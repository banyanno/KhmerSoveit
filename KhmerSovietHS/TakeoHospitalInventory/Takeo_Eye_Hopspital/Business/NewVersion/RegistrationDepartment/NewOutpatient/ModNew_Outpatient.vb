Module ModNew_Outpatient
    Function InserNewOutpatient( _
    ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal PatientFee As String, _
    ByVal PatientDolar As String, _
    ByVal Prescribed As Boolean, _
    ByVal Dispensed As Boolean, _
    ByVal Hearing As Boolean, _
    ByVal Understand As Boolean, _
    ByVal Seeing As Boolean, _
    ByVal Physical As Boolean, _
    ByVal Other As String, _
    ByVal CreateDate As String, _
    ByVal TypeDiagnosis As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient ( " & _
        "ReceiptNo," & _
        "PatientNo," & _
        "Diagnosis," & _
        "DiagnosisTem," & _
        "PatientFee," & _
        "PatientDolar," & _
        "Prescribed," & _
        "Dispensed," & _
        "Hearing," & _
        "Understand," & _
        "Seeing," & _
        "Physical," & _
        "Other," & _
        "CreateDate," & _
        "TypeDiagnosis" & _
        ")" & _
        "VALUES(" & _
        ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        DiagnosisTem & "'," & _
        PatientFee & "," & _
        PatientDolar & ",'" & _
        Prescribed & "','" & _
        Dispensed & "','" & _
        Hearing & "','" & _
        Understand & "','" & _
        Seeing & "','" & _
        Physical & "','" & _
        Other & "','" & _
        CreateDate & "','" & _
        TypeDiagnosis & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function InsertNewBookAchieve( _
   ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
   ByVal Diagnosis As String, _
    ByVal DiagnosisTem As String, _
    ByVal PatientFee As String, _
    ByVal PatientDolar As String, _
   ByVal Other As String, _
   ByVal CreateDate As Date, _
   ByVal TypeDiagnosis As Boolean) As Integer
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient ( " & _
        "ReceiptNo," & _
       "PatientNo," & _
        "Diagnosis," & _
        "DiagnosisTem," & _
        "PatientFee," & _
        "PatientDolar," & _
        "Other," & _
        "CreateDate," & _
        "TypeDiagnosis) " & _
        "VALUES(" & _
        ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        DiagnosisTem & "'," & _
        PatientFee & "," & _
        PatientDolar & ",'" & _
        Other & "','" & _
        CreateDate & "','" & _
        TypeDiagnosis & _
        "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function Get_CombindReferal(ByVal PatientNo As String) As String
        Dim SQL As String = "SELECT ComBindRefferal FROM TblPatients WHERE PatientNo=" & PatientNo
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(SQL)
        Catch ex As Exception
            Return "Self"
        End Try

    End Function
    Function CheckOldPatientExisting(ByVal OldPatientNo As String) As Integer
        Dim sql As String = "SELECT COUNT(OlePatientNo) FROM TblPatients WHERE OlePatientNo=" & OldPatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function UpdatAchieveNew(ByVal NewOutPatientNo As String, _
  ByVal PatientNo As String, ByVal OlePatientNo As String, ByVal ReceiptNo As String, _
  ByVal NameEng As String, ByVal NameKhmer As String, ByVal Age As String, _
  ByVal Sex As String, ByVal Address As String, _
  ByVal PatientFee As String, ByVal Diagnosis As String, ByVal Other As String, _
  ByVal CreateDate As String) As Integer
        Dim sql As String = "UPDATE V_NewOutpatientDetail SET " & _
            "PatientNo = " & PatientNo & "," & _
            "OlePatientNo =" & OlePatientNo & "," & _
            "ReceiptNo =" & ReceiptNo & "" & _
            ",NameEng ='" & NameEng & "'," & _
            "NameKhmer ='" & NameKhmer & "'," & _
            "Age =" & Age & "," & _
            "Sex ='" & Sex & "'," & _
            "Address ='" & Address & "'," & _
            "PatientFee =" & PatientFee & "," & _
            "Diagnosis ='" & Diagnosis & "'," & _
            "Other ='" & Other & "'," & _
            "CreateDate ='" & CreateDate & _
        "' WHERE NewOutPatientNo=" & NewOutPatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateAchieve(ByVal PatientNo As String) As Integer
        Dim SQL As String = "UPDATE TblPatients SET Achieve='False' WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function EnterPatientDiagnosis(ByVal No As String, ByVal Diagnosis As String) As Integer
        Dim sql As String = "UPDATE TblNew_Old_OutPatient SET Diagnosis='" & Diagnosis & "' WHERE NewOutPatientNo=" & No
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(Sql)
    End Function
    Function UpdateNewOutPatient( _
        ByVal NewNo As String, _
        ByVal ReceiptNo As String, _
        ByVal PatientNo As String, _
        ByVal Diagnosis As String, _
        ByVal DiagnosisTem As String, _
        ByVal PatientFee As String, _
        ByVal PatientDolar As String, _
        ByVal Prescribed As Boolean, _
        ByVal Dispensed As Boolean, _
        ByVal Hearing As Boolean, _
        ByVal Understand As Boolean, _
        ByVal Seeing As Boolean, _
        ByVal Physical As Boolean, _
        ByVal Other As String, _
        ByVal CreateDate As String, ByVal TypeDiagnosis As Boolean) As Integer
        Dim sql As String = "UPDATE TblNew_Old_OutPatient SET " & _
        "ReceiptNo=" & ReceiptNo & "," & _
        "PatientNo=" & PatientNo & "," & _
        "Diagnosis='" & Diagnosis & "'," & _
        "DiagnosisTem='" & DiagnosisTem & "'," & _
        "PatientFee=" & PatientFee & "," & _
        "PatientDolar=" & PatientDolar & "," & _
        "Prescribed='" & Prescribed & "'," & _
        "Dispensed='" & Dispensed & "'," & _
        "Hearing='" & Hearing & "'," & _
        "Understand='" & Understand & "'," & _
        "Seeing='" & Seeing & "'," & _
        "Physical='" & Physical & "'," & _
        "Other='" & Other & "'," & _
        "CreateDate ='" & CreateDate & "'," & _
        "TypeDiagnosis='" & TypeDiagnosis & "'" & _
        " WHERE NewOutPatientNo=" & NewNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteNewOutPatient(ByVal NewOutNo As String) As Integer
        Dim sql As String = "DELETE FROM TblNew_Old_OutPatient WHERE NewOutPatientNo=" & NewOutNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function UpdateToCancel(ByVal NewOutNo As String) As Integer
        Dim sql As String = "UPDATE TblNew_Old_OutPatient SET DeleteOption='1' WHERE NewOutPatientNo=" & NewOutNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function UpdateToUndo(ByVal NewOutNo As String) As Integer
        Dim sql As String = "UPDATE TblNew_Old_OutPatient SET DeleteOption='0' WHERE NewOutPatientNo=" & NewOutNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SelectReceiptNewpatient(ByVal ReceiptNo As String) As DataTable
        Dim SQL As String = "SELECT * FROM V_Newoutpatient WHERE ReceiptNo=" & ReceiptNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(SQL)
    End Function
    Function SelectNewOutpatientByDate(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Achive As Boolean) As DataTable
        Dim sql As String = "SELECT * FROM V_NewOutpatientDetail WHERE Status=0 AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelecNewOutPatientByDateNotFillDiagnosis(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Achive As Boolean, ByVal Diagnosis As String) As DataTable
        Dim sql As String = "SELECT * FROM V_NewOutpatientDetail WHERE Status=0 AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " AND Diagnosis='" & Diagnosis & "' ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelecNewOutPatientByDateNotVA(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Achive As Boolean) As DataTable
        Dim sql As String = "SELECT * FROM V_NewOutpatientDetail WHERE Status=0 AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " AND VAStatus =0 ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function UpdateVAStatus(ByVal PatientNo As String) As Integer
        Dim sql As String = "Update TblNew_Old_OutPatient SET VAStatus='True' WHERE NewOutPatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function SumNewPatientRiel(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT SUM(PatientFee) FROM TblNew_Old_OutPatient WHERE Status='False' AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function SumNewPatientDolar(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT SUM(PatientDolar) FROM TblNew_Old_OutPatient WHERE Status='False' AND " & _
                 " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function SelectNewPatientBook(ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_NewOutpatientDetail WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CMale(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE  Status=" & Status & " AND SEX='M' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountM As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountM
    End Function
    Function CMaleForInpatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE   SEX='M' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountM As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountM
    End Function
    Function CMaleForOldPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE Status=1 AND  SEX='M' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountM As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountM
    End Function
    Function CFemale(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE  Status=" & Status & " AND SEX='F' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountF As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountF
    End Function
    Function CFemaleForInPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE  SEX='F' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountF As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountF
    End Function
    Function CFemaleForOldPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(SEX) FROM " & TblNew_Old & " WHERE Status=1 AND SEX='F' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountF As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountF
    End Function
    Function CNil(ByVal TblNewOut As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM " & TblNewOut & " WHERE  Status=" & Status & " AND ReceiptNo =0 AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
         " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
         " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountF As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountF
    End Function
    Function CNilForOldPatient(ByVal TblNewOut As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM " & TblNewOut & " WHERE Status=1 AND ReceiptNo =0 AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
         " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
         " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountF As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountF
    End Function
    Function CountCanceled(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM " & TblNew_Old & " WHERE  Status=" & Status & " AND  DeleteOption='True' AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
         " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
         " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountNCancel As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountNCancel
    End Function
    Function CountCanceledForInPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM " & TblNew_Old & " WHERE   DeleteOption='True' AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
         " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
         " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountNCancel As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountNCancel
    End Function
    Function CountCanceledForOldPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM " & TblNew_Old & " WHERE Status=1 AND DeleteOption=1 AND " & _
         " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
         " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
         " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Dim CountNCancel As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountNCancel
    End Function
    Function CountNotFillDiagnosis(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(Diagnosis) FROM " & TblNew_Old & " WHERE Status =" & Status & " AND " & _
                " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " & _
                " AND Diagnosis=''"
        Dim CountNotFill As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountNotFill
    End Function
    Function CountNotFillDiagnosisForOldPatient(ByVal TblNew_Old As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Status As Integer) As Integer
        Dim sql As String = "SELECT COUNT(Diagnosis) FROM " & TblNew_Old & " WHERE STATUS=1 AND " & _
                " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) " & _
                " AND Diagnosis=''"
        Dim CountNotFill As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Return CountNotFill
    End Function
    Function SelectNewOutNo(ByVal NewOutPatientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_NewOutpatientDetail WHERE NewOutPatientNo=" & NewOutPatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckReceiptAndPatient(ByVal PatientNo As String, ByVal ReceiptNo As String) As Boolean
        Dim Sql As String = "SELECT COUNT(PatientNo) FROM TblNew_Old_OutPatient WHERE ReceiptNo=" & ReceiptNo & " AND PatientNo=" & PatientNo
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(Sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckPatientOld(ByVal PatientNo As String) As Boolean
        Dim Sql As String = "SELECT COUNT(PatientNo) FROM TblNew_Old_OutPatient WHERE  PatientNo=" & PatientNo & " AND Status='False'"
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(Sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckNewPatient(ByVal PatientNo As String) As Boolean
        Dim Sql As String = "SELECT COUNT(PatientNo) From TblNew_Old_OutPatient WHERE PatientNo=" & PatientNo & " and Status='False' "
        Dim status As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(Sql)
        If status > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CountFollowUp(ByVal PatientNo As String) As Integer
        Dim Sql As String = "SELECT COUNT(PatientNo) From TblNew_Old_OutPatient WHERE PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectAsScalar(Sql)
    End Function

    ' Statistic New out patient
    Function NewOutpatientStatistic( _
        ByVal Months As String, _
        ByVal Years As String, _
        ByVal Age1 As String, _
        ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F, T2.Diagnosis" & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE T2.Status='False' AND " & _
                            "(MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                            " AND" & _
                            " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")" & _
                            " GROUP BY T2.Diagnosis "

        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CountNewOutPrecriped(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Prescribed) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Prescribed='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOutDispensed(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Dispensed) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Dispensed='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOutHearing(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Hearing) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Hearing='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOutUnderstand(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Understand) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Understand='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOutSeeing(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Seeing) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Seeing='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOutPhysical(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Physical) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='False' AND T1.Physical='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
