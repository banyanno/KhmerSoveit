Public Class frmRates

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.txtRate.Text <> "" Then
            MRates.InsertRates(Me.txtRate.Text.Trim, USER_NAME, Format(Date.Now(), "MMM-dd-yyyy"))
            Me.dgvRates.DataSource = MRates.GetRateChanges()
        End If
    End Sub

    Private Sub frmRates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvRates.DataSource = MRates.GetRateChanges()
    End Sub

    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case 46     'for [.] value ascii
                e.Handled = True
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Private Sub dgvRates_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRates.CellDoubleClick
    '    Dim i As Integer
    '    For i = 0 To Me.dgvRates.Rows.Count - 1
    '        If Me.dgvRates.Rows(i).Selected = True Then
    '            If IsDBNull(Me.dgvRates.Rows(i).Cells(0).Value) Then
    '            Else
    '                Me.txtRate.Text = Me.dgvRates.Rows(0).Cells(0).Value
    '            End If
    '        End If
    '    Next
    'End Sub

    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged

    End Sub
End Class