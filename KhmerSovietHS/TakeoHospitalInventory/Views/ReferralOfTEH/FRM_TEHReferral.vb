Public Class FRM_TEHReferral
    Dim DA_Referral As New DSREFFERRAL_TEHTableAdapters.REFFERAL_TEHTableAdapter
    Private Sub FRM_TEHReferral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtReferral, "", ErrReferal) = False Then Exit Sub
        If LblSave.Text = "0" Then
            If MessageBox.Show("Do you want save new referral?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Referral.InsertReferral(TxtReferral.Text, TxtDescription.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new referral.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update referral?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_Referral.UpdateReferral(TxtReferral.Text, TxtDescription.Text, LblSave.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update referral.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class