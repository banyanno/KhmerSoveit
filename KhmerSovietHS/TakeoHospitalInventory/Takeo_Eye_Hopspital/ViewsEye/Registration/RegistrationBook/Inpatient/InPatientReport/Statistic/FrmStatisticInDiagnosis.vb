Public Class FrmStatisticInDiagnosis
    Dim myListDiagnosis As New ArrayList
    Dim MyListDiagnosisOther As New ArrayList
    Dim IndexLabel As Integer = 0
    Dim ArrLabelDiagnosis As LabelArray
    Dim ArrSubTotalLabel As LabelArray
    Dim Arr0_4F As LabelArray
    Dim ArrTotal0_4F As LabelArray
    Dim Arr0_4M As LabelArray
    Dim ArrTotal0_4M As LabelArray
    Dim Arr5_14M As LabelArray
    Dim ArrTotal5_14M As LabelArray
    Dim Arr5_14F As LabelArray
    Dim ArrTotal5_14F As LabelArray
    Dim Arr15_49F As LabelArray
    Dim ArrTotal15_49F As LabelArray
    Dim arr15_49M As LabelArray
    Dim ArrTotal15_49M As LabelArray
    Dim Arr50M As LabelArray
    Dim ArrTotal50M As LabelArray
    Dim Arr50F As LabelArray
    Dim ArrTotal50F As LabelArray
    Dim ArrEachTotal As LabelArray
    Dim ArrTotalSubTotal As LabelArray
    ' Declare label Array other
    Dim ArrLabelDiagnosisOther As LabelArray
    Dim ArrSubTotalLabelOther As LabelArray
    Dim Arr0_4FOther As LabelArray
    Dim ArrTotal0_4FOther As LabelArray
    Dim Arr0_4MOther As LabelArray
    Dim ArrTotal0_4MOther As LabelArray
    Dim Arr5_14MOther As LabelArray
    Dim ArrTotal5_14MOther As LabelArray
    Dim Arr5_14FOther As LabelArray
    Dim ArrTotal5_14FOther As LabelArray
    Dim Arr15_49FOther As LabelArray
    Dim ArrTotal15_49FOther As LabelArray
    Dim arr15_49MOther As LabelArray
    Dim ArrTotal15_49MOther As LabelArray
    Dim Arr50MOther As LabelArray
    Dim ArrTotal50MOther As LabelArray
    Dim Arr50FOther As LabelArray
    Dim ArrTotal50FOther As LabelArray
    Dim ArrEachTotalOther As LabelArray
    Dim ArrTotalSubTotalOther As LabelArray
    Private DoEventWork As System.ComponentModel.DoWorkEventArgs
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrLabelDiagnosis = New LabelArray(GpResult)
        ArrSubTotalLabel = New LabelArray(GpResult)
        Arr0_4F = New LabelArray(GpResult)
        ArrTotal0_4F = New LabelArray(GpResult)
        Arr0_4M = New LabelArray(GpResult)
        ArrTotal0_4M = New LabelArray(GpResult)
        Arr5_14F = New LabelArray(GpResult)
        ArrTotal5_14F = New LabelArray(GpResult)
        Arr5_14M = New LabelArray(GpResult)
        ArrTotal5_14M = New LabelArray(GpResult)
        arr15_49M = New LabelArray(GpResult)
        ArrTotal15_49M = New LabelArray(GpResult)
        Arr15_49F = New LabelArray(GpResult)
        ArrTotal15_49F = New LabelArray(GpResult)
        Arr50M = New LabelArray(GpResult)
        ArrTotal50M = New LabelArray(GpResult)
        Arr50F = New LabelArray(GpResult)
        ArrTotal50F = New LabelArray(GpResult)
        ArrEachTotal = New LabelArray(GpResult)
        ArrTotalSubTotal = New LabelArray(GpResult)
        


       
        Arr0_4FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4FOther = New LabelArray(GpDiagnosisOther)
        Arr0_4MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4MOther = New LabelArray(GpDiagnosisOther)
        Arr5_14FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal5_14FOther = New LabelArray(GpDiagnosisOther)
        Arr5_14MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal5_14MOther = New LabelArray(GpDiagnosisOther)
        arr15_49MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal15_49MOther = New LabelArray(GpDiagnosisOther)
        Arr15_49FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal15_49FOther = New LabelArray(GpDiagnosisOther)
        Arr50MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal50MOther = New LabelArray(GpDiagnosisOther)
        Arr50FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal50FOther = New LabelArray(GpDiagnosisOther)
        ArrEachTotalOther = New LabelArray(GpDiagnosisOther)
        ArrTotalSubTotalOther = New LabelArray(GpDiagnosisOther)
        ArrLabelDiagnosisOther = New LabelArray(GpDiagnosisOther)
        ArrSubTotalLabelOther = New LabelArray(GpDiagnosisOther)

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
        CboAge2.SelectedIndex = 4

        For i As Integer = 0 To 100
            cboAge3.Items.Add(i)
        Next
        cboAge3.SelectedIndex = 5

        For i As Integer = 0 To 100
            CboAge4.Items.Add(i)
        Next
        CboAge4.SelectedIndex = 14

        For i As Integer = 0 To 100
            CboAge5.Items.Add(i)
        Next
        CboAge5.SelectedIndex = 15
        For i As Integer = 0 To 100
            CboAge6.Items.Add(i)
        Next
        CboAge6.SelectedIndex = 49
        ' Add any initialization after the InitializeComponent() call.
        For I As Integer = 0 To ChBoxDiagnosis.Items.Count - 1
            MyListDiagnosisOther.Add(ChBoxDiagnosis.Items.Item(I))
        Next

    End Sub

    Private Sub ChBoxDiagnosis_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChBoxDiagnosis.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                myListDiagnosis.Add(ChBoxDiagnosis.Text)
                MyListDiagnosisOther.Remove(ChBoxDiagnosis.Text)
            Case CheckState.Unchecked
                myListDiagnosis.Remove(ChBoxDiagnosis.Text)
                MyListDiagnosisOther.Add(ChBoxDiagnosis.Text)
        End Select
    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgInPatient.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgInPatient.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgInPatient.CancelAsync()
        End If
    End Sub
    Sub LoadInPatient()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadInPatient))
        Else
            PictLoading.Visible = True
            If RadDiagnosis.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim Diagnosis As String = ""
                Dim Age0_4F As Integer
                Dim TotalAge0_4F As Integer
                Dim Age0_4M As Integer
                Dim TotalAge0_4M As Integer
                Dim Age5_14F As Integer
                Dim TotalAge5_14F As Integer
                Dim Age5_14M As Integer
                Dim TotalAge5_14M As Integer
                Dim Age15_49M As Integer
                Dim TotalAge15_49M As Integer
                Dim Age15_49F As Integer
                Dim TotalAge15_49F As Integer
                Dim Age50F As Integer
                Dim TotalAge50F As Integer
                Dim Age50M As Integer
                Dim TotalAge50M As Integer
                Dim SubTotal As String
                Dim TotalSubTotal As Integer
                ' Dim ApendDiagnosis As String = ""
                For i As Integer = 0 To IndexLabel
                    ArrLabelDiagnosis.Remove()
                    Arr0_4M.Remove()
                    ArrTotal0_4M.Remove()
                    Arr0_4F.Remove()
                    ArrTotal0_4F.Remove()
                    Arr5_14F.Remove()
                    ArrTotal5_14F.Remove()
                    Arr5_14M.Remove()
                    ArrTotal5_14M.Remove()
                    Arr15_49F.Remove()
                    ArrTotal15_49F.Remove()
                    arr15_49M.Remove()
                    ArrTotal15_49M.Remove()
                    Arr50M.Remove()
                    ArrTotal50M.Remove()
                    Arr50F.Remove()
                    ArrTotal50F.Remove()
                    ArrEachTotal.Remove()
                    ArrTotalSubTotal.Remove()
                    ArrSubTotalLabel.Remove()
                Next

                For Each Diagnosis In myListDiagnosis
                    If BgInPatient.CancellationPending Then
                        DoEventWork.Cancel = True
                        Return
                    End If
                    Me.Cursor = Cursors.WaitCursor
                    ArrLabelDiagnosis.AddNewLabel(Diagnosis, 10, 300, ContentAlignment.MiddleLeft)
                    'ApendDiagnosis = ApendDiagnosis & " AND Diagnosis<>'" & Diagnosis & "'"
                    Dim TblAge0_4 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim TblAge5_14 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim TblAge15_49 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim TblAge50 As DataTable = ModNewInPatientStatistic.InpatientFM50(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)

                    'Display 0-4
                    For T As Integer = 0 To TblAge0_4.Rows.Count - 1
                        Age0_4M = TblAge0_4.Rows(T).Item(0).ToString
                        Arr0_4M.AddNewLabel(Age0_4M, 372, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4M += Age0_4M

                        Age0_4F = TblAge0_4.Rows(T).Item(1).ToString
                        Arr0_4F.AddNewLabel(Age0_4F, 418, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4F += Age0_4F
                    Next
                    'Display 5-14 
                    For T As Integer = 0 To TblAge5_14.Rows.Count - 1
                        Age5_14M = TblAge5_14.Rows(T).Item(0).ToString
                        Arr5_14M.AddNewLabel(Age5_14M, 479, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14M += Age5_14M

                        Age5_14F = TblAge5_14.Rows(T).Item(1).ToString
                        Arr5_14F.AddNewLabel(Age5_14F, 526, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14F += Age5_14F
                    Next
                    'Display 15-49
                    For i As Integer = 0 To TblAge15_49.Rows.Count - 1
                        Age15_49M = TblAge15_49.Rows(i).Item(0).ToString
                        arr15_49M.AddNewLabel(Age15_49M, 584, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49M += Age15_49M

                        Age15_49F = TblAge15_49.Rows(i).Item(1).ToString
                        Arr15_49F.AddNewLabel(Age15_49F, 630, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49F += Age15_49F
                    Next
                    'Display 50
                    For I As Integer = 0 To TblAge50.Rows.Count - 1
                        Age50M = TblAge50.Rows(I).Item(0).ToString
                        Arr50M.AddNewLabel(Age50M, 691, 50, ContentAlignment.MiddleCenter)
                        TotalAge50M += Age50M
                        Age50F = TblAge50.Rows(I).Item(1).ToString
                        Arr50F.AddNewLabel(Age50F, 738, 50, ContentAlignment.MiddleCenter)
                        TotalAge50F += Age50F
                    Next
                    'Display Total Each Diagnosis
                    SubTotal = ModNewInPatientStatistic.InTotalEachDiagnosis(Diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    Topscroll = ArrEachTotal.AddNewLabel(SubTotal, 807, 50, ContentAlignment.MiddleCenter).Top

                    TotalSubTotal += SubTotal
                    IndexLabel = IndexLabel + 1

                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(100, Topscroll + 100)
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()
                    Me.Cursor = Cursors.Default
                Next
                ArrSubTotalLabel.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4M.AddNewLabelForSubTotal(TotalAge0_4M, 372, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4F.AddNewLabelForSubTotal(TotalAge0_4F, 418, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14M.AddNewLabelForSubTotal(TotalAge5_14M, 479, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14F.AddNewLabelForSubTotal(TotalAge5_14F, 526, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49M.AddNewLabelForSubTotal(TotalAge15_49M, 584, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49F.AddNewLabelForSubTotal(TotalAge15_49F, 630, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50M.AddNewLabelForSubTotal(TotalAge50M, 691, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50F.AddNewLabelForSubTotal(TotalAge50F, 738, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 807, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                TxtTotalInpatient.Text = ModNewInPatientStatistic.InPatientTotalDiagnosis(CboMonth.SelectedIndex + 1, CboYear.Text)
                'TxtTotalInPatientOther.Text = ModNewInPatientStatistic.InPatientTotalDiagnosisOther(ApendDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)

            End If
            If RadDiagnosisOther.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim DiagnosisOther As String = ""
                Dim ApendDiagnosis As String = ""
                Dim Age0_4FOther As Integer
                Dim TotalAge0_4FOther As Integer
                Dim Age0_4MOther As Integer
                Dim TotalAge0_4MOther As Integer
                Dim Age5_14FOther As Integer
                Dim TotalAge5_14FOther As Integer
                Dim Age5_14MOther As Integer
                Dim TotalAge5_14MOther As Integer
                Dim Age15_49MOther As Integer
                Dim TotalAge15_49MOther As Integer
                Dim Age15_49FOther As Integer
                Dim TotalAge15_49FOther As Integer
                Dim Age50FOther As Integer
                Dim TotalAge50FOther As Integer
                Dim Age50MOther As Integer
                Dim TotalAge50MOther As Integer

                Dim SubTotal As Integer
                Dim TotalSubTotalOther As Integer

                For i As Integer = 0 To IndexLabel
                    ArrLabelDiagnosisOther.Remove()
                    Arr0_4MOther.Remove()
                    ArrTotal0_4MOther.Remove()
                    Arr0_4FOther.Remove()
                    ArrTotal0_4FOther.Remove()
                    Arr5_14FOther.Remove()
                    ArrTotal5_14FOther.Remove()
                    Arr5_14MOther.Remove()
                    ArrTotal5_14MOther.Remove()
                    Arr15_49FOther.Remove()
                    ArrTotal15_49FOther.Remove()
                    arr15_49MOther.Remove()
                    ArrTotal15_49MOther.Remove()
                    Arr50MOther.Remove()
                    ArrTotal50MOther.Remove()
                    Arr50FOther.Remove()
                    ArrTotal50FOther.Remove()
                    ArrEachTotalOther.Remove()
                    ArrTotalSubTotalOther.Remove()
                    ArrSubTotalLabel.Remove()
                Next

                For Each DiagnosisOther In MyListDiagnosisOther
                    Me.Cursor = Cursors.WaitCursor
                    If BgInPatient.CancellationPending Then
                        DoEventWork.Cancel = True
                        Return
                    End If
                    ArrLabelDiagnosisOther.AddNewLabel(DiagnosisOther, 10, 300, ContentAlignment.MiddleLeft)
                    'ApendDiagnosis = ApendDiagnosis & " AND Diagnosis<>'" & DiagnosisOther & "'"
                    Dim TblAge0_4 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(DiagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim TblAge5_14 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(DiagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim TblAge15_49 As DataTable = ModNewInPatientStatistic.InPatientFMDiagnosis(DiagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim TblAge50 As DataTable = ModNewInPatientStatistic.InpatientFM50(DiagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)

                    'Display 0-4
                    For T As Integer = 0 To TblAge0_4.Rows.Count - 1
                        Age0_4MOther = TblAge0_4.Rows(T).Item(0).ToString
                        Arr0_4MOther.AddNewLabel(Age0_4MOther, 372, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4MOther += Age0_4MOther
                        Age0_4FOther = TblAge0_4.Rows(T).Item(1).ToString
                        Arr0_4FOther.AddNewLabel(Age0_4FOther, 418, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4FOther += Age0_4FOther
                    Next
                    'Display 5-14 
                    For T As Integer = 0 To TblAge5_14.Rows.Count - 1
                        Age5_14MOther = TblAge5_14.Rows(T).Item(0).ToString
                        Arr5_14MOther.AddNewLabel(Age5_14MOther, 479, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14MOther += Age5_14MOther
                        Age5_14FOther = TblAge5_14.Rows(T).Item(1).ToString
                        Arr5_14FOther.AddNewLabel(Age5_14FOther, 526, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14FOther += Age5_14FOther
                    Next
                    'Display 15-49
                    For i As Integer = 0 To TblAge15_49.Rows.Count - 1
                        Age15_49MOther = TblAge15_49.Rows(i).Item(0).ToString
                        arr15_49MOther.AddNewLabel(Age15_49MOther, 584, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49MOther += Age15_49MOther
                        Age15_49FOther = TblAge15_49.Rows(i).Item(1).ToString
                        Arr15_49FOther.AddNewLabel(Age15_49FOther, 630, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49FOther += Age15_49FOther
                    Next
                    'Display 50
                    For I As Integer = 0 To TblAge50.Rows.Count - 1
                        Age50MOther = TblAge50.Rows(I).Item(0).ToString
                        Arr50MOther.AddNewLabel(Age50MOther, 691, 50, ContentAlignment.MiddleCenter)
                        TotalAge50MOther += Age50MOther
                        Age50FOther = TblAge50.Rows(I).Item(1).ToString
                        Arr50FOther.AddNewLabel(Age50FOther, 738, 50, ContentAlignment.MiddleCenter)
                        TotalAge50FOther += Age50FOther
                    Next
                    'Display Total Each Diagnosis
                    SubTotal = ModNewInPatientStatistic.InTotalEachDiagnosis(DiagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)
                    TotalSubTotalOther += SubTotal
                    Topscroll = ArrEachTotalOther.AddNewLabel(SubTotal, 807, 50, ContentAlignment.MiddleCenter).Top
                    IndexLabel = IndexLabel + 1

                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()
                    Me.Cursor = Cursors.Default
                Next
                ArrSubTotalLabelOther.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(TotalAge0_4MOther, 372, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(TotalAge0_4FOther, 418, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(TotalAge5_14MOther, 479, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14FOther.AddNewLabelForSubTotal(TotalAge5_14FOther, 526, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(TotalAge15_49MOther, 584, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(TotalAge15_49FOther, 630, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50MOther.AddNewLabelForSubTotal(TotalAge50MOther, 691, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50FOther.AddNewLabelForSubTotal(TotalAge50FOther, 738, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotalOther, 807, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                TxtTotalInpatient.Text = ModNewInPatientStatistic.InPatientTotalDiagnosis(CboMonth.SelectedIndex + 1, CboYear.Text)
                TxtTotalInPatientOther.Text = ModNewInPatientStatistic.InPatientTotalDiagnosisOther(ApendDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)

            End If
        End If

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BgInPatient.CancellationPending Then
            DoEventWork.Cancel = True
            Return
        End If
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BgInPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgInPatient.DoWork
        DoEventWork = e
        LoadInPatient()
    End Sub

    Private Sub BgInPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgInPatient.RunWorkerCompleted
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