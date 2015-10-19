<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userForm))
        Me.saveNewUserButton = New System.Windows.Forms.Button()
        Me.saveExitUserButton = New System.Windows.Forms.Button()
        Me.fullNameUserTextBox = New System.Windows.Forms.TextBox()
        Me.fullNameUserLabel = New System.Windows.Forms.Label()
        Me.loginIDUserLabel = New System.Windows.Forms.Label()
        Me.loginIDUserTextBox = New System.Windows.Forms.TextBox()
        Me.emailUserLabel = New System.Windows.Forms.Label()
        Me.emailUserTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'saveNewUserButton
        '
        Me.saveNewUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewUserButton.Location = New System.Drawing.Point(306, 131)
        Me.saveNewUserButton.Name = "saveNewUserButton"
        Me.saveNewUserButton.Size = New System.Drawing.Size(125, 30)
        Me.saveNewUserButton.TabIndex = 4
        Me.saveNewUserButton.Text = "Save and New"
        Me.saveNewUserButton.UseVisualStyleBackColor = True
        '
        'saveExitUserButton
        '
        Me.saveExitUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitUserButton.Location = New System.Drawing.Point(175, 131)
        Me.saveExitUserButton.Name = "saveExitUserButton"
        Me.saveExitUserButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitUserButton.TabIndex = 3
        Me.saveExitUserButton.Text = "Save and Exit"
        Me.saveExitUserButton.UseVisualStyleBackColor = True
        '
        'fullNameUserTextBox
        '
        Me.fullNameUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fullNameUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullNameUserTextBox.Location = New System.Drawing.Point(16, 32)
        Me.fullNameUserTextBox.Name = "fullNameUserTextBox"
        Me.fullNameUserTextBox.Size = New System.Drawing.Size(200, 26)
        Me.fullNameUserTextBox.TabIndex = 0
        Me.fullNameUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fullNameUserLabel
        '
        Me.fullNameUserLabel.AutoSize = True
        Me.fullNameUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullNameUserLabel.Location = New System.Drawing.Point(12, 9)
        Me.fullNameUserLabel.Name = "fullNameUserLabel"
        Me.fullNameUserLabel.Size = New System.Drawing.Size(80, 20)
        Me.fullNameUserLabel.TabIndex = 36
        Me.fullNameUserLabel.Text = "Full Name"
        '
        'loginIDUserLabel
        '
        Me.loginIDUserLabel.AutoSize = True
        Me.loginIDUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDUserLabel.Location = New System.Drawing.Point(227, 9)
        Me.loginIDUserLabel.Name = "loginIDUserLabel"
        Me.loginIDUserLabel.Size = New System.Drawing.Size(69, 20)
        Me.loginIDUserLabel.TabIndex = 38
        Me.loginIDUserLabel.Text = "Login ID"
        '
        'loginIDUserTextBox
        '
        Me.loginIDUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginIDUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDUserTextBox.Location = New System.Drawing.Point(231, 32)
        Me.loginIDUserTextBox.Name = "loginIDUserTextBox"
        Me.loginIDUserTextBox.Size = New System.Drawing.Size(200, 26)
        Me.loginIDUserTextBox.TabIndex = 1
        Me.loginIDUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailUserLabel
        '
        Me.emailUserLabel.AutoSize = True
        Me.emailUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailUserLabel.Location = New System.Drawing.Point(12, 66)
        Me.emailUserLabel.Name = "emailUserLabel"
        Me.emailUserLabel.Size = New System.Drawing.Size(53, 20)
        Me.emailUserLabel.TabIndex = 40
        Me.emailUserLabel.Text = "E-mail"
        '
        'emailUserTextBox
        '
        Me.emailUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailUserTextBox.Location = New System.Drawing.Point(16, 89)
        Me.emailUserTextBox.Name = "emailUserTextBox"
        Me.emailUserTextBox.Size = New System.Drawing.Size(415, 26)
        Me.emailUserTextBox.TabIndex = 2
        Me.emailUserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 177)
        Me.Controls.Add(Me.emailUserLabel)
        Me.Controls.Add(Me.emailUserTextBox)
        Me.Controls.Add(Me.loginIDUserLabel)
        Me.Controls.Add(Me.loginIDUserTextBox)
        Me.Controls.Add(Me.fullNameUserLabel)
        Me.Controls.Add(Me.saveNewUserButton)
        Me.Controls.Add(Me.saveExitUserButton)
        Me.Controls.Add(Me.fullNameUserTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "userForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveNewUserButton As System.Windows.Forms.Button
    Friend WithEvents saveExitUserButton As System.Windows.Forms.Button
    Friend WithEvents fullNameUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fullNameUserLabel As System.Windows.Forms.Label
    Friend WithEvents loginIDUserLabel As System.Windows.Forms.Label
    Friend WithEvents loginIDUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailUserLabel As System.Windows.Forms.Label
    Friend WithEvents emailUserTextBox As System.Windows.Forms.TextBox
End Class
