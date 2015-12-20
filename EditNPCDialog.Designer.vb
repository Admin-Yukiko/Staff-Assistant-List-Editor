<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditNPCDialog
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
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.GroupBox3 = New System.Windows.Forms.GroupBox
    Me.AnimationPreview = New System.Windows.Forms.PictureBox
    Me.NewAnimation = New System.Windows.Forms.ComboBox
    Me.NewHue = New System.Windows.Forms.TextBox
    Me.NewName = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.CurrentHue = New System.Windows.Forms.TextBox
    Me.CurrentName = New System.Windows.Forms.TextBox
    Me.CurrentAnimation = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.TableLayoutPanel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    CType(Me.AnimationPreview, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(345, 316)
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
    Me.GroupBox2.Controls.Add(Me.GroupBox3)
    Me.GroupBox2.Controls.Add(Me.NewAnimation)
    Me.GroupBox2.Controls.Add(Me.NewHue)
    Me.GroupBox2.Controls.Add(Me.NewName)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(479, 175)
    Me.GroupBox2.TabIndex = 4
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Selection Edit..."
    '
    'GroupBox3
    '
    Me.GroupBox3.Controls.Add(Me.AnimationPreview)
    Me.GroupBox3.Location = New System.Drawing.Point(306, 19)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Size = New System.Drawing.Size(167, 149)
    Me.GroupBox3.TabIndex = 7
    Me.GroupBox3.TabStop = False
    Me.GroupBox3.Text = "Animation Preview"
    '
    'AnimationPreview
    '
    Me.AnimationPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.AnimationPreview.Location = New System.Drawing.Point(3, 16)
    Me.AnimationPreview.Name = "AnimationPreview"
    Me.AnimationPreview.Size = New System.Drawing.Size(161, 130)
    Me.AnimationPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.AnimationPreview.TabIndex = 0
    Me.AnimationPreview.TabStop = False
    '
    'NewAnimation
    '
    Me.NewAnimation.AutoCompleteCustomSource.AddRange(New String() {"Ogre", "Ettin", "Zombie", "Gargoyle", "Eagle", "Bird", "Orc Captain", "Corpser", "Daemon", "Dragons Grey", "Air Elemental", "Earth Elemental", "Fire Elemental", "Water Elemental", "Orc", "Snake Giant", "Gazer", "Liche", "Ghost", "Spider Giant", "Gorilla", "Harpy", "Headless", "Lizardman", "Mongbat", "Ratman", "Reaper", "Scorpions Giant", "Skeleton", "Slime", "Snake", "Troll", "Wisp", "Dragons Red", "Drake Grey", "Drake Red", "Terathan Warrior", "Terathan Drone", "Terathan Queen", "Cyclops", "Titan", "Frog Giant", "Bullfrog", "Ophidian Mage", "Ophidian Warrior", "Ophidian Queen", "Sea Serpent", "Dolphin", "Beetle Fire", "Denkou Yajuu", "Gouzen Ha", "Horse Dappled Brown", "Cat", "Alligator Brown", "Pig", "Horse Dark Brown", "Rabbit", "Lava Lizard", "Sheep", "Hen", "Goat Billy", "Ostard Desert", "Bear Black", "Bear Grizzly", "Bear Polar", "Panther", "Rat Giant", "Cow Brown", "Dog", "Ostard Forest", "Ostard Frenzied", "Llama", "Walrus", "Sheep Shorn", "Wolf Timber", "Horse Dappled Grey", "Horse Tan", "Cow Spotted", "Bull Brown", "Bull Spotted", "Stag", "Doe", "Rat Sewer", "Kappa", "Oni", "Bimbobushi", "Hai Riyo", "Rune Beetle", "Yomotsu Warrior", "Kitsun Tsuki", "Fan Dancer", "Wild Guar", "Yamandon", "Tri Wolf", "Vampyric Beast", "Lady Of The Snow", "Yomotsu Priest", "Crane", "Yomotsu Elder", "Boar", "Horse Pack", "Llama Pack", "Crystal Elemental", "Treefellow", "Skittering Hopper", "Devourer", "Flesh Golem", "Gore Fiend", "Impaler", "Gibberling", "Bonedemon", "Patchskeleton", "Wailingbanshee", "Shadow Knight", "Abysmal Horror", "Darknight Creeper", "Ravager", "Flesh Renderer", "Wander", "Vampire Bat", "Demon Knight", "Mound Of Maggots", "Male", "Female", "Blade Spirit"})
    Me.NewAnimation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
    Me.NewAnimation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.NewAnimation.FormattingEnabled = True
    Me.NewAnimation.Items.AddRange(New Object() {"1, Ogre", "2, Ettin", "3, Zombie", "4, Gargoyle", "5, Eagle", "6, Generic", "7, Orc Captain", "8, Corpser", "9, Daemon", "10, Daemon", "12, Dragons Grey", "13, Air Elemental", "14, Earth Elemental", "15, Fire Elemental", "16, Water Elemental", "17, Orc", "18, Ettin", "21, Snake Giant", "22, Gazer", "24, Liche", "26, Ghost", "28, Spider Giant", "29, Gorilla", "30, Harpy", "31, Headless", "33, Lizardman", "35, Lizardman", "36, Lizardman", "39, Mongbat", "41, Orc", "42, Ratman", "44, Ratman", "45, Ratman", "47, Reaper", "48, Scorpions Giant", "50, Skeleton", "51, Slime", "52, Snake", "53, Troll", "54, Troll", "56, Skeleton", "57, Skeleton", "58, Wisp", "59, Dragons Red", "60, Drake Grey", "61, Drake Red", "70, Terathan Warrior", "71, Terathan Drone", "72, Terathan Queen", "75, Cyclops", "76, Titan", "80, Frog Giant", "81, Bullfrog", "85, Ophidian Mage", "86, Ophidian Warrior", "87, Ophidian Queen", "150, Sea Serpent", "151, Dolphin", "169, Beetle Fire", "196, Denkou Yajuu", "199, Gouzen Ha", "200, Horse Dappled Brown", "201, Cat", "202, Alligator Brown", "203, Pig", "204, Horse Dark Brown", "205, Rabbit", "206, Lava Lizard", "207, Sheep", "208, Hen", "209, Goat Billy", "210, Ostard Desert", "211, Bear Black", "212, Bear Grizzly", "213, Bear Polar", "214, Panther", "215, Rat Giant", "216, Cow Brown", "217, Dog", "218, Ostard Forest", "219, Ostard Frenzied", "220, Llama", "221, Walrus", "223, Sheep Shorn", "225, Wolf Timber", "226, Horse Dappled Grey", "228, Horse Tan", "231, Cow Spotted", "232, Bull Brown", "233, Bull Spotted", "234, Stag", "237, Doe", "238, Rat Sewer", "240, Kappa", "241, Oni", "242, Bimbobushi", "243, Hai Riyo", "244, Rune Beetle", "245, Yomotsu Warrior", "246, Kitsun Tsuki", "247, Fan Dancer", "248, Wild Guar", "249, Yamandon", "250, Tri Wolf", "251, Vampyric Beast", "252, Lady Of The Snow", "253, Yomotsu Priest", "254, Crane", "255, Yomotsu Elder", "290, Boar", "291, Horse Pack", "292, Llama Pack", "300, Crystal Elemental", "301, Treefellow", "302, Skittering Hopper", "303, Devourer", "304, Flesh Golem", "305, Gore Fiend", "306, Impaler", "307, Gibberling", "308, Bonedemon", "309, Patchskeleton", "310, Wailingbanshee", "311, Shadow Knight", "312, Abysmal Horror", "313, Darknight Creeper", "314, Ravager", "315, Flesh Renderer", "316, Wander", "317, Vampire Bat", "318, Demon Knight", "319, Mound Of Maggots", "400, Male", "401, Female", "574, Blade Spirit"})
    Me.NewAnimation.Location = New System.Drawing.Point(100, 27)
    Me.NewAnimation.Name = "NewAnimation"
    Me.NewAnimation.Size = New System.Drawing.Size(200, 21)
    Me.NewAnimation.TabIndex = 6
    Me.ToolTip.SetToolTip(Me.NewAnimation, "Select an animation from the drop down menu or start typing a name to be given a " & _
            "list of matching entries.")
    '
    'NewHue
    '
    Me.NewHue.Location = New System.Drawing.Point(100, 80)
    Me.NewHue.MaxLength = 7
    Me.NewHue.Name = "NewHue"
    Me.NewHue.Size = New System.Drawing.Size(100, 20)
    Me.NewHue.TabIndex = 5
    Me.ToolTip.SetToolTip(Me.NewHue, "The hue to display the NPC as. This has no effect on the hue of the NPC created i" & _
            "n-game.")
    '
    'NewName
    '
    Me.NewName.Location = New System.Drawing.Point(100, 54)
    Me.NewName.MaxLength = 45
    Me.NewName.Name = "NewName"
    Me.NewName.Size = New System.Drawing.Size(200, 20)
    Me.NewName.TabIndex = 4
    Me.ToolTip.SetToolTip(Me.NewName, "The name of the NPC. This is what the server uses to create the NPC in-game.")
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
    Me.Label2.Location = New System.Drawing.Point(11, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(83, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Animation ID:"
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
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.CurrentHue)
    Me.GroupBox1.Controls.Add(Me.CurrentName)
    Me.GroupBox1.Controls.Add(Me.CurrentAnimation)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(479, 112)
    Me.GroupBox1.TabIndex = 3
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Current Values"
    '
    'CurrentHue
    '
    Me.CurrentHue.Location = New System.Drawing.Point(100, 70)
    Me.CurrentHue.MaxLength = 7
    Me.CurrentHue.Name = "CurrentHue"
    Me.CurrentHue.ReadOnly = True
    Me.CurrentHue.Size = New System.Drawing.Size(100, 20)
    Me.CurrentHue.TabIndex = 8
    Me.ToolTip.SetToolTip(Me.CurrentHue, "Current display hue.")
    '
    'CurrentName
    '
    Me.CurrentName.Location = New System.Drawing.Point(100, 44)
    Me.CurrentName.MaxLength = 45
    Me.CurrentName.Name = "CurrentName"
    Me.CurrentName.ReadOnly = True
    Me.CurrentName.Size = New System.Drawing.Size(200, 20)
    Me.CurrentName.TabIndex = 7
    Me.ToolTip.SetToolTip(Me.CurrentName, "Current NPC name.")
    '
    'CurrentAnimation
    '
    Me.CurrentAnimation.Location = New System.Drawing.Point(100, 18)
    Me.CurrentAnimation.MaxLength = 7
    Me.CurrentAnimation.Name = "CurrentAnimation"
    Me.CurrentAnimation.ReadOnly = True
    Me.CurrentAnimation.Size = New System.Drawing.Size(200, 20)
    Me.CurrentAnimation.TabIndex = 6
    Me.ToolTip.SetToolTip(Me.CurrentAnimation, "Current NPC animation ID.")
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(15, 73)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Display Hue:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(11, 21)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(83, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Animation ID:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(51, 47)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(43, 13)
    Me.Label6.TabIndex = 3
    Me.Label6.Text = "Name:"
    '
    'EditNPCDialog
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(503, 357)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "EditNPCDialog"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Edit Selection..."
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.GroupBox3.ResumeLayout(False)
    CType(Me.AnimationPreview, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents NewHue As System.Windows.Forms.TextBox
  Friend WithEvents NewName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents CurrentHue As System.Windows.Forms.TextBox
  Friend WithEvents CurrentName As System.Windows.Forms.TextBox
  Friend WithEvents CurrentAnimation As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents NewAnimation As System.Windows.Forms.ComboBox
  Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
  Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
  Friend WithEvents AnimationPreview As System.Windows.Forms.PictureBox

End Class
