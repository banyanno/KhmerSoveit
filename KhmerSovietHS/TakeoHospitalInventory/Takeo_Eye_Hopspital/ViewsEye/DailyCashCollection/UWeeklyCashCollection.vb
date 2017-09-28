Imports CrystalDecisions.Shared
Public Class UWeeklyCashCollection

    Dim TblCash As DataTable, _
    TblCashCount As DataTable, _
    TblCashCountTotal As DataTable, _
    TblCashTotalAll As DataTable, _
    TblRemarks As DataTable, _
    DFrom As Date, _
    DTo As Date
    Dim TOTALUSD, TOTALRIEL, TOTALUSDR, TOTALRIELR As Double
    Dim DAAccountPayable As New DSAccountPayableTableAdapters.V_ACCOUNT_PAYABLE_DETAILTableAdapter
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        '-------------------Weekly Cash Flow-----------------------------------
        DFrom = Me.dtpDateFrom.Value
        DTo = Me.dtpDateTo.Value
        PicLoad.Visible = True
        cmdView.Enabled = False
        BgWeekly.RunWorkerAsync()
        Me.GridAccountPayable.DataSource = DAAccountPayable.GetDataByDate(dtpDateFrom.Value, dtpDateTo.Value)
        'Me.dgvCash.DataSource = MCashCollectionWeekly.WeeklyCashCollection(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy"))
        ''--------------------Weekly Cash Count
        'Me.dgvCashCount.DataSource = MCashCollectionWeekly.SelectCashCountWeekly(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy"))
        ''--------------------Remarks or Account Receivable---------------
        'Me.dgvRemarks.DataSource = MCashCollectionWeekly.WeeklyRemarks(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy"))
    End Sub

    Private Sub CashCountTotal()
        Dim tblCashTotal As DataTable = MCashCollectionWeekly.SelectCashCountWeeklyTotalAllFinal(DFrom, DTo)
        Dim RowRem As DataRow
        Dim i, j As Integer
        If tblCashTotal.Rows.Count > 0 Then
            For j = 0 To tblCashTotal.Rows.Count - 1
                RowRem = tblCashTotal.Rows(j)
                With RowRem
                    TOTALUSD = IIf(IsDBNull(.Item(0)) = False, .Item(0), 0)
                    TOTALRIEL = IIf(IsDBNull(.Item(1)) = False, .Item(1), 0)
                End With
            Next
        End If
        ''---------------------Very manual on this code of Total Remarks Weekly-----------------------------
        Dim tblCashTotalR As DataTable = MCashCollectionWeekly.TotalDailyRemarksWeekly(DFrom, DTo)
        Dim RowRemR As DataRow
        If tblCashTotalR.Rows.Count > 0 Then
            For i = 0 To tblCashTotalR.Rows.Count - 1
                RowRemR = tblCashTotalR.Rows(i)
                With RowRemR
                    TOTALUSDR = IIf(IsDBNull(.Item(0)) = False, .Item(0), 0)
                    TOTALRIELR = IIf(IsDBNull(.Item(1)) = False, .Item(1), 0)
                End With
            Next
        End If
        'Me.txtTotalR.Text = TOTALUSD + TOTALUSDR
        'Me.txtTotalR.Text = TOTALRIEL + TOTALRIELR
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Try
        Me.cmdPrint.Enabled = False
        Dim frmReportCCW As New frmReportCashCountWeekly
        '-------------Report Form Active--------------------------------
        Dim ReportCCW As New ReportCashCountWeekly
        Dim TblAccoutPayable As DataTable = Me.DAAccountPayable.GetDataByDate(dtpDateFrom.Value, dtpDateTo.Value)
        ReportCCW.Subreports.Item("ReportCashCountWeekly").SetDataSource(MCashCollectionWeekly.ReportCashFlow(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy"), Format(Me.dtpDateTo.Value, "MM-dd-yyyy")).Tables(1))
        ReportCCW.Subreports.Item("ReportCashCount").SetDataSource(MCashCollectionWeekly.ReportCashCount(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy"), Format(Me.dtpDateTo.Value, "MM-dd-yyyy")).Tables(1))
        ReportCCW.Subreports.Item("ReportCashRemarks").SetDataSource(MCashCollectionWeekly.ReportCashRemarks(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy"), Format(Me.dtpDateTo.Value, "MM-dd-yyyy")).Tables(1))
        ReportCCW.Subreports.Item("ReportAccountPayable").SetDataSource(TblAccoutPayable)
        frmReportCCW.crvReportCashCountWeekly.ReportSource = ReportCCW
        ReportCCW.Refresh()
        '-------Parameter for Date from to date to-----------------
        Dim DateFromTo As ParameterField
        DateFromTo = ReportCCW.ParameterFields("txtDateFromTo")
        DateFromTo.CurrentValues.AddValue("Date: " & Format(Me.dtpDateFrom.Value, "dd/MM/yyyy") & " to: " & Format(Me.dtpDateTo.Value, "dd/MM/yyyy"))
        frmReportCCW.ShowDialog()
        Me.cmdPrint.Enabled = True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        'End Try
    End Sub

    Private Sub BgWeekly_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgWeekly.DoWork
        TblCash = MCashCollectionWeekly.WeeklyCashCollection(Format(DFrom, "MM/dd/yyyy"), Format(DTo, "MM/dd/yyyy"))
        ''--------------------Weekly Cash Count
        TblCashCount = MCashCollectionWeekly.SelectCashCountWeekly(Format(DFrom, "MM/dd/yyyy"), Format(DTo, "MM/dd/yyyy"))
        '---------------------Total Cash Count------------------------------------
        TblCashCountTotal = MCashCollectionWeekly.SelectCashCountWeeklyTotal(Format(DFrom, "MM/dd/yyyy"), Format(DTo, "MM/dd/yyyy"))
        '--------------------Total All--------------------------------------------------
        TblCashTotalAll = MCashCollectionWeekly.SelectCashCountWeeklyTotalAll(Format(DFrom, "MM/dd/yyyy"), Format(DTo, "MM/dd/yyyy"))
        ''--------------------Remarks or Account Receivable---------------
        TblRemarks = MCashCollectionWeekly.WeeklyRemarks(Format(DFrom, "MM/dd/yyyy"), Format(DTo, "MM/dd/yyyy"))
        'Call CashCountTotal()
        If Me.BgWeekly.CancellationPending = True Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub BgWeekly_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWeekly.RunWorkerCompleted
        Me.dgvCash.DataSource = TblCash
        ''--------------------Weekly Cash Count
        Me.dgvCashCount.DataSource = TblCashCount
        '---------------------Total Cash Count------------------------------------
        Me.dgvTotalCash.DataSource = TblCashCountTotal
        '----------------------Total All-------------------------------------------------
        Me.dgvCashTotalAll.DataSource = TblCashTotalAll
        ''--------------------Remarks or Account Receivable---------------
        Me.dgvRemarks.DataSource = TblRemarks
        cmdView.Enabled = True
        PicLoad.Visible = False
    End Sub

    Private Sub GridEX1_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles dgvTotalCash.FormattingRow

    End Sub
End Class
