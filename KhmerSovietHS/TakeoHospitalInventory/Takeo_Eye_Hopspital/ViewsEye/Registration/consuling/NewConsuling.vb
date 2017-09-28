Public Class NewConsuling
    Dim DA_Daignosis As New DSConsultTableAdapters.TblSurgeryTableAdapter
    Dim DA_Surgery As New DSConsultTableAdapters.tblDiagSurgeriesTableAdapter
    Dim DA_Donater As New DSConsultTableAdapters.DONATIONTableAdapter
    Dim DA_Org_Offer As New DSConsultTableAdapters.ORG_OFFERTableAdapter
    Dim DA_Consulting As New DSConsultTableAdapters.CONSULINGTableAdapter
    Dim DA_Patient As New DSConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_FamilyStatus As New DSConsultTableAdapters.FAMILY_STATUSTableAdapter

    Dim DA_New_Old_Adapter As New DSPharmacy_V1TableAdapters.TblNew_Old_OutPatientTableAdapter

    ' Patient Note for Consult
    ' Value=1 is Old-Patient
    ' Value=2 is In-Patient
    ' Value=3 is OpticalShop
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'With CboFirstDiagnosis
        '    .DataSource = DA_Daignosis.GetData
        '    .ValueMember = DA_Daignosis.GetData.Columns("SID").ColumnName
        '    .DisplayMember = DA_Daignosis.GetData.Columns("Surgery").ColumnName
        '    .SelectedIndex = -1
        'End With
        'With CboFirstSurgery
        '    .DataSource = DA_Surgery.GetData
        '    .ValueMember = DA_Surgery.GetData.Columns("SID").ColumnName
        '    .DisplayMember = DA_Surgery.GetData.Columns("Surgeries").ColumnName
        '    .SelectedIndex = -1
        'End With


        With CboFamilyOccupation
            .DataSource = ModOccupation.SelectAllOccupation()
            .ValueMember = "Occupation"
            .SelectedValue = "OccNo"
            .Text = Nothing
        End With
        With CboSecondDiagnosis
            .DataSource = DA_Daignosis.GetData
            .ValueMember = DA_Daignosis.GetData.Columns("SID").ColumnName
            .DisplayMember = DA_Daignosis.GetData.Columns("Surgery").ColumnName
            .SelectedIndex = -1
        End With
        With CboSecondSurgery
            .DataSource = DA_Surgery.GetData
            .ValueMember = DA_Surgery.GetData.Columns("SID").ColumnName
            .DisplayMember = DA_Surgery.GetData.Columns("Surgeries").ColumnName
            .SelectedIndex = -1
        End With
        With CboPatientStatus
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
        With cboPatientMoney
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With

        With CboFamilyStatus
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
        With cboFamilyMoney
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
        With CboOrg
            .DataSource = DA_Donater.GetData
            .ValueMember = DA_Donater.GetData.Columns("DonationID").ColumnName
            .DisplayMember = DA_Donater.GetData.Columns("DonationName").ColumnName
            .SelectedIndex = -1
        End With
        With LsGive
            .Items.Clear()
            For Each row As DataRow In DA_Org_Offer.GetData
                .Items.Add(row("OFFER"))
            Next
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CboProNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProNo.GotFocus

        Try
            With CboProNo
                .DataSource = ModProvince.SelectProvice()
                .DisplayMember = "Province"
                .ValueMember = "IDProvCode"
                .Text = Nothing
                '.SelectAll()
            End With
            CboDisNo.Text = Nothing
            CboCommNo.Text = Nothing
            txtFamilyAddress.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Private Sub CboDisNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboDisNo.GotFocus

        Try
            With CboDisNo
                .DataSource = ModProvince.SelectDistrict(CInt(CboProNo.SelectedValue))
                .DisplayMember = "DISTRICT"
                .ValueMember = "SrokCode"
                .Text = Nothing
                '.SelectAll()
            End With
            CboCommNo.Text = Nothing
            txtFamilyAddress.Text = Nothing
        Catch ex As Exception

        End Try

    End Sub


    Private Sub CboCommNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboCommNo.GotFocus
        Try
            With CboCommNo
                .DataSource = ModProvince.SelectCommune(CInt(CboDisNo.SelectedValue))
                .DisplayMember = "Commune"
                .ValueMember = "KhumCode"
                .Text = Nothing
                '.SelectAll()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FindPatientNo(ByVal patientNo As Double)
        Dim TblPatient As DataTable = DA_Patient.GetDataByPatientNo(patientNo)
        If TblPatient.Rows.Count <= 0 Then
            MessageBox.Show("Patient No not found. Please check it again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPatientNo.Focus()
            TxtPatientNo.SelectAll()
            TxtPatientName.Text = ""
            TxtSex.Text = ""
            TxtAge.Text = ""
            TxtPatientOccupation.Text = ""
            TxtPatientAddress.Text = ""
        Else
            For Each Row As DataRow In TblPatient.Rows
                TxtPatientName.Text = Row("NameKhmer")
                TxtSex.Text = Row("Sex")
                TxtAge.Text = Row("Age")
                TxtPatientOccupation.Text = Row("Occupation")
                TxtPatientAddress.Text = Row("Address")
                CboProNo.Text = Row("Province")
                CboDisNo.Text = Row("District")
                CboCommNo.Text = Row("Commune")
                txtFamilyAddress.Text = Row("Address")
            Next
        End If
        Dim TblTempNew_Old As DataTable = DA_New_Old_Adapter.GetDataByBlankDiagnosis(patientNo, "")
        For Each DRowNew_Old As DataRow In TblTempNew_Old.Rows
            LblNew_OldID.Text = DRowNew_Old("NewOutPatientNo")
        Next
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Function CheckConsultFor(ByVal GB As GroupBox) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function


    Private Sub BtnOffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOffer.Click
        Dim NOffer As New OrgGive
        If NOffer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With LsGive
                .Items.Clear()
                For Each row As DataRow In DA_Org_Offer.GetData
                    .Items.Add(row("OFFER"))
                Next
            End With
        End If
    End Sub
    Private Function GetTextReferralV1() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To LsGive.Items.Count - 1
                If LsGive.GetItemChecked(i) = True Then
                    str = str & " + " & LsGive.Items(i).ToString
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Function ChecIsCheckReferall() As Boolean
        Dim CountCheck As Integer = 0
        For i As Int16 = 0 To LsGive.Items.Count - 1
            If LsGive.GetItemChecked(i) = True Then
                CountCheck = CountCheck + 1
            End If
        Next
        If CountCheck = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtPatientNo, "", ErrConsulting) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "", ErrConsulting) = False Then Exit Sub
        If ValidateTextField(TxtSex, "", ErrConsulting) = False Then Exit Sub
        If ValidateDateTimePicker(DateConsult, "", ErrConsulting) = False Then Exit Sub
        If ValidateCombobox(CboPatientStatus, "", ErrConsulting) = False Then Exit Sub
        If ValidateCombobox(cboPatientMoney, "", ErrConsulting) = False Then Exit Sub
        If ValidateTextField(TxtHospitalFee, "", ErrConsulting) = False Then Exit Sub
       
        'If ValidateCombobox(CboFirstDiagnosis, "", ErrConsulting) = False Then Exit Sub
        'If ValidateCombobox(CboFirstSurgery, "", ErrConsulting) = False Then Exit Sub
        ' If ValidateCombobox(CboOrg, "", ErrConsulting) = False Then Exit Sub
        If RadForInPatient.Checked = True Then
            If ValidateCombobox(CboSecondDiagnosis, "", ErrConsulting) = False Then Exit Sub
            If ValidateCombobox(CboSecondSurgery, "", ErrConsulting) = False Then Exit Sub
            If ValidateCombobox(CboEye, "", ErrConsulting) = False Then Exit Sub
            ' If ValidateTextField(TxtHospitalFee, "", ErrConsulting) = False Then Exit Sub

            If ModDiagnosis.CheckNameDiagnosis(CboSecondDiagnosis.Text) = 0 Then
                MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                CboSecondDiagnosis.Select()
                CboSecondDiagnosis.SelectAll()
                Exit Sub
            End If
            If ModDiagnosis.CheckNameSurgery(CboSecondSurgery.Text) = 0 Then
                MsgBox("Surgery Name not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                CboSecondSurgery.Select()
                CboSecondSurgery.SelectAll()
                Exit Sub
            End If
        Else
            'If ValidateTextField(TxtHospitalFee, "", ErrConsulting) = False Then Exit Sub
        End If


        If CheckConsultFor(GroupConsultFor) = False Then
            GroupConsultFor.BackColor = Color.Khaki
            MessageBox.Show("Please select option consulting for", "Consult", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            GroupConsultFor.BackColor = Color.Transparent
        End If


        If CheckConsultFor(GroupConsultPay) = False Then
            GroupConsultPay.BackColor = Color.Khaki
            MessageBox.Show("Please select option social service", "Consult", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            GroupConsultPay.BackColor = Color.Transparent
        End If
        If CheckConsultFor(GroupPatientPay) = False Then
            GroupConsultPay.BackColor = Color.Khaki
            MessageBox.Show("Please select option patient pay", "Consult", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            GroupConsultPay.BackColor = Color.Transparent
        End If

        Dim ValSocial_Type As String = ""
        Dim ValConsultFor As String = ""

        If RadForOld.Checked = True Then
            ValConsultFor = RadForOld.Text
        ElseIf RadForInPatient.Checked = True Then
            ValConsultFor = RadForInPatient.Text
        ElseIf RadForOpticalShop.Checked = True Then
            ValConsultFor = RadForOpticalShop.Text
        ElseIf RadForNewPatient.Checked = True Then
            ValConsultFor = RadForNewPatient.Text
        End If

        If RadSocial.Checked = True Then
            ValSocial_Type = RadSocial.Text
        ElseIf RadNil.Checked = True Then
            ValSocial_Type = RadNil.Text
        ElseIf RadFull.Checked = True Then
            ValSocial_Type = RadFull.Text
        End If
        ' Incase In-Patient With Nill option user must check Donate and refferto
        If RadForInPatient.Checked = True And RadNil.Checked = True Then
            If ValidateCombobox(CboOrg, "", ErrConsulting) = False Then Exit Sub
            If ValidateTextField(TxtDonateD, "", ErrConsulting) = False Then Exit Sub
        End If
        If RadForInPatient.Checked = True And RadSocial.Checked = True Then
            If ValidateCombobox(CboOrg, "", ErrConsulting) = False Then Exit Sub
            If ValidateTextField(TxtDonateD, "", ErrConsulting) = False Then Exit Sub
        End If
        ' End Of In patient consutl.........


        If RadForOpticalShop.Checked = True And RadNil.Checked = True Then
            If ChecIsCheckReferall() = False Then
                MessageBox.Show("Please check one in list offer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LsGive.BackColor = Color.Aqua
                Exit Sub
            Else
                LsGive.BackColor = Color.White
            End If
        End If

        If RadForOpticalShop.Checked = True And RadSocial.Checked = True Then
            If ChecIsCheckReferall() = False Then
                MessageBox.Show("Please check one in list offer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LsGive.BackColor = Color.Aqua
                Exit Sub
            Else
                LsGive.BackColor = Color.White
            End If
        End If

        ' Check In case hospital fee <100 R
        If CInt(TxtHospitalFee.Text) < 100 Then
            MessageBox.Show("Please enter hospital fee > 100 R", "Hospital Fee", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtHospitalFee.Select()
            TxtHospitalFee.Focus()
            Exit Sub
        End If
        If LblSaveOption.Text = "0" Then
            If RadForInPatient.Checked = True Then
                If DA_Consulting.CheckInCashRegisDuplicate(DateConsult.Value.Date, EmptyString(TxtPatientNo.Text), CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text).Rows.Count > 0 Then
                    MessageBox.Show("This patient consult already. Please check again", "Consult", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If MessageBox.Show("Do you want save new consulting?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If RadForNewPatient.Checked = True Then
                    If DA_Consulting.InsertConsulting(TxtPatientNo.Text, Now.Date, DateConsult.Value.Date, CboPatientStatus.Text, cboPatientMoney.Text, 1, "", "", CboOrg.Text, GetTextReferralV1, TxtOrgNote.Text, Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, EmptyString(TxtHospitalFee.Text), ValSocial_Type, CBool(IIf(RadPatientPayR.Checked = True, True, False)), CDbl(IIf(RadPatientPayR.Checked = True, EmptyString(TxtDonateR.Text), 0)), EmptyString(TxtDonateD.Text), TxtConsultNote.Text, USER_NAME, USER_NAME, ValConsultFor, CDbl(IIf(RadPatientPayD.Checked = True, EmptyString(TxtDonateR.Text), 0)), TxtFamilyName.Text, EmptyString(TxtFamilyAge.Text), cboFamilySex.Text, cboFamilyMoney.Text, CboFamilyStatus.Text, TxtFamilyRelative.Text, CboFamilyOccupation.Text, txtFamilyAddress.Text) = 1 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                ElseIf RadForOld.Checked = True Then
                    If DA_Consulting.InsertConsulting(TxtPatientNo.Text, Now.Date, DateConsult.Value.Date, CboPatientStatus.Text, cboPatientMoney.Text, 1, "", "", CboOrg.Text, GetTextReferralV1, TxtOrgNote.Text, Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, EmptyString(TxtHospitalFee.Text), ValSocial_Type, CBool(IIf(RadPatientPayR.Checked = True, True, False)), CDbl(IIf(RadPatientPayR.Checked = True, EmptyString(TxtDonateR.Text), 0)), EmptyString(TxtDonateD.Text), TxtConsultNote.Text, USER_NAME, USER_NAME, ValConsultFor, CDbl(IIf(RadPatientPayD.Checked = True, EmptyString(TxtDonateR.Text), 0)), TxtFamilyName.Text, EmptyString(TxtFamilyAge.Text), cboFamilySex.Text, cboFamilyMoney.Text, CboFamilyStatus.Text, TxtFamilyRelative.Text, CboFamilyOccupation.Text, txtFamilyAddress.Text) = 1 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Else

                    If DA_Consulting.InsertConsulting(TxtPatientNo.Text, Now.Date, DateConsult.Value.Date, CboPatientStatus.Text, cboPatientMoney.Text, 0, "", "", CboOrg.Text, GetTextReferralV1, TxtOrgNote.Text, Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, EmptyString(TxtHospitalFee.Text), ValSocial_Type, CBool(IIf(RadPatientPayR.Checked = True, True, False)), CDbl(IIf(RadPatientPayR.Checked = True, EmptyString(TxtDonateR.Text), 0)), EmptyString(TxtDonateD.Text), TxtConsultNote.Text, USER_NAME, USER_NAME, ValConsultFor, CDbl(IIf(RadPatientPayD.Checked = True, EmptyString(TxtDonateR.Text), 0)), TxtFamilyName.Text, EmptyString(TxtFamilyAge.Text), cboFamilySex.Text, cboFamilyMoney.Text, CboFamilyStatus.Text, TxtFamilyRelative.Text, CboFamilyOccupation.Text, txtFamilyAddress.Text) = 1 Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End If

            End If
            'In case update Diagnosis 
            If RadForInPatient.Checked = True Then
                If LblNew_OldID.Text <> "0" Then
                    ModNew_Outpatient.EnterPatientDiagnosis(LblNew_OldID.Text, CboSecondDiagnosis.Text)
                End If
            End If

        Else
            If MessageBox.Show("Do you want update consulting?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Consulting.UpdateConsulting(TxtPatientNo.Text, DateConsult.Value.Date, DateConsult.Value.Date, CboPatientStatus.Text, cboPatientMoney.Text, "", "", CboOrg.Text, GetTextReferralV1, TxtOrgNote.Text, Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, CboSecondDiagnosis.Text, CboSecondSurgery.Text, CboEye.Text, EmptyString(TxtHospitalFee.Text), ValSocial_Type, CBool(IIf(RadPatientPayR.Checked = True, True, False)), CDbl(IIf(RadPatientPayR.Checked = True, EmptyString(TxtDonateR.Text), 0)), EmptyString(TxtDonateD.Text), TxtConsultNote.Text, USER_NAME, USER_NAME, ValConsultFor, CDbl(IIf(RadPatientPayD.Checked = True, EmptyString(TxtDonateR.Text), 0)), TxtFamilyName.Text, EmptyString(TxtFamilyAge.Text), cboFamilySex.Text, cboFamilyMoney.Text, CboFamilyStatus.Text, TxtFamilyRelative.Text, CboFamilyOccupation.Text, txtFamilyAddress.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else

                End If
            End If
        End If
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtPatientNo, "", ErrConsulting) = False Then Exit Sub
        FindPatientNo(TxtPatientNo.Text)
    End Sub

    Private Sub TxtHospitalFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHospitalFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDonateR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonateR.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDonateD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonateD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboSecondSurgery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSecondSurgery.SelectedIndexChanged
        Try
            For Each Row As DataRow In DA_Surgery.GetDataBySurgeryID(CboSecondSurgery.SelectedValue)
                TxtHospitalFee.Text = Row("SurgeriesFee")
            Next
        Catch ex As Exception

        End Try
    End Sub




    Private Sub RadSocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSocial.CheckedChanged
        TxtDonateR.Enabled = True
        TxtDonateR.Text = "0"
        TxtDonateR.Focus()
        TxtDonateR.SelectAll()
        CboOrg.SelectedIndex = -1
        TxtDonateD.Text = ""
        CboOrg.Enabled = True
        TxtDonateD.Enabled = True
        'LsGive.Enabled = True
    End Sub

    Private Sub RadNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadNil.CheckedChanged
        TxtDonateR.Enabled = False
        RadPatientPayR.Checked = True
        TxtDonateR.Text = "0"
        CboOrg.SelectedIndex = -1
        TxtDonateD.Text = ""
        CboOrg.Enabled = True
        TxtDonateD.Enabled = True
        'LsGive.Enabled = False
    End Sub

    Private Sub RadFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFull.CheckedChanged
        TxtDonateR.Enabled = True
        TxtDonateR.Text = TxtHospitalFee.Text
        CboOrg.SelectedIndex = -1
        TxtDonateD.Text = ""
        CboOrg.Enabled = False
        TxtDonateD.Enabled = False
        'LsGive.Enabled = False
    End Sub

    Sub GetValueNew()
        TxtHospitalFee.Text = 0
        Dim DA_NEW As New DSDEFAULT_VAL_OLD_NEWTableAdapters.DEFAULT_VALUE_NEWTableAdapter
        Dim D_TBL As DataTable = DA_NEW.GetData
        With D_TBL
            If .Rows.Count > 0 Then
                Me.TxtHospitalFee.Text = .Rows(0).Item("DefaultValue")
            End If
        End With
    End Sub
    Sub GetValueOLD()
        TxtHospitalFee.Text = 0
        Dim DA_Old As New DSDEFAULT_VAL_OLD_NEWTableAdapters.DEFAULT_VALUE_OLDTableAdapter
        Dim D_TBL As DataTable = DA_Old.GetData
        With D_TBL
            If .Rows.Count > 0 Then
                Me.TxtHospitalFee.Text = .Rows(0).Item("DefaultValue")
            End If
        End With
    End Sub
    Private Sub ClearDiagnosis()
        CboEye.SelectedIndex = -1
        CboSecondDiagnosis.SelectedIndex = -1
        CboSecondSurgery.SelectedIndex = -1
    End Sub

    Private Sub RadForNewPatient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadForNewPatient.CheckedChanged
        GetValueNew()
        'CleanSocial()
        ClearDiagnosis()
        GroupDiagnosis.Enabled = False
        RadNil.Checked = True
        RadNil.Enabled = True
        RadSocial.Enabled = False
        RadFull.Enabled = False
    End Sub
    'Private Sub CleanSocial()
    '    RadSocial.Checked = False
    '    RadNil.Checked = False
    '    RadFull.Checked = False
    'End Sub

    Private Sub RadForOld_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadForOld.CheckedChanged
        GetValueOLD()
        'CleanSocial()
        ClearDiagnosis()
        GroupDiagnosis.Enabled = False
        RadNil.Checked = True
        RadSocial.Enabled = False
        RadFull.Enabled = False
    End Sub

    Private Sub RadForInPatient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadForInPatient.CheckedChanged
        GroupDiagnosis.Enabled = True
        RadNil.Enabled = True
        RadSocial.Enabled = True
        RadFull.Enabled = True
        TxtHospitalFee.Text = 0
        'CleanSocial()
        If ValidateCombobox(CboSecondSurgery, "", ErrConsulting) = False Then Exit Sub
        CboSecondSurgery_SelectedIndexChanged(sender, e)

    End Sub

    Private Sub RadForOpticalShop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadForOpticalShop.CheckedChanged
        TxtHospitalFee.Text = 0
        ' CleanSocial()
        ClearDiagnosis()
        GroupDiagnosis.Enabled = False
        RadNil.Enabled = True
        RadNil.Checked = False
        RadSocial.Enabled = True
        RadFull.Checked = False
        RadFull.Enabled = False

    End Sub

    Private Sub BtnFamilyStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFamilyStatus.Click
        Dim FStatus As New FamilyStatus
        FStatus.ShowDialog()
        With CboPatientStatus
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
        With cboPatientMoney
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With

        With CboFamilyStatus
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
        With cboFamilyMoney
            .DataSource = DA_FamilyStatus.GetData
            .ValueMember = "F_ID"
            .DisplayMember = "FAMILY_STATUS"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub NewConsuling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtPatientNo.Focus()
        TxtPatientNo.Select()

    End Sub

    Private Sub GroupConsultFor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupConsultFor.Enter

    End Sub

    Private Sub TxtFamilyAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFamilyAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboCommNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommNo.TextChanged
        txtFamilyAddress.Text = "Province: " & CboProNo.Text & ", District: " & CboDisNo.Text & ", Commune: " & CboCommNo.Text & "."
    End Sub


    Private Sub RadPatientPayD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientPayD.CheckedChanged
        TxtDonateR.Text = "0"

    End Sub

    Private Sub RadPatientPayR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientPayR.CheckedChanged
        TxtDonateR.Text = "0"
    End Sub
End Class