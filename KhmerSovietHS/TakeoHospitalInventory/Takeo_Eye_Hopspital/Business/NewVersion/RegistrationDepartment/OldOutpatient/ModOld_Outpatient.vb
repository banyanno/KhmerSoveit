Module ModOld_Outpatient
    Function UpdateReferral(ByVal ComBindRefferal As String, ByVal NewOldID As Double) As Integer
        Dim SQL As String = "UPDATE TblNew_Old_OutPatient SET ComBindRefferal='" & ComBindRefferal & "' WHERE NewOutPatientNo=" & NewOldID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function SelectExistingReferral(ByVal Referal As String, ByVal patientNo As String) As DataTable
        Dim SQL As String = "SELECT REFE_DETAIL_ID,PATIENT_NO,REFERRAL_FROM  FROM REFFERAL_PATIENT_DETAIL"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(SQL)
    End Function
    Function InsertRefferal(ByVal PatientNo As String, ByVal Referal As String) As Integer
        Dim SQL As String = "INSERT INTO REFFERAL_PATIENT_DETAIL (PATIENT_NO,REFERRAL_FROM) VALUES(" & PatientNo & ",'" & Referal & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(Sql)
    End Function
    Function DeleteReferalDetail(ByVal PatientNo As String) As Integer
        Dim sql As String = "DELETE FROM REFFERAL_PATIENT_DETAIL WHERE PATIENT_NO=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SaveOldPatient( _
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
    ByVal TypeDiagnosis As Boolean, ByVal ComBindRefferal As String) As Integer
        Dim sql As String = "INSERT INTO TblNew_Old_OutPatient " & _
        "(ReceiptNo," & _
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
        "Status," & _
        "TypeDiagnosis" & _
        ",ComBindRefferal) " & _
        " VALUES(" & _
        ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        DiagnosisTem & "'," & _
        PatientFee & "," & _
        PatientDolar & ",'" & _
        Prescribed & "','" & _
        Dispensed & "','" & _
        Hearing & "','" & _
        Seeing & "','" & _
        Understand & "','" & _
        Physical & "','" & _
        Other & "','" & _
        CreateDate & _
        "','True','" & _
        TypeDiagnosis & "','" & ComBindRefferal & "')"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function

    Function CheckDuplicatePatientOneDay(ByVal PatientNo As Double, ByVal DateOldRegis As Date) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblNew_Old_OutPatient " & _
        "WHERE PatientNO=" & PatientNo & " AND  " & _
        "CAST(CONVERT(VARCHAR(10), CAST(CreateDate AS DATETIME), 1) AS Datetime)=CAST(CONVERT(VARCHAR(10), CAST('" & DateOldRegis & "' AS DATETIME), 1) AS Datetime) AND  Status='False'"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
    Function UpdateOldPatient( _
    ByVal OldNo As String, _
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
        "CreateDate='" & CreateDate & "'," & _
        "TypeDiagnosis='" & TypeDiagnosis & "'" & _
        " WHERE NewOutPatientNo=" & OldNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteOldPatient(ByVal OldNo As String) As Integer
        Dim sql As String = "DELETE FROM TblNew_Old_OutPatient WHERE NewOutPatientNo=" & OldNo
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function
    Function SelectOldReceiptNo(ByVal ReceiptNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_Oldoutpatient WHERE ReceiptNo=" & ReceiptNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckExistingReceipt(ByVal ReceiptNo As String) As Boolean
        Dim sql As String = "SELECT COUNT(ReceiptNo) FROM TblNew_Old_OutPatient WHERE ReceiptNo=" & ReceiptNo
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function SelectOldDetailByReceiptNo(ByVal ReceiptNo As String, ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_OldOutpatientDetail WHERE ReceiptNo=" & ReceiptNo & " AND PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOldPatientDetailByDate(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_OldOutpatientDetail WHERE " & _
            " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOldPatientDetailByDateNotFillDiagnosis(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String, ByVal Diagnosis As String) As DataTable
        Dim sql As String = "SELECT * FROM V_OldOutpatientDetail WHERE " & _
           " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
           " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
           " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " AND Diagnosis='" & Diagnosis & "' ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function SelectOldPatienDetailbyDateNotVA(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_OldOutpatientDetail WHERE " & _
           " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
           " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
           " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " AND VAStatus=0 ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SumOldPatientRiel(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT SUM(PatientFee) FROM TblNew_Old_OutPatient WHERE Status='True' AND " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function SumOldPatientDolar(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT SUM(PatientDolar) FROM TblNew_Old_OutPatient WHERE Status='True' AND " & _
              " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                  " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                  " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime) "
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function SelectOldPatientBook(ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_OldOutpatientDetail WHERE  PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    ' Statistic New out patient
    Function OldOutpatientStatistic( _
        ByVal Months As String, _
        ByVal Years As String, _
        ByVal Age1 As String, _
        ByVal Age2 As String) As DataTable
        Dim sql As String = "SELECT  COUNT(T1.Male) M,COUNT(T1.Female) F,T2.Diagnosis " & _
                            " FROM TblPatients AS T1 INNER JOIN TblNew_Old_OutPatient AS T2 ON T1.PatientNo = T2.PatientNo " & _
                            " WHERE  T2.Status='True' AND " & _
                            "(MONTH(T2.CreateDate)='" & Months & "' AND YEAR(T2.CreateDate)='" & Years & "')" & _
                            " AND" & _
                            " (T1.Age BETWEEN " & Age1 & " AND " & Age2 & ")" & _
                            " Group By T2.Diagnosis"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function CountOldOutPrecriped(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Prescribed) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE T1.Prescribed='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountNewOldDispensed(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Dispensed) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='True' AND  T1.Dispensed='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountOldOutHearing(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Hearing) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE   T1.Status='True' AND T1.Hearing='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountOldOutUnderstand(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Understand) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE   T1.Status='True' AND T1.Understand='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountOldOutSeeing(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Seeing) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE T1.Seeing='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function

    Function CountOldOutPhysical(ByVal Months As String, ByVal Years As String) As Integer
        Dim sql As String = "SELECT COUNT(Physical) FROM TblNew_Old_OutPatient AS T1 " & _
        "WHERE  T1.Status='True' AND  T1.Physical='True' AND " & _
        "(MONTH(T1.CreateDate)='" & Months & "' AND YEAR(T1.CreateDate)='" & Years & "')"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
    End Function
End Module
