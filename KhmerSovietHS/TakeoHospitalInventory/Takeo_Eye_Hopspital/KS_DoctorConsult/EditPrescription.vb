Public Class EditPrescription
    Dim DA_PrePrescription As New DSConsultHistoryTableAdapters.S_PRESCRIPTION_PRETableAdapter
    Dim DA_Item As New DSConsultHistoryTableAdapters.tblItemTableAdapter
    Dim DA_Ordinance As New DSOrdinanceTableAdapters.S_ORDINANCETableAdapter
    Dim DA_Duration As New DSOrdinanceTableAdapters.S_DURATIONTableAdapter
    Dim DA_Usage As New DSOrdinanceTableAdapters.S_USINAGETableAdapter
    Private ItemPrice As New DSItemPriceTableAdapters.tblItemPriceTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Add any initialization after the InitializeComponent() call.
        With cbomedicine
            .DataSource = DA_Item.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With

        With txtdosage
            .DataSource = DA_Ordinance.GetData
            .ValueMember = "ORDERNONG_ID"
            .DisplayMember = "LABEL_ORDERNONG"
            .SelectedIndex = -1
        End With

        With TxtUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USING_ID"
            .DisplayMember = "USING_LABEL"
            .SelectedIndex = -1
        End With
        With CboDuration
            .DataSource = DA_Duration.GetData
            .ValueMember = "DURATION_ID"
            .DisplayMember = "DURATION"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnRemovePrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrescription.Click
        Me.Close()
    End Sub

    Private Sub BtnAddPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrescription.Click
        If ValidateCombobox(cbomedicine, "", ErrConsult) = False Then Exit Sub
        'If ValidateCombobox(txtdosage, "", ErrConsult) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrConsult) = False Then Exit Sub
        If ValidateCombobox(TxtUsage, "", ErrConsult) = False Then Exit Sub
        If MessageBox.Show("Do you want to update precription?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_PrePrescription.UpdatePrePrescription(CInt(cbomedicine.SelectedValue), cbomedicine.Text, txtdosage.Text, EmptyString(TxtQTY.Text), TxtUsage.Text & "-" & CboDuration.Text, CDbl(LblPrice.Text), CDbl(EmptyString(TxtQTY.Text)) * CDbl(LblPrice.Text), LblSaveOption.Text) = 1 Then
                'DA_PrePrescription.InsertPrePrescription(CInt(LblWaitingNo.Text), CDbl(TxtPatientNo.Text), CInt(cbomedicine.SelectedValue), cbomedicine.Text, txtdosage.Text, CInt(EmptyString(TxtQTY.Text)), TxtUsage.Text & "-" & CboDuration.Text, GetDateServer.Date, CInt(LblPrice.Text), CDbl(EmptyString(TxtQTY.Text)) * CDbl(LblPrice.Text))
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub cbomedicine_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedValueChanged
        Try
            Dim TblTemItem As DataTable = ItemPrice.GetItemPriceDataByItemID(CInt(cbomedicine.SelectedValue))  'SelectByItemID(CInt(cbomedicine.SelectedValue))
            LblPrice.Text = "0"
            For Each row As DataRow In TblTemItem.Rows
                LblPrice.Text = CDbl(row("Price"))
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
            LblPrice.Text = "0"
        End Try

    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class