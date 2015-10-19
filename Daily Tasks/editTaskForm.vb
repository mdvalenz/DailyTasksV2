Public Class editTaskForm

    Public Shared enteredDate As Date, estimatedTime As Integer, taskName, taskDescription As String
    Public Shared tag1Text, tag2Text, tag3Text As String
    Public Shared valueID, tag1ID, tag2ID, tag3ID As Integer
    Public Shared userLogin, userName As String
    Public Shared userID As Integer

    Private Sub editTaskForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)

        'Fill the Tag dropdown list from the database
        Call loadTagDatabase()

        'Fill the Department dropdown list from the database
        Call loadDepartmentDatabase()

        'Get login name and Place in header
        userLogin = Environment.UserName
        Call getUserName()
        nameTaskLabel.Text = userName

        Call resetForm()

        'Get Task information and fill out form
        Call getTaskInfo()

    End Sub

    Private Sub saveExitTaskButton_Click(sender As Object, e As EventArgs) Handles saveExitTaskButton.Click
        Call saveTaskRecord()
        If exitSub = False Then Close()
    End Sub

    Private Sub saveNewTaskButton_Click(sender As Object, e As EventArgs) Handles saveNewTaskButton.Click

        Call saveTaskRecord()

        If exitSub = False Then
            taskForm.Show()
            Me.Close()
        End If

    End Sub

    Dim exitSub As Boolean = False

    Private Sub saveTaskRecord()

        'Get Task information
        enteredDate = dateTaskPicker.Value

        'Check Estimated Minutes
        If estimatedTimeTaskTextBox.Text = "" Or estimatedTimeTaskTextBox.Text = "0" Then
            MsgBox("Please enter your estimated minutes.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        'Check Task Name
        If taskTaskTextBox.Text = "" Then
            MsgBox("Please enter the task name")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        'Check Tags
        If tag1TaskComboBox.Text = "* Select General Tag" Then
            MsgBox("Please select a general tag.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If tag2TaskComboBox.Text = "* Select Specific Tag" Then
            MsgBox("Please select a specific tag.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If tag3TaskComboBox.Text = "* Select Department" Then
            MsgBox("Please select a department.")
            exitSub = True
        Else
            exitSub = False
        End If
        If exitSub = True Then Exit Sub

        If exitSub = False Then

            'Get Task, Description, Minutes, Tags, and Department--------------------------------------
            estimatedTime = Convert.ToInt32(estimatedTimeTaskTextBox.Text)
            taskName = taskTaskTextBox.Text
            taskDescription = descriptionTaskTextBox.Text
            tag1Text = tag1TaskComboBox.Text
            tag2Text = tag2TaskComboBox.Text
            tag3Text = tag3TaskComboBox.Text

            'Connect to the task database
            Dim con As New OleDb.OleDbConnection
            Dim dbProvider As String
            Dim dbSource As String
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter
            Dim Sql As String

            'Provider to access the database and where the database is located
            dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
            dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

            con.ConnectionString = dbProvider & dbSource

            'Opening the database connection
            con.Open()

            'Search string to select all tasks from the taskTable
            Sql = "SELECT * FROM taskTable WHERE taskTable.[ID]=" & My.Settings.taskID

            'Send the search to the data adapter
            da = New OleDb.OleDbDataAdapter(Sql, con)

            'Tell the data adapter to fill the dataset
            da.Fill(ds, "Task")

            'Add edits to the dataset
            'Fill in Task Date
            'MsgBox(ds.Tables("Task").Rows(0).Item(1))
            ds.Tables("Task").Rows(0).Item(1) = dateTaskPicker.Value

            'Fill in Task Name
            'MsgBox(ds.Tables("Task").Rows(0).Item(2))
            ds.Tables("Task").Rows(0).Item(2) = taskTaskTextBox.Text

            'Fill in Task Description
            'MsgBox(ds.Tables("Task").Rows(0).Item(3))
            ds.Tables("Task").Rows(0).Item(3) = descriptionTaskTextBox.Text

            'Fill in Task Time
            'MsgBox(ds.Tables("Task").Rows(0).Item(4))
            ds.Tables("Task").Rows(0).Item(4) = estimatedTimeTaskTextBox.Text

            'Fill in Task Person
            'MsgBox(ds.Tables("Task").Rows(0).Item(5))
            ds.Tables("Task").Rows(0).Item(5) = nameTaskLabel.Text

            'Fill in Task Tag1
            'MsgBox(ds.Tables("Task").Rows(0).Item(6))
            ds.Tables("Task").Rows(0).Item(6) = tag1TaskComboBox.Text

            'Fill in Task Tag2
            'MsgBox(ds.Tables("Task").Rows(0).Item(7))
            ds.Tables("Task").Rows(0).Item(7) = tag2TaskComboBox.Text

            'Fill in Task Tag3
            'MsgBox(ds.Tables("Task").Rows(0).Item(8))
            ds.Tables("Task").Rows(0).Item(8) = tag3TaskComboBox.Text

            'Create a command builder to add edits to the database
            Dim cb As New OleDb.OleDbCommandBuilder(da)

            'Update the database using the data adapter
            da.Update(ds, "Task")

            'MsgBox("Database is now open")

            'Closing the database connection
            con.Close()

            'MsgBox("Database is now Closed")
            Call resetForm()
        End If

    End Sub

    Private Sub resetForm()

        'Clear the text boxs and set cursor
        dateTaskPicker.Value = Format(Today, "MM/dd/yy")
        estimatedTimeTaskTextBox.Text = ""

        taskTaskTextBox.Text = ""
        descriptionTaskTextBox.Text = ""

        tag1TaskComboBox.SelectedIndex = 0
        tag2TaskComboBox.SelectedIndex = 0
        tag3TaskComboBox.SelectedIndex = 0

        taskTaskTextBox.Focus()

    End Sub

    Private Sub getTaskInfo()

        'Get TaskID
        Dim taskID = My.Settings.taskID

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        Sql = "SELECT * FROM taskTable WHERE taskTable.[ID]=@taskID"

        'Send the search to the data adapter
        Dim cm As New OleDb.OleDbCommand(Sql, con)

        cm.Parameters.AddWithValue("@taskID", taskID)

        'Send the search to the data reader
        Dim dr As OleDb.OleDbDataReader = cm.ExecuteReader

        'Get the database information into the variables
        While dr.Read

            'Task Date
            dateTaskPicker.Value = dr("taskDate")

            'Task Person
            nameTaskLabel.Text = dr("taskPerson")

            'Task Name
            taskTaskTextBox.Text = dr("taskName")

            'Task Description
            descriptionTaskTextBox.Text = dr("taskDescription")

            'Estimated Task Time
            estimatedTimeTaskTextBox.Text = dr("taskTime")

            'General Task Tag
            tag1TaskComboBox.Text = dr("taskTag1")

            'Specific Task Tag
            tag2TaskComboBox.Text = dr("taskTag2")

            'Department Tag
            tag3TaskComboBox.Text = dr("taskTag3")

        End While

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()


    End Sub

    Private Sub loadTagDatabase()

        'Connect to the task database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string to select all tags from the tagTable
        Sql = "SELECT tagTable.[Tags] FROM tagTable ORDER by tagTable.[Tags]"

        Dim cm As New OleDb.OleDbCommand(Sql, con)

        'Send the search to the data reader
        Dim dr As OleDb.OleDbDataReader = cm.ExecuteReader

        'Get the database into the dropdown list
        tag1TaskComboBox.Items.Clear()
        tag2TaskComboBox.Items.Clear()
        While dr.Read
            tag1TaskComboBox.Items.Add(dr("Tags"))
            tag2TaskComboBox.Items.Add(dr("Tags"))
        End While

        'Add instructions to the dropdown list and set as default selection
        tag1TaskComboBox.Items.Insert(0, "* Select General Tag")
        tag1TaskComboBox.SelectedIndex = 0

        tag2TaskComboBox.Items.Insert(0, "* Select Specific Tag")
        tag2TaskComboBox.SelectedIndex = 0

        'Closing the database connection
        dr.Close()
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Private Sub loadDepartmentDatabase()

        'Connect to the task database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string to select all tags from the tagTable
        Sql = "SELECT departmentTable.[Departments] FROM departmentTable ORDER by departmentTable.[Departments]"
        Dim cm As New OleDb.OleDbCommand(Sql, con)

        'Send the search to the data reader
        Dim dr As OleDb.OleDbDataReader = cm.ExecuteReader

        'Get the database into the dropdown list
        tag3TaskComboBox.Items.Clear()
        While dr.Read
            tag3TaskComboBox.Items.Add(dr("Departments"))
        End While

        'Add instructions to the dropdown list and set as default selection
        tag3TaskComboBox.Items.Insert(0, "* Select Department")
        tag3TaskComboBox.SelectedIndex = 0

        'Closing the database connection
        dr.Close()
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Private Sub getUserName()

        'Connect to the task database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string to select the full name of the logged in user
        Sql = "SELECT userTable.[FullName] FROM userTable where userTable.[LoginID]=@userLogin"
        Dim cm As New OleDb.OleDbCommand(Sql, con)
        cm.Parameters.AddWithValue("@userLogin", userLogin)

        'Send the search to the data reader
        Dim dr As OleDb.OleDbDataReader = cm.ExecuteReader

        While dr.Read
            userName = dr.Item(0).ToString 'needed for assigning people to the task
        End While

        'MsgBox("Database is now open")

        'Closing the database connection
        dr.Close()
        con.Close()

    End Sub

    Private Sub estimatedTimeTaskTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles estimatedTimeTaskTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter whole numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub newTagTaskButton_Click(sender As Object, e As EventArgs) Handles newTagTaskButton.Click
        tagForm.ShowDialog()
        tag1TaskComboBox.Items.Clear()
        tag2TaskComboBox.Items.Clear()
        Call loadTagDatabase()
    End Sub
End Class