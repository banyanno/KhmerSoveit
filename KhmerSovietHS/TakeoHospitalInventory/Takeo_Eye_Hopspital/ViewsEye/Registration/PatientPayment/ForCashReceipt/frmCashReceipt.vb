Imports System.Math

Public Class frmCashReceipt
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        dtpDateIn.Value = ModGlobleVariable.GeteDateServer
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        isTrueFalse = False
        AccRolesCashier = False
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

    Private Sub txtMedical_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMedicine.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtMedical_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMedicine.LostFocus
        If Me.txtMedicine.Text.Trim = "" Then
            Me.txtMedicine.Text = "0"
        End If
    End Sub

    Private Sub txtMedical_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMedicine.MouseClick
        Me.txtMedicine.SelectAll()
    End Sub

    Private Sub txtGlass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGlass.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtGlass_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGlass.LostFocus
        If Me.txtGlass.Text.Trim = "" Then
            Me.txtGlass.Text = "0"
        End If
    End Sub

    Private Sub txtGlass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtGlass.MouseClick
        Me.txtGlass.SelectAll()
    End Sub

    Private Sub txtOtherFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 46, 8, 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtMedicine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMedicine.TextChanged
        If Me.txtMedicine.Text.Trim > "0" Then
            Me.txtGlass.Text = "0"
            Me.txtTotal.Text = Me.txtMedicine.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub txtGlass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlass.TextChanged
        If Me.txtGlass.Text.Trim > "0" Then
            Me.txtMedicine.Text = "0"
            Me.txtTotal.Text = Me.txtGlass.Text.Trim
            Call InpatientPayment()
        Else
            Me.txtTotal.Text = "0"
        End If
    End Sub

    Private Sub rdMedicineR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdMedicineR.CheckedChanged
        If Me.rdMedicineR.Checked = True Then
            Me.txtMedicine.Enabled = True
            Me.txtMedicine.Text = ""
            Me.txtMedicine.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "OPFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtMedicine.Text = "0"
            Me.txtMedicine.Enabled = False
        End If
    End Sub

    Private Sub rdGlassR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdGlassR.CheckedChanged
        If Me.rdGlassR.Checked = True Then
            Me.txtGlass.Enabled = True
            Me.txtGlass.Text = ""
            Me.txtGlass.Focus()
            Me.lblRielDolar.Text = "erol"
            Me.lblFees.Text = "AEFeesRiel"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtGlass.Text = "0"
            Me.txtGlass.Enabled = False
        End If
    End Sub

    Private Sub rdMedicineD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdMedicineD.CheckedChanged
        If Me.rdMedicineD.Checked = True Then
            Me.txtMedicine.Enabled = True
            Me.txtMedicine.Text = ""
            Me.txtMedicine.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "OPFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtMedicine.Text = "0"
            Me.txtMedicine.Enabled = False
        End If
    End Sub

    Private Sub rdGlassD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdGlassD.CheckedChanged
        If Me.rdGlassD.Checked = True Then
            Me.txtGlass.Enabled = True
            Me.txtGlass.Text = ""
            Me.txtGlass.Focus()
            Me.lblRielDolar.Text = "duløa"
            Me.lblFees.Text = "AEFeesDollar"
            Me.txtReturnD.Text = "0"
            Me.txtReturnR.Text = "0"
        Else
            Me.txtGlass.Text = "0"
            Me.txtGlass.Enabled = False
        End If
    End Sub

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
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
            Me.lblReceiptToPrintID.Text = ""
            Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        Else
            Call SearchCashR()
        End If
        Me.lblFees.Text = ""
        Me.cmdPrint.Enabled = False
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                    'Me.cmdCashierSave.Visible = True
                    'Me.cmdSave.Enabled = False
                    'Me.cmdPrint.Enabled = False
                ElseIf .Item(0) = "New Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    Me.cmdCashierSave.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Old Registration" Then
                    Me.chkDollar.Enabled = False
                    Me.chkRiel.Enabled = False
                    Me.cmdPrint.Enabled = True
                    Me.cmdSave.Enabled = True
                    Me.cmdCashierSave.Visible = False
                    AccRolesCashier = False
                ElseIf .Item(0) = "Administrator" Then
                    AccRolesCashier = True
                    Me.cmdCashierSave.Visible = True
                    Me.cmdSave.Enabled = True
                    Me.cmdPrint.Enabled = True
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

        Me.lblReceiptToPrintID.Text = ""

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtMedicine.Enabled = False
        Me.txtMedicine.Text = "0"
        Me.rdMedicineR.Checked = False
        Me.rdMedicineD.Checked = False

        Me.txtGlass.Enabled = False
        Me.txtGlass.Text = "0"
        Me.rdGlassR.Checked = False
        Me.rdGlassD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"

        Me.cmdSave.Text = "&Save"
        Me.cmdPrint.Enabled = False
    End Sub

    Sub ClearForm()
        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()

        Me.txtCashReceiptNumber.Clear()

        Me.txtHN.Text = ""
        Me.txtPatient.Text = ""

        Me.lblReceiptToPrintID.Text = ""
        Me.lblID.Text = 0
        Me.dtpDateIn.Checked = False

        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Text = "0"

        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Text = "0"
        Me.chkRiel.Checked = False
        Me.chkDollar.Checked = False

        Me.txtMedicine.Enabled = False
        Me.txtMedicine.Text = "0"
        Me.rdMedicineR.Checked = False
        Me.rdMedicineD.Checked = False

        Me.txtGlass.Enabled = False
        Me.txtGlass.Text = "0"
        Me.rdGlassR.Checked = False
        Me.rdGlassD.Checked = False

        Me.chkSocialFee.Checked = False

        Me.txtTotal.Text = "0"

        Me.txtReturnR.Text = "0"
        Me.txtReturnD.Text = "0"

        Me.cmdSave.Text = "&Save"
        Me.cmdPrint.Enabled = False
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

    Private Function CheckSave() As Boolean
        If Me.chkSocialFee.Checked = False Then
            If Me.lblCashier.Text = "" Then
                MsgBox("Please check the cashier name.", MsgBoxStyle.Information, "Cashier Confirm")
                Return False
            ElseIf Me.txtReceiptNumber.Text = "" Then
                MsgBox("Please enter the receipt number.", MsgBoxStyle.Information, "Receipt number confirm")
                Me.txtReceiptNumber.Focus()
                Return False
            ElseIf Me.dtpDateIn.Checked = False Then
                MsgBox("Please select the date to save.", MsgBoxStyle.Information, "Date confirm")
                Me.dtpDateIn.Focus()
                Return False
            ElseIf Me.txtCashReceiptNumber.Text = "" Then
                MsgBox("Please enter the cash receipt number.", MsgBoxStyle.Information, "Cash receipt number confirm")
                Me.txtCashReceiptNumber.Focus()
                Return False
            ElseIf Me.txtHN.Text = "" Then
                MsgBox("Please enter HN number.", MsgBoxStyle.Information, "HN confirm")
                Me.txtHN.Focus()
                Return False
            ElseIf Me.txtRate.Text = "" Then
                MsgBox("Please check the rate. This operation cannot work without rate.", MsgBoxStyle.Information, "Rate confirm")
                Me.txtRate.Focus()
                Return False
            ElseIf Me.txtPatient.Text = "" Then
                MsgBox("Please enter the patient name.", MsgBoxStyle.Information, "Patient confirm")
                Me.txtPatient.Focus()
                Return False
            ElseIf Me.rdMedicineR.Checked = False And Me.rdMedicineD.Checked = False And Me.rdGlassR.Checked = False And Me.rdGlassD.Checked = False Then
                MsgBox("Please enter the amount of operation or artificial or other fee.", MsgBoxStyle.Information, "Hospital fee confirm")
                Me.rdMedicineR.Focus()
                Return False
            ElseIf Me.rdMedicineR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter operation fee in Riel.", MsgBoxStyle.Information, "Operation fee Riel confirm")
                Me.txtMedicine.Focus()
                Return False
            ElseIf Me.rdMedicineD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter operation fee in Dollar.", MsgBoxStyle.Information, "Operation fee Dollar confirm")
                Me.txtMedicine.Focus()
                Return False
            ElseIf Me.rdGlassR.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter artificial fee in Riel.", MsgBoxStyle.Information, "Artificial fee Riel confirm")
                Me.txtGlass.Focus()
                Return False
            ElseIf Me.rdGlassD.Checked = True And Me.txtTotal.Text = "0" Then
                MsgBox("Please enter artificial fee in Dollar.", MsgBoxStyle.Information, "Artificial fee Dollar confirm")
                Me.txtGlass.Focus()
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
        Else
            If Me.txtCashReceiptNumber.Text = "" Then
                MsgBox("Please enter the cash receipt number.", MsgBoxStyle.Information, "Cash Receipt Number")
                Me.lblID.Text = 0
                Me.txtCashReceiptNumber.Focus()
                Return False
            End If
            Return True
        End If
        'Return True
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckSave() = False Then
            Exit Sub
        End If
        If Me.lblID.Text <> 0 Then
            Dim DialogBox As DialogResult
            DialogBox = MessageBox.Show("Do you really want to update these information?" & Chr(13) & "Please make sure that you enter the right amount before saving." & Chr(13) & "Click Yes to update and click No to cancel update.", "Receipt ID existed", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                Call MCashReceipt.UpdateCashReceipt(Me.txtReceiptNumber.Text, Me.lblID.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf((Me.rdMedicineR.Checked = True Or Me.rdMedicineD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                IIf((Me.rdMedicineD.Checked = True Or Me.rdMedicineR.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                IIf((Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                IIf((Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdMedicineD.Checked = True Or Me.rdMedicineR.Checked = True, "1", "0"), IIf(Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True, "1", "0"), _
                IIf(Me.chkSocialFee.Checked = True, 1, 0), IIf(Me.chkSocialFee.Checked = False, 1, 0), "CR", Me.lblCashierLogin.Text, 1, Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"))
                'Me.cmdPrint.Enabled = True
                'Me.Close()
            End If
        Else
            Dim DialogBox As DialogResult = MessageBox.Show("Do you really want to save these information?", "Save confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                    MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
                    Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    Exit Sub
                End If
                Call MCashReceipt.SaveCashReceipt(Me.txtReceiptNumber.Text, Me.txtCashReceiptNumber.Text, Me.txtHN.Text, Me.txtPatient.Text, Me.txtAmountFigureR.Text, _
                    Me.txtAmountFigureD.Text, IIf(Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    IIf((Me.rdMedicineR.Checked = True Or Me.rdMedicineD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                    IIf((Me.rdMedicineD.Checked = True Or Me.rdMedicineR.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                    IIf((Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True) And Me.chkRiel.Checked = True, Me.txtAmountFigureR.Text, 0), _
                    IIf((Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True) And Me.chkDollar.Checked = True, Me.txtAmountFigureD.Text, 0), _
                    IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = True And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "erol", Me.txtTotal.Text, 0), IIf(Me.chkSocialFee.Checked = False And Me.lblRielDolar.Text = "duløa", Me.txtTotal.Text, 0), _
                    Me.txtRate.Text, Me.txtAmountWord.Text, IIf(Me.rdMedicineD.Checked = True Or Me.rdMedicineR.Checked = True, "1", "0"), IIf(Me.rdGlassR.Checked = True Or Me.rdGlassD.Checked = True, "1", "0"), _
                    IIf(Me.chkSocialFee.Checked = True, 1, 0), IIf(Me.chkSocialFee.Checked = False, 1, 0), "CR", Me.lblCashier.Text, "", 1, Me.dtpDateIn.Value, Format(Date.Now(), "MM/dd/yyyy"), "1", Me.dtpDateIn.Value.Year)
                Me.lblReceiptToPrintID.Text = Me.txtCashReceiptNumber.Text
                Me.lblID.Text = 0
                Me.cmdPrint.Enabled = True
                'Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                isTrueFalse = False
                AccRolesCashier = False
                'Call PrintReportCash()
                Me.Close()
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

    Private Sub txtCashReceiptNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCashReceiptNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub SearchCashR()
        If Me.lblID.Text = "" Then
            MsgBox("Please enter the cash receipt number.", MsgBoxStyle.Information, "Cash Receipt number")
            Me.lblID.Text = 0
            Me.txtCashReceiptNumber.Focus()
            Exit Sub
        End If
        If MCashReceipt.SelectCashReceipt(Me.lblID.Text).Rows.Count > 0 Then
            With MCashReceipt.SelectCashReceipt(Me.lblID.Text).Rows(0)
                Me.lblID.Text = .Item(17)
                Me.lblCashier.Text = .Item(8)
                Me.txtCashReceiptNumber.Text = .Item(2)
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
                If .Item(5) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineD.Checked = True
                    Me.txtMedicine.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineR.Checked = True
                    Me.txtMedicine.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(15) = 1 Then
                    Me.rdGlassD.Checked = True
                    Me.txtGlass.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(15) = 1 Then
                    Me.rdGlassR.Checked = True
                    Me.txtGlass.Text = .Item(6)

                End If
                If .Item(16) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtCashReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for cash receipt.", MsgBoxStyle.Information, "Cash receipt ID")
            Call ClearSearch()
            Me.txtCashReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchCashRByRecID()
        If Me.txtCashReceiptNumber.Text = "" Then
            MsgBox("Please enter the cash receipt number.", MsgBoxStyle.Information, "Cash Receipt number")
            Me.lblID.Text = 0
            Me.txtCashReceiptNumber.Focus()
            Exit Sub
        End If
        If MCashReceipt.SelectCashReceiptByRecID(Me.txtCashReceiptNumber.Text).Rows.Count > 0 Then
            With MCashReceipt.SelectCashReceiptByRecID(Me.txtCashReceiptNumber.Text).Rows(0)
                Me.lblID.Text = .Item(17)
                Me.lblCashier.Text = .Item(8)
                Me.txtCashReceiptNumber.Text = .Item(2)
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
                If .Item(5) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineD.Checked = True
                    Me.txtMedicine.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineR.Checked = True
                    Me.txtMedicine.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(15) = 1 Then
                    Me.rdGlassD.Checked = True
                    Me.txtGlass.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(15) = 1 Then
                    Me.rdGlassR.Checked = True
                    Me.txtGlass.Text = .Item(6)

                End If
                If .Item(16) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtCashReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            Me.cmdPrint.Enabled = True
        Else
            MsgBox("This receipt ID is not valid for cash receipt.", MsgBoxStyle.Information, "Cash receipt ID")
            Call ClearSearch()
            Me.txtCashReceiptNumber.Focus()
        End If
    End Sub

    Private Sub SearchCashRByHN()
        If Me.txtHN.Text = "" Then
            MsgBox("Please enter the HN.", MsgBoxStyle.Information, "Cash Receipt number")
            Me.txtHN.Focus()
            Exit Sub
        End If
        If MCashReceipt.SelectCashReceiptByHN(Me.txtHN.Text).Rows.Count > 0 Then
            With MCashReceipt.SelectCashReceiptByHN(Me.txtHN.Text).Rows(0)
                Me.lblCashier.Text = .Item(8)
                Me.txtCashReceiptNumber.Text = .Item(2)
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
                If .Item(5) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineD.Checked = True
                    Me.txtMedicine.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(14) = 1 Then
                    Me.rdMedicineR.Checked = True
                    Me.txtMedicine.Text = .Item(6)

                End If
                If .Item(5) > 0 And .Item(15) = 1 Then
                    Me.rdGlassD.Checked = True
                    Me.txtGlass.Text = .Item(5)

                ElseIf .Item(6) > 0 And .Item(15) = 1 Then
                    Me.rdGlassR.Checked = True
                    Me.txtGlass.Text = .Item(6)

                End If
                If .Item(16) = 1 Then
                    Me.chkSocialFee.Checked = True
                End If
            End With
            Me.lblReceiptToPrintID.Text = Me.txtCashReceiptNumber.Text
            Me.cmdSave.Text = "&Update"
            Me.cmdPrint.Enabled = True
        Else
            MsgBox("This HN is not valid for cash receipt.", MsgBoxStyle.Information, "HN Confirm")
            Call ClearSearch()
            Me.txtCashReceiptNumber.Focus()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Call SearchCashRByRecID()
    End Sub

    Private Sub PrintReportCash()
        Try
            If Me.lblReceiptToPrintID.Text <> "" Then
                Me.cmdPrint.Enabled = False
                Dim ReportInCR As New ReportCashReceipt
                ReportInCR.SetDataSource(MCashReceipt.ReportCashReceipt(Me.lblReceiptToPrintID.Text).Tables(1))
                ReportInCR.Refresh()
                If ChPrintPreveiw.Checked = True Then
                    Dim frmReportLoad As New frmReportCashReceipt
                    frmReportLoad.crvReportCashReceipt.ReportSource = ReportInCR
                    frmReportLoad.ShowDialog()
                    frmReportLoad.Dispose()
                    frmReportLoad.Close()
                    ReportInCR.Dispose()
                    ReportInCR.Close()
                Else
                    printDocument.PrinterSettings.PrinterName = ModCommon.PrinterReceipt
                    ReportInCR.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
                    ReportInCR.PrintToPrinter(1, True, 1, 1)
                    ReportInCR.Dispose()
                    ReportInCR.Close()
                End If
                '-------------Report Form Active--------------------------------
                Me.cmdPrint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call PrintReportCash()
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
            Call MCashReceipt.UpdateCashReceiptCashier(Me.lblID.Text, Me.txtAmountFigureR.Text, Me.txtAmountFigureD.Text, Me.lblCashier.Text, Format(Me.dtpDateIn.Value, "MM/dd/yyyy"))
            isTrueFalse = False
            AccRolesCashier = False
            Me.Close()
        End If
    End Sub

    Private Sub txtCashReceiptNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashReceiptNumber.TextChanged

    End Sub

    Private Sub chkSocialFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSocialFee.CheckedChanged
        If Me.chkSocialFee.Checked = True Then
            Me.txtMedicine.Text = 0
            Me.txtGlass.Text = 0
        End If
    End Sub

    Private Sub cmdFindHN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindHN.Click
        Call SearchCashRByHN()
    End Sub
End Class