Imports System.Math
Public Class FormForInpatientReceiptFront
    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DS_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        dtpDateIn.Value = ModGlobleVariable.GeteDateServer
        Try
            With Me.txtOperation
                .DataSource = ModSurgeries.SelectSurgeries()
                .DisplayMember = "Surgeries"
                .ValueMember = "SID"
                '.Text = ""
                .SelectedIndex = -1
            End With
            With CboDiagnosis
                .DataSource = ModDiagnosis.SelectMainSurgery()
                .ValueMember = "Surgery"
                .SelectedValue = "SID"
                .Text = ""
                .SelectAll()
            End With
            InitDonation()
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub CleanDonation(ByVal enable As Boolean)
        CboDonation.SelectedIndex = -1
        TxtDonationPay.Text = ""
        CboDonation.Enabled = enable
        TxtDonationPay.Enabled = enable
        BtnDonation.Enabled = enable
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'If CheckTheSameDay(txtHN.Text, dtpDateIn.Value) > 0 Then

        '    Exit Sub
        'End If
        If LblConsultType.Text = "No Consult" Then
            MessageBox.Show("This patient not yet registration in consulting list.Please contace department consult", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If LblConsultType.Text = "Nil" Then
            MessageBox.Show("This patient can not save, Because patient consult is PATIENT NILL. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CheckSave() = False Then
            Exit Sub
        End If
        If Me.lblID.Text = 0 Then
            If SaveInPatientReceipt() = True Then
                'Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
                Me.lblID.Text = 0
                AccRolesCashier = True
                isTrueFalse = False
                If LblConsultID.Text = "0" Then
                Else
                    DS_Consult.UpdateStatus(1, LblConsultID.Text)
                End If
                BgLoadReceipt.RunWorkerAsync()
            Else
                'MessageBox.Show("Error, Save inpatient receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Function CheckStatusPayment() As Boolean

        For Each obj As Object In GroupPay.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function SaveInPatientReceipt() As Boolean
        ' Check Dolar
        Dim DolarSosial As Double
        Dim RielSosial As Double

        Dim DolarFull As Double
        Dim RielFull As Double

        Dim CalDolarSosial As Double
        Dim CalDolarFull As Double
        ' For calculate sosial service 
        If RRielSSFee.Checked = True Then
            RielSosial = EmptyString(TxtSosialServiceFee.Text)
            CalDolarSosial = RielSosial / 4000
            If CalDolarSosial < 1 Then
                CalDolarSosial = 1
            Else
                CalDolarSosial = RielSosial / 4000
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
            Else
                CalDolarFull = RielFull / 4000
            End If
        Else
            DolarFull = EmptyString(TxtFullFee.Text)
            CalDolarFull = DolarFull
        End If
        If rdOperationR.Checked = True Then
            RielFull = EmptyString(txtTotal.Text)
            CalDolarFull = RielFull / 4000
            If CalDolarFull < 1 Then
                CalDolarFull = 1
            Else
                CalDolarFull = RielFull / 4000
            End If
        Else
            DolarFull = EmptyString(txtTotal.Text)
            CalDolarFull = DolarFull
        End If
        '********************************
        If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
            LoadNewReceiptNo()
        End If
        If MessageBox.Show("Do you  want to save these information?", "Save confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Dim CashTotal As Double = 0
            cmdSave.Enabled = False
            PicLoading.Visible = True
            cmdClose.Enabled = False
            Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
            Dim Transaction As SqlClient.SqlTransaction = Nothing
            Transaction = Con.BeginTransaction
            sqlComm.Transaction = Transaction
            Try
                '================= Save Receipt in patient============
                sqlComm.CommandText = DoSaveInPatientReceipt(Me.txtReceiptNumber.Text, _
                Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", _
                Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.rdOperationR.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdOperationD.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdArtificialEyeR.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdArtificialEyeD.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdOtherR.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdOtherD.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                Me.txtRate.Text, Me.txtAmountWord.Text, _
                IIf(Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True, "1", "0"), _
                IIf(Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True, "1", "0"), _
                IIf(Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True, "1", "0"), _
                IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                IIf(Me.chkSocialFee.Checked = False, 1, 0), "IR", Me.lblCashier.Text, "", 1, _
                Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"), ModGlobleVariable.GeteDateServer.Year, _
                Me.txtOperation.Text, ChDonation.Checked, CboDonation.SelectedValue, _
                CboDonation.Text, EmptyString(TxtDonationPay.Text), TxtDonateNote.Text, EmptyString(TxtHosFee.Text))
                sqlComm.ExecuteNonQuery()
                '==============================End Save receipt inpatient======================
                '================= Save Inpatient book ======================================
                ''' ============== Do for donation =====================================
                If ChDonation.Checked = True Then
                    ' To exchange currentcy reil to dolar Becoz columne is Reil
                    If Me.lblRielDolar.Text = "erol" Then
                        CashTotal = Round(txtTotal.Text / 4000, 2)
                    Else
                        CashTotal = txtTotal.Text
                    End If
                    If CashTotal = TxtDonationPay.Text Then
                        CashTotal = 0
                    End If
                    'If CashTotal > TxtDonationPay.Text Then
                    '    MessageBox.Show("The patient pay can not greater than donor pay. Please patient pay again.", "Donated", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    Exit Function
                    'End If
                    sqlComm.CommandText = DoSaveDonationDetail(txtReceiptNumber.Text, txtHN.Text, LblPatientEn.Text, txtPatient.Text, LblAge.Text, LblSex.Text, LblAddress.Text, "", TxtDonationPay.Text, FormatDateTime(dtpDateIn.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, txtOperation.Text, TxtDonateNote.Text, TxtHosFee.Text, CashTotal, "IP", LblComBindRefferal.Text, LblConsultType.Text)
                    sqlComm.ExecuteNonQuery()
                    'ModDonation.SaveNewDonatPay(txtReceiptNumber.Text, txtHN.Text, LblPatientEn.Text, txtPatient.Text, LblAge.Text, LblSex.Text, LblAddress.Text, "", TxtDonationPay.Text, FormatDateTime(dtpDateIn.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, txtOperation.Text, TxtDonateNote.Text, TxtHosFee.Text, CashTotal, "IP")
                End If
                sqlComm.CommandText = DoSaveInPatientBook( _
                                        txtReceiptNumber.Text, _
                                        txtHN.Text, _
                                        CboDiagnosis.Text, _
                                        txtOperation.Text, _
                                        EmptyString(TxtHosFee.Text), _
                                        IIf(RRielSSFee.Checked = True, TxtSosialServiceFee.Text, 0), _
                                        IIf(RReilFFee.Checked = True, TxtFullFee.Text, 0), _
                                        IIf(RDolarSSFee.Checked = True, TxtSosialServiceFee.Text, 0), _
                                        IIf(RDolarFFee.Checked = True, TxtFullFee.Text, 0), _
                                        CalDolarSosial, _
                                        CalDolarFull, _
                                        "", _
                                        dtpDateIn.Value, ChDonation.Checked, CboDonation.SelectedValue, CboDonation.Text, EmptyString(TxtDonationPay.Text), CashTotal)
                sqlComm.ExecuteNonQuery()
                '====================== end save in patient book================
                Transaction.Commit()
                Transaction.Dispose()
                Return True
            Catch ex As Exception
                MessageBox.Show("Error, Save inpatient receipt. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Transaction.Rollback()
                Return False
            Finally
                Con.Close()
                Con.Dispose()
            End Try
        End If
    End Function
    Sub LoadNewReceiptNo()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
    End Sub
    Dim frmReportInPR As New frmReportInpatientReceipt
    '-------------Report Form Active--------------------------------
    Dim ReportInPR As New ReportInpatientReceipt
    Dim checkPrintPreview As Boolean = False
    Private Sub PrintReportIPR()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PrintReportIPR))
        Else
            Try
                'Me.cmdPrint.Enabled = False
                ReportInPR.SetDataSource(MInpatientReceipt.ReportInpatientReceipt(Me.txtReceiptNumber.Text).Tables(1))
                ReportInPR.Refresh()
                If checkPrintPreview = True Then
                    frmReportInPR.crvInpatientReceipt.ReportSource = ReportInPR
                    frmReportInPR.ShowDialog()
                    frmReportInPR.Dispose()
                    frmReportInPR.Close()
                    ReportInPR.Dispose()
                    ReportInPR.Close()
                Else
                    printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                    ReportInPR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                    ReportInPR.PrintToPrinter(1, True, 1, 1)
                    ReportInPR.Dispose()
                    ReportInPR.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If

    End Sub
    Private Function CheckSave() As Boolean
        If Me.chkSocialFee.Checked = False Then
            If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                MsgBox("Receipt date can not < " & ModGlobleVariable.GeteDateServer, MsgBoxStyle.Critical, "Error")
                Return False
                'ElseIf CheckDuplicateDateInPatient(txtHN.Text, dtpDateIn.Value) = True Then
                '    MsgBox("This patient have registration for In-Patient today already. Could you check In-patient book agian.", MsgBoxStyle.Critical, "Error")
                '    Return False
            ElseIf Me.lblCashier.Text = "" Then
                MsgBox("Please check the cashier name.", MsgBoxStyle.Information, "Cashier Confirm")
                Return False
            ElseIf ValidateTextField(txtReceiptNumber, "", ErrInPatientReceipt) = False Then
                'MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number confirm")
                Me.txtReceiptNumber.Select()
                Me.txtReceiptNumber.Focus()
                Return False
            ElseIf ValidateTextField(Me.txtHN, "", ErrInPatientReceipt) = False Then
                'MsgBox("Please enter HN number.", MsgBoxStyle.Information, "HN confirm")
                Me.txtHN.Select()
                Me.txtHN.Focus()
                Return False
            ElseIf Me.dtpDateIn.Checked = False Then
                MsgBox("Please select date to save.", MsgBoxStyle.Critical, "Date confirm")
                dtpDateIn.Select()
                Me.dtpDateIn.Focus()
                Return False
            ElseIf ValidateTextField(txtRate, "", ErrInPatientReceipt) = False Then
                Me.txtRate.Select()
                Me.txtRate.Focus()
                Return False
            ElseIf ValidateTextField(txtPatient, "", ErrInPatientReceipt) = False Then
                ' MsgBox("Please enter the patient name.", MsgBoxStyle.Information, "Patient confirm")
                Me.txtPatient.Focus()
                Return False
            ElseIf Me.rdOperationR.Checked = False And Me.rdOperationD.Checked = False And Me.rdArtificialEyeR.Checked = False And Me.rdArtificialEyeD.Checked = False And Me.rdOtherR.Checked = False And Me.rdOtherD.Checked = False Then
                MsgBox("Please enter the amount of operation or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdOperationR.Focus()
                Return False
                'ElseIf Me.rdOperationR.Checked = False Then 'And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter operation fee in Riel.", MsgBoxStyle.Critical, "Operation fee Riel confirm")
                '    Me.txtOperationFee.Focus()
                '    Return False
                'ElseIf Me.rdOperationD.Checked = True Then 'And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter operation fee in Dollar.", MsgBoxStyle.Critical, "Operation fee Dollar confirm")
                '    Me.txtOperationFee.Focus()
                '    Return False
                'ElseIf Me.rdArtificialEyeR.Checked = True Then 'And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter artificial fee in Riel.", MsgBoxStyle.Critical, "Artificial fee Riel confirm")
                '    Me.txtAritificialEyeFee.Focus()
                '    Return False
                'ElseIf Me.rdArtificialEyeD.Checked = True And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter artificial fee in Dollar.", MsgBoxStyle.Critical, "Artificial fee Dollar confirm")
                '    Me.txtAritificialEyeFee.Focus()
                '    Return False
                'ElseIf Me.rdOtherR.Checked = True And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter other fee in Riel.", MsgBoxStyle.Critical, "Other fee Riel confirm")
                '    Me.txtOtherFee.Focus()
                '    Return False
                'ElseIf Me.rdOtherD.Checked = True And Me.txtTotal.Text = "0" Then
                '    MsgBox("Please enter other fee in Dollar.", MsgBoxStyle.Critical, "Other fee Dollar confirm")
                '    Me.txtOtherFee.Focus()
                '    Return False
            ElseIf Me.txtAmountWord.Text = "" Then
                MsgBox("Please enter the amount payment in word.", MsgBoxStyle.Critical, "Amount payment word confirm")
                Me.txtAmountWord.Focus()
                Return False
            ElseIf ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
                MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                CboDiagnosis.Focus()
                CboDiagnosis.SelectAll()
                Return False
            ElseIf ModSurgeries.CheckSurgeries(txtOperation.Text) = 0 Then
                MsgBox("Surgeries not exist in system. Could you contact system adiminstrator to create surgeries name.", MsgBoxStyle.Critical, "Exclamtion")
                txtOperation.Focus()
                txtOperation.SelectAll()
                Return False
            ElseIf TxtHosFee.Text = "" Then
                MsgBox("Please enter the amount Hos.Fee.", MsgBoxStyle.Critical, "Exclamtion")
                TxtHosFee.Focus()
                TxtHosFee.SelectAll()
                Return False
            ElseIf CheckStatusPayment() = False Then
                MessageBox.Show("Please check patient Fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GroupPay.BackColor = Color.Khaki
                Return False
            ElseIf Me.TxtSosialServiceFee.Text = "0" And Me.RRielSSFee.Checked = False Then
                MsgBox("Please choose option Riel or Dollar for social service to save.", MsgBoxStyle.Critical, "Social Service")
                Me.TxtSosialServiceFee.Focus()
                Return False
            ElseIf Me.TxtSosialServiceFee.Text = "0" And Me.RDolarSSFee.Checked = True Then
                MsgBox("Please choose option Riel or Dollar for social service to save.", MsgBoxStyle.Critical, "Social Service")
                Me.TxtSosialServiceFee.Focus()
                Return False
            ElseIf Me.TxtFullFee.Text = "0" And Me.RReilFFee.Checked = False Then
                MsgBox("Please choose option Riel or Dollar for full fee to save.", MsgBoxStyle.Critical, "Full Fee")
                Me.TxtFullFee.Focus()
                Return False
            ElseIf Me.TxtFullFee.Text = "0" And Me.RDolarFFee.Checked = True Then
                MsgBox("Please choose option Riel or Dollar for full fee to save.", MsgBoxStyle.Critical, "Full Fee")
                Me.TxtFullFee.Focus()
                Return False
                'ElseIf AccRolesCashier = True Then
                '    If Me.chkRiel.Checked = False And Me.chkDollar.Checked = False Then
                '        MsgBox("Please enter any amount in figure Riel or Dollar.", MsgBoxStyle.Critical, "Amount figure Riel or Dollar confirm")
                '        Me.chkRiel.Checked = True
                '        Return False
                '    ElseIf Me.chkRiel.Checked = True And Me.chkDollar.Checked = True And Me.txtAmountFigureR.Text = "0" And Me.txtAmountFigureD.Text = "0" Then
                '        MsgBox("Please enter amount figure Riel or Dollar.", MsgBoxStyle.Critical, "Amount figure Riel or Dollar confirm")
                '        Me.txtAmountFigureR.Focus()
                '        Return False
                '    ElseIf Me.chkRiel.Checked = True And Me.txtAmountFigureR.Text = "0" Then
                '        MsgBox("Please enter the amount of figure in Riel.", MsgBoxStyle.Critical, "Amount figure Riel confirm")
                '        Me.txtAmountFigureR.Focus()
                '        Return False
                '    ElseIf Me.chkDollar.Checked = True And Me.txtAmountFigureD.Text = "0" Then
                '        MsgBox("Please enter the amount of figure in Dollar.", MsgBoxStyle.Critical, "Amount figure Dollar confirm")
                '        Me.txtAmountFigureD.Focus()
                '        Return False
                '    End If
            ElseIf ChDonation.Checked = True Then
                If ValidateCombobox(CboDonation, "", ErrInPatientReceipt) = False Then
                    CboDonation.Select()
                    CboDonation.Focus()
                    Return False
                ElseIf ValidateTextField(TxtDonationPay, "", ErrInPatientReceipt) = False Then
                    TxtDonationPay.Select()
                    TxtDonationPay.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function
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
                rdOperationR.Checked = True
                rdOperationR.Enabled = False
                rdOperationD.Enabled = False
                txtOperationFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                txtOperationFee.Enabled = False
                CboDiagnosis.Text = DataTbl.Rows(i).Item("DIAGNOSIS2")
                txtOperation.Text = DataTbl.Rows(i).Item("OPERATION2")
                TxtHosFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
                RRielSSFee.Checked = True
                RReilFFee.Checked = True
                TxtHosFee.Enabled = False
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Social" Then
                    If DataTbl.Rows(i).Item("IS_RIEL_DOLAR") = True Then
                        RRielSSFee.Checked = True
                        rdOperationR.Checked = True
                        TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                        txtOperationFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    Else
                        RDolarSSFee.Checked = True
                        rdOperationD.Checked = True
                        TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                        txtOperationFee.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                    End If

                    ChDonation.Checked = True
                    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                    TxtFullFee.Text = "0"
                    ChDonation.Enabled = False
                    GroupBox8.Enabled = False
                End If
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Nil" Then
                    TxtSosialServiceFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    ChDonation.Checked = True
                    CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                    TxtDonationPay.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                    TxtFullFee.Text = "0"
                    ChDonation.Enabled = False
                    GroupBox8.Enabled = False
                End If
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Full" Then

                    If DataTbl.Rows(i).Item("IS_RIEL_DOLAR") = True Then
                        RReilFFee.Checked = True
                        rdOperationR.Checked = True
                        TxtFullFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                        txtOperationFee.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    Else
                        RDolarFFee.Checked = True
                        rdOperationD.Checked = True
                        TxtFullFee.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                        txtOperationFee.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                    End If

                    TxtSosialServiceFee.Text = "0"
                    ' TxtFullFee.Text = DataTbl.Rows(i).Item("HOSPITAL_FEE")
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
    Private Sub FormForInpatientReceiptFront_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblCashierLogin.Text = ""
        Me.dtpDateIn.Checked = False
        Me.lblCashierLogin.Text = USER_NAME
        Me.lblCashier.Text = USER_NAME
        Call GetRates()
        CheckIsPatientConsult(txtHN.Text, "In-Patient", 0)
        Me.lblFees.Text = ""
        LoadNewReceiptNo()
        AccRolesCashier = False
        LblComBindRefferal.Text = ModNew_Outpatient.Get_CombindReferal(txtHN.Text)
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    Me.cmdSave.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdSave.Enabled = True
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdSave.Enabled = True
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.cmdSave.Enabled = True
                End If
            End With
        Next
    End Sub
    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub rdOperationR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOperationR.CheckedChanged
        If Me.rdOperationR.Checked = True Then
            Me.txtOperationFee.Enabled = True
            Me.txtOperationFee.Text = ""
            Me.txtOperationFee.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtOperationFee.Text = "0"
            Me.txtOperationFee.Enabled = False
        End If
    End Sub

    Private Sub rdOperationD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOperationD.CheckedChanged
        If Me.rdOperationD.Checked = True Then
            Me.txtOperationFee.Enabled = True
            Me.txtOperationFee.Text = ""
            Me.txtOperationFee.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtOperationFee.Text = "0"
            Me.txtOperationFee.Enabled = False
        End If
    End Sub

    Private Sub rdArtificialEyeR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdArtificialEyeR.CheckedChanged
        If Me.rdArtificialEyeR.Checked = True Then
            Me.txtAritificialEyeFee.Enabled = True
            Me.txtAritificialEyeFee.Text = ""
            Me.txtAritificialEyeFee.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "AEFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtAritificialEyeFee.Text = "0"
            Me.txtAritificialEyeFee.Enabled = False
        End If
    End Sub

    Private Sub rdArtificialEyeD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdArtificialEyeD.CheckedChanged
        If Me.rdArtificialEyeD.Checked = True Then
            Me.txtAritificialEyeFee.Enabled = True
            Me.txtAritificialEyeFee.Text = ""
            Me.txtAritificialEyeFee.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "AEFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtAritificialEyeFee.Text = "0"
            Me.txtAritificialEyeFee.Enabled = False
        End If
    End Sub

    Private Sub rdOtherR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOtherR.CheckedChanged
        If Me.rdOtherR.Checked = True Then
            Me.txtOtherFee.Enabled = True
            Me.txtOtherFee.Text = ""
            Me.txtOtherFee.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtOtherFee.Text = "0"
            Me.txtOtherFee.Enabled = False
        End If
    End Sub

    Private Sub rdOtherD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOtherD.CheckedChanged
        If Me.rdOtherD.Checked = True Then
            Me.txtOtherFee.Enabled = True
            Me.txtOtherFee.Text = ""
            Me.txtOtherFee.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtOtherFee.Text = "0"
            Me.txtOtherFee.Enabled = False
        End If
    End Sub

    Private Sub txtOperationFee_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOperationFee.MouseClick
        Me.txtOperationFee.SelectAll()
    End Sub
    Private Sub txtOperationFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOperationFee.LostFocus
        If Me.txtOperationFee.Text.Trim = "" Then
            Me.txtOperationFee.Text = "0"
        End If
    End Sub

    Private Sub txtOperationFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperationFee.TextChanged
        If Me.txtOperationFee.Text.Trim > "0" Then
            Me.txtAritificialEyeFee.Text = "0"
            Me.txtOtherFee.Text = "0"
            Me.txtTotal.Text = Me.txtOperationFee.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub
    Private Sub InpatientPayment()
        Dim Riels As Double
        Dim Dollars As Double
        If Me.lblRielDolar.Text = "erol" And Me.chkRiel.Checked = True And Me.chkDollar.Checked = True Then
            Riels = Val(Me.txtAmountFigureD.Text) * Val(Me.txtRate.Text)
            Me.txtReturnR.Text = Round((Val(Me.txtAmountFigureR.Text) + Riels) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkRiel.Checked = True And Me.chkDollar.Checked = True Then
            Dollars = Val(Me.txtAmountFigureR.Text) / Val(Me.txtRate.Text)
            Me.txtReturnD.Text = Round((Val(Me.txtAmountFigureD.Text) + Dollars) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "erol" And Me.chkRiel.Checked = True Then
            Me.txtReturnR.Text = Round(Val(Me.txtAmountFigureR.Text) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "erol" And Me.chkDollar.Checked = True Then
            Riels = Val(Me.txtAmountFigureD.Text) * Val(Me.txtRate.Text)
            Me.txtReturnR.Text = Round((Val(Me.txtAmountFigureR.Text) + Riels) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnD.Text = Round(Val(Me.txtReturnR.Text) / Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkDollar.Checked = True Then
            Me.txtReturnD.Text = Round(Val(Me.txtAmountFigureD.Text) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        ElseIf Me.lblRielDolar.Text = "duløa" And Me.chkRiel.Checked = True Then
            Dollars = Val(Me.txtAmountFigureR.Text) / Val(Me.txtRate.Text)
            Me.txtReturnD.Text = Round((Val(Me.txtAmountFigureD.Text) + Dollars) - Val(Me.txtTotal.Text), 2)
            Me.txtReturnR.Text = Round(Val(Me.txtReturnD.Text) * Val(Me.txtRate.Text), 2)
        End If
    End Sub

    Private Sub txtOperationFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperationFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAritificialEyeFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAritificialEyeFee.TextChanged
        If Me.txtAritificialEyeFee.Text.Trim > "0" Then
            Me.txtOperationFee.Text = "0"
            Me.txtOtherFee.Text = "0"
            Me.txtTotal.Text = Me.txtAritificialEyeFee.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub txtAritificialEyeFee_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAritificialEyeFee.MouseClick
        Me.txtAritificialEyeFee.SelectAll()
    End Sub

    Private Sub txtAritificialEyeFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAritificialEyeFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtOtherFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtherFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtOtherFee_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOtherFee.MouseClick
        Me.txtOtherFee.SelectAll()
    End Sub

    Private Sub txtOtherFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherFee.TextChanged
        If Me.txtOtherFee.Text.Trim > "0" Then
            Me.txtOperationFee.Text = "0"
            Me.txtAritificialEyeFee.Text = "0"
            Me.txtTotal.Text = Me.txtOtherFee.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub
    Function DoSaveInPatientReceipt(ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
        ByVal CashRiel As Double, ByVal CashUSD As Double, _
        ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
        ByVal OperationFeeRiel As Double, ByVal OperationFeeUSD As Double, _
        ByVal ArtificialEyeFeeRiel As Double, ByVal ArtificialEyeUSD As Double, _
        ByVal OtherFeeRiel As Double, ByVal OtherFeeUSD As Double, _
        ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
        ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, ByVal AmountWord As String, _
        ByVal ConOP As String, ByVal ConAE As String, ByVal ConOT As String, ByVal ConSocialFee As String, _
        ByVal ConFullFee As String, ByVal ConGeneral As String, _
        ByVal CashierIn As String, ByVal CashierUpdate As String, _
        ByVal PrintCount As Integer, ByVal DateIn As Date, _
        ByVal DateNow As Date, ByVal Years As Integer, _
        ByVal Operation As String, ByVal IsDonation As Boolean, _
        ByVal DonationID As Double, ByVal DonationName As String, _
        ByVal DonationPay As Double, ByVal DonateNote As String, ByVal HosFee As Double) As String
        Dim SQL As String = "INSERT INTO tblPatientReceipt " _
                            & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                            & " OperationFeeRiel, OperationFeeUSD, ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel," _
                            & " OtherFeeUSD, SocialFeeRiel," _
                            & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConOP, ConAE, ConOT, ConSocialFee, ConFullFee," _
                            & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow,Years, Operation,IsDonation,DonationID," _
                            & " DonationName,DonationPay,DonateNote,HosFee)" _
                            & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                            & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                            & OperationFeeRiel & "," & OperationFeeUSD & "," & ArtificialEyeFeeRiel & "," & ArtificialEyeUSD & "," _
                            & OtherFeeRiel & "," & OtherFeeUSD & "," _
                            & SocialFeeRiel & "," & SocialFeeUSD & "," _
                            & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                            & AmountWord & "','" & ConOP & "','" & ConAE & "','" & ConOT & "','" & ConSocialFee & "','" _
                            & ConFullFee & "','" & ConGeneral & "','" _
                            & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn _
                            & "','" & DateNow & "'," & Years & ",'" & Operation & "','" & IsDonation & "'," _
                            & DonationID & ",'" & DonationName & "'," & DonationPay & ",'" & DonateNote & "'," & HosFee & ")"
        Return SQL
    End Function
    Function DoSaveDonationDetail(ByVal ReceiptNo As Double, ByVal HN As Double, ByVal NameEng As String, _
                            ByVal NameKhmer As String, ByVal Age As Integer, _
                            ByVal Sex As String, ByVal Address As String, ByVal Occupation As String, _
                            ByVal DonationPay As String, ByVal DateIn As Date, ByVal DonationID As Integer, ByVal DonationName As String, _
                            ByVal Operation As String, ByVal DonateNote As String, ByVal HosFee As Double, ByVal CashTotal As Double, ByVal DonateIn As String, ByVal ComBindRefferal As String, ByVal DonateType As String) As String
        Dim SQL As String = "INSERT INTO DONATION_DETAIL (ReceiptNo,HN,NameEng,NameKhmer,Age,Sex,Address,Occupation,DonationPay,DateIn,DonationID,DonationName,Operation,DonateNote,HosFee,CashTotal,DonateIn,ComBindRefferal,DonateType) VALUES " & _
        " (" & ReceiptNo & "," & HN & ",'" & NameEng & "','" & NameKhmer & "'," & Age & _
        ",'" & Sex & "','" & Replace(Address, "'", "''") & "','" & Occupation & "'," & DonationPay & ",'" & DateIn & _
        "'," & DonationID & ",'" & DonationName & "','" & Operation & "','" & DonateNote & _
        "'," & HosFee & "," & CashTotal & ",'" & DonateIn & "','" & ComBindRefferal & "','" & DonateType & "')"
        Return SQL
    End Function
    Function DoSaveInPatientBook(ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Diagnosis As String, _
    ByVal TypeOfOperation As String, _
    ByVal HosFee As String, _
    ByVal SosialFee As String, _
    ByVal FullFee As String, _
    ByVal DolarSosial As String, _
    ByVal DolarFull As String, _
    ByVal CalDolarSosial As String, _
    ByVal CalDolarFull As String, _
    ByVal Other As String, _
    ByVal CreateDate As Date, _
    ByVal IsDonate As Boolean, _
    ByVal DonationID As Integer, _
    ByVal DonationName As String, _
    ByVal DonationPay As Double, _
    ByVal CashTotal As Double) As String
        Dim sql As String = "INSERT INTO TblInpatient (ReceiptNo,PatientNo,Diagnosis,TypeOfOperation," & _
       "HosFee,SosialFee,FullFee,DolarSosial,DolarFull,CalDolarSosial,CalDolarFull,Other,CreateDate,IsDonate,DonationID,DonationName,DonationPay,CashTotal) " & _
       "VALUES(" & ReceiptNo & "," & _
       PatientNo & ",'" & _
       Diagnosis & "','" & _
       TypeOfOperation & "'," & _
       HosFee & "," & _
       SosialFee & "," & _
       FullFee & "," & _
       DolarSosial & "," & _
       DolarFull & "," & _
       CalDolarSosial & "," & _
       CalDolarFull & ",'" & _
       Other & "','" & _
       CreateDate & "','" & IsDonate & "'," & DonationID & ",'" & DonationName & "'," & DonationPay & "," & CashTotal & ")"
        Return sql
    End Function
    Function CheckTheSameDay(ByVal PatientNo As String, ByVal CreateDate As Date) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInpatient WHERE PatientNO=" & PatientNo & " AND  CAST(CONVERT(VARCHAR(10), CAST(CreateDate AS DATETIME), 1) AS Datetime)=CAST(CONVERT(VARCHAR(10), CAST('" & CreateDate & "' AS DATETIME), 1) AS Datetime)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Private Sub RRielSSFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RRielSSFee.CheckedChanged
        'TxtSosialServiceFee.Text = 0
        'Me.TxtSosialServiceFee.Focus()

        'TxtSosialServiceFee.SelectAll()
        'RReilFFee.Checked = False
        'RDolarFFee.Checked = False
        'TxtFullFee.Text = 0
    End Sub

    Private Sub RDolarSSFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDolarSSFee.CheckedChanged
        'TxtSosialServiceFee.Text = 0
        'Me.TxtSosialServiceFee.Focus()
        'TxtSosialServiceFee.SelectAll()
        'RReilFFee.Checked = False
        'RDolarFFee.Checked = False
        'TxtFullFee.Text = 0
    End Sub

    Private Sub RReilFFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RReilFFee.CheckedChanged
        'TxtFullFee.Text = 0
        'Me.TxtFullFee.Focus()
        'TxtFullFee.SelectAll()
        'RRielSSFee.Checked = False
        'RDolarSSFee.Checked = False
        'TxtSosialServiceFee.Text = 0
    End Sub

    Private Sub RDolarFFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDolarFFee.CheckedChanged
        'TxtFullFee.Text = 0
        'Me.TxtFullFee.Focus()
        'TxtFullFee.SelectAll()

        'RRielSSFee.Checked = False
        'RDolarSSFee.Checked = False
        'TxtSosialServiceFee.Text = 0
    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        If Me.lblRielDolar.Text = "erol" Then
            Me.txtAmountWord.Text = Riel.Convert(Me.txtTotal.Text)
        ElseIf Me.lblRielDolar.Text = "duløa" Then
            Me.txtAmountWord.Text = Dollar.Convert(Me.txtTotal.Text)
        End If
    End Sub

    Private Sub TxtHosFee_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHosFee.GotFocus
        TxtHosFee.SelectAll()
    End Sub

    Private Sub TxtHosFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHosFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtSosialServiceFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSosialServiceFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtFullFee_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFullFee.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub chkRiel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRiel.CheckedChanged
        If Me.chkRiel.Checked = True Then
            Me.txtAmountFigureR.Enabled = True
            Me.txtAmountFigureR.Text = ""
            Me.txtAmountFigureR.Focus()
        Else
            Me.txtAmountFigureR.Enabled = False
            Me.txtAmountFigureR.Text = "0"
        End If
    End Sub

    Private Sub chkDollar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDollar.CheckedChanged
        If Me.chkDollar.Checked = True Then
            Me.txtAmountFigureD.Enabled = True
            Me.txtAmountFigureD.Text = ""
            Me.txtAmountFigureD.Focus()
        Else
            Me.txtAmountFigureD.Enabled = False
            Me.txtAmountFigureD.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureR.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtAmountFigureR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtAmountFigureR_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureR.MouseClick
        If Me.txtAmountFigureR.Text = "0" Then
            Me.txtAmountFigureR.Text = ""
        End If
    End Sub

    Private Sub txtAmountFigureR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.LostFocus
        If Me.txtAmountFigureR.Text.Trim = "" Then
            Me.txtAmountFigureR.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtAmountFigureD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.LostFocus
        If Me.txtAmountFigureD.Text.Trim = "" Then
            Me.txtAmountFigureD.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureD_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureD.MouseClick
        If Me.txtAmountFigureD.Text = "0" Then
            Me.txtAmountFigureD.Text = ""
        End If
    End Sub



    Private Sub txtAmountFigureD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub BgLoadReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReceipt.RunWorkerCompleted
        cmdSave.Enabled = True
        PicLoading.Visible = False
        cmdClose.Enabled = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BgLoadReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReceipt.DoWork
        Call Me.PrintReportIPR()
    End Sub

    Private Sub ChPrintPreveiw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPrintPreveiw.CheckedChanged
        checkPrintPreview = ChPrintPreveiw.Checked
    End Sub

    Private Sub BtnDonation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDonation.Click
        Dim FDonation As New NewDonation
        If FDonation.ShowDialog = Windows.Forms.DialogResult.OK Then
            InitDonation()
        End If
    End Sub
    Sub InitDonation()
        With CboDonation
            .DataSource = ModDonation.GetDonation
            .ValueMember = "DonationID"
            .DisplayMember = "DonationName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDonation.CheckedChanged
        CleanDonation(ChDonation.Checked)
    End Sub

    Private Sub TxtDonationPay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonationPay.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtOperation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperation.SelectedIndexChanged
        Try
            TxtHosFee.Text = ModSurgeries.GetSurgeryPrice(txtOperation.SelectedValue)
        Catch ex As Exception
            TxtHosFee.Text = ""
        End Try
    End Sub

    Private Sub TxtHosFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHosFee.TextChanged

    End Sub

    Private Sub cmdAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRate.Click

    End Sub
End Class