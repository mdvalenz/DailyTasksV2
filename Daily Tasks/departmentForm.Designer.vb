<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class departmentForm
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
        Me.saveNewDepartmentButton = New System.Windows.Forms.Button()
        Me.saveExitDepartmentButton = New System.Windows.Forms.Button()
        Me.departmentDepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'saveNewDepartmentButton
        '
        Me.saveNewDepartmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewDepartmentButton.Location = New System.Drawing.Point(143, 56)
        Me.saveNewDepartmentButton.Name = "saveNewDepartmentButton"
        Me.saveNewDepartmentButton.Size = New System.Drawing.Size(125, 30)
        Me.saveNewDepartmentButton.TabIndex = 5
        Me.saveNewDepartmentButton.Text = "Save and New"
        Me.saveNewDepartmentButton.UseVisualStyleBackColor = True
        '
        'saveExitDepartmentButton
        '
        Me.saveExitDepartmentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitDepartmentButton.Location = New System.Drawing.Point(12, 56)
        Me.saveExitDepartmentButton.Name = "saveExitDepartmentButton"
        Me.saveExitDepartmentButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitDepartmentButton.TabIndex = 4
        Me.saveExitDepartmentButton.Text = "Save and Exit"
        Me.saveExitDepartmentButton.UseVisualStyleBackColor = True
        '
        'departmentDepartmentTextBox
        '
        Me.departmentDepartmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.departmentDepartmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentDepartmentTextBox.Location = New System.Drawing.Point(40, 17)
        Me.departmentDepartmentTextBox.Name = "departmentDepartmentTextBox"
        Me.departmentDepartmentTextBox.Size = New System.Drawing.Size(200, 26)
        Me.departmentDepartmentTextBox.TabIndex = 3
        Me.departmentDepartmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'departmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 98)
        Me.Controls.Add(Me.saveNewDepartmentButton)
        Me.Controls.Add(Me.saveExitDepartmentButton)
        Me.Controls.Add(Me.departmentDepartmentTextBox)
        Me.Name = "departmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter New Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveNewDepartmentButton As System.Windows.Forms.Button
    Friend WithEvents saveExitDepartmentButton As System.Windows.Forms.Button
    Friend WithEvents departmentDepartmentTextBox As System.Windows.Forms.TextBox
End Class
