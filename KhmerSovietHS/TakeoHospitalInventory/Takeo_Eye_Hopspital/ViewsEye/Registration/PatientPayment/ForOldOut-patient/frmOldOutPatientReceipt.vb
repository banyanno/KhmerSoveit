Imports System.Math

Public Class frmOldOutPatientReceipt
    Public isCloseOld As Boolean = False
    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DS_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        dtpDateIn.Value = ModGlobleVariable.GeteDateServer
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        AccRolesCashier = False
        isTrueFalse = False
        isCloseOld = False
        Me.Close()
    End Sub
    Public Function CheckIsPatientConsult(ByVal PatientNo As Double, ByVal ConsultFor As String, ByVal Status As Integer) As Boolean
        Dim DataTbl As DataTable = DA_Consult_Detail.GetDataByConsultFor(PatientNo, ConsultFor, Status)
        If DataTbl.Rows.Count = 1 Then
            For i As Integer = 0 To DataTbl.Rows.Count - 1
                ' MsgBox(DataTbl.Rows(i).Item("CONSULT_FOR"))
                LblConsultID.Text = DataTbl.Rows(i).Item("CONSULING_ID")
                LblConsultDate.Text = DataTbl.Rows(i).Item("CONSULING_DATE")
                LblConsultType.Text = DataTbl.Rows(i).Item("DONATE_TYPE")
                lblConsultFor.Text = DataTbl.Rows(i).Item("CONSULT_FOR")
                LblSendBy.Text = DataTbl.Rows(i).Item("APROVE_BY")
                txtFollowUp.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                'CboDiagnosis.Text = DataTbl.Rows(i).Item("DIAGNOSIS2")
            Next
            Return True
        Else
            GetValueOLD()
            Return False
        End If
    End Function
    Private Sub txtAmountFigureR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureR.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
        'If Asc(e.KeyChar) = Keys.Enter Then
        '    Call cmdFind_Click(sender, e)
        '    Me.txtHNFind.Focus()
        'End If
    End Sub

    Private Sub txtAmountFigureR_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.LostFocus
        If Me.txtAmountFigureR.Text.Trim = "" Then
            Me.txtAmountFigureR.Text = "0"
        End If
    End Sub

    Private Sub txtAmountFigureR_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAmountFigureR.MouseClick
        If Me.txtAmountFigureR.Text = "0" Then
            Me.txtAmountFigureR.Text = ""
        End If
    End Sub

    Private Sub txtAmountFigureD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountFigureD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
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

    Private Sub txtAmountFigureR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureR.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtAmountFigureD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountFigureD.TextChanged
        Call InpatientPayment()
    End Sub

    Private Sub txtFollowUp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFollowUp.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFollowUp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFollowUp.LostFocus
        If Me.txtFollowUp.Text.Trim = "" Then
            Me.txtFollowUp.Text = "0"
        End If
    End Sub

    Private Sub txFollowUp_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFollowUp.MouseClick
        Me.txtFollowUp.SelectAll()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFollowUp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFollowUp.TextChanged
        If Me.txtFollowUp.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtFollowUp.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub rdFollowUpR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFollowUpR.CheckedChanged
        If Me.rdFollowUpR.Checked = True Then
            Me.txtFollowUp.Enabled = True
            Me.txtFollowUp.Text = ""
            Me.txtFollowUp.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            txtAmountFigureD.Text = "0"
            txtAmountFigureR.Text = "0"
            chkRiel.Checked = False
            chkDollar.Checked = False
        Else
            Me.txtFollowUp.Text = "0"
            Me.txtFollowUp.Enabled = False
        End If
    End Sub

    Private Sub rdFollowUpD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdFollowUpD.CheckedChanged
        If Me.rdFollowUpD.Checked = True Then
            Me.txtFollowUp.Enabled = True
            Me.txtFollowUp.Text = ""
            Me.txtFollowUp.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            txtAmountFigureD.Text = "0"
            txtAmountFigureR.Text = "0"
            chkRiel.Checked = False
            chkDollar.Checked = False
        Else
            Me.txtFollowUp.Text = "0"
            Me.txtFollowUp.Enabled = False
        End If
    End Sub

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub
    Sub GetValueOLD()
        Dim DA_Old As New DSDEFAULT_VAL_OLD_NEWTableAdapters.DEFAULT_VALUE_OLDTableAdapter
        Dim D_TBL As DataTable = DA_Old.GetData
        With D_TBL
            If .Rows.Count > 0 Then
                Me.txtFollowUp.Text = .Rows(0).Item("DefaultValue")
            End If
        End With
        If Me.txtFollowUp.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtFollowUp.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub frmInpatientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblCashierLogin.Text = ""
        Me.dtpDateIn.Checked = False
        Me.lblCashierLogin.Text = USER_NAME
        Me.lblCashier.Text = USER_NAME
        Call GetRates()


        If isTrueFalse = False Then
            Me.lblReceiptToPrintID.Text = ""    '------------for printing receipt-------------
            Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
            CheckIsPatientConsult(EmptyString(txtHN.Text), "Old Patient", 0)
        Else
            Call SearchOldOPReceipt()
        End If
        Me.lblFees.Text = ""
        ' Me.cmdPrint.Enabled = False
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    Me.cmdCashierSave.Enabled = True
                    Me.cmdSave.Enabled = False
                    Me.Width = 830
                    GDifficulty.Visible = False
                    GReferralFrom.Visible = False
                    ChPrintPreveiw.Visible = False
                    ' Me.cmdPrint.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    ' Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    Me.cmdCashierSave.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    ' Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    'Me.cmdCashierSave.Visible = False
                    cmdCashierSave.Enabled = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.cmdCashierSave.Visible = True
                    Me.cmdSave.Enabled = True
                    'Me.cmdPrint.Enabled = True
                End If
            End With
        Next
        InitChListReferral()
    End Sub
    Sub InitChListReferral()
        With ChListReferral
            .Items.Clear()
            Dim TblReferral As DataTable = DA_Referral.GetData
            For Each DRow As DataRow In TblReferral.Rows
                .Items.Add(DRow("REFFERAL_NAME"))
            Next
        End With
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

    Sub ClearSearch()
        Me.txtHN.Text = ""
        Me.txtPatient.Text = ""

        Me.lblID.Text = 0
        Me.dtpDateIn.Checked = False

        Me.lblReceiptToPrintID.Text = ""

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtFollowUp.Enabled = False
        Me.txtFollowUp.Text = "0"
        Me.rdFollowUpR.Checked = False
        Me.rdFollowUpD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"
    End Sub

    Sub ClearForm()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        ChPrintPreveiw.Checked = False
        Me.txtHN.Text = ""
        Me.txtPatient.Text = ""

        Me.lblID.Text = 0
        Me.dtpDateIn.Checked = False

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtFollowUp.Enabled = False
        Me.txtFollowUp.Text = "0"
        Me.rdFollowUpR.Checked = False
        Me.rdFollowUpD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"

        'Me.cmdPrint.Enabled = False
        Me.cmdSave.Text = "&Save"
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Call ClearForm()
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

    Private Sub txtReturnR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReturnR.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtReturnR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnR.TextChanged
        If Me.txtReturnR.Text < 0 Then
            Me.txtReturnR.ForeColor = Color.Red
        Else
            Me.txtReturnR.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtReturnD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReturnD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtReturnD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReturnD.TextChanged
        If Me.txtReturnD.Text < 0 Then
            Me.txtReturnD.ForeColor = Color.Red
        Else
            Me.txtReturnD.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAmountWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmountWord.TextChanged
        If Me.txtAmountWord.Text = "Error: that is too much for inputting this value." Then
            Me.txtAmountWord.ForeColor = Color.Red
        Else
            Me.txtAmountWord.ForeColor = Color.Black
        End If
    End Sub

    Private Function CheckSave() As Boolean
        If Me.chkSocialFee.Checked = False Then
            If Me.lblCashier.Text = "" Then
                MsgBox("Please check the cashier name.", MsgBoxStyle.Information, "Cashier Confirm")
                Return False
                'ElseIf dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                '    MsgBox("Receipt date can not smallere " & ModGlobleVariable.GeteDateServer, MsgBoxStyle.Critical, "Error")
                '    Return False
            ElseIf Me.txtReceiptNumber.Text = "" Then
                MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number confirm")
                Me.txtReceiptNumber.Focus()
                Return False
            ElseIf Me.txtHN.Text = "" Then
                MsgBox("Please enter HN number.", MsgBoxStyle.Information, "HN confirm")
                Me.txtHN.Focus()
                Return False
            ElseIf Me.dtpDateIn.Checked = False Then
                MsgBox("Please select date to save.", MsgBoxStyle.Information, "Date confirm")
                Me.dtpDateIn.Focus()
                Return False
            ElseIf Me.txtRate.Text = "" Then
                MsgBox("Please check the rate. This operation cannot work without rate.", MsgBoxStyle.Information, "Rate confirm")
                Me.txtRate.Focus()
                Return False
            ElseIf Me.txtPatient.Text = "" Then
                MsgBox("Please enter the patient name.", MsgBoxStyle.Information, "Patient confirm")
                Me.txtPatient.Focus()
                Return False
            ElseIf Me.rdFollowUpR.Checked = False And Me.rdFollowUpD.Checked = False Then
                MsgBox("Please enter the amount of follow up or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdFollowUpR.Focus()
                Return False
            ElseIf Me.rdFollowUpR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter follow up fee in Riel.", MsgBoxStyle.Information, "Follow up fee Riel confirm")
                Me.txtFollowUp.Focus()
                Return False
            ElseIf Me.rdFollowUpD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter follow up fee in Dollar.", MsgBoxStyle.Information, "Follow up fee Dollar confirm")
                Me.txtFollowUp.Focus()
                Return False
            ElseIf Me.txtAmountWord.Text = "" Then
                MsgBox("Please enter the amount payment in word.", MsgBoxStyle.Information, "Amount payment word confirm")
                Me.txtAmountWord.Focus()
                Return False
            ElseIf AccRolesCashier = True Then
                If Me.chkRiel.Checked = False And Me.chkDollar.Checked = False Then
                    MsgBox("Please enter any amount in figure Riel or Dollar.", MsgBoxStyle.Information, "Amount figure Riel or Dollar confirm")
                    Me.chkRiel.Checked = True
                    Return False
                ElseIf Me.chkRiel.Checked = True And Me.chkDollar.Checked = True And Me.txtAmountFigureR.Text = "0" And Me.txtAmountFigureD.Text = "0" Then
                    MsgBox("Please enter amount figure Riel or Dollar.", MsgBoxStyle.Information, "Amount figure Riel or Dollar confirm")
                    Me.txtAmountFigureR.Focus()
                    Return False
                ElseIf Me.chkRiel.Checked = True And Me.txtAmountFigureR.Text = "0" Then
                    MsgBox("Please enter the amount of figure in Riel.", MsgBoxStyle.Information, "Amount figure Riel confirm")
                    Me.txtAmountFigureR.Focus()
                    Return False
                ElseIf Me.chkDollar.Checked = True And Me.txtAmountFigureD.Text = "0" Then
                    MsgBox("Please enter the amount of figure in Dollar.", MsgBoxStyle.Information, "Amount figure Dollar confirm")
                    Me.txtAmountFigureD.Focus()
                    Return False
                End If
            End If
            Return True
        End If
        Return True
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        
        If Me.lblID.Text = 0 Then
            If ModOld_Outpatient.CheckDuplicatePatientOneDay(EmptyString(txtHN.Text), dtpDateIn.Value) > 0 Then
                MessageBox.Show("Can not registration patient for Old patient book on the same day. Could you check old patient book agian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If LblConsultType.Text = "Nil" Then
                MessageBox.Show("Can not save becouase is nil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckSave() = False Then
                Exit Sub
            End If
            '============= Check Referal from ==========================
            'If CheckStatusReferal() = False Then
            '    MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    GrpReferal.BackColor = Color.Khaki
            '    Exit Sub
            'Else
            '    GrpReferal.BackColor = Color.Transparent
            'End If
            If GetTextReferralV1() = "" Then
                ChListReferral.BackColor = Color.Aqua
                MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                ChListReferral.BackColor = Color.White
            End If

            Dim DialogBox As DialogResult = MessageBox.Show("Do you really want to save these information?", "Save confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                    MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
                    Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    Exit Sub
                End If

                If SaveOldOutpatientReceiptProcess() = True Then
                    ModRegistration.UpdatePatientLastReferal(txtHN.Text, GetTextReferralV1)
                    Me.lblID.Text = 0
                    'Me.cmdPrint.Enabled = True
                    AccRolesCashier = True
                    isTrueFalse = False
                    isCloseOld = True
                    BgPrinter.RunWorkerAsync()
                    If LblConsultID.Text = "0" Then
                    Else
                        DS_Consult.UpdateStatus(1, LblConsultID.Text)
                    End If

                End If
            End If
        Else
            If CheckSave() = False Then
                Exit Sub
            End If
            'Check Referal from
            'If CheckStatusReferal() = False Then
            '    MessageBox.Show("Please check referal from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    GrpReferal.BackColor = Color.Khaki
            '    Exit Sub
            'Else
            '    GrpReferal.BackColor = Color.Transparent
            'End If
            If MessageBox.Show("Do you really want to update these information?" & Chr(13) & "Please make sure that you enter the right information before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Call MOldOutpatientReceipt.UpdateOldOutpatientReceipt(Me.lblID.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf((Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                IIf((Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True, "1", "0"), IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                IIf(Me.chkSocialFee.Checked = False, 1, 0), "OR", Me.lblCashierLogin.Text, 1, Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"))
                If Me.lblHistoryNo.Text > 0 Then
                    Call MOldOutpatientReceipt.UpdateReferalOutpatient(Me.lblHistoryNo.Text, Me.ChHearing.Checked, Me.ChUnderstand.Checked, Me.ChSeeing.Checked, _
                    Me.ChPhysical.Checked, Me.ChCDMDP.Checked, Me.ChEyeScreenig.Checked, Me.ChScreeningKV.Checked, Me.ChSelf.Checked, _
                    Me.ChPatient.Checked, Me.ChFriend.Checked, Me.ChOtherNGO.Checked, Me.ChChurch.Checked, Me.ChHealth.Checked, Me.ChOtherReferal.Checked)
                End If
                MsgBox("Update old-out patient receipt successfully", MsgBoxStyle.OkOnly, "Update Old-Out Patient")
            End If
        End If
    End Sub

    Function SaveOldOutpatientReceiptProcess() As Boolean         '--------------Question = Do check or count referal for every followup patient ?-------------------------
        '---------------Renew Receipt ID First time before saving----------------------------------------------------------
        cmdSave.Enabled = False
        cmdClose.Enabled = False
        ' Me.cmdPrint.Enabled = False
        PictLoading.Visible = True
        Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
        Dim Transaction As SqlClient.SqlTransaction = Nothing
        Transaction = Con.BeginTransaction
        sqlComm.Transaction = Transaction
        Try
            '-----------------------Save to tblPatientReceipt -----------------------------------------------------
            sqlComm.CommandText = SqlSaveOldOutpatientReceipt()
            sqlComm.ExecuteNonQuery()
            ' =========== Save Old patient book     ==================

            sqlComm.CommandText = DoSaveOldPatientBook()
            sqlComm.ExecuteNonQuery()
            'Save Old patient referal
            sqlComm.CommandText = SqlSaveOrUpdateRegistrationFormForReferal()
            sqlComm.ExecuteNonQuery()

            'Check condition for old patient Mo-po-Ch
            If ChMoPoCho.Checked = True Then
                sqlComm.CommandText = SavePatientMoPoTyso(txtHN.Text, FormatDateTime(dtpDateIn.Value, DateFormat.ShortDate))
                sqlComm.ExecuteNonQuery()
            End If
            Transaction.Commit()
            Transaction.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Transaction.Rollback()
            Return False
        Finally
            Con.Close()
            Con.Dispose()
        End Try
    End Function
    Function DoSaveOldPatientBook() As String
        Dim Riel As Integer
        Dim Dolar As Integer
        If rdFollowUpR.Checked = True Then
            Riel = EmptyString(txtFollowUp.Text)
            Dolar = 0
        End If
        If rdFollowUpD.Checked = True Then
            Dolar = EmptyString(txtFollowUp.Text)
            Riel = 0
        End If
        Return SQLSaveOldPatientBook(txtReceiptNumber.Text, txtHN.Text, "", "", Riel, Dolar, False, False, False, False, False, False, "", dtpDateIn.Value, False, GetTextReferralV1())
    End Function
    Function SQLSaveOldPatientBook( _
    ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal PatientFee As String, _
    ByVal PatientDolar As String, _
    ByVal Prescribed As Boolean, _
    ByVal Dispensed As Boolean, _
    ByVal Hearing As Boolean, _
    ByVal Understand As Boolean, _
    ByVal Seeing As Boolean, _
    ByVal Physical As Boolean, _
    ByVal Other As String, _
    ByVal CreateDate As String, _
    ByVal TypeDiagnosis As Boolean, ByVal ConbindReferal As String) As String
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient " & _
               "(ReceiptNo," & _
               "PatientNo," & _
               "Diagnosis," & _
               "DiagnosisTem," & _
               "PatientFee," & _
               "PatientDolar," & _
               "Prescribed," & _
               "Dispensed," & _
               "Hearing," & _
               "Understand," & _
               "Seeing," & _
               "Physical," & _
               "Other," & _
               "CreateDate," & _
               "Status," & _
               "TypeDiagnosis," & _
               "ComBindRefferal) " & _
               " VALUES(" & _
               ReceiptNo & "," & _
               PatientNo & ",'" & _
               Diagnosis & "','" & _
               DiagnosisTem & "'," & _
               PatientFee & "," & _
               PatientDolar & ",'" & _
               Prescribed & "','" & _
               Dispensed & "','" & _
               Hearing & "','" & _
               Seeing & "','" & _
               Understand & "','" & _
               Physical & "','" & _
               Other & "','" & _
               CreateDate & _
               "','True','" & _
               TypeDiagnosis & "','" & ConbindReferal & "')"
        Return sql
    End Function

    Function SavePatientMoPoTyso(ByVal PatientNo As Double, ByVal DateFolowup As Date) As String
        Dim sql As String = "INSERT INTO TblMopoTyso (PatientNo,CreateDate) VALUES(" & PatientNo & ",'" & DateFolowup & "')"
        Return sql
    End Function

    Function CheckStatusReferal() As Boolean

        For Each obj As Object In GrpReferal.Controls
            If TypeOf obj Is CheckBox Then
                Dim rd As CheckBox = CType(obj, CheckBox)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If

        Next
    End Function
    Function GetTextReferralV1() As String
        Try
            Dim str As String = ""
            For i As Int16 = 0 To ChListReferral.Items.Count - 1
                If ChListReferral.GetItemChecked(i) = True Then
                    str = str & " + " & ChListReferral.Items(i).ToString
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    'Function ValidSaveFollowUp() As Boolean
    '    If Me.ChHearing.Checked = False And Me.ChUnderstand.Checked = False And Me.ChSeeing.Checked = False And Me.ChPhysical.Checked = False And Me.ChCDMDP.Checked = False _
    '       And Me.ChEyeScreenig.Checked = False And Me.ChScreeningKV.Checked = False And Me.ChSelf.Checked = False And Me.ChPatient.Checked = False And Me.ChFriend.Checked = False _
    '       And Me.ChOtherNGO.Checked = False And Me.ChChurch.Checked = False And Me.ChHealth.Checked = False And Me.ChOtherReferal.Checked = False Then
    '        Return False
    '    End If
    '    Return True
    'End Function

    Function SqlSaveOldOutpatientReceipt() As String
        Return Me.SaveOldOutpatientReceipt(Me.txtReceiptNumber.Text, _
                        Me.txtHN.Text, _
                        Me.txtPatient.Text, _
                        Me.txtAmountFigureR.Text, _
                        Me.txtAmountFigureD.Text, _
                        IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        IIf(Me.rdFollowUpR.Checked = True, Me.txtTotal.Text, 0), _
                        IIf(Me.rdFollowUpD.Checked = True, Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                        IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                        Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True, "1", "0"), _
                        IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                        IIf(Me.chkSocialFee.Checked = False, 1, 0), "OR", Me.lblCashier.Text, "", 1, _
                        Me.dtpDateIn.Value, ModGlobleVariable.GeteDateServer.Year)
    End Function

    Function SaveOldOutpatientReceipt( _
       ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
       ByVal CashRiel As Double, ByVal CashUSD As Double, _
       ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
       ByVal FollowUpFeeRiel As Double, ByVal FollowUpFeeUSD As Double, _
       ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
       ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, _
       ByVal AmountWord As String, ByVal ConFOL As String, ByVal ConSocialFee As String, _
       ByVal ConFullFee As String, ByVal ConGeneral As String, _
       ByVal CashierIn As String, ByVal CashierUpdate As String, _
       ByVal PrintCount As Integer, ByVal DateIn As Date, ByVal Years As Integer) As String
        'Try
        '-----tblPatientReceipt--------------------------------------------
        Dim sql As String = " INSERT INTO tblPatientReceipt " _
                & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                & " FollowUpFeeRiel, FollowUpFeeUSD, SocialFeeRiel," _
                & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConFOL, ConSocialFee, ConFullFee," _
                & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, Years)" _
                & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                & FollowUpFeeRiel & "," & FollowUpFeeUSD & "," _
                & SocialFeeRiel & "," & SocialFeeUSD & "," _
                & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                & AmountWord & "','" & ConFOL & "','" & ConSocialFee & "','" & ConFullFee & "','" & ConGeneral & "','" _
                & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn & "'," & Years & ")"
        Return sql
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.OkCancel)
        'End Try
    End Function
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

    Function SqlSaveOrUpdateRegistrationFormForReferal() As String
        Return Me.StringSaveReferal( _
               txtHN.Text, _
               dtpDateIn.Value, _
               ChHearing.Checked, _
               ChUnderstand.Checked, _
               ChSeeing.Checked, _
               ChPhysical.Checked, _
               ChCDMDP.Checked, _
               ChEyeScreenig.Checked, _
               ChScreeningKV.Checked, _
               ChSelf.Checked, _
               ChPatient.Checked, _
               ChFriend.Checked, _
               ChOtherNGO.Checked, _
               ChChurch.Checked, _
               ChHealth.Checked, _
               ChOtherReferal.Checked, _
               ChPreyKabasVC.Checked, _
               ChPreyScreening.Checked, _
               ChSchoolScreening.Checked, _
               ChMoPoCho.Checked, _
               GetTextReferralV1())
    End Function
   
    Function UpdatePatientHistory(ByVal PatientNo As String, _
                                ByVal Hearing As Boolean, _
                                ByVal Understand As Boolean, _
                                ByVal Seeing As Boolean, _
                                ByVal Physical As Boolean, _
                                ByVal CDMDPatient As Boolean, _
                                ByVal ScreeningKV As Boolean, _
                                ByVal EyeSreening As Boolean, _
                                ByVal Self As Boolean, _
                                ByVal PatientReferal As Boolean, _
                                ByVal Friend_Relation As Boolean, _
                                ByVal OtherNGO As Boolean, _
                                ByVal Church As Boolean, _
                                ByVal HealthWorker As Boolean, _
                                ByVal OtherReferal As Boolean, _
                                ByVal PreyKabasVC As Boolean, _
                                ByVal PreyScreening As Boolean, _
                                ByVal SchoolScreening As Boolean, _
                                ByVal MoPoCho As Boolean, _
                                ByVal ComBindRefferal As String) As String
        Dim sql As String = "UPDATE TblFollowUp SET " & _
                            " Hearing = '" & Hearing & _
                            "' ,Understand =  '" & Understand & _
                            "' ,Seeing =  '" & Seeing & _
                            "' ,Physical =  '" & Physical & _
                            "' ,CDMDPatient =  '" & CDMDPatient & _
                            "' ,ScreeningKV = '" & ScreeningKV & _
                            "' ,EyeSreening =  '" & EyeSreening & _
                            "' ,Self =  '" & Self & _
                            "' ,PatientReferal  ='" & PatientReferal & _
                            "' ,Friend_Relation =  '" & Friend_Relation & _
                            "' ,OtherNGO =  '" & OtherNGO & _
                            "' ,Church =  '" & Church & _
                            "' ,HealthWorker =  '" & HealthWorker & _
                            "' ,OtherReferal =  '" & OtherReferal & _
                            "' ,PreyKabasVC='" & PreyKabasVC & _
                            "' ,PreyScreening='" & PreyScreening & _
                            "' ,SchoolScreening='" & SchoolScreening & _
                            "' ,MoPoCho='" & MoPoCho & _
                            "' ,ComBindRefferal='" & ComBindRefferal & _
                            "' WHERE PatientNo=" & PatientNo
        Return sql
    End Function
    Function StringSaveReferal( _
                   ByVal PatientNo As String _
                  , ByVal CreateDate As String _
                  , ByVal Hearing As Boolean _
                  , ByVal Understand As Boolean _
                  , ByVal Seeing As Boolean _
                  , ByVal Physical As Boolean _
                  , ByVal CDMDPatient As Boolean _
                  , ByVal EyeScreeningTK As Boolean _
                  , ByVal ScreeningKV As Boolean _
                  , ByVal Self As Boolean _
                  , ByVal PatientReferal As Boolean _
                  , ByVal Friend_Relation As Boolean _
                  , ByVal OtherNGO As Boolean _
                  , ByVal Church As Boolean _
                  , ByVal HealthWorker As Boolean _
                  , ByVal OtherReferal As Boolean _
                  , ByVal PreyKabasVC As Boolean _
                  , ByVal PreyScreening As Boolean _
                  , ByVal SchoolScreening As Boolean _
                  , ByVal MoPoCho As Boolean _
                  , ByVal CombinRefferal As String) As String
        Dim sql As String = "INSERT INTO TblFollowUp " & _
                    "(PatientNo" & _
                    ",CreateDate" & _
                    ",Hearing" & _
                    ",Understand" & _
                    ",Seeing" & _
                    ",Physical" & _
                    ",CDMDPatient" & _
                    ",EyeSreening" & _
                    ",ScreeningKV" & _
                    ",Self" & _
                    ",PatientReferal" & _
                    ",Friend_Relation" & _
                    ",OtherNGO" & _
                    ",Church" & _
                    ",HealthWorker" & _
                    ",OtherReferal,PreyKabasVC,PreyScreening,SchoolScreening,MoPoCho,ComBindRefferal,FollowUpStatus)" & _
                    " VALUES " & _
                    "(" & PatientNo & _
                    ",'" & CreateDate & _
                    "','" & Hearing & _
                    "','" & Understand & _
                    "','" & Seeing & _
                    "','" & Physical & _
                    "','" & CDMDPatient & _
                    "','" & EyeScreeningTK & _
                    "','" & ScreeningKV & _
                    "','" & Self & _
                    "','" & PatientReferal & _
                    "','" & Friend_Relation & _
                    "','" & OtherNGO & _
                    "','" & Church & _
                    "','" & HealthWorker & _
                    "','" & OtherReferal & _
                    "','" & PreyKabasVC & _
                    "','" & PreyScreening & _
                    "','" & SchoolScreening & _
                    "','" & MoPoCho & _
                    "','" & CombinRefferal & _
                    "',1)"
        Return sql
    End Function

    Function StringSavePatientRegistration( _
               ByVal PatientNo As String _
              , ByVal CreateDate As String _
              , ByVal Hearing As Boolean _
              , ByVal Understand As Boolean _
              , ByVal Seeing As Boolean _
              , ByVal Physical As Boolean _
              , ByVal CDMDPatient As Boolean _
              , ByVal EyeScreeningTK As Boolean _
              , ByVal ScreeningKV As Boolean _
              , ByVal Self As Boolean _
              , ByVal PatientReferal As Boolean _
              , ByVal Friend_Relation As Boolean _
              , ByVal OtherNGO As Boolean _
              , ByVal Church As Boolean _
              , ByVal HealthWorker As Boolean _
              , ByVal OtherReferal As Boolean _
              , ByVal PreyKabasVC As Boolean, _
              ByVal PreyScreening As Boolean, _
              ByVal SchoolScreening As Boolean, _
              ByVal MoPoCho As Boolean, _
              ByVal ComBindRefferal As String) As String
        Dim sql As String = "INSERT INTO TblFollowUp " & _
                    "(PatientNo" & _
                    ",CreateDate" & _
                    ",Hearing" & _
                    ",Understand" & _
                    ",Seeing" & _
                    ",Physical" & _
                    ",CDMDPatient" & _
                    ",EyeSreening" & _
                    ",ScreeningKV" & _
                    ",Self" & _
                    ",PatientReferal" & _
                    ",Friend_Relation" & _
                    ",OtherNGO" & _
                    ",Church" & _
                    ",HealthWorker" & _
                    ",OtherReferal,PreyKabasVC,PreyScreening,SchoolScreening,MoPoCho,ComBindRefferal, FollowUpStatus)" & _
                    " VALUES " & _
                    "(" & PatientNo & _
                    ",'" & CreateDate & _
                    "','" & Hearing & _
                    "','" & Understand & _
                    "','" & Seeing & _
                    "','" & Physical & _
                    "','" & CDMDPatient & _
                    "','" & EyeScreeningTK & _
                    "','" & ScreeningKV & _
                    "','" & Self & _
                    "','" & PatientReferal & _
                    "','" & Friend_Relation & _
                    "','" & OtherNGO & _
                    "','" & Church & _
                    "','" & HealthWorker & _
                    "','" & OtherReferal & _
                    "','" & PreyKabasVC & _
                    "','" & PreyScreening & _
                    "','" & SchoolScreening & _
                    "','" & MoPoCho & _
                    "','" & ComBindRefferal & _
                    "',1)"
        Return sql
    End Function

    Private Sub txtHN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtHN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHN.TextChanged

    End Sub

    Private Sub txtReceiptNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiptNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
        If Asc(e.KeyChar) = Keys.Enter Then
            Call Me.cmdSearch_Click(sender, e)
        End If
    End Sub

    Private Sub txtReceiptNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNumber.TextChanged

    End Sub

    Private Sub SearchOldOPReceipt()
        If Me.lblID.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number cannot be blank.")
            Me.lblID.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MOldOutpatientReceipt.SelectOldOutReceipt(Me.lblID.Text).Rows.Count > 0 Then
            With MOldOutpatientReceipt.SelectOldOutReceipt(Me.lblID.Text).Rows(0)

                Me.lblID.Text = .Item(14)
                Me.lblCashier.Text = .Item(8)
                Me.txtReceiptNumber.Text = .Item(2)
                Me.txtHN.Text = .Item(0)
                Me.dtpDateIn.Text = .Item(7)
                Me.dtpDateIn.Checked = True
                Me.txtPatient.Text = .Item(1)
                Me.txtAmountWord.Text = .Item(9)
                Me.chkDollar.Checked = False
                Me.chkRiel.Checked = False
                If .Item(3) > 0 Then
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(3)
                End If
                If .Item(4) > 0 Then
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(4)
                End If
                If .Item(5) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpD.Checked = True
                    Me.chkDollar.Checked = True
                    Me.txtFollowUp.Text = .Item(5)
                    txtAmountFigureD.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpR.Checked = True
                    Me.chkRiel.Checked = True
                    Me.txtFollowUp.Text = .Item(6)
                    txtAmountFigureR.Text = .Item(6)
                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            'Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for old out-patient receipt.", MsgBoxStyle.Information, "Old Out-patient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchOldOPReceiptByID()
        If Me.txtReceiptNumber.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number")
            Me.lblID.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MOldOutpatientReceipt.SelectOldOutReceiptByID(Me.txtReceiptNumber.Text).Rows.Count > 0 Then
            With MOldOutpatientReceipt.SelectOldOutReceiptByID(Me.txtReceiptNumber.Text).Rows(0)
                Me.lblID.Text = .Item(14)
                Me.lblCashier.Text = .Item(8)
                Me.txtReceiptNumber.Text = .Item(2)
                Me.txtHN.Text = .Item(0)
                Me.dtpDateIn.Text = .Item(7)
                Me.dtpDateIn.Checked = True
                Me.txtPatient.Text = .Item(1)
                Me.txtAmountWord.Text = .Item(9)
                Me.chkDollar.Checked = False
                Me.chkRiel.Checked = False
                If .Item(3) > 0 Then
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(3)
                End If
                If .Item(4) > 0 Then
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(4)
                End If
                If .Item(5) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpD.Checked = True
                    Me.txtFollowUp.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpR.Checked = True
                    Me.txtFollowUp.Text = .Item(6)

                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            If MOldOutpatientReceipt.SearchReferal(Me.txtHN.Text, Me.dtpDateIn.Value).Rows.Count > 0 Then
                With MOldOutpatientReceipt.SearchReferal(Me.txtHN.Text, Me.dtpDateIn.Value).Rows(0)
                    Me.lblHistoryNo.Text = .Item(0)
                    Me.ChHearing.Checked = .Item(1)
                    Me.ChUnderstand.Checked = .Item(2)
                    Me.ChSeeing.Checked = .Item(3)
                    Me.ChPhysical.Checked = .Item(4)

                    Me.ChCDMDP.Checked = .Item(5)
                    Me.ChEyeScreenig.Checked = .Item(6)
                    Me.ChScreeningKV.Checked = .Item(7)
                    Me.ChSelf.Checked = .Item(8)
                    Me.ChPatient.Checked = .Item(9)
                    Me.ChFriend.Checked = .Item(10)
                    Me.ChOtherNGO.Checked = .Item(11)
                    Me.ChChurch.Checked = .Item(12)
                    Me.ChHealth.Checked = .Item(13)
                    Me.ChOtherReferal.Checked = .Item(14)
                End With
            End If
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            'Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for old out-patient receipt.", MsgBoxStyle.Information, "Old Out-patient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchOldOPReceiptByHN()
        If Me.txtHN.Text = "" Then
            MsgBox("Please enter the HN.", MsgBoxStyle.Information, "HN cannot be blank.")
            Me.txtHN.Focus()
            Exit Sub
        End If
        If MOldOutpatientReceipt.SelectOldOutReceiptByHN(Me.txtHN.Text).Rows.Count > 0 Then
            With MOldOutpatientReceipt.SelectOldOutReceiptByHN(Me.txtHN.Text).Rows(0)
                Me.lblCashier.Text = .Item(8)
                Me.txtReceiptNumber.Text = .Item(2)
                Me.txtHN.Text = .Item(0)
                Me.dtpDateIn.Text = .Item(7)
                Me.txtPatient.Text = .Item(1)
                Me.txtAmountWord.Text = .Item(9)
                Me.chkDollar.Checked = False
                Me.chkRiel.Checked = False
                If .Item(3) > 0 Then
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(3)
                End If
                If .Item(4) > 0 Then
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(4)
                End If
                If .Item(5) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpD.Checked = True
                    Me.txtFollowUp.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdFollowUpR.Checked = True
                    Me.txtFollowUp.Text = .Item(6)

                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            ' Me.cmdPrint.Enabled = True
        Else
            MsgBox("This HN is not valid for old out-patient receipt.", MsgBoxStyle.Information, "Old Out-patient HN")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchReceipt.Click
        Call SearchOldOPReceiptByID()
    End Sub
    Dim Preview As Boolean = False
    Dim ReportOOPR As New ReportOldOutPatientReceipt
    Dim frmReportOOPR As New frmReportOldOutPatientReceipt
    Private Sub PrintReportOOPR()
        Try
            '-------------Report Form Active--------------------------------
            ReportOOPR.SetDataSource(MOldOutpatientReceipt.ReportOldOutpatientReceipt(Me.txtReceiptNumber.Text).Tables(1))
            If Preview = True Then
                frmReportOOPR.crvReportOldOutPatientReceipt.ReportSource = ReportOOPR
                ReportOOPR.Refresh()
                frmReportOOPR.ShowDialog()
                frmReportOOPR.Dispose()
                frmReportOOPR.Close()
            Else
                Try
                    printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                    ReportOOPR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                    ReportOOPR.PrintToPrinter(1, True, 1, 1)
                    ReportOOPR.Dispose()
                    ReportOOPR.Close()
                Catch ex As Exception
                    MsgBox("Can't find printer." & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call PrintReportOOPR()
    End Sub

    Private Sub cmdAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRate.Click
        Dim frmRates As New frmRates
        frmRates.ShowDialog()
        Call GetRates()
    End Sub

    Private Sub cmdCashierSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashierSave.Click
        If CheckSave() = False Then
            Exit Sub
        End If
        Dim DialogBox As DialogResult
        DialogBox = MessageBox.Show("Do you really want to update these information?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If DialogBox = Windows.Forms.DialogResult.Yes Then
            Call MOldOutpatientReceipt.UpdateOldOutpatientReceiptCashier(Me.lblID.Text, Me.txtAmountFigureR.Text, Me.txtAmountFigureD.Text, _
            IIf((Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
            IIf((Me.rdFollowUpR.Checked = True Or Me.rdFollowUpD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
            Me.txtRate.Text, Me.txtAmountWord.Text, dtpDateIn.Value, Me.lblCashierLogin.Text, Format(Date.Now(), "MM/dd/yyyy"), "1")
            AccRolesCashier = True
            isTrueFalse = False
            Me.Close()
        End If
    End Sub

    Private Sub chkSocialFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSocialFee.CheckedChanged
        If Me.chkSocialFee.Checked = True Then
            Me.txtFollowUp.Text = 0
        End If
    End Sub

    Private Sub cmdFindHN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindHN.Click
        Call SearchOldOPReceiptByHN()
    End Sub

    Private Sub BgPrinter_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPrinter.DoWork
        'Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        Call PrintReportOOPR()
    End Sub

    Private Sub ChPrintPreveiw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPrintPreveiw.CheckedChanged
        Preview = ChPrintPreveiw.Checked
    End Sub

    Private Sub BgPrinter_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPrinter.RunWorkerCompleted
        cmdSave.Enabled = False
        cmdClose.Enabled = False
        ' Me.cmdPrint.Enabled = False
        PictLoading.Visible = True
        ' MsgBox("Save old out patient receipt successfully", MsgBoxStyle.Information, "Old-Out Patient")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class