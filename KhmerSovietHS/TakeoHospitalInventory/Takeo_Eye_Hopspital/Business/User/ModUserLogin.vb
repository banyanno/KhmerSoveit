Module ModUserLogin
   

    Public Function checkPassword(ByVal userName As String, ByVal userPassword As String) As Integer
        ' On Error GoTo Error_Place
        Try
            Dim CnnForLogin As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
            Dim SQL_Comman_Login As New SqlClient.SqlCommand
            SQL_Comman_Login = CnnForLogin.CreateCommand()
            SQL_Comman_Login.CommandText = "SUserValidation"
            SQL_Comman_Login.CommandType = CommandType.StoredProcedure
            With SQL_Comman_Login
                .Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName
                .Parameters.Add("@userPassword", SqlDbType.VarChar, 250).Value = userPassword
                .Parameters.Add("@RoleAccess", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output
                .Parameters.Add("@retValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
                .ExecuteNonQuery()
                checkPassword = Convert.ToInt32(.Parameters("@retValue").Value) 'lOGIN SUCCESSFULLY
                USER_NAME = userName
                'nEmployeeID = IIf(IsDBNull(.Parameters("@staffID").Value), 0, .Parameters("@staffID").Value)
                RoleAccess = IIf(IsDBNull(.Parameters("@RoleAccess").Value), 0, .Parameters("@RoleAccess").Value)
            End With
            SQL_Comman_Login.Dispose()
            CnnForLogin.Close()
            Exit Function
        Catch ex As Exception
            'CnnForLogin.Close()
            MsgBox(ex.Message + "System error. Error occured at " & Err.Description & ". " & vbCrLf & "Please contact system administrator.", MsgBoxStyle.Critical, "ERROR")
            checkPassword = 10
        End Try

        'Error_Place:

    End Function

    Public Sub changePassword(ByVal userName As String, ByVal newPassword As String)
        Dim CnnForLogin As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SQL_Comman_Login As New SqlClient.SqlCommand
        SQL_Comman_Login = CnnForLogin.CreateCommand()
        SQL_Comman_Login.CommandText = "SChangePassword"
        SQL_Comman_Login.CommandType = CommandType.StoredProcedure
        With SQL_Comman_Login
            .Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = UCase(userName)
            .Parameters.Add("@Password", SqlDbType.VarChar, 255).Value = UCase(newPassword)
            .ExecuteNonQuery()
        End With
        SQL_Comman_Login.Dispose()
        CnnForLogin.Close()
    End Sub
    Public Sub Load_User(ByVal CmbName As ComboBox)
        Dim CnnForLogin As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SQL_Comman_Login As New SqlClient.SqlCommand
        Dim StrSql As String = "Select SystemUserID,UserName From tblUser Order By UserName"
        Dim SqlDa As New SqlClient.SqlDataAdapter(StrSql, CnnForLogin)
        Dim Dset As New DataSet
        Try
            SqlDa.Fill(Dset, "tblUser")
            CmbName.DataSource = Dset.Tables("tblUser")
            CmbName.ValueMember = Dset.Tables("tblUser").Columns("SystemUserID").ColumnName
            CmbName.DisplayMember = Dset.Tables("tblUser").Columns("UserName").ColumnName
            SqlDa.Dispose()
            CnnForLogin.Close()
        Catch ex As Exception
            SqlDa.Dispose()
            CnnForLogin.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
        CnnForLogin.Close()
    End Sub
    Public Function GetLoginLog(ByVal staffid As Long, ByVal bankID As Long, ByVal IPAddress As String, ByVal HostName As String, ByRef strerror As String) As Boolean
        On Error GoTo Err_Message
        Dim CnnForLogin As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        Dim SQL_Comman_Login As New SqlClient.SqlCommand
        Dim sqlCmd As New SqlClient.SqlCommand
        CnnForLogin = ModGlobleVariable.GENERAL_DAO.getConnection
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "zLoginLog"
        sqlCmd.Connection = CnnForLogin

        sqlCmd.Parameters.Add("@staffid", SqlDbType.Int).Value = staffid
        sqlCmd.Parameters.Add("@bankID", SqlDbType.Int).Value = bankID
        sqlCmd.Parameters.Add("@ipAddress", SqlDbType.VarChar, 30).Value = IPAddress
        sqlCmd.Parameters.Add("@HostName", SqlDbType.VarChar, 50).Value = HostName
        sqlCmd.Parameters.Add("@strError", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output

        sqlCmd.ExecuteNonQuery()
        strerror = sqlCmd.Parameters("@strError").Value
        sqlCmd.Dispose()
        CnnForLogin.Close()

        If strerror.Trim = "" Then
            Return True
        End If

        Return False
Err_Message:
        CnnForLogin.Close()
        strerror = "System error. Error occured at " & Err.Description & ". " & vbCrLf & "Please contact system administrator."
        Return False
    End Function

    Function SelectRoles() As DataTable
        Dim sql As String = "SELECT DISTINCT DepartName from V_User where UserName='" & USER_NAME & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectListOfUser() As DataTable
        Dim sql As String = "SELECT UserName,Password,UserID,EmployeeName FROM Department_User"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectListOfUserByGroup(ByVal GroupID As Integer) As DataTable
        Dim sql As String = "SELECT UserName,Password,UserID,EmployeeName FROM Department_User,Department_Add_User WHERE Department_Add_User.UserNo=Department_User.UserID AND Department_Add_User.GroupNo=" & GroupID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
