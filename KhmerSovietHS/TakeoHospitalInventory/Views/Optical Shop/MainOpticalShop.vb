Public Class MainOpticalShop
    Dim DSOpt As New DSOpticalShop
    Dim DAReceipt As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim DAReceiptDetail As New DSOpticalShopTableAdapters.VReceiptDetailTableAdapter
    Dim MTakeoInventory As MainTakeoInventory
    Sub New(ByVal MTakeoInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub LoadingReceipt()
        DAReceipt.GetData()
        DAReceipt.Fill(DSOpt.VMainReceiptDetail)
        DAReceiptDetail.GetData()
        DAReceiptDetail.Fill(DSOpt.VReceiptDetail)
        GridReceipt.DataSource = DSOpt.VMainReceiptDetail
        GridReceipt.RootTable.ChildTables(0).DataMember = "VMainReceiptDetail_VReceiptDetail"
    End Sub
    Sub LoadingReceiptByDate(ByVal DateToVal As Date, ByVal DateFromVal As Date)
        'DAReceipt.GetData
        DAReceipt.FillByDateToFrom(DSOpt.VMainReceiptDetail, DateFromVal, DateToVal)
        DAReceiptDetail.GetData()
        DAReceiptDetail.Fill(DSOpt.VReceiptDetail)
        GridReceipt.DataSource = DSOpt.VMainReceiptDetail
        GridReceipt.RootTable.ChildTables(0).DataMember = "VMainReceiptDetail_VReceiptDetail"
    End Sub
    Sub LoadingReceiptByDateCancel(ByVal DateToVal As Date, ByVal DateFromVal As Date, ByVal isPaidVal As Integer)
        DAReceipt.FillByDateWithCancelPaid(DSOpt.VMainReceiptDetail, DateFromVal, DateToVal, isPaidVal)
        ' DAReceiptDetail.GetData()
        DAReceiptDetail.Fill(DSOpt.VReceiptDetail)
        GridReceipt.DataSource = DSOpt.VMainReceiptDetail
        GridReceipt.RootTable.ChildTables(0).DataMember = "VMainReceiptDetail_VReceiptDetail"
        GridReceipt.Refresh()
    End Sub
    Sub LoadingReceiptByDateWithWaitAndPaid(ByVal DateToVal As Date, ByVal DateFromVal As Date, ByVal isPaidVal1 As Integer)

        DAReceipt.FillByDateWithWaitingPay(DSOpt.VMainReceiptDetail, DateFromVal, DateToVal, isPaidVal1)
        ' DAReceiptDetail.GetData()
        DAReceiptDetail.Fill(DSOpt.VReceiptDetail)
        GridReceipt.DataSource = DSOpt.VMainReceiptDetail
        GridReceipt.RootTable.ChildTables(0).DataMember = "VMainReceiptDetail_VReceiptDetail"
        GridReceipt.Refresh()
    End Sub
    Sub LoadByReceiptNo(ByVal receiptNo As String)
        DAReceipt.GetDataByReceiptNo(receiptNo)
        DAReceipt.Fill(DSOpt.VMainReceiptDetail)
        DAReceiptDetail.GetData()
        DAReceiptDetail.Fill(DSOpt.VReceiptDetail)
        GridReceipt.DataSource = DSOpt.VMainReceiptDetail
        GridReceipt.RootTable.ChildTables(0).DataMember = "VMainReceiptDetail_VReceiptDetail"
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        'FilterReceipt.Visible = True
        MTakeoInventory.StatusLoading(True)
        'RadWaitAndPaid.Checked = True
        BtnView.Enabled = False
        BGLoadOpticalShop.RunWorkerAsync()
        'If RadWaitAndPaid.Checked = True Then
        '    LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
        'Else
        '    LoadingReceiptByDateCancel(DateTo.Value, DateFrom.Value, 2)
        'End If

    End Sub
    Sub FileOpticalReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf FileOpticalReceipt))
        Else
            If RadWaitAndPaid.Checked = True Then
                LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
            End If
            If RadReceiptCancel.Checked = True Then
                LoadingReceiptByDateCancel(DateTo.Value, DateFrom.Value, 2)
            End If
        End If
        
    End Sub

    Private Sub BtnNewReceipt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReceipt1.Click
        Dim FNewReceipt As New FrmNewReceipt(MTakeoInventory)
        If FNewReceipt.ShowDialog() = DialogResult.OK Then
            LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
        End If
    End Sub

    Private Sub RadReceiptCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptCancel.CheckedChanged
        'LoadingReceiptByDateCancel(DateTo.Value, DateFrom.Value, 2)
    End Sub

    Private Sub RadWaitAndPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadWaitAndPaid.CheckedChanged
        'LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
    End Sub

    Private Sub BtnEditInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditInvoice.Click

        Try
            If GridReceipt.SelectedItems.Count = 0 Then
                MessageBox.Show("Please select invoice to edit.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            ElseIf CBool(GridReceipt.GetRow.Cells("IsPaid").Value) = True Then
                MessageBox.Show("The receipt already paid you can not edit, Could you do adjust for item.", "edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim FNewReceipt As New FrmNewReceipt(MTakeoInventory)
                FNewReceipt.LblSaveStatus.Text = GridReceipt.GetRow.Cells("ReceiptID").Value
                FNewReceipt.InvoiceNo = GridReceipt.SelectedItems(0).GetRow.Cells("ReceiptNo").Value

                FNewReceipt.GroupPayCorrency.Enabled = False
                If FNewReceipt.ShowDialog() = DialogResult.OK Then
                    BtnPrintInvoice_Click(sender, e)
                    LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
                End If
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnPrintInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintInvoice.Click
        If GridReceipt.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select invoice to edit.", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                '---- print request order ----------
                MTakeoInventory.StatusLoading(True)
                Application.DoEvents()
                Dim FRptRequestView As New frmReportViewer
                FRptRequestView.ReportOption = 14
                FRptRequestView.PrintReceiptAgain = True
                FRptRequestView.ReceiptID = GridReceipt.GetRow.Cells("ReceiptID").Value 'GridReceipt.SelectedItems(0).GetRow.Cells("ReceiptID").Value
                MTakeoInventory.StatusLoading(False)
                If FRptRequestView.ShowDialog = DialogResult.OK Then

                End If
            Catch ex As Exception
                MessageBox.Show("Please select Receipt no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        End If

    End Sub

    Private Sub GridReceipt_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridReceipt.SelectionChanged
        'Try           
        '    If GridReceipt.SelectedItems(0).GetRow.Cells("ReceiptNo").Value = "0" Then
        '        BtnEditInvoice.Enabled = False
        '    Else
        '        'BtnEditInvoice.Enabled = True
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub BGLoadOpticalShop_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadOpticalShop.DoWork
        FileOpticalReceipt()
    End Sub

    Private Sub BGLoadOpticalShop_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadOpticalShop.RunWorkerCompleted
        Me.MTakeoInventory.StatusLoading(False)
        BtnView.Enabled = True
    End Sub

    Private Sub BtnEditeDateReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditeDateReceipt.Click
        If GridReceipt.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim ReceiptDUpdate As New FindReceiptForUpdate
            ReceiptDUpdate.ReceiptNo.Text = GridReceipt.GetRow.Cells("ReceiptNo").Value
            ReceiptDUpdate.txtPatientName.Text = GridReceipt.GetRow.Cells("CusName").Value
            ReceiptDUpdate.DateReceipt.Checked = True
            ReceiptDUpdate.DateReceipt.Value = GridReceipt.GetRow.Cells("ReceiptDate").Value
            ReceiptDUpdate.LblSaveOption.Text = GridReceipt.GetRow.Cells("ReceiptNo").Value
            ReceiptDUpdate.LblOPTIDDetial.Text = GridReceipt.GetRow.Cells("ReceiptID").Value
            ReceiptDUpdate.ShowDialog()
            If ReceiptDUpdate.DialogResult = DialogResult.OK Then
                'FilterReceipt.Visible = True
                MTakeoInventory.StatusLoading(True)
                'RadWaitAndPaid.Checked = True
                BtnView.Enabled = False
                BGLoadOpticalShop.RunWorkerAsync()
                'If RadWaitAndPaid.Checked = True Then
                '    LoadingReceiptByDateWithWaitAndPaid(DateTo.Value, DateFrom.Value, 2)
                'Else
                '    LoadingReceiptByDateCancel(DateTo.Value, DateFrom.Value, 2)
                'End If
            End If
        End If
    End Sub

    Private Sub MainOpticalShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
        '    With TBLACCESS_ROLE.Rows(i)
        '        If .Item(0) = "Administrator" Then
        '            BtnEditeDateReceipt.Enabled = True
        '            BtnEditInvoice.Enabled = True
        '        Else
        '            BtnEditeDateReceipt.Enabled = False
        '            BtnEditInvoice.Enabled = False
        '            'ElseIf .Item(0) = "Administrator" Then
        '            '    AccRolesCashier = True
        '            '    Me.cmdCashierSave.Visible = True
        '            '    Me.cmdSave.Enabled = True
        '            '    ' Me.cmdPrint.Enabled = True
        '        End If
        '    End With
        'Next
    End Sub

    
    Private Sub BtnEditDonateOptical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditDonateOptical.Click

        If GridReceipt.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim EditDonateOpticalShop As New FormEditDonateOpticalShop
            EditDonateOpticalShop.LblOpticalShopID.Text = GridReceipt.GetRow.Cells("ReceiptID").Value
            EditDonateOpticalShop.TxtReceiptNo.Text = GridReceipt.GetRow.Cells("ReceiptNo").Value
            EditDonateOpticalShop.TxtPatientNo.Text = GridReceipt.GetRow.Cells("CustomerNo").Value
            EditDonateOpticalShop.CboDonation.SelectedValue = GridReceipt.GetRow.Cells("DonationID").Value
            If TypeOf GridReceipt.GetRow.Cells("DonateAmount").Value Is DBNull Then
            Else
                EditDonateOpticalShop.TxtDonateAmount.Text = GridReceipt.GetRow.Cells("DonateAmount").Value
            End If

            EditDonateOpticalShop.Txtname.Text = GridReceipt.GetRow.Cells("CusName").Value
            If EditDonateOpticalShop.ShowDialog() = DialogResult.OK Then
                BtnPrintInvoice_Click(sender, e)
            End If
        End If
        
    End Sub
End Class
