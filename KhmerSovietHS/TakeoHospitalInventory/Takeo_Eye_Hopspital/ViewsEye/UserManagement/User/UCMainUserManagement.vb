Public Class UCMainUserManagement

    Private Sub UCMainUserManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadListOfUser()
        LoadListOfGroup()
    End Sub
    Sub LoadListOfUser()
        Dim TblUser As DataTable = ModUserLogin.SelectListOfUser()
        Dim Index As Integer
        Dim DRow As DataRow
        LsUser.Items.Clear()
        Dim listviewItem As ListViewItem
        If TblUser Is Nothing Then
            Exit Sub
        End If
        For Index = 0 To TblUser.Rows.Count - 1
            DRow = TblUser.Rows(Index)
            listviewItem = LsUser.Items.Add(DRow(0).ToString)
            listviewItem.ImageIndex = 1
            LsUser.Items(Index).SubItems.Add(DRow(1).ToString)
            LsUser.Items(Index).SubItems.Add(DRow(2).ToString)
            LsUser.Items(Index).SubItems.Add(DRow(3).ToString)
        Next Index
    End Sub
    Sub LoadListOfUserByGroup(ByVal GID As Integer)
        Dim TblUser As DataTable = ModUserLogin.SelectListOfUserByGroup(GID)
        Dim Index As Integer
        Dim DRow As DataRow
        LsUser.Items.Clear()
        Dim listviewItem As ListViewItem
        If TblUser Is Nothing Then
            Exit Sub
        End If
        For Index = 0 To TblUser.Rows.Count - 1
            DRow = TblUser.Rows(Index)
            listviewItem = LsUser.Items.Add(DRow(0).ToString)
            listviewItem.ImageIndex = 1
            LsUser.Items(Index).SubItems.Add(DRow(1).ToString)
            LsUser.Items(Index).SubItems.Add(DRow(2).ToString)
            LsUser.Items(Index).SubItems.Add(DRow(3).ToString)
        Next Index
    End Sub

    Sub LoadListOfGroup()
        Dim TblGroup As DataTable = ModUser.SelectGroup()
        Dim Index1 As Integer
        Dim DRow1 As DataRow
        LsGroup.Items.Clear()
        Dim LVITem As ListViewItem
        If TblGroup Is Nothing Then
            Exit Sub
        End If
        For Index1 = 0 To TblGroup.Rows.Count - 1
            DRow1 = TblGroup.Rows(Index1)
            LVITem = LsGroup.Items.Add(DRow1(1).ToString)
            LVITem.ImageIndex = 0
            LsGroup.Items(Index1).SubItems.Add(DRow1(0).ToString)
        Next
    End Sub
    Private Sub NewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserToolStripMenuItem.Click
        Dim FNewUser As New FRMNewUser
        FNewUser.ShowDialog()
        If FNewUser.isClose = True Then
            LoadListOfUser()
        End If
        FNewUser.Close()
        FNewUser.Dispose()
    End Sub

    Private Sub PropertiesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem1.Click
        LoadPropertyGroup()
    End Sub
    Sub LoadPropertyGroup()
        Try
            If LsGroup.SelectedItems(0).SubItems(0).Text = "Administrator" Then
                MsgBox("You can't look properties this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim GroupName As String = LsGroup.SelectedItems(0).SubItems(0).Text, _
                GroupID As String = LsGroup.SelectedItems(0).SubItems(1).Text

                Dim FGroupProperties As New FRMGroupProperties
                FGroupProperties.TxtGroupName.Text = GroupName
                FGroupProperties.LblGroupID.Text = GroupID
                FGroupProperties.Show()
            End If
        Catch ex As Exception
            MsgBox("Could you select group name.", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub NewGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGroupToolStripMenuItem.Click
        Dim FNewGroup As New FRMNewGroup
        FNewGroup.ShowDialog()
        If FNewGroup.isClose = True Then
            LoadListOfGroup()
        End If
        FNewGroup.Close()
        FNewGroup.Dispose()
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        LoadPropertyUser()
    End Sub
    Sub LoadPropertyUser()
        Try
            If LsUser.SelectedItems(0).SubItems(0).Text = "ADMIN" Then
                MsgBox("You can't look properties this user.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim UserLogin As String, UserID As String, FProperties As New FRMPropertiesUser
                UserLogin = LsUser.SelectedItems(0).SubItems(0).Text
                UserID = LsUser.SelectedItems(0).SubItems(2).Text
                FProperties.TxtUserName.Text = UserLogin
                FProperties.LblUserId.Text = UserID
                FProperties.Show()
            End If
        Catch ex As Exception
            MsgBox("Please select user name", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Try
            If LsUser.SelectedItems(0).SubItems(0).Text = "ADMIN" Then
                MsgBox("You can't delete this user.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim UserNo As Integer = LsUser.SelectedItems(0).SubItems(2).Text
                If MsgBox("Do you want to delete this user.", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                    If ModUser.DeleteUser(UserNo) = 1 And ModUser.DeleteGroupByUserID(UserNo) >= 0 Then
                        MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                        LoadListOfUser()
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox("Please select user login name.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteGroupToolStripMenuItem.Click
        Try
            If LsGroup.SelectedItems(0).SubItems(0).Text = "Administrator" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Cashier" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "New Registration" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Old Registration" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Wards" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim GroupNo As Integer = LsGroup.SelectedItems(0).SubItems(1).Text
                If MsgBox(MSG_DELETE, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                    If ModUser.DeleteGroup(GroupNo) = 1 And ModUser.DeleteGroupInUser(GroupNo) >= 0 And ModUser.DeleteGroupInGrouopMenu(GroupNo) > 0 Then
                        MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                        LoadListOfGroup()
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Please select group name.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Try
            Dim FChangeUserPwd As New FrmChangeUserPWD
            FChangeUserPwd.TxtUserName.Text = LsUser.SelectedItems(0).SubItems(0).Text
            FChangeUserPwd.ShowDialog()
            FChangeUserPwd.Close()
            FChangeUserPwd.Dispose()
        Catch ex As Exception
            MessageBox.Show("Please select user to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

    Private Sub LsUser_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LsUser.MouseDoubleClick
        LoadPropertyUser()
    End Sub

    Private Sub LsGroup_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LsGroup.MouseDoubleClick
        LoadPropertyGroup()
    End Sub

    Private Sub BtnNewGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewGroup.Click
        Dim FNewGroup As New FRMNewGroup
        FNewGroup.ShowDialog()
        If FNewGroup.isClose = True Then
            LoadListOfGroup()
        End If
        FNewGroup.Close()
        FNewGroup.Dispose()
    End Sub

    Private Sub BtnDeleteGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteGroup.Click
        Try
            If LsGroup.SelectedItems(0).SubItems(0).Text = "Administrator" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Cashier" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "New Registration" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Old Registration" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            ElseIf LsGroup.SelectedItems(0).SubItems(0).Text = "Wards" Then
                MsgBox("You can't delete this group.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim GroupNo As Integer = LsGroup.SelectedItems(0).SubItems(1).Text
                If MsgBox(MSG_DELETE, MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                    If ModUser.DeleteGroup(GroupNo) = 1 And ModUser.DeleteGroupInUser(GroupNo) >= 0 And ModUser.DeleteGroupInGrouopMenu(GroupNo) > 0 Then
                        MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                        LoadListOfGroup()
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Please select group name.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnPropertyGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPropertyGroup.Click
        LoadPropertyGroup()
    End Sub

    Private Sub BtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewUser.Click
        Dim FNewUser As New FRMNewUser
        FNewUser.ShowDialog()
        If FNewUser.isClose = True Then
            LoadListOfUser()
        End If
        FNewUser.Close()
        FNewUser.Dispose()
    End Sub

    Private Sub BtnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePassword.Click
        Try
            Dim FChangeUserPwd As New FrmChangeUserPWD
            FChangeUserPwd.TxtUserName.Text = LsUser.SelectedItems(0).SubItems(0).Text
            FChangeUserPwd.ShowDialog()
            FChangeUserPwd.Close()
            FChangeUserPwd.Dispose()
        Catch ex As Exception
            MessageBox.Show("Please select user to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub BtnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteUser.Click
        Try
            If LsUser.SelectedItems(0).SubItems(0).Text = "ADMIN" Then
                MsgBox("You can't delete this user.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                Dim UserNo As Integer = LsUser.SelectedItems(0).SubItems(2).Text
                If MsgBox("Do you want to delete this user.", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
                    If ModUser.DeleteUser(UserNo) = 1 And ModUser.DeleteGroupByUserID(UserNo) >= 0 Then
                        MsgBox(MSG_DELETE_SUCCESS, MsgBoxStyle.Information, "Delete")
                        LoadListOfUser()
                    Else
                        MsgBox(MSG_DELETE_ERROR, MsgBoxStyle.Critical, "Error")
                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox("Please select user login name.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnPropertyUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPropertyUser.Click
        LoadPropertyUser()
    End Sub

    Private Sub LsGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsGroup.SelectedIndexChanged
        Try
            Dim GroupID As String = LsGroup.SelectedItems(0).SubItems(1).Text
            LoadListOfUserByGroup(GroupID)
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub BtnViewAllUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllUser.Click
        LoadListOfUser()
    End Sub
End Class
