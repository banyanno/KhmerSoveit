Public Class NewDr
    Dim DA_Dr As New DSMedicalCertificateTableAdapters.MEDICAL_DRTableAdapter
   
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtDrname, "", ErrDr) = False Then Exit Sub
        If ValidateTextField(TxtSkill, "", ErrDr) = False Then Exit Sub
        If lblSave.Text = "0" Then
            If MessageBox.Show("Do you want save new Dr?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Dr.InserMedicalDr(TxtDrname.Text, TxtSkill.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
            
        Else
            If MessageBox.Show("Do you want update Dr?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Dr.UpdateMedicalDr(TxtDrname.Text, TxtSkill.Text, lblSave.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class