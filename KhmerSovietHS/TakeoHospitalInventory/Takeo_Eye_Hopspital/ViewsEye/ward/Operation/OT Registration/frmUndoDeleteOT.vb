Public Class frmUndoDeleteOT

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Me.GridOTRegistration.DataSource = ModOTRegistration.SelectDeleteOT(EmptyString(Me.txtPatientNo.Text), Me.DateFrom.Value, Me.DateTo.Value)
    End Sub

    Private Sub MUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUndo.Click
        Try
            Dim index As Integer = ModCommon.GetRowIndexDataGrid(GridOTRegistration)
            Dim OTNo As String = Me.GridOTRegistration.Rows(index).Cells(0).Value
            DIALOG_DELETE = MessageBox.Show(MSG_UndoDelete, "Undo Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DIALOG_DELETE = DialogResult.Yes Then
                If ModOTRegistration.UndoDeleteOT(OTNo) = 1 And ModIOLRegistration.UndoDeleteIOLByOT(OTNo) >= 0 Then
                    MsgBox("Delete OT registration successfully.", MsgBoxStyle.Information, "Delete")
                    Me.GridOTRegistration.DataSource = ModOTRegistration.SelectDeleteOT(EmptyString(Me.txtPatientNo.Text), Me.DateFrom.Value, Me.DateTo.Value)
                Else
                    MsgBox("Error Undo delete OT registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class