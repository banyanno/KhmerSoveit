Imports System.Math

Public Class frmInpatientReceipt
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
                .Text = Nothing
            End With
        Catch ex As Exception
        End Try
        InitDonation()
        ' Add any initialization after the InitializeComponent() call.

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

    Private Sub txtOperationFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperationFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtOperationFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOperationFee.LostFocus
        If Me.txtOperationFee.Text.Trim = "" Then
            Me.txtOperationFee.Text = "0"
        End If
    End Sub

    Private Sub txtOperationFee_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOperationFee.MouseClick
        Me.txtOperationFee.SelectAll()
    End Sub

    Private Sub txtAritificialEyeFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAritificialEyeFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAritificialEyeFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAritificialEyeFee.LostFocus
        If Me.txtAritificialEyeFee.Text.Trim = "" Then
            Me.txtAritificialEyeFee.Text = "0"
        End If
    End Sub

    Private Sub txtAritificialEyeFee_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAritificialEyeFee.MouseClick
        Me.txtAritificialEyeFee.SelectAll()
    End Sub

    Private Sub txtOtherFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtherFee.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtOtherFee_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOtherFee.LostFocus
        If Me.txtOtherFee.Text.Trim = "" Then
            Me.txtOtherFee.Text = "0"
        End If
    End Sub

    Private Sub txtOtherFee_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtOtherFee.MouseClick
        Me.txtOtherFee.SelectAll()
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
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

    Private Sub rdOperationR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOperationR.CheckedChanged
        If Me.rdOperationR.Checked = True Then
            Me.txtOperationFee.Enabled = True
            Me.txtOperationFee.Text = ""
            Me.txtOperationFee.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtOperationFee.Text = "0"
            Me.txtOperationFee.Enabled = False
        End If
    End Sub

    Private Sub rdAritificialEyeR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdArtificialEyeR.CheckedChanged
        If Me.rdArtificialEyeR.Checked = True Then
            Me.txtAritificialEyeFee.Enabled = True
            Me.txtAritificialEyeFee.Text = ""
            Me.txtAritificialEyeFee.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "AEFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
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
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtOtherFee.Text = "0"
            Me.txtOtherFee.Enabled = False
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
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtOperationFee.Text = "0"
            Me.txtOperationFee.Enabled = False
        End If
    End Sub

    Private Sub rdAritificialEyeD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdArtificialEyeD.CheckedChanged
        If Me.rdArtificialEyeD.Checked = True Then
            Me.txtAritificialEyeFee.Enabled = True
            Me.txtAritificialEyeFee.Text = ""
            Me.txtAritificialEyeFee.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "AEFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtAritificialEyeFee.Text = "0"
            Me.txtAritificialEyeFee.Enabled = False
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
            Me.chkDollar.Checked = False
            Me.txtAmountFigureD.Text = "0"
            Me.chkRiel.Checked = False
            Me.txtAmountFigureR.Text = "0"
        Else
            Me.txtOtherFee.Text = "0"
            Me.txtOtherFee.Enabled = False
        End If
    End Sub

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub
    Sub InitDonation()
        With CboDonation
            .DataSource = ModDonation.GetDonation
            .ValueMember = "DonationID"
            .DisplayMember = "DonationName"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub frmInpatientReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblCashierLogin.Text = ""
        Me.dtpDateIn.Checked = False
        Me.lblCashierLogin.Text = USER_NAME
        Me.lblCashier.Text = USER_NAME
        Call GetRates()
        Me.lblFees.Text = ""
        If isTrueFalse = False Then
            Me.lblReceiptToPrintID.Text = ""
            Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        Else
            Call SearchReceiptPatient()
        End If
        'PrintReceiptAgain.Enabled = False
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    Me.UpdateReceipt1.Visible = True
                    Me.UpdateReceipt1.Enabled = False
                    ' Me.PrintReceiptAgain.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    'Me.PrintReceiptAgain.Enabled = True
                    Me.UpdateReceipt1.Enabled = True
                    Me.CashierSave1.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    ' Me.PrintReceiptAgain.Enabled = True
                    Me.UpdateReceipt1.Enabled = True
                    Me.CashierSave1.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.CashierSave1.Visible = True
                    UpdateReceipt1.Enabled = True
                    'Me.PrintReceiptAgain.Enabled = True
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

        Me.txtOperationFee.Enabled = False
        Me.txtOperationFee.Text = "0"
        Me.rdOperationR.Checked = False
        Me.rdOperationD.Checked = False

        Me.txtAritificialEyeFee.Enabled = False
        Me.txtAritificialEyeFee.Text = "0"
        Me.rdArtificialEyeR.Checked = False
        Me.rdArtificialEyeD.Checked = False

        Me.txtOtherFee.Enabled = False
        Me.txtOtherFee.Text = "0"
        Me.rdOtherD.Checked = False
        Me.rdOtherR.Checked = False

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

        Me.dtpDateIn.Value = Now()

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtOperationFee.Enabled = False
        Me.txtOperationFee.Text = "0"
        Me.rdOperationR.Checked = False
        Me.rdOperationD.Checked = False

        Me.txtAritificialEyeFee.Enabled = False
        Me.txtAritificialEyeFee.Text = "0"
        Me.rdArtificialEyeR.Checked = False
        Me.rdArtificialEyeD.Checked = False

        Me.txtOtherFee.Enabled = False
        Me.txtOtherFee.Text = "0"
        Me.rdOtherD.Checked = False
        Me.rdOtherR.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"

        UpdateReceipt1.Text = "&Save"
        'PrintReceiptAgain.Enabled = False
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
        If Me.txtReturnR.Text <> "" Then
            If Me.txtReturnR.Text.Trim.Substring(0, 1) = "-" Then
                Me.txtReturnR.ForeColor = Color.Red
            Else
                Me.txtReturnR.ForeColor = Color.Black
            End If
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
        If Me.txtReturnD.Text <> "" Then
            If Me.txtReturnD.Text.Trim.Substring(0, 1) = "-" Then
                Me.txtReturnD.ForeColor = Color.Red
            Else
                Me.txtReturnD.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Function CheckSave() As Boolean
        If Me.chkSocialFee.Checked = False Then
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
            ElseIf Me.rdOperationR.Checked = False And Me.rdOperationD.Checked = False And Me.rdArtificialEyeR.Checked = False And Me.rdArtificialEyeD.Checked = False And Me.rdOtherR.Checked = False And Me.rdOtherD.Checked = False Then
                MsgBox("Please enter the amount of operation or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdOperationR.Focus()
                Return False
            ElseIf Me.rdOperationR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter operation fee in Riel.", MsgBoxStyle.Information, "Operation fee Riel confirm")
                Me.txtOperationFee.Focus()
                Return False
            ElseIf Me.rdOperationD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter operation fee in Dollar.", MsgBoxStyle.Information, "Operation fee Dollar confirm")
                Me.txtOperationFee.Focus()
                Return False
            ElseIf Me.rdArtificialEyeR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter artificial fee in Riel.", MsgBoxStyle.Information, "Artificial fee Riel confirm")
                Me.txtAritificialEyeFee.Focus()
                Return False
            ElseIf Me.rdArtificialEyeD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter artificial fee in Dollar.", MsgBoxStyle.Information, "Artificial fee Dollar confirm")
                Me.txtAritificialEyeFee.Focus()
                Return False
            ElseIf Me.rdOtherR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter other fee in Riel.", MsgBoxStyle.Information, "Other fee Riel confirm")
                Me.txtOtherFee.Focus()
                Return False
            ElseIf Me.rdOtherD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter other fee in Dollar.", MsgBoxStyle.Information, "Other fee Dollar confirm")
                Me.txtOtherFee.Focus()
                Return False
            ElseIf Me.txtAmountWord.Text = "" Then
                MsgBox("Please enter the amount payment in word.", MsgBoxStyle.Information, "Amount payment word confirm")
                Me.txtAmountWord.Focus()
                Return False
            ElseIf Me.TxtHospitalFee.Text = "" Then
                MsgBox("Please enter the amount in hospital fee.", MsgBoxStyle.Information, "Amount payment word confirm")
                Me.TxtHospitalFee.Focus()
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

   

    Private Sub txtHN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHN.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
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
    Dim frmReportInPR As New frmReportInpatientReceipt
    '-------------Report Form Active--------------------------------
    Dim ReportInPR As New ReportInpatientReceipt
    Private Sub PrintReportIPR()
        Try
            If Me.lblReceiptToPrintID.Text <> "" Then
                ' PrintReceiptAgain.Enabled = False
                ReportInPR.SetDataSource(MInpatientReceipt.ReportInpatientReceipt(Me.lblReceiptToPrintID.Text).Tables(1))
                ReportInPR.Refresh()
                If ChPrintPreveiw.Checked = True Then
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

                'PrintReceiptAgain.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

   

    Private Sub SearchReceiptPatient()
        If Me.lblID.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number")
            Me.lblCashier.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MInpatientReceipt.SelectInpatientReceipt(Me.lblID.Text).Rows.Count > 0 Then
            With MInpatientReceipt.SelectInpatientReceipt(Me.lblID.Text).Rows(0)
                Me.lblID.Text = .Item(21)
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
                If .Item(5) > 0 And .Item(16) = 1 Then
                    Me.rdOperationD.Checked = True
                    Me.txtOperationFee.Text = .Item(5)
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(16) = 1 Then
                    Me.rdOperationR.Checked = True
                    Me.txtOperationFee.Text = .Item(6)
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(6)
                End If
                If .Item(5) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeD.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeR.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(6)
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(6)
                End If
                If .Item(5) > 0 And .Item(18) = 1 Then
                    Me.rdOtherD.Checked = True
                    Me.txtOtherFee.Text = .Item(5)
                    Me.chkDollar.Checked = True
                    Me.txtAmountFigureD.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(18) = 1 Then
                    Me.rdOtherR.Checked = True
                    Me.txtOtherFee.Text = .Item(6)
                    Me.chkRiel.Checked = True
                    Me.txtAmountFigureR.Text = .Item(6)
                End If
                If .Item(19) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
                Me.txtOperation.Text = .Item(20).ToString
                ChDonation.Checked = .Item("IsDonation").ToString
                CboDonation.SelectedValue = .Item("DonationID").ToString
                TxtDonationPay.Text = .Item("DonationPay").ToString
                TxtDonateNote.Text = .Item("DonateNote").ToString
                TxtHospitalFee.Text = .Item("HosFee").ToString
                CalExchangRadDonate(.Item("TotalUSD"), IIf(.Item("TotalUSD") > 0, .Item("TotalUSD"), .Item("TotalRiel")), .Item("DonationPay").ToString)
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            UpdateReceipt1.Text = "&Update"
            'PrintReceiptAgain.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for inpatient receipt.", MsgBoxStyle.Information, "Inpatient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub
    Sub CalExchangRadDonate(ByVal ToTalUSD As Double, ByVal HospitalFee As Double, ByVal DonatePay As Double)

        Dim DonateRiel As Double = DonatePay * 4000
        If DonatePay = 0 Then
            TxtExchangeDolar.Text = 0
            TxtExchangeRiel.Text = 0
        Else
            If ToTalUSD > 0 Then
                'Is exchange to $
                If DonatePay = ToTalUSD Then
                    TxtExchangeDolar.Text = DonatePay
                    TxtExchangeRiel.Text = DonateRiel
                Else
                    TxtExchangeDolar.Text = DonatePay - HospitalFee
                    TxtExchangeRiel.Text = DonateRiel - (HospitalFee * 4000)
                End If
              
            Else
                'Is exchange to R
                If DonateRiel = HospitalFee Then
                    TxtExchangeDolar.Text = DonatePay
                    TxtExchangeRiel.Text = DonateRiel
                Else
                    TxtExchangeDolar.Text = DonatePay - (HospitalFee / 4000)
                    TxtExchangeRiel.Text = DonateRiel - HospitalFee
                End If
               
            End If
        End If
        
       
    End Sub
    Private Sub SearchReceiptPatientByID()
        If Me.txtReceiptNumber.Text = "" Then
            MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number")
            Me.lblCashier.Text = 0
            Me.dtpDateIn.Checked = False
            Me.txtReceiptNumber.Focus()
            Exit Sub
        End If
        If MInpatientReceipt.SelectInpatientReceiptByID(Me.txtReceiptNumber.Text).Rows.Count > 0 Then
            With MInpatientReceipt.SelectInpatientReceiptByID(Me.txtReceiptNumber.Text).Rows(0)
                Me.lblID.Text = .Item(21)
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
                If .Item(5) > 0 And .Item(16) = 1 Then
                    Me.rdOperationD.Checked = True
                    Me.txtOperationFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(16) = 1 Then
                    Me.rdOperationR.Checked = True
                    Me.txtOperationFee.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeD.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeR.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(18) = 1 Then
                    Me.rdOtherD.Checked = True
                    Me.txtOtherFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(18) = 1 Then
                    Me.rdOtherR.Checked = True
                    Me.txtOtherFee.Text = .Item(6)

                End If
                If .Item(19) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
                Me.txtOperation.Text = .Item(20).ToString
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            UpdateReceipt1.Text = "&Update"
            ' PrintReceiptAgain.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for inpatient receipt.", MsgBoxStyle.Information, "Inpatient receipt ID")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchReceiptPatientByHN()
        If Me.txtHN.Text = "" Then
            MsgBox("Please enter the HN.", MsgBoxStyle.Information, "HN number")
            Me.txtHN.Focus()
            Exit Sub
        End If
        If MInpatientReceipt.SelectInpatientReceiptByHN(Me.txtHN.Text).Rows.Count > 0 Then
            With MInpatientReceipt.SelectInpatientReceiptByHN(Me.txtHN.Text).Rows(0)
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
                If .Item(5) > 0 And .Item(16) = 1 Then
                    Me.rdOperationD.Checked = True
                    Me.txtOperationFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(16) = 1 Then
                    Me.rdOperationR.Checked = True
                    Me.txtOperationFee.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeD.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(17) = 1 Then
                    Me.rdArtificialEyeR.Checked = True
                    Me.txtAritificialEyeFee.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(18) = 1 Then
                    Me.rdOtherD.Checked = True
                    Me.txtOtherFee.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(18) = 1 Then
                    Me.rdOtherR.Checked = True
                    Me.txtOtherFee.Text = .Item(6)

                End If
                If .Item(19) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
                Me.txtOperation.Text = .Item(20).ToString
            End With
            Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
            UpdateReceipt1.Text = "&Update"
            'PrintReceiptAgain.Enabled = True
        Else
            MsgBox("This HN is not valid for inpatient receipt.", MsgBoxStyle.Information, "Inpatient HN")
            Call ClearSearch()
            Me.txtReceiptNumber.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Call SearchReceiptPatientByID()
    End Sub

    Private Sub txtReceiptNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNumber.TextChanged

    End Sub

    Private Sub cmdAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRate.Click
        Dim frmRates As New frmRates
        frmRates.ShowDialog()
        Call GetRates()
    End Sub

   

    Private Sub chkSocialFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSocialFee.CheckedChanged
        If Me.chkSocialFee.Checked = True Then
            Me.txtOperationFee.Text = 0
            Me.txtAritificialEyeFee.Text = 0
            Me.txtOtherFee.Text = 0
        End If
    End Sub

    
    Private Sub cmdFinHN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinHN.Click
        Call SearchReceiptPatientByHN()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub CashierSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashierSave1.Click
        If CheckSave() = False Then
            Exit Sub
        End If
        Dim DialogBox As DialogResult
        DialogBox = MessageBox.Show("Do you really want to update the amount in figure [Riel, US $]?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Cahsier: Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Dim CashTotalDolar As Double = 0
        CashTotalDolar = Round((EmptyString(txtAmountFigureR.Text) / txtRate.Text) + EmptyString(txtAmountFigureD.Text), 2)
        If DialogBox = Windows.Forms.DialogResult.Yes Then
            Call MInpatientReceipt.UpdateInpatientReceiptCashier(Me.lblID.Text, _
            Me.txtAmountFigureR.Text, Me.txtAmountFigureD.Text, _
            IIf((Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
            IIf((Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
            IIf((Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
            IIf((Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
            IIf((Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
            IIf((Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
            Me.txtRate.Text, Me.txtAmountWord.Text, dtpDateIn.Value, Me.lblCashierLogin.Text, Format(Date.Now(), "MM/dd/yyyy"), "1", _
            EmptyString(TxtHospitalFee.Text), CashTotalDolar)
            AccRolesCashier = True
            isTrueFalse = False
            Me.Close()
        End If
    End Sub

    Private Sub UpdateReceipt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateReceipt1.Click

        If CheckSave() = False Then
            Exit Sub
        End If
        If Me.lblID.Text = 0 Then

            If MessageBox.Show("Do you really want to update the amount in figure [Riel, US $]?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Cahsier: Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                    MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
                    Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    Exit Sub
                End If
                'If dtpDateIn.Value.DayOfYear < ModGlobleVariable.GeteDateServer.DayOfYear Then
                '    MsgBox("Receipt date can not < " & ModGlobleVariable.GeteDateServer, MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                If MInpatientReceipt.SaveInpatientReceipt(Me.txtReceiptNumber.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                    Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
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
                    IIf(Me.chkSocialFee.Checked = False, 1, 0), "IR", _
                    Me.lblCashier.Text, "", 1, _
                    Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"), _
                    Me.dtpDateIn.Value.Year, _
                    Me.txtOperation.Text, ChDonation.Checked, _
                    CboDonation.SelectedValue, CboDonation.Text, _
                    EmptyString(TxtDonationPay.Text)) > 0 Then
                    MsgBox("Insert new inpatient receipt successfully", MsgBoxStyle.OkOnly, "New Inpatient Receipt")
                    Me.lblReceiptToPrintID.Text = Me.txtReceiptNumber.Text
                    Me.lblID.Text = 0
                    ' PrintReceiptAgain.Enabled = True
                    'Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    AccRolesCashier = True
                    isTrueFalse = False
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Call PrintReportIPR()
                    Me.Close()
                Else
                    MsgBox("Error new inpatient receipt successfully", MsgBoxStyle.OkOnly, "New Inpatient Receipt")
                End If

            End If
        Else
            If MessageBox.Show("Do you really want to update these information?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim CashTotalDolar As Double = 0
                CashTotalDolar = Round((EmptyString(txtAmountFigureR.Text) / txtRate.Text) + EmptyString(txtAmountFigureD.Text), 2)
                Call MInpatientReceipt.UpdateInpatientReceipt(Me.lblID.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                    Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    IIf((Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                    IIf((Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                    IIf((Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                    IIf((Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                    IIf((Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                    IIf((Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                    IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdOperationR.Checked = True Or Me.rdOperationD.Checked = True, "1", "0"), IIf(Me.rdArtificialEyeR.Checked = True Or Me.rdArtificialEyeD.Checked = True, "1", "0"), _
                    IIf(Me.rdOtherR.Checked = True Or Me.rdOtherD.Checked = True, "1", "0"), IIf(Me.chkSocialFee.Checked = True, 1, 0), _
                    IIf(Me.chkSocialFee.Checked = False, 1, 0), "IR", Me.lblCashierLogin.Text, 1, Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"), _
                    Me.txtOperation.Text, ChDonation.Checked, CboDonation.SelectedValue, CboDonation.Text, EmptyString(TxtDonationPay.Text), TxtDonateNote.Text, EmptyString(TxtHospitalFee.Text), CashTotalDolar)
                'Me.cmdPrint.Enabled = True
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReceiptAgain.Click
        Call PrintReportIPR()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        AccRolesCashier = True
        isTrueFalse = False
        Me.Close()
    End Sub


    Private Sub ChDonation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDonation.CheckedChanged
        If ChDonation.Checked = True Then
            CboDonation.Enabled = ChDonation.Checked
            TxtDonationPay.Enabled = ChDonation.Checked
        Else
            CboDonation.Enabled = ChDonation.Checked
            TxtDonationPay.Enabled = ChDonation.Checked
            CboDonation.SelectedIndex = -1
            TxtDonationPay.Text = 0
        End If
    End Sub

    Private Sub TxtDonationPay_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonationPay.KeyPress, TxtExchangeRiel.KeyPress, TxtExchangeDolar.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboDonation_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDonation.DropDown
        InitDonation()
    End Sub

   
    Private Sub txtOperation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperation.SelectedIndexChanged
        Try
            TxtHospitalFee.Text = ModSurgeries.GetSurgeryPrice(txtOperation.SelectedValue)
        Catch ex As Exception
            TxtHospitalFee.Text = 0
        End Try

    End Sub
End Class
