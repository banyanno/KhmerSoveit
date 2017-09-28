Public Class FRMStatisticOldPatient
    Dim myListDiagnosis As New ArrayList
    Dim MyListDiagnosisOther As New ArrayList
    'Declare for real diagnosis
    Dim ArrDiagnosis As LabelArray
    Dim ArrSubTotalLabel As LabelArray

    Dim ArrO_4M As LabelArray
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
    Dim ArrTotalSubTotal As LabelArray

    'Display diagnosis others
    Dim ArrDiagnosisOther As LabelArray
    Dim ArrSubTotalLabelOther As LabelArray

    Dim ArrO_4MOther As LabelArray
    Dim ArrTotal0_4MOther As LabelArray

    Dim Arr0_4FOther As LabelArray
    Dim ArrTotal0_4FOther As LabelArray

    Dim Arr5_14FOther As LabelArray
    Dim ArrTotal5_14Fother As LabelArray

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
    Dim ArrTotalSubTotalOther As LabelArray
    Private EventBgDoWork As System.ComponentModel.DoWorkEventArgs
    Dim IndexCount As Integer
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Declare diagnosis 
        ArrDiagnosis = New LabelArray(GpResultNewOutPatient)
        ArrSubTotalLabel = New LabelArray(GpResultNewOutPatient)

        ArrO_4M = New LabelArray(GpResultNewOutPatient)
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
        ArrTotalSubTotal = New LabelArray(GpResultNewOutPatient)

        'Declare diagnosis others
        ArrDiagnosisOther = New LabelArray(GpDiagnosisOther)
        ArrSubTotalLabelOther = New LabelArray(GpDiagnosisOther)

        ArrO_4MOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4MOther = New LabelArray(GpDiagnosisOther)

        Arr0_4FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal0_4FOther = New LabelArray(GpDiagnosisOther)

        Arr5_14FOther = New LabelArray(GpDiagnosisOther)
        ArrTotal5_14Fother = New LabelArray(GpDiagnosisOther)

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
        ArrTotalSubTotalOther = New LabelArray(GpDiagnosisOther)

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

    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgOldPatient.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgOldPatient.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgOldPatient.CancelAsync()
        End If
    End Sub
    Sub LoadOldPatientStatistic()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadOldPatientStatistic))
        Else
            PicLoad.Visible = True
            If RadShowDiagnosis.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim TotalOtherChild As Integer = 0
                Dim TotalOtherAdult As Integer = 0
                'Remove Label 
                For i As Integer = 0 To IndexCount
                    ArrDiagnosis.Remove()
                    ArrSubTotalLabel.Remove()
                    ArrO_4M.Remove()
                    ArrTotal0_4M.Remove()
                    Arr0_4F.Remove()
                    ArrTotal0_4F.Remove()
                    Arr5_14F.Remove()
                    ArrTotal5_14F.Remove()
                    Arr5_14M.Remove()
                    ArrTotal5_14M.Remove()
                    Arr15_49M.Remove()
                    ArrTotal15_49M.Remove()
                    Arr15_49F.Remove()
                    ArrTotal15_49F.Remove()
                    Arr50M.Remove()
                    ArrTotal50M.Remove()
                    Arr50F.Remove()
                    ArrTotal50F.Remove()
                    ArrTotalEachDiagnosis.Remove()
                    ArrTotalSubTotal.Remove()
                Next
                ' Display Total new out patient by month
                TxtTotalOldOutpatient.Text = ModOutPatientStatistic.TotalOlddPatient(CboMonth.SelectedIndex + 1, CboYear.Text)
                ' Create Label Diagnosis

                'GpResultNewOutPatient.Text = "Result Statistict New-Out Patient On : " & CboMonth.Text & " : " & CboYear.Text
                ' Declare a new ButtonArray object.
                Dim diagnosis As String
                Dim SubTotalLabel As String
                Dim Age0_4M As Integer
                Dim TotalAge0_4M As Integer
                Dim Age0_4F As Integer
                Dim TotalAge0_4F As Integer
                Dim Age5_14M As Integer
                Dim TotalAge5_14M As Integer
                Dim Age5_14F As Integer
                Dim TotalAge5_14F As Integer
                Dim Age15_49M As Integer
                Dim TotalAge15_49M As Integer
                Dim Age15_49F As Integer
                Dim TotalAge15_49F As Integer
                Dim Age50M As Integer
                Dim TotalAge50M As Integer
                Dim Age50F As Integer
                Dim TotalAge50F As Integer
                Dim SubTotal As Integer
                Dim TotalSubTotal As Integer

                Me.Cursor = Cursors.WaitCursor
                ' Dim AppandStringDiagnosis As String
                For Each diagnosis In myListDiagnosis
                    ArrDiagnosis.AddNewLabel(diagnosis, 10, 300, ContentAlignment.MiddleLeft)
                    'Apand string to find other diagnosis.
                    ' AppandStringDiagnosis = AppandStringDiagnosis & " AND T2.Diagnosis<>'" & diagnosis & "'"
                    If BgOldPatient.CancellationPending Then
                        EventBgDoWork.Cancel = True
                        Return
                    End If

                    'Get data for children
                    Dim tblO_4 As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    'Get data for adult
                    Dim Tbl5_14 As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    'Get data for age 15-49 
                    Dim Tbl15_49 As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim Tbl50 As DataTable = ModOutPatientStatistic.OldStatistic50(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    SubTotal = ModOutPatientStatistic.TotalEachDiagnosisOld(diagnosis, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For i As Integer = 0 To tblO_4.Rows.Count - 1
                        Age0_4M = tblO_4.Rows(i).Item(0).ToString
                        ArrO_4M.AddNewLabel(Age0_4M, 336, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4M = TotalAge0_4M + Age0_4M

                        Age0_4F = tblO_4.Rows(i).Item(1).ToString
                        Arr0_4F.AddNewLabel(Age0_4F, 386, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4F = TotalAge0_4F + Age0_4F
                    Next
                    For i As Integer = 0 To Tbl5_14.Rows.Count - 1
                        Age5_14M = Tbl5_14.Rows(i).Item(0).ToString
                        Arr5_14M.AddNewLabel(Age5_14M, 449, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14M = TotalAge5_14M + Age5_14M

                        Age5_14F = Tbl5_14.Rows(i).Item(1).ToString
                        Arr5_14F.AddNewLabel(Age5_14F, 499, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14F = TotalAge5_14F + Age5_14F
                    Next
                    For i As Integer = 0 To Tbl15_49.Rows.Count - 1
                        Age15_49M = Tbl15_49.Rows(i).Item(0).ToString
                        Arr15_49M.AddNewLabel(Age15_49M, 563, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49M = TotalAge15_49M + Age15_49M

                        Age15_49F = Tbl15_49.Rows(i).Item(1).ToString
                        Arr15_49F.AddNewLabel(Age15_49F, 613, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49F = TotalAge15_49F + Age15_49F
                    Next
                    For i As Integer = 0 To Tbl50.Rows.Count - 1
                        Age50M = Tbl50.Rows(i).Item(0).ToString
                        Arr50M.AddNewLabel(Age50M, 676, 50, ContentAlignment.MiddleCenter)
                        TotalAge50M = TotalAge50M + Age50M
                        Age50F = Tbl50.Rows(i).Item(1).ToString
                        Arr50F.AddNewLabel(Age50F, 726, 50, ContentAlignment.MiddleCenter)
                        TotalAge50F = TotalAge50F + Age50F
                    Next

                    Topscroll = ArrTotalEachDiagnosis.AddNewLabel(SubTotal, 787, 50, ContentAlignment.MiddleCenter).Top
                    TotalSubTotal = TotalSubTotal + SubTotal
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                    Me.Cursor = Cursors.Default
                Next
                ArrSubTotalLabel.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4M.AddNewLabelForSubTotal(TotalAge0_4M, 336, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4F.AddNewLabelForSubTotal(TotalAge0_4F, 386, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14M.AddNewLabelForSubTotal(TotalAge5_14M, 449, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14F.AddNewLabelForSubTotal(TotalAge5_14F, 499, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49M.AddNewLabelForSubTotal(TotalAge15_49M, 563, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49F.AddNewLabelForSubTotal(TotalAge15_49F, 613, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50M.AddNewLabelForSubTotal(TotalAge50M, 676, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50F.AddNewLabelForSubTotal(TotalAge50F, 726, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 787, 50, ContentAlignment.MiddleCenter, Topscroll + 50)

                'Display for total other diagnosis 

                'Dim OthChild As Integer = ModOutPatientStatistic.OldOther(AppandStringDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                'Dim OthAdult As Integer = ModOutPatientStatistic.OldOther(AppandStringDiagnosis, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                'TxtTotalOtherChild.Text = OthChild
                'TxtTotalOtherAdult.Text = OthAdult


            End If
            'For display diagnosis others 
            If RadDiagnosisOther.Checked = True Then
                Dim Topscroll As Integer = 0
                Dim TotalOtherChild As Integer = 0
                Dim TotalOtherAdult As Integer = 0
                'Remove Label 
                For i As Integer = 0 To IndexCount
                    ArrDiagnosisOther.Remove()
                    ArrSubTotalLabelOther.Remove()
                    ArrO_4MOther.Remove()
                    ArrTotal0_4MOther.Remove()
                    Arr0_4FOther.Remove()
                    ArrTotal0_4FOther.Remove()
                    Arr5_14FOther.Remove()
                    ArrTotal5_14Fother.Remove()
                    Arr5_14MOther.Remove()
                    ArrTotal5_14MOther.Remove()
                    Arr15_49MOther.Remove()
                    ArrTotal15_49MOther.Remove()
                    Arr15_49FOther.Remove()
                    ArrTotal15_49FOther.Remove()
                    Arr50MOther.Remove()
                    ArrTotal50MOther.Remove()
                    Arr50FOther.Remove()
                    ArrTotal50FOther.Remove()
                    ArrTotalEachDiagnosisOther.Remove()
                    ArrTotalSubTotalOther.Remove()
                Next
                ' Display Total new out patient by month
                TxtTotalOldOutpatient.Text = ModOutPatientStatistic.TotalOlddPatient(CboMonth.SelectedIndex + 1, CboYear.Text)
                ' Create Label Diagnosis

                'GpResultNewOutPatient.Text = "Result Statistict New-Out Patient On : " & CboMonth.Text & " : " & CboYear.Text
                ' Declare a new ButtonArray object.
                Dim diagnosisOther As String
                Dim SubTotalOther As String
                Dim Age0_4MOther As Integer
                Dim TotalAge0_4MOther As Integer
                Dim Age0_4FOther As Integer
                Dim TotalAge0_4FOther As Integer
                Dim Age5_14MOther As Integer
                Dim TotalAge5_14MOther As Integer
                Dim Age5_14FOther As Integer
                Dim TotalAge5_14FOther As Integer
                Dim Age15_49MOther As Integer
                Dim TotalAge15_49MOther As Integer
                Dim Age15_49FOther As Integer
                Dim TotalAge15_49FOther As Integer
                Dim Age50MOther As Integer
                Dim TotalAge50MOther As Integer
                Dim Age50FOther As Integer
                Dim TotalAge50FOther As Integer
                Dim TotalEachDiagnosisOther As Integer
                Dim TotalSubTotalOther As Integer


                For Each diagnosisOther In MyListDiagnosisOther
                    If BgOldPatient.CancellationPending Then
                        EventBgDoWork.Cancel = True
                        Return
                    End If
                    Me.Cursor = Cursors.WaitCursor
                    ArrDiagnosisOther.AddNewLabel(diagnosisOther, 10, 300, ContentAlignment.MiddleLeft)
                    'Apand string to find other diagnosis.

                    'Get data for children
                    Dim tblO_4Other As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    'Get data for adult
                    Dim Tbl5_14Other As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    'Get data for age 15-49 
                    Dim Tbl15_49Other As DataTable = ModOutPatientStatistic.OldChildM_F(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim Tbl50Other As DataTable = ModOutPatientStatistic.OldStatistic50(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)

                    For i As Integer = 0 To tblO_4Other.Rows.Count - 1
                        Age0_4MOther = tblO_4Other.Rows(i).Item(0).ToString
                        ArrO_4MOther.AddNewLabel(Age0_4MOther, 336, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4MOther += Age0_4MOther

                        Age0_4FOther = tblO_4Other.Rows(i).Item(1).ToString
                        Arr0_4FOther.AddNewLabel(Age0_4FOther, 386, 50, ContentAlignment.MiddleCenter)
                        TotalAge0_4FOther += Age0_4FOther
                    Next
                    For i As Integer = 0 To Tbl5_14Other.Rows.Count - 1
                        Age5_14MOther = Tbl5_14Other.Rows(i).Item(0).ToString
                        Arr5_14MOther.AddNewLabel(Age5_14MOther, 449, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14MOther += Age5_14MOther
                        Age5_14FOther = Tbl5_14Other.Rows(i).Item(1).ToString
                        Arr5_14FOther.AddNewLabel(Age5_14FOther, 499, 50, ContentAlignment.MiddleCenter)
                        TotalAge5_14FOther += Age5_14FOther
                    Next
                    For i As Integer = 0 To Tbl15_49Other.Rows.Count - 1
                        Age15_49MOther = Tbl15_49Other.Rows(i).Item(0).ToString
                        Arr15_49MOther.AddNewLabel(Age15_49MOther, 563, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49MOther += Age15_49MOther
                        Age15_49FOther = Tbl15_49Other.Rows(i).Item(1).ToString
                        Arr15_49FOther.AddNewLabel(Age15_49FOther, 613, 50, ContentAlignment.MiddleCenter)
                        TotalAge15_49FOther += Age15_49FOther
                    Next
                    For i As Integer = 0 To Tbl50Other.Rows.Count - 1
                        Age50MOther = Tbl50Other.Rows(i).Item(0).ToString
                        Arr50MOther.AddNewLabel(Age50MOther, 676, 50, ContentAlignment.MiddleCenter)
                        TotalAge50MOther += Age50MOther
                        Age50FOther = Tbl50Other.Rows(i).Item(1).ToString
                        Arr50FOther.AddNewLabel(Age50FOther, 726, 50, ContentAlignment.MiddleCenter)
                        TotalAge50FOther += Age50FOther
                    Next
                    TotalEachDiagnosisOther = ModOutPatientStatistic.TotalEachDiagnosisOld(diagnosisOther, CboMonth.SelectedIndex + 1, CboYear.Text)
                    TotalSubTotalOther += TotalEachDiagnosisOther
                    Topscroll = ArrTotalEachDiagnosisOther.AddNewLabel(TotalEachDiagnosisOther, 787, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                    Me.Cursor = Cursors.Default

                Next
                ArrSubTotalLabelOther.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, Topscroll + 50)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(TotalAge0_4MOther, 336, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(TotalAge0_4FOther, 386, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(TotalAge5_14MOther, 449, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal5_14Fother.AddNewLabelForSubTotal(TotalAge5_14FOther, 499, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(TotalAge15_49MOther, 563, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(TotalAge15_49FOther, 613, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50MOther.AddNewLabelForSubTotal(TotalAge50MOther, 676, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotal50FOther.AddNewLabelForSubTotal(TotalAge50FOther, 726, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotalOther, 787, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
            End If
        End If
    End Sub
    Private Sub ChBoxDiagnosis_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChBoxDiagnosis.ItemCheck
        'Select Case e.NewValue
        '    Case CheckState.Checked
        '        MyListDiagnosisOther.Remove(ChBoxDiagnosis.Text)
        '        myListDiagnosis.Add(ChBoxDiagnosis.Text)
        '    Case CheckState.Unchecked
        '        myListDiagnosis.Remove(ChBoxDiagnosis.Text)
        '        MyListDiagnosisOther.Add(ChBoxDiagnosis.Text)
        'End Select
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
        If BgOldPatient.CancellationPending Then
            EventBgDoWork.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BgOldPatient_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgOldPatient.DoWork
        EventBgDoWork = e
        LoadOldPatientStatistic()
    End Sub

    Private Sub BgOldPatient_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgOldPatient.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        BtnResult.Text = "Result"
        PicLoad.Visible = False
    End Sub
End Class