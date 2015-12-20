<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpDialog))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.TextBox2 = New System.Windows.Forms.TextBox
    Me.TextBox3 = New System.Windows.Forms.TextBox
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(348, 424)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(75, 29)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.OK_Button.Location = New System.Drawing.Point(4, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(67, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Panel1
    '
    Me.Panel1.AutoScroll = True
    Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Panel1.Controls.Add(Me.GroupBox3)
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Location = New System.Drawing.Point(2, 2)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(431, 412)
    Me.Panel1.TabIndex = 1
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.TextBox3)
    Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(421, 70)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Introduction"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.TextBox1)
    Me.GroupBox2.Location = New System.Drawing.Point(3, 79)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(421, 123)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "How do I add to a list?"
    '
    'TextBox1
    '
    Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox1.Location = New System.Drawing.Point(6, 19)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ReadOnly = True
    Me.TextBox1.Size = New System.Drawing.Size(410, 97)
    Me.TextBox1.TabIndex = 0
    Me.TextBox1.Text = resources.GetString("TextBox1.Text")
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.TextBox2)
    Me.GroupBox3.Location = New System.Drawing.Point(3, 208)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(421, 190)
    Me.GroupBox3.TabIndex = 2
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "How do I add a new category or sub-category?"
    '
    'TextBox2
    '
    Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
    Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox2.Location = New System.Drawing.Point(6, 19)
    Me.TextBox2.Multiline = True
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(410, 164)
    Me.TextBox2.TabIndex = 0
    Me.TextBox2.Text = resources.GetString("TextBox2.Text")
    '
    'TextBox3
    '
    Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
    Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox3.Location = New System.Drawing.Point(6, 19)
    Me.TextBox3.Multiline = True
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(410, 45)
    Me.TextBox3.TabIndex = 0
    Me.TextBox3.Text = "While no formal help system exists yet in this version, this small FAQ of sorts w" & _
        "as included to ensure you could at east perform the basic functions involved wit" & _
        "h the use of the program."
    '
    'HelpDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
    Me.ClientSize = New System.Drawing.Size(435, 465)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MaximumSize = New System.Drawing.Size(441, 497)
    Me.MinimumSize = New System.Drawing.Size(441, 497)
    Me.Name = "HelpDialog"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Help and Support"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
