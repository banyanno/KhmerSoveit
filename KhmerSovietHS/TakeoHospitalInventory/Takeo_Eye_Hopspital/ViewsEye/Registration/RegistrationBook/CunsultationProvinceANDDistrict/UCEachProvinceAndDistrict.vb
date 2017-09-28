Public Class UCEachProvinceAndDistrict
    Dim startDate As DateTime
    Dim Months As Integer
    Dim Years As Integer
    Dim CRConsultation As New CRConsultationEachProvince
    Dim CRProvinceDiagnosis As New CRProvinceDiagnosis
    Dim TblConsultation, TblProvinceDiagnosis As DataTable
    Dim DFrom, DTo As Date
    Dim MainInventory As MainTakeoInventory
    Sub New(ByVal MainInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
        CboYear1.SelectedIndex = 0
        Me.MainInventory = MainInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadData.Click
        ModCommon.ShowSplitPanel(SplitContainerReport, 1)
        BtnLoadData.Enabled = False
        startDate = DateTime.Now
        ProgrestData.Visible = True
        Months = CboMonth.SelectedIndex + 1
        Years = CboYear.Text
        ' Do search action

        bgPatient.RunWorkerAsync()


        TimerSearchPatien.Start()


    End Sub

    Private Sub bgPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgPatient.DoWork

        'Me.SetDataObjects()
        Me.TblProvincesTableAdapter.Fill(Me.DSProvinceAndDistrict.tblProvinces)
        Me.V_CosultationEachProvinceTableAdapter.FillBy(Me.DSProvinceAndDistrict.V_CosultationEachProvince, Months, Years)
        If (bgPatient.CancellationPending) Then ' Test if user hit Cancel key
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub bgPatient_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgPatient.ProgressChanged
        ProgrestData.Value = e.ProgressPercentage
    End Sub

    Private Sub bgPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgPatient.RunWorkerCompleted
        ProgrestData.Value = 100
        BtnLoadData.Enabled = True
        ProgrestData.Visible = False
        ProgrestData.Value = 0
        TimerSearchPatien.Stop()
    End Sub

    Private Sub TimerSearchPatien_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSearchPatien.Tick
        Dim ts As TimeSpan = DateTime.Now.Subtract(startDate)
        lblTimeShowData.Text = "Time Load Data..." & ts.Minutes.ToString("00") & _
        ":" & ts.Seconds.ToString("00") & _
        ":" + ts.Milliseconds.ToString("000")
        If (ProgrestData.Value = ProgrestData.Maximum) Then
            ProgrestData.Value = 0
        End If
        ProgrestData.PerformStep()
    End Sub

   
    Private Sub GridConsultationEachProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridConsultationEachProvince.Click
        'If GridConsultationEachProvince.SelectedItems.Count = 0 Then
        '    Exit Sub
        'Else
        '    ModCommon.ShowSplitPanel(SplitContainerReport, 1)
        '    Dim Province As String = GridConsultationEachProvince.GetRow.Cells("Province").Value  '.SelectedItems(0).GetRow.Cells("Province").Value
        '    Me.V_DiagnosisByDistrictTableAdapter.Fill(Me.DSProvinceAndDistrict.V_DiagnosisByDistrict, Months, Years, Province)
        'End If

        ''If GridConsultationEachProvince.SelectedItems(0).Table.Key = "ViewForEachProvince" Then
        ''    Dim District As String = GridConsultationEachProvince.GetRow.Cells("Province").Value  '.SelectedItems(0).GetRow.Cells("Province").Value
        ''    Me.V_DiagnosisByDistrictTableAdapter.Fill(Me.DSProvinceAndDistrict.V_DiagnosisByDistrict, District, Months, Years)
        ''Else
        ''    Exit Sub
        ''End If
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        ModCommon.ShowSplitPanel(SplitContainerReport, 0)
        Years = CboYear1.Text
        CRVConsultation.DisplayToolbar = True
        BtnPrintPreview.Enabled = False
        Me.MainInventory.StatusLoading(True)
        BgReportConsultation.RunWorkerAsync()
    End Sub

    Private Sub BgLoadReport_DoWork_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgReportConsultation.DoWork
        TblConsultation = Me.TblConsultationEachTableAdapter.GetData(Years)
    End Sub

    Private Sub BgLoadReport_RunWorkerCompleted_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgReportConsultation.RunWorkerCompleted
        CRConsultation.SetDataSource(TblConsultation)
        CRVConsultation.ReportSource = CRConsultation
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("CONSULTATIONS( NEW AND FOLLOW UP) EACH PROVINCE AND DISTRICT YEAR:" & CboYear.Text)
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVConsultation.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CRConsultation.Refresh()
        BtnPrintPreview.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub


   
   
    Private Sub BtnPrintPreview1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview1.Click
        ModCommon.ShowSplitPanel(SplitContainerReport, 0)
        DFrom = DateFrom.Value
        DTo = DateTo.Value
        DTo = DateTo.Value
        CRVConsultation.DisplayToolbar = True
        BgReportProviceDiagnosis.RunWorkerAsync()
        BtnPrintPreview1.Enabled = False
        Me.MainInventory.StatusLoading(True)
    End Sub

    Private Sub BgReportProviceDiagnosis_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgReportProviceDiagnosis.RunWorkerCompleted
        CRProvinceDiagnosis.SetDataSource(TblProvinceDiagnosis)
        CRVConsultation.ReportSource = CRProvinceDiagnosis
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Statistics Diagnosis Each Province and District From " & DateFrom.Text & " To " & DateTo.Text)
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVConsultation.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CRProvinceDiagnosis.Refresh()
        CRVConsultation.Zoom(75)
        BtnPrintPreview1.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub

    Private Sub BgReportProviceDiagnosis_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgReportProviceDiagnosis.DoWork
        TblProvinceDiagnosis = Me.DTblProvinceReportTableAdapter.GetDataByMonth(DTo, DFrom)
    End Sub

    Private Sub GridConsultationEachProvince_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridConsultationEachProvince.SelectionChanged
        If GridConsultationEachProvince.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            ModCommon.ShowSplitPanel(SplitContainerReport, 1)
            Dim Province As String = GridConsultationEachProvince.GetRow.Cells("Province").Value  '.SelectedItems(0).GetRow.Cells("Province").Value
            Me.V_DiagnosisByDistrictTableAdapter.Fill(Me.DSProvinceAndDistrict.V_DiagnosisByDistrict, Months, Years, Province)
        End If
    End Sub
End Class
