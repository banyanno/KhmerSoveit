Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext
Public Class Item
    Implements IItem
    Private THIDataContext As New BaseDataContext

    Public Function CreateItem(ByVal tblItem As Object) As String Implements IItem.CreateItem
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblItems.InsertOnSubmit(tblItem)
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

    Public Function CreateItemWithoutTransCover(ByVal tblItem As Object) As Boolean Implements IItem.CreateItemWithoutTransCover
        THIDataContext.getTHIDataContext.tblItems.InsertOnSubmit(tblItem)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteItem(ByVal tblItem As Object) As String Implements IItem.DeleteItem
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblItems.DeleteOnSubmit(tblItem)
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

    Public Function DeleteItemWithoutTransCover(ByVal tblItem As Object) As Boolean Implements IItem.DeleteItemWithoutTransCover
        THIDataContext.getTHIDataContext.tblItems.DeleteOnSubmit(tblItem)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetItemByID(ByVal pItemID As Integer) As tblItem Implements IItem.GetItemByID
        Dim item = From tblItem In THIDataContext.getTHIDataContext.tblItems Where tblItem.ItemID = pItemID
        Return item.SingleOrDefault
    End Function

    Public Function ListItem() As System.Collections.Generic.List(Of tblItem) Implements IItem.ListItem
        Return THIDataContext.getTHIDataContext.tblItems.ToList
    End Function

    Public Function UpdateItem() As String Implements IItem.UpdateItem

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

    Public Function UpdateItemWithoutTransCover() As Boolean Implements IItem.UpdateItemWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function
    Public Function GetMaxItemID() As Integer Implements IItem.GetMaxItemID

        Try
            Dim ID = (From item In THIDataContext.getTHIDataContext.tblItems _
                  Select item.ItemID).Max
            Return ID
        Catch ex As Exception
            Return 0
        End Try
        
    End Function

    Public Function GetItemInMainStock(ByVal pItemID As Integer) As tblCentralInventory Implements IItem.GetItemInMainStock

        Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = pItemID
        Return q.SingleOrDefault

    End Function

    Public Function GetItemUnitInStockMain(ByVal pItemdID As Integer) As Integer Implements IItem.GetItemUnitInStockMain

        Dim q = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = pItemdID Select mainStock.UnitsInStock
        Return q.SingleOrDefault.Value

    End Function

    Public Function isItemExistInMainStock(ByVal pBarcode As String) As Boolean Implements IItem.isItemExistInMainStock

        Dim q = (From item In THIDataContext.getTHIDataContext.tblItems Where item.Barcode = pBarcode).Count()
        Return q

    End Function

    Public Function GetItemByBarcode(ByVal pBarcode As String) As tblItem Implements IItem.GetItemByBarcode

        Dim item = From tblItem In THIDataContext.getTHIDataContext.tblItems Where tblItem.Barcode = pBarcode
        Return item.SingleOrDefault

    End Function

    Public Function isValidItemBarcode(ByVal pBarcode As String) As Boolean Implements IItem.isValidItemBarcode

        Dim q = (From tblItem In THIDataContext.getTHIDataContext.tblItems Where tblItem.Barcode = pBarcode).Count
        Return q

    End Function

    Public Function GetItemPriceByItemPriceID(ByVal pItemPriceID As Double) As tblItemPrice Implements IItem.GetItemPriceByItemPriceID

        Dim myItemPrice = From itemPrice In THIDataContext.getTHIDataContext.tblItemPrices Where itemPrice.ItemPriceID = pItemPriceID
        Return myItemPrice.SingleOrDefault

    End Function

    'Public Function GetDepartItemBalance(ByVal pItemID As Integer, ByVal pDepartID As Integer) As tblDeptStock Implements IItem.GetDepartItemBalance     
    '    Dim myItemDepart = From itemDepart In THIDataContext.getTHIDataContext.tblDeptStocks Where itemDepart.ItemID = pItemID And itemDepart.DeptStockID = pDepartID
    '    Return myItemDepart.SingleOrDefault
    'End Function

End Class
