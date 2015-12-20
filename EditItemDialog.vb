Imports System.Windows.Forms

Public Class EditItemDialog

  Private Sub EditItemDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If ((Me.CurrentID.Text <> "GCat") And (Me.CurrentID.Text <> "Cat") And (Me.CurrentID.Text <> "Sub")) Then
      ItemPreview.Image = Ultima.Art.GetStatic(Convert.ToInt32(Me.CurrentID.Text, 16))
    End If
  End Sub

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

End Class
