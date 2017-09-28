Imports System.Data.Common

Public Class DepartStockRepository
    Implements IDepartStockRepository
    Private THIDataContext As New BaseDataContext

    Public Function GetDepartStockByDepartIDAndItemID(ByVal pDepartID As Integer, ByVal pItemID As Integer) As tblDeptStock Implements IDepartStockRepository.GetDepartStockByDepartIDAndItemID

        Dim q = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = pDepartID And departStock.ItemID = pItemID
        Return q.SingleOrDefault

    End Function

    Public Function UpdateDepartStock() As String Implements IDepartStockRepository.UpdateDepartStock

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"

    End Function
    ' Error when try to execute this function in block of loop
    Public Function isItemExistInDepartStock(ByVal pDepartID As Integer, ByVal pItemID As Integer) As Boolean Implements IDepartStockRepository.isItemExistInDepartStock

        'Dim q = (From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = pDepartID And departStock.ItemID = pItemID Select departStock.ItemID).Count()
        'Return q

        'Dim itemDepartStock As New tblDeptStock
        'Dim q = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = pDepartID And departStock.ItemID = pItemID
        'itemDepartStock = q.SingleOrDefault()
        'Try
        '    If IsDBNull(itemDepartStock.ItemID) = False And itemDepartStock.ItemID <> 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Catch ex As Exception
        '    Return False
        'End Try

        THIDataContext.getTHIDataContext.Connection.Close()        
        Dim q = THIDataContext.getTHIDataContext.ExecuteQuery(Of tblDeptStock)("SELECT * FROM tblDeptStock WHERE DepartID={0} AND ItemID={1}", pDepartID, pItemID)
        If q.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GetUnitInStockDepartByDepartIDAndItemID(ByVal pDepartID As Integer, ByVal pItemID As Integer) As Integer Implements IDepartStockRepository.GetUnitInStockDepartByDepartIDAndItemID
        Try
            Dim q = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = pDepartID And departStock.ItemID = pItemID Select departStock.UnitsInStock
            Return q.SingleOrDefault.Value
        Catch ex As Exception            
            Return 0
        End Try

    End Function

End Class
