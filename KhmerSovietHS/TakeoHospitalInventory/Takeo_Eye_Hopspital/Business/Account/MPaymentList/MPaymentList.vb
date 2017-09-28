Module MPaymentList

    Dim generalDAO As New GeneralDAO

    Public Function GetPaymentList(ByVal DateIn As Date) As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select PR.HN, P.NameKhmer as PatientName, PR.ReceiptNo, PR.IDCashReceipt," _
                    & " PR.ConPay, PR.ConGeneral ,PR.DateIn, PR.ID,PR.IsDonation,PR.DonationID,PR.DonationName,PR.DonationPay,PR.DonateNote,PR.HosFee,PR.CashTotal FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo WHERE  CAST(CONVERT(VARCHAR(10), PR.DateIn, 1) AS DateTime) >=CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) and PR.ConPay='0' and PR.ConDelete='0' order by PR.ReceiptNo Asc")
    End Function

    Public Function GetPaymentListAll() As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select PR.HN, P.NameKhmer as PatientName, PR.ReceiptNo, PR.IDCashReceipt," _
                    & " PR.ConPay, PR.ConGeneral ,PR.DateIn, PR.ID,PR.IsDonation,PR.DonationID,PR.DonationName,PR.DonationPay,PR.DonateNote,PR.HosFee,PR.CashTotal FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo Where  PR.ConPay='0' and PR.ConDelete='0' order by PR.ReceiptNo Asc")
    End Function

    Public Function GetPaymentListDelete(ByVal DateIn As Date, ByVal DateTo As Date) As DataTable
        Dim sql As String = "Select PR.HN, P.NameKhmer as PatientName, PR.ReceiptNo, PR.IDCashReceipt," _
                    & " PR.ConPay, PR.ConGeneral ,PR.DateIn, PR.ID FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo" _
                    & " where (CAST(CONVERT(VARCHAR(10), PR.DateIn, 1) AS DateTime) BETWEEN CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) and CAST(CONVERT(VARCHAR(10), CAST('" & DateTo & "' AS DATETIME), 1) AS Datetime)) " _
                    & " and PR.ConDelete='1' order by PR.ReceiptNo Asc"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function

    Public Function GetPaymentListDeleteAll() As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select PR.HN, P.NameKhmer as PatientName, PR.ReceiptNo, PR.IDCashReceipt," _
                    & " PR.ConPay, PR.ConGeneral ,PR.DateIn, PR.ID FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo where PR.ConDelete='1' order by PR.ReceiptNo Asc")
    End Function

    Public Function GetPaymentListToday(ByVal DateIn As Date) As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select PR.HN, P.NameKhmer as PatientName, PR.ReceiptNo, PR.IDCashReceipt, " _
                    & " PR.ConPay, PR.ConGeneral ,PR.DateIn, PR.ID,PR.IsDonation,PR.DonationID,PR.DonationName,PR.DonationPay,PR.DonateNote,PR.HosFee,PR.CashTotal FROM tblPatientReceipt PR INNER JOIN tblPatients P ON PR.HN=P.PatientNo " _
                    & " Where CAST(CONVERT(VARCHAR(10), PR.DateIn, 1) AS DateTime) >=CAST(CONVERT(VARCHAR(10), CAST('" & DateIn & "' AS DATETIME), 1) AS Datetime) " _
                    & " and PR.ConPay='0' and PR.ConDelete='0'  order by PR.ReceiptNo Asc")
    End Function

End Module
