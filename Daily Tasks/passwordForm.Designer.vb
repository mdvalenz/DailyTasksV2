<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.saveNewTagButton = New System.Windows.Forms.Button()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'saveNewTagButton
        '
        Me.saveNewTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewTagButton.Location = New System.Drawing.Point(112, 56)
        Me.saveNewTagButton.Name = "saveNewTagButton"
        Me.saveNewTagButton.Size = New System.Drawing.Size(56, 30)
        Me.saveNewTagButton.TabIndex = 5
        Me.saveNewTagButton.Text = "OK"
        Me.saveNewTagButton.UseVisualStyleBackColor = True
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextBox.Location = New System.Drawing.Point(40, 17)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(200, 26)
        Me.passwordTextBox.TabIndex = 3
        Me.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'passwordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 98)
        Me.Controls.Add(Me.saveNewTagButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Name = "passwordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveNewTagButton As System.Windows.Forms.Button
    Friend WithEvents passwordTextBox As System.Windows.Forms.TextBox
End Class
