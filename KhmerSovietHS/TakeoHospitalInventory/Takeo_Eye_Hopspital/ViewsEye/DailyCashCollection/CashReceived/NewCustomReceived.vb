Public Class NewCustomReceived
    Dim DA_Client As New DSPatientReceiptTableAdapters.CASH_RECEIVED_CUSTOMERTableAdapter
    Dim DA_Patient As New DSPatientReceiptTableAdapters.TblPatientsTableAdapter
   
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtCusName, "", ErroClientInfor) = False Then Exit Sub
        If ValidateTextField(TxtCusNameEng, "", ErroClientInfor) = False Then Exit Sub
        If ValidateCombobox(CboSex, "", ErroClientInfor) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErroClientInfor) = False Then Exit Sub
        If ValidateTextField(TxtMoreInfo, "", ErroClientInfor) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save client?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Client.InsertNewClient(TxtCusName.Text, TxtCusNameEng.Text, CboSex.Text, TxtAge.Text, TxtMoreInfo.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to client client info?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Client.UpdateClient(TxtCusName.Text, TxtCusNameEng.Text, CboSex.Text, TxtAge.Text, TxtMoreInfo.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        Dim tblTem As DataTable = DA_Patient.FindPatientNo(EmptyString(TxtPatientNo.Text))
        If tblTem.Rows.Count <= 0 Then
            MessageBox.Show("Patient No not found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPatientNo.Select()
            TxtPatientNo.SelectAll()
            TxtCusName.Text = ""
            TxtCusNameEng.Text = ""
            TxtAge.Text = ""
            CboSex.Text = ""
        Else
            For Each Rows As DataRow In tblTem.Rows
                TxtCusName.Text = Rows("NameKhmer")
                TxtCusNameEng.Text = Rows("NameEng")
                TxtAge.Text = Rows("Age")
                CboSex.Text = Rows("Sex")
            Next
        End If
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub ChPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPatientNo.CheckedChanged
        TxtPatientNo.Enabled = ChPatientNo.Checked
        BtnFindPatient.Enabled = ChPatientNo.Checked
        TxtPatientNo.Text = ""
        TxtCusName.Text = ""
        TxtCusNameEng.Text = ""
        TxtAge.Text = ""
        CboSex.Text = ""
    End Sub
End Class