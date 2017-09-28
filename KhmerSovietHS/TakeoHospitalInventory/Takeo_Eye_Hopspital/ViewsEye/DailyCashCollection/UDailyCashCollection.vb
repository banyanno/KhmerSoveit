Public Class UCashCollection

    Dim DAAccountPayable As New DSAccountPayableTableAdapters.V_ACCOUNT_PAYABLE_DETAILTableAdapter
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        '-----------------DataGridView all-------------------------------
        Me.GridCashCollection.DataSource = MCashCollection.DailyCashCollection(Me.dtpDateFrom.Value)
        '-----------------Income Summary---------------------------------
        Dim i, j As Integer
        'Dim TotalUSD, TotalRIEL As Double
        Dim tblIncomeSummary As DataTable = MCashCollection.IncomeSummary(Me.dtpDateFrom.Value)
        Dim RowIS As DataRow
        If tblIncomeSummary.Rows.Count > 0 Then
            For i = 0 To tblIncomeSummary.Rows.Count - 1
                RowIS = tblIncomeSummary.Rows(i)
                With RowIS
                    Me.txtOPUSD.Text = .Item(0).ToString
                    Me.txtOPRiel.Text = .Item(1).ToString
                    Me.txtIPUSD.Text = .Item(2).ToString
                    Me.txtIPRiel.Text = .Item(3).ToString
                    Me.txtEGUSD.Text = .Item(4).ToString
                    Me.txtEGRiel.Text = .Item(5).ToString
                    Me.txtMUSD.Text = .Item(6).ToString
                    Me.txtMRiel.Text = .Item(7).ToString
                    Me.txtOUSD.Text = .Item(8).ToString
                    Me.txtORiel.Text = .Item(9).ToString
                    Me.txtTotalUSD.Text = .Item(10).ToString
                    Me.txtTotalRiel.Text = .Item(11).ToString
                End With
            Next
        End If
        '--------------------Remarks or Account Receivable---------------
        Me.dgvRemarks.DataSource = MCashCollection.DailyRemarks(Me.dtpDateFrom.Value)
        Me.GridAccountPayable.DataSource = DAAccountPayable.GetDataByCurrentDate(dtpDateFrom.Value)
        Dim tblRemarkNote As DataTable = MCashCollection.SelectRemarksNote(dtpDateFrom.Value.Date)
        If tblRemarkNote.Rows.Count > 0 Then
            For Each row As DataRow In tblRemarkNote.Rows
                LblRemarkNoteID.Text = row("RemarkID")
                TxtRemarkNote.Text = row("Remarks")
            Next
        Else
            LblRemarkNoteID.Text = "0"
            TxtRemarkNote.Text = ""
        End If
        '--------------------Total Remarks and Income Summary------------
        'Dim tblRemarks As DataTable = MCashCollection.TotalDailyRemarks(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"))
        'Dim RowRem As DataRow
        'If tblRemarks.Rows.Count > 0 Then
        '    For j = 0 To tblRemarks.Rows.Count - 1
        '        RowRem = tblRemarks.Rows(j)
        '        With RowRem
        '            TotalUSD = IIf(IsDBNull(.Item(0)) = False, .Item(0), 0)
        '            TotalRIEL = IIf(IsDBNull(.Item(1)) = False, .Item(1), 0)
        '        End With
        '    Next
        'End If
        'Me.txtTotalUSD.Text = Val(Me.txtTotalUSD.Text) + TotalUSD
        'Me.txtTotalRiel.Text = Val(Me.txtTotalRiel.Text) + TotalRIEL
        '--------------------Show Cash Count----------------------------
        Call ClearCashCount()
        Call ShowCashCount()
    End Sub

    Private Sub cmdCreateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateNew.Click
        Dim frmAccRec As New frmAccountName
        frmAccRec.ShowDialog()
    End Sub

    Private Function USDRielCal(ByVal AmountDR As Integer, ByVal USDRIEL As Double) As Double
        Dim SubTotal As Double
        SubTotal = AmountDR * USDRIEL
        Return SubTotal
    End Function

    Private Function TotalCountUSD() As Double
        Dim TotalUSD As Double
        TotalUSD = Val(Me.txt100D.Text) + Val(Me.txt50D.Text) + Val(Me.txt20D.Text) + Val(Me.txt10D.Text) + Val(Me.txt5D.Text) + Val(Me.txt1D.Text)
        Return TotalUSD
    End Function

    Private Function TotalCountRIEL() As Double
        Dim TotalRIEL As Double
        TotalRIEL = Val(Me.txt100000Rs.Text) + Val(Me.txt50000Rs.Text) + Val(Me.txt20000Rs.Text) + Val(Me.txt10000Rs.Text) + Val(Me.txt5000Rs.Text) + Val(Me.txt2000Rs.Text) + Val(Me.txt1000Rs.Text) + Val(Me.txt500Rs.Text) + Val(Me.txt100Rs.Text) + Val(Me.txt50Rs.Text)
        Return TotalRIEL
    End Function

    Private Sub txt100USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt100USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt50USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt50USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt1USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt100USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt100USD.LostFocus
        If Me.txt100USD.Text = "" Then
            Me.txt100USD.Text = "0"
        End If
    End Sub

    Private Sub txt100USD_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt100USD.MouseClick
        Me.txt100USD.SelectAll()
    End Sub

    Private Sub txt100USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt100USD.TextChanged
        If Me.txt100USD.Text <> "" Then
            Me.txt100D.Text = USDRielCal(100, Me.txt100USD.Text)
        Else
            Me.txt100D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt50USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt50USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt20USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt20USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt100USD.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt100USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt50USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt50USD.LostFocus
        If Me.txt50USD.Text = "" Then
            Me.txt50USD.Text = "0"
        End If
    End Sub

    Private Sub txt50USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt50USD.TextChanged
        If Me.txt50USD.Text <> "" Then
            Me.txt50D.Text = USDRielCal(50, Me.txt50USD.Text)
        Else
            Me.txt50D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt20USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt20USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt10USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt10USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt50USD.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt50USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt20USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt20USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt20USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt20USD.LostFocus
        If Me.txt20USD.Text = "" Then
            Me.txt20USD.Text = "0"
        End If
    End Sub

    Private Sub txt20USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt20USD.TextChanged
        If Me.txt20USD.Text <> "" Then
            Me.txt20D.Text = USDRielCal(20, Me.txt20USD.Text)
        Else
            Me.txt20D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt10USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt10USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt5USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt5USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt20USD.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt20USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt10USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt10USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt10USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt10USD.LostFocus
        If Me.txt10USD.Text = "" Then
            Me.txt10USD.Text = "0"
        End If
    End Sub

    Private Sub txt10USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt10USD.TextChanged
        If Me.txt10USD.Text <> "" Then
            Me.txt10D.Text = USDRielCal(10, Me.txt10USD.Text)
        Else
            Me.txt10D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt5USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt5USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt1USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt1USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt10USD.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt10USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt5USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt5USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt5USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5USD.LostFocus
        If Me.txt5USD.Text = "" Then
            Me.txt5USD.Text = "0"
        End If
    End Sub

    Private Sub txt5USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt5USD.TextChanged
        If Me.txt5USD.Text <> "" Then
            Me.txt5D.Text = USDRielCal(5, Me.txt5USD.Text)
        Else
            Me.txt5D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt1USD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt1USD.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt100USD.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt100USD.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt5USD.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt5USD.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt1USD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1USD.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt1USD_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1USD.LostFocus
        If Me.txt1USD.Text = "" Then
            Me.txt1USD.Text = "0"
        End If
    End Sub

    Private Sub txt1USD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1USD.TextChanged
        If Me.txt1USD.Text <> "" Then
            Me.txt1D.Text = USDRielCal(1, Me.txt1USD.Text)
        Else
            Me.txt1D.Text = "0"
        End If
        Me.txtTotalUSDCount.Text = TotalCountUSD()
    End Sub

    Private Sub txt100000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt100000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.txt50000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt50000R.Focus()
                e.Handled = True
            Case Keys.Up
                Me.txt50R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt100000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt100000R.LostFocus
        If Me.txt100000R.Text = "" Then
            Me.txt100000R.Text = "0"
        End If
    End Sub

    Private Sub txt100000R_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt100000R.MouseClick
        Me.txt100000R.SelectAll()
    End Sub

    Private Sub txt100000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt100000R.TextChanged
        If Me.txt100000R.Text <> "" Then
            Me.txt100000Rs.Text = USDRielCal(100000, Me.txt100000R.Text)
        Else
            Me.txt100000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt50000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt50000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt100000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt100000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt20000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt20000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt50000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt50000R.LostFocus
        If Me.txt50000R.Text = "" Then
            Me.txt50000R.Text = "0"
        End If
    End Sub

    Private Sub txt50000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt50000R.TextChanged
        If Me.txt50000R.Text <> "" Then
            Me.txt50000Rs.Text = USDRielCal(50000, Me.txt50000R.Text)
        Else
            Me.txt50000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt20000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt20000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt50000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt50000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt10000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt10000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt20000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt20000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt20000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt20000R.LostFocus
        If Me.txt20000R.Text = "" Then
            Me.txt20000R.Text = "0"
        End If
    End Sub

    Private Sub txt20000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt20000R.TextChanged
        If Me.txt20000R.Text <> "" Then
            Me.txt20000Rs.Text = USDRielCal(20000, Me.txt20000R.Text)
        Else
            Me.txt20000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt10000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt10000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt20000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt20000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt5000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt5000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt10000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt10000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt10000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt10000R.LostFocus
        If Me.txt10000R.Text = "" Then
            Me.txt10000R.Text = "0"
        End If
    End Sub

    Private Sub txt10000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt10000R.TextChanged
        If Me.txt10000R.Text <> "" Then
            Me.txt10000Rs.Text = USDRielCal(10000, Me.txt10000R.Text)
        Else
            Me.txt10000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt5000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt5000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt10000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt10000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt2000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt2000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt5000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt5000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt5000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5000R.LostFocus
        If Me.txt5000R.Text = "" Then
            Me.txt5000R.Text = "0"
        End If
    End Sub

    Private Sub txt5000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt5000R.TextChanged
        If Me.txt5000R.Text <> "" Then
            Me.txt5000Rs.Text = USDRielCal(5000, Me.txt5000R.Text)
        Else
            Me.txt5000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt2000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt2000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt5000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt5000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt1000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt1000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt2000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt2000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2000R.LostFocus
        If Me.txt2000R.Text = "" Then
            Me.txt2000R.Text = "0"
        End If
    End Sub

    Private Sub txt2000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2000R.TextChanged
        If Me.txt2000R.Text <> "" Then
            Me.txt2000Rs.Text = USDRielCal(2000, Me.txt2000R.Text)
        Else
            Me.txt2000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt1000R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt1000R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt2000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt2000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt500R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt500R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt1000R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1000R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt1000R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1000R.LostFocus
        If Me.txt1000R.Text = "" Then
            Me.txt1000R.Text = "0"
        End If
    End Sub

    Private Sub txt1000R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1000R.TextChanged
        If Me.txt1000R.Text <> "" Then
            Me.txt1000Rs.Text = USDRielCal(1000, Me.txt1000R.Text)
        Else
            Me.txt1000Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt500R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt500R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt1000R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt1000R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt100R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt100R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt500R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt500R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt500R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt500R.LostFocus
        If Me.txt500R.Text = "" Then
            Me.txt500R.Text = "0"
        End If
    End Sub

    Private Sub txt500R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt500R.TextChanged
        If Me.txt500R.Text <> "" Then
            Me.txt500Rs.Text = USDRielCal(500, Me.txt500R.Text)
        Else
            Me.txt500Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt100R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt100R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt500R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt500R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt50R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt50R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt100R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt100R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt100R.LostFocus
        If Me.txt100R.Text = "" Then
            Me.txt100R.Text = "0"
        End If
    End Sub

    Private Sub txt100R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt100R.TextChanged
        If Me.txt100R.Text <> "" Then
            Me.txt100Rs.Text = USDRielCal(100, Me.txt100R.Text)
        Else
            Me.txt100Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Sub txt50R_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt50R.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Me.txt100R.Focus()
                e.Handled = True
            Case Keys.Left
                Me.txt100R.Focus()
                e.Handled = True
            Case Keys.Right
                Me.txt100000R.Focus()
                e.Handled = True
            Case Keys.Down
                Me.txt100000R.Focus()
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50R_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt50R.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txt50R_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt50R.LostFocus
        If Me.txt50R.Text = "" Then
            Me.txt50R.Text = "0"
        End If
    End Sub

    Private Sub txt50R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt50R.TextChanged
        If Me.txt50R.Text <> "" Then
            Me.txt50Rs.Text = USDRielCal(50, Me.txt50R.Text)
        Else
            Me.txt50Rs.Text = "0"
        End If
        Me.txtTotalRielCount.Text = TotalCountRIEL()
    End Sub

    Private Function CheckSaveCashCount() As Boolean
        If Me.txt100USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt100USD.Focus()
            Return False
        ElseIf Me.txt50USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt50USD.Focus()
            Return False
        ElseIf Me.txt20USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt20USD.Focus()
            Return False
        ElseIf Me.txt10USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt10USD.Focus()
            Return False
        ElseIf Me.txt5USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt5USD.Focus()
            Return False
        ElseIf Me.txt1USD.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt1USD.Focus()
            Return False
        ElseIf Me.txtTotalUSDCount.Text = "" Then
            MsgBox("Please enter any amount or at least zero." & Chr(13) & "You can re-type any amount then it is automatically updated for this total.", MsgBoxStyle.Information, "Amount Check")
            Me.txt100USD.Focus()
            Return False

            '------------RIEL---------------------------
        ElseIf Me.txt100000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt100000R.Focus()
            Return False
        ElseIf Me.txt50000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt50000R.Focus()
            Return False
        ElseIf Me.txt20000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt20000R.Focus()
            Return False
        ElseIf Me.txt10000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt10000R.Focus()
            Return False
        ElseIf Me.txt5000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt5000R.Focus()
            Return False
        ElseIf Me.txt2000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt2000R.Focus()
            Return False
        ElseIf Me.txt1000R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt1000R.Focus()
            Return False
        ElseIf Me.txt500R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt500R.Focus()
            Return False
        ElseIf Me.txt100R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt100R.Focus()
            Return False
        ElseIf Me.txt50R.Text = "" Then
            MsgBox("Please enter any amount or at least zero.", MsgBoxStyle.Information, "Amount Check")
            Me.txt50R.Focus()
            Return False
        ElseIf Me.txtTotalRielCount.Text = "" Then
            MsgBox("Please enter any amount or at least zero." & Chr(13) & "You can re-type any amount then it is automatically updated for this total.", MsgBoxStyle.Information, "Amount Check")
            Me.txt100000R.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckSaveCashCount() = False Then
            Exit Sub
        End If
        If MCashCollection.CheckCashCount(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy")) = True Then
            Dim DialogBox As DialogResult = MessageBox.Show("Do you really want to save these information?", "Save confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                Call MCashCollection.SaveCashCount(IIf(Me.txt100USD.Text > 0, "100 x", ""), Me.txt100USD.Text, Me.txt100D.Text, _
                                    IIf(Me.txt50USD.Text > 0, "50 x", ""), Me.txt50USD.Text, Me.txt50D.Text, _
                                    IIf(Me.txt20USD.Text > 0, "20 x", ""), Me.txt20USD.Text, Me.txt20D.Text, _
                                    IIf(Me.txt10USD.Text > 0, "10 x", ""), Me.txt10USD.Text, Me.txt10D.Text, _
                                    IIf(Me.txt5USD.Text > 0, "5 x", ""), Me.txt5USD.Text, Me.txt5D.Text, _
                                    IIf(Me.txt1USD.Text > 0, "1 x", ""), Me.txt1USD.Text, Me.txt1D.Text, Me.txtTotalUSDCount.Text, _
                                    IIf(Me.txt100000R.Text > 0, "100,000 x", ""), Me.txt100000R.Text, Me.txt100000Rs.Text, _
                                    IIf(Me.txt50000R.Text > 0, "50,000 x", ""), Me.txt50000R.Text, Me.txt50000Rs.Text, _
                                    IIf(Me.txt20000R.Text > 0, "20,000 x", ""), Me.txt20000R.Text, Me.txt20000Rs.Text, _
                                    IIf(Me.txt10000R.Text > 0, "10,000 x", ""), Me.txt10000R.Text, Me.txt10000Rs.Text, _
                                    IIf(Me.txt5000R.Text > 0, "5,000 x", ""), Me.txt5000R.Text, Me.txt5000Rs.Text, _
                                    IIf(Me.txt2000R.Text > 0, "2,000 x", ""), Me.txt2000R.Text, Me.txt2000Rs.Text, _
                                    IIf(Me.txt1000R.Text > 0, "1,000 x", ""), Me.txt1000R.Text, Me.txt1000Rs.Text, _
                                    IIf(Me.txt500R.Text > 0, "500 x", ""), Me.txt500R.Text, Me.txt500Rs.Text, _
                                    IIf(Me.txt100R.Text > 0, "100 x", ""), Me.txt100R.Text, Me.txt100Rs.Text, _
                                    IIf(Me.txt50R.Text > 0, "50 x", ""), Me.txt50R.Text, Me.txt50Rs.Text, Me.txtTotalRielCount.Text, _
                                    Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), USER_NAME)
                If TxtRemarkNote.Text.Trim <> "" Then
                    MCashCollection.SaveDiallyRemarkNote(dtpDateFrom.Value.Date, TxtRemarkNote.Text)
                End If
            End If
        Else
            Dim Dialogbox As DialogResult
            Dialogbox = MessageBox.Show("This Cash Count is existed in the system. Do you want to update it?" & Chr(13) & "Please click Yes to update and No to cancel this operation.", "Cash Count Existed", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If Dialogbox = Windows.Forms.DialogResult.Yes Then
                Call MCashCollection.UpdateCashCount(IIf(Me.txt100USD.Text > 0, "100 x", ""), Me.txt100USD.Text, Me.txt100D.Text, _
                                IIf(Me.txt50USD.Text > 0, "50 x", ""), Me.txt50USD.Text, Me.txt50D.Text, _
                                IIf(Me.txt20USD.Text > 0, "20 x", ""), Me.txt20USD.Text, Me.txt20D.Text, _
                                IIf(Me.txt10USD.Text > 0, "10 x", ""), Me.txt10USD.Text, Me.txt10D.Text, _
                                IIf(Me.txt5USD.Text > 0, "5 x", ""), Me.txt5USD.Text, Me.txt5D.Text, _
                                IIf(Me.txt1USD.Text > 0, "1 x", ""), Me.txt1USD.Text, Me.txt1D.Text, Me.txtTotalUSDCount.Text, _
                                IIf(Me.txt100000R.Text > 0, "100,000 x", ""), Me.txt100000R.Text, Me.txt100000Rs.Text, _
                                IIf(Me.txt50000R.Text > 0, "50,000 x", ""), Me.txt50000R.Text, Me.txt50000Rs.Text, _
                                IIf(Me.txt20000R.Text > 0, "20,000 x", ""), Me.txt20000R.Text, Me.txt20000Rs.Text, _
                                IIf(Me.txt10000R.Text > 0, "10,000 x", ""), Me.txt10000R.Text, Me.txt10000Rs.Text, _
                                IIf(Me.txt5000R.Text > 0, "5,000 x", ""), Me.txt5000R.Text, Me.txt5000Rs.Text, _
                                IIf(Me.txt2000R.Text > 0, "2,000 x", ""), Me.txt2000R.Text, Me.txt2000Rs.Text, _
                                IIf(Me.txt1000R.Text > 0, "1,000 x", ""), Me.txt1000R.Text, Me.txt1000Rs.Text, _
                                IIf(Me.txt500R.Text > 0, "500 x", ""), Me.txt500R.Text, Me.txt500Rs.Text, _
                                IIf(Me.txt100R.Text > 0, "100 x", ""), Me.txt100R.Text, Me.txt100Rs.Text, _
                                IIf(Me.txt50R.Text > 0, "50 x", ""), Me.txt50R.Text, Me.txt50Rs.Text, Me.txtTotalRielCount.Text, _
                                Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"), USER_NAME, Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"))
                If LblRemarkNoteID.Text <> "0" Then
                  
                    MCashCollection.UpdateDaillyRemarkNote(LblRemarkNoteID.Text, TxtRemarkNote.Text)
                Else
                    If TxtRemarkNote.Text.Trim <> "" Then
                        MCashCollection.SaveDiallyRemarkNote(dtpDateFrom.Value.Date, TxtRemarkNote.Text)
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub ShowCashCount()
        Dim i As Integer
        Dim tblCashCount As DataTable = MCashCollection.SelectCashCount(Format(Me.dtpDateFrom.Value, "MM/dd/yyyy"))
        Dim RowCC As DataRow
        If tblCashCount.Rows.Count > 0 Then
            For i = 0 To tblCashCount.Rows.Count - 1
                RowCC = tblCashCount.Rows(i)
                With RowCC
                    Me.txt100USD.Text = .Item(2).ToString
                    Me.txt50USD.Text = .Item(5).ToString
                    Me.txt20USD.Text = .Item(8).ToString
                    Me.txt10USD.Text = .Item(11).ToString
                    Me.txt5USD.Text = .Item(14).ToString
                    Me.txt1USD.Text = .Item(17).ToString
                    Me.txtTotalUSDCount.Text = .Item(19).ToString
                    Me.txt100000R.Text = .Item(21).ToString
                    Me.txt50000R.Text = .Item(24).ToString
                    Me.txt20000R.Text = .Item(27).ToString
                    Me.txt10000R.Text = .Item(30).ToString
                    Me.txt5000R.Text = .Item(33).ToString
                    Me.txt2000R.Text = .Item(36).ToString
                    Me.txt1000R.Text = .Item(39).ToString
                    Me.txt500R.Text = .Item(42).ToString
                    Me.txt100R.Text = .Item(45).ToString
                    Me.txt50R.Text = .Item(48).ToString
                    Me.txtTotalRielCount.Text = .Item(50).ToString
                End With
            Next
        End If
    End Sub

    Sub ClearCashCount()
        Me.txt100USD.Text = "0"
        Me.txt50USD.Text = "0"
        Me.txt20USD.Text = "0"
        Me.txt10USD.Text = "0"
        Me.txt5USD.Text = "0"
        Me.txt1USD.Text = "0"
        Me.txt100000R.Text = "0"
        Me.txt50000R.Text = "0"
        Me.txt20000R.Text = "0"
        Me.txt10000R.Text = "0"
        Me.txt5000R.Text = "0"
        Me.txt2000R.Text = "0"
        Me.txt1000R.Text = "0"
        Me.txt500R.Text = "0"
        Me.txt100R.Text = "0"
        Me.txt50R.Text = "0"
        Me.txt100USD.Focus()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Call ClearCashCount()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Me.cmdPrint.Enabled = False
            Dim frmReportCCD As New frmReportCashCountDaily
            '-------------Report Form Active--------------------------------
            Dim ReportCCD As New ReportCashCountDaily
            Dim TblAccoutPayAble As DataTable = DAAccountPayable.GetDataByCurrentDate(dtpDateFrom.Value)
            ReportCCD.Subreports.Item("ReportCashFlow").SetDataSource(MCashCollection.ReportCashFlowDaily(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy")).Tables(1))
            ReportCCD.Subreports.Item("ReportIncomeSummary").SetDataSource(MCashCollection.ReportIncomeSummaryDaily(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy")).Tables(1))
            ReportCCD.Subreports.Item("ReportRemarksDaily").SetDataSource(MCashCollection.ReportCashRemarksDaily(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy")).Tables(1))
            ReportCCD.Subreports.Item("ReportCashCountDaily").SetDataSource(MCashCollection.ReportCashCountDaily(Format(Me.dtpDateFrom.Value, "MM-dd-yyyy")).Tables(1))
            ReportCCD.Subreports.Item("RemarkNote").SetDataSource(MCashCollection.SelectRemarksNote(dtpDateFrom.Value.Date))
            ReportCCD.Subreports.Item("AccountPayable").SetDataSource(TblAccoutPayAble)
            frmReportCCD.crvReportCashCountDaily.ReportSource = ReportCCD
            ReportCCD.Refresh()
            '-------Parameter for Date from to date to-----------------
            'Dim DateFromTo As ParameterField
            'DateFromTo = ReportCCW.ParameterFields("txtDateFromTo")
            'DateFromTo.CurrentValues.AddValue("Date: " & Format(Me.dtpDateFrom.Value, "dd/MM/yyyy") & " to: " & Format(Me.dtpDateTo.Value, "dd/MM/yyyy"))
            frmReportCCD.ShowDialog()
            Me.cmdPrint.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

    Private Sub cmdViewAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAR.Click
        Dim frmAccRec As New frmAccountReceivable
        frmAccRec.ShowDialog()
    End Sub
End Class
