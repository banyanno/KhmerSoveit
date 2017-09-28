Module ModRefer
    Function SaveRefer(ByVal ReferName As String, ByVal Note As String) As Integer
        Dim sql As String = "INSERT INTO TblRefer (,Refer,ReferNote) VALUES('" & ReferName & "','" & Note & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function SelectRefer() As DataTable
        Dim sql As String = "SELECT ReferNo,Refer,ReferNote FROM TblRefer ORDER BY Refer"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function UpdateRefer(ByVal ReferNo As String, ByVal Refer As String, ByVal ReferNote As String) As Integer
        Dim sql As String = "UPDATE TblRefer SET  Refer='" & Refer & "',ReferNote='" & ReferNote & "' WHERE ReferNo=" & ReferNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteRefer(ByVal ReferNo As String) As Integer
        Dim sql As String = "DELETE FROM TblRefer WHERE ReferNo=" & ReferNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    '================================Patient Refer to===================
    Function InsertReferTo(ByVal DateRefer As String, ByVal PatientNo As String, ByVal Diagnosis As String, ByVal ReferTo As String, ByVal Note As String) As Integer
        Dim sql As String = "INSERT INTO TblReferTo (PatientNo,ReferTo,Diagnosis,ReferDate,Note) VALUES(" & PatientNo & ",'" & ReferTo & "','" & Diagnosis & "','" & DateRefer & "','" & Note & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateReferto(ByVal ReferNo As String, ByVal Diagnosis As String, ByVal DateRefer As String, ByVal ReferTo As String, ByVal Note As String) As Integer
        Dim sql As String = "UPDATE TblReferTo SET Diagnosis='" & Diagnosis & "', ReferDate='" & DateRefer & "',ReferTo='" & ReferTo & "',Note='" & Note & "' WHERE ReferNo=" & ReferNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function
    Function DeleteReferTo(ByVal ReferNo As Integer) As Integer
        Dim sql As String = "DELETE FROM TblReferTo WHERE ReferNo=" & ReferNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectReferTo(ByVal PatientNo As String, ByVal DFrom As Date, ByVal DTo As Date) As DataTable
        Dim sql As String = "SELECT ReferNo,PatientNo,NameEng,NameKhmer,Age,Sex,Address,Occupation,ReferTo,ReferDate,Note,Male,Female,Diagnosis FROM V_PatientRefer WHERE " & _
        " (CAST(CONVERT(VARCHAR(10), ReferDate, 1) AS DateTime)" & _
        " BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10), CAST('" & DFrom & "' AS DATETIME), 1) AS Datetime)" & _
        " AND" & _
        " CAST(CONVERT(VARCHAR(10), CAST('" & DTo & "' AS DATETIME), 1)  AS Datetime)) "
        If PatientNo <> "" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If

        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
