<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItemDialog
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
    Me.components = New System.ComponentModel.Container
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Cancel_Button = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CurrentName = New System.Windows.Forms.TextBox
    Me.CurrentID = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.ItemPreview = New System.Windows.Forms.PictureBox
    Me.NewName = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.NewID = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    CType(Me.ItemPreview, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(283, 262)
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
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CurrentName)
    Me.GroupBox1.Controls.Add(Me.CurrentID)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(417, 79)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Current Values"
    '
    'CurrentName
    '
    Me.CurrentName.Location = New System.Drawing.Point(54, 48)
    Me.CurrentName.MaxLength = 45
    Me.CurrentName.Name = "CurrentName"
    Me.CurrentName.ReadOnly = True
    Me.CurrentName.Size = New System.Drawing.Size(266, 20)
    Me.CurrentName.TabIndex = 7
    Me.ToolTip.SetToolTip(Me.CurrentName, "Current item name.")
    '
    'CurrentID
    '
    Me.CurrentID.Location = New System.Drawing.Point(54, 22)
    Me.CurrentID.MaxLength = 4
    Me.CurrentID.Name = "CurrentID"
    Me.CurrentID.ReadOnly = True
    Me.CurrentID.Size = New System.Drawing.Size(100, 20)
    Me.CurrentID.TabIndex = 6
    Me.ToolTip.SetToolTip(Me.CurrentID, "Current item ID.")
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(24, 25)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(24, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "ID:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(5, 51)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(43, 13)
    Me.Label6.TabIndex = 3
    Me.Label6.Text = "Name:"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.GroupBox3)
    Me.GroupBox2.Controls.Add(Me.NewName)
    Me.GroupBox2.Controls.Add(Me.NewID)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 97)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(417, 154)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Selection Edit..."
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.ItemPreview)
    Me.GroupBox3.Location = New System.Drawing.Point(271, 19)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(139, 129)
    Me.GroupBox3.TabIndex = 5
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Item Preview"
    '
    'ItemPreview
    '
    Me.ItemPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ItemPreview.Location = New System.Drawing.Point(3, 16)
    Me.ItemPreview.Name = "ItemPreview"
    Me.ItemPreview.Size = New System.Drawing.Size(133, 110)
    Me.ItemPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.ItemPreview.TabIndex = 0
    Me.ItemPreview.TabStop = False
    '
    'NewName
    '
    Me.NewName.Location = New System.Drawing.Point(54, 53)
    Me.NewName.MaxLength = 45
    Me.NewName.Name = "NewName"
    Me.NewName.Size = New System.Drawing.Size(211, 20)
    Me.NewName.TabIndex = 4
    Me.ToolTip.SetToolTip(Me.NewName, "Enter the name of the item. This is for reference only and has no effect on the i" & _
            "tem created in-game.")
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(25, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(24, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "ID:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(5, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Name:"
    '
    'NewID
    '
    Me.NewID.Location = New System.Drawing.Point(55, 27)
    Me.NewID.MaxLength = 4
    Me.NewID.Name = "NewID"
    Me.NewID.Size = New System.Drawing.Size(99, 20)
    Me.NewID.TabIndex = 3
    Me.ToolTip.SetToolTip(Me.NewID, "Enter the ID number of the item." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Decimal format only! No hexadecimal!")
    '
    'EditItemDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Control
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(441, 303)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "EditItemDialog"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Edit Selection..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    CType(Me.ItemPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents NewName As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents CurrentName As System.Windows.Forms.TextBox
  Friend WithEvents CurrentID As System.Windows.Forms.TextBox
  Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents ItemPreview As System.Windows.Forms.PictureBox
  Friend WithEvents NewID As System.Windows.Forms.TextBox

End Class
