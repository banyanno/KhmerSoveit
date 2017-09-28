Public Class FormIntravitrealInjection
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_INJECTION As New DSOPERATIONNOTETableAdapters.S_OPER_INJECTIONTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'With SURGEON
        '    .DataSource = DA_Doctor.GetData
        '    .ValueMember = "DoctorNo"
        '    .DisplayMember = "DoctorName"
        '    .SelectedIndex = -1
        'End With
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
        If ValidateCombobox(DIAGNOSIS, "", ErrInjection) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrInjection) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrInjection) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_INJECTION.InsertNewInjection(Now.Date, LblOpNumber.Text, PATIENT_NO.Text, PATIENT_NAME.Text, _
                                                   PATIENT_SEX.Text, PATIENT_AGE.Text, START_TIME.Text, "", _
                                                   SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, _
                                                   IVTA.Checked, AVASTIN.Checked, LUCENTIS.Checked, AN_TOPICAL.Checked, _
                                                   AN_SUBCONJUNCTIVAL.Checked, FULL_PRE_OP.Checked, PATIENT_FULL.Checked, _
                                                   INTRA_TRIAMCINOLONE.Checked, INTRA_TRIAM_DOSE.Text, INTRA_AVASTIN.Checked, _
                                                   INTRA_AVASTIN_DOSE.Text, INTRA_LUCENTIS.Checked, INTRA_LUCENTIS_DOSE.Text, _
                                                   ALPHAGAM.Checked, NEO_SYNEPHRINE.Checked, POLY_OPH_TROPICAL.Checked, _
                                                   VIGAMOX_TROPICAL.Checked, VIGAMO_TROPICAL_NOTE.Text, MAXITROL_EYE_OITMENT.Checked, _
                                                   PATH.Checked, NO_COMPLICATION.Checked, NOTE.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_INJECTION.UpdateInjection(START_TIME.Text, "", _
                                                   SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, _
                                                   IVTA.Checked, AVASTIN.Checked, LUCENTIS.Checked, AN_TOPICAL.Checked, _
                                                   AN_SUBCONJUNCTIVAL.Checked, FULL_PRE_OP.Checked, PATIENT_FULL.Checked, _
                                                   INTRA_TRIAMCINOLONE.Checked, INTRA_TRIAM_DOSE.Text, INTRA_AVASTIN.Checked, _
                                                   INTRA_AVASTIN_DOSE.Text, INTRA_LUCENTIS.Checked, INTRA_LUCENTIS_DOSE.Text, _
                                                   ALPHAGAM.Checked, NEO_SYNEPHRINE.Checked, POLY_OPH_TROPICAL.Checked, _
                                                   VIGAMOX_TROPICAL.Checked, VIGAMO_TROPICAL_NOTE.Text, MAXITROL_EYE_OITMENT.Checked, _
                                                   PATH.Checked, NO_COMPLICATION.Checked, NOTE.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class