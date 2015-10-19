<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tagForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tagForm))
        Me.tagTagTextBox = New System.Windows.Forms.TextBox()
        Me.saveNewTagButton = New System.Windows.Forms.Button()
        Me.saveExitTagButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tagTagTextBox
        '
        Me.tagTagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tagTagTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagTagTextBox.Location = New System.Drawing.Point(40, 17)
        Me.tagTagTextBox.Name = "tagTagTextBox"
        Me.tagTagTextBox.Size = New System.Drawing.Size(200, 26)
        Me.tagTagTextBox.TabIndex = 0
        Me.tagTagTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'saveNewTagButton
        '
        Me.saveNewTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewTagButton.Location = New System.Drawing.Point(143, 56)
        Me.saveNewTagButton.Name = "saveNewTagButton"
        Me.saveNewTagButton.Size = New System.Drawing.Size(125, 30)
        Me.saveNewTagButton.TabIndex = 2
        Me.saveNewTagButton.Text = "Save and New"
        Me.saveNewTagButton.UseVisualStyleBackColor = True
        '
        'saveExitTagButton
        '
        Me.saveExitTagButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitTagButton.Location = New System.Drawing.Point(12, 56)
        Me.saveExitTagButton.Name = "saveExitTagButton"
        Me.saveExitTagButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitTagButton.TabIndex = 1
        Me.saveExitTagButton.Text = "Save and Exit"
        Me.saveExitTagButton.UseVisualStyleBackColor = True
        '
        'tagForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 98)
        Me.Controls.Add(Me.saveNewTagButton)
        Me.Controls.Add(Me.saveExitTagButton)
        Me.Controls.Add(Me.tagTagTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "tagForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter New Tag"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tagTagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents saveNewTagButton As System.Windows.Forms.Button
    Friend WithEvents saveExitTagButton As System.Windows.Forms.Button
End Class
