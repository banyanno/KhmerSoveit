Imports System.Data.Linq

Public Class OpticalshopImp
    Implements IOpticalShop

    Private THTOpticalShopContext As New BaseDataContext
    Public Function SaveNewIncomeType(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveNewIncomeType
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.INCOME_TYPEs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveNewCustomer(ByVal Obj As Object) As Double Implements IOpticalShop.SaveNewCustomer
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_CUSTOMERs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Dim cus As RECEIPT_CUSTOMER = CType(Obj, RECEIPT_CUSTOMER)
            Return cus.CustomerNo
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return 0
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveNewDonation(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveNewDonation
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.DONATIONs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveNewReceipt(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveNewReceipt
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPTs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveUpdateReceipt(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveUpdateReceipt
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveReceiptDetail(ByVal obj As Object) As Boolean Implements IOpticalShop.SaveReceiptDetail
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_DETAILs.InsertOnSubmit(obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function GetReceipt(ByVal receiptId As Double) As RECEIPT Implements IOpticalShop.GetReceipt
        Dim ObjReceipt = From RECEIPT In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPTs Where RECEIPT.ReceiptID = CDec(receiptId)
        Return ObjReceipt.SingleOrDefault
    End Function

    Public Function GetReceiptByReceiptNo(ByVal pReceiptNo As String) As RECEIPT Implements IOpticalShop.GetReceiptByReceiptNo

        Dim ObjReceipt = From RECEIPT In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPTs Where RECEIPT.ReceiptID = pReceiptNo
        Return ObjReceipt.SingleOrDefault

    End Function



    Public Function UpdateReceiptPay() As Boolean Implements IOpticalShop.UpdateReceiptPay
        If THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.State = ConnectionState.Closed Then
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        End If
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function GetMaxCustomerID() As Double Implements IOpticalShop.GetMaxCustomerID
        Try
            'Dim ID = (From RECEIPT_CUSTOMER In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_CUSTOMERs _
            '      Select RECEIPT_CUSTOMER.CustID).Last

            Dim ID = From RECEIPT_CUSTOMER In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_CUSTOMERs
            Dim cus As RECEIPT_CUSTOMER = ID.ToList.Last
            Return cus.CustID + 1
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Public Function DeleteReceiptItemDetailByReceiptID(ByVal pReceiptID As String) As Boolean Implements IOpticalShop.DeleteReceiptItemDetailByReceiptID
        If THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.State = ConnectionState.Closed Then
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        End If
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.ExecuteCommand("DELETE FROM RECEIPT_DETAIL WHERE ReceiptNo={0}", pReceiptID)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function GetNameAccountPayable(ByVal IDAccount As Integer) As ACCOUNT_PAYABLE Implements IOpticalShop.GetNameAccountPayable
        Dim ObjReceipt = From ACCOUNT_PAYABLE In THTOpticalShopContext.getTHIDataContextOpticalShop.ACCOUNT_PAYABLEs Where ACCOUNT_PAYABLE.AccountID = IDAccount
        Return ObjReceipt.SingleOrDefault
    End Function

    Public Function GetPaidAccountPayable(ByVal IDPaid As Integer) As ACCOUNT_PAYABLE_DETAIL Implements IOpticalShop.GetPaidAccountPayable
        Dim ObjReceipt = From ACCOUNT_PAYABLE_DETAIL In THTOpticalShopContext.getTHIDataContextOpticalShop.ACCOUNT_PAYABLE_DETAILs Where ACCOUNT_PAYABLE_DETAIL.ACC_PAID_ID = IDPaid
        Return ObjReceipt.SingleOrDefault
    End Function

    Public Function SaveNewNameAccountPayable(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveNewNameAccountPayable
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.ACCOUNT_PAYABLEs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function SaveNewPaidAccountPayable(ByVal Obj As Object) As Boolean Implements IOpticalShop.SaveNewPaidAccountPayable
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.ACCOUNT_PAYABLE_DETAILs.InsertOnSubmit(Obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Function DoSaveInPatientReceipt(ByVal ReceiptNo As Long, ByVal HN As Long, ByVal PatientName As String, _
       ByVal CashRiel As Double, ByVal CashUSD As Double, _
       ByVal TotalRiel As Double, ByVal TotalUSD As Double, _
       ByVal OperationFeeRiel As Double, ByVal OperationFeeUSD As Double, _
       ByVal ArtificialEyeFeeRiel As Double, ByVal ArtificialEyeUSD As Double, _
       ByVal OtherFeeRiel As Double, ByVal OtherFeeUSD As Double, _
       ByVal SocialFeeRiel As Double, ByVal SocialFeeUSD As Double, _
       ByVal FullFeeRiel As Double, ByVal FullFeeUSD As Double, ByVal Rates As Double, ByVal AmountWord As String, _
       ByVal ConOP As String, ByVal ConAE As String, ByVal ConOT As String, ByVal ConSocialFee As String, _
       ByVal ConFullFee As String, ByVal ConGeneral As String, _
       ByVal CashierIn As String, ByVal CashierUpdate As String, _
       ByVal PrintCount As Integer, ByVal DateIn As Date, _
       ByVal DateNow As Date, ByVal Years As Integer, _
       ByVal Operation As String, ByVal IsDonation As Boolean, _
       ByVal DonationID As Double, ByVal DonationName As String, _
       ByVal DonationPay As Double, ByVal DonateNote As String, ByVal HosFee As Double) As String
        Dim SQL As String = "INSERT INTO tblPatientReceipt " _
                            & " (ReceiptNo, HN, PatientName, CashRiel, CashUSD, TotalRiel, TotalUSD," _
                            & " OperationFeeRiel, OperationFeeUSD, ArtificialEyeFeeRiel, ArtificialEyeFeeUSD, OtherFeeRiel," _
                            & " OtherFeeUSD, SocialFeeRiel," _
                            & " SocialFeeUSD, FullFeeRiel, FullFeeUSD, Rates, AmoutWord, ConOP, ConAE, ConOT, ConSocialFee, ConFullFee," _
                            & " ConGeneral, CashierIn, CashierUpdate, PrintCount, DateIn, DateNow,Years, Operation,IsDonation,DonationID," _
                            & " DonationName,DonationPay,DonateNote,HosFee)" _
                            & " VALUES(" & ReceiptNo & "," & HN & ",'" & PatientName & "'," _
                            & CashRiel & "," & CashUSD & "," & TotalRiel & "," & TotalUSD & "," _
                            & OperationFeeRiel & "," & OperationFeeUSD & "," & ArtificialEyeFeeRiel & "," & ArtificialEyeUSD & "," _
                            & OtherFeeRiel & "," & OtherFeeUSD & "," _
                            & SocialFeeRiel & "," & SocialFeeUSD & "," _
                            & FullFeeRiel & "," & FullFeeUSD & "," & Rates & ",'" _
                            & AmountWord & "','" & ConOP & "','" & ConAE & "','" & ConOT & "','" & ConSocialFee & "','" _
                            & ConFullFee & "','" & ConGeneral & "','" _
                            & CashierIn & "','" & CashierUpdate & "'," & PrintCount & ",'" & DateIn _
                            & "','" & DateNow & "'," & Years & ",'" & Operation & "','" & IsDonation & "'," _
                            & DonationID & ",'" & DonationName & "'," & DonationPay & ",'" & DonateNote & "'," & HosFee & ")"
        Return SQL
    End Function

    Public Function SaveNewReceiptPatient(ByVal obj As Object) As Boolean Implements IOpticalShop.SaveNewReceiptPatient
        THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.tblPatientReceipts.InsertOnSubmit(obj)
            THTOpticalShopContext.getTHIDataContextOpticalShop.SubmitChanges()
            trans.Commit()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return True
        Catch ex As Exception
            trans.Rollback()
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Close()
            Return False
        Finally
            trans = Nothing
        End Try
    End Function

    Public Function GetTblPatientReceipt(ByVal ReceiptNo As Double) As tblPatientReceipt Implements IOpticalShop.GetTblPatientReceipt
        Dim ObjReceipt = From tblPatientReceipt In THTOpticalShopContext.getTHIDataContextOpticalShop.tblPatientReceipts Where tblPatientReceipt.ReceiptNo = ReceiptNo
        Return ObjReceipt.SingleOrDefault
    End Function

    Public Function GetReceiptNo(ByVal ReceiptNo As String) As RECEIPT Implements IOpticalShop.GetReceiptNo
        Dim ObjReceipt = From RECEIPT In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPTs Where RECEIPT.ReceiptNo = ReceiptNo
        Return ObjReceipt.SingleOrDefault
    End Function
End Class
