Module ModOccupation

    Function InsertOccupation(ByVal Occupation As String) As Integer
        Dim sql As String = "INSERT INTO TblOccupation VALUES('" & Occupation & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateOccupation(ByVal OccNo As String, ByVal Occupation As String) As Integer
        Dim sql As String = "UPDATE TblOccupation SET Occupation='" & Occupation & "' WHERE OccNo=" & OccNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteOccupation(ByVal OccNo As String) As Integer
        Dim sql As String = "DELETE FROM TblOccupation WHERE OccNo=" & OccNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectAllOccupation() As DataTable
        Dim sql As String = "SELECT OccNo,Occupation FROM TblOccupation ORDER BY Occupation ASC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

End Module
