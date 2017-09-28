Public Class UCRegistrationForm
    Dim frmMain As MainTakeoInventory
    Sub New(ByVal formMain As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        frmMain = formMain
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CboPrimD_RE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboPrimD_RE.KeyPress
        e.Handled = True
    End Sub

    Private Sub CboPrimD_LE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboPrimD_LE.KeyPress
        e.Handled = True
    End Sub

    Private Sub CboSecD_RE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CboSecD_LE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CboPrimD_RE_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPrimD_RE.DropDown
        With CboPrimD_RE
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .ValueMember = "Surgery"
            .SelectedValue = "SID"
            .Text = ""
        End With
    End Sub

    Private Sub CboPrimD_LE_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPrimD_LE.DropDown
        With CboPrimD_LE
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .ValueMember = "Surgery"
            .SelectedValue = "SID"
            .Text = ""
        End With
    End Sub


    Private Sub TxtPatientNoFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

   
    Sub FindPatientRegistration()
        If ModConsultation.GetHistoryByPatientNo(EmptyString(TxtPatientNo.Text)).Rows.Count > 0 Then
            GridPatientFollowUp.DataSource = ModConsultation.GetHistoryByPatientNo(EmptyString(TxtPatientNo.Text))
            For Each row As DataGridViewRow In Me.GridPatientFollowUp.Rows
                If row.Cells("FollowUpStatus").Value = "True" Then
                    row.DefaultCellStyle.BackColor = Color.Gray
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            Next
            Me.GridPatientFollowUp.ClearSelection()
        End If
    End Sub

    Private Sub TxtPantientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtPatientName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientName.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtSex_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSex.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtProvice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TxtDistrict_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TxtOccupation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub txtCommune_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TxtTel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub TxtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAddress.KeyPress
        e.Handled = True
    End Sub
    Function GetTextReferral() As String
        Try
            Dim str As String
            For i As Int16 = 0 To GrpReferal.Controls.Count - 1
                Dim ch As CheckBox = CType(GrpReferal.Controls(i), CheckBox)
                If ch.Checked = True Then
                    str = str & " + " & ch.Text
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim priorityVR As String = ""
        Dim priorityVL As String = ""
        Dim PriorityEye As String = ""
        Dim priorityDiagnosis As String = ""
        If RPriorityPlain.Checked = True Then
            priorityVR = TxtPlainVa_R.Text
            priorityVL = TxtPlainVa_L.Text
        End If
        If RPH.Checked = True Then
            priorityVR = txtPHVa_R.Text
            priorityVL = TxtPhVa_L.Text
        End If
        If RGlasses.Checked = True Then
            priorityVR = TxtG1Va_R.Text
            priorityVL = TxtG1Va_L.Text
        End If
        If RPriorityRE.Checked = True Then
            priorityDiagnosis = CboPrimD_RE.Text
            PriorityEye = "Right Eye"
        Else
            priorityDiagnosis = CboPrimD_LE.Text
            PriorityEye = "Left Eye"
        End If

        If lblExamID.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = DialogResult.Yes Then
                If ModConsultation.SavePatientHistory( _
                TxtPatientNo.Text, _
                ChHearing.Checked, _
                ChUnderstand.Checked, _
                ChSeeing.Checked, _
                ChPhysical.Checked, _
                ChBOV.Checked, _
                ChDiplopia.Checked, _
                ChEyePain.Checked, _
                ChFloaters.Checked, _
                ChEyeRedness.Checked, _
                ChFBSensation.Checked, _
                ChTearing.Checked, _
                ChEyeDischarge.Checked, _
                ChPhotophobia.Checked, _
                TxtOtherComplaint.Text, _
                TxtDuration.Text, _
                TxtOD.Text, _
                TxtOS.Text, _
                TxtOU.Text, _
                ChCDMDP.Checked, _
                ChEyeScreenig.Checked, _
                ChSelf.Checked, _
                ChPatient.Checked, _
                ChFriend.Checked, _
                ChOtherNGO.Checked, _
                ChChurch.Checked, _
                ChHealth.Checked, _
                ChOtherReferal.Checked, _
                DatePlain.Text, _
                TxtPlainVa_R.Text, _
                TxtPlainVa_L.Text, _
                DateICPH.Text, _
                txtPHVa_R.Text, _
                TxtPhVa_L.Text, _
                DateICG1.Text, _
                TxtG1Va_R.Text, _
                TxtG1Va_L.Text, _
                priorityVR, _
                priorityVL, _
                TxtInitial_RE.Text, _
                TxtInitial_LE.Text, _
                CboPrimD_RE.Text, _
                CboPrimD_LE.Text, _
                priorityDiagnosis, _
                PriorityEye, _
                TxtICD_P_RE.Text, _
                TxtICD_P_LE.Text, _
                TxtHistory.Text, _
                ChBlindness.Checked, _
                ChHypertension.Checked, _
                ChDiabetes.Checked, _
                ChAsthma.Checked, _
                ChGlaucoma.Checked, _
                ChCataract.Checked, _
                ChAIDS.Checked, _
                ChTB.Checked, _
                ChSyphilis.Checked, _
                TxtTreatment.Text, _
                CboTypeOfOperation.Text, _
                CboSpectacle.Text, _
                ChInpatient.Checked) = 1 Then
                    MsgBox("Save patient examination sucessfully.", MsgBoxStyle.Information, "Save")
                    SplitRegistrationForm.Panel2Collapsed = True
                    ClearPatientRegistration()
                    FindPatientRegistration()
                Else
                    MessageBox.Show("Error save patient examination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DIALOG_UPDATE = DialogResult.Yes Then
                If ModConsultation.UpdatePatientHistory( _
                lblExamID.Text, _
               ChHearing.Checked, _
                ChUnderstand.Checked, _
                ChSeeing.Checked, _
                ChPhysical.Checked, _
                ChBOV.Checked, _
                ChDiplopia.Checked, _
                ChEyePain.Checked, _
                ChFloaters.Checked, _
                ChEyeRedness.Checked, _
                ChFBSensation.Checked, _
                ChTearing.Checked, _
                ChEyeDischarge.Checked, _
                ChPhotophobia.Checked, _
                TxtOtherComplaint.Text, _
                TxtDuration.Text, _
                TxtOD.Text, _
                TxtOS.Text, _
                TxtOU.Text, _
                ChCDMDP.Checked, _
                ChScreeningKV.Checked, _
                ChEyeScreenig.Checked, _
                ChSelf.Checked, _
                ChPatient.Checked, _
                ChFriend.Checked, _
                ChOtherNGO.Checked, _
                ChChurch.Checked, _
                ChHealth.Checked, _
                ChOtherReferal.Checked, _
                DatePlain.Value, _
                TxtPlainVa_R.Text, _
                TxtPlainVa_L.Text, _
                DateICPH.Value, _
                txtPHVa_R.Text, _
                TxtPhVa_L.Text, _
                DateICG1.Value, _
                TxtG1Va_R.Text, _
                TxtG1Va_L.Text, _
                priorityVR, _
                priorityVL, _
                TxtInitial_RE.Text, _
                TxtInitial_LE.Text, _
                CboPrimD_RE.Text, _
                CboPrimD_LE.Text, _
                priorityDiagnosis, _
                PriorityEye, _
                TxtICD_P_RE.Text, _
                TxtICD_P_LE.Text, _
                "1010", _
                TxtHistory.Text, _
                ChBlindness.Checked, _
                ChHypertension.Checked, _
                ChDiabetes.Checked, _
                ChAsthma.Checked, _
                ChGlaucoma.Checked, _
                ChCataract.Checked, _
                ChAIDS.Checked, _
                ChTB.Checked, _
                ChSyphilis.Checked, _
                TxtTreatment.Text, _
                CboTypeOfOperation.Text, _
                CboSpectacle.Text, _
                ChInpatient.Checked, _
                ChPreyKabasVC.Checked, _
                ChPreyScreening.Checked, _
                ChSchoolScreening.Checked, _
                ChMoPoCho.Checked, GetTextReferral) = 1 Then
                    GridPatientFollowUp.DataSource = ModConsultation.GetHistoryByPatientNo(EmptyString(TxtPatientNo.Text))
                    MsgBox("Update examination successfully.", MsgBoxStyle.Information, "Update")
                    SplitRegistrationForm.Panel2Collapsed = True
                    ClearPatientRegistration()
                    FindPatientRegistration()
                Else
                    MsgBox("Error update examinatinton.", MsgBoxStyle.Critical, "Error")
                End If
            End If

        End If

    End Sub

    Private Sub GridPatienHistory_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPatientFollowUp.CellDoubleClick
        Try
            Dim rowIndex As Integer = e.RowIndex
            lblExamID.Text = GridPatientFollowUp.Rows(rowIndex).Cells(0).Value
            DateCreateExam.Value = GridPatientFollowUp.Rows(rowIndex).Cells(2).Value
            ChHearing.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(3).Value
            ChUnderstand.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(4).Value
            ChSeeing.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(5).Value
            ChPhysical.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(6).Value
            ChBOV.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(7).Value
            ChDiplopia.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(8).Value
            ChEyePain.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(9).Value
            ChFloaters.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(10).Value
            ChEyeRedness.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(11).Value
            ChFBSensation.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(12).Value
            ChTearing.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(13).Value
            ChEyeDischarge.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(14).Value
            ChPhotophobia.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(15).Value
            TxtOtherComplaint.Text = GridPatientFollowUp.Rows(rowIndex).Cells(16).Value
            TxtDuration.Text = GridPatientFollowUp.Rows(rowIndex).Cells(17).Value
            TxtOD.Text = GridPatientFollowUp.Rows(rowIndex).Cells(18).Value
            TxtOS.Text = GridPatientFollowUp.Rows(rowIndex).Cells(19).Value
            TxtOU.Text = GridPatientFollowUp.Rows(rowIndex).Cells(20).Value
            ChCDMDP.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(21).Value
            ChScreeningKV.Checked = GridPatientFollowUp.Rows(rowIndex).Cells("ScreeningKV").Value
            ChEyeScreenig.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(22).Value
            ChSelf.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(23).Value
            ChPatient.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(24).Value
            ChFriend.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(25).Value
            ChOtherNGO.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(26).Value
            ChChurch.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(27).Value
            ChHealth.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(28).Value
            ChOtherReferal.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(29).Value
            ChPreyKabasVC.Checked = GridPatientFollowUp.Rows(rowIndex).Cells("PreyKabasVC").Value
            ChPreyScreening.Checked = GridPatientFollowUp.Rows(rowIndex).Cells("PreyScreening").Value
            ChMoPoCho.Checked = GridPatientFollowUp.Rows(rowIndex).Cells("MoPoCho").Value
            ChSchoolScreening.Checked = GridPatientFollowUp.Rows(rowIndex).Cells("SchoolScreening").Value
            DatePlain.Value = GridPatientFollowUp.Rows(rowIndex).Cells(30).Value


            TxtPlainVa_R.Text = GridPatientFollowUp.Rows(rowIndex).Cells(31).Value
            TxtPlainVa_L.Text = GridPatientFollowUp.Rows(rowIndex).Cells(32).Value

            DateICPH.Value = GridPatientFollowUp.Rows(rowIndex).Cells(33).Value


            txtPHVa_R.Text = GridPatientFollowUp.Rows(rowIndex).Cells(34).Value
            TxtPhVa_L.Text = GridPatientFollowUp.Rows(rowIndex).Cells(35).Value

            DateICG1.Value = GridPatientFollowUp.Rows(rowIndex).Cells(36).Value

            TxtG1Va_R.Text = GridPatientFollowUp.Rows(rowIndex).Cells(37).Value
            TxtG1Va_L.Text = GridPatientFollowUp.Rows(rowIndex).Cells(38).Value
            TxtInitial_RE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(39).Value
            TxtInitial_LE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(40).Value

            CboPrimD_RE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(41).Value
            CboPrimD_LE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(42).Value
            TxtICD_P_RE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(43).Value
            TxtICD_P_LE.Text = GridPatientFollowUp.Rows(rowIndex).Cells(44).Value
            TxtHistory.Text = GridPatientFollowUp.Rows(rowIndex).Cells(45).Value

            ChBlindness.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(46).Value
            ChHypertension.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(47).Value
            ChDiabetes.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(48).Value
            ChAsthma.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(49).Value
            ChGlaucoma.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(50).Value
            ChCataract.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(51).Value
            ChAIDS.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(52).Value
            ChTB.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(53).Value
            ChSyphilis.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(54).Value
            TxtTreatment.Text = GridPatientFollowUp.Rows(rowIndex).Cells(55).Value
            CboTypeOfOperation.Text = GridPatientFollowUp.Rows(rowIndex).Cells(56).Value
            CboSpectacle.Text = GridPatientFollowUp.Rows(rowIndex).Cells(57).Value
            ChInpatient.Checked = GridPatientFollowUp.Rows(rowIndex).Cells(58).Value
            SplitRegistrationForm.Panel2Collapsed = False
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        If ValidateTextField(TxtPatientNo, "", ErrHistoryExam) = False Then
            Exit Sub
        End If
        If ModConsultation.CheckPatient_And_ReceiptNo(TxtPatientNo.Text) = True Then
            MsgBox("You can not create followup. Could you create new receipt!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            SplitRegistrationForm.Panel2Collapsed = False
            ClearPatientRegistration()
        End If

    End Sub
    

    Private Sub ClearPatientRegistration()
        lblExamID.Text = "0"
        DateCreateExam.Value = Now
        ChHearing.Checked = False
        ChUnderstand.Checked = False
        ChSeeing.Checked = False
        ChPhysical.Checked = False
        ChBOV.Checked = False
        ChDiplopia.Checked = False
        ChEyePain.Checked = False
        ChFloaters.Checked = False
        ChEyeRedness.Checked = False
        ChFBSensation.Checked = False
        ChTearing.Checked = False
        ChEyeDischarge.Checked = False
        ChPhotophobia.Checked = False
        TxtOtherComplaint.Text = ""
        TxtDuration.Text = ""
        TxtOD.Text = ""
        TxtOS.Text = ""
        TxtOU.Text = ""
        ChCDMDP.Checked = False
        ChScreeningKV.Checked = False
        ChEyeScreenig.Checked = False
        ChSelf.Checked = False
        ChPatient.Checked = False
        ChFriend.Checked = False
        ChOtherNGO.Checked = False
        ChChurch.Checked = False
        ChHealth.Checked = False
        ChOtherReferal.Checked = False
        TxtPlainVa_R.Text = ""
        TxtPlainVa_L.Text = ""
        txtPHVa_R.Text = ""
        TxtPhVa_L.Text = ""
        TxtG1Va_R.Text = ""
        TxtG1Va_L.Text = ""
        TxtInitial_RE.Text = ""
        TxtInitial_LE.Text = ""
        CboPrimD_RE.Text = ""
        CboPrimD_LE.Text = ""
        TxtICD_P_RE.Text = ""
        TxtICD_P_LE.Text = ""
        TxtHistory.Text = ""
        ChBlindness.Checked = False
        ChHypertension.Checked = False
        ChDiabetes.Checked = False
        ChAsthma.Checked = False
        ChGlaucoma.Checked = False
        ChCataract.Checked = False
        ChAIDS.Checked = False
        ChTB.Checked = False
        ChSyphilis.Checked = False
        TxtTreatment.Text = ""
        CboTypeOfOperation.Text = ""
        CboSpectacle.Text = ""
        ChInpatient.Checked = False
    End Sub


   


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        SplitRegistrationForm.Panel2Collapsed = True
    End Sub

    Private Sub BtnCancelForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelForm.Click
        SplitRegistrationForm.Panel2Collapsed = True
        ClearPatientRegistration()
        frmMain.CreatePaymentForm()
    End Sub
    Dim frmReportForm As New ReportForm
    Private Sub BtnPrintRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRegistration.Click
        Try
            'Dim rowIndex As Int16 = GridPatientFollowUp.SelectedCells(0).RowIndex

            GLOBLE_PATIENT_NO = GridPatientFollowUp.SelectedRows(0).Cells(1).Value    ' Rows(rowIndex).Cells(1).Value
            frmReportForm.LoadRegistrationForm()
            frmReportForm.ShowDialog()
            SplitRegistrationForm.Panel2Collapsed = True
            ClearPatientRegistration()
            frmMain.CreatePaymentForm()
        Catch ex As Exception
            MsgBox("Please select follow up.", MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub CboTypeOfOperation_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTypeOfOperation.DropDown
        Try
            With CboTypeOfOperation
                .DataSource = ModSurgeries.SelectSurgeries()
                .DisplayMember = "Surgeries"
                .ValueMember = "SID"
                .Text = ""
            End With
        Catch ex As Exception
        End Try
    End Sub

    

    
End Class
