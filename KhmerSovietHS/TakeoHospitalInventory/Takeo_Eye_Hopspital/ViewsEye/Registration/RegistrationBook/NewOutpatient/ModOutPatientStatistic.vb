Module ModOutPatientStatistic
    'Get new patient statistic. ===========================
    Function NewOutStatisticAge(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal age1 As String, ByVal age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.Status='False' AND T2.DeleteOption='False' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                            " AND" & _
                            " (T1.Age BETWEEN " & age1 & " AND " & age2 & ") AND T2.Diagnosis='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function NewOutStatistict50(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                             " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                             " WHERE (T1.Age>=50  AND T2.Diagnosis='" & Diagnosis & "') AND" & _
                            " T2.Status='False' AND T2.DeleteOption='False' and T2.diagnosis<>'' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function NewOther(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal age1 As String, ByVal age2 As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                                    " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                    " WHERE T2.Status='False' AND T2.DeleteOption='False' AND T2.Diagnosis<>''" & _
                                    " AND" & _
                                    " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                                    " AND" & _
                                    " (T1.Age BETWEEN " & age1 & " AND " & age2 & ")"
        If Diagnosis <> "" Then
            sql = sql & Diagnosis
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function TotalNewPatient(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.Status='False' AND T2.DeleteOption='False' and T2.diagnosis<>'' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalEachDiagnosisNew(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                        " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                        " WHERE T2.Status='False' AND T2.DeleteOption='False' and T2.diagnosis<>'' AND Diagnosis='" & Diagnosis & "'" & _
                        " AND" & _
                        " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    'Get Old-out patient statistic.''''''''''''''''''''''''''''''''
    Function OldChildM_F(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal age1 As String, ByVal age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.Status='True' AND DeleteOption='False' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                            " AND" & _
                            " (T1.Age BETWEEN " & age1 & " AND " & age2 & ") AND T2.Diagnosis='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function OldStatistic50(ByVal diagnosis As String, ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                                   " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                   " WHERE T2.Status='True' AND DeleteOption='False' " & _
                                   " AND" & _
                                   " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                                   " AND" & _
                                   " (T1.Age >=50 AND T2.Diagnosis='" & diagnosis & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function OldOther(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal age1 As String, ByVal age2 As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                                    " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                    " WHERE T2.Status='True' AND DeleteOption='False' AND T2.Diagnosis<>''" & _
                                    " AND" & _
                                    " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                                    " AND" & _
                                    " (T1.Age BETWEEN " & age1 & " AND " & age2 & ")"
        If Diagnosis <> "" Then
            sql = sql & Diagnosis
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function TotalOlddPatient(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.Status='True' AND T2.DeleteOption='False' and T2.diagnosis<>'' " & _
                            " AND" & _
                            " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalEachDiagnosisOld(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT  COUNT(T1.PatientNo)" & _
                        " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                        " WHERE T2.Status='True' AND T2.DeleteOption='False' and T2.diagnosis<>'' AND Diagnosis='" & Diagnosis & "'" & _
                        " AND" & _
                        " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
