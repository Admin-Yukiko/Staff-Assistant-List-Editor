<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuildingListDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
    Me.Label1 = New System.Windows.Forms.Label
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Location = New System.Drawing.Point(29, 54)
    Me.ProgressBar1.MarqueeAnimationSpeed = 25
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(296, 23)
    Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
    Me.ProgressBar1.TabIndex = 0
    Me.ProgressBar1.UseWaitCursor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(61, 21)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(234, 18)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Populating List. Please Wait..."
    Me.Label1.UseWaitCursor = True
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Transparent
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Panel1.Controls.Add(Me.ProgressBar1)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(356, 101)
    Me.Panel1.TabIndex = 2
    Me.Panel1.UseWaitCursor = True
    '
    'BuildingListDialog
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.ClientSize = New System.Drawing.Size(356, 101)
    Me.ControlBox = False
    Me.Controls.Add(Me.Panel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(356, 101)
    Me.MinimizeBox = False
    Me.MinimumSize = New System.Drawing.Size(356, 101)
    Me.Name = "BuildingListDialog"
    Me.Opacity = 0.75
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Populating List..."
    Me.UseWaitCursor = True
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
