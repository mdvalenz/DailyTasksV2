<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsForm))
        Me.DBSettingsLabel = New System.Windows.Forms.Label()
        Me.DBSettingsTextBox = New System.Windows.Forms.TextBox()
        Me.BrowseSettingsButton = New System.Windows.Forms.Button()
        Me.exitSettingsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DBSettingsLabel
        '
        Me.DBSettingsLabel.AutoSize = True
        Me.DBSettingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBSettingsLabel.Location = New System.Drawing.Point(12, 19)
        Me.DBSettingsLabel.Name = "DBSettingsLabel"
        Me.DBSettingsLabel.Size = New System.Drawing.Size(144, 20)
        Me.DBSettingsLabel.TabIndex = 42
        Me.DBSettingsLabel.Text = "Database Location"
        '
        'DBSettingsTextBox
        '
        Me.DBSettingsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Daily_Tasks.My.MySettings.Default, "DBLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DBSettingsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBSettingsTextBox.Location = New System.Drawing.Point(16, 42)
        Me.DBSettingsTextBox.Name = "DBSettingsTextBox"
        Me.DBSettingsTextBox.Size = New System.Drawing.Size(415, 26)
        Me.DBSettingsTextBox.TabIndex = 41
        Me.DBSettingsTextBox.Text = Global.Daily_Tasks.My.MySettings.Default.DBLocation
        '
        'BrowseSettingsButton
        '
        Me.BrowseSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseSettingsButton.Location = New System.Drawing.Point(437, 40)
        Me.BrowseSettingsButton.Name = "BrowseSettingsButton"
        Me.BrowseSettingsButton.Size = New System.Drawing.Size(83, 30)
        Me.BrowseSettingsButton.TabIndex = 43
        Me.BrowseSettingsButton.Text = "Browse"
        Me.BrowseSettingsButton.UseVisualStyleBackColor = True
        '
        'exitSettingsButton
        '
        Me.exitSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitSettingsButton.Location = New System.Drawing.Point(392, 96)
        Me.exitSettingsButton.Name = "exitSettingsButton"
        Me.exitSettingsButton.Size = New System.Drawing.Size(128, 30)
        Me.exitSettingsButton.TabIndex = 44
        Me.exitSettingsButton.Text = "Save and Exit"
        Me.exitSettingsButton.UseVisualStyleBackColor = True
        '
        'settingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 138)
        Me.Controls.Add(Me.exitSettingsButton)
        Me.Controls.Add(Me.BrowseSettingsButton)
        Me.Controls.Add(Me.DBSettingsLabel)
        Me.Controls.Add(Me.DBSettingsTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBSettingsLabel As System.Windows.Forms.Label
    Friend WithEvents DBSettingsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseSettingsButton As System.Windows.Forms.Button
    Friend WithEvents exitSettingsButton As System.Windows.Forms.Button
End Class
