Public Class FrmDateFollowUP

    Public isClose As Boolean = False


    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        isClose = False
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'If DateFollowUp.Checked = False Then
        '    MsgBox("Please check date followup.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If
        'If DateDischarge.Checked = False Then
        '    MsgBox("Please check date discharge.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If
        Dim DaFollowup As String
        If DateFollowUp.Checked = True Then
            DaFollowup = "'" & Me.DateFollowUp.Value & "'"
        Else
            DaFollowup = "NULL"
        End If
        Dim dialogResult As DialogResult = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If ModNewInPatient.UpdateFollowUp(LblSaveOption.Text, LblDateLeave.Text, DaFollowup) = 1 Then
                MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                isClose = True
                Me.Close()
            Else
                MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub FrmDateFollowUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LblDateLeave.Text = GeteDateServer()
    End Sub
End Class