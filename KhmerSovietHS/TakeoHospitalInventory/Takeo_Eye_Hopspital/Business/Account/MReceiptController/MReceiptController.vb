Module MReceiptController

    Dim generalDAO As New GeneralDAO

    Public Function GetPaymentList(ByVal DateIn As Date) As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select HN, PatientName, ReceiptNo, IDCashReceipt," _
                    & " ConPay, ConGeneral from tblPatientReceipt where DateIn >='" & DateIn & "' and ConPay='0' and ConDelete='0' order by ReceiptNo Desc")
    End Function

    Function DeleteReceipt(ByVal RNo As Long) As Integer
        Dim sql As String = "UPDATE  tblPatientReceipt SET ConDelete='1' WHERE ReceiptNo=" & RNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Function RedoDeleteReceipt(ByVal RNo As Long) As Integer
        Dim sql As String = "UPDATE tblPatientReceipt SET ConDelete='0' WHERE ReceiptNo=" & RNo
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(sql)
    End Function

    Public Function GetPaymentListDelete(ByVal DateIn As Date) As DataTable
        Return generalDAO.SelectDAOAsDataTatable("Select HN, PatientName, ReceiptNo, IDCashReceipt, CashUSD, CashRiel," _
                            & " DateIn, ConPay from tblPatientReceipt where ConDelete='0'")
    End Function
    
End Module
