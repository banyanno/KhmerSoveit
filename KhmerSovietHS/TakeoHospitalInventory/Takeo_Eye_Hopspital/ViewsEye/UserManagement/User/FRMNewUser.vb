Public Class FRMNewUser
    Dim Dset As DataSet
    Public isClose As Boolean = False
    Dim DepDataAdapter As New DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim IUser As IUserManagement = New UserManagementImplement
    Private THIUserContex As New BaseDataContext
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Try
        '    If ValidateTextField(TxtUserName, "Name", ErrUser) = False Or _
        '    ValidateTextField(TxtLoginName, "Login name", ErrUser) = False Or _
        '    ValidateTextField(TxtPwd, "password", ErrUser) = False Or _
        '    ValidateTextField(TxtVerifyPwd, "verify password", ErrUser) = False Then
        '        Exit Sub
        '    Else
        '        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
        '            MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
        '            Me.TxtVerifyPwd.Focus()
        '            Exit Sub
        '        End If
        '        If MsgBox("Do you want to save record?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Save Record") = MsgBoxResult.Yes Then
        '            If AddUserToDataSet() = True Then
        '                If Save_SystemUser() = False Then
        '                    Exit Sub
        '                Else
        '                    Call Load_SystemUser()
        '                    MsgBox("User Information has completely saved.", MsgBoxStyle.Information, "Successful")
        '                    isClose = True
        '                    Me.Close()
        '                    Me.Dispose()
        '                End If

        '            End If
        '        End If
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        'End Try


        'Mine

        Try
            If ValidateTextField(TxtUserName, "Name", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtLoginName, "Login name", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtPwd, "password", ErrUser) = False Then
                Exit Sub
            End If
            If ValidateTextField(TxtVerifyPwd, "verify password", ErrUser) = False Then
                Exit Sub
            End If
            If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
                MsgBox("Password does not match verify password.please Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
                Me.TxtVerifyPwd.Focus()
                Exit Sub
            End If
            If ValidateCombobox(CboDepartment, "", ErrUser) = False Then Exit Sub

            '--- Validate duplicate user name
            Dim V_user = From T_User In THIUserContex.getTHIDataContextUserManagement.Department_Users Where T_User.UserName = UCase(TxtUserName.Text)
            If (V_user.ToList.Count > 0) Then
                MessageBox.Show("Login name already registed in system.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MessageBox.Show("Do you want save new user?", "Takeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            System.Windows.Forms.DialogResult.Yes Then

                Dim user As New Department_User
                user.EmployeeName = TxtUserName.Text.Trim
                user.UserName = TxtUserName.Text.Trim
                user.NewPassword = TxtVerifyPwd.Text.Trim
                user.isHospitalManager = CbHosManager.Checked
                user.isMainStockManager = CbMSManager.Checked
                If IUser.SaveNewUser(user) = True Then
                    Dim Dep_user As New Department_Add_User
                    Dep_user.GroupNo = CInt(CboDepartment.SelectedValue)
                    Dep_user.UserNo = CInt(user.UserID)
                    IUser.SaveUserIntoDepartment(Dep_user)

                    '--- Add Permission for user run end-of-day department
                    With GridEODAccessRight
                        For Each rRow As DataGridViewRow In .Rows
                            Dim EOD_AR As New EOD_ACCESS_RIGHT
                            EOD_AR.UserNo = CInt(user.UserID)
                            EOD_AR.EOD_Right_DepartID = CInt(rRow.Cells("cDepartID").Value)
                            THIUserContex.getTHIDataContextUserManagement.EOD_ACCESS_RIGHTs.InsertOnSubmit(EOD_AR)
                            THIUserContex.getTHIDataContextUserManagement.SubmitChanges()
                        Next
                    End With
                    MessageBox.Show("Save new user successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Function AddUserToDataSet() As Boolean
        On Error GoTo Error_Place
        If UserInfo_Checking() = False Then
            Return False
            Exit Function
        End If
        Dim Drow() As DataRow
       
        Drow = Dset.Tables(0).Select("UserName='" & Me.TxtUserName.Text.Trim & "'")
        If Drow.Length > 0 Then
            MsgBox("This User Name already existed in record.", MsgBoxStyle.Critical, "User Name Exist")
            Me.TxtUserName.Focus()
            Exit Function
        End If

        Dim dr As DataRow
        dr = Me.Dset.Tables(0).NewRow
        dr(1) = Me.TxtUserName.Text
        dr(2) = Me.TxtLoginName.Text.Trim
        dr(3) = EncryptPassword(Me.TxtPwd.Text.ToUpper.Trim)
        dr(4) = "Y"
        dr(5) = 0
        dr(6) = 0
        dr(7) = "N"


        Dset.Tables(0).Rows.Add(dr)
        Return True
Error_Place:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "System Error")
        Return False


        


    End Function
    Private Function UserInfo_Checking() As Boolean
        If Me.TxtUserName.Text.Trim = "" Then
            MsgBox("Please key in employee name.", MsgBoxStyle.Information, "Employee Name")
            Me.TxtUserName.Focus()
            Exit Function
        End If
        If Me.txtUserName.Text.Trim = "" Then
            MsgBox("Please key in user name.", MsgBoxStyle.Information, "UserName")
            Me.txtUserName.Focus()
            Exit Function
        End If
        If Me.TxtPwd.Text.Trim = "" Then
            MsgBox("Please key in password.", MsgBoxStyle.Information, "Password")
            Me.TxtPwd.Focus()
            Exit Function
        End If
        If Me.TxtVerifyPwd.Text.Trim = "" Then
            MsgBox("Please key in verify password.", MsgBoxStyle.Information, "Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Function
        End If
        If Me.TxtPwd.Text.Length <= 5 Then
            MsgBox("Password cannot be less than 6 numbers or characters.", MsgBoxStyle.Critical, "Password Check confirm")
            Me.TxtPwd.Focus()
            Exit Function
        End If
        If Me.TxtVerifyPwd.Text.ToUpper.Trim <> Me.TxtPwd.Text.ToUpper.Trim Then
            MsgBox("Password does not match verify password. Check your verify password.", MsgBoxStyle.Critical, "Password # Verify Password")
            Me.TxtVerifyPwd.Focus()
            Exit Function
        End If
        
        Return True
    End Function
    Private Function EncryptPassword(ByVal strPassword As String)
        Dim CNN As SqlClient.SqlConnection
        CNN = ModGlobleVariable.GENERAL_DAO.getConnection
        If CNN.State = ConnectionState.Closed Then
            CNN.Open()
        End If
        Dim SqlCmd As New SqlClient.SqlCommand("SEncryptPassword", CNN)
        SqlCmd.CommandType = CommandType.StoredProcedure
        With SqlCmd
            .Parameters.Add("@PasswordIn", SqlDbType.VarChar, 100).Value = strPassword.Trim
            .Parameters.Add("@PasswordOut", SqlDbType.VarBinary, 250).Direction = ParameterDirection.Output
            Try
                .ExecuteNonQuery()
                EncryptPassword = .Parameters("@PasswordOut").Value
            Catch ex As Exception
                EncryptPassword = 0
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End With
        CNN.Close()
    End Function

    


    Private Function Save_SystemUser() As Boolean
        'On Error GoTo Error_Place
        Dim CNN As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim da As New SqlClient.SqlDataAdapter
        Dim parm As SqlClient.SqlParameter

        Dim cmd As New SqlClient.SqlCommand("Insert Into tblUser(EmployeeName,UserName,Password,isActive,GroupNo) " & _
                                            " Values(@EmployeeName,@UserName,@Password,@isActive,@GroupNo)", CNN)
        cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 80, "EmployeeName")
        cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50, "UserName")
        cmd.Parameters.Add("@Password", SqlDbType.VarBinary, 250, "Password")
        cmd.Parameters.Add("@isActive", SqlDbType.Char, 1, "isActive")
        cmd.Parameters.Add("@GroupNo", SqlDbType.Int, 4, "GroupNo")
        da.InsertCommand = cmd

        cmd = New SqlClient.SqlCommand("Update tblUser Set EmployeeName=@EmployeeName,UserName=@UserName,Password=@Password," _
                            & " isActive=@isActive,isBadLogIn=@isBadLogIn,GroupNo=@GroupNo Where SystemUserID = @SystemUserID", CNN)
        parm = cmd.Parameters.Add("@SystemUserID", SqlDbType.Int, 4, "SystemUserID")
        cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar, 80, "EmployeeName")
        cmd.Parameters.Add("@UserName", SqlDbType.VarChar, 50, "UserName")
        cmd.Parameters.Add("@Password", SqlDbType.VarBinary, 250, "Password")
        cmd.Parameters.Add("@isActive", SqlDbType.Char, 1, "isActive")
        cmd.Parameters.Add("@isBadLogIn", SqlDbType.Char, 1, "isBadLogIn")
        cmd.Parameters.Add("@GroupNo", SqlDbType.Int, 4, "GroupNo")
        parm.SourceVersion = DataRowVersion.Original
        da.UpdateCommand = cmd

        cmd = New SqlClient.SqlCommand("Delete from  tblUser Where SystemUserID = @SystemUserID", CNN)
        parm = cmd.Parameters.Add("@SystemUserID", SqlDbType.Int, 4, "SystemUserID")
        parm.SourceVersion = DataRowVersion.Original
        da.DeleteCommand = cmd

        Try
            da.Update(Me.Dset, "Table")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
            CNN.Close()
            cmd.Dispose()
            da.Dispose()
            Return False
        End Try
        CNN.Close()
        cmd.Dispose()
        da.Dispose()
    End Function

    Private Sub FRMNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'modGetData.RecursivelyFormatForWinXP(Me)
           
            'Call modGetData.Load_Employee(Me.cboEmployeeName)
            Call Load_SystemUser()
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


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_SystemUser()
        Dim CNN As SqlClient.SqlConnection
        CNN = ModGlobleVariable.GENERAL_DAO.getConnection
        If CNN.State = ConnectionState.Closed Then
            CNN.Open()
        End If
        Dim StrSql As String = "Select U.UserID,U.EmployeeName,U.UserName,U.Password,U.isActive," _
                                & " U.GroupNo,D.DepartName,U.isBadLogIn From Department_User U INNER JOIN " _
                                & " tblDepartment D ON U.GroupNo=D.DepartID Order By UserName"
        Dim SqlDa As New SqlClient.SqlDataAdapter(StrSql, CNN)
        Dset = New DataSet
        Try
            SqlDa.Fill(Dset)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        CNN.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateCombobox(CbDepartment, "", ErrUser) = False Then
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