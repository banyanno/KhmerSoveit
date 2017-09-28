Module ModInPatient
    Function SelectInpatient(ByVal DateIn As String) As DataTable
        Dim sql As String = "SELECT * FROM View_InPatient WHERE CONVERT(VARCHAR(10),CreateDate, 103)>= CONVERT(VARCHAR(10),CAST('" & DateIn & "' as DATETIME),103)"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
    Function CheckPatientAndReceipt(ByVal patientNo As String, ByVal ReceiptNo As String) As Boolean
        Dim Sql As String = "SELECT COUNT(PatientNo) FROM TblInpatient WHERE ReceiptNo=" & ReceiptNo & " AND PatientNo=" & patientNo
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectAsScalar(Sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function CheckDuplicateDateInPatient(ByVal PateintNo As Double, ByVal DateIn As Date) As Boolean
        Dim sql As String = "SELECT COUNT(PatientNo) FROM TblInpatient WHERE PatientNo=" & PateintNo & " AND  " & _
        "CAST(CONVERT(VARCHAR(10), CAST(CreateDate AS DATETIME), 1) AS Datetime)=CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime)"
        Dim count As Integer = ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function SaveInpatient(ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Diagnosis As String, _
    ByVal TypeOfOperation As String, _
    ByVal HosFee As String, _
    ByVal SosialFee As String, _
    ByVal FullFee As String, _
    ByVal DolarSosial As String, _
    ByVal DolarFull As String, _
    ByVal CalDolarSosial As String, _
    ByVal CalDolarFull As String, _
    ByVal Other As String, _
    ByVal CreateDate As String, _
    ByVal IsDonate As Boolean, _
    ByVal DonationID As Integer, _
    ByVal DonationName As String, _
    ByVal DonationPay As Double, _
    ByVal CashTotal As Double) As Integer
        Dim sql As String = "INSERT INTO TblInpatient (ReceiptNo,PatientNo,Diagnosis,TypeOfOperation," & _
        "HosFee,SosialFee,FullFee,DolarSosial,DolarFull,CalDolarSosial,CalDolarFull,Other,CreateDate,IsDonate,DonationID,DonationName,DonationPay,CashTotal) " & _
        "VALUES(" & ReceiptNo & "," & _
        PatientNo & ",'" & _
        Diagnosis & "','" & _
        TypeOfOperation & "'," & _
        HosFee & "," & _
        SosialFee & "," & _
        FullFee & "," & _
        DolarSosial & "," & _
        DolarFull & "," & _
        CalDolarSosial & "," & _
        CalDolarFull & ",'" & _
        Other & "','" & _
        CreateDate & "','" & IsDonate & "'," & DonationID & ",'" & DonationName & "'," & DonationPay & "," & CashTotal & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function SaveReceiptNillForDonation(ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Operation As String, _
    ByVal DateIn As Date, ByVal HosFee As String, _
    ByVal CashTotal As String, ByVal IsDonate As Boolean, _
    ByVal DonationID As String, ByVal DonationName As String, ByVal DonationPay As Double) As Integer
        Dim sql As String = "INSERT INTO tblPatientReceipt (ReceiptNo,HN,Operation,DateIn,HosFee,CashTotal,IsDonation,DonationID,DonationName,IsPatientNill,ConPay,Years,DonationPay)" & _
        " VALUES(" & ReceiptNo & "," & PatientNo & ",'" & Operation & "','" & DateIn & "'," & HosFee & "," & CashTotal & ",'" & IsDonate & "'," & DonationID & ",'" & DonationName & "','True','1'," & DateIn.Year & "," & DonationPay & ")"
        Return ModGlobleVariable.GENERAL_DAO.InsertDAO(sql)
    End Function
    Function UpdateInpatient(ByVal InNO As String, _
    ByVal ReceiptNo As String, _
    ByVal PatientNo As String, _
    ByVal Diagnosis As String, _
    ByVal TypeOfOperation As String, _
    ByVal HosFee As String, _
    ByVal SosialFee As String, _
    ByVal FullFee As String, _
    ByVal DolarSosial As String, _
    ByVal DolarFull As String, _
    ByVal CalDolarSosial As String, _
    ByVal CalDolarFull As String, _
    ByVal Other As String, _
    ByVal CreateDate As String) As Integer
        Dim sql As String = "UPDATE TblInpatient SET ReceiptNo=" & ReceiptNo & _
        ",PatientNo=" & PatientNo & _
        ",Diagnosis='" & Diagnosis & _
        "',TypeOfOperation='" & TypeOfOperation & _
        "',HosFee=" & HosFee & _
        ",SosialFee=" & SosialFee & _
        ",FullFee=" & FullFee & _
        ",DolarSosial=" & DolarSosial & _
        ",DolarFull =" & DolarFull & _
        ",CalDolarSosial= " & CalDolarSosial & _
        ",CalDolarFull= " & CalDolarFull & _
        ",Other='" & Other & "'" & _
        ",CreateDate='" & CreateDate & "'" & _
        " WHERE InNo=" & InNO
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function
    Function DeleteInpatient(ByVal InNO As String) As Integer
        Dim sql As String = "DELETE FROM TblInpatient WHERE InNO=" & InNO
        Return ModGlobleVariable.GENERAL_DAO.DeleteDAO(sql)
    End Function

    Function UpdateInToCancel(ByVal InNo As String) As Integer
        Dim sql As String = "UPDATE TblInpatient SET DeleteOption='True' WHERE InNo=" & InNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function UpdateInToUndo(ByVal InNo As String) As Integer
        Dim sql As String = "UPDATE TblInpatient SET DeleteOption='False' WHERE InNo=" & InNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function SelectInpatientByReceipt(ByVal ReceiptNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_Inpatient WHERE ReceiptNo=" & ReceiptNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectInpatientDetailByReceipt(ByVal receiptNo As String, ByVal PatientNo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_InpatientDetail WHERE ReceiptNo=" & receiptNo & " AND PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SelectInpatientDetailByDate(ByVal PatientNo As String, ByVal DateFrom As String, ByVal DateTo As String) As DataTable
        Dim sql As String = "SELECT * FROM V_InpatientDetail WHERE " & _
            " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        If PatientNo <> "0" Then
            sql = sql & " AND PatientNo=" & PatientNo
        End If
        sql = sql & " ORDER BY CreateDate DESC"
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function

    Function SumInpatientFee(ByVal DateFrom As String, ByVal DateTo As String, ByVal FieldSum As String) As Integer
        Dim sql As String = "SELECT SUM(" & FieldSum & ") FROM V_InpatientDetail WHERE " & _
            " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
            " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
            " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function CountInpatientFree(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) From V_InpatientDetail WHERE ReceiptNo=0 and " & _
        " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
        " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
        " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Function CountInpatientPaid(ByVal DateFrom As String, ByVal DateTo As String, ByVal FieldCount As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE " & FieldCount & " <> 0 AND " & _
                   " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                   " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                   " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function CountPatientPayFull(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE (FullFee <> 0 OR DolarFull <> 0) AND " & _
                  " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                  " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                  " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function CountPatientPaySocial(ByVal DateFrom As String, ByVal DateTo As String) As Integer
        Dim sql As String = "SELECT COUNT(PatientNo) FROM V_InpatientDetail WHERE (SosialFee <> 0 or DolarSosial <> 0) AND " & _
                 " CAST(CONVERT(VARCHAR(10), CreateDate, 1) as DateTime) BETWEEN " & _
                 " CAST(CONVERT(VARCHAR(10),CAST('" & DateFrom & "' AS DATETIME), 1) as Datetime)" & _
                 " AND CAST(CONVERT(VARCHAR(10),CAST('" & DateTo & "' AS DATETIME), 1) as Datetime)"
        Try
            Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsScalar(sql)
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Function SelectInpatientBook(ByVal PatientNo As String)
        Dim sql As String = "SELECT * FROM V_InpatientDetail WHERE  PatientNo=" & PatientNo
        Return ModGlobleVariable.GENERAL_DAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
