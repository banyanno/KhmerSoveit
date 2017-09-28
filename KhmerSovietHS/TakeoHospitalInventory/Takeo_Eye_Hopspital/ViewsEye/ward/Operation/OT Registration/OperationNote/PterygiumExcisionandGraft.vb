Public Class PterygiumExcisionandGraft
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_Pterygium As New DSOPERATIONNOTETableAdapters.S_OPER_PTERYGIUMTableAdapter
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
        With SURGEON
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
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
        ' If ValidateCombobox(DIAGNOSIS, "", ErrOperative) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SURGEON, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperative) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Pterygium.InsertPTERYGIUM(Now.Date, lblOperNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, START_TIME.Text, SURGEON.Text, SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, _
                            "", RIGHT_EYE.Checked, LEFT_EYE.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, _
                            False, PTERYGIUM_NASAL.Checked, PTERYGIUM_TEMPORAL.Checked, BRIDAL_SUPERIOR.Checked, BRIDAL_70VICRYL.Checked, BRIDAL_80SILK.Checked, BRIDAL_OTHERS.Text, _
                            SUBCONJUNCTIVAL_XYLOCAIN_WITH.Checked, SUBCONJUNCTIVAL_XYLOCAIN.Checked, SUBCONJUNCTIVAL_NONE.Checked, PTERYGIUM_SCISSORS.Checked, PTERYGIUM_OTHER.Text, _
                            CAUTERY_MILD.Checked, CAUTERY_69BLADE.Checked, CAUTERY_MODRATE.Checked, CAUTERY_EXTENSIVE.Checked, CONJUNCTIVAL_SUPERIOR.Checked, CONJUNCTIVAL_OTHER_SITE.Text, SIZE1.Text, SIZE2.Text, _
                            GRAFT_80VERGIN.Checked, GRAFT_100NYLON.Checked, GRAFT_OTHER.Text, GRAFT_90NYLON.Checked, GRAFT_RUNNING.Checked, GRAFT_INTERRUPTED.Checked, GRAFT_COMBINED.Checked, _
                            SUBCONJUNCTIVAL_GENTAL.Checked, SUBCONJUNCTIVAL_CEFAZOLIN.Checked, SUBCONJUNCTIVAL_DEXAMETHASONE.Checked, SUBCONJUNCTIVAL_OTHERS.Text, TOPICAL_MAXITROL.Checked, _
               TOPICAL_TOBRADEX.Checked, TOPICAL_OTHER.Text, EXTRA_NOTES.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        Else
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Pterygium.UpdatePTERYGIUM(START_TIME.Text, SURGEON.Text, SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, _
                                         "", RIGHT_EYE.Checked, LEFT_EYE.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, _
                                         False, PTERYGIUM_NASAL.Checked, PTERYGIUM_TEMPORAL.Checked, BRIDAL_SUPERIOR.Checked, BRIDAL_70VICRYL.Checked, BRIDAL_80SILK.Checked, BRIDAL_OTHERS.Text, _
                                         SUBCONJUNCTIVAL_XYLOCAIN_WITH.Checked, SUBCONJUNCTIVAL_XYLOCAIN.Checked, SUBCONJUNCTIVAL_NONE.Checked, PTERYGIUM_SCISSORS.Checked, PTERYGIUM_OTHER.Text, _
                                         CAUTERY_MILD.Checked, CAUTERY_69BLADE.Checked, CAUTERY_MODRATE.Checked, CAUTERY_EXTENSIVE.Checked, CONJUNCTIVAL_SUPERIOR.Checked, CONJUNCTIVAL_OTHER_SITE.Text, SIZE1.Text, SIZE2.Text, _
                                         GRAFT_80VERGIN.Checked, GRAFT_100NYLON.Checked, GRAFT_OTHER.Text, GRAFT_90NYLON.Checked, GRAFT_RUNNING.Checked, GRAFT_INTERRUPTED.Checked, GRAFT_COMBINED.Checked, _
                                         SUBCONJUNCTIVAL_GENTAL.Checked, SUBCONJUNCTIVAL_CEFAZOLIN.Checked, SUBCONJUNCTIVAL_DEXAMETHASONE.Checked, SUBCONJUNCTIVAL_OTHERS.Text, TOPICAL_MAXITROL.Checked, _
                            TOPICAL_TOBRADEX.Checked, TOPICAL_OTHER.Text, EXTRA_NOTES.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class