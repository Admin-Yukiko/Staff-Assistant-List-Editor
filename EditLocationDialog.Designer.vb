<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLocationDialog
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Cancel_Button = New System.Windows.Forms.Button
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.NewZ = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.NewY = New System.Windows.Forms.TextBox
    Me.NewX = New System.Windows.Forms.TextBox
    Me.NewName = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CurrentZ = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.CurrentY = New System.Windows.Forms.TextBox
    Me.CurrentX = New System.Windows.Forms.TextBox
    Me.CurrentName = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 310)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(3, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.NewZ)
    Me.GroupBox2.Controls.Add(Me.Label8)
    Me.GroupBox2.Controls.Add(Me.NewY)
    Me.GroupBox2.Controls.Add(Me.NewX)
    Me.GroupBox2.Controls.Add(Me.NewName)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(411, 149)
    Me.GroupBox2.TabIndex = 4
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Selection Edit..."
    '
    'NewZ
    '
    Me.NewZ.Location = New System.Drawing.Point(100, 105)
    Me.NewZ.MaxLength = 2
    Me.NewZ.Name = "NewZ"
    Me.NewZ.Size = New System.Drawing.Size(100, 20)
    Me.NewZ.TabIndex = 7
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(75, 108)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(19, 13)
    Me.Label8.TabIndex = 6
    Me.Label8.Text = "Z:"
    '
    'NewY
    '
    Me.NewY.Location = New System.Drawing.Point(100, 79)
    Me.NewY.MaxLength = 4
    Me.NewY.Name = "NewY"
    Me.NewY.Size = New System.Drawing.Size(100, 20)
    Me.NewY.TabIndex = 5
    '
    'NewX
    '
    Me.NewX.Location = New System.Drawing.Point(100, 53)
    Me.NewX.MaxLength = 4
    Me.NewX.Name = "NewX"
    Me.NewX.Size = New System.Drawing.Size(100, 20)
    Me.NewX.TabIndex = 4
    '
    'NewName
    '
    Me.NewName.Location = New System.Drawing.Point(100, 27)
    Me.NewName.MaxLength = 45
    Me.NewName.Name = "NewName"
    Me.NewName.Size = New System.Drawing.Size(281, 20)
    Me.NewName.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(75, 82)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(19, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Y:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(51, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(43, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Name:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(75, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(19, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "X:"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CurrentZ)
    Me.GroupBox1.Controls.Add(Me.Label7)
    Me.GroupBox1.Controls.Add(Me.CurrentY)
    Me.GroupBox1.Controls.Add(Me.CurrentX)
    Me.GroupBox1.Controls.Add(Me.CurrentName)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(411, 132)
    Me.GroupBox1.TabIndex = 3
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Original Values"
    '
    'CurrentZ
    '
    Me.CurrentZ.Location = New System.Drawing.Point(100, 96)
    Me.CurrentZ.MaxLength = 3
    Me.CurrentZ.Name = "CurrentZ"
    Me.CurrentZ.ReadOnly = True
    Me.CurrentZ.Size = New System.Drawing.Size(100, 20)
    Me.CurrentZ.TabIndex = 10
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(75, 99)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(19, 13)
    Me.Label7.TabIndex = 9
    Me.Label7.Text = "Z:"
    '
    'CurrentY
    '
    Me.CurrentY.Location = New System.Drawing.Point(100, 70)
    Me.CurrentY.MaxLength = 4
    Me.CurrentY.Name = "CurrentY"
    Me.CurrentY.ReadOnly = True
    Me.CurrentY.Size = New System.Drawing.Size(100, 20)
    Me.CurrentY.TabIndex = 8
    '
    'CurrentX
    '
    Me.CurrentX.Location = New System.Drawing.Point(100, 44)
    Me.CurrentX.MaxLength = 4
    Me.CurrentX.Name = "CurrentX"
    Me.CurrentX.ReadOnly = True
    Me.CurrentX.Size = New System.Drawing.Size(100, 20)
    Me.CurrentX.TabIndex = 7
    '
    'CurrentName
    '
    Me.CurrentName.Location = New System.Drawing.Point(100, 18)
    Me.CurrentName.MaxLength = 45
    Me.CurrentName.Name = "CurrentName"
    Me.CurrentName.ReadOnly = True
    Me.CurrentName.Size = New System.Drawing.Size(281, 20)
    Me.CurrentName.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(75, 73)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(19, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Y:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(51, 21)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(43, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Name:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(75, 47)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(19, 13)
    Me.Label6.TabIndex = 3
    Me.Label6.Text = "X:"
    '
    'EditLocationDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(435, 351)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "EditLocationDialog"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Edit Selection..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents NewY As System.Windows.Forms.TextBox
  Friend WithEvents NewX As System.Windows.Forms.TextBox
  Friend WithEvents NewName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents CurrentY As System.Windows.Forms.TextBox
  Friend WithEvents CurrentX As System.Windows.Forms.TextBox
  Friend WithEvents CurrentName As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents NewZ As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents CurrentZ As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
