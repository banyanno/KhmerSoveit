Public Class FrmListUndoPatient

   
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        LoadUndoPatient()
    End Sub

    Private Sub MUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try
            If Me.GridUndoInPatient.Rows.Count > 0 Then
                Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridUndoInPatient)
                Dim NewInNo As String = GridUndoInPatient.Rows(Index).Cells(0).Value
                DIALOG_DELETE = MessageBox.Show("Do you want to undo cancel?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_DELETE = DialogResult.Yes Then
                    If ModNewInPatient.UndoCancelNewInPatient(NewInNo) = 1 And ModNewInPatient.UndoDeleteDiallyBook(NewInNo) >= 0 Then
                        MsgBox("Undo cancel new inpatient successful.", MsgBoxStyle.Information, "Delete")
                        LoadUndoPatient()
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadUndoPatient()
        GridUndoInPatient.DataSource = ModNewInPatient.SelectListNewInPatientDelete(TxtPatientNo.Text.Trim, DateFrom.Value, DateTo.Value)
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub GridUndoInPatient_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridUndoInPatient.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub

    Private Sub FrmListUndoPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class