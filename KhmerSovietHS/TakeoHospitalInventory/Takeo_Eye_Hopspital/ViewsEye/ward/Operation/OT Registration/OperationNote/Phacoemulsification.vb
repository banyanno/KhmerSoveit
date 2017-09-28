Public Class Phacoemulsification
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_Phacoe As New DSOPERATIONNOTETableAdapters.S_OPER_PHACOEMULSIFICATIONTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If ValidateCombobox(DIAGNOSIS, "", ErrOperative) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperative) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Phacoe.Insert_New_Phacoem(Now.Date, lblOperNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, _
                                                START_TIME.Text, "", SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, "", S_AN_GA.Checked, _
                                                S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, _
                                                S_AN_TOPICAL.Checked, VIS_HEALON_GV.Checked, VIS_IALF.Checked, VIS_VISSOAT.Checked, VIS_DUOVISE.Checked, _
                                                VIS_HEALON5.Checked, VIS_OPHTHALINE.Checked, VIS_PROVISE.Checked, BSS_PLUS.Checked, _
                                                POWER.Text, FLOW_RATE.Text, VAC.Text, PHACO_TIME.Text, IA_FLOW_RATE.Text, IA_VAC.Text, _
                                                NOT_DONE.Checked, DONE.Checked, DONE_NOTE.Text, CORNEAL.Checked, SCLERAL.Checked, FINAL_SIZE.Checked, _
                                                FINAL_SIZE_NOTE.Text, CAPSULORHEXIS.Text, HEYDRODISSECTION_YES.Checked, HEYDRODISSECTION_NO.Checked, _
                                                PHACO_DIVIDE.Checked, PHACO_CHOP.Checked, PHACO_STOP_CHOP.Checked, PHACO_SCULPTING.Checked, _
                                                PHACO_CRACKING.Checked, PHACO_OTHERS.Text, IA_TIP.Checked, IA_OTHER.Text, CAPSULAR_YES.Checked, _
                                                CAPSULAR_NO.Checked, IOL_YES.Checked, IOL_NO.Checked, IOL_IN_CAPSULAR.Checked, IOL_IN_SULCUS.Checked, _
                                                IOL_IN_AC.Checked, SUTURE_YES.Checked, SUTURE_NO.Checked, SUB_GENTAL.Checked, SUB_CEFAZOLIN.Checked, _
                                                SUB_DEXAMETHASONE.Checked, SUB_OTHERS.Text, TOPICAL_PILOCARPINE.Checked, TOPICAL_MAXITROL.Checked, _
                                                TOPICAL_OTHERS.Text, COMPLICATION_YES.Checked, COMPLICATION_NO.Checked, COMPLICATION_NOTE.Text, _
                                                OTHER_PRO_ANTERIOR.Checked, OTHER_PRO_PI.Checked, OTHER_PRO_AT.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Phacoe.UpdatePhaco(START_TIME.Text, "", SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, "", S_AN_GA.Checked, _
                                               S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, _
                                               S_AN_TOPICAL.Checked, VIS_HEALON_GV.Checked, VIS_IALF.Checked, VIS_VISSOAT.Checked, VIS_DUOVISE.Checked, _
                                               VIS_HEALON5.Checked, VIS_OPHTHALINE.Checked, VIS_PROVISE.Checked, BSS_PLUS.Checked, _
                                               POWER.Text, FLOW_RATE.Text, VAC.Text, PHACO_TIME.Text, IA_FLOW_RATE.Text, IA_VAC.Text, _
                                               NOT_DONE.Checked, DONE.Checked, DONE_NOTE.Text, CORNEAL.Checked, SCLERAL.Checked, FINAL_SIZE.Checked, _
                                               FINAL_SIZE_NOTE.Text, CAPSULORHEXIS.Text, HEYDRODISSECTION_YES.Checked, HEYDRODISSECTION_NO.Checked, _
                                               PHACO_DIVIDE.Checked, PHACO_CHOP.Checked, PHACO_STOP_CHOP.Checked, PHACO_SCULPTING.Checked, _
                                               PHACO_CRACKING.Checked, PHACO_OTHERS.Text, IA_TIP.Checked, IA_OTHER.Text, CAPSULAR_YES.Checked, _
                                               CAPSULAR_NO.Checked, IOL_YES.Checked, IOL_NO.Checked, IOL_IN_CAPSULAR.Checked, IOL_IN_SULCUS.Checked, _
                                               IOL_IN_AC.Checked, SUTURE_YES.Checked, SUTURE_NO.Checked, SUB_GENTAL.Checked, SUB_CEFAZOLIN.Checked, _
                                               SUB_DEXAMETHASONE.Checked, SUB_OTHERS.Text, TOPICAL_PILOCARPINE.Checked, TOPICAL_MAXITROL.Checked, _
                                               TOPICAL_OTHERS.Text, COMPLICATION_YES.Checked, COMPLICATION_NO.Checked, COMPLICATION_NOTE.Text, _
                                               OTHER_PRO_ANTERIOR.Checked, OTHER_PRO_PI.Checked, OTHER_PRO_AT.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class