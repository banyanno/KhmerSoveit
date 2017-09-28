Public Class UCInpatientReport

    Private DFrom As Date
    Private DTo As Date
    Dim CR As New CRInpatientReport
    Dim MainInventory As MainTakeoInventory
    Sub New(ByVal MainInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainInventory = MainInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        DFrom = DateFrom.Value
        DTo = DateTo.Value
        BtnPrintPreview.Enabled = False
        Me.MainInventory.StatusLoading(True)
        BGLoadReport.RunWorkerAsync()
    End Sub

    Private Sub BGLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadReport.DoWork
        Dim TblInpatient As DataTable = Me.TblInpatientReportTableAdapter.GetDataByMonth(DTo, DFrom)
        CR.SetDataSource(TblInpatient)
    End Sub

    Private Sub BGLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadReport.RunWorkerCompleted
        CRVInPatient.ReportSource = CR
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Monthly In-patient From  " & Format(DFrom, "dd/MM/yyyy") & " To " & Format(DTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVInPatient.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CR.Refresh()
        BtnPrintPreview.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub

   
    Private Sub BtnFullNon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFullNon.Click
        Dim fStatisticFullNon As New FrmStatisticInFullNon
        fStatisticFullNon.ShowDialog()
        fStatisticFullNon.Close()
        fStatisticFullNon.Dispose()
    End Sub

    Private Sub BtnInDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInDiagnosis.Click
        Dim FStatisticInDiagnosis As New FrmStatisticInDiagnosis
        FStatisticInDiagnosis.ShowDialog()
        FStatisticInDiagnosis.Close()
        FStatisticInDiagnosis.Dispose()
    End Sub

    Private Sub BtnInEyeProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInEyeProblem.Click
        Dim FStatisticEyeProblem As New FrmWardNewInPatient
        FStatisticEyeProblem.ShowDialog()
        FStatisticEyeProblem.Close()
        FStatisticEyeProblem.Dispose()
    End Sub

    Private Sub BtnInSurgery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInSurgery.Click
        Dim FStatisticInSuegery As New FrmStatisticInSurgery
        FStatisticInSuegery.ShowDialog()
        FStatisticInSuegery.Close()
        FStatisticInSuegery.Dispose()
    End Sub
End Class
