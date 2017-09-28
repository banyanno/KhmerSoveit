Public Class FrmVAReport

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Dim CVAL As New CryMainLeft
    Dim CVAR As New CryMainRight
    Dim CMainVA As New CryMainVA
    Dim tblPlain As DataTable
    Dim tblPh As DataTable
    Dim tblGlasses As DataTable
    Dim month, year As Integer
    Dim DFrom, DMainFrom As Date
    Dim DTo, DMainTo As Date

    Private Sub BtnByMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnByMonth.Click
        BtnByMonth.Enabled = False
        PicLoadReport.Visible = True
        month = CboMonth.SelectedIndex + 1
        year = CboYear.Text
        BgLoadVAByMonth.RunWorkerAsync()
    End Sub

    Sub ShowReportsByMonth()
        If Me.rdLeftEye.Checked = True Then
            CVAL.Subreports.Item("VAPlain").SetDataSource(tblPlain)
            CVAL.Subreports.Item("VAPH").SetDataSource(tblPh)
            CVAL.Subreports.Item("VAGlasses").SetDataSource(tblGlasses)
            Dim Titles As CrystalDecisions.Shared.ParameterField
            Titles = CVAL.ParameterFields("Title")
            Titles.CurrentValues.AddValue("Visual Acuity on Left Eye by month: " & CboMonth.Text & ", " & CboYear.Text)
            CrvVAReport.ReportSource = CVAL
        Else
            CVAR.Subreports.Item("VAPlain").SetDataSource(tblPlain)
            CVAR.Subreports.Item("VAPH").SetDataSource(tblPh)
            CVAR.Subreports.Item("VAGlasses").SetDataSource(tblGlasses)
            Dim Titles As CrystalDecisions.Shared.ParameterField
            Titles = CVAR.ParameterFields("Title")
            Titles.CurrentValues.AddValue("Visual Acuity on Right Eye by month: " & CboMonth.Text & ", " & CboYear.Text)
            CrvVAReport.ReportSource = CVAR
        End If
    End Sub

    Sub ShowReportsByDate()
        If Me.rdLeftEye.Checked = True Then
            CVAL.Subreports.Item("VAPlain").SetDataSource(tblPlain)
            CVAL.Subreports.Item("VAPH").SetDataSource(tblPh)
            CVAL.Subreports.Item("VAGlasses").SetDataSource(tblGlasses)
            Dim Titles As CrystalDecisions.Shared.ParameterField
            Titles = cVAL.ParameterFields("Title")
            Titles.CurrentValues.AddValue("Visual Acuity on Left Eye by date between : " & Format(DateFrom.Value, "dd/MM/yyyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
            CrvVAReport.ReportSource = cVAL
        Else
            CVAR.Subreports.Item("VAPlain").SetDataSource(tblPlain)
            CVAR.Subreports.Item("VAPH").SetDataSource(tblPh)
            CVAR.Subreports.Item("VAGlasses").SetDataSource(tblGlasses)
            Dim Titles As CrystalDecisions.Shared.ParameterField
            Titles = cVAR.ParameterFields("Title")
            Titles.CurrentValues.AddValue("Visual Acuity on Right Eye by date between : " & Format(DateFrom.Value, "dd/MM/yyyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
            CrvVAReport.ReportSource = cVAR
        End If
    End Sub

    Private Sub BgLoadVAByMonth_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadVAByMonth.DoWork
        If Me.rdLeftEye.Checked = True Then
            tblPlain = Me.TblVAPlainTableAdapter.GetData(year, month)
            tblPh = Me.TblVAPHTableAdapter.GetData(year, month)
            tblGlasses = Me.TblVAGlassesTableAdapter.GetData(year, month)
        Else
            tblPlain = Me.TblVAPlainRightTableAdapter.GetData(year, month)
            tblPh = Me.TblVAPHRightTableAdapter.GetData(year, month)
            tblGlasses = Me.TblVAGlassesRightTableAdapter.GetData(year, month)
        End If
       
    End Sub

    Private Sub BgLoadVAByMonth_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadVAByMonth.RunWorkerCompleted
        Call ShowReportsByMonth()
        'Dim myArrayList As ArrayList = New ArrayList()
        'myArrayList.Add("Visual Acuity by month: " & CboMonth.Text & ", " & CboYear.Text)
        'Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CrvVAReport.ParameterFieldInfo
        'ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        BtnByMonth.Enabled = True
        PicLoadReport.Visible = False
    End Sub

    Private Sub BgLoadVAByDate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadVAByDate.DoWork
        If Me.rdLeftEye.Checked = True Then
            tblPlain = Me.TblVAPlainTableAdapter.GetDataByDate(DTo, DFrom)
            tblPh = Me.TblVAPHTableAdapter.GetDataByDate(DTo, DFrom)
            tblGlasses = Me.TblVAGlassesTableAdapter.GetDataByDate(DTo, DFrom)
        Else
            tblPlain = Me.TblVAPlainRightTableAdapter.GetDataByDate(DTo, DFrom)
            tblPh = Me.TblVAPHRightTableAdapter.GetDataByDate(DTo, DFrom)
            tblGlasses = Me.TblVAGlassesRightTableAdapter.GetDataByDate(DTo, DFrom)
        End If
    End Sub

    Private Sub BgLoadVAByDate_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadVAByDate.RunWorkerCompleted
        Call ShowReportsByDate()
        'Dim myArrayList As ArrayList = New ArrayList()
        'myArrayList.Add("Visual Acuity by date between : " & Format(DateFrom.Value, "dd/MM/yyyy") & " To: " & Format(DateTo.Value, "dd/MM/yyyy"))
        'Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CrvVAReport.ParameterFieldInfo
        'ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        BtnPrintByBetween.Enabled = True
        PicLoadReport.Visible = False
    End Sub

    Private Sub BtnPrintByBetween_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintByBetween.Click
        BtnPrintByBetween.Enabled = False
        PicLoadReport.Visible = True
        DFrom = DateFrom.Value
        DTo = DateTo.Value
        BgLoadVAByDate.RunWorkerAsync()
    End Sub


    Private Sub BtnPrintMain1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintMain1.Click
        BtnPrintMain1.Enabled = False
        PicLoadReport.Visible = True
        month = CboMainMonth.SelectedIndex + 1
        year = CboMainYear.Text
        BgMainByMonth.RunWorkerAsync()
    End Sub

    Private Sub BgMainByMonth_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgMainByMonth.DoWork
        tblPlain = Me.TblMainPlainTableAdapter.GetData(year, month)
        tblPh = Me.TblMainPhTableAdapter.GetData(year, month)
        tblGlasses = Me.TblMainGlassesTableAdapter.GetData(year, month)
        If e.Cancel = True Then
            BgMainByMonth.CancelAsync()
        End If

    End Sub

    Private Sub BgMainByMonth_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgMainByMonth.RunWorkerCompleted
        CMainVA.Subreports.Item("CryMainVAPlain").SetDataSource(tblPlain)
        CMainVA.Subreports.Item("CryMainVAPH").SetDataSource(tblPh)
        CMainVA.Subreports.Item("CryMainVAClassess").SetDataSource(tblGlasses)
        CMainVA.SetParameterValue("VATitle", "Visual Acuity on Month: " & CboMainMonth.Text & ", Year: " & CboMainYear.Text & " By Patien In (New Patient Book)")
        CrvVAReport.ReportSource = CMainVA
        BtnPrintMain1.Enabled = True
        PicLoadReport.Visible = False

    End Sub


    Private Sub BtnPrintMain2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintMain2.Click
        BtnPrintMain2.Enabled = False
        PicLoadReport.Visible = True
        DMainFrom = DateMainStart.Value
        DMainTo = DateMainTo.Value
        BgMainByDate.RunWorkerAsync()
    End Sub

    Private Sub BgMainByDate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgMainByDate.DoWork
        tblPlain = Me.TblMainPlainTableAdapter.GetDataByDate(DMainTo, DMainFrom)
        tblPh = Me.TblMainPhTableAdapter.GetDataByDate(DMainTo, DMainFrom)
        tblGlasses = Me.TblMainGlassesTableAdapter.GetDataByDate(DMainTo, DMainFrom)
    End Sub

    Private Sub BgMainByDate_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgMainByDate.RunWorkerCompleted
        CMainVA.Subreports.Item("CryMainVAPlain").SetDataSource(tblPlain)
        CMainVA.Subreports.Item("CryMainVAPH").SetDataSource(tblPh)
        CMainVA.Subreports.Item("CryMainVAClassess").SetDataSource(tblGlasses)
        CMainVA.SetParameterValue("VATitle", "Visual Acuity on date between : " & Format(DateMainStart.Value, "dd/MM/yyyy") & " To: " & Format(DateMainTo.Value, "dd/MM/yyyy") & " By Patien In (New Patient Book)")
        CrvVAReport.ReportSource = CMainVA
        BtnPrintMain2.Enabled = True
        PicLoadReport.Visible = False
    End Sub

    Private Sub FrmVAReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
        CboMainMonth.SelectedIndex = 0
        CboMainYear.SelectedIndex = 0
    End Sub
End Class