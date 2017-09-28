Public Class CUReferMain

    Dim DFromRefer As Date
    Dim DToRefer As Date
    Dim TblTem As DataTable
    Dim CryReferTo As New CRPatientRefer
    Dim CryReferToByDiagnosis As New CryPatientReferToByDiagnosis
    Dim CryTem As Object
    Dim ReferToName As String = ""
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboReferTo
            .DataSource = ModRefer.SelectRefer()
            .ValueMember = "ReferNo"
            .DisplayMember = "Refer"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        ShowSplitPanel(SplitPatientReferTo, 1)
        GridListReferTo.DataSource = ModRefer.SelectReferTo(TxtPatientNo.Text, DFrom.Value, DTo.Value)

    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub DeletePatientReferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePatientReferToolStripMenuItem.Click
        'Try
        '    Dim dialogResult As DialogResult = MessageBox.Show("Do you realy want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    Dim Rowindex As Integer = ModCommon.GetRowIndexDataGrid(GridResultRefer)
        '    Dim ReferToNo As Integer = GridResultRefer.Rows(Rowindex).Cells("ReferNo").Value
        '    If dialogResult = Windows.Forms.DialogResult.Yes Then
        '        If ModRefer.DeleteReferTo(ReferToNo) = 1 Then
        '            MsgBox("Delete patient refer successful!", MsgBoxStyle.Information, "Delete")
        '            GridResultRefer.DataSource = ModRefer.SelectReferTo(TxtPatientNo.Text, DFrom.Value, DTo.Value)
        '            ModCommon.NumberAllRowHeaderDataGrid(GridResultRefer)
        '        Else
        '            MsgBox("Error Delete refer to!", MsgBoxStyle.Critical, "Error")
        '        End If
        '    End If


        'Catch ex As Exception

        'End Try

    End Sub


   
    Private Sub GridListReferTo_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridListReferTo.RowDoubleClick
        Try
            Dim FPatientRefer As New FrmRefer
            FPatientRefer.LblSaveOption.Text = e.Row.Cells(0).Value
            FPatientRefer.DateRefer.Checked = True
            FPatientRefer.DateRefer.Value = e.Row.Cells(10).Value
            FPatientRefer.TxtPatientNo.Text = e.Row.Cells(2).Value
            FPatientRefer.TxtPatientName.Text = e.Row.Cells(4).Value
            FPatientRefer.TxtAge.Text = e.Row.Cells(5).Value
            FPatientRefer.TxtSex.Text = e.Row.Cells(6).Value
            FPatientRefer.CboRefer.Text = e.Row.Cells(9).Value
            Try
                FPatientRefer.CboDiagnosis.Text = e.Row.Cells(1).Value
            Catch ex As Exception
                FPatientRefer.CboDiagnosis.Text = ""
            End Try

            FPatientRefer.TxtAddress.Text = e.Row.Cells(7).Value
            FPatientRefer.TxtNote.Text = e.Row.Cells(11).Value

            FPatientRefer.ShowDialog()
            If FPatientRefer.isClosed = True Then
                GridListReferTo.DataSource = ModRefer.SelectReferTo(TxtPatientNo.Text, DFrom.Value, DTo.Value)
            End If
        Catch ex As Exception

        End Try

    End Sub
    
    Private Sub BtnPrintRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRefer.Click
        ShowSplitPanel(SplitPatientReferTo, 0)
        DFromRefer = DateReferFrom.Value
        DToRefer = DateReferTo.Value
        PictLoading.Visible = True
        ReferToName = CboReferTo.Text
        BgLoadReport.RunWorkerAsync()
    End Sub

    Private Sub BgLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReport.DoWork
        LoadReport()
    End Sub
    Sub LoadReport()
        If ChViewBy.Checked = True Then
            If RadViewAllRefer.Checked = True Then
                TblTem = Me.TblReferToByDiagnosisTableAdapter.GetData(DToRefer, DFromRefer)
            Else
                TblTem = Me.TblReferToByDiagnosisTableAdapter.GetDataByReferTo(ReferToName, DFromRefer, DToRefer)
            End If

        Else
            TblTem = Me.V_PatientReferTableAdapter.GetData(DFromRefer, DToRefer)
        End If
    End Sub
    Sub EnableCriterail(ByVal enable As Boolean)
        RadViewAllRefer.Enabled = enable
        RadViewByRefer.Enabled = enable
        CboReferTo.Enabled = enable
    End Sub
    Private Sub BgLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReport.RunWorkerCompleted
        If ChViewBy.Checked = True Then
            If RadViewAllRefer.Checked = True Then
                CryReferToByDiagnosis.SetDataSource(TblTem)
                CryReferToByDiagnosis.SetParameterValue("Title", "Report Refer To Date from " & Format(DFromRefer, "dd/MM/yyyy") & " To " & Format(DToRefer, "dd/MM/yyyy") & " By age and diagnosis.")
                CReportViewer.ReportSource = CryReferToByDiagnosis
            Else
                CryReferToByDiagnosis.SetDataSource(TblTem)
                CryReferToByDiagnosis.SetParameterValue("Title", "Report Refer To Date from " & Format(DFromRefer, "dd/MM/yyyy") & " To " & Format(DToRefer, "dd/MM/yyyy") & " By " & ReferToName)
                CReportViewer.ReportSource = CryReferToByDiagnosis
            End If
            
        Else
            CryReferTo.SetDataSource(TblTem)
            CryReferTo.SetParameterValue("Title", "Report Refer To Date from " & Format(DFromRefer, "dd/MM/yyyy") & " To " & Format(DToRefer, "dd/MM/yyyy"))
            CReportViewer.ReportSource = CryReferTo
        End If
        PictLoading.Visible = False
    End Sub

    Private Sub ChViewBy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChViewBy.CheckedChanged
        EnableCriterail(ChViewBy.Checked)
    End Sub
End Class
