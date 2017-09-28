Module ModDiagnosis

    Function InsertMainDiagnosis(ByVal Surgery As String, ByVal Description As String, ByVal Code As String, ByVal Type As Boolean) As Integer
        Dim sql As String = "INSERT INTO tblSurgery (Surgery,Description,Code,Type) VALUES('" & Surgery.Replace("'", "''") & "','" & Description.Replace("'", "''") & "','" & Code & "','" & Type & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function CheckNameDiagnosis(ByVal Diagnosis As String) As Int16
        Dim sql As String = "SELECT COUNT(Surgery)  FROM tblSurgery WHERE Surgery='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function CheckNameSurgery(ByVal SurgeryName As String) As Integer
        Dim SQL As String = "SELECT COUNT(Surgeries) FROM tblDiagSurgeries WHERE  Surgeries='" & SurgeryName & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(SQL)
    End Function
    Function UpdateMainDiagnosis(ByVal SID As String, ByVal Surgery As String, ByVal Description As String, ByVal code As String, ByVal Type As Boolean) As Integer
        Dim sql As String = "UPDATE tblSurgery SET Surgery='" & Surgery.Replace("'", "''") & "',Description='" & Description.Replace("'", "''") & "',Code='" & code & "' , Type ='" & Type & "' WHERE SID=" & SID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteMainDiagnosis(ByVal sid As String) As Integer
        Dim sql As String = "DELETE FROM tblSurgery where sid=" & sid
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Public Function SelectMainSurgery() As DataTable
        Dim sql As String = "SELECT * FROM tblSurgery Order By Surgery Asc"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectDiagnosisTypeOther(ByVal Diagnosis As String) As Boolean
        Dim sql As String = "SELECT Type FROM TblSurgery WHERE Surgery='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function SelectMainDiagnosis(ByVal Diagnosis As String) As DataTable
        Dim sql As String = "SELECT * FROM tblSurgery"
        If Diagnosis <> "" Then
            sql = sql & " WHERE Surgery LIKE '%" & Diagnosis & "%'"
        End If
        sql = sql & " ORDER By Type "
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function InsertSubDiagnosis(ByVal SID As String, ByVal Surgerysub As String, ByVal Description As String, ByVal Code As String) As Integer
        Dim sql As String = "INSERT INTO tblSurgerySub (SID,Surgerysub,Description,code) VALUES(" & SID & ",'" & Surgerysub.Replace("'", "''") & "','" & Description.Replace("'", "''") & "','" & Code & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateSubDiagnosis(ByVal SIDS As String, ByVal SID As String, ByVal Surgerysub As String, ByVal Description As String, ByVal code As String) As Integer
        Dim sql As String = "UPDATE tblSurgerySub SET SID='" & SID & "', Surgerysub='" & Surgerysub.Replace("'", "''") & "',Description='" & Description.Replace("'", "''") & "',Code='" & code & "' where SSID=" & SIDS
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteSubDiagnosis(ByVal SID As String) As Integer
        Dim sql As String = "DELETE FROM tblSurgerySub WHERE sid=" & SID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function DeleteSubDiagnosisBySSID(ByVal SSID As String) As Integer
        Dim sql As String = "DELETE FROM tblSurgerySub WHERE SSID=" & SSID
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Public Function SelectSubDiagnosis(ByVal SID As String) As DataTable
        Dim sql As String = "SELECT * FROM tblSurgerySub where sid=" & SID
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

End Module
