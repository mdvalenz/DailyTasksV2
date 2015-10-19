Public Class tagForm
    Public Shared tagText As String
    Private Sub saveExitTagButton_Click(sender As Object, e As EventArgs) Handles saveExitTagButton.Click
        Call saveTagRecord()
        Close()
    End Sub

    Private Sub saveNewTagButton_Click(sender As Object, e As EventArgs) Handles saveNewTagButton.Click
        Call saveTagRecord()
        Call resetForm()
    End Sub

    Private Sub saveTagRecord()

        'Get tag
        tagText = tagTagTextBox.Text

        'Check if it is blank
        If tagText = "" Then
            MsgBox("No tag was entered.")
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
            Sql = "SELECT tagTable.[Tags] FROM tagTable"

            'Send the search to the data adapter
            da = New OleDb.OleDbDataAdapter(Sql, con)

            'Tell the data adapter to fill the dataset
            da.Fill(ds, "Tags")

            'Add a new row to the dataset
            'Create a command builder 
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            'Create new row in the dataset
            dsNewRow = ds.Tables("Tags").NewRow()

            'Add the new tag to the new datarow in the dataset
            dsNewRow.Item("Tags") = tagText

            'Add the row to the dataset
            ds.Tables("Tags").Rows.Add(dsNewRow)

            'Update the database using the data adapter
            da.Update(ds, "Tags")

            'MsgBox("Database is now open")

            'Closing the database connection
            con.Close()

            'MsgBox("Database is now Closed")
            Call resetForm()

        End If

    End Sub

    Private Sub resetForm()

        'Clear the text box and set cursor
        tagTagTextBox.Text = ""
        tagTagTextBox.Focus()

    End Sub

    Private Sub tagForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call resetForm()
    End Sub
End Class