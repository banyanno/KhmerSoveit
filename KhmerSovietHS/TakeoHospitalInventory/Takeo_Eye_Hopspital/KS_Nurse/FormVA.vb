Public Class FormVA
    Dim DAPatient As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to send to doctor consult?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DA_Waiting.UpdatePatientStatus(TxtNote.Text, "2", "2", LblWating.Text) = 1 Then
                If DA_VA.UpdateVA(TxtRE.Text, TxtRPh.Text, TxtRREF.Text, TxtRRE.Text, TxtLE.Text, TxtLPh.Text, TxtLREF.Text, TxtLLE.Text, TxtNote.Text, TxtIOPRE.Text, TxtIOPLE.Text, CDbl(LblWating.Text)) >= 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'Else
                    '    MessageBox.Show("")
                End If
               
            End If
        End If
    End Sub
End Class