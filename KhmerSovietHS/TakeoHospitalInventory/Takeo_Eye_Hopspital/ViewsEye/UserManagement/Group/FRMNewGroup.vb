Public Class FRMNewGroup
    Public isClose As Boolean = False
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtGroupName, "group name", ErrGroup) = False Then
            Exit Sub
        Else
            If LblSaveOption.Text = "0" Then
                If MsgBox(MSG_SAVE, MsgBoxStyle.YesNo, "Save") = MsgBoxResult.Yes Then
                    If ModUser.InsertGroup(TxtGroupName.Text) = 1 Then
                        MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                        Me.isClose = True
                        Me.Close()
                        Me.Dispose()
                    Else
                        MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Else
                If MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.YesNo, "Update") = MsgBoxResult.Yes Then
                    If ModUser.UpdateGroup(LblSaveOption.Text, TxtGroupName.Text) = 1 Then
                        MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                        Me.isClose = True
                        Me.Close()
                        Me.Dispose()
                    Else
                        MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        End If
    End Sub
End Class