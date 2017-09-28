Public Class FormOrdinance
    Dim DA_Ordinance As New DSOrdinanceTableAdapters.S_ORDINANCETableAdapter
    Private Sub FormOrdinance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridOrdinance.DataSource = DA_Ordinance.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateTextField(TxtOrdinance, "", ErrOrdinance) = False Then Exit Sub
        If DA_Ordinance.InsertNewOrdinance(TxtOrdinance.Text) = 1 Then
            GridOrdinance.DataSource = DA_Ordinance.GetData
            TxtOrdinance.Text = ""
        End If

    End Sub

    Private Sub BtnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub.Click
        If GridOrdinance.SelectedItems.Count = 0 Then Exit Sub
        If DA_Ordinance.DeleteOrdinance(GridOrdinance.GetRow.Cells("ORDERNONG_ID").Value) = 1 Then
            GridOrdinance.DataSource = DA_Ordinance.GetData
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtOrdinance, "", ErrOrdinance) = False Then Exit Sub
        If DA_Ordinance.UpdateOrdinance(TxtOrdinance.Text, GridOrdinance.GetRow.Cells("ORDERNONG_ID").Value) = 1 Then
            GridOrdinance.DataSource = DA_Ordinance.GetData
            TxtOrdinance.Text = ""
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GridOrdinance_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOrdinance.RowDoubleClick
        If GridOrdinance.SelectedItems.Count = 0 Then Exit Sub
        TxtOrdinance.Text = GridOrdinance.GetRow.Cells("LABEL_ORDERNONG").Value
    End Sub
End Class