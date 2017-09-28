Public Class FormPayablename

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtAccountName, "", ErrAccountname) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new account payable?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim ObjAccountName As New ACCOUNT_PAYABLE
                Dim OpticalIMP As New OpticalshopImp
                ObjAccountName.AccountName = TxtAccountName.Text
                ObjAccountName.Description = TxtDescription.Text
                If OpticalIMP.SaveNewNameAccountPayable(ObjAccountName) = True Then
                    MessageBox.Show("Save new account payable name successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new account payable name.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            
        Else
            If MessageBox.Show("Do you want update account payable?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim OpticalIMP As New OpticalshopImp
                Dim ObjAccountName As ACCOUNT_PAYABLE = OpticalIMP.GetNameAccountPayable(LblSaveOption.Text)
                ObjAccountName.AccountName = TxtAccountName.Text
                ObjAccountName.Description = TxtDescription.Text
                If OpticalIMP.UpdateReceiptPay = True Then
                    MessageBox.Show("Update account payable name successful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update account payable name.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class