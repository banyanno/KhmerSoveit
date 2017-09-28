Public Class FrmWardNewInPatient
    Dim myListDiagnosis As New ArrayList
    Dim MyListDiagnosisOther As New ArrayList
    Dim ArrLabelDiagnosis As LabelArray
    Dim ArrSubTotalLabel As LabelArray
    Dim Arr0_4M As LabelArray
    Dim ArrTotal0_4M As LabelArray
    Dim Arr0_4F As LabelArray
    Dim ArrTotal0_4F As LabelArray
    Dim Arr5_14M As LabelArray
    Dim ArrTotal5_14M As LabelArray
    Dim Arr5_14F As LabelArray
    Dim ArrTotal5_14F As LabelArray
    Dim Arr15_49M As LabelArray
    Dim ArrTotal15_49M As LabelArray
    Dim Arr15_49F As LabelArray
    Dim ArrTotal15_49F As LabelArray
    Dim Arr50M As LabelArray
    Dim ArrTotal50M As LabelArray
    Dim Arr50F As LabelArray
    Dim ArrTotal50F As LabelArray
    Dim ArrSubTotal As LabelArray
    Dim ArrTotalSubTotal As LabelArray

    Dim ArrLabelDiagnosisOther As LabelArray
    Dim ArrSubTotalLabelOther As LabelArray
    Dim Arr0_4lMOther As LabelArray
    Dim ArrTotal0_4MOther As LabelArray
    Dim Arr0_4FOther As LabelArray
    Dim ArrTotal0_4FOther As LabelArray
    Dim Arr5_14MOther As LabelArray
    Dim ArrTotal5_14MOther As LabelArray
    Dim Arr5_14FOther As LabelArray
    Dim ArrTotal5_14FOther As LabelArray
    Dim Arr15_49MOther As LabelArray
    Dim ArrTotal15_49MOther As LabelArray
    Dim Arr15_49FOther As LabelArray
    Dim ArrTotal15_49FOther As LabelArray
    Dim Arr50MOther As LabelArray
    Dim ArrTotal50MOther As LabelArray
    Dim Arr50FOther As LabelArray
    Dim ArrTotal50FOther As LabelArray
    Dim ArrSubTotalOther As LabelArray
    Dim ArrTotalSubTotalOther As LabelArray

    Dim IndexCount As Integer = 0
    Private DoEventWork As System.ComponentModel.DoWorkEventArgs
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim tblDiagnosis As DataTable = ModDiagnosis.SelectMainSurgery()
        ArrLabelDiagnosis = New LabelArray(GpResult)
        ArrSubTotalLabel = New LabelArray(GpResult)
        Arr0_4M = New LabelArray(GpResult)
        ArrTotal0_4M = New LabelArray(GpResult)
        Arr0_4F = New LabelArray(GpResult)
        ArrTotal0_4F = New LabelArray(GpResult)
        Arr5_14M = New LabelArray(GpResult)
        ArrTotal5_14M = New LabelArray(GpResult)
        Arr5_14F = New LabelArray(GpResult)
        ArrTotal5_14F = New LabelArray(GpResult)
        Arr15_49M = New LabelArray(GpResult)
        ArrTotal15_49M = New LabelArray(GpResult)
        Arr15_49F = New LabelArray(GpResult)
        ArrTotal15_49F = New LabelArray(GpResult)
        Arr50M = New LabelArray(GpResult)
        ArrTotal50M = New LabelArray(GpResult)
        Arr50F = New LabelArray(GpResult)
        ArrTotal50F = New LabelArray(GpResult)
        ArrSubTotal = New LabelArray(GpResult)
        ArrTotalSubTotal = New LabelArray(GpResult)

        ArrLabelDiagnosisOther = New LabelArray(GpOther)
        ArrSubTotalLabelOther = New LabelArray(GpOther)
        Arr0_4lMOther = New LabelArray(GpOther)
        ArrTotal0_4MOther = New LabelArray(GpOther)
        Arr0_4FOther = New LabelArray(GpOther)
        ArrTotal0_4FOther = New LabelArray(GpOther)
        Arr5_14MOther = New LabelArray(GpOther)
        ArrTotal5_14MOther = New LabelArray(GpOther)
        Arr5_14FOther = New LabelArray(GpOther)
        ArrTotal5_14FOther = New LabelArray(GpOther)
        Arr15_49MOther = New LabelArray(GpOther)
        ArrTotal15_49MOther = New LabelArray(GpOther)
        Arr15_49FOther = New LabelArray(GpOther)
        ArrTotal15_49FOther = New LabelArray(GpOther)
        Arr50MOther = New LabelArray(GpOther)
        ArrTotal50MOther = New LabelArray(GpOther)
        Arr50FOther = New LabelArray(GpOther)
        ArrTotal50FOther = New LabelArray(GpOther)
        ArrSubTotalOther = New LabelArray(GpOther)
        ArrTotalSubTotalOther = New LabelArray(GpOther)

        With ChListDiagnosis
            For i As Integer = 0 To tblDiagnosis.Rows.Count - 1
                .Items.Add(tblDiagnosis.Rows(i).Item(1).ToString)
            Next
        End With
        For I As Integer = 0 To ChListDiagnosis.Items.Count - 1
            MyListDiagnosisOther.Add(ChListDiagnosis.Items.Item(I))
        Next
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
        For i As Integer = 0 To 100
            CboAge1.Items.Add(i)
        Next
        CboAge1.SelectedIndex = 0

        For i As Integer = 0 To 100
            CboAge2.Items.Add(i)
        Next
        CboAge2.SelectedIndex = 4
        For I As Integer = 0 To 100
            CboAge3.Items.Add(I)
        Next
        CboAge3.SelectedIndex = 5
        For I As Integer = 0 To 100
            CboAge4.Items.Add(I)
        Next
        CboAge4.SelectedIndex = 14
        For I As Integer = 0 To 100
            CboAge5.Items.Add(I)
        Next
        CboAge5.SelectedIndex = 15
        For I As Integer = 0 To 100
            CboAge6.Items.Add(I)
        Next
        CboAge6.SelectedIndex = 49
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgInWard.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgInWard.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgInWard.CancelAsync()
        End If
    End Sub

    Sub LoadInpatientWard()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadInpatientWard))
        Else
            PictLoading.Visible = True
            If RadShowDiagnosis.Checked = True Then
                Dim TopScroll As Integer = 0
                Dim Age0_4M As Integer = 0
                Dim TotalAge0_4M As Integer
                Dim Age0_4F As Integer = 0
                Dim TotalAge0_4F As Integer
                Dim Age5_14M As Integer
                Dim TotalAge5_14M As Integer
                Dim Age5_14F As Integer
                Dim TotalAge5_14F As Integer
                Dim Age15_49F As Integer
                Dim TotalAge15_49F As Integer
                Dim Age15_49M As Integer
                Dim TotalAge15_49M As Integer
                Dim Age50M As Integer
                Dim TotalAge50M As Integer
                Dim Age50F As Integer
                Dim TotalAge50F As Integer
                Dim SubTotal As Integer
                Dim TotalSubTotal As Integer

                '   Dim ApendDiagnosis As String

                For i As Integer = 0 To IndexCount
                    ArrLabelDiagnosis.Remove()
                    ArrSubTotalLabel.Remove()
                    Arr0_4M.Remove()
                    ArrTotal0_4M.Remove()
                    Arr0_4F.Remove()
                    ArrTotal0_4F.Remove()
                    Arr5_14M.Remove()
                    ArrTotal5_14M.Remove()
                    Arr5_14F.Remove()
                    ArrTotal5_14F.Remove()
                    Arr15_49M.Remove()
                    ArrTotal15_49M.Remove()
                    Arr15_49F.Remove()
                    ArrTotal15_49F.Remove()
                    Arr50M.Remove()
                    ArrTotal50M.Remove()
                    Arr50F.Remove()
                    ArrTotal50F.Remove()
                    ArrSubTotal.Remove()
                    ArrTotalSubTotal.Remove()
                Next
                Dim diagnosis As String
                For Each diagnosis In myListDiagnosis
                    Me.Cursor = Cursors.WaitCursor
                    If BgInWard.CancellationPending Then
                        DoEventWork.Cancel = True
                        Return
                    End If
                    ' ApendDiagnosis = ApendDiagnosis & " AND T2.Diagnosis<>'" & diagnosis & "'"
                    ArrLabelDiagnosis.AddNewLabel(diagnosis, 9, 300, ContentAlignment.BottomLeft)
                    Dim tbl0_4 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim tbl5_14 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge3.Text, CboAge4.Text)
                    Dim tbl15_49 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tbl50 As DataTable = ModNewInWardStatistic.TotalNewInWard50(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For k As Integer = 0 To tbl0_4.Rows.Count - 1
                        Age0_4M = tbl0_4.Rows(k).Item(0).ToString
                        Age0_4F = tbl0_4.Rows(k).Item(1).ToString
                        TotalAge0_4M += Age0_4M
                        TotalAge0_4F += Age0_4F
                        Arr0_4M.AddNewLabel(Age0_4M, 342, 50, ContentAlignment.MiddleCenter)
                        Arr0_4F.AddNewLabel(Age0_4F, 383, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl5_14.Rows.Count - 1
                        Age5_14M = tbl5_14.Rows(I).Item(0).ToString
                        Age5_14F = tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14M += Age5_14M
                        TotalAge5_14F += Age5_14F
                        Arr5_14M.AddNewLabel(Age5_14M, 449, 50, ContentAlignment.MiddleCenter)
                        Arr5_14F.AddNewLabel(Age5_14F, 490, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl15_49.Rows.Count - 1
                        Age15_49M = tbl15_49.Rows(I).Item(0).ToString
                        Age15_49F = tbl15_49.Rows(I).Item(1).ToString
                        TotalAge15_49M += Age15_49M
                        TotalAge15_49F += Age15_49F
                        Arr15_49M.AddNewLabel(Age15_49M, 554, 50, ContentAlignment.MiddleCenter)
                        Arr15_49F.AddNewLabel(Age15_49F, 595, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl50.Rows.Count - 1
                        Age50M = tbl50.Rows(I).Item(0).ToString
                        Age50F = tbl50.Rows(I).Item(1).ToString
                        TotalAge50M += Age50M
                        TotalAge50F += Age50F
                        Arr50M.AddNewLabel(Age50M, 661, 50, ContentAlignment.MiddleCenter)
                        Arr50F.AddNewLabel(Age50F, 702, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotal = ModNewInWardStatistic.TotalEachDiagnosis(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    TotalSubTotal += SubTotal
                    TopScroll = ArrSubTotal.AddNewLabel(SubTotal, 797, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    Me.Cursor = Cursors.Default
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()
                Next
                ArrSubTotalLabel.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 50)
                ArrTotal0_4M.AddNewLabelForSubTotal(TotalAge0_4M, 342, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal0_4F.AddNewLabelForSubTotal(TotalAge0_4F, 383, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14M.AddNewLabelForSubTotal(TotalAge5_14M, 449, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14F.AddNewLabelForSubTotal(TotalAge5_14F, 490, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49M.AddNewLabelForSubTotal(TotalAge15_49M, 554, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49F.AddNewLabelForSubTotal(TotalAge15_49F, 595, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50M.AddNewLabelForSubTotal(TotalAge50M, 661, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50F.AddNewLabelForSubTotal(TotalAge50F, 702, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 797, 50, ContentAlignment.MiddleCenter, TopScroll + 50)

                'txtTotalInPatient.Text = ModNewInWardStatistic.TotalNewIn(CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                'txtTotalOther.Text = ModNewInWardStatistic.TotalOtherDiagnosis(ApendDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)

            End If
            If RadShowOther.Checked = True Then
                Dim TopScroll As Integer
                Dim Age0_4MOther As Integer
                Dim TotalAge0_4MOther As Integer
                Dim Age0_4FOther As Integer
                Dim TotalAge0_4FOther As Integer
                Dim Age5_14MOther As Integer
                Dim TotalAge5_14MOther As Integer
                Dim Age5_14FOther As Integer
                Dim TotalAge5_14FOther As Integer
                Dim Age15_49FOther As Integer
                Dim TotalAge15_49FOther As Integer
                Dim Age15_49MOther As Integer
                Dim Totalage15_49MOther As Integer
                Dim Age50MOther As Integer
                Dim TotalAge50MOther As Integer
                Dim Age50FOther As Integer
                Dim TotalAge50FOther As Integer
                Dim SubTotalOther As Integer
                Dim TotalSubTotalOther As Integer
                ' Dim ApendDiagnosis As String
                For i As Integer = 0 To IndexCount
                    ArrLabelDiagnosisOther.Remove()
                    ArrSubTotalLabelOther.Remove()
                    Arr0_4lMOther.Remove()
                    ArrTotal0_4MOther.Remove()
                    Arr0_4FOther.Remove()
                    ArrTotal0_4FOther.Remove()
                    Arr5_14MOther.Remove()
                    ArrTotal5_14MOther.Remove()
                    Arr5_14FOther.Remove()
                    ArrTotal5_14FOther.Remove()
                    Arr15_49MOther.Remove()
                    ArrTotal15_49MOther.Remove()
                    Arr15_49FOther.Remove()
                    ArrTotal15_49FOther.Remove()
                    Arr50MOther.Remove()
                    ArrTotal50MOther.Remove()
                    Arr50FOther.Remove()
                    ArrTotal50FOther.Remove()
                    ArrSubTotalOther.Remove()
                    ArrTotalSubTotalOther.Remove()
                Next
                Dim diagnosis As String

                For Each diagnosis In MyListDiagnosisOther
                    Me.Cursor = Cursors.WaitCursor
                    If BgInWard.CancellationPending Then
                        DoEventWork.Cancel = True
                        Return
                    End If
                    'ApendDiagnosis = ApendDiagnosis & " AND T2.Diagnosis<>'" & diagnosis & "'"
                    ArrLabelDiagnosisOther.AddNewLabel(diagnosis, 9, 300, ContentAlignment.BottomLeft)
                    Dim tbl0_4 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim tbl5_14 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge3.Text, CboAge4.Text)
                    Dim tbl15_49 As DataTable = ModNewInWardStatistic.TotalNewInWardM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tbl50 As DataTable = ModNewInWardStatistic.TotalNewInWard50(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For k As Integer = 0 To tbl0_4.Rows.Count - 1
                        Age0_4MOther = tbl0_4.Rows(k).Item(0).ToString
                        Age0_4FOther = tbl0_4.Rows(k).Item(1).ToString
                        TotalAge0_4MOther += Age0_4MOther
                        TotalAge0_4FOther += Age0_4FOther
                        Arr0_4lMOther.AddNewLabel(Age0_4MOther, 342, 50, ContentAlignment.MiddleCenter)
                        Arr0_4FOther.AddNewLabel(Age0_4FOther, 383, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl5_14.Rows.Count - 1
                        Age5_14MOther = tbl5_14.Rows(I).Item(0).ToString
                        Age5_14FOther = tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14MOther += Age5_14MOther
                        TotalAge5_14FOther += Age5_14FOther
                        Arr5_14MOther.AddNewLabel(Age5_14MOther, 449, 50, ContentAlignment.MiddleCenter)
                        Arr5_14FOther.AddNewLabel(Age5_14FOther, 490, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl15_49.Rows.Count - 1
                        Age15_49MOther = tbl15_49.Rows(I).Item(0).ToString
                        Age15_49FOther = tbl15_49.Rows(I).Item(1).ToString
                        Totalage15_49MOther += Age15_49MOther
                        TotalAge15_49FOther += Age15_49FOther
                        Arr15_49MOther.AddNewLabel(Age15_49MOther, 554, 50, ContentAlignment.MiddleCenter)
                        Arr15_49FOther.AddNewLabel(Age15_49FOther, 595, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl50.Rows.Count - 1
                        Age50MOther = tbl50.Rows(I).Item(0).ToString
                        Age50FOther = tbl50.Rows(I).Item(1).ToString
                        TotalAge50MOther += Age50MOther
                        TotalAge50FOther += Age50FOther
                        Arr50MOther.AddNewLabel(Age50MOther, 661, 50, ContentAlignment.MiddleCenter)
                        Arr50FOther.AddNewLabel(Age50FOther, 702, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotalOther = ModNewInWardStatistic.TotalEachDiagnosis(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    TotalSubTotalOther += SubTotalOther
                    TopScroll = ArrSubTotalOther.AddNewLabel(SubTotalOther, 797, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    Me.Cursor = Cursors.Default
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()

                Next
                ArrSubTotalLabelOther.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 50)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(TotalAge0_4MOther, 342, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(TotalAge0_4FOther, 383, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(TotalAge5_14MOther, 449, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14FOther.AddNewLabelForSubTotal(TotalAge5_14FOther, 490, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(Totalage15_49MOther, 554, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(TotalAge15_49FOther, 595, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50MOther.AddNewLabelForSubTotal(TotalAge50MOther, 661, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50FOther.AddNewLabelForSubTotal(TotalAge50FOther, 702, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotalOther, 797, 50, ContentAlignment.MiddleCenter, TopScroll + 50)


                'txtTotalInPatient.Text = ModNewInWardStatistic.TotalNewIn(CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                'txtTotalOther.Text = ModNewInWardStatistic.TotalOtherDiagnosis(ApendDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
            End If
        End If
        
    End Sub
    Private Sub ChListDiagnosis_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChListDiagnosis.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                myListDiagnosis.Add(ChListDiagnosis.Text)
                MyListDiagnosisOther.Remove(ChListDiagnosis.Text)
            Case CheckState.Unchecked
                myListDiagnosis.Remove(ChListDiagnosis.Text)
                MyListDiagnosisOther.Add(ChListDiagnosis.Text)
        End Select
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BgInWard.CancellationPending Then
            DoEventWork.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BgInWard_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgInWard.DoWork
        DoEventWork = e
        LoadInpatientWard()
    End Sub

    Private Sub BgInWard_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgInWard.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        BtnResult.Text = "Result"
        PictLoading.Visible = False
    End Sub
End Class