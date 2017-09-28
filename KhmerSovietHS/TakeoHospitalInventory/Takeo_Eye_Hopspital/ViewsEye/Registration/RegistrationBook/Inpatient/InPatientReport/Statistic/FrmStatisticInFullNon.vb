Public Class FrmStatisticInFullNon
    Dim ListSurgery As New ArrayList
    Dim ListSurgeryOther As New ArrayList
    Dim ArrLabelSurgery As LabelArray
    Dim ArrLabelSurgeryOther As LabelArray
    Dim ArrSubTotal As LabelArray
    Dim ArrSubTotalOther As LabelArray
    Dim ArrTotalSubTotal As LabelArray
    Dim ArrTotalSubTotalOther As LabelArray
    Dim ArrTotalLabel As LabelArray
    Dim ArrTotalLabelOther As LabelArray
    Dim Index As Integer
    Private DoEventWorker As System.ComponentModel.DoWorkEventArgs
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ArrLabelSurgery = New LabelArray(GroupResult)
        ArrLabelSurgeryOther = New LabelArray(GroupOther)
        ArrSubTotal = New LabelArray(GroupResult)
        ArrSubTotalOther = New LabelArray(GroupOther)
        ArrTotalSubTotal = New LabelArray(GroupResult)
        arrTotalsubTotalOther = New LabelArray(GroupOther)
        ArrTotalLabel = New LabelArray(GroupResult)
        ArrTotalLabelOther = New LabelArray(GroupOther)
        Dim tblSurgeries As DataTable = ModSurgeries.SelectSurgeries
        With ChListSurgery
            For i As Integer = 0 To tblSurgeries.Rows.Count - 1
                .Items.Add(tblSurgeries.Rows(i).Item(1).ToString)
            Next
        End With
        For i As Integer = 0 To ChListSurgery.Items.Count - 1
            ListSurgeryOther.Add(ChListSurgery.Items.Item(i))
        Next
        CboMonth.SelectedIndex = 0
        CboYear.SelectedIndex = 0

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ChListSurgery_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChListSurgery.ItemCheck
        Select Case e.NewValue
            Case CheckState.Checked
                ListSurgeryOther.Remove(ChListSurgery.Text)
                ListSurgery.Add(ChListSurgery.Text)
            Case CheckState.Unchecked
                ListSurgeryOther.Add(ChListSurgery.Text)
                ListSurgery.Remove(ChListSurgery.Text)
        End Select
    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnResult.Click
        If Not BgPayment.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgPayment.RunWorkerAsync()
            BtnResult.Text = "Cancel"
        Else
            BgPayment.CancelAsync()
        End If
    End Sub
    Sub LoadStatisticPayment()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadStatisticPayment))
        Else
            PictLoading.Visible = True
            ' Show Full payment
            If RadioFull.Checked = True Then
                If Rad1.Checked = True Then
                    Dim TopScroll As Integer = 0
                    Dim Surgery As String = ""
                    Dim TotalSubTotal As Integer
                    '  Dim AppandSurgery As String = ""
                    For i As Integer = 0 To Index
                        ArrLabelSurgery.Remove()
                        ArrSubTotal.Remove()
                        ArrTotalSubTotal.Remove()
                        ArrTotalLabel.Remove()
                    Next
                    For Each Surgery In ListSurgery
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgery.AddNewLabel(Surgery, 88, 300, ContentAlignment.MiddleLeft)
                        'AppandSurgery = AppandSurgery & " AND TypeOfOperation<>'" & Surgery & "'"
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.FullPayingSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                        TotalSubTotal += TotalSurgery
                        TopScroll = ArrSubTotal.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                    ArrTotalLabel.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, TopScroll + 50)
                    'TxtTotal.Text = ModNewInPatientStatistic.TotalFullPaying(CboMonth.SelectedIndex + 1, CboYear.Text)
                    'TxtTotalOther.Text = ModNewInPatientStatistic.FullPayingOtherSurgery(AppandSurgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                End If
                If Rad2.Checked = True Then
                    Dim TopScroll As Integer = 0
                    Dim Surgery As String = ""
                    Dim TotalSubTotal As Integer
                    '  Dim AppandSurgery As String = ""
                    For i As Integer = 0 To Index
                        ArrLabelSurgeryOther.Remove()
                        ArrSubTotalOther.Remove()
                        ArrTotalSubTotalOther.Remove()
                        ArrTotalLabelOther.Remove()
                    Next
                    For Each Surgery In ListSurgeryOther
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgeryOther.AddNewLabel(Surgery, 88, 300, ContentAlignment.MiddleLeft)
                        'AppandSurgery = AppandSurgery & " AND TypeOfOperation<>'" & Surgery & "'"
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.FullPayingSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                        TotalSubTotal += TotalSurgery
                        TopScroll = ArrSubTotalOther.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                    ArrTotalLabelOther.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, TopScroll + 50)
                    'TxtTotal.Text = ModNewInPatientStatistic.TotalFullPaying(CboMonth.SelectedIndex + 1, CboYear.Text)
                    'TxtTotalOther.Text = ModNewInPatientStatistic.FullPayingOtherSurgery(AppandSurgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                End If
            End If
            ' show Non Payment
            If RadioNonPay.Checked = True Then
                If Rad1.Checked = True Then
                    Dim Topscroll As Integer = 0
                    Dim Surgery As String
                    Dim TotalSubTotal As Integer = 0
                    'Remove Label 
                    For i As Integer = 0 To Index
                        ArrLabelSurgery.Remove()
                        ArrSubTotal.Remove()
                        ArrTotalSubTotal.Remove()
                        ArrTotalLabel.Remove()
                    Next
                    ' Dim AppandSurgery As String = ""
                    For Each Surgery In ListSurgery
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgery.AddNewLabel(Surgery, 88, 300, ContentAlignment.MiddleLeft)
                        'AppandSurgery = AppandSurgery & " AND TypeOfOperation<>'" & Surgery & "'"
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.NonPayingSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                        TotalSubTotal += TotalSurgery
                        Topscroll = ArrSubTotal.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                    ArrTotalLabel.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, Topscroll + 50)
                End If
                If Rad2.Checked = True Then

                    Dim Topscroll As Integer = 0
                    Dim Surgery As String
                    Dim TotalSubTotal As Integer = 0
                    'Remove Label 
                    For i As Integer = 0 To Index
                        ArrLabelSurgeryOther.Remove()
                        ArrSubTotalOther.Remove()
                        ArrTotalSubTotalOther.Remove()
                        ArrTotalLabelOther.Remove()
                    Next
                    ' Dim AppandSurgery As String = ""
                    For Each Surgery In ListSurgeryOther
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgeryOther.AddNewLabel(Surgery, 88, 300, ContentAlignment.MiddleLeft)
                        'AppandSurgery = AppandSurgery & " AND TypeOfOperation<>'" & Surgery & "'"
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.NonPayingSurgery(Surgery, CboMonth.SelectedIndex + 1, CboYear.Text)
                        TotalSubTotal += TotalSurgery
                        Topscroll = ArrSubTotalOther.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                    ArrTotalLabelOther.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, Topscroll + 50)
                End If
            End If
            If RadioMore50.Checked = True Then
                If Rad1.Checked = True Then
                    Dim Topscroll As Integer = 0
                    Dim TotalSubTotal As Integer = 0
                    Dim surgery As String = ""

                    'Remove Label 
                    For i As Integer = 0 To Index
                        ArrLabelSurgery.Remove()
                        ArrSubTotal.Remove()
                        ArrTotalSubTotal.Remove()
                        ArrTotalLabel.Remove()
                    Next
                    For Each surgery In ListSurgery
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgery.AddNewLabel(surgery, 88, 300, ContentAlignment.MiddleLeft)

                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.PayingLessMore50(surgery, CboMonth.SelectedIndex + 1, CboYear.Text, ">=50")
                        TotalSubTotal += TotalSurgery
                        Topscroll = ArrSubTotal.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalLabel.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, Topscroll + 50)
                    ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                End If
                If Rad2.Checked = True Then
                    Dim Topscroll As Integer = 0
                    Dim TotalSubTotal As Integer = 0
                    Dim surgery As String = ""

                    'Remove Label 
                    For i As Integer = 0 To Index
                        ArrLabelSurgeryOther.Remove()
                        ArrSubTotalOther.Remove()
                        ArrTotalSubTotalOther.Remove()
                        ArrTotalLabelOther.Remove()
                    Next
                    For Each surgery In ListSurgeryOther
                        Me.Cursor = Cursors.WaitCursor
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        ArrLabelSurgeryOther.AddNewLabel(surgery, 88, 300, ContentAlignment.MiddleLeft)

                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.PayingLessMore50(surgery, CboMonth.SelectedIndex + 1, CboYear.Text, ">=50")
                        TotalSubTotal += TotalSurgery
                        Topscroll = ArrSubTotalOther.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, Topscroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalLabelOther.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, Topscroll + 50)
                    ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, Topscroll + 50)
                End If
               
            End If

            If RadioLess50.Checked = True Then
                If Rad1.Checked = True Then
                    Dim TopScroll As Integer = 0
                    Dim TotalSubTotal As Integer = 0
                    Dim surgery As String = ""
                    For i As Integer = 0 To Index
                        ArrLabelSurgery.Remove()
                        ArrSubTotal.Remove()
                        ArrTotalSubTotal.Remove()
                        ArrTotalLabel.Remove()
                    Next
                    For Each surgery In ListSurgery
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        Me.Cursor = Cursors.WaitCursor
                        ArrLabelSurgery.AddNewLabel(surgery, 88, 300, ContentAlignment.MiddleLeft)
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.PayingLessMore50(surgery, CboMonth.SelectedIndex + 1, CboYear.Text, "<50")
                        TotalSubTotal += TotalSurgery
                        TopScroll = ArrSubTotal.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel1.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotal.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                    ArrTotalLabel.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, TopScroll + 50)
                End If
                If Rad2.Checked = True Then
                    Dim TopScroll As Integer = 0
                    Dim TotalSubTotal As Integer = 0
                    Dim surgery As String = ""
                    For i As Integer = 0 To Index
                        ArrLabelSurgeryOther.Remove()
                        ArrSubTotalOther.Remove()
                        ArrTotalSubTotalOther.Remove()
                        ArrTotalLabelOther.Remove()
                    Next
                    For Each surgery In ListSurgeryOther
                        If BgPayment.CancellationPending Then
                            DoEventWorker.Cancel = True
                            Return
                        End If
                        Me.Cursor = Cursors.WaitCursor
                        ArrLabelSurgeryOther.AddNewLabel(surgery, 88, 300, ContentAlignment.MiddleLeft)
                        Dim TotalSurgery As Integer = ModNewInPatientStatistic.PayingLessMore50(surgery, CboMonth.SelectedIndex + 1, CboYear.Text, "<50")
                        TotalSubTotal += TotalSurgery
                        TopScroll = ArrSubTotalOther.AddNewLabel(TotalSurgery, 378, 50, ContentAlignment.MiddleCenter).Top
                        Index = Index + 1
                        SplitContainer1.Panel2.AutoScrollMinSize = New Size(1000, TopScroll + 100)
                        Me.Cursor = Cursors.Default
                        System.Threading.Thread.Sleep(500)
                        Application.DoEvents()
                    Next
                    ArrTotalSubTotalOther.AddNewLabelForSubTotal(TotalSubTotal, 378, 50, ContentAlignment.MiddleCenter, TopScroll + 50)
                    ArrTotalLabelOther.AddNewLabelForSubTotal("Total:", 88, 300, ContentAlignment.BottomRight, TopScroll + 50)
                End If

            End If
        End If

    End Sub
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        If BgPayment.CancellationPending Then
            DoEventWorker.Cancel = True
            Return
        End If
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub RadioNonPay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioNonPay.CheckedChanged
        GroupResult.Text = RadioNonPay.Text
    End Sub

    Private Sub RadioFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioFull.CheckedChanged
        GroupResult.Text = RadioFull.Text
    End Sub

    Private Sub RadioMore50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioMore50.CheckedChanged
        GroupResult.Text = RadioMore50.Text
    End Sub

    Private Sub RadioLess50_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioLess50.CheckedChanged
        GroupResult.Text = RadioLess50.Text
    End Sub

    Private Sub BgPayment_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPayment.DoWork
        DoEventWorker = e
        LoadStatisticPayment()
    End Sub

    Private Sub BgPayment_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPayment.RunWorkerCompleted
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