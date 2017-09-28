Public Class UCOpticalshopIncomStatement
    Dim DAOpticalShopIncomeS As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim ObjReportIncome As New CryIncomeOpticalShop
    Dim MTakeoInventory As MainTakeoInventory
    Sub New(ByVal MainForm As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MTakeoInventory = MainForm
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        Try
            RadAsTable.Checked = True
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
       
    End Sub
    Sub LoadingAndPreviewReport()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingAndPreviewReport))
        Else
            If RadAsTable.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 1)
            End If
            If RadViewReport.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False
                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 1)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome
            End If
            If RadReceiptCancel.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 2)
            End If
            If RadReportCancel.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False
                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataByDateWithPaid(DateFrom.Value, DateTo.Value, 2)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "List Of Receipt Cancel From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome
            End If

            If RadReceiptNil.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = False
                SplitContainerIncomstatement.Panel2Collapsed = True
                GridReceipt.DataSource = DAOpticalShopIncomeS.GetDataRecieptNilByDate(DateFrom.Value, DateTo.Value)
            End If

            If RadReportNil.Checked = True Then
                SplitContainerIncomstatement.Panel1Collapsed = True
                SplitContainerIncomstatement.Panel2Collapsed = False

                Dim TblIncomeStatementTem As DataTable = DAOpticalShopIncomeS.GetDataRecieptNilByDate(DateFrom.Value, DateTo.Value)
                ObjReportIncome.SetDataSource(TblIncomeStatementTem)
                ObjReportIncome.SetParameterValue("Title", "List Of Receipt Nil From:" & Format(DateFrom.Value, "dd/MM/yyyy") & " To:" & Format(DateTo.Value, "dd/MM/yyyy"))
                CryViewOpticalshopIncome.ReportSource = ObjReportIncome

            End If


        End If
    End Sub

    Private Sub RadViewReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadViewReport.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadAsTable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAsTable.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadReceiptCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptCancel.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub RadReportCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReportCancel.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        LoadingAndPreviewReport()
    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        MTakeoInventory.StatusLoading(False)
    End Sub

    Private Sub RadReceiptNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReceiptNil.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadReportNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReportNil.CheckedChanged
        Try
            MTakeoInventory.StatusLoading(True)
            BgLoadingReport.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

End Class
