Public Class ExtracapsularCataractExtraction_ECCE_
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_ECCE As New DSOPERATIONNOTETableAdapters.S_OPERA_ECCETableAdapter
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
        'With DIAGNOSIS
        '    .DataSource = DA_DIAGNOSIS.GetData
        '    .ValueMember = "SID"
        '    .DisplayMember = "Surgery"
        '    .SelectedIndex = -1
        'End With
        With SURGEON_SIGNATURE
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        With SURGEON
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(START_TIME, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(SURGEON, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrInjection) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ECCE.InsertNewECCE(Now.Date, lblOperNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, _
                                         START_TIME.Text, LEFT_EYE.Checked, RIGHT_EYE.Checked, SURGEON.Text, SCRUB.Text, CIRCULATING.Text, _
                                         ANESTHESIONLOGIST.Text, "", S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, _
                                         S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, False, VIS_HEALON_GV.Checked, VIS_IALF.Checked, _
                                         VIS_VISSOAT.Checked, False, VIS_HEALON5.Checked, False, VIS_PROVISE.Checked, BSS_PLUS.Checked, _
                                         BSS.Checked, PERITO_YES.Checked, PERITO_NO.Checked, CARTERY_MILD.Checked, CARTERY_MODERATE.Checked, _
                                         CAUTERY_EXTENSIVE.Checked, INCISION_SITE_CORNEOSCLERAL.Checked, INCISION_SITE_SCLERAL.Checked, _
                                         INCISION_SIZE_SUPERRIOR.Checked, INCISION_SIZE_SUPERRIOR_NOTE.Text, INCISION_SIZE_SUPERRIOR_OTHER.Text, _
                                         CAPSULOTOMY_CYSTOTOMY.Checked, CAPSULOTOMY_OTHERS.Text, NUCLEUS_EXPRESSION.Checked, NUCLEUS_LENSLOOP.Checked, _
                                         NUCLEUS_VISCO.Checked, CORTEX_SIMCO_IA.Checked, CAPSULE_YES.Checked, CAPSULE_NO.Checked, IOL_IN_CAPSULAR.Checked, _
                                         IOL_IN_SULCUS.Checked, IOL_IN_AC.Checked, SUTURE_NYLON.Checked, SUTURE_NYLON_NOTE.Text, SUTURE_OTHERS.Text, _
                                         SUBCONJUN_GENTAL.Checked, SUBCONJUN_CEFAZOLIN.Checked, SUBCONJUN_DEXAMETHASONE.Checked, SUBCONJUN_OTHERS.Text, _
                                         TOPICAL_PILOCARPINE.Checked, TOPICAL_MAXITROL.Checked, TOPICAL_OTHERS.Text, EXTRA_IRRIDECTOMY.Checked, EXTRA_LOCATION.Text, _
                                         EXTRA_CAPSULAR.Checked, EXTRA_VITREOS.Checked, EXTRA_ANTERIOR.Checked, EXTRA_AC_HEMORRHAGE.Checked, EXTRA_OTHER.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_ECCE.UpdateECCE(START_TIME.Text, LEFT_EYE.Checked, RIGHT_EYE.Checked, SURGEON.Text, SCRUB.Text, CIRCULATING.Text, _
                                         ANESTHESIONLOGIST.Text, "", S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, _
                                         S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, False, VIS_HEALON_GV.Checked, VIS_IALF.Checked, _
                                         VIS_VISSOAT.Checked, False, VIS_HEALON5.Checked, False, VIS_PROVISE.Checked, BSS_PLUS.Checked, _
                                         BSS.Checked, PERITO_YES.Checked, PERITO_NO.Checked, CARTERY_MILD.Checked, CARTERY_MODERATE.Checked, _
                                         CAUTERY_EXTENSIVE.Checked, INCISION_SITE_CORNEOSCLERAL.Checked, INCISION_SITE_SCLERAL.Checked, _
                                         INCISION_SIZE_SUPERRIOR.Checked, INCISION_SIZE_SUPERRIOR_NOTE.Text, INCISION_SIZE_SUPERRIOR_OTHER.Text, _
                                         CAPSULOTOMY_CYSTOTOMY.Checked, CAPSULOTOMY_OTHERS.Text, NUCLEUS_EXPRESSION.Checked, NUCLEUS_LENSLOOP.Checked, _
                                         NUCLEUS_VISCO.Checked, CORTEX_SIMCO_IA.Checked, CAPSULE_YES.Checked, CAPSULE_NO.Checked, IOL_IN_CAPSULAR.Checked, _
                                         IOL_IN_SULCUS.Checked, IOL_IN_AC.Checked, SUTURE_NYLON.Checked, SUTURE_NYLON_NOTE.Text, SUTURE_OTHERS.Text, _
                                         SUBCONJUN_GENTAL.Checked, SUBCONJUN_CEFAZOLIN.Checked, SUBCONJUN_DEXAMETHASONE.Checked, SUBCONJUN_OTHERS.Text, _
                                         TOPICAL_PILOCARPINE.Checked, TOPICAL_MAXITROL.Checked, TOPICAL_OTHERS.Text, EXTRA_IRRIDECTOMY.Checked, EXTRA_LOCATION.Text, _
                                         EXTRA_CAPSULAR.Checked, EXTRA_VITREOS.Checked, EXTRA_ANTERIOR.Checked, EXTRA_AC_HEMORRHAGE.Checked, EXTRA_OTHER.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub
End Class