Public Class passwordForm

    Private Sub passwordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordTextBox.Text = ""
    End Sub

    Private Sub saveNewTagButton_Click(sender As Object, e As EventArgs) Handles saveNewTagButton.Click
        My.Settings.password = passwordTextBox.Text
        Close()
    End Sub

End Class