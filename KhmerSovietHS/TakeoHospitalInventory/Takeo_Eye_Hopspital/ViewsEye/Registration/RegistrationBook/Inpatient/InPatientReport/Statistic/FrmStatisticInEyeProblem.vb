Public Class FrmStatisticInEyeProblem
    Dim myListDiagnosis As New ArrayList
    Dim IndexLabel As Integer = 0
    Dim ArrLabelDiagnosis As LabelArray
    Dim ArrLabelChilF As LabelArray
    Dim ArrLabelChilM As LabelArray
    Dim ArrLabelAdultM As LabelArray
    Dim ArrLabelAdultF As LabelArray
    Dim ArrLabelTotal As LabelArray
    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrLabelAdultF = New LabelArray(GpResult)
        ArrLabelAdultM = New LabelArray(GpResult)
        ArrLabelChilF = New LabelArray(GpResult)
        ArrLabelChilM = New LabelArray(GpResult)
        ArrLabelTotal = New LabelArray(GpResult)
        ArrLabelDiagnosis = New LabelArray(GpResult)
        Dim tblDiagnosis As DataTable = ModDiagnosis.SelectMainSurgery()
        With ChBoxDiagnosis
            For i As Integer = 0 To tblDiagnosis.Rows.Count - 1
                .Items.Add(tblDiagnosis.Rows(i).Item(1).ToString)
            Next
        End With
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
        For i As Integer = 0 To 100
            CboAge1.Items.Add(i)
        Next
        CboAge1.SelectedIndex = 0

        For i As Integer = 0 To 100
            CboAge2.Items.Add(i)
        Next
        CboAge2.SelectedIndex = 15

        For i As Integer = 0 To 100
            cboAge3.Items.Add(i)
        Next
        cboAge3.SelectedIndex = 16

        For i As Integer = 0 To 100
            CboAge4.Items.Add(i)
        Next
        CboAge4.SelectedIndex = 100
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        Dim TopScroll As Integer = 0
        Dim Diagnosis As String
        Dim ChildF As String
        Dim childM As String
        Dim AdultF As String
        Dim AdultM As String
        Dim TotalEach As String
        ' Remove Label befor add to form
        For I As Integer = 0 To IndexLabel
            ArrLabelChilM.Remove()
            ArrLabelChilF.Remove()
            ArrLabelAdultM.Remove()
            ArrLabelAdultF.Remove()
            ArrLabelDiagnosis.Remove()
            ArrLabelTotal.Remove()
        Next
        For Each Diagnosis In myListDiagnosis
            ArrLabelDiagnosis.AddNewLabel(Diagnosis, 9, 300, ContentAlignment.MiddleLeft)
            Dim tblPatChild As DataTable = ModNewInPatientStatistic.InPDiagPerformFM(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
            Dim tblPatAdult As DataTable = ModNewInPatientStatistic.InPDiagPerformFM(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
            For I As Integer = 0 To tblPatChild.Rows.Count - 1
                childM = tblPatChild.Rows(I).Item(0).ToString
                ChildF = tblPatChild.Rows(I).Item(1).ToString
                ArrLabelChilM.AddNewLabel(childM, 394, 50, ContentAlignment.MiddleCenter)
                ArrLabelChilF.AddNewLabel(ChildF, 479, 50, ContentAlignment.MiddleCenter)
            Next
            For I As Integer = 0 To tblPatAdult.Rows.Count - 1
                AdultM = tblPatAdult.Rows(I).Item(0).ToString
                AdultF = tblPatAdult.Rows(I).Item(1).ToString
                ArrLabelAdultM.AddNewLabel(AdultM, 567, 50, ContentAlignment.MiddleCenter)
                ArrLabelAdultF.AddNewLabel(AdultF, 630, 50, ContentAlignment.MiddleCenter)
            Next
            TotalEach = ModNewInPatientStatistic.TotalInPEachDiagPerform(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
            TopScroll = ArrLabelTotal.AddNewLabel(TotalEach, 705, 50, ContentAlignment.MiddleCenter).Top
            IndexLabel = IndexLabel + 1
        Next
        Panel1.AutoScrollMinSize = New Size(2000, TopScroll + 50)
    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub ChBoxDiagnosis_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChBoxDiagnosis.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                myListDiagnosis.Add(ChBoxDiagnosis.Text)
            Case CheckState.Unchecked
                myListDiagnosis.Remove(ChBoxDiagnosis.Text)
        End Select
    End Sub

    
End Class