Module ModUpdateDateOPT
    Function UpdateDATE_OPT(ByVal ID As Double, ByVal DateValue As Date) As Integer

        Dim SQL As String = "UPDATE RECEIPT SET receiptdate='" & DateValue & "' WHERE RECEIPTNO='" & ID & "'"
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function UPdate_Date_OPT_NIll(ByVal id As Double, ByVal DateValue As Date) As Integer
        Dim SQL As String = "UPDATE RECEIPT SET receiptdate='" & DateValue & "' WHERE ReceiptID='" & id & "'"
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function Update_Date_OPTDetial(ByVal ID As Double, ByVal DateValue As Date) As Integer
        Dim SQL As String = "UPDATE RECEIPT_DETAIL SET ReceiptDate='" & DateValue & "' WHERE RECEIPTNO='" & ID & "'"
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function
    Function UpdateDate_RECEIPT(ByVal ID As Double, ByVal DateValue As Date) As Integer
        Dim SQL As String = "UPDATE tblpatientreceipt SET dateIn='" & DateValue & "' WHERE RECEIPTNO=" & ID
        Return ModGlobleVariable.GENERAL_DAO.UpdateDAO(SQL)
    End Function

End Module
