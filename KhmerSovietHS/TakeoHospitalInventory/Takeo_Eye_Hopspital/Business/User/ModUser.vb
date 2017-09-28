Module ModUser
    Function InsertGroup(ByVal groupName As String) As Integer
        Dim sql As String = "Insert Into tblGroup (groupname) values('" & groupName.Replace("'", "''") & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function DeleteGroup(ByVal groupNo As Integer) As Integer
        Dim sql As String = "Delete FROM tblGroup where groupNo=" & groupNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteGroupInUser(ByVal groupNo As Integer) As Integer
        Dim sql As String = "DELETE FROM tbl_group_user WHERE GroupNo=" & groupNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteGroupInGrouopMenu(ByVal groupNo As Integer) As Integer
        Dim sql As String = "DELETE  FROM TblGroupMenu Where GroupNo=" & groupNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function UpdateGroup(ByVal groupNo As Integer, ByVal groupName As String) As Integer
        Dim sql As String = "Update tblGroup set groupName='" & groupName.Replace("'", "''") & "' Where groupNo=" & groupNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Public Function SelectGroup() As DataTable
        Dim sql As String = "Select DepartID,DepartName From tblDepartment"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Public Function SelectGroupNo(ByVal groupName As String) As Integer
        Dim sql As String = "Select GroupNo from tblGroup where groupName='" & groupName.Replace("'", "''") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Public Function SelectGroupByUserID(ByVal UserID As String) As DataTable
        Dim sql As String = "SELECT DepartID,DepartName,UserID FROM V_ShowGroupByUserID Where UserID=" & UserID
        Return ModGlobleVariable.GENERAL_DAO.SelectAsDataTable(sql)
    End Function
    Public Function DeleteGroupByUserID(ByVal UserID As String) As Integer
        Dim sql As String = "DELETE FROM Tbl_Group_User WHERE UserNo=" & UserID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function InsertUserGroup(ByVal UserID As String, ByVal GroupID As String) As Integer
        Dim sql As String = "INSERT INTO Tbl_Group_User (GroupNo,UserNo) VALUES(" & GroupID & "," & UserID & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

   
    Function DeleteGroupMenu(ByVal groupNo As Integer) As Integer
        Dim Sql As String = "Delete From Deppartment_Permistion_Menu Where GroupNo = " & groupNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(Sql)
    End Function

    Public Function SelectMenuNo(ByVal menuName As String) As String
        Dim sql As String = "Select MenuKey From Menu_INVENTORY WHERE MenuDisplay='" & menuName.Replace("'", "''") & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql).ToString
    End Function

    Function InsertGroupMenu(ByVal GroupNo As String, ByVal menuNo As String) As Integer
        Dim Sql As String = "Insert Into Deppartment_Permistion_Menu values('" & GroupNo & "','" & menuNo & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(Sql)
    End Function

    Function InsertUser(ByVal loginName As String, ByVal groupid As Integer) As Integer
        Dim sql As String = "Insert into tbluser (loginName,groupno) values('" & loginName.Replace("'", "''") & "'," & groupid & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateUser(ByVal userid As Integer, ByVal loginName As String, ByVal groupID As Integer) As Integer
        Dim sql As String = "Update tbluser set loginname='" & loginName & "',groupid=" & groupID & " Where userID=" & userid
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteUser(ByVal userid As Integer) As Integer
        Dim sql As String = "Delete from tbluser where SystemUserID=" & userid
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function ChangeUserPwd(ByVal userlogin As String, ByVal password As String) As Integer
        Dim sql As String = "Update tbluser set password ='" & password & "' where LoginName='" & userlogin & "'"
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectUser() As DataTable
        Dim sql As String = "SELECT userid,loginName,GroupName,tbluser.GroupNo FROM tbluser,tblGroup where tbluser.groupno=tblgroup.groupno"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function GetMenuPermission(ByVal loginName As String) As DataTable
        Dim sql As String = "SELECT  Deppartment_Permistion_Menu.MenuNo " & _
                            " FROM    Department_User INNER JOIN " & _
                            " Department_Add_User ON " & _
                            " Department_User.UserID = dbo.Department_Add_User.UserNo" & _
                            " INNER Join" & _
                            " Deppartment_Permistion_Menu ON " & _
                            " Department_Add_User.GroupNo = dbo.Deppartment_Permistion_Menu.GroupNo" & _
                            " WHERE " & _
                            " Department_User.UserName='" & loginName & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    'Function CheckUserLogin(ByVal userName As String, ByVal password As String) As Int64
    '    Dim sql As String = "select count(userid) from tblUser where UserName='" & userName & "' and password='" & password & "'"
    '    Return Convert.ToInt64(generalDAO.SelectDAOAsScalar(sql))
    'End Function
End Module
