<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressBar
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
        Me.exportProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'exportProgressBar
        '
        Me.exportProgressBar.Location = New System.Drawing.Point(12, 12)
        Me.exportProgressBar.Name = "exportProgressBar"
        Me.exportProgressBar.Size = New System.Drawing.Size(319, 23)
        Me.exportProgressBar.TabIndex = 0
        '
        'ProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 46)
        Me.Controls.Add(Me.exportProgressBar)
        Me.Name = "ProgressBar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Monthly List"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exportProgressBar As System.Windows.Forms.ProgressBar
End Class
