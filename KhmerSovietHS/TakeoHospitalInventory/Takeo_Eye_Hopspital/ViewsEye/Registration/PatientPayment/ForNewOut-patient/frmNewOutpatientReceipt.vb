Imports System.Math

Public Class frmNewOutpatientReceipt
    Public isCloseReceipt As Boolean = False
    Dim frmReportNOPR As frmReportNewOutPatientReceipt
    Dim ReportNOPR As ReportNewOutPatientReceipt
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        frmReportNOPR = New frmReportNewOutPatientReceipt
        ReportNOPR = New ReportNewOutPatientReceipt
        dtpDateIn.Value = ModGlobleVariable.GeteDateServer
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        AccRolesCashier = True
        isTrueFalse = False
        isCloseReceipt = False
        Me.Close()
    End Sub

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

    Private Sub txtConsultation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConsultation.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConsultation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConsultation.LostFocus
        If Me.txtConsultation.Text.Trim = "" Then
            Me.txtConsultation.Text = "0"
        End If
    End Sub

    Private Sub txConsultation_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtConsultation.MouseClick
        Me.txtConsultation.SelectAll()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtConsultation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsultation.TextChanged
        If Me.txtConsultation.Text.Trim > "0" Then
            Me.txtTotal.Text = Me.txtConsultation.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub rdConsultationR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdConsultationR.CheckedChanged
        If Me.rdConsultationR.Checked = True Then
            Me.txtConsultation.Enabled = True
            Me.txtConsultation.Text = ""
            Me.txtConsultation.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtConsultation.Text = "0"
            Me.txtConsultation.Enabled = False
        End If
    End Sub

    Private Sub rdConsultationD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdConsultationD.CheckedChanged
        If Me.rdConsultationD.Checked = True Then
            Me.txtConsultation.Enabled = True
            Me.txtConsultation.Text = ""
            Me.txtConsultation.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtConsultation.Text = "0"
            Me.txtConsultation.Enabled = False
        End If
    End Sub

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                'If MRates.GetRateChange Is Nothing Then
                '    Exit Sub
                'End If
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
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
        Else
            Call SearchNewOPR()
        End If
        Me.lblFees.Text = ""
        ' Me.cmdPrint.Enabled = False
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    Me.cmdCashierSave.Visible = True
                    Me.cmdSave.Enabled = False
                    'Me.cmdPrint.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    'Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    Me.cmdCashierSave.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    'Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    Me.cmdCashierSave.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.cmdCashierSave.Visible = True
                    Me.cmdSave.Enabled = True
                    ' Me.cmdPrint.Enabled = True
                End If
            End With
        Next
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

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtConsultation.Enabled = False
        Me.txtConsultation.Text = "0"
        Me.rdConsultationR.Checked = False
        Me.rdConsultationD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"
    End Sub

    Sub ClearForm()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()

        Me.lblReceiptToPrintID.Text = ""    '------------for printing receipt-------------

        Me.lblID.Text = 0
        Me.dtpDateIn.Checked = False

        Me.txtHN.Text = ""
        Me.txtPatient.Text = ""

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtConsultation.Enabled = False
        Me.txtConsultation.Text = "0"
        Me.rdConsultationR.Checked = False
        Me.rdConsultationD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"

        Me.cmdSave.Text = "&Save"
        'Me.cmdPrint.Enabled = False
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
            'If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
            '    MsgBox("Receipt date can not < " & ModGlobleVariable.GeteDateServer.DayOfYear, MsgBoxStyle.Critical, "Error")
            '    Return False
            If Me.lblCashier.Text = "" Then
                MsgBox("Please check the cashier name.", MsgBoxStyle.Information, "Cashier Confirm")
                Return False
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
            ElseIf Me.rdConsultationR.Checked = False And Me.rdConsultationD.Checked = False Then
                MsgBox("Please enter the amount of consultation or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdConsultationR.Focus()
                Return False
            ElseIf Me.rdConsultationR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter consultation fee in Riel.", MsgBoxStyle.Information, "Consultation fee Riel confirm")
                Me.txtConsultation.Focus()
                Return False
            ElseIf Me.rdConsultationD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter consultation fee in Dollar.", MsgBoxStyle.Information, "Consultation fee Dollar confirm")
                Me.txtConsultation.Focus()
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
        If CheckSave() = False Then
            Exit Sub
        End If
        If Me.lblID.Text = 0 Then
            Dim DialogBox As DialogResult = MessageBox.Show("Do you really want to save these information?", "Save confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                    MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
                    Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    Exit Sub
                End If
                'If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                '    MsgBox("Receipt date can not < " & ModGlobleVariable.GeteDateServer, MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                ' // Save New Patient Receipt
                If _
                MNewOutpatientReceipt.SaveNewOutpatientReceipt(Me.txtReceiptNumber.Text, _
                Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                Me.txtAmountFigureD.Text, _
                IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.rdConsultationR.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.rdConsultationD.Checked = True, Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                Me.txtRate.Text, Me.txtAmountWord.Text, _
                IIf(Me.rdConsultationR.Checked = True Or Me.rdConsultationD.Checked = True, "1", "0"), _
                IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                IIf(Me.chkSocialFee.Checked = False, 1, 0), _
                "NR", Me.lblCashier.Text, "", 1, Me.dtpDateIn.Value, _
                Format(Date.Now(), "MM/dd/yyyy"), Me.dtpDateIn.Value.Year) = 1 _
                Then
                    MsgBox("Save New patient receipt successfully.", MsgBoxStyle.Information, "Save")
                    Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
                    Me.lblID.Text = 0
                    ' Me.cmdPrint.Enabled = True
                    AccRolesCashier = True
                    isTrueFalse = False
                    isCloseReceipt = True
                    'Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    Call PrintReportNOPR()
                    Me.Close()
                End If

            End If
        Else
            Dim DialogBox As DialogResult
            DialogBox = MessageBox.Show("Do you really want to update these information?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                Call MNewOutpatientReceipt.UpdateNewOutpatientReceipt(Me.lblID.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf((Me.rdConsultationR.Checked = True Or Me.rdConsultationD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                IIf((Me.rdConsultationD.Checked = True Or Me.rdConsultationR.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdConsultationR.Checked = True Or Me.rdConsultationD.Checked = True, "1", "0"), IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                IIf(Me.chkSocialFee.Checked = False, 1, 0), "NR", Me.lblCashierLogin.Text, 1, Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"))
                'Me.cmdPrint.Enabled = True
            End If
        End If
    End Sub

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
    End Sub

    Private Sub txtReceiptNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNumber.TextChanged

    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged

    End Sub

    Private Sub SearchNewOPR()
        If Me.lblID.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number cannot be blank.")
            Me.lblID.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MNewOutpatientReceipt.SelectNewOutReceipt(Me.lblID.Text).Rows.Count > 0 Then
            With MNewOutpatientReceipt.SelectNewOutReceipt(Me.lblID.Text).Rows(0)
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
                    Me.rdConsultationD.Checked = True
                    Me.txtConsultation.Text = .Item(5)
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(5)
                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdConsultationR.Checked = True
                    Me.txtConsultation.Text = .Item(6)
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(6)
                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            ' Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for new out-patient receipt.", MsgBoxStyle.Information, "New Out-patient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchNewOPRByID()
        If Me.txtReceiptNumber.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number cannot be blank.")
            Me.lblID.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MNewOutpatientReceipt.SelectNewOutReceiptByID(Me.txtReceiptNumber.Text).Rows.Count > 0 Then
            With MNewOutpatientReceipt.SelectNewOutReceiptByID(Me.txtReceiptNumber.Text).Rows(0)
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
                    Me.rdConsultationD.Checked = True
                    Me.txtConsultation.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdConsultationR.Checked = True
                    Me.txtConsultation.Text = .Item(6)

                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            'Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for new out-patient receipt.", MsgBoxStyle.Information, "New Out-patient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchNewOPRByHN()
        If Me.txtHN.Text = "" Then
            MsgBox("Please enter the HN.", MsgBoxStyle.Information, "HN cannot be blank.")
            Me.txtHN.Focus()
            Exit Sub
        End If
        If MNewOutpatientReceipt.SelectNewOutReceiptByHN(Me.txtHN.Text).Rows.Count > 0 Then
            With MNewOutpatientReceipt.SelectNewOutReceiptByHN(Me.txtHN.Text).Rows(0)
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
                    Me.rdConsultationD.Checked = True
                    Me.txtConsultation.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(12) = 1 Then
                    Me.rdConsultationR.Checked = True
                    Me.txtConsultation.Text = .Item(6)

                End If
                If .Item(13) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            'Me.cmdPrint.Enabled = True
        Else
            MsgBox("This HN is not valid for new out-patient receipt.", MsgBoxStyle.Information, "New Out-patient HN")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Call SearchNewOPRByID()
    End Sub

    Private Sub PrintReportNOPR()
        Try
            If Me.lblReceiptToPrintID.Text <> "" Then
                'Me.cmdPrint.Enabled = False
                ReportNOPR.SetDataSource(MNewOutpatientReceipt.ReportNewOutpatientReceipt(Me.lblReceiptToPrintID.Text).Tables(1))
                ReportNOPR.Refresh()
                If ChPrintPreveiw.Checked = True Then
                    frmReportNOPR.crvReportNewOutPatientReceipt.ReportSource = ReportNOPR
                    frmReportNOPR.ShowDialog()
                    frmReportNOPR.Dispose()
                    frmReportNOPR.Close()
                    ReportNOPR.Dispose()
                    ReportNOPR.Close()
                Else
                    printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                    ReportNOPR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                    ReportNOPR.PrintToPrinter(1, True, 1, 1)
                    ReportNOPR.Dispose()
                    ReportNOPR.Close()
                End If
                'Me.cmdPrint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call PrintReportNOPR()
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
        DialogBox = MessageBox.Show("Do you really want to update the amount in figure [Riel, US $]?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Cashier: Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        If DialogBox = Windows.Forms.DialogResult.Yes Then
            Call MNewOutpatientReceipt.UpdateNewOutpatientReceiptCashier(Me.lblID.Text, Me.txtAmountFigureR.Text, Me.txtAmountFigureD.Text, _
            IIf((Me.rdConsultationR.Checked = True Or Me.rdConsultationD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
            IIf((Me.rdConsultationD.Checked = True Or Me.rdConsultationR.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
            Me.txtRate.Text, Me.txtAmountWord.Text, dtpDateIn.Value, Me.lblCashierLogin.Text, Format(Date.Now(), "MM/dd/yyyy"), "1")
            AccRolesCashier = True
            isTrueFalse = False
            Me.Close()
        End If
    End Sub

    Private Sub chkSocialFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSocialFee.CheckedChanged
        If Me.chkSocialFee.Checked = True Then
            Me.txtConsultation.Text = 0
        End If
    End Sub

    Private Sub cmdFindHN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindHN.Click
        Call SearchNewOPRByHN()
    End Sub
End Class