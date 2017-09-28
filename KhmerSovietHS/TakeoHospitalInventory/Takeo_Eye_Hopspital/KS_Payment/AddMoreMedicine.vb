Public Class AddMoreMedicine
    Dim MWaitingPay As DashboardPayment
    Dim DA_MedicineService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTMEDICINE_PAYMENTTableAdapter
    Dim DA_Item As New DS_KSPAYMENTTableAdapters.tblItemTableAdapter
    Private ItemPrice As New DSItemPriceTableAdapters.tblItemPriceTableAdapter
    Dim DA_PresciptionV1 As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Dim DA_Usage As New DSOrdinanceTableAdapters.S_USINAGETableAdapter
    Dim DA_Ordinance As New DSOrdinanceTableAdapters.S_ORDINANCETableAdapter
    Dim DA_Duration As New DSOrdinanceTableAdapters.S_DURATIONTableAdapter
    Sub New(ByVal MWaitingPay As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MWaitingPay = MWaitingPay
        ' Add any initialization after the InitializeComponent() call.
        With CboMedicine
            .DataSource = DA_ITem.GetData
            .DisplayMember = "ItemName"
            .ValueMember = "ItemID"
            .SelectedIndex = -1
        End With
        With TxtUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USING_ID"
            .DisplayMember = "USING_LABEL"
            .SelectedIndex = -1
        End With
        With txtdosage
            .DataSource = DA_Ordinance.GetData
            .ValueMember = "ORDERNONG_ID"
            .DisplayMember = "LABEL_ORDERNONG"
            .SelectedIndex = -1
        End With
        With CboDuration
            .DataSource = DA_Duration.GetData
            .ValueMember = "DURATION_ID"
            .DisplayMember = "DURATION"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboMedicine, "", ErrMedicine) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrMedicine) = False Then Exit Sub
        If ValidateCombobox(TxtUsage, "", ErrMedicine) = False Then Exit Sub
        If DA_MedicineService.CheckExistingItem(CInt(CboMedicine.SelectedValue), LblWaitingFee.Text) > 0 Then
            MessageBox.Show("The medicine already add!. Please check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboMedicine.Focus()
            CboMedicine.SelectAll()
            Exit Sub
        End If
        If DA_Item.CheckNameMedicince(CInt(CboMedicine.SelectedValue), CboMedicine.Text) <= 0 Then
            MessageBox.Show("The name of medicince doesn't have in system. Please check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboMedicine.Focus()
            CboMedicine.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to add medicine?", "Medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_PresciptionV1.InsertNewPrescription( _
                        CDbl(LblWaitingFee.Text), CDbl(LblPatientNo.Text), CInt(CboMedicine.SelectedValue), _
                        CboMedicine.Text, txtdosage.Text, _
                        CInt(EmptyString(TxtQTY.Text)), TxtUsage.Text & CboDuration.Text, _
                        Now.Date, _
                        CDbl(EmptyString(TxtPrice.Text)), CDbl(EmptyString(TxtTotalPrice.Text))) = 1 Then
                MWaitingPay.ViewPatientMedicine(LblWaitingFee.Text)
                CboMedicine.SelectedIndex = -1
                txtdosage.SelectedIndex = -1
                CboDuration.SelectedIndex = -1
                TxtPrice.Text = ""
                TxtQTY.Text = ""
                TxtTotalPrice.Text = ""
                TxtUsage.SelectedIndex = -1
                CboMedicine.Select()
                CboMedicine.Focus()
            End If



            'If DA_MedicineService.InsertNewMedicinePay(LblWaitingFee.Text, CInt(CboMedicine.SelectedValue), CboMedicine.Text, EmptyString(TxtPrice.Text), EmptyString(TxtQTY.Text), EmptyString(TxtTotalPrice.Text)) = 1 Then

            'End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub
    Sub CalculateTotalMedicine()
        TxtTotalPrice.Text = CDbl(EmptyString(TxtPrice.Text)) * CDbl(EmptyString(TxtQTY.Text))
    End Sub

    Private Sub TxtPrice_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrice.KeyUp
        CalculateTotalMedicine()
    End Sub

    Private Sub TxtQTY_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQTY.KeyUp
        CalculateTotalMedicine()
    End Sub

    Private Sub CboMedicine_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMedicine.SelectedValueChanged
        Try
            Dim TblTemItem As DataTable = ItemPrice.GetCurItemPriceDataByItemID(CInt(CboMedicine.SelectedValue))
            TxtPrice.Text = "0"
            For Each row As DataRow In TblTemItem.Rows
                TxtPrice.Text = row("Price")
            Next
        Catch ex As Exception
            TxtPrice.Text = "0"
        End Try
    End Sub
End Class