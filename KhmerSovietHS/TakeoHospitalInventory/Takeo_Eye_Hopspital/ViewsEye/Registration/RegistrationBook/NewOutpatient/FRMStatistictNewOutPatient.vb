Imports System.Threading
Public Class FRMStatistictNewOutPatient
    Dim MyThread As Thread

    Dim myListDiagnosis As New ArrayList
    Dim MyListDiagnosisOther As New ArrayList
    Dim ArrDiagnosis As LabelArray
    Dim ArrDiagnosisTotalLabel As LabelArray

    Dim Arr0_4M As LabelArray
    Dim ArrTotal0_4M As LabelArray

    Dim Arr0_4F As LabelArray
    Dim ArrTotal0_4F As LabelArray

    Dim Arr5_14F As LabelArray
    Dim ArrTotal5_14F As LabelArray

    Dim Arr5_14M As LabelArray
    Dim ArrTotal5_14M As LabelArray

    Dim Arr15_49M As LabelArray
    Dim ArrTotal15_49M As LabelArray

    Dim Arr15_49F As LabelArray
    Dim ArrTotal15_49F As LabelArray

    Dim Arr50M As LabelArray
    Dim ArrTotal50M As LabelArray

    Dim Arr50F As LabelArray
    Dim ArrTotal50F As LabelArray

    Dim ArrTotalEachDiagnosis As LabelArray
    Dim ArrSubTotal As LabelArray

    ' Show Diagnosis Others
    Dim ArrDiagnosisOther As LabelArray
    Dim ArrDiagnosisLabelOther As LabelArray

    Dim Arr0_4MOther As LabelArray
    Dim ArrTotal0_4MOther As LabelArray

    Dim Arr0_4FOther As LabelArray
    Dim ArrTotal0_4FOther As LabelArray

    Dim Arr5_14FOther As LabelArray
    Dim ArrTotal5_14FOther As LabelArray

    Dim Arr5_14MOther As LabelArray
    Dim ArrTotal5_14MOther As LabelArray

    Dim Arr15_49MOther As LabelArray
    Dim ArrTotal15_49MOther As LabelArray

    Dim Arr15_49FOther As LabelArray
    Dim ArrTotal15_49FOther As LabelArray

    Dim Arr50MOther As LabelArray
    Dim ArrTotal50MOther As LabelArray

    Dim Arr50FOther As LabelArray
    Dim ArrTotal50FOther As LabelArray

    Dim ArrTotalEachDiagnosisOther As LabelArray
    Dim ArrSubTotalOther As LabelArray
    Dim ArrDiagnosisTotalLabelOther As LabelArray


    Dim IndexCount As Integer = 0
    Private worker As New System.ComponentModel.BackgroundWorker()

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrDiagnosis = New LabelArray(GpResultNewOutPatient)
        ArrDiagnosisTotalLabel = New LabelArray(GpResultNewOutPatient)

        Arr0_4M = New LabelArray(GpResultNewOutPatient)
        ArrTotal0_4M = New LabelArray(GpResultNewOutPatient)

        Arr0_4F = New LabelArray(GpResultNewOutPatient)
        ArrTotal0_4F = New LabelArray(GpResultNewOutPatient)

        Arr5_14F = New LabelArray(GpResultNewOutPatient)
        ArrTotal5_14F = New LabelArray(GpResultNewOutPatient)

        Arr5_14M = New LabelArray(GpResultNewOutPatient)
        ArrTotal5_14M = New LabelArray(GpResultNewOutPatient)

        Arr15_49M = New LabelArray(GpResultNewOutPatient)
        ArrTotal15_49M = New LabelArray(GpResultNewOutPatient)

        Arr15_49F = New LabelArray(GpResultNewOutPatient)
        ArrTotal15_49F = New LabelArray(GpResultNewOutPatient)

        Arr50M = New LabelArray(GpResultNewOutPatient)
        ArrTotal50M = New LabelArray(GpResultNewOutPatient)

        Arr50F = New LabelArray(GpResultNewOutPatient)
        ArrTotal50F = New LabelArray(GpResultNewOutPatient)

        ArrTotalEachDiagnosis = New LabelArray(GpResultNewOutPatient)
        ArrSubTotal = New LabelArray(GpResultNewOutPatient)

        'This declare for Diagnosis other.
        ArrDiagnosisOther = New LabelArray(GpDiagnosisOther)
        ArrDiagnosisLabelOther = New LabelArray(GpDiagnosisOther)
        Arr0_4MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4MOther = New LabelArray(GpDiagnosisOther)

        Arr0_4FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4FOther = New LabelArray(GpDiagnosisOther)

        Arr5_14FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal5_14FOther = New LabelArray(GpDiagnosisOther)

        Arr5_14MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal5_14MOther = New LabelArray(GpDiagnosisOther)

        Arr15_49MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal15_49MOther = New LabelArray(GpDiagnosisOther)

        Arr15_49FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal15_49FOther = New LabelArray(GpDiagnosisOther)

        Arr50MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal50MOther = New LabelArray(GpDiagnosisOther)

        Arr50FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal50FOther = New LabelArray(GpDiagnosisOther)
        ArrTotalEachDiagnosisOther = New LabelArray(GpDiagnosisOther)
        ArrSubTotalOther = New LabelArray(GpDiagnosisOther)
        ArrDiagnosisTotalLabelOther = New LabelArray(GpDiagnosisOther)

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
        For i As Integer = 0 To ChBoxDiagnosis.Items.Count - 1
            MyListDiagnosisOther.Add(ChBoxDiagnosis.Items.Item(i))
        Next
        ' Add any initialization after the InitializeComponent() call.

        worker.WorkerReportsProgress = True
        worker.WorkerSupportsCancellation = True
        AddHandler worker.DoWork, New System.ComponentModel.DoWorkEventHandler(AddressOf worker_DoWork)
        AddHandler worker.RunWorkerCompleted, New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf worker_RunWorkerCompleted)
        'AddHandler worker.ProgressChanged, AddressOf worker_ProgressChanged
    End Sub
    Private workerCancel As System.ComponentModel.DoWorkEventArgs
    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Me.Cursor = Cursors.Arrow
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        BtnResult.Text = "Result"
        Pict1.Visible = False
    End Sub

    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        workerCancel = e
        fun2()
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

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If worker.CancellationPending Then
            workerCancel.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not worker.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            worker.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            worker.CancelAsync()
        End If
        'MyThread = New Thread(New ThreadStart(AddressOf fun1))
        'MyThread.Name = "Yanno"
        'MyThread.Start()
    End Sub
    Sub fun1()
        'fun2()
    End Sub
 
    Public Sub fun2()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf fun2))
        Else
            Pict1.Visible = True
            If RadDiagnosis.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim TotalOtherChild As Integer = 0
                Dim TotalOtherAdult As Integer = 0
                'Remove Label 
                For I As Integer = 0 To IndexCount
                    ArrDiagnosis.Remove()
                    ArrDiagnosisLabelOther.Remove()
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
                    Arr15_49M.Remove()
                    ArrTotal15_49M.Remove()
                    Arr50M.Remove()
                    ArrTotal50M.Remove()
                    Arr50F.Remove()
                    ArrTotal50F.Remove()
                    ArrTotalEachDiagnosis.Remove()
                    ArrSubTotal.Remove()
                    ArrDiagnosisTotalLabel.Remove()

                Next

                ' Display Total new out patient by month
                TxtTotalNewOutpatient.Text = ModOutPatientStatistic.TotalNewPatient(CboMonth.SelectedIndex + 1, CboYear.Text)
                ' Create Label Diagnosis
                'GpResultNewOutPatient.Text = "Result Statistict New-Out Patient On : " & CboMonth.Text & " : " & CboYear.Text
                ' Declare a new ButtonArray object.
                Dim diagnosis As String

                Dim Age0_4M As Integer
                Dim Total0_4M As Integer = 0

                Dim Age0_4F As Integer
                Dim Total0_4F As Integer = 0

                Dim Age5_14M As Integer
                Dim Total5_14M As Integer = 0

                Dim Age5_14F As Integer
                Dim Total5_14F As Integer = 0

                Dim Age15_49M As Integer
                Dim Total15_49M As Integer = 0

                Dim Age15_49F As Integer
                Dim Total15_49F As Integer = 0

                Dim Age50M As Integer
                Dim Total50M As Integer = 0

                Dim Age50F As Integer
                Dim Total50F As Integer = 0

                Dim TotalSub As Integer = 0

                Dim AppandStringDiagnosis As String

                For Each diagnosis In myListDiagnosis
                    If worker.CancellationPending Then
                        workerCancel.Cancel = True
                        Return
                    End If
                    Me.Cursor = Cursors.WaitCursor
                    ArrDiagnosis.AddNewLabel(diagnosis, 10, 300, ContentAlignment.MiddleLeft)
                    Dim TotalEachDiagnosis As String = ModOutPatientStatistic.TotalEachDiagnosisNew(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)

                    'Apand string to find other diagnosis.
                    AppandStringDiagnosis = AppandStringDiagnosis & " AND T2.Diagnosis<>'" & diagnosis & "'"

                    'Get data for children
                    Dim tblAge0_4 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    'Get data for adult
                    Dim TblAge5_14 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim TblAge15_49 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tblAge50 As DataTable = ModOutPatientStatistic.NewOutStatistict50(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For i As Integer = 0 To tblAge0_4.Rows.Count - 1
                        Age0_4M = tblAge0_4.Rows(i).Item(0).ToString
                        Arr0_4M.AddNewLabel(Age0_4M, 321, 50, ContentAlignment.MiddleCenter)
                        Total0_4M += Age0_4M

                        Age0_4F = tblAge0_4.Rows(i).Item(1).ToString
                        Arr0_4F.AddNewLabel(Age0_4F, 375, 50, ContentAlignment.MiddleCenter)
                        Total0_4F += Age0_4F
                    Next
                    For i As Integer = 0 To TblAge5_14.Rows.Count - 1
                        Age5_14M = TblAge5_14.Rows(i).Item(0).ToString
                        Arr5_14M.AddNewLabel(Age5_14M, 442, 50, ContentAlignment.MiddleCenter)
                        Total5_14M += Age5_14M

                        Age5_14F = TblAge5_14.Rows(i).Item(1).ToString
                        Arr5_14F.AddNewLabel(Age5_14F, 489, 50, ContentAlignment.MiddleCenter)
                        Total5_14F = Total5_14F + Age5_14F
                    Next
                    For i As Integer = 0 To TblAge15_49.Rows.Count - 1
                        Age15_49M = TblAge15_49.Rows(i).Item(0).ToString
                        Arr15_49M.AddNewLabel(Age15_49M, 555, 50, ContentAlignment.MiddleCenter)
                        Total15_49M += Age15_49M

                        Age15_49F = TblAge15_49.Rows(i).Item(1).ToString
                        Arr15_49F.AddNewLabel(Age15_49F, 609, 50, ContentAlignment.MiddleCenter)
                        Total15_49F += Age15_49F
                    Next
                    For i As Integer = 0 To tblAge50.Rows.Count - 1
                        Age50M = tblAge50.Rows(i).Item(0).ToString
                        Arr50M.AddNewLabel(Age50M, 676, 50, ContentAlignment.MiddleCenter)
                        Total50M += +Age50M

                        Age50F = tblAge50.Rows(i).Item(1).ToString
                        Arr50F.AddNewLabel(Age50F, 723, 50, ContentAlignment.MiddleCenter)
                        Total50F += Age50F
                    Next
                    Topscroll = ArrTotalEachDiagnosis.AddNewLabel(TotalEachDiagnosis, 783, 50, ContentAlignment.MiddleCenter).Top
                    TotalSub = TotalSub + TotalEachDiagnosis
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                    Thread.Sleep(100)
                    Application.DoEvents()
                    worker.ReportProgress(IndexCount)
                    Me.Cursor = Cursors.Default
                Next
                ArrDiagnosisTotalLabel.AddNewLabelForSubTotal("Tota:", 10, 300, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4M.AddNewLabelForSubTotal(Total0_4M, 321, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4F.AddNewLabelForSubTotal(Total0_4F, 375, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14M.AddNewLabelForSubTotal(Total5_14M, 442, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14F.AddNewLabelForSubTotal(Total5_14F, 489, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49M.AddNewLabelForSubTotal(Total15_49M, 555, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49F.AddNewLabelForSubTotal(Total15_49F, 609, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50M.AddNewLabelForSubTotal(Total50M, 676, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50F.AddNewLabelForSubTotal(Total50F, 723, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrSubTotal.AddNewLabelForSubTotal(TotalSub, 783, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                'Display disability patient
                TxtHearing.Text = ModNew_Outpatient.CountNewOutHearing(CboMonth.SelectedIndex + 1, CboYear.Text)
                TxtUnderstand.Text = ModNew_Outpatient.CountNewOutUnderstand(CboMonth.SelectedIndex + 1, CboYear.Text)
                TxtSeeing.Text = ModNew_Outpatient.CountNewOutSeeing(CboMonth.SelectedIndex + 1, CboYear.Text)
                TxtPhysical.Text = ModNew_Outpatient.CountNewOutPhysical(CboMonth.SelectedIndex + 1, CboYear.Text)
                TxtTotalDisability.Text = CInt(TxtHearing.Text) + CInt(TxtUnderstand.Text) + CInt(TxtSeeing.Text) + CInt(TxtPhysical.Text)

            End If

            If RadioDiagnosisOther.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim TotalOtherChild As Integer = 0
                Dim TotalOtherAdult As Integer = 0
                'Remove Label 
                For I As Integer = 0 To IndexCount
                    ArrDiagnosisOther.Remove()
                    ArrDiagnosisLabelOther.Remove()

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

                    Arr15_49MOther.Remove()
                    ArrTotal15_49MOther.Remove()

                    Arr50MOther.Remove()
                    ArrTotal50MOther.Remove()

                    Arr50FOther.Remove()
                    ArrTotal50FOther.Remove()

                    ArrTotalEachDiagnosisOther.Remove()
                    ArrSubTotalOther.Remove()
                    ArrDiagnosisTotalLabelOther.Remove()

                Next


                'GpResultNewOutPatient.Text = "Result Statistict New-Out Patient On : " & CboMonth.Text & " : " & CboYear.Text
                'Declare a new ButtonArray object.
                Dim diagnosisOther As String

                Dim Age0_4MOther As Integer
                Dim Total0_4MOther As Integer

                Dim Age0_4FOther As Integer
                Dim Total0_4FOther As Integer

                Dim Age5_14MOther As Integer
                Dim Total5_14MOther As Integer

                Dim Age5_14FOther As Integer
                Dim Total5_14FOther As Integer

                Dim Age15_49MOther As Integer
                Dim Total15_49MOther As Integer

                Dim Age15_49FOther As Integer
                Dim Total15_49FOther As Integer

                Dim Age50MOther As Integer
                Dim Total50MOther As Integer

                Dim Age50FOther As Integer
                Dim Total50FOther As Integer
                Dim TotalEachDiagnosis As Integer
                Dim TotalSubTotal As Integer

                Dim AppandStringDiagnosis As String

                Pict1.Visible = True
                For Each diagnosisOther In MyListDiagnosisOther
                    If worker.CancellationPending Then
                        workerCancel.Cancel = True
                        Return

                    End If
                    Me.Cursor = Cursors.WaitCursor
                    ArrDiagnosisOther.AddNewLabel(diagnosisOther, 10, 300, ContentAlignment.MiddleLeft)
                    TotalEachDiagnosis = ModOutPatientStatistic.TotalEachDiagnosisNew(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)

                    'Apand string to find other diagnosis.


                    'Get data for children
                    Dim tblAge0_4 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    'Get data for adult
                    Dim TblAge5_14 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim TblAge15_49 As DataTable = ModOutPatientStatistic.NewOutStatisticAge(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tblAge50 As DataTable = ModOutPatientStatistic.NewOutStatistict50(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For i As Integer = 0 To tblAge0_4.Rows.Count - 1
                        Age0_4MOther = tblAge0_4.Rows(i).Item(0).ToString
                        Arr0_4MOther.AddNewLabel(Age0_4MOther, 321, 50, ContentAlignment.MiddleCenter)
                        Total0_4MOther += Age0_4MOther

                        Age0_4FOther = tblAge0_4.Rows(i).Item(1).ToString
                        Arr0_4FOther.AddNewLabel(Age0_4FOther, 375, 50, ContentAlignment.MiddleCenter)
                        Total0_4FOther += Age0_4FOther
                    Next
                    For i As Integer = 0 To TblAge5_14.Rows.Count - 1
                        Age5_14MOther = TblAge5_14.Rows(i).Item(0).ToString
                        Arr5_14MOther.AddNewLabel(Age5_14MOther, 442, 50, ContentAlignment.MiddleCenter)
                        Total5_14MOther += Age5_14MOther

                        Age5_14FOther = TblAge5_14.Rows(i).Item(1).ToString
                        Arr5_14FOther.AddNewLabel(Age5_14FOther, 489, 50, ContentAlignment.MiddleCenter)
                        Total5_14FOther = Total5_14FOther + Age5_14FOther
                    Next
                    For i As Integer = 0 To TblAge15_49.Rows.Count - 1
                        Age15_49MOther = TblAge15_49.Rows(i).Item(0).ToString
                        Arr15_49MOther.AddNewLabel(Age15_49MOther, 555, 50, ContentAlignment.MiddleCenter)
                        Total15_49MOther += Age15_49MOther

                        Age15_49FOther = TblAge15_49.Rows(i).Item(1).ToString
                        Arr15_49FOther.AddNewLabel(Age15_49FOther, 609, 50, ContentAlignment.MiddleCenter)
                        Total15_49FOther += Age15_49FOther
                    Next
                    For i As Integer = 0 To tblAge50.Rows.Count - 1
                        Age50MOther = tblAge50.Rows(i).Item(0).ToString
                        Arr50MOther.AddNewLabel(Age50MOther, 676, 50, ContentAlignment.MiddleCenter)
                        Total50MOther += Age50MOther

                        Age50FOther = tblAge50.Rows(i).Item(1).ToString
                        Arr50FOther.AddNewLabel(Age50FOther, 723, 50, ContentAlignment.MiddleCenter)
                        Total50FOther += Age50FOther
                    Next
                    Topscroll = ArrTotalEachDiagnosisOther.AddNewLabel(TotalEachDiagnosis, 783, 50, ContentAlignment.MiddleCenter).Top
                    TotalSubTotal += TotalEachDiagnosis
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                    Thread.Sleep(100)
                    Me.Cursor = Cursors.Default
                    Application.DoEvents()
                Next
                ArrDiagnosisTotalLabelOther.AddNewLabelForSubTotal("Tota:", 10, 300, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(Total0_4MOther, 321, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(Total0_4FOther, 375, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(Total5_14MOther, 442, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14FOther.AddNewLabelForSubTotal(Total5_14FOther, 489, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(Total15_49MOther, 555, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(Total15_49FOther, 609, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50MOther.AddNewLabelForSubTotal(Total50MOther, 676, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50FOther.AddNewLabelForSubTotal(Total50FOther, 723, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 783, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                Pict1.Visible = False

            End If
        End If
    End Sub



End Class