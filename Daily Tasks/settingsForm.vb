Public Class settingsForm

    Private Sub BrowseSettingsButton_Click(sender As Object, e As EventArgs) Handles BrowseSettingsButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "F:\QA\Daily Tasks\Database\"
        fd.Filter = "Microsoft Access Database (*.accdb)|*.accdb"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            My.Settings.DBLocation = fd.FileName
            DBSettingsTextBox.Text = My.Settings.DBLocation
        End If
    End Sub

    Private Sub exitSettingsButton_Click(sender As Object, e As EventArgs) Handles exitSettingsButton.Click
        Close()
    End Sub

    Private Sub settingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class