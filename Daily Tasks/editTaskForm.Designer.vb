<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editTaskForm
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
        Me.newTagTaskButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tag3TaskComboBox = New System.Windows.Forms.ComboBox()
        Me.tag2TaskComboBox = New System.Windows.Forms.ComboBox()
        Me.saveNewTaskButton = New System.Windows.Forms.Button()
        Me.tag1TaskComboBox = New System.Windows.Forms.ComboBox()
        Me.tagsTaskLabel = New System.Windows.Forms.Label()
        Me.descriptionTaskTextBox = New System.Windows.Forms.TextBox()
        Me.descriptionTaskLabel = New System.Windows.Forms.Label()
        Me.saveExitTaskButton = New System.Windows.Forms.Button()
        Me.dateTaskPicker = New System.Windows.Forms.DateTimePicker()
        Me.dateTaskLabel = New System.Windows.Forms.Label()
        Me.estimatedTimeTaskTextBox = New System.Windows.Forms.TextBox()
        Me.estimatedTimeTaskLabel = New System.Windows.Forms.Label()
        Me.taskTaskTextBox = New System.Windows.Forms.TextBox()
        Me.taskTaskLabel = New System.Windows.Forms.Label()
        Me.nameTaskLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'newTagTaskButton
        '
        Me.newTagTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTagTaskButton.Location = New System.Drawing.Point(651, 202)
        Me.newTagTaskButton.Name = "newTagTaskButton"
        Me.newTagTaskButton.Size = New System.Drawing.Size(125, 30)
        Me.newTagTaskButton.TabIndex = 41
        Me.newTagTaskButton.Text = "New Tag"
        Me.newTagTaskButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "* Required Fields"
        '
        'tag3TaskComboBox
        '
        Me.tag3TaskComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag3TaskComboBox.FormattingEnabled = True
        Me.tag3TaskComboBox.Location = New System.Drawing.Point(622, 166)
        Me.tag3TaskComboBox.Name = "tag3TaskComboBox"
        Me.tag3TaskComboBox.Size = New System.Drawing.Size(191, 28)
        Me.tag3TaskComboBox.TabIndex = 34
        '
        'tag2TaskComboBox
        '
        Me.tag2TaskComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tag2TaskComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tag2TaskComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag2TaskComboBox.FormattingEnabled = True
        Me.tag2TaskComboBox.Location = New System.Drawing.Point(622, 132)
        Me.tag2TaskComboBox.Name = "tag2TaskComboBox"
        Me.tag2TaskComboBox.Size = New System.Drawing.Size(191, 28)
        Me.tag2TaskComboBox.TabIndex = 32
        '
        'saveNewTaskButton
        '
        Me.saveNewTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveNewTaskButton.Location = New System.Drawing.Point(651, 274)
        Me.saveNewTaskButton.Name = "saveNewTaskButton"
        Me.saveNewTaskButton.Size = New System.Drawing.Size(125, 30)
        Me.saveNewTaskButton.TabIndex = 36
        Me.saveNewTaskButton.Text = "Save and New"
        Me.saveNewTaskButton.UseVisualStyleBackColor = True
        '
        'tag1TaskComboBox
        '
        Me.tag1TaskComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tag1TaskComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tag1TaskComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tag1TaskComboBox.FormattingEnabled = True
        Me.tag1TaskComboBox.Location = New System.Drawing.Point(622, 98)
        Me.tag1TaskComboBox.Name = "tag1TaskComboBox"
        Me.tag1TaskComboBox.Size = New System.Drawing.Size(191, 28)
        Me.tag1TaskComboBox.TabIndex = 31
        '
        'tagsTaskLabel
        '
        Me.tagsTaskLabel.AutoSize = True
        Me.tagsTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tagsTaskLabel.Location = New System.Drawing.Point(697, 61)
        Me.tagsTaskLabel.Name = "tagsTaskLabel"
        Me.tagsTaskLabel.Size = New System.Drawing.Size(44, 20)
        Me.tagsTaskLabel.TabIndex = 39
        Me.tagsTaskLabel.Text = "Tags"
        '
        'descriptionTaskTextBox
        '
        Me.descriptionTaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descriptionTaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTaskTextBox.Location = New System.Drawing.Point(46, 161)
        Me.descriptionTaskTextBox.Multiline = True
        Me.descriptionTaskTextBox.Name = "descriptionTaskTextBox"
        Me.descriptionTaskTextBox.Size = New System.Drawing.Size(543, 143)
        Me.descriptionTaskTextBox.TabIndex = 30
        '
        'descriptionTaskLabel
        '
        Me.descriptionTaskLabel.AutoSize = True
        Me.descriptionTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionTaskLabel.Location = New System.Drawing.Point(42, 138)
        Me.descriptionTaskLabel.Name = "descriptionTaskLabel"
        Me.descriptionTaskLabel.Size = New System.Drawing.Size(89, 20)
        Me.descriptionTaskLabel.TabIndex = 38
        Me.descriptionTaskLabel.Text = "Description"
        '
        'saveExitTaskButton
        '
        Me.saveExitTaskButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveExitTaskButton.Location = New System.Drawing.Point(651, 238)
        Me.saveExitTaskButton.Name = "saveExitTaskButton"
        Me.saveExitTaskButton.Size = New System.Drawing.Size(125, 30)
        Me.saveExitTaskButton.TabIndex = 35
        Me.saveExitTaskButton.Text = "Save and Exit"
        Me.saveExitTaskButton.UseVisualStyleBackColor = True
        '
        'dateTaskPicker
        '
        Me.dateTaskPicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTaskPicker.CustomFormat = "MM/dd/yy"
        Me.dateTaskPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTaskPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTaskPicker.Location = New System.Drawing.Point(92, 58)
        Me.dateTaskPicker.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.dateTaskPicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dateTaskPicker.Name = "dateTaskPicker"
        Me.dateTaskPicker.Size = New System.Drawing.Size(124, 26)
        Me.dateTaskPicker.TabIndex = 26
        '
        'dateTaskLabel
        '
        Me.dateTaskLabel.AutoSize = True
        Me.dateTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTaskLabel.Location = New System.Drawing.Point(32, 61)
        Me.dateTaskLabel.Name = "dateTaskLabel"
        Me.dateTaskLabel.Size = New System.Drawing.Size(54, 20)
        Me.dateTaskLabel.TabIndex = 37
        Me.dateTaskLabel.Text = "* Date"
        '
        'estimatedTimeTaskTextBox
        '
        Me.estimatedTimeTaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estimatedTimeTaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estimatedTimeTaskTextBox.Location = New System.Drawing.Point(509, 59)
        Me.estimatedTimeTaskTextBox.Name = "estimatedTimeTaskTextBox"
        Me.estimatedTimeTaskTextBox.Size = New System.Drawing.Size(80, 26)
        Me.estimatedTimeTaskTextBox.TabIndex = 28
        Me.estimatedTimeTaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estimatedTimeTaskLabel
        '
        Me.estimatedTimeTaskLabel.AutoSize = True
        Me.estimatedTimeTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estimatedTimeTaskLabel.Location = New System.Drawing.Point(352, 61)
        Me.estimatedTimeTaskLabel.Name = "estimatedTimeTaskLabel"
        Me.estimatedTimeTaskLabel.Size = New System.Drawing.Size(151, 20)
        Me.estimatedTimeTaskLabel.TabIndex = 33
        Me.estimatedTimeTaskLabel.Text = "* Estimated Minutes"
        '
        'taskTaskTextBox
        '
        Me.taskTaskTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taskTaskTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTaskTextBox.Location = New System.Drawing.Point(92, 99)
        Me.taskTaskTextBox.Name = "taskTaskTextBox"
        Me.taskTaskTextBox.Size = New System.Drawing.Size(497, 26)
        Me.taskTaskTextBox.TabIndex = 29
        '
        'taskTaskLabel
        '
        Me.taskTaskLabel.AutoSize = True
        Me.taskTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTaskLabel.Location = New System.Drawing.Point(33, 101)
        Me.taskTaskLabel.Name = "taskTaskLabel"
        Me.taskTaskLabel.Size = New System.Drawing.Size(53, 20)
        Me.taskTaskLabel.TabIndex = 27
        Me.taskTaskLabel.Text = "* Task"
        '
        'nameTaskLabel
        '
        Me.nameTaskLabel.AutoSize = True
        Me.nameTaskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTaskLabel.Location = New System.Drawing.Point(12, 9)
        Me.nameTaskLabel.Name = "nameTaskLabel"
        Me.nameTaskLabel.Size = New System.Drawing.Size(0, 29)
        Me.nameTaskLabel.TabIndex = 25
        '
        'editTaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 316)
        Me.Controls.Add(Me.newTagTaskButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tag3TaskComboBox)
        Me.Controls.Add(Me.tag2TaskComboBox)
        Me.Controls.Add(Me.saveNewTaskButton)
        Me.Controls.Add(Me.tag1TaskComboBox)
        Me.Controls.Add(Me.tagsTaskLabel)
        Me.Controls.Add(Me.descriptionTaskTextBox)
        Me.Controls.Add(Me.descriptionTaskLabel)
        Me.Controls.Add(Me.saveExitTaskButton)
        Me.Controls.Add(Me.dateTaskPicker)
        Me.Controls.Add(Me.dateTaskLabel)
        Me.Controls.Add(Me.estimatedTimeTaskTextBox)
        Me.Controls.Add(Me.estimatedTimeTaskLabel)
        Me.Controls.Add(Me.taskTaskTextBox)
        Me.Controls.Add(Me.taskTaskLabel)
        Me.Controls.Add(Me.nameTaskLabel)
        Me.Name = "editTaskForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newTagTaskButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tag3TaskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents tag2TaskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents saveNewTaskButton As System.Windows.Forms.Button
    Friend WithEvents tag1TaskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents tagsTaskLabel As System.Windows.Forms.Label
    Friend WithEvents descriptionTaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents descriptionTaskLabel As System.Windows.Forms.Label
    Friend WithEvents saveExitTaskButton As System.Windows.Forms.Button
    Friend WithEvents dateTaskPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateTaskLabel As System.Windows.Forms.Label
    Friend WithEvents estimatedTimeTaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents estimatedTimeTaskLabel As System.Windows.Forms.Label
    Friend WithEvents taskTaskTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taskTaskLabel As System.Windows.Forms.Label
    Friend WithEvents nameTaskLabel As System.Windows.Forms.Label
End Class
