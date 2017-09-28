Public Class UCOperationReport
    Dim DFrom As Date
    Dim DTo As Date
    Dim DIOLFrom As Date
    Dim DIOLTo As Date
    Dim CR As New CROperationReport
    Dim CROTWithIOL As New CROperationIOL
    Dim TblOperation As DataTable
    Dim TblOTWithIOL As DataTable
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
        BGLoadDiagnosisWithSurgery.RunWorkerAsync()
    End Sub
    Private Sub BtnPrintIOL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintIOL.Click
        DIOLFrom = DateIOLFrom.Value
        DIOLTo = DateIOLTo.Value
        BtnPrintIOL.Enabled = False
        Me.MainInventory.StatusLoading(True)
        BgLoadDgWithIOL.RunWorkerAsync()
    End Sub

    Private Sub BGLoadReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGLoadDiagnosisWithSurgery.DoWork
        TblOperation = Me.DTblOperationTableAdapter.GetData(DTo, DFrom)
    End Sub

    Private Sub BGLoadReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGLoadDiagnosisWithSurgery.RunWorkerCompleted
        CR.SetDataSource(TblOperation)
        CRVOperation.ReportSource = CR
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Operation report From  " & Format(DFrom, "dd/MM/yyyy") & " To " & Format(DTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVOperation.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CR.Refresh()
        BtnPrintPreview.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub

    Private Sub BgLoadDgWithIOL_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadDgWithIOL.DoWork
        TblOTWithIOL = Me.TblOperationIOLTableAdapter.GetData(DIOLTo, DIOLFrom)
    End Sub

    Private Sub BgLoadDgWithIOL_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadDgWithIOL.RunWorkerCompleted
        CROTWithIOL.SetDataSource(TblOTWithIOL)
        CRVOperation.ReportSource = CROTWithIOL
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Operation with IOL number report From  " & Format(DIOLFrom, "dd/MM/yyyy") & " To " & Format(DIOLTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVOperation.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CR.Refresh()
        BtnPrintIOL.Enabled = True
        Me.MainInventory.StatusLoading(False)
    End Sub
End Class
