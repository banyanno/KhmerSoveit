Public Class UCMainAcountPayable

    Dim DAAccountPayable As New DSAccountPayableTableAdapters.V_ACCOUNT_PAYABLE_DETAILTableAdapter
    Dim MTakeoInventory As MainTakeoInventory


    Public Sub New(ByVal MTakeoInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnNewPayAble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewPayAble.Click
        Dim FPayable As New FormNewAccountPayable
        If FPayable.ShowDialog = DialogResult.OK Then
            ViewAccountPayableByDate(DateFrom.Value, DateTo.Value)
        End If
    End Sub

    Private Sub BtnMainAccountPayable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMainAccountPayable.Click
        Dim FMainAccountPayable As New FormMainName
        If FMainAccountPayable.ShowDialog = DialogResult.OK Then

        End If
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        ViewAccountPayableByDate(DateFrom.Value, DateTo.Value)
    End Sub
    Sub ViewAccountPayableByDate(ByVal dateFrom As DateTime, ByVal dateTo As DateTime)
        GridAccountPayable.DataSource = DAAccountPayable.GetDataByDate(dateFrom, dateTo)
    End Sub

    Private Sub GridAccountPayable_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAccountPayable.RowDoubleClick
        Dim FPayable As New FormNewAccountPayable
        FPayable.LblSaveOption.Text = GridAccountPayable.GetRow.Cells("ACC_PAID_ID").Value
        FPayable.CboAccountName.SelectedValue = GridAccountPayable.GetRow.Cells("ACCOUNTID").Value
        FPayable.DatePaidAble.Checked = True
        FPayable.DatePaidAble.Value = GridAccountPayable.GetRow.Cells("DATE_PAID").Value
        If CBool(GridAccountPayable.GetRow.Cells("IS_DOLAR").Value) = True Then
            FPayable.ChDolar.Checked = CBool(GridAccountPayable.GetRow.Cells("IS_DOLAR").Value)
            FPayable.TxtAmountDolar.Text = GridAccountPayable.GetRow.Cells("AMOUNT_DOLAR").Value
        End If
        If CBool(GridAccountPayable.GetRow.Cells("IS_RIEL").Value) = True Then
            FPayable.ChRiel.Checked = CBool(GridAccountPayable.GetRow.Cells("IS_RIEL").Value)
            FPayable.TxtAmountRiel.Text = GridAccountPayable.GetRow.Cells("AMOUNT_REAL").Value
        End If
        If TypeOf GridAccountPayable.GetRow.Cells("DESCRIPTION").Value Is DBNull Then
        Else
            FPayable.TxtDescription.Text = GridAccountPayable.GetRow.Cells("DESCRIPTION").Value
        End If

        If FPayable.ShowDialog = DialogResult.OK Then
            ViewAccountPayableByDate(DateFrom.Value, DateTo.Value)
        End If
    End Sub

    Private Sub GridAccountPayable_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridAccountPayable.SelectionChanged
        If UserGlobleVariable.DEPART_NAME <> "Administrator" Then
            BtnDelete.Enabled = False
            BtnUndoDelete.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If GridAccountPayable.SelectedItems.Count = 0 Then Exit Sub
        Dim OpticalIMP As New OpticalshopImp
        Dim ObjPayable As ACCOUNT_PAYABLE_DETAIL = OpticalIMP.GetPaidAccountPayable(GridAccountPayable.GetRow.Cells("ACC_PAID_ID").Value)
        ObjPayable.IS_DELETE = True
        If MessageBox.Show("Do you want delete this payable?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            OpticalIMP.UpdateReceiptPay()
            ViewAccountPayableByDate(DateFrom.Value, DateTo.Value)
        End If
    End Sub

    Private Sub BtnUndoDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoDelete.Click
        If GridAccountPayable.SelectedItems.Count = 0 Then Exit Sub
        Dim OpticalIMP As New OpticalshopImp
        Dim ObjPayable As ACCOUNT_PAYABLE_DETAIL = OpticalIMP.GetPaidAccountPayable(GridAccountPayable.GetRow.Cells("ACC_PAID_ID").Value)
        ObjPayable.IS_DELETE = False
        If MessageBox.Show("Do you want delete this payable?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            OpticalIMP.UpdateReceiptPay()
            ViewAccountPayableByDate(DateFrom.Value, DateTo.Value)
        End If
    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click

        '---- print request order ----------
        MTakeoInventory.StatusLoading(True)
        Application.DoEvents()
        Dim FRptRequestView As New frmReportViewer
        FRptRequestView.ReportOption = 15
        FRptRequestView.FDate = DateFrom.Value
        FRptRequestView.TDate = DateTo.Value
        MTakeoInventory.StatusLoading(False)

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If

    End Sub

End Class
