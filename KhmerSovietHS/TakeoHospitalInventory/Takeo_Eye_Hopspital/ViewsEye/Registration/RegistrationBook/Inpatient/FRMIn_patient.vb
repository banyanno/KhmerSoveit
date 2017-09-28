Public Class FRMIn_patient
    Public isCloseIn As Boolean = False
    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DS_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboOperationType
                .DataSource = ModSurgeries.SelectSurgeries()
                .DisplayMember = "Surgeries"
                .ValueMember = "SID"
                .Text = Nothing
            End With
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .ValueMember = "Surgery"
                .SelectedValue = "SID"
                .Text = ""
                .SelectAll()
            End With
            With CboDonation
                .DataSource = ModDonation.GetDonation
                .ValueMember = "DonationID"
                .DisplayMember = "DonationName"
                .SelectedIndex = -1
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub LblLoadData_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblLoadData.LinkClicked
        LoadPatientInfo()
    End Sub
   
    Sub LoadPatientInfo()
        Dim TblInPatient As DataTable = ModInPatient.SelectInpatientByReceipt(EmptyString(TxtReceiptNo.Text))
        Dim DRow As DataRow
        If TblInPatient.Rows.Count > 0 Then
            For i As Integer = 0 To TblInPatient.Rows.Count - 1
                DRow = TblInPatient.Rows(i)
                TxtPatientNo.Text = DRow(0).ToString
                TxtPatientName.Text = DRow(2).ToString
                TxtAge.Text = DRow(3).ToString
                TxtSex.Text = DRow(4).ToString
                TxtAddress.Text = DRow(5).ToString
                'TxtHosFee.Text = DRow(6).ToString
            Next
        Else
            TxtPatientNo.Text = ""
            TxtPatientName.Text = ""
            TxtAge.Text = ""
            TxtSex.Text = ""
            TxtAddress.Text = ""
            TxtHosFee.Text = ""
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim DolarSosial As Double
        Dim RielSosial As Double

        Dim DolarFull As Double
        Dim RielFull As Double

        Dim CalDolarSosial As Double
        Dim CalDolarFull As Double
        

        If RRielSSFee.Checked = True Then
            RielSosial = EmptyString(TxtSosialServiceFee.Text)
            CalDolarSosial = RielSosial / 4000
            If CalDolarSosial < 1 Then
                CalDolarSosial = 1
            End If
        Else
            DolarSosial = EmptyString(TxtSosialServiceFee.Text)
            CalDolarSosial = DolarSosial
        End If
        If RReilFFee.Checked = True Then
            RielFull = EmptyString(TxtFullFee.Text)
            CalDolarFull = RielFull / 4000
            If CalDolarFull < 1 Then
                CalDolarFull = 1
            End If
        Else
            DolarFull = EmptyString(TxtFullFee.Text)
            CalDolarFull = DolarFull
        End If
        If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
            MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Exclamation, "Error")
            CboDiagnosis.Focus()
            CboDiagnosis.SelectAll()
            Exit Sub
        End If
        If ModSurgeries.CheckSurgeries(CboOperationType.Text) = 0 Then
            MsgBox("Surgeries not exist in system. Could you contact system adiminstrator to create surgeries name.", MsgBoxStyle.Exclamation, "Exclamtion")
            CboOperationType.Focus()
            CboOperationType.SelectAll()
            Exit Sub
        End If
        If ValidateTextField(TxtReceiptNo, "receiptNo", ErrInpatient) = False Or _
        ValidateLabelField(TxtPatientNo, "patient no", ErrInpatient) = False Or _
        ValidateCombobox(CboOperationType, "Type operation", ErrInpatient) = False Or _
        ValidateCombobox(CboDiagnosis, "Diagnosis", ErrInpatient) = False Then
            MsgBox("Could you fill in-patient information.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        ElseIf Me.TxtSosialServiceFee.Text <> "0" And Me.RRielSSFee.Checked = False And Me.RDolarSSFee.Checked = False Then
            MsgBox("Please choose option Riel or Dollar for social service to save.", MsgBoxStyle.Information, "Social Service")
            Me.TxtSosialServiceFee.Focus()
        ElseIf Me.TxtFullFee.Text <> "0" And Me.RReilFFee.Checked = False And Me.RDolarFFee.Checked = False Then
            MsgBox("Please choose option Riel or Dollar for full fee to save.", MsgBoxStyle.Information, "Full Fee")
            Me.TxtFullFee.Focus()
        ElseIf Me.DateIn.Checked = False Then
            MsgBox("Please select date to save.", MsgBoxStyle.Information, "Date confirm")
            Me.DateIn.Focus()
        
        Else
            If LblSaveOption.Text = "0" Then
                ' For calculate sosial service 
                If LblConsultType.Text = "No Consult" Then
                    MessageBox.Show("This patient not yet registration in consulting list.Please contace department consult", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If LblConsultType.Text = "Social" Then
                    MessageBox.Show("This patient can not save, Because patient consult is Pay for PATIENT SOCIAL. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If LblConsultType.Text = "Full" Then
                    MessageBox.Show("This patient can not save, Because patient consult is Pay for PATIENT FULL. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If TxtReceiptNo.Text <> "0" Then
                    If ModInPatient.CheckPatientAndReceipt(TxtPatientNo.Text, TxtReceiptNo.Text) = True Then
                        MsgBox("Patient already exist in-patient book. Could you check in-patient book again.", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                End If
                If Me.ChDonation.Checked = True Then
                    If ValidateCombobox(CboDonation, "", ErrInpatient) = False Then
                        Exit Sub
                    End If
                    If ValidateTextField(TxtDonationPay, "", ErrInpatient) = False Then
                        Exit Sub
                    End If
                    ModDonation.SaveNewDonatPay(TxtReceiptNo.Text, TxtPatientNo.Text, LblPatientNameEng.Text, "", TxtAge.Text, TxtSex.Text, TxtAddress.Text, "", TxtDonationPay.Text, FormatDateTime(DateIn.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, CboOperationType.Text, "", TxtHosFee.Text, 0, "IP", 0, LblCombindReferal.Text, LblConsultType.Text)
                End If
                DIALOG_SAVE = MessageBox.Show(MSG_SAVE, SAVE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                    If ModInPatient.SaveInpatient( _
                    TxtReceiptNo.Text, _
                    TxtPatientNo.Text, _
                    CboDiagnosis.Text, _
                    CboOperationType.Text, _
                    EmptyString(TxtHosFee.Text), _
                    RielSosial, _
                    RielFull, _
                    DolarSosial, _
                    DolarFull, _
                    CalDolarSosial, _
                    CalDolarFull, _
                    TxtOther.Text, _
                    DateIn.Value, ChDonation.Checked, _
                    CboDonation.SelectedValue, CboDonation.SelectedText, _
                    TxtDonationPay.Text, 0) = 1 Then

                        MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, SAVE_TITLE)
                        'If ChDonation.Checked = True Then
                        '    If MCashReceipt.CheckDuplicateReceiptNo(Me.LblReceiptNoHid.Text, "tblPatientReceipt") = True Then
                        '        LoadNewReceiptNo()
                        '    End If
                        '    ModInPatient.SaveReceiptNillForDonation(LblReceiptNoHid.Text, _
                        '    TxtPatientNo.Text, CboOperationType.Text, DateIn.Value, _
                        '    TxtHosFee.Text, 0, ChDonation.Checked, _
                        '    CboDonation.SelectedValue, CboDonation.Text, TxtDonationPay.Text)
                        'End If
                        If LblConsultID.Text = "0" Then
                        Else
                            DS_Consult.UpdateStatus(1, LblConsultID.Text)
                        End If
                        isCloseIn = True
                        Me.Close()
                    Else
                        MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                    End If
                End If
            Else
                DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, UPDATE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                    If ModInPatient.UpdateInpatient( _
                    LblSaveOption.Text, _
                    TxtReceiptNo.Text, _
                    TxtPatientNo.Text, _
                    CboDiagnosis.Text, _
                    CboOperationType.Text, _
                    EmptyString(TxtHosFee.Text), _
                    RielSosial, _
                    RielFull, _
                    DolarSosial, _
                    DolarFull, _
                    CalDolarSosial, _
                    CalDolarFull, _
                    TxtOther.Text, _
                    DateIn.Value) = 1 Then
                        MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, UPDATE_TITLE)
                        isCloseIn = True
                        Me.Close()
                    Else
                        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, ERROR_TITLE)
                    End If
                End If
            End If
        End If
    End Sub
    Sub LoadNewReceiptNo()
        Me.LblReceiptNoHid.Text = MCashReceipt.getMaxID()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isCloseIn = False
        Me.Close()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub FRMIn_patient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckIsPatientConsult(TxtPatientNo.Text, "In-Patient", 0)
        'Me.DateIn.Checked = False
        LblCombindReferal.Text = ModNew_Outpatient.Get_CombindReferal(TxtPatientNo.Text)
    End Sub
    Public Function CheckIsPatientConsult(ByVal PatientNo As Double, ByVal ConsultFor As String, ByVal Status As Integer) As Boolean
        Dim DataTbl As DataTable = DA_Consult_Detail.GetDataByConsultFor(PatientNo, ConsultFor, Status)
        If DataTbl.Rows.Count >= 1 Then
            For i As Integer = 0 To DataTbl.Rows.Count - 1
                ' MsgBox(DataTbl.Rows(i).Item("CONSULT_FOR"))
                LblConsultID.Text = DataTbl.Rows(i).Item("CONSULING_ID")
                LblConsultDate.Text = DataTbl.Rows(i).Item("CONSULING_DATE")
                LblConsultType.Text = DataTbl.Rows(i).Item("DONATE_TYPE")
                lblConsultFor.Text = DataTbl.Rows(i).Item("CONSULT_FOR")
                LblSendBy.Text = DataTbl.Rows(i).Item("APROVE_BY")
                'rdOperationR.Checked = True
                'rdOperationR.Enabled = False
                'rdOperationD.Enabled = False
                'txtOperationFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                'txtOperationFee.Enabled = False
                CboDiagnosis.Text = DataTbl.Rows(i).Item("DIAGNOSIS2")
                CboOperationType.Text = DataTbl.Rows(i).Item("OPERATION2")
                TxtHosFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
                RRielSSFee.Checked = True
                RReilFFee.Checked = True
                TxtHosFee.Enabled = False
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Nil" Then
                    TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    ChDonation.Checked = True
                    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                    TxtFullFee.Text = "0"
                    ChDonation.Enabled = False
                    GroupBox8.Enabled = False
                End If

                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Social" Then
                    TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    ChDonation.Checked = True
                    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                    TxtFullFee.Text = "0"
                    ChDonation.Enabled = False
                    GroupBox8.Enabled = False
                End If
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Full" Then
                    TxtSosialServiceFee.Text = "0"
                    TxtFullFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
                End If
                TxtSosialServiceFee.Enabled = False
                TxtFullFee.Enabled = False

                RRielSSFee.Enabled = False
                RDolarSSFee.Enabled = False

                RReilFFee.Enabled = False
                RDolarFFee.Enabled = False

            Next
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub RRielSSFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRielSSFee.CheckedChanged
        Me.TxtSosialServiceFee.Focus()
        RReilFFee.Checked = False
        RDolarFFee.Checked = False
        TxtFullFee.Text = 0
    End Sub

    Private Sub RDolarSSFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDolarSSFee.CheckedChanged
        Me.TxtSosialServiceFee.Focus()
        RReilFFee.Checked = False
        RDolarFFee.Checked = False
        TxtFullFee.Text = 0
    End Sub

   

    Private Sub RReilFFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RReilFFee.CheckedChanged
        Me.TxtFullFee.Focus()
        RRielSSFee.Checked = False
        RDolarSSFee.Checked = False
        TxtSosialServiceFee.Text = 0
    End Sub

    Private Sub RDolarFFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDolarFFee.CheckedChanged
        Me.TxtFullFee.Focus()
        RRielSSFee.Checked = False
        RDolarSSFee.Checked = False
        TxtSosialServiceFee.Text = 0
    End Sub

    Private Sub TxtSosialServiceFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSosialServiceFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtFullFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFullFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtHosFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHosFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboOperationType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboOperationType.SelectedIndexChanged
        Try
            TxtHosFee.Text = ModSurgeries.GetSurgeryPrice(CboOperationType.SelectedValue)
        Catch ex As Exception
            TxtHosFee.Text = ""
        End Try
    End Sub

    Private Sub ChDonation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDonation.CheckedChanged
        CleanDonation(ChDonation.Checked)
    End Sub
    Sub CleanDonation(ByVal enable As Boolean)
        CboDonation.SelectedIndex = -1
        TxtDonationPay.Text = ""
        CboDonation.Enabled = enable
        TxtDonationPay.Enabled = enable
        If enable = True Then
            LoadNewReceiptNo()
        Else
            LblReceiptNoHid.Text = "0"
        End If

    End Sub
End Class