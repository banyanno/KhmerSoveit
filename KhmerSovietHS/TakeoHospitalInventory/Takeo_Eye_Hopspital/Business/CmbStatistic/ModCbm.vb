Module ModCbm
    Function getConsultationChildren(ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F , T2.Diagnosis" & _
                                    " FROM TblPatients AS T1 " & _
                                    " INNER JOIN " & _
                                    " TblNew_Old_OutPatient AS T2 " & _
                                    " ON T1.PatientNo = T2.PatientNo  " & _
                                    " WHERE " & _
                                    " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "') " & _
                                    " AND (T1.Age BETWEEN 0 AND 15)" & _
                                    " GROUP BY T2.Diagnosis"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function getConsultationAdult(ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F , T2.Diagnosis" & _
                                    " FROM TblPatients AS T1 " & _
                                    " INNER JOIN " & _
                                    " TblNew_Old_OutPatient AS T2 " & _
                                    " ON T1.PatientNo = T2.PatientNo  " & _
                                    " WHERE " & _
                                    " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "') " & _
                                    " AND (T1.Age BETWEEN 16 AND 100)" & _
                                    " GROUP BY T2.Diagnosis"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
