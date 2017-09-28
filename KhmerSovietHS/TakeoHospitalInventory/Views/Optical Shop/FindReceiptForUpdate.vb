Public Class FindReceiptForUpdate

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(ReceiptNo, "", ErrOptdate) = False Then Exit Sub
        If ValidateTextField(txtPatientName, "", ErrOptdate) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceipt, "", ErrOptdate) = False Then Exit Sub
        If MessageBox.Show("Do you want update date receipt in optical shop?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If LblSaveOption.Text = "0" Then
                'Update only table RECEIPT in OPT= Nill
                ModUpdateDateOPT.UPdate_Date_OPT_NIll(LblOPTIDDetial.Text, DateReceipt.Value.Date)
                ModUpdateDateOPT.Update_Date_OPTDetial(LblOPTIDDetial.Text, DateReceipt.Value.Date)

            Else
                'Udate both table patient receipt and receipt in OPT
                ModUpdateDateOPT.UpdateDate_RECEIPT(LblSaveOption.Text, DateReceipt.Value.Date)
                ModUpdateDateOPT.UpdateDATE_OPT(LblSaveOption.Text, DateReceipt.Value.Date)
                ModUpdateDateOPT.Update_Date_OPTDetial(LblOPTIDDetial.Text, DateReceipt.Value.Date)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class