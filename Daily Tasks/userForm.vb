Public Class userForm
    Public Shared fullNameText, loginIDText, emailText As String

    Private Sub saveExitUserButton_Click(sender As Object, e As EventArgs) Handles saveExitUserButton.Click
        Call saveNameRecord()
        Close()
    End Sub

    Private Sub saveNewUserButton_Click(sender As Object, e As EventArgs) Handles saveNewUserButton.Click
        Call saveNameRecord()
        Call resetForm()
    End Sub
    Private Sub saveNameRecord()

        'Get Full Name and Login ID
        fullNameText = fullNameUserTextBox.Text
        loginIDText = loginIDUserTextBox.Text
        emailText = emailUserTextBox.Text

        'Check if it is blank
        If fullNameText = "" Or loginIDText = "" Then
            MsgBox("Please fill in both boxes.")
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

            'Search string to select all Users from the userTable
            Sql = "SELECT userTable.[FullName], userTable.[LoginID], userTable.[Email] FROM userTable"

            'Send the search to the data adapter
            da = New OleDb.OleDbDataAdapter(Sql, con)

            'Tell the data adapter to fill the dataset
            da.Fill(ds, "Name")

            'Add a new row to the dataset
            'Create a command builder 
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            'Create new row in the dataset
            dsNewRow = ds.Tables("Name").NewRow()

            'Add the new tag to the new datarow in the dataset
            dsNewRow.Item("FullName") = fullNameText
            dsNewRow.Item("LoginID") = loginIDText
            dsNewRow.Item("Email") = emailText

            'Add the row to the dataset
            ds.Tables("Name").Rows.Add(dsNewRow)

            'Update the database using the data adapter
            da.Update(ds, "Name")

            'MsgBox("Database is now open")

            'Closing the database connection
            con.Close()

            'MsgBox("Database is now Closed")
            Call resetForm()
        End If

    End Sub

    Private Sub resetForm()

        'Clear the text boxs and set cursor
        fullNameUserTextBox.Text = ""
        loginIDUserTextBox.Text = ""
        emailUserTextBox.Text = ""
        fullNameUserTextBox.Focus()

    End Sub

    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call resetForm()
    End Sub
End Class