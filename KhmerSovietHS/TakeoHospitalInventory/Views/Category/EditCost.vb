Public Class EditCost
    Dim DA_ReceivedInfo As New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
    Private Sub txtNewCost_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNewCost.KeyUp
        TxtNewTotalCost.Text = CDbl(EmptyString(txtNewCost.Text)) * CDbl(EmptyString(TxtQTY.Text))
    End Sub

    Private Sub EditCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNewCost.Select()
        txtNewCost.SelectAll()
        txtNewCost.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Do you want to update new cost this Item?", "Edite Cost", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_ReceivedInfo.UpdateNewCost(EmptyString(txtNewCost.Text), EmptyString(TxtNewTotalCost.Text), lblSaveOption.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtNewCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewCost.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class