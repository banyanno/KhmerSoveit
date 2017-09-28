Public Class FormPatientDischarged

    Sub LoadUndoPatient()
        GridUndoInPatient.DataSource = ModNewInPatient.SelectListPatientDischarged(TxtPatientNo.Text.Trim, DateFrom.Value, DateTo.Value)
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call LoadUndoPatient()
    End Sub

    Private Sub MUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try
            If Me.GridUndoInPatient.Rows.Count > 0 Then
                Dim Index As Integer = ModCommon.GetRowIndexDataGrid(GridUndoInPatient)
                Dim NewInNo As String = GridUndoInPatient.Rows(Index).Cells(0).Value
                DIALOG_UPDATE = MessageBox.Show("Do you really want to undo discharged?", "Undo Discharged", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DIALOG_UPDATE = DialogResult.Yes Then
                    If ModNewInPatient.UndoDischargedPatient(NewInNo, "NULL", "NULL") = 1 Then
                        MsgBox("Undo discharged inpatient successfully.", MsgBoxStyle.Information, "Undo Discharged")
                        LoadUndoPatient()
                    Else
                        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKeyString(e)
    End Sub

    Private Sub GridUndoInPatient_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridUndoInPatient.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridUndoInPatient)
    End Sub
End Class