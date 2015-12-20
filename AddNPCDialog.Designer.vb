<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNPCDialog
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
    Me.NPCID = New System.Windows.Forms.ComboBox
    Me.NPCHue = New System.Windows.Forms.TextBox
    Me.NPCName = New System.Windows.Forms.TextBox
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(202, 153)
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
    Me.GroupBox2.Controls.Add(Me.NPCID)
    Me.GroupBox2.Controls.Add(Me.NPCHue)
    Me.GroupBox2.Controls.Add(Me.NPCName)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(335, 126)
    Me.GroupBox2.TabIndex = 5
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Add NPC"
    '
    'NPCID
    '
    Me.NPCID.AutoCompleteCustomSource.AddRange(New String() {"GCat", "Cat", "Sub", "Ogre, 1", "Ettin, 2", "Zombie, 3", "Gargoyle, 4", "Eagle, 5", "Generic, 6", "Orc Captain, 7", "Corpser, 8", "Daemon, 9", "Daemon, 10", "Dragons Grey, 12", "Air Elemental, 13", "Earth Elemental, 14", "Fire Elemental, 15", "Water Elemental, 16", "Orc, 17", "Ettin, 18", "Snake Giant, 21", "Gazer, 22", "Liche, 24", "Ghost, 26", "Spider Giant, 28", "Gorilla, 29", "Harpy, 30", "Headless, 31", "Lizardman, 33", "Lizardman, 35", "Lizardman, 36", "Mongbat, 39", "Orc, 41", "Ratman, 42", "Ratman, 44", "Ratman, 45", "Reaper, 47", "Scorpions Giant, 48", "Skeleton, 50", "Slime, 51", "Snake, 52", "Troll, 53", "Troll, 54", "Skeleton, 56", "Skeleton, 57", "Wisp, 58", "Dragons Red, 59", "Drake Grey, 60", "Drake Red, 61", "Terathan Warrior, 70", "Terathan Drone, 71", "Terathan Queen, 72", "Cyclops, 75", "Titan, 76", "Frog Giant, 80", "Bullfrog, 81", "Ophidian Mage, 85", "Ophidian Warrior, 86", "Ophidian Queen, 87", "Sea Serpent, 150", "Dolphin, 151", "Beetle Fire, 169", "Denkou Yajuu, 196", "Gouzen Ha, 199", "Horse Dappled Brown, 200", "Cat, 201", "Alligator Brown, 202", "Pig, 203", "Horse Dark Brown, 204", "Rabbit, 205", "Lava Lizard, 206", "Sheep, 207", "Hen, 208", "Goat Billy, 209", "Ostard Desert, 210", "Bear Black, 211", "Bear Grizzly, 212", "Bear Polar, 213", "Panther, 214", "Rat Giant, 215", "Cow Brown, 216", "Dog, 217", "Ostard Forest, 218", "Ostard Frenzied, 219", "Llama, 220", "Walrus, 221", "Sheep Shorn, 223", "Wolf Timber, 225", "Horse Dappled Grey, 226", "Horse Tan, 228", "Cow Spotted, 231", "Bull Brown, 232", "Bull Spotted, 233", "Stag, 234", "Doe, 237", "Rat Sewer, 238", "Kappa, 240", "Oni, 241", "Bimbobushi, 242", "Hai Riyo, 243", "Rune Beetle, 244", "Yomotsu Warrior, 245", "Kitsun Tsuki, 246", "Fan Dancer, 247", "Wild Guar, 248", "Yamandon, 249", "Tri Wolf, 250", "Vampyric Beast, 251", "Lady Of The Snow, 252", "Yomotsu Priest, 253", "Crane, 254", "Yomotsu Elder, 255", "Boar, 290", "Horse Pack, 291", "Llama Pack, 292", "Crystal Elemental, 300", "Treefellow, 301", "Skittering Hopper, 302", "Devourer, 303", "Flesh Golem, 304", "Gore Fiend, 305", "Impaler, 306", "Gibberling, 307", "Bonedemon, 308", "Patchskeleton, 309", "Wailingbanshee, 310", "Shadow Knight, 311", "Abysmal Horror, 312", "Darknight Creeper, 313", "Ravager, 314", "Flesh Renderer, 315", "Wander, 316", "Vampire Bat, 317", "Demon Knight, 318", "Mound Of Maggots, 319", "Male, 400", "Female, 401", "Blade Spirit, 574"})
    Me.NPCID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.NPCID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.NPCID.FormattingEnabled = True
    Me.NPCID.Items.AddRange(New Object() {"GCat", "Cat", "Sub", "Ogre, 1", "Ettin, 2", "Zombie, 3", "Gargoyle, 4", "Eagle, 5", "Generic, 6", "Orc Captain, 7", "Corpser, 8", "Daemon, 9", "Daemon, 10", "Dragons Grey, 12", "Air Elemental, 13", "Earth Elemental, 14", "Fire Elemental, 15", "Water Elemental, 16", "Orc, 17", "Ettin, 18", "Snake Giant, 21", "Gazer, 22", "Liche, 24", "Ghost, 26", "Spider Giant, 28", "Gorilla, 29", "Harpy, 30", "Headless, 31", "Lizardman, 33", "Lizardman, 35", "Lizardman, 36", "Mongbat, 39", "Orc, 41", "Ratman, 42", "Ratman, 44", "Ratman, 45", "Reaper, 47", "Scorpions Giant, 48", "Skeleton, 50", "Slime, 51", "Snake, 52", "Troll, 53", "Troll, 54", "Skeleton, 56", "Skeleton, 57", "Wisp, 58", "Dragons Red, 59", "Drake Grey, 60", "Drake Red, 61", "Terathan Warrior, 70", "Terathan Drone, 71", "Terathan Queen, 72", "Cyclops, 75", "Titan, 76", "Frog Giant, 80", "Bullfrog, 81", "Ophidian Mage, 85", "Ophidian Warrior, 86", "Ophidian Queen, 87", "Sea Serpent, 150", "Dolphin, 151", "Beetle Fire, 169", "Denkou Yajuu, 196", "Gouzen Ha, 199", "Horse Dappled Brown, 200", "Cat, 201", "Alligator Brown, 202", "Pig, 203", "Horse Dark Brown, 204", "Rabbit, 205", "Lava Lizard, 206", "Sheep, 207", "Hen, 208", "Goat Billy, 209", "Ostard Desert, 210", "Bear Black, 211", "Bear Grizzly, 212", "Bear Polar, 213", "Panther, 214", "Rat Giant, 215", "Cow Brown, 216", "Dog, 217", "Ostard Forest, 218", "Ostard Frenzied, 219", "Llama, 220", "Walrus, 221", "Sheep Shorn, 223", "Wolf Timber, 225", "Horse Dappled Grey, 226", "Horse Tan, 228", "Cow Spotted, 231", "Bull Brown, 232", "Bull Spotted, 233", "Stag, 234", "Doe, 237", "Rat Sewer, 238", "Kappa, 240", "Oni, 241", "Bimbobushi, 242", "Hai Riyo, 243", "Rune Beetle, 244", "Yomotsu Warrior, 245", "Kitsun Tsuki, 246", "Fan Dancer, 247", "Wild Guar, 248", "Yamandon, 249", "Tri Wolf, 250", "Vampyric Beast, 251", "Lady Of The Snow, 252", "Yomotsu Priest, 253", "Crane, 254", "Yomotsu Elder, 255", "Boar, 290", "Horse Pack, 291", "Llama Pack, 292", "Crystal Elemental, 300", "Treefellow, 301", "Skittering Hopper, 302", "Devourer, 303", "Flesh Golem, 304", "Gore Fiend, 305", "Impaler, 306", "Gibberling, 307", "Bonedemon, 308", "Patchskeleton, 309", "Wailingbanshee, 310", "Shadow Knight, 311", "Abysmal Horror, 312", "Darknight Creeper, 313", "Ravager, 314", "Flesh Renderer, 315", "Wander, 316", "Vampire Bat, 317", "Demon Knight, 318", "Mound Of Maggots, 319", "Male, 400", "Female, 401", "Blade Spirit, 574"})
    Me.NPCID.Location = New System.Drawing.Point(100, 27)
    Me.NPCID.Name = "NPCID"
    Me.NPCID.Size = New System.Drawing.Size(200, 21)
    Me.NPCID.TabIndex = 6
    '
    'NPCHue
    '
    Me.NPCHue.Location = New System.Drawing.Point(100, 80)
    Me.NPCHue.MaxLength = 7
    Me.NPCHue.Name = "NPCHue"
    Me.NPCHue.Size = New System.Drawing.Size(100, 20)
    Me.NPCHue.TabIndex = 5
    '
    'NPCName
    '
    Me.NPCName.Location = New System.Drawing.Point(100, 54)
    Me.NPCName.MaxLength = 45
    Me.NPCName.Name = "NPCName"
    Me.NPCName.Size = New System.Drawing.Size(200, 20)
    Me.NPCName.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(15, 83)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(79, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Display Hue:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(39, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(55, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Anim ID:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(51, 57)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Name:"
    '
    'TextBox1
    '
    Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
    Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.Location = New System.Drawing.Point(12, 144)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(187, 45)
    Me.TextBox1.TabIndex = 6
    Me.TextBox1.Text = "Hint: For Anim ID use the keyword ""GCat"", ""Cat"", or ""Sub"" to create Global Catego" & _
        "ries, Categories, or Sub-Categories respectively."
    '
    'AddNPCDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(360, 194)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.TextBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AddNPCDialog"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Add NPC..."
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
  Friend WithEvents NPCID As System.Windows.Forms.ComboBox
  Friend WithEvents NPCHue As System.Windows.Forms.TextBox
  Friend WithEvents NPCName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
