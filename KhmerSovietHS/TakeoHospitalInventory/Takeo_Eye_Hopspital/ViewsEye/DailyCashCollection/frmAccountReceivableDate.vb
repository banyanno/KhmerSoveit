Public Class frmAccountReceivableDate

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If DIALOG_UPDATE = DialogResult.Yes Then
                Call MAccountReceivable.UpdateDateAccReceipt(AIDAR, Format(Me.dtpDate.Value, "MM/dd/yyyy"))
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmAccountReceivableDate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.dtpDate.Value = DateAR
    End Sub
End Class