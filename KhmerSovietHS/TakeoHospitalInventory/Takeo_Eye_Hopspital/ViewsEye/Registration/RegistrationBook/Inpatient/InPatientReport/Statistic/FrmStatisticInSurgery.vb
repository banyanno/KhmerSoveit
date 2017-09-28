Public Class FrmStatisticInSurgery
    Dim MyListSurgery As New ArrayList
    Dim MyListSurgeryOther As New ArrayList
    Dim IndexCount As Integer = 0
    Dim ArrLabelOP As LabelArray
    Dim ArrSubTotalLabel As LabelArray
    Dim Arr0_4F As LabelArray
    Dim ArrTotal0_4F As LabelArray
    Dim Arr0_4M As LabelArray
    Dim ArrTotal0_4M As LabelArray
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
    'SurgeryOther
    Dim ArrLabelOPOther As LabelArray
    Dim ArrSubTotalLabelOther As LabelArray
    Dim Arr0_4FOther As LabelArray
    Dim ArrTotal0_4FOther As LabelArray
    Dim Arr0_4MOther As LabelArray
    Dim ArrTotal0_4MOther As LabelArray
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
    Private DoEventBG As System.ComponentModel.DoWorkEventArgs
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrLabelOP = New LabelArray(GpResult)
        ArrSubTotalLabel = New LabelArray(GpResult)
        Arr0_4F = New LabelArray(GpResult)
        ArrTotal0_4F = New LabelArray(GpResult)
        Arr0_4M = New LabelArray(GpResult)
        ArrTotal0_4M = New LabelArray(GpResult)
        Arr5_14F = New LabelArray(GpResult)
        ArrTotal5_14F = New LabelArray(GpResult)
        Arr5_14M = New LabelArray(GpResult)
        ArrTotal5_14M = New LabelArray(GpResult)
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


        ArrLabelOPOther = New LabelArray(GpOpOther)
        ArrSubTotalLabelOther = New LabelArray(GpOpOther)
        Arr0_4FOther = New LabelArray(GpOpOther)
        ArrTotal0_4FOther = New LabelArray(GpOpOther)
        Arr0_4MOther = New LabelArray(GpOpOther)
        ArrTotal0_4MOther = New LabelArray(GpOpOther)
        Arr5_14MOther = New LabelArray(GpOpOther)
        ArrTotal5_14MOther = New LabelArray(GpOpOther)
        Arr5_14FOther = New LabelArray(GpOpOther)
        ArrTotal5_14FOther = New LabelArray(GpOpOther)
        Arr15_49MOther = New LabelArray(GpOpOther)
        ArrTotal15_49MOther = New LabelArray(GpOpOther)
        Arr15_49FOther = New LabelArray(GpOpOther)
        ArrTotal15_49FOther = New LabelArray(GpOpOther)
        Arr50MOther = New LabelArray(GpOpOther)
        ArrTotal50MOther = New LabelArray(GpOpOther)
        Arr50FOther = New LabelArray(GpOpOther)
        ArrTotal50FOther = New LabelArray(GpOpOther)
        ArrSubTotalOther = New LabelArray(GpOpOther)
        ArrTotalSubTotalOther = New LabelArray(GpOpOther)

        Dim tblSurgeries As DataTable = ModSurgeries.SelectSurgeries
        With ChListSurgery
            For i As Integer = 0 To tblSurgeries.Rows.Count - 1
                .Items.Add(tblSurgeries.Rows(i).Item(1).ToString)
            Next
        End With
        For I As Integer = 0 To ChListSurgery.Items.Count - 1
            MyListSurgeryOther.Add(ChListSurgery.Items.Item(I))
        Next
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0
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
    Private Sub ChListSurgery_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChListSurgery.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                MyListSurgery.Add(ChListSurgery.Text)
                MyListSurgeryOther.Remove(ChListSurgery.Text)
            Case CheckState.Unchecked
                MyListSurgery.Remove(ChListSurgery.Text)
                MyListSurgeryOther.Add(ChListSurgery.Text)
        End Select
    End Sub
    Sub LoadInSurgery()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadInSurgery))
        Else
            PictLoading.Visible = True
            If RadOperation.Checked Then
                Dim TopScroll As Integer = 0
                Dim Surgery As String
                Dim Age0_4F As Integer
                Dim TotalAge0_4F As Integer
                Dim Age0_4M As Integer
                Dim TotalAge0_4M As Integer
                Dim Age5_14F As Integer
                Dim TotalAge5_14F As Integer
                Dim Age5_14M As Integer
                Dim TotalAge5_14M As Integer
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
                ' Remove Label befor add to form
                For I As Integer = 0 To IndexCount
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
                    ArrLabelOP.Remove()
                    ArrSubTotalLabel.Remove()
                    ArrSubTotal.Remove()
                    ArrTotalSubTotal.Remove()
                Next

                For Each Surgery In MyListSurgery
                    Me.Cursor = Cursors.WaitCursor
                    If BgInsurgery.CancellationPending Then
                        DoEventBG.Cancel = True
                        Return
                    End If
                    ArrLabelOP.AddNewLabel(Surgery, 9, 300, ContentAlignment.MiddleLeft)
                    Dim tbl0_4 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim tbl5_14 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim tbl15_49 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tbl50 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM50(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For I As Integer = 0 To tbl0_4.Rows.Count - 1
                        Age0_4M = tbl0_4.Rows(I).Item(0).ToString
                        Age0_4F = tbl0_4.Rows(I).Item(1).ToString
                        TotalAge0_4M += Age0_4M
                        TotalAge0_4F += Age0_4F
                        Arr0_4M.AddNewLabel(Age0_4M, 379, 50, ContentAlignment.MiddleCenter)
                        Arr0_4F.AddNewLabel(Age0_4F, 429, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl5_14.Rows.Count - 1
                        Age5_14M = tbl5_14.Rows(I).Item(0).ToString
                        Age5_14F = tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14M += Age5_14M
                        TotalAge5_14F += Age5_14F
                        Arr5_14M.AddNewLabel(Age5_14M, 493, 50, ContentAlignment.MiddleCenter)
                        Arr5_14F.AddNewLabel(Age5_14F, 543, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl15_49.Rows.Count - 1
                        Age15_49M = tbl15_49.Rows(I).Item(0).ToString
                        Age15_49F = tbl15_49.Rows(I).Item(1).ToString
                        TotalAge15_49M += Age15_49M
                        TotalAge15_49F += Age15_49F
                        Arr15_49M.AddNewLabel(Age15_49M, 602, 50, ContentAlignment.MiddleCenter)
                        Arr15_49F.AddNewLabel(Age15_49F, 652, 50, ContentAlignment.MiddleCenter)

                    Next
                    For I As Integer = 0 To tbl50.Rows.Count - 1
                        Age50M = tbl50.Rows(I).Item(0).ToString
                        Age50F = tbl50.Rows(I).Item(1).ToString
                        TotalAge50M += Age50M
                        TotalAge50F += Age50F
                        Arr50M.AddNewLabel(Age50M, 716, 50, ContentAlignment.MiddleCenter)
                        Arr50F.AddNewLabel(Age50F, 766, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotal = ModNewInPatientStatistic.TotalInEachSurgeryPerform(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    TotalSubTotal += SubTotal
                    TopScroll = ArrSubTotal.AddNewLabel(SubTotal, 848, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    Me.Cursor = Cursors.Default
                Next
                ArrSubTotalLabel.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 40)
                ArrTotal0_4M.AddNewLabelForSubTotal(TotalAge0_4M, 379, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal0_4F.AddNewLabelForSubTotal(TotalAge0_4F, 429, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal5_14M.AddNewLabelForSubTotal(TotalAge5_14M, 493, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal5_14F.AddNewLabelForSubTotal(TotalAge5_14F, 543, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal15_49M.AddNewLabelForSubTotal(TotalAge15_49M, 602, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal15_49F.AddNewLabelForSubTotal(TotalAge15_49F, 652, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal50M.AddNewLabelForSubTotal(TotalAge50M, 716, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal50F.AddNewLabelForSubTotal(TotalAge50F, 766, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 848, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
               
            End If
            If RadOperationOther.Checked = True Then
                Dim TopScroll As Integer = 0
                Dim Surgery As String
                Dim Age0_4F As Integer
                Dim TotalAge0_4F As Integer
                Dim Age0_4M As Integer
                Dim TotalAge0_4M As Integer
                Dim Age5_14F As Integer
                Dim TotalAge5_14F As Integer
                Dim Age5_14M As Integer
                Dim TotalAge5_14M As String
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
                ' Remove Label befor add to form
                For I As Integer = 0 To IndexCount
                    ArrLabelOPOther.Remove()

                    Arr0_4MOther.Remove()
                    ArrTotal0_4MOther.Remove()

                    Arr0_4FOther.Remove()
                    ArrTotal0_4FOther.Remove()

                    Arr5_14MOther.Remove()
                    ArrTotal5_14MOther.Remove()

                    Arr5_14FOther.Remove()
                    ArrTotal5_14FOther.Remove()

                    Arr15_49MOther.Remove()
                    ArrTotal5_14MOther.Remove()

                    Arr15_49FOther.Remove()
                    ArrTotal15_49FOther.Remove()

                    Arr50MOther.Remove()
                    ArrTotal50MOther.Remove()

                    Arr50FOther.Remove()
                    ArrTotal50FOther.Remove()

                    ArrSubTotalOther.Remove()
                    ArrTotalSubTotalOther.Remove()
                    ArrSubTotalLabelOther.Remove()
                Next

                For Each Surgery In MyListSurgeryOther
                    If BgInsurgery.CancellationPending Then
                        DoEventBG.Cancel = True
                        Return
                    End If
                    Me.Cursor = Cursors.WaitCursor
                    ArrLabelOPOther.AddNewLabel(Surgery, 9, 300, ContentAlignment.MiddleLeft)
                    Dim tbl0_4 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim tbl5_14 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, cboAge3.Text, CboAge4.Text)
                    Dim tbl15_49 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim tbl50 As DataTable = ModNewInPatientStatistic.InPatSurgeryFM50(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For I As Integer = 0 To tbl0_4.Rows.Count - 1
                        Age0_4M = tbl0_4.Rows(I).Item(0).ToString
                        Age0_4F = tbl0_4.Rows(I).Item(1).ToString
                        TotalAge0_4M += Age0_4M
                        TotalAge0_4F += Age0_4F
                        Arr0_4MOther.AddNewLabel(Age0_4M, 379, 50, ContentAlignment.MiddleCenter)
                        Arr0_4FOther.AddNewLabel(Age0_4F, 429, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl5_14.Rows.Count - 1
                        Age5_14M = tbl5_14.Rows(I).Item(0).ToString
                        Age5_14F = tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14M += Age5_14M
                        TotalAge5_14F += Age5_14F
                        Arr5_14MOther.AddNewLabel(Age5_14M, 493, 50, ContentAlignment.MiddleCenter)
                        Arr5_14FOther.AddNewLabel(Age5_14F, 543, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To tbl15_49.Rows.Count - 1
                        Age15_49M = tbl15_49.Rows(I).Item(0).ToString
                        Age15_49F = tbl15_49.Rows(I).Item(1).ToString
                        TotalAge15_49M += Age15_49M
                        TotalAge15_49F += Age15_49F
                        Arr15_49MOther.AddNewLabel(Age15_49M, 602, 50, ContentAlignment.MiddleCenter)
                        Arr15_49FOther.AddNewLabel(Age15_49F, 652, 50, ContentAlignment.MiddleCenter)

                    Next
                    For I As Integer = 0 To tbl50.Rows.Count - 1
                        Age50M = tbl50.Rows(I).Item(0).ToString
                        Age50F = tbl50.Rows(I).Item(1).ToString
                        TotalAge50M += Age50M
                        TotalAge50F += Age50F
                        Arr50MOther.AddNewLabel(Age50M, 716, 50, ContentAlignment.MiddleCenter)
                        Arr50FOther.AddNewLabel(Age50F, 766, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotal = ModNewInPatientStatistic.TotalInEachSurgeryPerform(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    TotalSubTotal += SubTotal
                    TopScroll = ArrSubTotalOther.AddNewLabel(SubTotal, 848, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    System.Threading.Thread.Sleep(100)
                    Application.DoEvents()
                    Me.Cursor = Cursors.Default
                Next
                ArrSubTotalLabelOther.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 40)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(TotalAge0_4M, 379, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(TotalAge0_4F, 429, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(TotalAge5_14M, 493, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal5_14FOther.AddNewLabelForSubTotal(TotalAge5_14F, 543, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(TotalAge15_49M, 602, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(TotalAge15_49F, 652, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal50MOther.AddNewLabelForSubTotal(TotalAge50M, 716, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotal50FOther.AddNewLabelForSubTotal(TotalAge50F, 766, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
                ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 848, 50, ContentAlignment.MiddleCenter, TopScroll + 40)
               
            End If
            End If
    End Sub
  
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BgInsurgery.CancellationPending Then
            DoEventBG.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BgInsurgery_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgInsurgery.DoWork
        DoEventBG = e
        LoadInSurgery()
    End Sub

    Private Sub BgInsurgery_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgInsurgery.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        BtnResult.Text = "Result"
        PictLoading.Visible = False
    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgInsurgery.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgInsurgery.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgInsurgery.CancelAsync()
        End If
    End Sub
End Class