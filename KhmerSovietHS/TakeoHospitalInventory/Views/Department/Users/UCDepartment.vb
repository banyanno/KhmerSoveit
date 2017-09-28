Imports Janus.Windows.GridEX

Public Class UCDepartment
    Dim DepDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim MenuDataAdapter As New DSUserManagementTableAdapters.Menu_INVENTORYTableAdapter
    Dim UserDataAdapter As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Dim DAPermission As New DSUserManagementTableAdapters.VGroupPermistionTableAdapter
    Dim departRepo As IDepartRepository = New DepartRepository
    Dim DepTableTemplate As DataTable

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DepDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    '' User Management user
    Public Sub InitDepartment()
        Dim TblDepTem As DataTable = DepDataAdapter.GetData
        Dim Index1 As Integer
        Dim DRow1 As DataRow
        Dim LVITem As ListViewItem
        LsDepartment.Items.Clear()
        If TblDepTem Is Nothing Then
            Exit Sub
        End If
        For Index1 = 0 To TblDepTem.Rows.Count - 1
            DRow1 = TblDepTem.Rows(Index1)
            LVITem = LsDepartment.Items.Add(DRow1(1).ToString)
            LVITem.ImageIndex = 0
            'LsDepartment.Items(Index1).SubItems.Add(DRow1(0).ToString)
            LVITem.SubItems.Add(DRow1(0).ToString)
        Next
        Me.LsDepartment.Items(0).Selected = True
    End Sub
    
    Private Sub BtnViewAllUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllUser.Click
        Dim TblUser As DataTable = UserDataAdapter.GetData
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsUser.Items.Clear()
        If TblUser Is Nothing Then
            Exit Sub
        End If
        LsUser.Items.Clear()
        For index As Integer = 0 To TblUser.Rows.Count - 1
            DRow = TblUser.Rows(index)
            LVItem = LsUser.Items.Add(DRow("UserName").ToString)
            LVItem.ImageIndex = 2
            LVItem.SubItems.Add(DRow("UserID").ToString)

        Next
        Try
            LsPermistion.Items(0).Selected = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub UCDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load department display in gridview
        ' BindIntoDataGrid()
    End Sub
   
    Public Sub LoadUserByGroup(ByVal GID As Integer)

        Dim TblUser As DataTable = UserDataAdapter.GetDataUserByGroup(GID)
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblUser Is Nothing Then
            Exit Sub
        End If
        LsUser.Items.Clear()
        For index As Integer = 0 To TblUser.Rows.Count - 1
            DRow = TblUser.Rows(index)
            LVItem = LsUser.Items.Add(DRow("UserName").ToString)
            LVItem.ImageIndex = 2
            ' LsUser.Items(index).SubItems.Add(DRow("UserID").ToString)
            LVItem.SubItems.Add(DRow("UserID").ToString)
        Next
    End Sub
    Public Sub LoadPermissionByGroup(ByVal GID As Integer)
        Dim TblPermission As DataTable = DAPermission.GetDataByGroupNo(GID)
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblPermission Is Nothing Then
            Exit Sub
        End If
        For index As Integer = 0 To TblPermission.Rows.Count - 1
            DRow = TblPermission.Rows(index)
            LVItem = LsPermistion.Items.Add(DRow("MenuDisplay").ToString)
            LVItem.ImageIndex = 1
            LVItem.SubItems.Add(DRow("MenuNo").ToString).Tag = DRow("MenuNo")
            LVItem.Tag = DRow("MenuNo")
        Next
        Try
            LsPermistion.Items(0).Selected = True
        Catch ex As Exception

        End Try
    End Sub
    Public Sub InitMenu()
        Dim TblMenu As DataTable = MenuDataAdapter.GetData
        Dim DRow As DataRow
        Dim LVItem As ListViewItem
        LsPermistion.Items.Clear()
        If TblMenu Is Nothing Then
            Exit Sub
        End If
        For index As Integer = 0 To TblMenu.Rows.Count - 1
            DRow = TblMenu.Rows(index)
            LVItem = LsPermistion.Items.Add(DRow("MenuDisplay").ToString)
            LVItem.ImageIndex = 1
            LVItem.SubItems.Add(DRow("MenuNo").ToString).Tag = DRow("MenuNo")
            LVItem.Tag = DRow("MenuNo")            
        Next
        Try
            LsPermistion.Items(0).Selected = True
        Catch ex As Exception

        End Try

    End Sub
    

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FDep As New frmDepartment(Me)
        FDep.ShowDialog()
        FDep.Close()
        FDep.Dispose()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        InitDepartment()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If LsDepartment.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select department name to edit.", "Edit", MessageBoxButtons.OK)
        Else
            Dim FDep As New frmDepartment(Me)
            FDep.lblSaveOption.Text = "1"
            FDep.departID = LsDepartment.SelectedItems(0).SubItems(1).Text
            FDep.txtDepartName.Text = LsDepartment.SelectedItems(0).Text
            If FDep.ShowDialog() = DialogResult.OK Then
                InitDepartment()
            End If
            FDep.Close()
            FDep.Dispose()
        End If
        'If Not GridDepartment.CurrentRow Is Nothing AndAlso GridDepartment.CurrentRow.RowType = RowType.Record Then
        '   
        'End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim depart As New tblDepartment
        'Dim departTransMsgStatus As String = ""

        'If MessageBox.Show("Do you want delete department ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '    If Not GridDepartment.CurrentRow Is Nothing AndAlso GridDepartment.CurrentRow.RowType = RowType.Record Then
        '        depart = departRepo.GetDepartByID(GridDepartment.GetValue("DepartID"))
        'departTransMsgStatus = departRepo.DeleteDepart(depart)

        '        If departTransMsgStatus <> "True" Then
        '            MsgBox("Error delete department.", MsgBoxStyle.Critical, "Error : " & departTransMsgStatus)
        '        Else
        '            MessageBox.Show("Delete department successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            BindIntoDataGrid()
        '        End If
        '    Else
        '        MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If
        'End If

    End Sub

    Private Sub GridDepartment_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmSubMain.UpdateLabelStatus("Double click to update department information", True)
    End Sub

    Private Sub GridDepartment_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmSubMain.UpdateLabelStatus("", False)
    End Sub

    Private Sub BgLoadingDepartment_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingDepartment.DoWork
        DepTableTemplate = DepDataAdapter.GetData
    End Sub

    Private Sub BgLoadingDepartment_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingDepartment.RunWorkerCompleted
        'GridDepartment.DataSource = DepTableTemplate

    End Sub

    Private Sub BtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewUser.Click

        'Dim FrmNewUser As New FormNewUserInventory
        'If FrmNewUser.ShowDialog = DialogResult.OK Then
        '    ' LoadUserByGroup(LsDepartment.SelectedItems(0).Tag)
        'End If
        'FrmNewUser.Dispose()
        'FrmNewUser.Close()

        Dim FrmNewUser As New FRMNewUser
        If FrmNewUser.ShowDialog = DialogResult.OK Then
            ' LoadUserByGroup(LsDepartment.SelectedItems(0).Tag)
        End If
        FrmNewUser.Dispose()
        FrmNewUser.Close()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FrmNewMenu As New FormNewMenuInventory
        If FrmNewMenu.ShowDialog = DialogResult.OK Then
            InitMenu()
        End If
        FrmNewMenu.Dispose()
        FrmNewMenu.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllPermission.Click
        InitMenu()
    End Sub

    Private Sub MenuGrantToDepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuGrantToDepart.Click
        Try
            'If LsDepartment.SelectedItems(0).SubItems(0).Text = "Administrator" Then
            '    MsgBox("You can't look properties of this department.", MsgBoxStyle.Information, "Info")
            '    Exit Sub
            'Else
            Dim GroupName As String = LsDepartment.SelectedItems(0).SubItems(0).Text
            Dim GroupID As String = LsDepartment.SelectedItems(0).SubItems(1).Text
            Dim FGroupProperties As New FRMGroupProperties
            FGroupProperties.TxtGroupName.Text = GroupName
            FGroupProperties.LblGroupID.Text = GroupID
            If FGroupProperties.ShowDialog = DialogResult.OK Then
                LsDepartment_SelectedIndexChanged(sender, e)
            End If
            'End If
        Catch ex As Exception
            MsgBox("Please select department name." & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try



    End Sub

    Private Sub LsDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LsDepartment.SelectedIndexChanged
        If LsDepartment.SelectedItems.Count = 0 Then
            LsUser.Items.Clear()
            LsPermistion.Items.Clear()
        Else
            Dim GroupID As String = LsDepartment.SelectedItems(0).SubItems(1).Text
            LoadUserByGroup(GroupID)
            LoadPermissionByGroup(GroupID)
        End If
    End Sub


    Private Sub BtnPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPermission.Click
        Try
            'If LsDepartment.SelectedItems(0).SubItems(0).Text = "Administrator" Then
            '    MsgBox("You can't look properties of this department.", MsgBoxStyle.Information, "Info")
            '    Exit Sub
            'Else
            Dim GroupName As String = LsDepartment.SelectedItems(0).SubItems(0).Text
            Dim GroupID As String = LsDepartment.SelectedItems(0).SubItems(1).Text
            Dim FGroupProperties As New FRMGroupProperties
            FGroupProperties.TxtGroupName.Text = GroupName
            FGroupProperties.LblGroupID.Text = GroupID
            If FGroupProperties.ShowDialog = DialogResult.OK Then
                LsDepartment_SelectedIndexChanged(sender, e)
            End If
            'End If
        Catch ex As Exception
            MsgBox("Please select department name." & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnMenuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMenuEdit.Click
        If LsPermistion.SelectedItems.Count = 0 Then
            MsgBox("Please selected permission to edit.", MsgBoxStyle.Information, "Info")
        Else

            Dim NewMenu As New FormNewMenuInventory
            'NewMenu.LblSaveOption.Text = LsPermistion.SelectedItems(0).Tag
            NewMenu.LblSaveOption.Text = LsPermistion.SelectedItems(0).SubItems(1).Tag
            NewMenu.TxtMenuDisplay.Text = LsPermistion.SelectedItems(0).Text
            'NewMenu.TxtMenuKey.Text = LsPermistion.SelectedItems(0).SubItems(1).Tag

            If NewMenu.ShowDialog = DialogResult.OK Then
                LoadPermissionByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
            End If
        End If
        'MsgBox(LsPermistion.)
    End Sub

    Private Sub BtnEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditUser.Click

        If LsUser.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select user to edit.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim FrmNewUser As New FRMUpdateUserInventory
            FrmNewUser.LblSaveOption.Text = LsUser.SelectedItems(0).SubItems(1).Text
            If FrmNewUser.ShowDialog = DialogResult.OK Then
                LoadUserByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
            End If
            FrmNewUser.Dispose()
            FrmNewUser.Close()
        End If

    End Sub

    Private Sub BtnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePassword.Click

        If LsUser.SelectedItems.Count = 0 Then
            MsgBox("Please select user to change password.", MsgBoxStyle.Information)
        Else
            Dim FChangePwd As New FRMChangePwdInventory
            FChangePwd.LblUserID.Text = LsUser.SelectedItems(0).SubItems(1).Text
            FChangePwd.TxtLoginName.Text = LsUser.SelectedItems(0).Text
            FChangePwd.ShowDialog()
        End If

    End Sub

   
    Private Sub BtnPropertyUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteUser.Click
        If LsUser.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select user to edit.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Do you want to delete this user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim IUser As New UserManagementImplement
                If IUser.DeleteUser(LsUser.SelectedItems(0).SubItems(1).Text) = True Then
                    MessageBox.Show("Delete user succesfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadUserByGroup(LsDepartment.SelectedItems(0).SubItems(1).Text)
                Else
                    MessageBox.Show("Error Delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If

    End Sub
End Class
