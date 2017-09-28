Public Class FormCashReceive
    Dim DA_OtherReceipt As New DSPatientReceiptTableAdapters.RECEIPT_OTHERSTableAdapter
    Dim Da_ReceiptNo As New DSPatientReceiptTableAdapters.RECEIPT_OTHERSTableAdapter
    Dim DA_PatientReceipt As New DSPatientReceiptTableAdapters.tblPatientReceiptTableAdapter
    Dim Val_PreviewData As Integer
    Private Sub BtnClientList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientList.Click
        Dim CList As New ClientList
        CList.ShowDialog()
    End Sub

    Private Sub BtnNewReceiptOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReceiptOther.Click
        Dim OtherReceived As New NewCashReceived
        OtherReceived.txtReceiptNumber.Text = MCashReceipt.getMaxID()
        If OtherReceived.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridOtherReceipt.DataSource = DA_OtherReceipt.SelectByReceiptNo(OtherReceived.txtReceiptNumber.Text)
        End If
    End Sub
 

    Private Sub FormCashReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Val_PreviewData = 1
        BgLoadCashOtherReceipt.RunWorkerAsync()
    End Sub
    Private Sub PreviewData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewData))

        Else
            MainForm.StatusLoading(True)
            If Val_PreviewData = 1 Then
                If TxtReceiptNo.Text.Trim = "" Then
                    GridOtherReceipt.DataSource = DA_OtherReceipt.SelectDateToDate(RDateFrom.Value.Date, RDateTo.Value.Date)
                Else
                    GridOtherReceipt.DataSource = DA_OtherReceipt.SelectDateToDateWithReceiptNo(RDateFrom.Value.Date, RDateTo.Value.Date, TxtReceiptNo.Text)
                End If
            End If
            If Val_PreviewData = 2 Then
                Try
                    Dim ROtherReceipt As New ReportOtherReceipt
                    Dim TblTemReceipt As DataTable = Da_ReceiptNo.SelectByReceiptNo(GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
                    ROtherReceipt.SetDataSource(TblTemReceipt)
                    ROtherReceipt.PrintToPrinter(1, False, 1, 1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Other Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
               
            End If
            If Val_PreviewData = 3 Then
                SplitOtherCash.Panel1Collapsed = True
                SplitOtherCash.Panel2Collapsed = False
                Dim RDailOtherReceipt As New ReportDialyOtherReceipt
                Dim TblCashDialy As DataTable = Da_ReceiptNo.SelectCashDialyReport(RDateFrom.Value.Date, RDateTo.Value.Date)
                RDailOtherReceipt.SetDataSource(TblCashDialy)
                CRViewerOtherReceipt.ReportSource = RDailOtherReceipt
                RDailOtherReceipt.SetParameterValue("Title", "From :" & Format(RDateFrom.Value.Date, "dd-MM-yyyy") & " To: " & Format(RDateTo.Value.Date, "dd-MM-yyyy"))
            End If
            

        End If
    End Sub

    Private Sub BgLoadCashOtherReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadCashOtherReceipt.DoWork
        PreviewData()
    End Sub

    Private Sub BgLoadCashOtherReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadCashOtherReceipt.RunWorkerCompleted
        MainForm.StatusLoading(False)
    End Sub



  
    Private Sub BtnPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReceipt.Click
        If GridOtherReceipt.SelectedItems.Count = 0 Then Exit Sub
        Val_PreviewData = 2
        BgLoadCashOtherReceipt.RunWorkerAsync()
    End Sub

    Private Sub TxtReceiptNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtReceiptNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub GridOtherReceipt_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridOtherReceipt.RowDoubleClick
        Dim OtherReceived As New NewCashReceived
        OtherReceived.lblSaveOption.Text = GridOtherReceipt.GetRow.Cells("R_OTHERID").Value
        OtherReceived.txtReceiptNumber.Text = GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value
        OtherReceived.DateReceiptIn.Checked = True
        OtherReceived.DateReceiptIn.Value = GridOtherReceipt.GetRow.Cells("RECEIPT_OTHTER_DATE").Value
        OtherReceived.CboReceivedFrom.SelectedValue = GridOtherReceipt.GetRow.Cells("CLIENT_ID").Value
        OtherReceived.TxtPatientKHName.Text = GridOtherReceipt.GetRow.Cells("CLIENT_NAME_ENG").Value
        Try
            OtherReceived.txtAmountWord.Text = GridOtherReceipt.GetRow.Cells("AmoutWord").Value
        Catch ex As Exception
            OtherReceived.txtAmountWord.Text = ""
        End Try

        If GridOtherReceipt.GetRow.Cells("IS_DOLAR").Value = True Then
            OtherReceived.RadDolar.Checked = True
            OtherReceived.TxtCashReceived.Text = GridOtherReceipt.GetRow.Cells("CLIENT_PAID_DOLAR").Value
        Else
            OtherReceived.RadReil.Checked = True
            OtherReceived.TxtCashReceived.Text = GridOtherReceipt.GetRow.Cells("CLIENT_PAID_REIL").Value
        End If
        If OtherReceived.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridOtherReceipt.DataSource = DA_OtherReceipt.SelectByReceiptNo(GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
        End If
    End Sub

    
    Private Sub BtnDeleteReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteReceipt.Click
        If GridOtherReceipt.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete this receipt", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_OtherReceipt.DeleteReceiptOther(True, GridOtherReceipt.GetRow.Cells("R_OTHERID").Value) Then
                DA_PatientReceipt.DeletePatientReceipt("1", GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
                GridOtherReceipt.DataSource = DA_OtherReceipt.SelectByReceiptNo(GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
            End If
        End If
    End Sub

    Private Sub BtnUndoReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoReceipt.Click
        If GridOtherReceipt.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want delete this receipt", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_OtherReceipt.DeleteReceiptOther(False, GridOtherReceipt.GetRow.Cells("R_OTHERID").Value) = 1 Then
                DA_PatientReceipt.DeletePatientReceipt("0", GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
                GridOtherReceipt.DataSource = DA_OtherReceipt.SelectByReceiptNo(GridOtherReceipt.GetRow.Cells("RECEIP_NO").Value)
            End If
        End If
    End Sub

  
    Private Sub BtnPrintReportOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReportOther.Click

        Val_PreviewData = 3
        BgLoadCashOtherReceipt.RunWorkerAsync()
    End Sub

    Private Sub TBtnViewDiale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBtnViewDiale.Click
        SplitOtherCash.Panel1Collapsed = False
        SplitOtherCash.Panel2Collapsed = True
        Val_PreviewData = 1
        BgLoadCashOtherReceipt.RunWorkerAsync()
    End Sub
End Class