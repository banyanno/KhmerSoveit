Module ModNewInPatientStatistic
    '=============================='Module New In Patient Paying ====================================================
    'Full Paying Payment Old Code
    Function FullPayingSurgery(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail " & _
                            "WHERE (FullFee <> 0 OR DolarFull <> 0) AND TypeOfOperation='" & TypeOfSurgery & "'" & _
                            " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    'Function FullPayingSurgery(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInPatient " & _
    '                        "WHERE DeleteOption='False' AND ReceiptNo<>0  AND TypeOfOperation='" & TypeOfSurgery & "'" & _
    '                        " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    'End Function
    Function TotalFullPaying(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail " & _
                            "WHERE CalDolarFull<>0 " & _
                            " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function FullPayingOtherSurgery(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail " & _
                            "WHERE CalDolarFull<>0 " & _
                           " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        If TypeOfSurgery <> "" Then
            sql = sql & TypeOfSurgery
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function


    'Non paying payment
    Function NonPayingSurgery(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail  " & _
                            "WHERE ReceiptNo=0 AND TypeOfOperation='" & TypeOfSurgery & "'" & _
                            " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function NonPayingOtherSurgery(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail  " & _
                           "WHERE  ReceiptNo=0 " & _
                           " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        If TypeOfSurgery <> "" Then
            sql = sql & TypeOfSurgery
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalNonPaying(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE DeleteOption='False' AND ReceiptNo=0 " & _
                            " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    'Paying Less and More $50
    Function PayingLessMore50(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String, ByVal LessOrMore As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE DeleteOption='False' AND ReceiptNo<>0 " & _
                             " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')" & _
                            " AND calDolarSosial + CalDolarFull " & LessOrMore & " AND TypeOfOperation='" & TypeOfSurgery & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function PayingLessMoreOther(ByVal TypeOfSurgery As String, ByVal Months As String, ByVal Years As String, ByVal LessOrMore As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE DeleteOption='False' AND ReceiptNo<>0 " & _
                            " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')" & _
                            " AND calDolarSosial + CalDolarFull " & LessOrMore
        If TypeOfSurgery <> "" Then
            sql = sql & TypeOfSurgery
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function TotalPayingLessMore50(ByVal Months As String, ByVal Years As String, ByVal LessOrMore As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNO) FROM V_InpatientDetail WHERE DeleteOption=0 AND ReceiptNo<>0 " & _
                             " AND (MONTH(Createdate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')" & _
                             " AND calDolarSosial + CalDolarFull " & LessOrMore
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    '============================== End module In Patient Payment ============================================

    '============================== Module In Patient Diagnosis   ============================================
    Function InPatientFMDiagnosis(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                           " FROM TblPatients AS T1 INNER JOIN TblInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                           " WHERE  T2.DeleteOption='False' " & _
                           " AND" & _
                           " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                           " AND" & _
                           " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.Diagnosis='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function InpatientFM50(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                                  " FROM TblPatients AS T1 INNER JOIN TblInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                                  " WHERE  T2.DeleteOption='False' " & _
                                  " AND" & _
                                  " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                                  " AND" & _
                                  " (T1.Age >=50 AND T2.Diagnosis='" & Diagnosis & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function InPatientTotalDiagnosis(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInPatient WHERE DeleteOption=0 AND " & _
                            "(MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function InPatientTotalDiagnosisOther(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String)
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInPatient WHERE DeleteOption=0 AND " & _
                            "(MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        If Diagnosis <> "" Then
            sql = sql & Diagnosis
        End If
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function InTotalEachDiagnosis(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInPatient  " & _
                            " WHERE  DeleteOption='False' AND Diagnosis='" & Diagnosis & "'" & _
                           " AND" & _
                           " (MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    '============================= End Module In Patient Diagnosis ===============================================


    '============================= Module In Patient Operation Performed (Eye Problem) ===========================

    Function InPDiagPerformFM(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                             " FROM TblPatients AS T1 INNER JOIN TblNewInPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                             " WHERE  T2.DeleteOption='False' " & _
                             " AND " & _
                             " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                             " AND" & _
                             " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.Diagnosis='" & Diagnosis & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function TotalInPEachDiagPerform(ByVal Diagnosis As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNO) FROM TblNewInPatient " & _
                             " WHERE  DeleteOption='False' AND Diagnosis='" & Diagnosis & "'" & _
                             " AND" & _
                             " (MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    '============================= End Module In Patient Operation Performed (Eye Problem) =======================

    '============================= Module In Patient Surgery(Eye Problem)=========================================
    'Function InPatSurgeryFM(ByVal Surgery As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As DataTable
    '    Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
    '                         " FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
    '                         " WHERE  T2.DeleteOption='False' " & _
    '                         " AND " & _
    '                         " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
    '                         " AND" & _
    '                         " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.OperationType='" & Surgery & "'"
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    'End Function


    Function InPatSurgeryFM(ByVal Surgery As String, ByVal Months As String, ByVal Years As String, ByVal Age1 As String, ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                             " FROM TblPatients AS T1  INNER JOIN TblInpatient as T2 ON T1.PatientNo=T2.PatientNo " & _
                             " WHERE  T2.DeleteOption='False' " & _
                             " AND " & _
                             " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                             " AND" & _
                             " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ") AND T2.TypeOfOperation='" & Surgery & "'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    'Function InPatSurgeryFM50(ByVal Surgery As String, ByVal Months As String, ByVal Years As String) As DataTable
    '    Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
    '                         " FROM TblPatients AS T1 INNER JOIN TblOTRegistration AS T2 ON T1.PatientNo = T2.PatientNo " & _
    '                         " WHERE  T2.DeleteOption='False' " & _
    '                         " AND " & _
    '                         " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
    '                         " AND" & _
    '                         " (T1.Age >=50 AND T2.OperationType='" & Surgery & "')"
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    'End Function
    Function InPatSurgeryFM50(ByVal Surgery As String, ByVal Months As String, ByVal Years As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F" & _
                             " FROM TblPatients AS T1  INNER JOIN TblInpatient as T2 ON T1.PatientNo=T2.PatientNo " & _
                             " WHERE  T2.DeleteOption='False' " & _
                             " AND " & _
                             " (MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                             " AND" & _
                             " (T1.Age >=50 AND T2.TypeOfOperation='" & Surgery & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    'Function TotalInEachSurgeryPerform(ByVal Surgery As String, ByVal Months As String, ByVal Years As String) As Integer
    '    Dim sql As String = "SELECT COUNT(PatientNo) FROM TblOTRegistration WHERE DeleteOption='False' AND OperationType='" & Surgery & "' " & _
    '                       " AND (MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
    '    Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(Sql)
    'End Function

    Function TotalInEachSurgeryPerform(ByVal Surgery As String, ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInpatient WHERE DeleteOption='False' AND TypeOfOperation='" & Surgery & "' " & _
                           " AND (MONTH(CreateDate)='" & Months & "' AND YEAR(CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(Sql)
    End Function
End Module
