Public Class FRMWardPreview
    Public DFrom As Date
    Public DTo As Date
    Dim TblPatientInward As DataTable
    Dim CRNew As New CRNewInpatientWard
    Dim CRLeave As New CRLeavPatient
    Sub CallBgNewInpatient()
        PicLoading.Visible = True
        BgLoadPatientNew.RunWorkerAsync()
    End Sub
    Sub CallBgPatientLeave()
        PicLoading.Visible = True
        BgLoadLeav.RunWorkerAsync()
    End Sub

    Private Sub BgLoadPatientNew_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadPatientNew.DoWork
        TblPatientInward = Me.TblNewInpatientTableAdapter.GetData(DFrom, DTo)
    End Sub

    Private Sub BgLoadPatientNew_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadPatientNew.RunWorkerCompleted
        CRNew.SetDataSource(TblPatientInward)
        CRVWard.ReportSource = CRNew
        Dim myArrayList As New ArrayList
        myArrayList.Add("List In patient staying From " & Format(DFrom, "dd/MM/yyyy") & " To " & Format(DTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVWard.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        CRVWard.Refresh()
        PicLoading.Visible = False
    End Sub

    Private Sub BgLoadLeav_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadLeav.DoWork
        TblPatientInward = Me.TblPatientLeavTableAdapter.GetData(DFrom, DTo)
    End Sub

    Private Sub BgLoadLeav_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadLeav.RunWorkerCompleted
        CRLeave.SetDataSource(TblPatientInward)
        CRVWard.ReportSource = CRLeave
        Dim myArrayList As New ArrayList
        myArrayList.Add("List patient leaved From " & Format(DFrom, "dd/MM/yyyy") & " To " & Format(DTo, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVWard.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        PicLoading.Visible = False
    End Sub

    Private Sub BtnPrintLeavVeiw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintLeavVeiw.Click
        Dim WardDisease As New CRWardDisease
        Dim TblTes As DataTable = Me.TblWardDiseaseTableAdapter.GetData(DateDisFrom.Value.Date, DateDisTo.Value.Date)
        WardDisease.SetDataSource(TblTes)
        CRVWard.ReportSource = WardDisease
        Dim myArrayList As ArrayList = New ArrayList()
        myArrayList.Add("Eye Disease in ward From  " & Format(DateDisFrom.Value, "dd/MM/yyyy") & " To " & Format(DateDisTo.Value, "dd/MM/yyyy"))
        Dim MyparameterFields As CrystalDecisions.Shared.ParameterFields = CRVWard.ParameterFieldInfo
        ModCommon.SetCurrentValuesForParameterField(MyparameterFields, myArrayList, "Title")
        'WardDisease.Dispose()
        'WardDisease.Close()
    End Sub

   
End Class