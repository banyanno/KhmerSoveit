Public Class SetExchageRate
    Dim DA_Rate As New DS_KSPAYMENTTableAdapters.S_EXCHANGE_RATETableAdapter
    Private Sub TxtExChangeRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExChangeRate.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateTextField(TxtExChangeRate, "", ErrorExchage) = False Then Exit Sub
        If MessageBox.Show("Do you want to set new exchage rate", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DA_Rate.DeleteExchage()
            If DA_Rate.InsertNewexchageRate(EmptyString(TxtExChangeRate.Text)) = 1 Then
                Close()
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class