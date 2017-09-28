Module ModSurgeries
    Function InsertNewSurgeries(ByVal SurgeriesType As String, ByVal SurgeriesDescription As String, ByVal Type As Boolean, ByVal SurgeriesFee As Double) As Integer
        Dim sql As String = "INSERT INTO TblDiagSurgeries (Surgeries,Description,Type,SurgeriesFee) VALUES('" & SurgeriesType & "','" & SurgeriesDescription & "','" & Type & "'," & SurgeriesFee & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function CheckSurgeries(ByVal Surgeries As String) As Integer
        Dim sql As String = "SELECT COUNT(Surgeries) FROM TblDiagSurgeries Where Surgeries='" & Surgeries & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function UpdateSurgeries(ByVal SurID As String, ByVal Surgeries As String, ByVal Description As String, ByVal Type As Boolean, ByVal SurgeriesFee As Double) As Integer
        Dim sql As String = "UPDATE TblDiagSurgeries SET Surgeries='" & Surgeries & "',Description='" & Description & "', Type='" & Type & "',SurgeriesFee=" & SurgeriesFee & " WHERE SID=" & SurID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteSurgeries(ByVal SurID As String) As Integer
        Dim sql As String = "DELETE FROM TblDiagSurgeries WHERE SID=" & SurID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectSurgeriesByType(ByVal Surgeries As String) As DataTable
        Dim sql As String = "SELECT * FROM TblDiagSurgeries WHERE SID IS NOT NULL "
        If Surgeries <> "" Then
            sql = sql & " AND Surgeries LIKE '%" & Surgeries & "%'"
        End If
        sql = sql & " ORDER By Type"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectSurgeries() As DataTable
        Dim sql As String = "SELECT * FROM TblDiagSurgeries Order By Surgeries Asc"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function GetSurgeryPrice(ByVal SurgID As Integer) As Double
        Dim sql As String = "SELECT SurgeriesFee FROM TblDiagSurgeries WHERE SID=" & SurgID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
