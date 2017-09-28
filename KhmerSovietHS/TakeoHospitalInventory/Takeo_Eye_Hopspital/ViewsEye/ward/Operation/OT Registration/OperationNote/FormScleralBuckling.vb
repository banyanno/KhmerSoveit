Public Class FormScleralBuckling
    Dim DA_SCLERAL As New DSOPERATIONNOTETableAdapters.S_OPER_SCLERAL_BUCKLINGTableAdapter
    Dim DA_Doctor As New DSOPERATIONNOTETableAdapters.TblDoctorTableAdapter
    Dim DA_DIAGNOSIS As New DSOPERATIONNOTETableAdapters.TblSurgeryTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With SURGEON
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
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
        With S_SUGEON_NAME
            .DataSource = DA_Doctor.GetData
            .ValueMember = "DoctorNo"
            .DisplayMember = "DoctorName"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateDateTimePicker(START_TIME, "", ErrOperation) = False Then
            START_TIME.Focus()
            START_TIME.Select()
            Exit Sub
        End If
        If ValidateCombobox(DIAGNOSIS, "", ErrOperation) = False Then Exit Sub
        If ValidateCombobox(SURGEON, "", ErrOperation) = False Then Exit Sub
        If ValidateCombobox(SCRUB, "", ErrOperation) = False Then Exit Sub
        If ValidateCombobox(CIRCULATING, "", ErrOperation) = False Then Exit Sub
        If ValidateCombobox(ANESTHESIONLOGIST, "", ErrOperation) = False Then Exit Sub
        If LblSaveOption.Text = "" Then Exit Sub

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save?", "Scleral Buckling", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_SCLERAL.InsertNewScleralBuckling(LblOperationNo.Text, RIGHT_EYE.Checked, LEFT_EYE.Checked, START_TIME.Text, SCRUB.Text, _
                                                       CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_PERITOMY360.Checked, _
                                                       S_RECTUS_MUSCLES.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, _
                                                       S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_EX_GA.Checked, _
                                                       S_EX_RETROBULBAR.Checked, S_EX_TOPICAL.Checked, S_NOTE.Text, S_INTRAVITREAL.Checked, S_OTHER_PROCEDURES.Text, _
                                                       S_CON_8VICRYL.Checked, S_CON_10NYLON.Checked, S_CON_OTHERS.Text, S_SUB_GENTAMICIN.Checked, _
                                                       S_SUB_CEFAZOLIN.Checked, S_SUB_DEXAMETHASONE.Checked, S_SUB_OTHERS.Text, S_TOP_MAXITROL.Checked, _
                                                       S_TOP_PILOCARPINE.Checked, S_TOP_ATROPINE.Checked, S_TOP_OTHERS.Text, S_SUGEON_NAME.Text, _
                                                      GetDateServer.Date, SURGEON.Text, PATIENT_NO.Text, PATIENT_NAME.Text, PATIENT_SEX.Text, PATIENT_AGE.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else

                End If
            End If
        Else
            If MessageBox.Show("Do you want to update?", "Scleral Buckling", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_SCLERAL.UpdateScleralBuckling(LblOperationNo.Text, RIGHT_EYE.Checked, LEFT_EYE.Checked, START_TIME.Text, SCRUB.Text, _
                                                      CIRCULATING.Text, ANESTHESIONLOGIST.Text, DIAGNOSIS.Text, S_PERITOMY360.Checked, _
                                                      S_RECTUS_MUSCLES.Checked, S_AN_GA.Checked, S_AN_NEURO.Checked, S_AN_STANDBY.Checked, _
                                                      S_AN_RETROBULBAR.Checked, S_AN_PERIBULBAR.Checked, S_AN_TOPICAL.Checked, S_EX_GA.Checked, _
                                                      S_EX_RETROBULBAR.Checked, S_EX_TOPICAL.Checked, S_NOTE.Text, S_INTRAVITREAL.Checked, S_OTHER_PROCEDURES.Text, _
                                                      S_CON_8VICRYL.Checked, S_CON_10NYLON.Checked, S_CON_OTHERS.Text, S_SUB_GENTAMICIN.Checked, _
                                                      S_SUB_CEFAZOLIN.Checked, S_SUB_DEXAMETHASONE.Checked, S_SUB_OTHERS.Text, S_TOP_MAXITROL.Checked, _
                                                      S_TOP_PILOCARPINE.Checked, S_TOP_ATROPINE.Checked, S_TOP_OTHERS.Text, S_SUGEON_NAME.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else

                End If
            End If
           
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class