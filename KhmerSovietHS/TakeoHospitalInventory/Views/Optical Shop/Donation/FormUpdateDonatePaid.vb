Public Class FormUpdateDonatePaid

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LoadDonationInfo()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
    Sub LoadDonationInfo()
        With CboDonate
            .DataSource = ModDonation.GetDonation()
            .ValueMember = "DonationID"
            .DisplayMember = "DonationName"
        End With
        With Me.CboSurgery
            .DataSource = ModSurgeries.SelectSurgeries()
            .DisplayMember = "Surgeries"
            .ValueMember = "SID"
            '.Text = ""
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub TxtDonatePaid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonatePaid.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboDonate, "", ErrUpdateDonate) = False Then Exit Sub
        If ValidateTextField(TxtDonatePaid, "", ErrUpdateDonate) = False Then Exit Sub
        If MessageBox.Show("Do you want update donate paid?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Dim OpticalImp As New OpticalshopImp
            'Dim ObjRecieptPatient As tblPatientReceipt = OpticalImp.GetTblPatientReceipt(TxtReceiptNo.Text)
            'ObjRecieptPatient.DonationID = CboDonate.SelectedValue
            'ObjRecieptPatient.DonationName = CboDonate.Text
            'ObjRecieptPatient.DonationPay = TxtDonatePaid.Text
            If ModDonation.UpdateDonatedPay(LblSaveOption.Text, CboDonate.SelectedValue, CboDonate.Text, EmptyString(TxtPatientPaid.Text), EmptyString(TxtDonatePaid.Text), EmptyString(TxtHospitalFee.Text), DateDonate.Value.Date, CboSurgery.Text) > 0 Then
                MessageBox.Show("Update Donate paid succesful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error update donate paid.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub TxtPatientPaid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientPaid.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtHospitalFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHospitalFee.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class