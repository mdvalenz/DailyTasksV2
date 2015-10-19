Public Class departmentForm

    Private Sub departmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call resetForm()
    End Sub

    Public Shared departmentText As String

    Private Sub saveExitDepartmentButton_Click(sender As Object, e As EventArgs) Handles saveExitDepartmentButton.Click
        Call saveDepartmentRecord()
        Close()
    End Sub

    Private Sub saveNewDepartmentButton_Click(sender As Object, e As EventArgs) Handles saveNewDepartmentButton.Click
        Call saveDepartmentRecord()
        Call resetForm()
    End Sub

    Private Sub saveDepartmentRecord()

        'Get tag
        departmentText = departmentDepartmentTextBox.Text

        'Check if it is blank
        If departmentText = "" Then
            MsgBox("No department was entered.")
            Call resetForm()
        Else
            'Connect to the database
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

            'Search string to select all Tags from the tagTable
            Sql = "SELECT departmentTable.[Departments] FROM departmentTable"

            'Send the search to the data adapter
            da = New OleDb.OleDbDataAdapter(Sql, con)

            'Tell the data adapter to fill the dataset
            da.Fill(ds, "Departments")

            'Add a new row to the dataset
            'Create a command builder 
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            'Create new row in the dataset
            dsNewRow = ds.Tables("Departments").NewRow()

            'Add the new tag to the new datarow in the dataset
            dsNewRow.Item("Departments") = departmentText

            'Add the row to the dataset
            ds.Tables("Departments").Rows.Add(dsNewRow)

            'Update the database using the data adapter
            da.Update(ds, "Departments")

            'MsgBox("Database is now open")

            'Closing the database connection
            con.Close()

            'MsgBox("Database is now Closed")
        End If

    End Sub

    Private Sub resetForm()

        'Clear the text box and set cursor
        departmentDepartmentTextBox.Text = ""
        departmentDepartmentTextBox.Focus()

    End Sub

End Class