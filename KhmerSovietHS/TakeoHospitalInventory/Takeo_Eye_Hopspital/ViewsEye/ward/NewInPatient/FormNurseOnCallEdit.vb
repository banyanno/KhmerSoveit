Public Class FormNurseOnCallEdit

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub txtInpatient_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInpatient.KeyDown, txtAdmission.KeyDown, txtDischarged.KeyDown, txtTotal.KeyDown, txtSurgery.KeyDown, txtPostCat.KeyDown, txtPostOther.KeyDown, txtUlcer.KeyDown, txtWaiting.KeyDown, txtOthers.KeyDown, txtNote.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Me.SelectNextControl(CType(sender, Control), True, True, True, True)
        End If
    End Sub

    Private Sub OnlyNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInpatient.KeyPress, txtAdmission.KeyPress, txtDischarged.KeyPress, txtTotal.KeyPress, txtSurgery.KeyPress, txtPostCat.KeyPress, txtPostOther.KeyPress, txtUlcer.KeyPress, txtWaiting.KeyPress, txtOthers.KeyPress
        If sender.Equals(Me.txtInpatient) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtInpatient, e)
        ElseIf sender.Equals(Me.txtAdmission) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtAdmission, e)
        ElseIf sender.Equals(Me.txtDischarged) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtDischarged, e)
        ElseIf sender.Equals(Me.txtTotal) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtTotal, e)
        ElseIf sender.Equals(Me.txtSurgery) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtSurgery, e)
        ElseIf sender.Equals(Me.txtPostCat) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtPostCat, e)
        ElseIf sender.Equals(Me.txtPostOther) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtPostOther, e)
        ElseIf sender.Equals(Me.txtUlcer) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtUlcer, e)
        ElseIf sender.Equals(Me.txtWaiting) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtWaiting, e)
        ElseIf sender.Equals(Me.txtOthers) Then
            Call ModGlobleVariable.OnlyNumber(Me.txtOthers, e)
        End If
    End Sub

    Private Sub Totals()
        Me.txtTotal.Text = (Val(Me.txtInpatient.Text) + Val(Me.txtAdmission.Text)) - Val(Me.txtDischarged.Text)
    End Sub

    Private Sub Surgerys()
        Me.txtSurgery.Text = Val(Me.txtPostCat.Text) + Val(Me.txtPostOther.Text)
    End Sub

    Private Function OtherTotal() As Integer
        Dim NN As Integer
        NN = Val(Me.txtSurgery.Text) + Val(Me.txtUlcer.Text) + Val(Me.txtWaiting.Text) + Val(Me.txtOthers.Text)
        Return NN
    End Function

    Private Sub txtInpatient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInpatient.TextChanged
        Call Totals()
    End Sub

    Private Sub txtAdmission_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdmission.TextChanged
        Call Totals()
    End Sub

    Private Sub txtDischarged_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDischarged.TextChanged
        Call Totals()
    End Sub

    Private Sub txtPostCat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostCat.TextChanged
        Call Surgerys()
    End Sub

    Private Sub txtPostOther_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostOther.TextChanged
        Call Surgerys()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If OtherTotal() <> Me.txtTotal.Text Then
            MsgBox("Please check your data entry. The total is not equal to other amount of patient diseases.", MsgBoxStyle.Information, "Error total")
            Exit Sub
        Else
            DIALOG_UPDATE = MessageBox.Show("Do you really want to update nurse on call information? " & Chr(13) & " " & Chr(13) & "Warning: you are responsible for this operation." & Chr(13) & " " & Chr(13) & "Please verify your information correctly before saving.", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModNewInPatient.UpdateNurseOnCall(Me.DateIn.Text, Me.txtInpatient.Text, Me.txtAdmission.Text, Me.txtDischarged.Text, _
                Me.txtTotal.Text, Me.txtSurgery.Text, Me.txtPostCat.Text, Me.txtPostOther.Text, Me.txtUlcer.Text, Me.txtWaiting.Text, _
                Me.txtOthers.Text, Me.txtNote.Text) = 1 Then
                    MsgBox("Update dailly nurse on call successfully.", MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class