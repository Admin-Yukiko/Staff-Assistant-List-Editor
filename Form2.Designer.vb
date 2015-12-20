<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    Me.DataGridView1 = New System.Windows.Forms.DataGridView
    Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DisplayHue = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'DataGridView1
    '
    Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
    Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.Description, Me.DisplayHue})
    Me.DataGridView1.EnableHeadersVisualStyles = False
    Me.DataGridView1.Location = New System.Drawing.Point(23, 26)
    Me.DataGridView1.MultiSelect = False
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
    Me.DataGridView1.RowHeadersVisible = False
    Me.DataGridView1.RowHeadersWidth = 40
    Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
    Me.DataGridView1.RowTemplate.DividerHeight = 1
    Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.DataGridView1.Size = New System.Drawing.Size(488, 420)
    Me.DataGridView1.StandardTab = True
    Me.DataGridView1.TabIndex = 0
    '
    'ItemID
    '
    Me.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.ItemID.FillWeight = 45.68528!
    Me.ItemID.HeaderText = "Item ID"
    Me.ItemID.MinimumWidth = 60
    Me.ItemID.Name = "ItemID"
    '
    'Description
    '
    Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.Description.FillWeight = 68.37855!
    Me.Description.HeaderText = "Description"
    Me.Description.Name = "Description"
    '
    'DisplayHue
    '
    Me.DisplayHue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
    Me.DisplayHue.FillWeight = 35.93617!
    Me.DisplayHue.HeaderText = "Display Hue"
    Me.DisplayHue.MinimumWidth = 60
    Me.DisplayHue.Name = "DisplayHue"
    '
    'Form2
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(552, 485)
    Me.Controls.Add(Me.DataGridView1)
    Me.Name = "Form2"
    Me.Text = "Form2"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DisplayHue As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
