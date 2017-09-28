Public Interface IOpticalShop
    Function SaveNewIncomeType(ByVal Obj As Object) As Boolean
    Function SaveNewCustomer(ByVal Obj As Object) As Double
    Function GetMaxCustomerID() As Double
    Function SaveNewDonation(ByVal Obj As Object) As Boolean
    Function SaveNewReceipt(ByVal Obj As Object) As Boolean
    Function SaveNewReceiptPatient(ByVal obj As Object) As Boolean
    Function SaveReceiptDetail(ByVal obj As Object) As Boolean
    Function UpdateReceiptPay() As Boolean
    Function GetReceipt(ByVal receiptId As Double) As RECEIPT
    Function GetReceiptNo(ByVal ReceiptNo As String) As RECEIPT
    Function GetTblPatientReceipt(ByVal ReceiptNo As Double) As tblPatientReceipt
    Function GetReceiptByReceiptNo(ByVal pReceiptNo As String) As RECEIPT
    Function SaveUpdateReceipt(ByVal Obj As Object) As Boolean
    Function DeleteReceiptItemDetailByReceiptID(ByVal pReceiptID As String) As Boolean

    '=========== Account Payable ====================
    Function SaveNewNameAccountPayable(ByVal Obj As Object) As Boolean
    Function SaveNewPaidAccountPayable(ByVal Obj As Object) As Boolean
    Function GetPaidAccountPayable(ByVal IDPaid As Integer) As ACCOUNT_PAYABLE_DETAIL
    Function GetNameAccountPayable(ByVal IDAccount As Integer) As ACCOUNT_PAYABLE


End Interface
