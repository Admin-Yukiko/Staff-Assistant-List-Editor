<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddLocationWizard
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddLocationWizard))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.OK_Button = New System.Windows.Forms.Button
    Me.Cancel_Button = New System.Windows.Forms.Button
    Me.Wizard1 = New Divelements.WizardFramework.Wizard
    Me.IntroductionPage1 = New Divelements.WizardFramework.IntroductionPage
    Me.WizardPage1 = New Divelements.WizardFramework.WizardPage
    Me.FinishPage1 = New Divelements.WizardFramework.FinishPage
    Me.TableLayoutPanel1.SuspendLayout()
    Me.Wizard1.SuspendLayout()
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
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(339, 319)
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
    'Wizard1
    '
    Me.Wizard1.BannerImage = CType(resources.GetObject("Wizard1.BannerImage"), System.Drawing.Image)
    Me.Wizard1.Controls.Add(Me.IntroductionPage1)
    Me.Wizard1.Controls.Add(Me.WizardPage1)
    Me.Wizard1.Controls.Add(Me.FinishPage1)
    Me.Wizard1.Location = New System.Drawing.Point(0, 0)
    Me.Wizard1.MarginImage = CType(resources.GetObject("Wizard1.MarginImage"), System.Drawing.Image)
    Me.Wizard1.Name = "Wizard1"
    Me.Wizard1.SelectedPage = Me.IntroductionPage1
    Me.Wizard1.Size = New System.Drawing.Size(497, 360)
    Me.Wizard1.TabIndex = 1
    '
    'IntroductionPage1
    '
    Me.IntroductionPage1.IntroductionText = "This wizard will assist you in the task of adding a new location to the Location " & _
        "List on the Travel Tab."
    Me.IntroductionPage1.Location = New System.Drawing.Point(177, 66)
    Me.IntroductionPage1.Name = "IntroductionPage1"
    Me.IntroductionPage1.NextPage = Me.WizardPage1
    Me.IntroductionPage1.Size = New System.Drawing.Size(307, 234)
    Me.IntroductionPage1.TabIndex = 1004
    Me.IntroductionPage1.Text = "Welcome to the Add Wizard"
    '
    'WizardPage1
    '
    Me.WizardPage1.Description = "This should be a piece of descriptive text about this page."
    Me.WizardPage1.Location = New System.Drawing.Point(19, 73)
    Me.WizardPage1.Name = "WizardPage1"
    Me.WizardPage1.NextPage = Me.FinishPage1
    Me.WizardPage1.PreviousPage = Me.IntroductionPage1
    Me.WizardPage1.Size = New System.Drawing.Size(459, 227)
    Me.WizardPage1.TabIndex = 1005
    Me.WizardPage1.Text = "Wizard Page"
    '
    'FinishPage1
    '
    Me.FinishPage1.FinishText = "You have successfully completed the Sample Wizard."
    Me.FinishPage1.Location = New System.Drawing.Point(177, 66)
    Me.FinishPage1.Name = "FinishPage1"
    Me.FinishPage1.PreviousPage = Me.WizardPage1
    Me.FinishPage1.Size = New System.Drawing.Size(307, 234)
    Me.FinishPage1.TabIndex = 1006
    Me.FinishPage1.Text = "Completing the Sample Wizard"
    '
    'AddLocationWizard
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(497, 360)
    Me.Controls.Add(Me.Wizard1)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AddLocationWizard"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Add Wizard"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.Wizard1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents Wizard1 As Divelements.WizardFramework.Wizard
  Friend WithEvents IntroductionPage1 As Divelements.WizardFramework.IntroductionPage
  Friend WithEvents WizardPage1 As Divelements.WizardFramework.WizardPage
  Friend WithEvents FinishPage1 As Divelements.WizardFramework.FinishPage

End Class
