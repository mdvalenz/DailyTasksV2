Imports Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop
Imports System.Globalization
Imports System.Xml

Public Class mainForm

    Public Shared userLogin, userName As String
    Public Shared lastMonth As Integer

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Daily_TasksDataSet.departmentTable' table. You can move, or remove it, as needed.
        Me.DepartmentTableTableAdapter.Fill(Me.Daily_TasksDataSet.departmentTable)

        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)
        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)
        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)

        'Fill in Month
        lastMonth = (Month(Today) - 1)

        Select Case lastMonth
            Case 1
                monthMainComboBox.Text = "January"
            Case 2
                monthMainComboBox.Text = "February"
            Case 3
                monthMainComboBox.Text = "March"
            Case 4
                monthMainComboBox.Text = "April"
            Case 5
                monthMainComboBox.Text = "May"
            Case 6
                monthMainComboBox.Text = "June"
            Case 7
                monthMainComboBox.Text = "July"
            Case 8
                monthMainComboBox.Text = "August"
            Case 9
                monthMainComboBox.Text = "September"
            Case 10
                monthMainComboBox.Text = "October"
            Case 11
                monthMainComboBox.Text = "November"
            Case 12
                monthMainComboBox.Text = "December"
        End Select

        'Fill the User dropdown list from the database
        Call loadUserDatabase()

        'Fill the Tag dropdown list from the database
        Call loadTagDatabase()

        'Fill the Department dropdown list from the database
        Call loadDepartmentDatabase()

        'Fill DataGridView with todays tasks from logged in person
        Call loadDefaultData()

        nameMainComboBox.Text = userName

        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.userTable' table. You can move, or remove it, as needed.
        'Me.UserTableTableAdapter.Fill(Me.Daily_TasksDataSet.userTable)
        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)
        ''TODO: This line of code loads data into the 'Daily_TasksDataSet.tagTable' table. You can move, or remove it, as needed.
        'Me.TagTableTableAdapter.Fill(Me.Daily_TasksDataSet.tagTable)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'My.Settings.exitForm = "Menu"
        Me.Close()
    End Sub

    Private Sub NewTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTaskToolStripMenuItem.Click
        taskForm.ShowDialog()
        Call searchMainUsers()
    End Sub

    Private Sub NewTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTagToolStripMenuItem.Click
        tagForm.ShowDialog()
        Call loadDefaultTags()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        userForm.ShowDialog()
        Call loadDefaultUsers()
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        settingsForm.Show()
    End Sub

    Private Sub newTaskMainButton_Click(sender As Object, e As EventArgs) Handles newTaskMainButton.Click
        taskForm.ShowDialog()
        Call searchMainUsers()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click

        nameMainComboBox.Text = userName
        startDateTimeMainPicker.Value = Today
        endDateTimeMainPicker.Value = Today
        tag1MainComboBox.SelectedIndex = 0

        Call loadDefaultTasks()

    End Sub

    Private Sub newTagMainTagButton_Click(sender As Object, e As EventArgs) Handles newTagMainTagButton.Click
        tagForm.ShowDialog()
        Call loadDefaultTags()
    End Sub

    Private Sub refreshMainTagButton_Click(sender As Object, e As EventArgs) Handles refreshMainTagButton.Click
        tagSearchMainTagTextBox.Text = ""
        Call loadDefaultTags()
    End Sub

    Private Sub refreshDepartmentButton_Click(sender As Object, e As EventArgs) Handles refreshDepartmentButton.Click
        departmentSearchDepartmentTextBox.Text = ""
        Call loadDefaultDepartments()
    End Sub

    Private Sub newDepartmentButton_Click(sender As Object, e As EventArgs) Handles newDepartmentButton.Click
        departmentForm.ShowDialog()
        Call loadDefaultDepartments()
    End Sub

    Private Sub newUserUsersButton_Click(sender As Object, e As EventArgs) Handles newUserUsersButton.Click
        userForm.ShowDialog()
        Call loadDefaultUsers()
    End Sub

    Private Sub refreshUsersButton_Click(sender As Object, e As EventArgs) Handles refreshUsersButton.Click
        userSearchUsersTextBox.Text = ""
        Call loadDefaultUsers()
    End Sub

    Private Sub NewTaskToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTaskToolStripMenuItem1.Click
        taskForm.ShowDialog()
        Call searchMainUsers()
    End Sub

    Private Sub NewTagToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTagToolStripMenuItem1.Click
        tagForm.ShowDialog()
        Call loadDefaultTags()
    End Sub

    Private Sub MonthlyEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyEmailToolStripMenuItem.Click
        Call createEmail()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        'My.Settings.exitForm = "Tray"
        Me.Close()
    End Sub

    Private Sub NewUserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem1.Click
        userForm.ShowDialog()
        Call loadDefaultUsers()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub NewDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDepartmentToolStripMenuItem.Click
        departmentForm.ShowDialog()
        Call loadDefaultDepartments()
    End Sub

    Private Sub NewDepartmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewDepartmentToolStripMenuItem1.Click
        departmentForm.ShowDialog()
        Call loadDefaultDepartments()
    End Sub

    Private Sub loadDefaultData()

        Call loadDefaultTasks()
        Call loadDefaultTags()
        Call loadDefaultDepartments()
        Call loadDefaultUsers()

    End Sub

    Private Sub loadUserDatabase()

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
        Sql = "SELECT userTable.[FullName] FROM userTable ORDER by userTable.[FullName]"
        Dim cm As New OleDb.OleDbCommand(Sql, con)

        'Send the search to the data reader
        Dim dr As OleDb.OleDbDataReader = cm.ExecuteReader

        'Get the database into the dropdown list
        While dr.Read
            nameMainComboBox.Items.Add(dr("FullName"))
        End While

        'Add instructions to the dropdown list and set as default selection
        nameMainComboBox.Items.Insert(0, "Select User Name")
        nameMainComboBox.SelectedIndex = 0

        'Closing the database connection
        dr.Close()
        con.Close()

        'MsgBox("Database is now Closed")

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
        tag1MainComboBox.Items.Clear()
        While dr.Read
            tag1MainComboBox.Items.Add(dr("Tags"))
        End While

        'Add instructions to the dropdown list and set as default selection
        tag1MainComboBox.Items.Insert(0, "Select Tag")
        tag1MainComboBox.SelectedIndex = 0

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
        While dr.Read
            departmentMainComboBox.Items.Add(dr("Departments"))
        End While

        'Add instructions to the dropdown list and set as default selection
        departmentMainComboBox.Items.Insert(0, "Select Department")
        departmentMainComboBox.SelectedIndex = 0

        'Closing the database connection
        dr.Close()
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Private Sub loadDefaultTasks()

        'Get user
        Dim selectedName = nameMainComboBox.Text
        Dim dateToday = Date.Today

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim dc As OleDb.OleDbCommand
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        'only show tasks from selected user
        userLogin = Environment.UserName
        Call getUserName()

        Sql = "SELECT * FROM taskTable WHERE taskTable.[taskPerson]=@userName AND taskTable.[taskDate]=@dateToday ORDER by taskTable.[taskTag1]"

        'Send the search to the data adapter
        dc = New OleDb.OleDbCommand(Sql, con)

        dc.Parameters.AddWithValue("@userName", userName)
        dc.Parameters.AddWithValue("@dateToday", dateToday)
        da.SelectCommand = dc

        'Tell the data adapter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView1.DataSource = bs
        Me.DataGridView1.Columns("ID").Visible = False

        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID"
            '.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Value = "Date"
            .Columns(1).Width = 100
            '.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Value = "Task"
            .Columns(2).Width = 300
            '.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Value = "Description"
            .Columns(3).Width = 300
            '.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            '.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Value = "Time Spent"
            .Columns(4).Width = 100
            '.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Value = "Person"
            .Columns(5).Width = 200
            '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Value = "General Tag"
            .Columns(6).Width = 200
            '.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).HeaderCell.Value = "Specific Tag"
            .Columns(7).Width = 200
            '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).HeaderCell.Value = "Department Tag"
            .Columns(8).Width = 200
            '.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")
        Call calculateTotalTime()

    End Sub

    Private Sub loadDefaultTags()

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        Sql = "SELECT tagTable.[Tags] FROM tagTable ORDER by tagTable.[Tags]"

        'Send the search to the data adapter
        da = New OleDb.OleDbDataAdapter(Sql, con)

        'Tell the data adapeter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView2.DataSource = bs
        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Private Sub loadDefaultDepartments()

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        Sql = "SELECT departmentTable.[Departments] FROM departmentTable ORDER by departmentTable.[Departments]"

        'Send the search to the data adapter
        da = New OleDb.OleDbDataAdapter(Sql, con)

        'Tell the data adapeter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView4.DataSource = bs
        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Private Sub loadDefaultUsers()

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        Sql = "SELECT userTable.[FullName], userTable.[LoginID], userTable.[Email] FROM userTable ORDER by userTable.[FullName]"

        'Send the search to the data adapter
        da = New OleDb.OleDbDataAdapter(Sql, con)

        'Tell the data adapeter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView3.DataSource = bs

        With DataGridView3
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Full Name"
            '.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Value = "Login ID"
            '.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Value = "Email"
            '.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
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

    Private Sub searchMainButton_Click(sender As Object, e As EventArgs) Handles searchMainButton.Click
        Call searchMainUsers()
    End Sub

    Dim selectedName As String = Nothing
    Dim selectedTag As String = Nothing
    Dim selectedDepartment As String = Nothing

    Private Sub searchMainUsers()

        'Get selections
        selectedName = nameMainComboBox.Text
        selectedTag = tag1MainComboBox.Text
        selectedDepartment = departmentMainComboBox.Text
        Dim selectedStartDate = Format(startDateTimeMainPicker.Value, "M/d/yyyy")
        Dim selectedEndDate = Format(endDateTimeMainPicker.Value, "M/d/yyyy")

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim dc As OleDb.OleDbCommand
        Dim Sql As String

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        'only show tasks from selected user, all users if not selected
        If selectedName = "Select User Name" Then
            Sql = "SELECT * FROM taskTable WHERE"
        Else
            Sql = "SELECT * FROM taskTable WHERE (taskTable.[taskPerson]=@selectedName) AND "
        End If

        'Show tasks between selected dates
        Sql = Sql & "(taskTable.[taskDate] BETWEEN @selectedStartDate and @selectedEndDate) "

        'only show tasks with selected tag, all tags if not selected
        If selectedTag = "Select Tag" Then
        Else
            Sql = Sql & "AND (taskTable.[taskTag1]=@selectedTag OR taskTable.[taskTag2]=@selectedTag)"
        End If

        'only show tasks with selected department, all departments if not selected
        If selectedDepartment = "Select Department" Then
        Else
            Sql = Sql & "AND (taskTable.[taskTag3]=@selectedDepartment)"
        End If

        'Sort by Date
        Sql = Sql & " ORDER by taskTable.[taskDate]"

        'Send the search to the data adapter
        dc = New OleDb.OleDbCommand(Sql, con)

        If selectedName = "Select User Name" Then
        Else
            dc.Parameters.AddWithValue("@selectedName", selectedName)
        End If

        dc.Parameters.AddWithValue("@selectedStartDate", selectedStartDate)
        dc.Parameters.AddWithValue("@selectedEndDate", selectedEndDate)

        If selectedTag = "Select Tag" Then
        Else
            dc.Parameters.AddWithValue("@selectedTag", selectedTag)
        End If

        If selectedDepartment = "Select Department" Then
        Else
            dc.Parameters.AddWithValue("@selectedDepartment", selectedDepartment)
        End If

        da.SelectCommand = dc

        'Tell the data adapeter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView1.DataSource = bs
        Me.DataGridView1.Columns("ID").Visible = False

        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")
        Call calculateTotalTime()

    End Sub

    Private Sub searchMainTagButton_Click(sender As Object, e As EventArgs) Handles searchMainTagButton.Click

        'Get search string
        Dim searchString = tagSearchMainTagTextBox.Text

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim dc As OleDb.OleDbCommand
        Dim Sql As String
        Dim buildString As String = ""

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        'only show tags that match search, all tags if blank
        If searchString = "" Then
            Sql = "SELECT tagTable.[Tags] FROM tagTable ORDER by tagTable.[Tags]"
        Else
            Sql = "SELECT tagTable.[Tags] FROM tagTable WHERE tagTable.[Tags] LIKE @searchString ORDER by tagTable.[Tags]"
        End If

        'Send the search to the data adapter
        dc = New OleDb.OleDbCommand(Sql, con)

        dc.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
        da.SelectCommand = dc

        'Tell the data adapter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView2.DataSource = bs
        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")
    End Sub

    Private Sub searchDepartmentButton_Click(sender As Object, e As EventArgs) Handles searchDepartmentButton.Click

        'Get search string
        Dim searchString = departmentSearchDepartmentTextBox.Text

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim dc As OleDb.OleDbCommand
        Dim Sql As String
        Dim buildString As String = ""

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        'only show tags that match search, all tags if blank
        If searchString = "" Then
            Sql = "SELECT departmentTable.[Departments] FROM departmentTable ORDER by departmentTable.[Departments]"
        Else
            Sql = "SELECT departmentTable.[Departments] FROM departmentTable WHERE departmentTable.[Departments] LIKE @searchString ORDER by departmentTable.[Departments]"
        End If

        'Send the search to the data adapter
        dc = New OleDb.OleDbCommand(Sql, con)

        dc.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
        da.SelectCommand = dc

        'Tell the data adapter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView4.DataSource = bs
        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")
    End Sub

    Private Sub searchUsersButton_Click_1(sender As Object, e As EventArgs) Handles searchUsersButton.Click
        Call searchUsers()
    End Sub

    Private Sub searchUsers()

        'Get search string
        Dim searchString = userSearchUsersTextBox.Text

        'Connect to the database
        Dim con As New OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSource As String
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim bs As New BindingSource
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter
        Dim dc As OleDb.OleDbCommand
        Dim Sql As String
        Dim buildString As String = ""

        'Provider to access the database and where the database is located
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        dbSource = "Data Source = " & My.Settings.DBLocation 'F:\QA\Daily Tasks\Database\DailyTasks.accdb"

        con.ConnectionString = dbProvider & dbSource

        'Opening the database connection
        con.Open()

        'Search string
        'only show users that match search, all users if blank
        If searchString = "" Then
            Sql = "SELECT userTable.[FullName], userTable.[LoginID], userTable.[Email] FROM userTable ORDER by userTable.[FullName]"
        Else
            Sql = "SELECT userTable.[FullName], userTable.[LoginID], userTable.[Email] FROM userTable WHERE userTable.[FullName] LIKE @searchString ORDER by userTable.[FullName]"
        End If

        'Send the search to the data adapter
        dc = New OleDb.OleDbCommand(Sql, con)

        dc.Parameters.AddWithValue("@searchString", "%" & searchString & "%")
        da.SelectCommand = dc

        'Tell the data adapeter to fill the dataset
        da.Fill(dt)
        bs.DataSource = dt
        DataGridView3.DataSource = bs
        da.Update(dt)

        'MsgBox("Database is now open")

        'Closing the database connection
        con.Close()

        'MsgBox("Database is now Closed")

    End Sub

    Dim filePrefix, fileName As String

    Private Sub emailMainButton_Click(sender As Object, e As EventArgs) Handles emailMainButton.Click
        Call createEmail()
    End Sub

    Private Sub createEmail()

        'Clear Tag
        tag1MainComboBox.SelectedIndex = 0

        'Clear Department
        departmentMainComboBox.SelectedIndex = 0

        'Get userName if not selected
        If nameMainComboBox.Text = "Select User Name" Then nameMainComboBox.Text = userName
        fileName = nameMainComboBox.Text

        'Get the month
        Dim selectedMonth As Integer = Nothing
        Select Case monthMainComboBox.Text
            Case "January"
                selectedMonth = 1
            Case "February"
                selectedMonth = 2
            Case "March"
                selectedMonth = 3
            Case "April"
                selectedMonth = 4
            Case "May"
                selectedMonth = 5
            Case "June"
                selectedMonth = 6
            Case "July"
                selectedMonth = 7
            Case "August"
                selectedMonth = 8
            Case "September"
                selectedMonth = 9
            Case "October"
                selectedMonth = 10
            Case "November"
                selectedMonth = 11
            Case "December"
                selectedMonth = 12
        End Select

        Select Case selectedMonth
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
                startDateTimeMainPicker.Value = DateSerial(Today.Year, selectedMonth, 1)
                filePrefix = Format(startDateTimeMainPicker.Value, "yyyy-MM")
                endDateTimeMainPicker.Value = DateSerial(Today.Year, selectedMonth + 1, 0)
            Case 12
                startDateTimeMainPicker.Value = DateSerial(Today.Year - 1, selectedMonth, 1)
                endDateTimeMainPicker.Value = DateSerial(Today.Year - 1, selectedMonth + 1, 0)
        End Select

        ProgressBar.exportProgressBar.Maximum = 100
        ProgressBar.exportProgressBar.Value = 0
        ProgressBar.Show()

        Call searchMainUsers()

        Call exportMonthlyTaskList()
        ProgressBar.exportProgressBar.Value = 100
        ProgressBar.Update()
        ProgressBar.Show()

        Call emailMonthlyTaskList()
        ProgressBar.Show()
        ProgressBar.Close()

    End Sub

    Private Sub emailMonthlyTaskList()

        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application

        Dim objNS As outlook._NameSpace = AppOutlook.Session
        Dim objFolder As outlook.MAPIFolder
        objFolder = objNS.GetDefaultFolder(outlook.OlDefaultFolders.olFolderDrafts)

        'Get recipients
        Dim recipients As String = Nothing
        Dim supervisor As String = Nothing
        Select Case nameMainComboBox.Text
            Case "Bob Takens"
                supervisor = "Bob"
                recipients = "Bob Takens"
            Case "Mario Valenzuela"
                supervisor = "Bob"
                recipients = "Bob Takens"
            Case "Christine Willmore"
                supervisor = "Bob and Mario"
                recipients = "Bob Takens; Mario Valenzuela"
        End Select

        'Create subject
        Dim subject As String = Nothing
        subject = selectedName & "'s Daily Tasks for " & monthMainComboBox.Text

        'Create HTML Body
        Dim MsgTxt As String = Nothing
        MsgTxt = MsgTxt & _
        "<p>Hello " & supervisor & ",</p>" & _
        "<p>Here are my daily tasks for " & monthMainComboBox.Text & "." & _
        "<br>Please use the included link if you would like more information.</p>"

        'Include link to the HTML file

        'Replace spaces with %20
        Dim urlstring As String = Nothing
        Do While InStr(HTMLFilePath, " ") > 0 'Replace spaces with %20
            urlstring = Mid(HTMLFilePath, 1, InStr(HTMLFilePath, " ") - 1) 'Portion before the space
            urlstring = urlstring & "%20"
            urlstring = urlstring & Mid(HTMLFilePath, InStr(HTMLFilePath, " ") + 1, Len(HTMLFilePath)) 'Portion after the space
            HTMLFilePath = urlstring
        Loop

        MsgTxt = MsgTxt & _
        "<p><strong><A HREF=file://" & HTMLFilePath & ">" & subject & "</A></td></strong></p>"

        'Closing
        MsgTxt = MsgTxt & _
        "<p>Thank you," & _
        "<br><br>     " & nameMainComboBox.Text

        ''Signature location for sending via Document Control
        'Dim sigstring As String = Nothing
        'SigString = Environ("appdata") & "\Microsoft\Signatures\Formal.htm"

        ''Set variables for the signature
        'Dim fso As Object = Nothing
        'Dim ts As Object = Nothing
        'Dim vsignature As Object = Nothing

        'fso = CreateObject("Scripting.FileSystemObject")
        'ts = fso.GetFile(SigString).OpenAsTextStream(1, -2)
        'vsignature = ts.readall

        Try
            OutlookMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
            Dim Recipents As Outlook.Recipients = OutlookMessage.Recipients
            Recipents.Add(recipients)
            OutlookMessage.Subject = subject
            OutlookMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
            OutlookMessage.HTMLBody = "<html><body>" & MsgTxt & "</body></html>"
            'OutlookMessage.Save()
            OutlookMessage.Display()
            'OutlookMessage.Move(objFolder)
        Catch ex As Exception
            MessageBox.Show("Mail could not be sent") 'if you dont want this message, simply delete this line    
        Finally
            OutlookMessage = Nothing
            AppOutlook = Nothing
        End Try


    End Sub

    Private Sub exportMonthlyTaskList()

        'Pull information from the datagridview and put into email or Excel
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To DataGridView1.RowCount - 1

            Dim progressBarValue As Integer = ((i / (DataGridView1.RowCount - 1)) / 2) * 100
            ProgressBar.exportProgressBar.Value = progressBarValue
            ProgressBar.Update()
            ProgressBar.Show()

            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ExportFilePath = "F:\QA\Daily Tasks\Excel\" & filePrefix & " " & fileName & " Daily Tasks.xlsx"
        xlWorkSheet.SaveAs(ExportFilePath)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        'Open Export File
        OpenExcel(ExportFilePath, "Sheet1")

        'MsgBox("You can find the file")

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Dim Openfilename As String
    Dim LastRow As Integer

    'Dimension Arrays
    Dim ExportArray(8, 0) As String

    'Other file locations
    Dim ExportFilePath As String = Nothing
    Dim HTMLString As String = Nothing
    Dim HTMLFilePath As String = Nothing
    Dim myRange As Excel.Range

    Public Sub OpenExcel(ByVal FileName As String, ByVal SheetName As String)
        If IO.File.Exists(FileName) Then
            Dim Proceed As Boolean = False
            Dim xlApp As Microsoft.Office.Interop.Excel.Application = Nothing
            Dim xlWorkBooks As Microsoft.Office.Interop.Excel.Workbooks = Nothing
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = Nothing
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
            Dim xlWorkSheets As Microsoft.Office.Interop.Excel.Sheets = Nothing
            Dim xlCells As Microsoft.Office.Interop.Excel.Range = Nothing
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(FileName)
            xlApp.Visible = False
            xlApp.ScreenUpdating = False
            xlWorkSheets = xlWorkBook.Sheets
            For x As Integer = 1 To xlWorkSheets.Count
                xlWorkSheet = CType(xlWorkSheets(x), Microsoft.Office.Interop.Excel.Worksheet)
                If xlWorkSheet.Name = SheetName Then
                    Console.WriteLine(SheetName)
                    Proceed = True
                    Exit For
                End If
                Runtime.InteropServices.Marshal.FinalReleaseComObject(xlWorkSheet)
                xlWorkSheet = Nothing
            Next
            If Proceed Then
                xlWorkSheet.Activate()
                Openfilename = xlWorkBook.Name

                With xlWorkSheet

                    'Fit and filter
                    LastRow = .Range("A" & .Rows.Count).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row

                    If Not .AutoFilterMode Then 'Figure out best way to filter-----------------------
                        .Range("A1:I" & LastRow).AutoFilter(Field:=2)

                        myRange = xlWorkSheet.Range("A2", "I" & LastRow)
                        myRange.Select()

                        myRange.Sort(Key1:=myRange.Range("B1"), _
                                                Order1:=Excel.XlSortOrder.xlAscending, _
                                                Orientation:=Excel.XlSortOrientation.xlSortColumns)
                    End If

                    .Columns.AutoFit()
                    xlApp.Visible = True
                    xlApp.ScreenUpdating = True
                    xlWorkBook.Save()

                    xlApp.Visible = False
                    xlApp.ScreenUpdating = False

                    'Create Arrays
                    ReDim ExportArray(8, LastRow)
                    Dim generalTagArray(3, 0) As String
                    Dim specificTagArray(3, 0) As String
                    Dim taskArray(2, 0) As String

                    Dim Present As Integer = Nothing
                    Dim generalCount As Integer = 0
                    Dim specificCount As Integer = 0
                    Dim taskCount As Integer = 0

                    'Work through worksheet and create HTML file

                    'Start HTML string
                    'Header
                    HTMLString = "<html lang=""en-GB"">" & _
                                    "<head>" & _
                                    "<meta http-equiv=""Content-Type"" content=""text/html;charset=utf-8"">" & _
                                    "<meta name=""author"" content=""The CSS Ninja"">" & _
                                    "<meta name=""keywords"" content=""CSS, Tree menu, checked pseudo-class, CSS Ninja"">" & _
                                    "<meta name=""description"" content=""Create a pure CSS tree folder structure with collapsible folders utilizing checkboxes along with the checked pseudo-class"">" & _
                                    "<meta name=""robots"" content=""all"">" & _
                                    "<meta name=""copyright"" content=""The CSS Ninja"">" & _
                                    "<!--[if gte IE 9 ]><link rel=""stylesheet"" type=""text/css"" href=""F:\QA\Daily Tasks\HTML\_styles.css"" media=""screen""><![endif]-->" & _
                                    "<!--[if !IE]>--><link rel=""stylesheet"" type=""text/css"" href=""F:\QA\Daily Tasks\HTML\_styles.css"" media=""screen""><!--<![endif]-->" & _
                                    "<title>" & selectedName & "'s Daily Tasks for " & monthMainComboBox.Text & "</title>" & _
                                    "</head>"

                    'Start HTML Body
                    HTMLString = HTMLString & _
                                "<body>" & _
                                selectedName & "'s Daily Tasks for " & monthMainComboBox.Text & _
                                "<ol class=""tree"">" & _
                                "<li>"

                    'Get General Tags, number of items, and total minutes
                    'Sort alpha
                    myRange.Select()
                    myRange.Sort(Key1:=myRange.Range("G1"), _
                                            Order1:=Excel.XlSortOrder.xlAscending, _
                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                    For RowNumGen = 2 To LastRow

                        If .Range("A" & RowNumGen).Text = "" Then Exit For
                        Present = 0

                        For checkGeneralTags = 2 To generalTagArray.GetUpperBound(1)
                            If generalTagArray(1, checkGeneralTags) = .Range("G" & RowNumGen).Value Then
                                generalTagArray(2, checkGeneralTags) = generalTagArray(2, checkGeneralTags) + 1
                                generalTagArray(3, checkGeneralTags) = generalTagArray(3, checkGeneralTags) + .Range("E" & RowNumGen).Value
                                Present = 1
                                Exit For
                            End If
                        Next

                        If Present = 0 Then
                            ReDim Preserve generalTagArray(3, RowNumGen)
                            generalTagArray(1, RowNumGen) = .Range("G" & RowNumGen).Value
                            generalTagArray(2, RowNumGen) = 1
                            generalTagArray(3, RowNumGen) = .Range("E" & RowNumGen).Value
                        End If

                    Next

                    'Filter by each General Tag
                    For generalTagCount = 2 To generalTagArray.GetUpperBound(1)

                        Dim progressBarValue As Integer = ((generalTagCount / generalTagArray.GetUpperBound(1)) / 2) * 100 + 50
                        ProgressBar.exportProgressBar.Value = progressBarValue
                        ProgressBar.Update()
                        ProgressBar.Show()

                        On Error Resume Next 'in case no dropdown arrows/filters are on the current sheet
                        .ShowAllData()
                        On Error GoTo 0

                        Dim generalTask As String = generalTagArray(1, generalTagCount)
                        'MessageBox.Show(generalTagArray(1, generalTagCount))

                        If generalTask <> "" Then

                            .Range("A1:I" & LastRow).AutoFilter(Field:=7, Criteria1:=generalTask)
                            generalCount = generalCount + 1

                            'Add General Tag to HTML String
                            Dim generalTime As String = Nothing
                            Dim generalTimeUnit As String = Nothing
                            If generalTagArray(3, generalTagCount) > 60 Then
                                generalTime = Format(generalTagArray(3, generalTagCount) / 60, "0.0")
                                generalTimeUnit = "hours"
                            Else
                                generalTime = generalTagArray(3, generalTagCount)
                                generalTimeUnit = "minutes"
                            End If

                            HTMLString = HTMLString & _
                                        "<label for=""generalTag" & generalCount & """>" & generalTagArray(1, generalTagCount) & _
                                        " [" & generalTagArray(2, generalTagCount) & " items]" & _
                                        "[" & generalTime & " " & generalTimeUnit & "]" & _
                                        "</label> <input type=""checkbox"" id=""generalTag" & generalCount & """ />" & _
                                        "<ol>" & _
                                        "<li>"

                            'Get Specific Tags, number of items, and total time
                            ReDim specificTagArray(3, 0)

                            'Sort alpha
                            myRange.Select()
                            myRange.Sort(Key1:=myRange.Range("H1"), _
                                                    Order1:=Excel.XlSortOrder.xlAscending, _
                                                    Orientation:=Excel.XlSortOrientation.xlSortColumns)

                            For RowNumSpec = 2 To LastRow
                                If .Range("A" & RowNumSpec).Text = "" Then Exit For
                                Present = 0


                                If .Range("A" & RowNumSpec).Height <> 0 Then
                                    For checkSpecificTags = 2 To specificTagArray.GetUpperBound(1)
                                        If specificTagArray(1, checkSpecificTags) = .Range("H" & RowNumSpec).Value Then
                                            specificTagArray(2, checkSpecificTags) = specificTagArray(2, checkSpecificTags) + 1
                                            specificTagArray(3, checkSpecificTags) = specificTagArray(3, checkSpecificTags) + .Range("E" & RowNumSpec).Value
                                            Present = 1
                                            Exit For
                                        End If
                                    Next

                                    If Present = 0 Then
                                        ReDim Preserve specificTagArray(3, RowNumSpec)
                                        specificTagArray(1, RowNumSpec) = .Range("H" & RowNumSpec).Value
                                        specificTagArray(2, RowNumSpec) = 1
                                        specificTagArray(3, RowNumSpec) = .Range("E" & RowNumSpec).Value
                                    End If
                                End If
                            Next

                            'Filter by each Specific Tag
                            For specificTagCount = 2 To specificTagArray.GetUpperBound(1)
                                Dim specificTask As String = specificTagArray(1, specificTagCount)
                                'MessageBox.Show(specificTagArray(1, specificTagCount))

                                If specificTask <> "" Then

                                    .Range("A1:I" & LastRow).AutoFilter(Field:=8, Criteria1:=specificTask)
                                    specificCount = specificCount + 1

                                    'Add Specific Tag to HTML String
                                    Dim specificTime As String = Nothing
                                    Dim specificTimeUnit As String = Nothing
                                    If specificTagArray(3, specificTagCount) > 60 Then
                                        specificTime = Format(specificTagArray(3, specificTagCount) / 60, "0.0")
                                        specificTimeUnit = "hours"
                                    Else
                                        specificTime = specificTagArray(3, specificTagCount)
                                        specificTimeUnit = "minutes"
                                    End If

                                    HTMLString = HTMLString & _
                                                "<label for=""specificTag" & specificCount & """>" & specificTagArray(1, specificTagCount) & _
                                                " [" & specificTagArray(2, specificTagCount) & " items]" & _
                                                "[" & specificTime & " " & specificTimeUnit & "]" & _
                                                "</label> <input type=""checkbox"" id=""specificTag" & specificCount & """ />" & _
                                                "<ol>" & _
                                                "<li>"

                                    'Get Task Names and times
                                    ReDim taskArray(2, 0)

                                    'Sort by date
                                    myRange.Select()
                                    myRange.Sort(Key1:=myRange.Range("B1"), _
                                                            Order1:=Excel.XlSortOrder.xlAscending, _
                                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                                    For RowNumtTask = 2 To LastRow
                                        If .Range("A" & RowNumtTask).Text = "" Then Exit For

                                        If .Range("A" & RowNumtTask).Height <> 0 Then

                                            ReDim Preserve taskArray(2, RowNumtTask)
                                            taskArray(0, RowNumtTask) = Format(.Range("B" & RowNumtTask).Value, "MM/dd")
                                            taskArray(1, RowNumtTask) = .Range("C" & RowNumtTask).Value
                                            taskArray(2, RowNumtTask) = .Range("E" & RowNumtTask).Value

                                            If taskArray(1, RowNumtTask) <> "" Then
                                                taskCount = taskCount + 1

                                                'Put Tasks in HTML String
                                                Dim taskTime As String = Nothing
                                                Dim taskTimeUnit As String = Nothing
                                                If taskArray(2, RowNumtTask) > 60 Then
                                                    taskTime = Format(taskArray(2, RowNumtTask) / 60, "0.0")
                                                    taskTimeUnit = "hours"
                                                Else
                                                    taskTime = taskArray(2, RowNumtTask)
                                                    taskTimeUnit = "minutes"
                                                End If

                                                HTMLString = HTMLString & _
                                                            "<label for=""task" & taskCount & """>" & taskArray(0, RowNumtTask) & " - " & _
                                                            taskArray(1, RowNumtTask) & " [" & taskTime & " " & taskTimeUnit & "]" & _
                                                            "</label> <input type=""checkbox"" id=""task" & taskCount & """ />"
                                            End If
                                        End If
                                    Next

                                    'Close Tasks and Specific Tag in HTML String
                                    HTMLString = HTMLString & _
                                                "</li>" & _
                                                "</ol>"
                                End If
                            Next

                            'Close General Tag in HTML String
                            HTMLString = HTMLString & _
                                            "</li>" & _
                                            "</ol>"
                        End If
                    Next

                    'Close Tree in HTML String
                    HTMLString = HTMLString & _
                                    "</li>" & _
                                    "</ol>"

                    'Close Body and HTML in HTML String
                    HTMLString = HTMLString & _
                                    "</body>" & _
                                    "</html>"

                    'Write HTML String to file
                    HTMLFilePath = "F:\QA\Daily Tasks\HTML\" & filePrefix & " " & selectedName & "'s Daily Tasks.html"
                    IO.File.WriteAllText(HTMLFilePath, HTMLString)

                    'Close Export File without saving
                    On Error Resume Next 'in case no dropdown arrows/filters are on the current sheet
                    .ShowAllData()
                    On Error GoTo 0

                    'Sort alpha
                    myRange.Select()
                    myRange.Sort(Key1:=myRange.Range("B1"), _
                                            Order1:=Excel.XlSortOrder.xlAscending, _
                                            Orientation:=Excel.XlSortOrientation.xlSortColumns)

                    xlApp.Visible = True
                    xlApp.ScreenUpdating = True
                    xlWorkBook.Close(SaveChanges:=True)
                    xlApp.UserControl = True
                    xlApp.Quit()

                    ReleaseComObject(xlCells)
                    ReleaseComObject(xlWorkSheets)
                    ReleaseComObject(xlWorkSheet)
                    ReleaseComObject(xlWorkBook)
                    ReleaseComObject(xlWorkBooks)
                    ReleaseComObject(xlApp)
                End With

                'Kill Export and Batch Files              
                'System.IO.File.Delete(ExportFilePath)

                'MessageBox.Show("File is open, if you close Excel just opened outside of this program we will crash-n-burn.")
            Else
                MessageBox.Show(SheetName & " not found.")
            End If

        Else
            MessageBox.Show("'" & FileName & "' not located. Try one of the write examples first.")
        End If
    End Sub

    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub

    Private oStringFormat As StringFormat
    Private oStringFormatComboBox As StringFormat
    Private oButton As Button
    Private oCheckbox As Windows.Forms.CheckBox
    Private oComboBox As Windows.Forms.ComboBox
    Private nTotalWidth As Int16
    Private nRowPos As Int16
    Private NewPage As Boolean
    Private nPageNo As Int16
    Private Header As String = "Task List"
    Private sUserName As String = userName
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        oStringFormat = New StringFormat
        oStringFormat.Alignment = StringAlignment.Near
        oStringFormat.LineAlignment = StringAlignment.Center
        oStringFormat.Trimming = StringTrimming.EllipsisCharacter
        oStringFormatComboBox = New StringFormat
        oStringFormatComboBox.LineAlignment = StringAlignment.Center
        oStringFormatComboBox.FormatFlags = StringFormatFlags.NoWrap
        oStringFormatComboBox.Trimming = StringTrimming.EllipsisCharacter
        oButton = New Button
        oCheckbox = New Windows.Forms.CheckBox
        oComboBox = New Windows.Forms.ComboBox
        nTotalWidth = 0
        For Each oColumn As DataGridViewColumn In DataGridView1.Columns
            nTotalWidth += oColumn.Width
        Next
        nPageNo = 1
        NewPage = True
        nRowPos = 0
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static oColumnLefts As New ArrayList
        Static oColumnWidths As New ArrayList
        Static oColumnTypes As New ArrayList
        Static nHeight As Int16
        Dim nWidth, i, nRowsPerPage As Int16
        Dim nTop As Int16 = e.MarginBounds.Top
        Dim nLeft As Int16 = e.MarginBounds.Left
        If nPageNo = 1 Then
            For Each oColumn As DataGridViewColumn In DataGridView1.Columns
                nWidth = CType(Math.Floor(oColumn.Width / nTotalWidth * nTotalWidth * (e.MarginBounds.Width / nTotalWidth)), Int16) + 10
                nHeight = e.Graphics.MeasureString(oColumn.HeaderText, oColumn.InheritedStyle.Font, nWidth).Height + 20
                oColumnLefts.Add(nLeft)
                oColumnWidths.Add(nWidth)
                oColumnTypes.Add(oColumn.GetType)
                nLeft += nWidth
            Next
        End If
        Do While nRowPos < DataGridView1.Rows.Count - 1
            Dim oRow As DataGridViewRow = DataGridView1.Rows(nRowPos)
            If nTop + nHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                DrawFooter(e, nRowsPerPage)
                NewPage = True
                nPageNo += 1
                e.HasMorePages = True
                Exit Sub
            Else
                If NewPage Then
                    ' Draw Header
                    e.Graphics.DrawString(Header, New Font(DataGridView1.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString(Header, New Font(DataGridView1.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)
                    ' Draw Columns
                    nTop = e.MarginBounds.Top
                    i = 0
                    For Each oColumn As DataGridViewColumn In DataGridView1.Columns
                        e.Graphics.FillRectangle(New SolidBrush(Drawing.Color.LightGray), New System.Drawing.Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawRectangle(Pens.Black, New System.Drawing.Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                        e.Graphics.DrawString(oColumn.HeaderText, oColumn.InheritedStyle.Font, New SolidBrush(oColumn.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                        i += 1
                    Next
                    NewPage = False
                End If
                nTop += nHeight
                i = 0
                For Each oCell As DataGridViewCell In oRow.Cells
                    If oColumnTypes(i) Is GetType(DataGridViewTextBoxColumn) OrElse oColumnTypes(i) Is GetType(DataGridViewLinkColumn) Then
                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i), nTop, oColumnWidths(i), nHeight), oStringFormat)
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewButtonColumn) Then
                        oButton.Text = oCell.Value.ToString
                        oButton.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oButton.Width, oButton.Height)
                        oButton.DrawToBitmap(oBitmap, New System.Drawing.Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewCheckBoxColumn) Then
                        oCheckbox.Size = New Size(14, 14)
                        oCheckbox.Checked = CType(oCell.Value, Boolean)
                        Dim oBitmap As New Bitmap(oColumnWidths(i), nHeight)
                        Dim oTempGraphics As Graphics = Graphics.FromImage(oBitmap)
                        oTempGraphics.FillRectangle(Brushes.White, New System.Drawing.Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        oCheckbox.DrawToBitmap(oBitmap, New System.Drawing.Rectangle(CType((oBitmap.Width - oCheckbox.Width) / 2, Int32), CType((oBitmap.Height - oCheckbox.Height) / 2, Int32), oCheckbox.Width, oCheckbox.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewComboBoxColumn) Then
                        oComboBox.Size = New Size(oColumnWidths(i), nHeight)
                        Dim oBitmap As New Bitmap(oComboBox.Width, oComboBox.Height)
                        oComboBox.DrawToBitmap(oBitmap, New System.Drawing.Rectangle(0, 0, oBitmap.Width, oBitmap.Height))
                        e.Graphics.DrawImage(oBitmap, New Point(oColumnLefts(i), nTop))
                        e.Graphics.DrawString(oCell.Value.ToString, oCell.InheritedStyle.Font, New SolidBrush(oCell.InheritedStyle.ForeColor), New RectangleF(oColumnLefts(i) + 1, nTop, oColumnWidths(i) - 16, nHeight), oStringFormatComboBox)
                    ElseIf oColumnTypes(i) Is GetType(DataGridViewImageColumn) Then
                        Dim oCellSize As Rectangle = New Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight)
                        Dim oImageSize As Size = CType(oCell.Value, Image).Size
                        e.Graphics.DrawImage(oCell.Value, New System.Drawing.Rectangle(oColumnLefts(i) + CType(((oCellSize.Width - oImageSize.Width) / 2), Int32), nTop + CType(((oCellSize.Height - oImageSize.Height) / 2), Int32), CType(oCell.Value, Image).Width, CType(oCell.Value, Image).Height))
                    End If
                    e.Graphics.DrawRectangle(Pens.Black, New System.Drawing.Rectangle(oColumnLefts(i), nTop, oColumnWidths(i), nHeight))
                    i += 1
                Next
            End If
            nRowPos += 1
            nRowsPerPage += 1
        Loop
        DrawFooter(e, nRowsPerPage)
        e.HasMorePages = False
    End Sub
    Private Sub DrawFooter(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal RowsPerPage As Int32)
        Dim sPageNo As String = nPageNo.ToString + " of " + Math.Ceiling(DataGridView1.Rows.Count / RowsPerPage).ToString
        ' Right Align - User Name
        e.Graphics.DrawString(sUserName, DataGridView1.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, DataGridView1.Font, e.MarginBounds.Width).Width), e.MarginBounds.Top + e.MarginBounds.Height + 7)
        ' Left Align - Date/Time
        e.Graphics.DrawString(Now.ToLongDateString + " " + Now.ToShortTimeString, DataGridView1.Font, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + e.MarginBounds.Height + 7)
        ' Center  - Page No. Info
        e.Graphics.DrawString(sPageNo, DataGridView1.Font, Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(sPageNo, DataGridView1.Font, e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top + e.MarginBounds.Height + 31)
    End Sub

    Private Sub printMainButton_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub calculateTotalTime()
        If DataGridView1.Rows.Count > 0 Then
            Dim totalMinutes As Integer = Total().ToString("n")
            totalMinutesMainTextBox.Text = totalMinutes
            totalHoursMainTextBox.Text = Format(totalMinutes / 60, "0.0")
        Else
            totalMinutesMainTextBox.Text = 0
            totalHoursMainTextBox.Text = 0
        End If
    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            tot = tot + Convert.ToDouble(DataGridView1.Rows(i).Cells("taskTime").Value)
        Next i
        Return tot
    End Function
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        'If My.Settings.exitForm = "" Then My.Settings.exitForm = "Menu"

        'If My.Settings.exitForm = "Menu" Then

        '    Dim msgboxResult As String = Nothing

        '    msgboxResult = MsgBox("Minimize to System Tray?", MsgBoxStyle.YesNo, "Minimize")

        '    Select Case msgboxResult

        '        Case 6
        '            'minimize to tray/hide etc here 
        '            'First minimize the form
        '            Me.WindowState = FormWindowState.Minimized

        '            'Cancel the closing of the application
        '            e.Cancel = True

        '        Case 7
        '            'nothing to do here the form is already closing

        '    End Select
        'Else
        '    'nothing to do here the form is already closing
        'End If

    End Sub

    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            'First minimize the form
            Me.WindowState = FormWindowState.Minimized

            'Now make it invisible (make it look like it went into the system tray)
            Me.Visible = False

            NotifyIcon1.Visible = True
            Me.Hide()

            NotifyIcon1.BalloonTipText = "Daily Tasks has been minimized"
            NotifyIcon1.ShowBalloonTip(300)

        End If

    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub editTaskButton_Click(sender As Object, e As EventArgs) Handles editTaskButton.Click

        'Display Task ID Number for testing
        'MsgBox(CType(My.Settings.taskID, String))
        editTaskForm.ShowDialog()

        Call searchMainUsers()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        'Get Task ID number
        If e.RowIndex <> -1 Then
            My.Settings.taskID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        End If

    End Sub

    Private Sub deleteTaskButton_Click(sender As Object, e As EventArgs) Handles deleteTaskButton.Click

        'Display Task ID Number for testing
        'MsgBox(CType(My.Settings.taskID, String))

        MsgBox("Are you sure you want to delete this task?", MsgBoxStyle.YesNo, "Delete Task")

        If vbYes = 6 Then

            passwordForm.ShowDialog()

            If My.Settings.password = "redbmw" Then
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

                'Create a command builder to delete the task in the database
                Dim cb As New OleDb.OleDbCommandBuilder(da)

                'MsgBox(ds.Tables("Task").Rows(0).Item(0))
                ds.Tables("Task").Rows(0).Delete()

                'Update the database using the data adapter
                da.Update(ds, "Task")

                'MsgBox("Database is now open")

                'Closing the database connection
                con.Close()

                'MsgBox("Database is now Closed")
                Call loadDefaultTasks()
            Else
                MsgBox("Incorrect password")
            End If
        End If

    End Sub

End Class
