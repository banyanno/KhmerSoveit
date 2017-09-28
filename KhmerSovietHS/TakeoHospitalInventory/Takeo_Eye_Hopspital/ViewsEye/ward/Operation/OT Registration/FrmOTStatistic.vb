Imports System.ComponentModel
Public Class FrmOTStatistic
    Dim MyListSurgery As New ArrayList
    Dim MyListSurgeryOther As New ArrayList
    Dim ArrLabelSurgery As LabelArray
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
    'Declare for Surgery Other
    Dim ArrLabelSurgeryOther As LabelArray
    Dim ArrSubTotalLabelOther As LabelArray
    Dim Arr0_4MOther As LabelArray
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
    Private DoEventBG As System.ComponentModel.DoWorkEventArgs
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrLabelSurgery = New LabelArray(GpResult)
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

        ArrLabelSurgeryOther = New LabelArray(GpOther)
        ArrSubTotalLabelOther = New LabelArray(GpOther)
        Arr0_4MOther = New LabelArray(GpOther)
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

        Dim tblSurgeries As DataTable = ModSurgeries.SelectSurgeries
        With ChOperation
            For i As Integer = 0 To tblSurgeries.Rows.Count - 1
                .Items.Add(tblSurgeries.Rows(i).Item(1).ToString)
            Next
        End With
        For I As Integer = 0 To ChOperation.Items.Count - 1
            MyListSurgeryOther.Add(ChOperation.Items.Item(I))
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
    End Sub
    Private Strt As System.Threading.Thread
    Private WithEvents mWorker As New BackgroundWorker
    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgOP.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgOP.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgOP.CancelAsync()
        End If
    End Sub
    

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BgOP.CancellationPending Then
            DoEventBG.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub



    Private Sub ChOperation_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChOperation.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                MyListSurgery.Add(ChOperation.Text)
                MyListSurgeryOther.Remove(ChOperation.Text)
            Case CheckState.Unchecked
                MyListSurgery.Remove(ChOperation.Text)
                MyListSurgeryOther.Add(ChOperation.Text)
        End Select
    End Sub


    Sub loadStatistic()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf loadStatistic))
        Else
            PicLoading.Visible = True
            If RadSurgery.Checked = True Then
                Dim TopScroll As Integer = 0
                For I As Integer = 0 To IndexCount
                    ArrLabelSurgery.Remove()
                    Arr0_4M.Remove()
                    Arr0_4F.Remove()
                    Arr5_14M.Remove()
                    Arr5_14F.Remove()
                    Arr15_49M.Remove()
                    Arr15_49F.Remove()
                    Arr50M.Remove()
                    Arr50F.Remove()
                    ArrSubTotal.Remove()
                    ArrSubTotalLabel.Remove()
                    ArrTotal0_4M.Remove()
                    ArrTotal0_4F.Remove()
                    ArrTotal5_14M.Remove()
                    ArrTotal5_14F.Remove()
                    ArrTotal15_49M.Remove()
                    ArrTotal15_49F.Remove()
                    ArrTotal50M.Remove()
                    ArrTotal50F.Remove()
                    ArrTotalSubTotal.Remove()
                Next
                Dim Age0_4M As Integer
                Dim Age0_4F As Integer
                Dim Age5_14M As Integer
                Dim Age5_14F As Integer
                Dim Age15_49M As Integer
                Dim Age15_49F As Integer
                Dim Age50M As Integer
                Dim Age50F As Integer
                Dim SubTotal As Integer

                Dim TotalAge0_4M As Integer
                Dim TotalAge0_4F As Integer
                Dim TotalAge5_14M As Integer
                Dim TotalAge5_14F As Integer
                Dim TotalAge15_49M As Integer
                Dim TotalAge15_49F As Integer
                Dim TotalAge50M As Integer
                Dim TotalAge50F As Integer
                Dim TotalSubTotal As Integer

                Dim Surgery As String
                Dim ApendSurgery As String = ""
                'Me.Cursor = Cursors.WaitCursor
                For Each Surgery In MyListSurgery
                    If BgOP.CancellationPending Then
                        DoEventBG.Cancel = True
                        Return
                    End If
                    ApendSurgery = ApendSurgery & " AND T2.OperationType<>'" & Surgery & "'"
                    ArrLabelSurgery.AddNewLabel(Surgery, 9, 300, ContentAlignment.BottomLeft)
                    Dim Tbl0_4 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim Tbl5_14 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge3.Text, CboAge4.Text)
                    Dim Tbl15_49 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim Tbl50 As DataTable = ModOTStatistic.TotalNewInSurgery50(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For K As Integer = 0 To Tbl0_4.Rows.Count - 1
                        Age0_4M = Tbl0_4.Rows(K).Item(0).ToString
                        Age0_4F = Tbl0_4.Rows(K).Item(1).ToString
                        TotalAge0_4M += Age0_4M
                        TotalAge0_4F += Age0_4F
                        Arr0_4M.AddNewLabel(Age0_4M, 350, 50, ContentAlignment.MiddleCenter)
                        Arr0_4F.AddNewLabel(Age0_4F, 393, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl5_14.Rows.Count - 1
                        Age5_14M = Tbl5_14.Rows(I).Item(0).ToString
                        Age5_14F = Tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14M += Age5_14M
                        TotalAge5_14F += Age5_14F
                        Arr5_14M.AddNewLabel(Age5_14M, 456, 50, ContentAlignment.MiddleCenter)
                        Arr5_14F.AddNewLabel(Age5_14F, 499, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl15_49.Rows.Count - 1
                        Age15_49M = Tbl15_49.Rows(I).Item(0).ToString
                        Age15_49F = Tbl15_49.Rows(I).Item(1).ToString
                        TotalAge15_49M += Age15_49M
                        TotalAge15_49F += Age15_49F
                        Arr15_49M.AddNewLabel(Age15_49M, 556, 50, ContentAlignment.MiddleCenter)
                        Arr15_49F.AddNewLabel(Age15_49F, 599, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl50.Rows.Count - 1
                        Age50M = Tbl50.Rows(I).Item(0).ToString
                        Age50F = Tbl50.Rows(I).Item(1).ToString
                        TotalAge50M += Age50M
                        TotalAge50F += Age50F
                        Arr50M.AddNewLabel(Age50M, 662, 50, ContentAlignment.MiddleCenter)
                        Arr50F.AddNewLabel(Age50F, 705, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotal = ModOTStatistic.TotalEachSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    TotalSubTotal += SubTotal
                    TopScroll = ArrSubTotal.AddNewLabel(SubTotal, 788, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1

                    Me.Cursor = Cursors.Default
                    SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()
                Next
                ArrSubTotalLabel.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 50)
                ArrTotal0_4M.AddNewLabelForSubTotal(TotalAge0_4M, 350, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal0_4F.AddNewLabelForSubTotal(TotalAge0_4F, 393, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14M.AddNewLabelForSubTotal(TotalAge5_14M, 456, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14F.AddNewLabelForSubTotal(TotalAge5_14F, 499, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49M.AddNewLabelForSubTotal(TotalAge15_49M, 556, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49F.AddNewLabelForSubTotal(TotalAge15_49F, 599, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50M.AddNewLabelForSubTotal(TotalAge50M, 662, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50F.AddNewLabelForSubTotal(TotalAge50F, 705, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 788, 50, ContentAlignment.MiddleCenter, TopScroll + 50)

                TxtTotal.Text = ModOTStatistic.TotalNewInSurgery(CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                TxtTotalOther.Text = ModOTStatistic.TotalOtherSurgery(ApendSurgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)


            End If
            If RadOther.Checked = True Then
                Dim TopScroll As Integer = 0
                For I As Integer = 0 To IndexCount
                    ArrLabelSurgeryOther.Remove()
                    Arr0_4MOther.Remove()
                    Arr0_4FOther.Remove()
                    Arr5_14MOther.Remove()
                    Arr5_14FOther.Remove()
                    Arr15_49MOther.Remove()
                    Arr15_49FOther.Remove()
                    Arr50MOther.Remove()
                    Arr50FOther.Remove()
                    ArrSubTotalOther.Remove()

                    ArrSubTotalLabelOther.Remove()
                    ArrTotal0_4MOther.Remove()
                    ArrTotal0_4FOther.Remove()
                    ArrTotal5_14MOther.Remove()
                    ArrTotal5_14FOther.Remove()
                    ArrTotal15_49MOther.Remove()
                    ArrTotal15_49FOther.Remove()
                    ArrTotal50MOther.Remove()
                    ArrTotal50FOther.Remove()
                    ArrTotalSubTotalOther.Remove()
                Next
                Dim Age0_4M As Integer
                Dim Age0_4F As Integer
                Dim Age5_14M As Integer
                Dim Age5_14F As Integer
                Dim Age15_49M As Integer
                Dim Age15_49F As Integer
                Dim Age50M As Integer
                Dim Age50F As Integer
                Dim SubTotal As Integer

                Dim TotalAge0_4M As Integer
                Dim TotalAge0_4F As Integer
                Dim TotalAge5_14M As Integer
                Dim TotalAge5_14F As Integer
                Dim TotalAge15_49M As Integer
                Dim TotalAge15_49F As Integer
                Dim TotalAge50M As Integer
                Dim TotalAge50F As Integer
                Dim TotalSubTotal As Integer

                Dim Surgery As String
                ' Dim ApendSurgery As String = ""

                For Each Surgery In MyListSurgeryOther
                    If BgOP.CancellationPending Then
                        DoEventBG.Cancel = True
                        Return
                    End If
                    Me.Cursor = Cursors.WaitCursor
                    'ApendSurgery = ApendSurgery & " AND T2.OperationType<>'" & Surgery & "'"
                    ArrLabelSurgeryOther.AddNewLabel(Surgery, 9, 300, ContentAlignment.BottomLeft)
                    Dim Tbl0_4 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    Dim Tbl5_14 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge3.Text, CboAge4.Text)
                    Dim Tbl15_49 As DataTable = ModOTStatistic.TotalNewInSurgeryM_F(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge5.Text, CboAge6.Text)
                    Dim Tbl50 As DataTable = ModOTStatistic.TotalNewInSurgery50(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                    For K As Integer = 0 To Tbl0_4.Rows.Count - 1
                        Age0_4M = Tbl0_4.Rows(K).Item(0).ToString
                        Age0_4F = Tbl0_4.Rows(K).Item(1).ToString
                        TotalAge0_4M += Age0_4M
                        TotalAge0_4F += Age0_4F
                        Arr0_4MOther.AddNewLabel(Age0_4M, 350, 50, ContentAlignment.MiddleCenter)
                        Arr0_4FOther.AddNewLabel(Age0_4F, 393, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl5_14.Rows.Count - 1
                        Age5_14M = Tbl5_14.Rows(I).Item(0).ToString
                        Age5_14F = Tbl5_14.Rows(I).Item(1).ToString
                        TotalAge5_14M += Age5_14M
                        TotalAge5_14F += Age5_14F
                        Arr5_14MOther.AddNewLabel(Age5_14M, 456, 50, ContentAlignment.MiddleCenter)
                        Arr5_14FOther.AddNewLabel(Age5_14F, 499, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl15_49.Rows.Count - 1
                        Age15_49M = Tbl15_49.Rows(I).Item(0).ToString
                        Age15_49F = Tbl15_49.Rows(I).Item(1).ToString
                        TotalAge15_49M += Age15_49M
                        TotalAge15_49F += Age15_49F
                        Arr15_49MOther.AddNewLabel(Age15_49M, 556, 50, ContentAlignment.MiddleCenter)
                        Arr15_49FOther.AddNewLabel(Age15_49F, 599, 50, ContentAlignment.MiddleCenter)
                    Next
                    For I As Integer = 0 To Tbl50.Rows.Count - 1
                        Age50M = Tbl50.Rows(I).Item(0).ToString
                        Age50F = Tbl50.Rows(I).Item(1).ToString
                        TotalAge50M += Age50M
                        TotalAge50F += Age50F
                        Arr50MOther.AddNewLabel(Age50M, 662, 50, ContentAlignment.MiddleCenter)
                        Arr50FOther.AddNewLabel(Age50F, 705, 50, ContentAlignment.MiddleCenter)
                    Next
                    SubTotal = ModOTStatistic.TotalEachSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                    TotalSubTotal += SubTotal
                    TopScroll = ArrSubTotalOther.AddNewLabel(SubTotal, 788, 50, ContentAlignment.MiddleCenter).Top
                    IndexCount = IndexCount + 1
                    SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                    Me.Cursor = Cursors.Default
                    System.Threading.Thread.Sleep(500)
                    Application.DoEvents()

                Next
                ArrSubTotalLabelOther.AddNewLabelForSubTotal("Total:", 7, 100, ContentAlignment.BottomRight, TopScroll + 50)
                ArrTotal0_4MOther.AddNewLabelForSubTotal(TotalAge0_4M, 350, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal0_4FOther.AddNewLabelForSubTotal(TotalAge0_4F, 393, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14MOther.AddNewLabelForSubTotal(TotalAge5_14M, 456, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal5_14FOther.AddNewLabelForSubTotal(TotalAge5_14F, 499, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49MOther.AddNewLabelForSubTotal(TotalAge15_49M, 556, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal15_49FOther.AddNewLabelForSubTotal(TotalAge15_49F, 599, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50MOther.AddNewLabelForSubTotal(TotalAge50M, 662, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotal50FOther.AddNewLabelForSubTotal(TotalAge50F, 705, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 788, 50, ContentAlignment.MiddleCenter, TopScroll + 50)

                'TxtTotal.Text = ModOTStatistic.TotalNewInSurgery(CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
                'TxtTotalOther.Text = ModOTStatistic.TotalOtherSurgery(ApendSurgery, CboMonth.SelectedIndex + 1, CboYear.Text, CboAge1.Text, CboAge2.Text)
            End If
        End If
       

    End Sub

    


    Private Sub mWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles mWorker.DoWork
        System.Threading.Thread.Sleep(5000)
        loadStatistic()
    End Sub

    Private Sub BgOP_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgOP.DoWork
        DoEventBG = e
        loadStatistic()
    End Sub

    Private Sub BgOP_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgOP.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        BtnResult.Text = "Result"
        PicLoading.Visible = False
    End Sub
End Class