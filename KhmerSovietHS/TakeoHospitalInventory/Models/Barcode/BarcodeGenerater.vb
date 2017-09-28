Public Class BarcodeGenerater
    Implements IBarcode

    Private THTOpticalShopContext As New BaseDataContext
    Public Function GetMaxBarCodeID() As Double Implements IBarcode.GetMaxBarCodeID
        Try
            Dim q = (From Reqeust In THTOpticalShopContext.getTHIDataContextOpticalShop.BARCODEs Select Reqeust.BarcodeID).Max '  THIDataContext.getTHIDataContext.tblRequests Select Reqeust.RequestID).Max
            ' Return max request order id
            If Val(q) = 0 Then
                Return 1
            Else
                Return Val(q) + 1
            End If
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Public Function SaveBardCode(ByVal bar As Object) As Boolean Implements IBarcode.SaveBardCode
        If THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.State = ConnectionState.Closed Then
            THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
            'Else
            '    THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.Open()
        End If

        Dim trans As Common.DbTransaction = THTOpticalShopContext.getTHIDataContextOpticalShop.Connection.BeginTransaction
        Try
            THTOpticalShopContext.getTHIDataContextOpticalShop.Transaction = trans
            THTOpticalShopContext.getTHIDataContextOpticalShop.BARCODEs.InsertOnSubmit(bar)
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
End Class
