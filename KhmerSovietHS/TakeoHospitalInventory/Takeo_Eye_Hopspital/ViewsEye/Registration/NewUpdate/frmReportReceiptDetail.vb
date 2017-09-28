Imports CrystalDecisions.Shared

Public Class frmReportReceiptDetail

    Dim IOP As Integer
    Dim ReportName As String = ""
    Dim Da_ReceiptNo As New DSPatientReceiptTableAdapters.RECEIPT_OTHERSTableAdapter
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If Me.chkConsltation.Checked = False And Me.chkFollowUp.Checked = False And Me.chkMedicine.Checked = False _
                And Me.chkGlasses.Checked = False And Me.chkOperation.Checked = False And Me.chkArtificialEye.Checked = False And Me.chkOthers.Checked = False And ChOtherReceipt.Checked = False Then
                MsgBox("Please select any condition to print.", MsgBoxStyle.Information, "Print confirm")
                Exit Sub
            End If
            Me.cmdPrint.Enabled = False
            Dim frmReportIP As New frmReportReceiptIP
            '-------------Report Form Active--------------------------------
            Dim ReportIP As New ReportReceiptIP
            Dim ReportCR As New ReportReceiptDetailCR
            If Me.chkConsltation.Checked = True Then
                ReportName = "Consultation Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailNP(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkFollowUp.Checked = True Then
                ReportName = "Follow up Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailOP(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkOperation.Checked = True And Me.chkArtificialEye.Checked = True And Me.chkOthers.Checked = True Then
                ReportName = "Inpatient Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkOperation.Checked = True And Me.chkArtificialEye.Checked = True Then
                ReportName = "Operation and Artificial Eye Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_OP_AE(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkOperation.Checked = True And Me.chkOthers.Checked = True Then
                ReportName = "Operation and Others Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_OP_OT(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkArtificialEye.Checked = True And Me.chkOthers.Checked = True Then
                ReportName = "Artificial and Others Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_AE_OT(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkOperation.Checked = True Then
                ReportName = "Operation Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_OP(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkArtificialEye.Checked = True Then
                ReportName = "Artificial Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_AE(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkOthers.Checked = True Then
                ReportName = "Others Fees Receipt"
                ReportIP.SetDataSource(MReportReceiptDetail.ReportReceiptDetailIP_OT(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkMedicine.Checked = True And Me.chkGlasses.Checked = True Then
                ReportName = "Cash Receipt"
                ReportCR.SetDataSource(MReportReceiptDetail.ReportReceiptDetailCR(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkMedicine.Checked = True Then
                ReportName = "Medicine Fees Receipt"
                ReportCR.SetDataSource(MReportReceiptDetail.ReportReceiptDetailCR_MED(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf Me.chkGlasses.Checked = True Then
                ReportName = "Glasses Fees Receipt"
                ReportCR.SetDataSource(MReportReceiptDetail.ReportReceiptDetailCR_GLA(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), Format(Me.dtpDateTo.Value, "MM/dd/yyyy")).Tables(1))
            ElseIf ChOtherReceipt.Checked = True Then
                IOP = 2
                ReportName = "Other Cash Receipt"
                Dim RDailOtherReceipt As New ReportDialyOtherReceipt
                Dim TblCashDialy As DataTable = Da_ReceiptNo.SelectCashDialyReport(dtpDateFrom.Value.Date, dtpDateTo.Value.Date)
                RDailOtherReceipt.SetDataSource(TblCashDialy)
                frmReportIP.crvReportReceiptIP.ReportSource = RDailOtherReceipt
                RDailOtherReceipt.SetParameterValue("Title", "From :" & Format(dtpDateFrom.Value.Date, "dd-MM-yyyy") & " To: " & Format(dtpDateTo.Value.Date, "dd-MM-yyyy"))
            End If
            If IOP = 1 Then
                frmReportIP.crvReportReceiptIP.ReportSource = ReportIP
                ReportIP.Refresh()
                '-------Parameter for Date from to date to-----------------
                Dim DateFromTo As ParameterField
                Dim StrReportName As ParameterField
                DateFromTo = ReportIP.ParameterFields("txtDateFromTo")
                DateFromTo.CurrentValues.AddValue("Date: " & Format(Me.dtpDateFrom.Value, "dd/MM/yyyy") & " to: " & Format(Me.dtpDateTo.Value, "dd/MM/yyyy"))
                StrReportName = ReportIP.ParameterFields("txtReportName")
                StrReportName.CurrentValues.AddValue(ReportName)
            ElseIf 2 Then

            Else
                frmReportIP.crvReportReceiptIP.ReportSource = ReportCR
                ReportCR.Refresh()
                '-------Parameter for Date from to date to-----------------
                Dim DateFromTo As ParameterField
                Dim StrReportName As ParameterField
                DateFromTo = ReportCR.ParameterFields("txtDateFromTo")
                DateFromTo.CurrentValues.AddValue("Date: " & Format(Me.dtpDateFrom.Value, "dd/MM/yyyy") & " to: " & Format(Me.dtpDateTo.Value, "dd/MM/yyyy"))
                StrReportName = ReportCR.ParameterFields("txtReportName")
                StrReportName.CurrentValues.AddValue(ReportName)
            End If
            frmReportIP.ShowDialog()
            Me.cmdPrint.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkConsltation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConsltation.CheckedChanged
        If Me.chkConsltation.Checked = True Then
            IOP = 1
            Me.chkFollowUp.Checked = False

            Me.chkMedicine.Checked = False
            Me.chkGlasses.Checked = False

            Me.chkOperation.Checked = False
            Me.chkArtificialEye.Checked = False
            Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkFollowUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFollowUp.CheckedChanged
        If Me.chkFollowUp.Checked = True Then
            IOP = 1
            Me.chkConsltation.Checked = False

            Me.chkMedicine.Checked = False
            Me.chkGlasses.Checked = False

            Me.chkOperation.Checked = False
            Me.chkArtificialEye.Checked = False
            Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkMedicine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicine.CheckedChanged
        If Me.chkMedicine.Checked = True Then
            IOP = 2
            Me.chkConsltation.Checked = False
            Me.chkFollowUp.Checked = False

            'Me.chkGlasses.Checked = False

            Me.chkOperation.Checked = False
            Me.chkArtificialEye.Checked = False
            Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkGlasses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGlasses.CheckedChanged
        If Me.chkGlasses.Checked = True Then
            IOP = 2
            Me.chkConsltation.Checked = False
            Me.chkFollowUp.Checked = False

            'Me.chkMedicine.Checked = False

            Me.chkOperation.Checked = False
            Me.chkArtificialEye.Checked = False
            Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkOperation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOperation.CheckedChanged
        If Me.chkOperation.Checked = True Then
            IOP = 1
            Me.chkConsltation.Checked = False
            Me.chkFollowUp.Checked = False

            Me.chkMedicine.Checked = False
            Me.chkGlasses.Checked = False

            'Me.chkArtificialEye.Checked = False
            'Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkArtificialEye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkArtificialEye.CheckedChanged
        If Me.chkArtificialEye.Checked = True Then
            IOP = 1
            Me.chkConsltation.Checked = False
            Me.chkFollowUp.Checked = False

            Me.chkMedicine.Checked = False
            Me.chkGlasses.Checked = False

            'Me.chkOperation.Checked = False
            'Me.chkOthers.Checked = False
        End If
    End Sub

    Private Sub chkOthers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOthers.CheckedChanged
        If Me.chkOthers.Checked = True Then
            IOP = 1
            Me.chkConsltation.Checked = False
            Me.chkFollowUp.Checked = False

            Me.chkMedicine.Checked = False
            Me.chkGlasses.Checked = False

            'Me.chkOperation.Checked = False
            'Me.chkArtificialEye.Checked = False
        End If
    End Sub
End Class