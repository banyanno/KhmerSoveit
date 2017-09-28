Public Class UsageLabel
    Dim DA_Usage As New DSOrdinanceTableAdapters.S_USINAGETableAdapter

    Private Sub UsageLabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridUsage.DataSource = DA_Usage.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateTextField(TxtOrdinance, "", ErrUsage) = False Then Exit Sub
        If DA_Usage.InsertNewUsage(TxtOrdinance.Text) = 1 Then
            GridUsage.DataSource = DA_Usage.GetData
            TxtOrdinance.Text = ""
        End If
    End Sub

    Private Sub BtnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub.Click
        If GridUsage.SelectedItems.Count = 0 Then Exit Sub
        If DA_Usage.DeleteUsage(GridUsage.GetRow.Cells("USING_ID").Value) = 1 Then
            GridUsage.DataSource = DA_Usage.GetData
            TxtOrdinance.Text = ""
        End If
    End Sub

    Private Sub GridUsage_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridUsage.RowDoubleClick
        If GridUsage.SelectedItems.Count = 0 Then Exit Sub
        TxtOrdinance.Text = GridUsage.GetRow.Cells("USING_LABEL").Value
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If GridUsage.SelectedItems.Count = 0 Then Exit Sub
        If DA_Usage.UpdateUsage(TxtOrdinance.Text, GridUsage.GetRow.Cells("USING_ID").Value) = 1 Then
            GridUsage.DataSource = DA_Usage.GetData
            TxtOrdinance.Text = ""
        End If


    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class