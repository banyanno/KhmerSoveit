Public Class FormDeleteResion
    Dim DA_New_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtConsultNote.Text.Trim = "" Then
            MessageBox.Show("Please you fill reasion.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtConsultNote.Focus()
            TxtConsultNote.Select()
            Exit Sub
        End If
        If MessageBox.Show("Do you want delete this consulting?", "Delete or Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_New_Consult.DeleteConsulting(LblDelete.Text, TxtConsultNote.Text, LblConsultID.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'MEyeInventory.StatusLoading(True)
                'TxtPatientNo.Text = GridConsulting.GetRow.Cells("PatientNo").Value
                'ConViewer = 3
                'BgLoadConsult.RunWorkerAsync()
            End If
        End If
    End Sub
End Class