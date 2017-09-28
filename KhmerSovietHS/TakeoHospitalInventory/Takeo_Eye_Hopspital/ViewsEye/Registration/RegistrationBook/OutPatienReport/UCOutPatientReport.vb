Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class UCOutPatientReport
    Private DFrom As Date
    Private DTo As Date
    Private Cr As New CROutPatientReport
    Dim MainInventory As MainTakeoInventory
    Sub New(ByVal MainInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainInventory = MainInventory
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Me.MainInventory.StatusLoading(True)
        BtnPreview.Enabled = False
        DFrom = DateFrom.Value
        DTo = DateTo.Value
        BgLoadReport.RunWorkerAsync()
    End Sub

    Private Sub BgLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadReport.DoWork
        Dim tblOutPatient As DataTable = Me.DataTable1TableAdapter.GetData(DTo, DFrom)
        Cr.SetDataSource(tblOutPatient)
        If BgLoadReport.CancellationPending Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub BgLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadReport.RunWorkerCompleted
        CROutPatientView.ReportSource = Cr
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Monthly Out-patient From  " & Format(DFrom, "dd/MM/yyyy") & " To " & Format(DTo, "dd/MM/yyyy"))
        Dim MyparameterFields As ParameterFields = CROutPatientView.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Label_Title")
        Cr.Refresh()
        BtnPreview.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub
   
    Private Sub BtnOldOutStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOldOutStatistic.Click
        Dim FStatisticOld As New FRMStatisticOldPatient
        FStatisticOld.ShowDialog()
        FStatisticOld.Close()
        FStatisticOld.Dispose()
    End Sub

    Private Sub BtnNewOutStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewOutStatistic.Click
        Dim FStatisticNewOut As New FRMStatistictNewOutPatient
        FStatisticNewOut.Show()
        ''FStatisticNewOut.ShowDialog()
        ''FStatisticNewOut.Close()
        ''FStatisticNewOut.Dispose()
    End Sub
End Class
