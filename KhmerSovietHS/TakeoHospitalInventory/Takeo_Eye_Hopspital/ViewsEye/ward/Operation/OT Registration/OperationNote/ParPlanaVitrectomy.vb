Public Class ParPlanaVitrectomy
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_ParPlana As New DSOPERATIONNOTETableAdapters.S_OPER_PAR_PLANA_VITRECTOMYTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With SCRUB
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        With CIRCULATING
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        With ANESTHESIONLOGIST
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.
        With DIAGNOSIS
            .DataSource = DA_DIAGNOSIS.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgery"
            .SelectedIndex = -1
        End With
        With SURGEON_SIGNATURE
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(DIAGNOSIS, "", ErrOperative) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperative) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ParPlana.InsertParPlana(Now.Date, LblOperNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, START_TIME.Text, SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, _
                                           S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, PERITOMY.Checked, SCLEROTOMISE.Checked, SCLEROTOMISE_NOTE.Text, INFUSION_SIZE.Checked, INFUSION_SIZE_NOTE.Text, CORE_VITRECTOMY.Checked, CORE_VITRECTOMY_NOTE1.Text, CORE_VITRECTOMY_NOTE2.Text, _
                                           PERIPHERAL_VITRECTORMY.Checked, MEMBRANCE_PEELING.Checked, PERFLUOCARBON.Checked, ENDO.Checked, ENDO_LASER.Text, ENDO_MW.Text, ENDO_SHOTS.Text, RETINOCRYOPEXY.Checked, AIR_FLUID_EXCHANGE.Checked, GAS_EXCHANGE.Checked, SF6.Checked, C6F8.Checked, C6F8_NOTE.Text, _
                                           SCLERAL_BUCHING.Checked, SILICONE_OIL.Checked, PAR_NOTE.Text, SCLEROTOMY_VICRYL.Checked, SCLEROLOMY_NYLON.Checked, SCLEROLOMY_DEXON.Checked, CONJUNTIVAL_NYLON.Checked, CONJUNTIVAL_VICRYL.Checked, SUB_GENTAL2MG.Checked, SUB_CEFAZOLIN50MG.Checked, SUB_DEXAMETHASONE.Checked, SUB_OTHERS.Text, _
                                           TOPICAL_MAXITROL.Checked, TOPICAL_PILOCARPINE.Checked, TOPICAL_ATROPINE.Checked, TOPICAL_ALPHAGAN.Checked, TOPICAL_VIGAMOX.Checked, TOPICAL_OTHERS.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ParPlana.UpdatePar(START_TIME.Text, SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, _
                                           S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, PERITOMY.Checked, SCLEROTOMISE.Checked, SCLEROTOMISE_NOTE.Text, INFUSION_SIZE.Checked, INFUSION_SIZE_NOTE.Text, CORE_VITRECTOMY.Checked, CORE_VITRECTOMY_NOTE1.Text, CORE_VITRECTOMY_NOTE2.Text, _
                                           PERIPHERAL_VITRECTORMY.Checked, MEMBRANCE_PEELING.Checked, PERFLUOCARBON.Checked, ENDO.Checked, ENDO_LASER.Text, ENDO_MW.Text, ENDO_SHOTS.Text, RETINOCRYOPEXY.Checked, AIR_FLUID_EXCHANGE.Checked, GAS_EXCHANGE.Checked, SF6.Checked, C6F8.Checked, C6F8_NOTE.Text, _
                                           SCLERAL_BUCHING.Checked, SILICONE_OIL.Checked, PAR_NOTE.Text, SCLEROTOMY_VICRYL.Checked, SCLEROLOMY_NYLON.Checked, SCLEROLOMY_DEXON.Checked, CONJUNTIVAL_NYLON.Checked, CONJUNTIVAL_VICRYL.Checked, SUB_GENTAL2MG.Checked, SUB_CEFAZOLIN50MG.Checked, SUB_DEXAMETHASONE.Checked, SUB_OTHERS.Text, _
                                           TOPICAL_MAXITROL.Checked, TOPICAL_PILOCARPINE.Checked, TOPICAL_ATROPINE.Checked, TOPICAL_ALPHAGAN.Checked, TOPICAL_VIGAMOX.Checked, TOPICAL_OTHERS.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End If
    End Sub
End Class