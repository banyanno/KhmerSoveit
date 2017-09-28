Public Class frmPaymentList

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Sub NumberofRecord()
        Dim i, j As Integer
        For i = 0 To Me.dgvPaymentList.Rows.Count - 1
            j = j + 1
            Me.dgvPaymentList.Rows(i).Cells(0).Value = j
        Next
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentList(Format(Me.dtpDateView.Value, "MM/dd/yyyy"))
        'Dim BalanceStock As Integer
        'For Each Rowt As DataGridViewRow In Me.dgvPaymentList.Rows
        '    BalanceStock = Rowt.Cells.Item("ConPay").Value
        '    If BalanceStock = 0 Then
        '        Rowt.DefaultCellStyle.BackColor = Color.LightGray
        '    End If
        'Next
        NumberofRecord()
    End Sub

    Private Sub cmdViewToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewToday.Click
        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
        NumberofRecord()
    End Sub

    Private Sub dgvPaymentList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentList.CellClick
        Dim i As Integer
        Try
            If Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked Then
                Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Unchecked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = False
                'Me.dgvSearch.Rows(e.RowIndex).Selected = False
            Else
                Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = True
                'Me.dgvSearch.Rows(e.RowIndex).Selected = True
            End If
            For i = 0 To Me.dgvPaymentList.Rows.Count - 1
                If Me.dgvPaymentList.Rows(i).Cells(1).Value = CheckState.Checked Then
                    Me.dgvPaymentList.Rows(i).Selected = True
                Else
                    Me.dgvPaymentList.Rows(i).Selected = False
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvPaymentList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentList.CellDoubleClick
        Dim i As Integer
        For i = 0 To Me.dgvPaymentList.Rows.Count - 1
            With Me.dgvPaymentList.Rows(i)
                If .Selected = True Then
                    RIDs = .Cells(4).Value
                    CONDs = .Cells(7).Value
                    If CONDs = "CR" Then
                        CRID = .Cells(5).Value
                    End If
                End If
            End With
        Next
        Dim frmCashReceipt As New frmCashReceipt
        Dim frmInpatientR As New frmInpatientReceipt
        Dim frmNewOPR As New frmNewOutpatientReceipt
        Dim frmOldOPR As New frmOldOutPatientReceipt
        If CONDs = "IR" Then
            isTrueFalse = True
            frmInpatientR.txtReceiptNumber.Text = RIDs
            frmInpatientR.lblReceiptToPrintID.Text = RIDs
            frmInpatientR.ShowDialog()
            '--------Refresh data------------------
            Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
            NumberofRecord()
            '--------------------------------------
        End If
        If CONDs = "NR" Then
            isTrueFalse = True
            frmNewOPR.txtReceiptNumber.Text = RIDs
            frmNewOPR.lblReceiptToPrintID.Text = RIDs
            frmNewOPR.ShowDialog()
            '--------Refresh data------------------
            Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
            NumberofRecord()
            '--------------------------------------
        End If
        If CONDs = "OR" Then
            isTrueFalse = True
            frmOldOPR.txtReceiptNumber.Text = RIDs
            frmOldOPR.lblReceiptToPrintID.Text = RIDs
            frmOldOPR.ShowDialog()
            '--------Refresh data------------------
            Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
            NumberofRecord()
            '--------------------------------------
        End If
        If CONDs = "CR" Then
            isTrueFalse = True
            frmCashReceipt.txtReceiptNumber.Text = RIDs
            frmCashReceipt.txtCashReceiptNumber.Text = CRID
            frmCashReceipt.lblReceiptToPrintID.Text = CRID
            frmCashReceipt.ShowDialog()
            '--------Refresh data------------------
            Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
            NumberofRecord()
            '--------------------------------------
        End If
    End Sub

    Private Sub dgvPaymentList_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPaymentList.ColumnHeaderMouseClick
        NumberofRecord()
    End Sub

    Private Sub tmrPay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPay.Tick
        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
        NumberofRecord()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim i As Integer
        Dim DialogBox As DialogResult
        If Me.dgvPaymentList.RowCount > 0 Then
            DialogBox = MessageBox.Show("Do you really want to delete this (these) selected receipts?" & Chr(13) & "* Note: The system can restore the deleted data after deletion.", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                For i = 0 To Me.dgvPaymentList.Rows.Count - 1
                    If Me.dgvPaymentList.Rows(i).Cells(1).Value = CheckState.Checked Then
                        Call MReceiptController.DeleteReceipt(Me.dgvPaymentList.Rows(i).Cells(4).Value)
                    End If
                Next
                Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(Date.Now(), "MM/dd/yyyy"))
            Else
                Exit Sub
            End If
        End If
    End Sub

   

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Dim frmUndoDel As New frmUndoDelete
        frmUndoDel.ShowDialog()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class