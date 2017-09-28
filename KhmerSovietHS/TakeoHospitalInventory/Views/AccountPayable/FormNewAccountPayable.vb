Public Class FormNewAccountPayable
    Dim DAAccountName As New DSAccountPayableTableAdapters.ACCOUNT_PAYABLETableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboAccountName
            .DataSource = DAAccountName.GetData
            .ValueMember = "AccountID"
            .DisplayMember = "AccountName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboAccountName, "", ErrPayable) = False Then Exit Sub
        If ValidateDateTimePicker(DatePaidAble, "", ErrPayable) = False Then Exit Sub
        If ChDolar.Checked = True Then
            If ValidateTextField(TxtAmountDolar, "", ErrPayable) = False Then Exit Sub
        End If
        If ChRiel.Checked = True Then
            If ValidateTextField(TxtAmountRiel, "", ErrPayable) = False Then Exit Sub
        End If

        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new payable?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim OpticalImp As New OpticalshopImp
                Dim ObjAccountPaid As New ACCOUNT_PAYABLE_DETAIL
                ObjAccountPaid.ACCOUNTID = CInt(CboAccountName.SelectedValue)
                ObjAccountPaid.DATE_PAID = DatePaidAble.Value
                ObjAccountPaid.DESCRIPTION = TxtDescription.Text
                ObjAccountPaid.IS_DELETE = False
                If ChDolar.Checked = True Then
                    ObjAccountPaid.AMOUNT_DOLAR = TxtAmountDolar.Text
                    ObjAccountPaid.IS_DOLAR = True
                Else
                    ObjAccountPaid.AMOUNT_DOLAR = 0
                    ObjAccountPaid.IS_DOLAR = False
                End If
                If ChRiel.Checked = True Then
                    ObjAccountPaid.AMOUNT_REAL = TxtAmountRiel.Text
                    ObjAccountPaid.IS_RIEL = True
                Else
                    ObjAccountPaid.AMOUNT_REAL = 0
                    ObjAccountPaid.IS_RIEL = False
                End If

                If OpticalImp.SaveNewPaidAccountPayable(ObjAccountPaid) = True Then
                    MessageBox.Show("Save new payable successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new payable.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update payable?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim OpticalImp As New OpticalshopImp
                Dim ObjAccountPaid As ACCOUNT_PAYABLE_DETAIL = OpticalImp.GetPaidAccountPayable(LblSaveOption.Text)
                ObjAccountPaid.DATE_PAID = DatePaidAble.Value
                ObjAccountPaid.ACCOUNTID = CInt(CboAccountName.SelectedValue)
                ObjAccountPaid.DESCRIPTION = TxtDescription.Text
                If ChDolar.Checked = True Then
                    ObjAccountPaid.AMOUNT_DOLAR = TxtAmountDolar.Text
                    ObjAccountPaid.IS_DOLAR = True
                Else
                    ObjAccountPaid.AMOUNT_DOLAR = 0
                    ObjAccountPaid.IS_DOLAR = False
                End If
                If ChRiel.Checked = True Then
                    ObjAccountPaid.AMOUNT_REAL = TxtAmountRiel.Text
                    ObjAccountPaid.IS_RIEL = True
                Else
                    ObjAccountPaid.AMOUNT_REAL = 0
                    ObjAccountPaid.IS_RIEL = False
                End If

                If OpticalImp.UpdateReceiptPay = True Then
                    MessageBox.Show("Update account payable successful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update payable.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    
    Private Sub ChDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDolar.CheckedChanged
        TxtAmountDolar.Enabled = ChDolar.Checked
        TxtAmountDolar.Select()
        TxtAmountDolar.Focus()
    End Sub

    Private Sub ChRiel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChRiel.CheckedChanged
        TxtAmountRiel.Enabled = ChRiel.Checked
        TxtAmountRiel.Select()
        TxtAmountRiel.Focus()
    End Sub

    Private Sub TxtAmountDolar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountDolar.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtAmountRiel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountRiel.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class