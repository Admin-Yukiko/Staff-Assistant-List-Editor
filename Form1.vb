Public Class Form1

  Public BuildItemsList() As String
  Public MainItemsList() As String
  Public NPCsList() As String
  Public LocationsList() As String
  Public ActiveList As Integer

  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Control.CheckForIllegalCrossThreadCalls = False
    If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\building_materials.lst")) Then
      BuildItemsList = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\building_materials.lst").Replace(vbCrLf, "|").Split("|")
    Else
            MessageBox.Show("There was a fatal error loading the Building Creator list." & vbCrLf & vbCrLf & "The program will terminate." & vbCrLf & vbCrLf & "Please reinstall the Staff Assistant to correct the error.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      Me.Close()
      Exit Sub
    End If

    ListView1.GridLines = My.Settings.ShowGrid
    ToolStrip.Visible = My.Settings.ShowToolbar

    StatusLabel.Text = "Loading Building Creator List..."
    BuildingCreatorListToolStripMenuItem.Checked = True
    Dim BuildingListDialog As New BuildingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      BuildingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    BuildingListDialog.Show(Me)
    Dim PopulateListThread As New System.Threading.Thread(AddressOf PopulateList_BuildingList)
    PopulateListThread.IsBackground = True
    PopulateListThread.Priority = Threading.ThreadPriority.Normal
    PopulateListThread.Start()

        Me.Text = "Staff Assistant List Editor: Building Creator List"

  End Sub

  Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    ListView1.Columns(1).Width = ListView1.Width - ((ListView1.Columns(0).Width + ListView1.Columns(2).Width) + 21)
    TableLayoutPanel2.Height = SplitContainer1.Height
  End Sub

  '############################################################'
  '######################## MAIN MENU #########################'
  '############################################################'

  'File > Select List > Building Creator List
  Private Sub BuildingCreatorListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildingCreatorListToolStripMenuItem.Click, BuildingCreatorListToolStripMenuItem1.Click
    ItemsListToolStripMenuItem.Checked = False
    NPCsListToolStripMenuItem.Checked = False
    TravelLocationsListToolStripMenuItem.Checked = False
        Me.Text = "Staff Assistant List Editor: Building Creator List"
    StatusLabel.Text = "Loading Building Creator List..."
    Dim BuildingListDialog As New BuildingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      BuildingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    BuildingListDialog.Show(Me)
    Dim PopulateListThread1 As New System.Threading.Thread(AddressOf PopulateList_BuildingList)

    PopulateListThread1.IsBackground = True
    PopulateListThread1.Priority = Threading.ThreadPriority.Normal
    PopulateListThread1.Name = "PopulateList_BuildingList"
    PopulateListThread1.Start()
  End Sub

  'File > Select List > Items List
  Private Sub ItemsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsListToolStripMenuItem.Click, ItemsListToolStripMenuItem1.Click
    BuildingCreatorListToolStripMenuItem.Checked = False
    NPCsListToolStripMenuItem.Checked = False
    TravelLocationsListToolStripMenuItem.Checked = False
        Me.Text = "Staff Assistant List Editor: Items List"
    StatusLabel.Text = "Loading Items List..."
    Dim BuildingListDialog As New BuildingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      BuildingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    BuildingListDialog.Show(Me)
    Dim PopulateListThread2 As New System.Threading.Thread(AddressOf PopulateList_ItemsList)
    PopulateListThread2.IsBackground = True
    PopulateListThread2.Priority = Threading.ThreadPriority.Normal
    PopulateListThread2.Name = "PopulateList_ItemsList"
    PopulateListThread2.Start()
  End Sub

  'File > Select List > NPCs List
  Private Sub NPCsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NPCsListToolStripMenuItem.Click, NPCsListToolStripMenuItem1.Click
    BuildingCreatorListToolStripMenuItem.Checked = False
    ItemsListToolStripMenuItem.Checked = False
    TravelLocationsListToolStripMenuItem.Checked = False
        Me.Text = "Staff Assistant List Editor: NPCs List"
    StatusLabel.Text = "Loading NPCs List..."
    Dim BuildingListDialog As New BuildingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      BuildingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    BuildingListDialog.Show(Me)
    Dim PopulateListThread3 As New System.Threading.Thread(AddressOf PopulateList_NPCsList)
    PopulateListThread3.IsBackground = True
    PopulateListThread3.Priority = Threading.ThreadPriority.Normal
    PopulateListThread3.Name = "PopulateList_NPCsList"
    PopulateListThread3.Start()
  End Sub

  'File > Select List > Travel Locations List
  Private Sub TravelLocationsListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TravelLocationsListToolStripMenuItem.Click, TravelLocationsListToolStripMenuItem1.Click
    BuildingCreatorListToolStripMenuItem.Checked = False
    ItemsListToolStripMenuItem.Checked = False
    NPCsListToolStripMenuItem.Checked = False
        Me.Text = "Staff Assistant List Editor: Travel Locations List"
    StatusLabel.Text = "Loading Travel Locations List..."
    Dim BuildingListDialog As New BuildingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      BuildingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    BuildingListDialog.Show(Me)
    Dim PopulateListThread4 As New System.Threading.Thread(AddressOf PopulateList_TravelList)
    PopulateListThread4.IsBackground = True
    PopulateListThread4.Priority = Threading.ThreadPriority.Normal
    PopulateListThread4.Name = "PopulateList_TravelList"
    PopulateListThread4.Start()
  End Sub

  'File > Save
  Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
    StatusLabel.Text = "Saving list..."
    Dim SavingListDialog As New SavingListDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      SavingListDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    SavingListDialog.Show(Me)
    Dim SavingListThread As New System.Threading.Thread(AddressOf SaveList)
    SavingListThread.IsBackground = True
    SavingListThread.Priority = Threading.ThreadPriority.Normal
    SavingListThread.Name = "SaveList"
    SavingListThread.Start()
    While (SavingListThread.IsAlive = True)
      Application.DoEvents()
    End While
    SavingListDialog.Close()
    SavingListDialog.Dispose()
    StatusLabel.Text = "Ready"
  End Sub

  'File > Print (disabled!)
  Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

  End Sub

  'File > Exit
  Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Me.Close()
  End Sub


  'Edit > Undo (disabled!)
  Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click

  End Sub

  'Edit > Redo (disabled!)
  Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click

  End Sub

  'Edit > Cut (disabled!)
  Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click

  End Sub

  'Edit > Copy (disabled!)
  Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click

  End Sub

  'Edit > Paste (disabled!)
  Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click

  End Sub

  'Edit > Delete
  Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

  End Sub

  'Edit > Select > Select Word (disabled!)
  Private Sub SelectWordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectWordToolStripMenuItem.Click

  End Sub

  'Edit > Select > Select Line (disabled!)
  Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click

  End Sub


  'View > Show Toolbar
  Private Sub ShowToolbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolbarToolStripMenuItem.Click
    If (ShowToolbarToolStripMenuItem.Checked = True) Then
      ToolStrip.Visible = True
      My.Settings.ShowToolbar = True
    Else
      ToolStrip.Visible = False
      My.Settings.ShowToolbar = False
    End If
  End Sub

  'View > Grid
  Private Sub GridToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridToolStripMenuItem.Click
    If (GridToolStripMenuItem.Checked = True) Then
      ListView1.GridLines = True
      My.Settings.ShowGrid = True
    Else
      ListView1.GridLines = False
      My.Settings.ShowGrid = False
    End If
  End Sub


  'Tools > Add Wizard... (disabled!)
  Private Sub AddWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddWizardToolStripMenuItem.Click, WizardToolStripButton.Click
        'Select Case (ActiveList)
        'Case 1, 2
        'Dim AddItemWizard As New AddItemWizard
        'AddItemWizard.ShowDialog()
        'Case 3
        'Dim AddNPCWizard As New AddNPCWizard
        'AddNPCWizard.ShowDialog()
        'Case 4
        'Dim AddLocationWizard As New AddLocationWizard
        'AddLocationWizard.ShowDialog()
        'End Select
    End Sub


  'Help > Help
  Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click, HelpToolStripButton.Click
    Dim HelpDialog As New HelpDialog
    If (Me.WindowState = FormWindowState.Maximized) Then
      HelpDialog.StartPosition = FormStartPosition.CenterScreen
    End If
    HelpDialog.ShowDialog()
    HelpDialog.Dispose()
  End Sub

  'Help > About...
  Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    Dim AboutBox As New AboutBox
    AboutBox.ShowDialog()
    AboutBox.Dispose()
  End Sub


  Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
    OpenToolStripButton.ShowDropDown()
  End Sub

  '############################################################'
  '#################### LISTVIEW CONTROLS #####################'
  '############################################################'

  'Mouse Click (Right Button) on ListView
  Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick
    If (e.Button = Windows.Forms.MouseButtons.Right) Then
      Dim ClickLocation As ListViewHitTestInfo = ListView1.HitTest(e.X, e.Y)
      ListView1.Items(ClickLocation.Item.Index).Selected = True
    End If
  End Sub

  'Context Menu > Edit Selection...
  Private Sub EditSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelectionToolStripMenuItem.Click
    Select Case (ActiveList)
      Case 1, 2
        Dim EditItemDialog As New EditItemDialog
        EditItemDialog.CurrentID.Text = ListView1.SelectedItems(0).Text
        EditItemDialog.CurrentName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        EditItemDialog.NewID.Text = ListView1.SelectedItems(0).Text
        EditItemDialog.NewName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Dim ReturnedValue As DialogResult = EditItemDialog.ShowDialog()
        If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
          ListView1.SelectedItems(0).Text = EditItemDialog.NewID.Text
          ListView1.SelectedItems(0).SubItems(1).Text = EditItemDialog.NewName.Text
        End If
        EditItemDialog.Dispose()

      Case 3
        Dim EditNPCDialog As New EditNPCDialog
        EditNPCDialog.CurrentAnimation.Text = ListView1.SelectedItems(0).Text
        EditNPCDialog.CurrentName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        If ((ListView1.SelectedItems(0).Text <> "Cat") And (ListView1.SelectedItems(0).Text <> "Sub")) Then
          EditNPCDialog.CurrentHue.Text = ListView1.SelectedItems(0).SubItems(2).Text
        Else
          EditNPCDialog.CurrentHue.Visible = False
        End If
        EditNPCDialog.NewAnimation.Text = ListView1.SelectedItems(0).Text
        EditNPCDialog.NewName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        EditNPCDialog.NewHue.Text = ListView1.SelectedItems(0).SubItems(2).Text
        Dim ReturnedValue As DialogResult = EditNPCDialog.ShowDialog()
        If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
          ListView1.SelectedItems(0).Text = EditNPCDialog.NewAnimation.Text
          ListView1.SelectedItems(0).SubItems(1).Text = EditNPCDialog.NewName.Text
          If ((ListView1.SelectedItems(0).Text <> "Cat") And (ListView1.SelectedItems(0).Text <> "Sub")) Then
            ListView1.SelectedItems(0).SubItems(2).Text = EditNPCDialog.NewHue.Text
          End If
        End If
        EditNPCDialog.Dispose()

      Case 4
        Dim EditLocationDialog As New EditLocationDialog
        EditLocationDialog.CurrentName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        EditLocationDialog.CurrentX.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 0)
        EditLocationDialog.CurrentY.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 1)
        EditLocationDialog.CurrentZ.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 2)
        EditLocationDialog.NewName.Text = ListView1.SelectedItems(0).SubItems(1).Text
        EditLocationDialog.NewX.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 0)
        EditLocationDialog.NewY.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 1)
        EditLocationDialog.NewZ.Text = TokenizeString(ListView1.SelectedItems(0).Text, ",", 2)
        Dim ReturnedValue As DialogResult = EditLocationDialog.ShowDialog()
        If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
          ListView1.SelectedItems(0).SubItems(1).Text = EditLocationDialog.NewName.Text
          ListView1.SelectedItems(0).Text = EditLocationDialog.NewX.Text & "," & EditLocationDialog.NewY.Text & "," & EditLocationDialog.NewZ.Text
        End If
        EditLocationDialog.Dispose()

    End Select
  End Sub

  'Context Menu > Add Above...
  Private Sub AddAboveSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAboveSelectionToolStripMenuItem.Click
    Select Case (ActiveList)
      Case 1, 2
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddItemDialog As New AddItemDialog
          Dim ReturnedValue As DialogResult = AddItemDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddItemDialog.ItemID.Text
            NewItem.SubItems.Add(AddItemDialog.ItemName.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0), NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) - 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddItemDialog.Dispose()
        End If
      Case 3
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddNPCDialog As New AddNPCDialog
          Dim ReturnedValue As DialogResult = AddNPCDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddNPCDialog.NPCName.Text
            NewItem.SubItems.Add(AddNPCDialog.NPCID.Text)
            NewItem.SubItems.Add(AddNPCDialog.NPCHue.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0), NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) - 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddNPCDialog.Dispose()
        End If
      Case 4
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddLocationDialog As New AddLocationDialog
          Dim ReturnedValue As DialogResult = AddLocationDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddLocationDialog.Location_X.Text & "," & AddLocationDialog.Location_Y.Text & "," & AddLocationDialog.Location_Z.Text
            NewItem.SubItems.Add(AddLocationDialog.LocationName.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0), NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) - 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) - 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) - 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) - 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddLocationDialog.Dispose()
        End If
    End Select
  End Sub

  'Context Menu > Add Below...
  Private Sub AddBelowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBelowToolStripMenuItem.Click
    Select Case (ActiveList)
      Case 1, 2
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddItemDialog As New AddItemDialog
          Dim ReturnedValue As DialogResult = AddItemDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddItemDialog.ItemID.Text
            NewItem.SubItems.Add(AddItemDialog.ItemName.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0) + 1, NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) + 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddItemDialog.Dispose()
        End If
      Case 3
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddNPCDialog As New AddNPCDialog
          Dim ReturnedValue As DialogResult = AddNPCDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddNPCDialog.NPCName.Text
            NewItem.SubItems.Add(AddNPCDialog.NPCID.Text)
            NewItem.SubItems.Add(AddNPCDialog.NPCHue.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0) + 1, NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) + 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddNPCDialog.Dispose()
        End If
      Case 4
        If (ListView1.SelectedIndices.Count = 1) Then
          Dim AddLocationDialog As New AddLocationDialog
          Dim ReturnedValue As DialogResult = AddLocationDialog.ShowDialog()
          If (ReturnedValue = Windows.Forms.DialogResult.OK) Then
            Dim NewItem As New ListViewItem
            NewItem.Text = AddLocationDialog.Location_X.Text & "," & AddLocationDialog.Location_Y.Text & "," & AddLocationDialog.Location_Z.Text
            NewItem.SubItems.Add(AddLocationDialog.LocationName.Text)
            ListView1.Items.Insert(ListView1.SelectedIndices(0) + 1, NewItem)
            ListView1.Items(ListView1.SelectedIndices(0) + 1).Focused = True
            If (AddItemDialog.ItemID.Text.ToLower = "gcat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.SteelBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Global Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "cat") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.CadetBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Category: " & AddItemDialog.ItemName.Text
            ElseIf (AddItemDialog.ItemID.Text.ToLower = "sub") Then
              ListView1.Items(ListView1.SelectedIndices(0) + 1).UseItemStyleForSubItems = True
              ListView1.Items(ListView1.SelectedIndices(0) + 1).BackColor = Color.LightBlue
              ListView1.Items(ListView1.SelectedIndices(0) + 1).ToolTipText = "Subcategory: " & AddItemDialog.ItemName.Text
            End If
          End If
          AddLocationDialog.Dispose()
        End If
    End Select

  End Sub

  'Context Menu > Delete Selection
  Private Sub DeleteSelectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectionToolStripMenuItem.Click
    If (ListView1.SelectedIndices.Count > 0) Then
      ListView1.SelectedItems(0).Remove()
    End If
  End Sub

  '############################################################'
  '################### SIDE TOOLBAR BUTTONS ###################'
  '############################################################'

  'Move UP Button Controls
  Private Sub MoveUpBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveUpBtn.MouseEnter
    MoveUpBtn.FlatAppearance.BorderSize = 1
  End Sub
  Private Sub MoveUpBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveUpBtn.MouseLeave
    MoveUpBtn.FlatAppearance.BorderSize = 0
  End Sub
  Private Sub MoveUpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveUpBtn.Click, MoveUpToolStripMenuItem.Click
    MoveItem(-1)
  End Sub

  'Move DOWN button controls
  Private Sub MoveDownBtn_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveDownBtn.MouseEnter
    MoveDownBtn.FlatAppearance.BorderSize = 1
  End Sub
  Private Sub MoveDownBtn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MoveDownBtn.MouseLeave
    MoveDownBtn.FlatAppearance.BorderSize = 0
  End Sub
  Private Sub MoveDownBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveDownBtn.Click, MoveDownToolStripMenuItem.Click
    MoveItem(1)
  End Sub

  '############################################################'
  '######################## FUNCTIONS #########################'
  '############################################################'

  Public Function MoveItem(ByVal distance As Integer) As Boolean
    If (ListView1.SelectedIndices.Count = 1) Then
      Dim ItemIndex As Integer = ListView1.SelectedIndices(0)
      If (((ItemIndex + distance) <= (ListView1.Items.Count - 1)) And ((ItemIndex + distance) >= 0)) Then
        ListView1.BeginUpdate()
        Dim TempItem As ListViewItem = ListView1.SelectedItems(0)
        ListView1.Items.RemoveAt(ItemIndex)
        ListView1.Items.Insert(ItemIndex + distance, TempItem)
        TempItem.Selected = True
        ListView1.EndUpdate()
      End If
    End If
  End Function

  Public Function TokenizeString(ByVal WorkingString As String, ByVal Token As String, ByVal Index As Integer) As String
    Dim Temp() As String = WorkingString.Split(Token)
    TokenizeString = Temp(Index)
  End Function

  '############################################################'
  '################# LIST POPULATION THREADS ##################'
  '############################################################'

  'PopulateListThread1
  Private Sub PopulateList_BuildingList(ByVal sender As System.Object)
    Dim BuildingListDialog As Form = Application.OpenForms("BuildingListDialog")

    ActiveList = 1
    ListView1.BeginUpdate()
    ListView1.Columns(0).Text = "Item ID"
    ListView1.Columns(1).Text = "Description"
    ListView1.Columns(2).Text = "unused"
    ListView1.Columns(2).Width = 0
    ListView1.Columns(1).Width = ListView1.Width - ((ListView1.Columns(0).Width + ListView1.Columns(2).Width) + 18)
    ListView1.Items.Clear()
    Dim lastKey As Integer = -1
    For Each line As String In BuildItemsList
      If (line.StartsWith("C")) Then
        lastKey += 1
        ListView1.Items.Add("Cat")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.CadetBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Category: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("S")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add("Sub")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.LightBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Subcategory: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("I")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add(line.Substring(52, line.Length - 52))
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, 50).TrimEnd(" "))
      End If
    Next line
    ListView1.EndUpdate()
    StatusLabel.Text = "Ready"
    BuildingListDialog.Close()
    BuildingListDialog.Dispose()
  End Sub

  'PopulateListThread2
  Private Sub PopulateList_ItemsList(ByVal sender As System.Object)
    Dim BuildingListDialog As Form = Application.OpenForms("BuildingListDialog")

    ActiveList = 2
    If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\items_list.lst")) Then
      MainItemsList = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\items_list.lst").Replace(vbCrLf, "|").Split("|")
    Else
            MessageBox.Show(Application.OpenForms(0), "There was a fatal error loading the Items list." & vbCrLf & vbCrLf & "The program will terminate." & vbCrLf & vbCrLf & "Please reinstall the Staff Assistant to correct the error.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      Me.Close()
      Exit Sub
    End If
    ListView1.BeginUpdate()
    ListView1.Columns(0).Text = "Item ID"
    ListView1.Columns(1).Text = "Description"
    ListView1.Columns(2).Text = "unused"
    ListView1.Columns(2).Width = 0
    ListView1.Columns(1).Width = ListView1.Width - ((ListView1.Columns(0).Width + ListView1.Columns(2).Width) + 18)
    ListView1.Items.Clear()
    Dim lastKey As Integer = -1
    For Each line As String In MainItemsList
      If (line.StartsWith("G")) Then
        lastKey += 1
        ListView1.Items.Add("GCat")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.SteelBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Global Category: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("C")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add("Cat")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.CadetBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Category: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("S")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add("Sub")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.LightBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Subcategory: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("I")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add(line.Substring(52, line.Length - 52))
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, 50).TrimEnd(" "))
      End If
    Next line
    ListView1.EndUpdate()
    StatusLabel.Text = "Ready"
    BuildingListDialog.Close()
    BuildingListDialog.Dispose()
  End Sub

  'PopulateListThread3
  Private Sub PopulateList_NPCsList(ByVal sender As System.Object)
    Dim BuildingListDialog As Form = Application.OpenForms("BuildingListDialog")

    ActiveList = 3
    If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\npc_list.lst")) Then
      NPCsList = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\npc_list.lst").Replace(vbCrLf, "|").Split("|")
    Else
            MessageBox.Show(Application.OpenForms(0), "There was a fatal error loading the NPCs list." & vbCrLf & vbCrLf & "The program will terminate." & vbCrLf & vbCrLf & "Please reinstall the Staff Assistant to correct the error.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      Me.Close()
      Exit Sub
    End If
    ListView1.BeginUpdate()
    ListView1.Columns(0).Text = "Animation ID"
    ListView1.Columns(1).Text = "Name"
    ListView1.Columns(2).Text = "Display Hue"
    ListView1.Columns(2).Width = 80
    ListView1.Columns(1).Width = ListView1.Width - ((ListView1.Columns(0).Width + ListView1.Columns(2).Width) + 18)
    ListView1.Items.Clear()
    Dim lastKey As Integer = -1
    For Each line As String In NPCsList

      If (line.StartsWith("G")) Then
        lastKey += 1
        ListView1.Items.Add("Cat")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.CadetBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Category: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If (line.StartsWith("S")) Then
        lastKey += 1
        ListView1.Items.Add("Sub")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.LightBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Subcategory: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("N")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        Continue For
      End If
      If ((line.StartsWith("B")) And (lastKey >= 0)) Then
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        Continue For
      End If
      If ((line.StartsWith("C")) And (lastKey >= 0)) Then
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        Continue For
      End If
    Next line
    ListView1.EndUpdate()
    StatusLabel.Text = "Ready"
    BuildingListDialog.Close()
    BuildingListDialog.Dispose()
  End Sub

  'PopulateListThread4
  Private Sub PopulateList_TravelList(ByVal sender As System.Object)
    Dim BuildingListDialog As Form = Application.OpenForms("BuildingListDialog")

    ActiveList = 4
    If (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\locations_list.lst")) Then
      LocationsList = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory & "\resources\lists\locations_list.lst").Replace(vbCrLf, "|").Split("|")
    Else
            MessageBox.Show(Application.OpenForms(0), "There was a fatal error loading the Travel Locations list." & vbCrLf & vbCrLf & "The program will terminate." & vbCrLf & vbCrLf & "Please reinstall the Staff Assistant to correct the error.", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      Me.Close()
      Exit Sub
    End If
    ListView1.BeginUpdate()
    ListView1.Columns(0).Text = "Coordinates"
    ListView1.Columns(1).Text = "Description"
    ListView1.Columns(2).Text = "unused"
    ListView1.Columns(0).Width = 90
    ListView1.Columns(2).Width = 0
    ListView1.Columns(1).Width = ListView1.Width - ((ListView1.Columns(0).Width + ListView1.Columns(2).Width) + 18)
    ListView1.Items.Clear()
    Dim lastKey As Integer = -1
    For Each line As String In LocationsList
      If (line.StartsWith("C")) Then
        lastKey += 1
        ListView1.Items.Add("Cat")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.CadetBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Category: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("S")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add("Sub")
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).BackColor = Color.LightBlue
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, line.Length - 2))
        ListView1.Items(lastKey).ToolTipText = "Subcategory: " & line.Substring(2, line.Length - 2)
        Continue For
      End If
      If ((line.StartsWith("I")) And (lastKey >= 0)) Then
        lastKey += 1
        ListView1.Items.Add(line.Substring(52, line.Length - 52))
        ListView1.Items(lastKey).UseItemStyleForSubItems = True
        ListView1.Items(lastKey).SubItems.Add(line.Substring(2, 50).TrimEnd(" "))
      End If
    Next line
    ListView1.EndUpdate()
    StatusLabel.Text = "Ready"
    BuildingListDialog.Close()
    BuildingListDialog.Dispose()
  End Sub

  '############################################################'
  '####################### SAVE THREAD ########################'
  '############################################################'

  Public Sub SaveList(ByVal sender As System.Object)
    For Each Item As ListViewItem In ListView1.Items
      Select Case (ActiveList)
        Case 1, 2
          If (Item.Text = "GCat") Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "G=" & Item.SubItems(1).Text & vbCrLf, True)
          ElseIf (Item.Text = "Cat") Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "C=" & Item.SubItems(1).Text & vbCrLf, True)
          ElseIf (Item.Text = "Sub") Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "S=" & Item.SubItems(1).Text & vbCrLf, True)
          Else
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "I=" & Item.SubItems(1).Text.PadRight(50) & Item.Text & vbCrLf, True)
          End If

        Case 3
					If (Item.Text = "Cat") Then
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "G=" & Item.SubItems(1).Text & vbCrLf, True)
					ElseIf (Item.Text = "Sub") Then
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "S=" & Item.SubItems(1).Text & vbCrLf, True)
					Else
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "N=" & Item.Text & vbCrLf, True)
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "B=" & Item.SubItems(1).Text & vbCrLf, True)
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "C=" & Item.SubItems(2).Text & vbCrLf, True)
					End If

				Case 4
					If (Item.Text = "Cat") Then
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "C=" & Item.SubItems(1).Text & vbCrLf, True)
					ElseIf (Item.Text = "Sub") Then
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "S=" & Item.SubItems(1).Text & vbCrLf, True)
					Else
						My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", "I=" & Item.SubItems(1).Text.PadRight(50) & Item.Text & vbCrLf, True)
					End If

			End Select

		Next Item

		Select Case (ActiveList)
			Case 1
				My.Computer.FileSystem.MoveFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", My.Computer.FileSystem.CurrentDirectory & "\resources\lists\building_materials.lst", True)
			Case 2
				My.Computer.FileSystem.MoveFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", My.Computer.FileSystem.CurrentDirectory & "\resources\lists\items_list.lst", True)
			Case 3
				My.Computer.FileSystem.MoveFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", My.Computer.FileSystem.CurrentDirectory & "\resources\lists\npc_list.lst", True)
			Case 4
				My.Computer.FileSystem.MoveFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ns~templist.tmp", My.Computer.FileSystem.CurrentDirectory & "\resources\lists\locations_list.lst", True)
		End Select



	End Sub

End Class
