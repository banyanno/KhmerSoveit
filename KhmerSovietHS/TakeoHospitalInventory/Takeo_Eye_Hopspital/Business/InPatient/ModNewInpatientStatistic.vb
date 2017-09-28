Module ModNewInWardStatistic
    Function TotalNewInWardM_F(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                           " FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                           " WHERE T2.DeleteOption='False' " & _
                           " AND" & _
                           " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                           " AND" & _
                           " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.Diagnosis='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function TotalNewInWard50(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                                   " FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                   " WHERE T2.DeleteOption='False' " & _
                                   " AND" & _
                                   " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                                   " AND" & _
                                   " (T1.Age >=50 AND T2.Diagnosis='" & Diagnosis & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function TotalEachDiagnosis(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.DeleteOption='False' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                            " AND T2.Diagnosis='" & Diagnosis & "'"
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") "

       
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)

    End Function
    Function TotalNewIn(ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                       " WHERE T2.DeleteOption='False' " & _
                       " AND" & _
                       " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" '  & _
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalOtherDiagnosis(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As Integer
        Dim sql As String = "SELECT COUNT(T2.PatientNo) FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                             " WHERE T2.DeleteOption='False' " & _
                             " AND" & _
                             " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" ' & _
        '" AND" & _
        '" (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")"
        If Diagnosis <> "" Then
            sql = sql & Diagnosis
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
