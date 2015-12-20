<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLocationDialog
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
    Me.Location_Z = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.Location_Y = New System.Windows.Forms.TextBox
    Me.Location_X = New System.Windows.Forms.TextBox
    Me.LocationName = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 175)
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
    Me.GroupBox2.Controls.Add(Me.Location_Z)
    Me.GroupBox2.Controls.Add(Me.Label8)
    Me.GroupBox2.Controls.Add(Me.Location_Y)
    Me.GroupBox2.Controls.Add(Me.Location_X)
    Me.GroupBox2.Controls.Add(Me.LocationName)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(411, 149)
    Me.GroupBox2.TabIndex = 5
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Add Location"
    '
    'Location_Z
    '
    Me.Location_Z.Location = New System.Drawing.Point(78, 105)
    Me.Location_Z.MaxLength = 2
    Me.Location_Z.Name = "Location_Z"
    Me.Location_Z.Size = New System.Drawing.Size(100, 20)
    Me.Location_Z.TabIndex = 7
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(53, 108)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(19, 13)
    Me.Label8.TabIndex = 6
    Me.Label8.Text = "Z:"
    '
    'Location_Y
    '
    Me.Location_Y.Location = New System.Drawing.Point(78, 79)
    Me.Location_Y.MaxLength = 4
    Me.Location_Y.Name = "Location_Y"
    Me.Location_Y.Size = New System.Drawing.Size(100, 20)
    Me.Location_Y.TabIndex = 5
    '
    'Location_X
    '
    Me.Location_X.Location = New System.Drawing.Point(78, 53)
    Me.Location_X.MaxLength = 4
    Me.Location_X.Name = "Location_X"
    Me.Location_X.Size = New System.Drawing.Size(100, 20)
    Me.Location_X.TabIndex = 4
    '
    'LocationName
    '
    Me.LocationName.Location = New System.Drawing.Point(78, 27)
    Me.LocationName.MaxLength = 45
    Me.LocationName.Name = "LocationName"
    Me.LocationName.Size = New System.Drawing.Size(281, 20)
    Me.LocationName.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(53, 82)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(19, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Y:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(29, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(43, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Name:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(53, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(19, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "X:"
    '
    'TextBox1
    '
    Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.Location = New System.Drawing.Point(12, 167)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(259, 45)
    Me.TextBox1.TabIndex = 6
    Me.TextBox1.Text = "Hint: For ""Name"" use the keyword ""GCat"", ""Cat"", or ""Sub"" to create Global Categor" & _
        "ies, Categories, or Sub-Categories respectively."
    '
    'AddLocationDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(435, 216)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AddLocationDialog"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Add Location..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Location_Z As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Location_Y As System.Windows.Forms.TextBox
  Friend WithEvents Location_X As System.Windows.Forms.TextBox
  Friend WithEvents LocationName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
