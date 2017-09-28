Public Interface IUserManagement
    Function SaveNewUser(ByVal user As Object) As Boolean
    Function UpdateUser() As Boolean
    Function GetUID(ByVal uid As Integer) As Department_User
    Function SaveUserIntoDepartment(ByVal dep_user As Object) As Boolean
    Function SaveNewMenu(ByVal Menu As Object) As Boolean
    Function UpdateMenu(ByVal Menu As Object) As Boolean
    Function ChangePwdUser(ByVal user As Object) As Boolean
    Function GetUserNameByID(ByVal pId As Integer) As String
    Function GrantPermistion(ByVal obj As Object) As Boolean
    Function RevokePermistion(ByVal obj As Object) As Boolean
    Function DeleteUser(ByVal UserID As Integer) As Boolean
End Interface
