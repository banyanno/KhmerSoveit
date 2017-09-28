Public Class OrgGive
    Dim DA_Offer As New DSConsultTableAdapters.ORG_OFFERTableAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtOffer, "", ErrOffer) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save org offer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Offer.InsertOffer(TxtOffer.Text) = 1 Then
                    RefreshOffer()
                End If
            End If
           
        Else
            If MessageBox.Show("Do you want update org offer?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Offer.UpdateOffer(TxtOffer.Text, LblSaveOption.Text) = 1 Then
                    RefreshOffer()
                End If
            End If
        End If
    End Sub
    Private Sub RefreshOffer()
        GridOffer.DataSource = DA_Offer.GetData
        LblSaveOption.Text = "0"
        TxtOffer.Text = ""
    End Sub

    Private Sub OrgGive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshOffer()
    End Sub

    Private Sub GridOffer_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOffer.RowDoubleClick
        If GridOffer.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridOffer.GetRow.Cells("OFFER_ID").Value
        TxtOffer.Text = GridOffer.GetRow.Cells("OFFER").Value
    End Sub

    Private Sub BtnDeleteOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteOffer.Click
        If GridOffer.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete this offer?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Offer.DeleteOffer(GridOffer.GetRow.Cells("OFFER_ID").Value) = 1 Then
                RefreshOffer()
            End If
        End If
    End Sub

    Private Sub BtnNewOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewOffer.Click
        LblSaveOption.Text = "0"
        TxtOffer.Text = ""
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class