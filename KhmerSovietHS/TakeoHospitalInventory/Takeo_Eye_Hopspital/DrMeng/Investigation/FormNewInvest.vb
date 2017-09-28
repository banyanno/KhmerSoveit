Public Class FormNewInvest
    Dim DA_Invest As New DS_Invest_LaserTableAdapters.S_INVESTIGATETableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtInvestigate, "", ErrInvest) = False Then Exit Sub
        If ValidateTextField(TxtInvestPrice, "", ErrInvest) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("You want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Invest.InsertInvest(TxtInvestigate.Text, EmptyString(TxtInvestPrice.Text)) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("You want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Invest.UpdateInvest(TxtInvestigate.Text, EmptyString(TxtInvestPrice.Text), LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtInvestPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInvestPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class