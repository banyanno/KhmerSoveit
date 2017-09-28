Public Class Trabeculectomy
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Dim DA_TRAB As New DSOPERATIONNOTETableAdapters.S_OPER_TRABECULECTOMYTableAdapter
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
   
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(DIAGNOSIS, "", ErrOperative) = False Then Exit Sub
        If ValidateDateTimePicker(START_TIME, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SURGEON, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperative) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperative) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_TRAB.InsertOperTrab(Now.Date, lblOperNo.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text, START_TIME.Text, SURGEON.Text, SCRUB.Text, CIRCULATING.Text _
                                     , ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, RIGHT_EYE.Checked, LEFT_EYE.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, _
                                     S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_AN_SUBCONJUNCTIVAL.Checked, CONJUNCTIVA_LIMBAL_BASE.Checked, CONJUNCTIVAL_FORNIX_BASE.Checked, _
                                     CONJUNC_NOTE_FROM.Text, CONJUNC_NOTE_TO.Text, SHAPE1.Checked, SHAPE2.Checked, SHAPE_OTHER.Text, SIZE1.Text, SIZE2.Text, THICKNESS13.Checked, _
                                     THICKNESS12.Checked, THICKNESS23.Checked, THICKNESS_OTHER.Text, LOCATION.Text, ADJUNCTIVE_NO.Checked, ADJUNCTIVE_YES.Checked, ADJUNCTIVE_MMC.Checked, _
                                     ADJUNCTIVE_MMC_NOTE.Text, ADJUNCTIVE_5FU.Checked, ADJUNCTIVE_5FU_NOTE.Text, INTRABLE.Checked, SOAKED.Checked, SOAKED_NOTE.Text, IRRIGATION_NO.Checked, _
                                     IRRIGATION_YES.Checked, IRRIGATION_WITH.Text, False, False, "", PARACENTESIS_NOTE_DONE.Checked, PARACENTESIS_DONE.Checked, PARACENTESIS_DONE_NOTE.Text, _
                                     TRABECULECTOMY1.Text, TRABECULECTOMY2.Text, IRIDECTOMY_NOT_DONE.Checked, IRIDECTOMY_DONE.Checked, IRIDECTOMY_DONE_NOTE.Text, SCLERAL_NOTE_NO.Text, _
                                     SCLERAL_100NYLON.Checked, SCLERAL_100PROLENE.Checked, SCLERAL_RELEASABLE.Checked, SCLERAL_NOTE.Text, CONJUNCTIVAL_CONTINUOS.Checked, CONJUNCTIVAL_INTERRUPTED.Checked, _
                                     CONJUNCTIVAL_INTERRUPTED_NOTE.Text, CONJUNCTIVAL_100NYLON.Checked, CONJUNCTIVAL_100PROLENE.Checked, CONJUNCTIVAL_OTHERS.Text, COPLICATION_NONE.Checked, COPLICATION_YES.Checked, _
                                     OTHER_PROCEDURES.Text, SUB_GENTAL2MG.Checked, SUB_CEFAZOLIN50MG.Checked, SUB_DEXAMETHASONE_25MG.Checked, SUB_OTHER.Text, TOPICAL_MAXITROL.Checked, TOPICAL_PILOCARPINE2.Checked, _
                                     TOPICAL_VIGAMOX.Checked, TOPICAL_OTHERS.Text, SURGEON_SIGNATURE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
          
        Else
            If MessageBox.Show("Do you want to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_TRAB.UpdateTrabecule(START_TIME.Text, SURGEON.Text, SCRUB.Text, CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, RIGHT_EYE.Checked, LEFT_EYE.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, S_AN_RETROBULBAR.Checked, _
                                     S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_AN_SUBCONJUNCTIVAL.Checked, CONJUNCTIVA_LIMBAL_BASE.Checked, CONJUNCTIVAL_FORNIX_BASE.Checked, _
                                     CONJUNC_NOTE_FROM.Text, CONJUNC_NOTE_TO.Text, SHAPE1.Checked, SHAPE2.Checked, SHAPE_OTHER.Text, SIZE1.Text, SIZE2.Text, THICKNESS13.Checked, _
                                     THICKNESS12.Checked, THICKNESS23.Checked, THICKNESS_OTHER.Text, LOCATION.Text, ADJUNCTIVE_NO.Checked, ADJUNCTIVE_YES.Checked, ADJUNCTIVE_MMC.Checked, _
                                     ADJUNCTIVE_MMC_NOTE.Text, ADJUNCTIVE_5FU.Checked, ADJUNCTIVE_5FU_NOTE.Text, INTRABLE.Checked, SOAKED.Checked, SOAKED_NOTE.Text, IRRIGATION_NO.Checked, _
                                     IRRIGATION_YES.Checked, IRRIGATION_WITH.Text, False, False, "", PARACENTESIS_NOTE_DONE.Checked, PARACENTESIS_DONE.Checked, PARACENTESIS_DONE_NOTE.Text, _
                                     TRABECULECTOMY1.Text, TRABECULECTOMY2.Text, IRIDECTOMY_NOT_DONE.Checked, IRIDECTOMY_DONE.Checked, IRIDECTOMY_DONE_NOTE.Text, SCLERAL_NOTE_NO.Text, _
                                     SCLERAL_100NYLON.Checked, SCLERAL_100PROLENE.Checked, SCLERAL_RELEASABLE.Checked, SCLERAL_NOTE.Text, CONJUNCTIVAL_CONTINUOS.Checked, CONJUNCTIVAL_INTERRUPTED.Checked, _
                                     CONJUNCTIVAL_INTERRUPTED_NOTE.Text, CONJUNCTIVAL_100NYLON.Checked, CONJUNCTIVAL_100PROLENE.Checked, CONJUNCTIVAL_OTHERS.Text, COPLICATION_NONE.Checked, COPLICATION_YES.Checked, _
                                     OTHER_PROCEDURES.Text, SUB_GENTAL2MG.Checked, SUB_CEFAZOLIN50MG.Checked, SUB_DEXAMETHASONE_25MG.Checked, SUB_OTHER.Text, TOPICAL_MAXITROL.Checked, TOPICAL_PILOCARPINE2.Checked, _
                                     TOPICAL_VIGAMOX.Checked, TOPICAL_OTHERS.Text, SURGEON_SIGNATURE.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            
        End If
    End Sub
End Class