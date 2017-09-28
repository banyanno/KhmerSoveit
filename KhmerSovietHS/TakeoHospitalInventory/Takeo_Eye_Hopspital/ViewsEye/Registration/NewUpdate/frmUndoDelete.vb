Public Class frmUndoDelete

    Dim SD As Integer

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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

    Private Sub dgvPaymentList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentList.CellContentClick

    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Dim i As Integer
        Dim DialogBox As DialogResult
        If Me.dgvPaymentList.RowCount > 0 Then
            DialogBox = MessageBox.Show("Do you really want to restore this (these) selected data receipts?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
            If DialogBox = Windows.Forms.DialogResult.Yes Then
                For i = 0 To Me.dgvPaymentList.Rows.Count - 1
                    If Me.dgvPaymentList.Rows(i).Cells(1).Value = CheckState.Checked Then
                        Call MReceiptController.RedoDeleteReceipt(Me.dgvPaymentList.Rows(i).Cells(4).Value)
                        If dgvPaymentList.Rows(i).Cells("ConGeneral").Value = "OP" Then
                            Dim ReceiptDataContext As IOpticalShop = New OpticalshopImp
                            Dim ObjReceip As RECEIPT = ReceiptDataContext.GetReceiptNo(dgvPaymentList.Rows(i).Cells("ReceiptNo").Value)
                            ObjReceip.IsPaid = 0
                            ReceiptDataContext.UpdateReceiptPay()
                        End If
                    End If
                Next
                If SD = 2 Then
                    Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListDeleteAll()
                ElseIf SD = 1 Then
                    Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListDelete(Format(Me.dtpDateView.Value, "MM/dd/yyyy"), Format(Me.DateTo.Value, "MM/dd/yyyy"))
                End If
            Else
                Exit Sub
            End If
            End If
    End Sub

    Sub NumberofRecord()
        Dim i, j As Integer
        For i = 0 To Me.dgvPaymentList.Rows.Count - 1
            j = j + 1
            Me.dgvPaymentList.Rows(i).Cells(0).Value = j
        Next
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        SD = 1
        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListDelete(Format(Me.dtpDateView.Value, "MM/dd/yyyy"), Format(DateTo.Value, "MM/dd/yyyy"))
        Call NumberofRecord()
    End Sub

    Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAll.Click
        SD = 2
        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListDeleteAll()
        Call NumberofRecord()
    End Sub
End Class