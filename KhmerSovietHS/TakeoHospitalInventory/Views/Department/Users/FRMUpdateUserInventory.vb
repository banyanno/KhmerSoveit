Imports System.Data.Common

Public Class FRMUpdateUserInventory
    Dim DepDataAdapter As New DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim DADepartmentByUserID As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Public DAEODAccessRight As New DSUserManagementTableAdapters.VEODAccessRightTableAdapter

    Private THIUserContex As New BaseDataContext

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        With CboDepartment
            .DataSource = DepDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With

        With CbDepartment
            .DataSource = DepDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With

    End Sub

    Private Sub FRMUpdateUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblUserTem As DataTable = DADepartmentByUserID.GetDataByUserID(LblSaveOption.Text)
        For Each row In TblUserTem.Rows
            TxtUserLogin.Text = row("UserName")
            TxtTempUserLogin.Text = row("UserName")
            CboDepartment.SelectedValue = row("GroupNo")
            CbHosManager.Checked = row("isHospitalManager")
            CbMSManager.Checked = row("isMainStockManager")
        Next

        '--- Get department list that user has permission to run EOD
        Dim TempEODAccessRight As New DataTable
        Dim obj(1) As Object
        GridEODAccessRight.Rows.Clear()
        TempEODAccessRight = DAEODAccessRight.GetEODAccessRightByUserID(CInt(LblSaveOption.Text))

        For Each aRow As DataRow In TempEODAccessRight.Rows
            With GridEODAccessRight
                obj(0) = aRow("DepartID")
                obj(1) = aRow("DepartName")
                .Rows.Add(obj)
            End With
        Next

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim TransMsgStatus As String = ""
        If ValidateCombobox(CboDepartment, "", ErrUpdateUser) = False Then Exit Sub
        If ValidateTextField(TxtUserLogin, "", ErrUpdateUser) = False Then Exit Sub
        If ValidateCombobox(CboDepartment, "", ErrUpdateUser) = False Then Exit Sub

        '--- Validate user name already exist
        If TxtUserLogin.Text <> TxtTempUserLogin.Text Then
            Dim V_user = From T_User In THIUserContex.getTHIDataContextUserManagement.Department_Users Where T_User.UserName = UCase(TxtUserLogin.Text)
            If (V_user.ToList.Count > 0) Then
                MessageBox.Show("Login name already registed in system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Do you want update this user?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            '--- Comment 21/02/2012
            'Dim userLogin As New Department_User
            'Dim UserControler As New UserManagementImplement
            'userLogin = UserControler.GetUID(LblSaveOption.Text)
            'userLogin.UserName = TxtUserLogin.Text
            'userLogin.isHospitalManager = CbHosManager.Checked
            'userLogin.isMainStockManager = CbMSManager.Checked
            'If UserControler.UpdateUser = True Then
            '    MessageBox.Show("Upate user login successful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    DialogResult = Windows.Forms.DialogResult.OK
            'Else
            '    MessageBox.Show("Error Upate user login.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

            '--- Update 21/02/2012 batch transaction purpose
            THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            THIUserContex.getTHIDataContextUserManagement.Connection.Open()
            Dim trans As DbTransaction = THIUserContex.getTHIDataContextUserManagement.Connection.BeginTransaction
            THIUserContex.getTHIDataContextUserManagement.Transaction = trans

            Try

                '--- Update Department_User	
                Dim userLogin As New Department_User
                Dim GetUserLogin = From user In THIUserContex.getTHIDataContextUserManagement.Department_Users Where user.UserID = CInt(LblSaveOption.Text)
                userLogin = GetUserLogin.SingleOrDefault
                userLogin.UserName = TxtUserLogin.Text
                userLogin.isHospitalManager = CbHosManager.Checked
                userLogin.isMainStockManager = CbMSManager.Checked
                THIUserContex.getTHIDataContextUserManagement.SubmitChanges()


                '--- Delete EODAccessRight for specific user
                THIUserContex.getTHIDataContextUserManagement.ExecuteCommand("DELETE FROM EOD_ACCESS_RIGHTS WHERE UserNo={0}", Val(LblSaveOption.Text))
                THIUserContex.getTHIDataContextUserManagement.SubmitChanges()

                '--- Insert EODAccessRight for specific user                
                With GridEODAccessRight
                    For Each rRow As DataGridViewRow In .Rows
                        Dim EOD_AR As New EOD_ACCESS_RIGHT
                        EOD_AR.UserNo = CInt(LblSaveOption.Text)
                        EOD_AR.EOD_Right_DepartID = CInt(rRow.Cells("cDepartID").Value)
                        THIUserContex.getTHIDataContextUserManagement.EOD_ACCESS_RIGHTs.InsertOnSubmit(EOD_AR)
                        THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
                    Next
                End With

                Dim DepartUser As New Department_Add_User
                Dim GetDepartUser = From DUser In THIUserContex.getTHIDataContextUserManagement.Department_Add_Users Where DUser.UserNo = CInt(LblSaveOption.Text)
                DepartUser = GetDepartUser.SingleOrDefault
                DepartUser.GroupNo = CInt(CboDepartment.SelectedValue)
                THIUserContex.getTHIDataContextUserManagement.SubmitChanges()

                trans.Commit()
                THIUserContex.getTHIDataContextUserManagement.Connection.Close()

            Catch ex As Exception
                TransMsgStatus = ex.Message
                trans.Rollback()
                THIUserContex.getTHIDataContextUserManagement.Connection.Close()
            Finally
                trans = Nothing
            End Try

            ' Message validation save update request
            If TransMsgStatus = "" Then
                MessageBox.Show("Upate user login successful.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("Error Upate user login." & TransMsgStatus)
            End If

        End If

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateCombobox(CbDepartment, "", ErrUpdateUser) = False Then
            Exit Sub
        End If
        Dim obj(1) As Object
        obj(0) = CbDepartment.SelectedValue
        obj(1) = CbDepartment.Text

        With GridEODAccessRight
            If .Rows.Count = 0 Then
                .Rows.Add(obj)
            Else
                If IsValidateDupDepart(obj, obj(0)) = True Then
                    MessageBox.Show("Department already added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    .Rows.Add(obj)
                End If
            End If
        End With

    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        With GridEODAccessRight
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected department ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Function IsValidateDupDepart(ByVal pObj() As Object, ByVal pDepartID As Integer) As Boolean

        Dim IsExist As Boolean = False

        With GridEODAccessRight
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("cDepartID").Value = pDepartID Then
                    IsExist = True
                    Exit For
                End If
            Next
        End With
        Return IsExist

    End Function


End Class