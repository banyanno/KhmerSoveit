Public Class FLabo
    Dim DA_LABO As New DS_Invest_LaserTableAdapters.S_LABORATORYTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtLaboratory, "", ErrLabo) = False Then Exit Sub
        If ValidateTextField(TxtLaboPrice, "", ErrLabo) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to save new Laboratory?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_LABO.InsertNewLabo(TxtLaboratory.Text, EmptyString(TxtLaboPrice.Text)) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update Laboratory?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_LABO.UpdateLabo(TxtLaboratory.Text, EmptyString(TxtLaboPrice.Text), LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtLaboPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLaboPrice.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class