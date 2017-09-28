Public Class Inventory
    Implements IInventory
    Private THIDataContext As New BaseDataContext
    Public Function AddItemIntoInventory(ByVal tblCentralInventory As Object) As Boolean Implements IInventory.AddItemIntoInventory
        THIDataContext.getTHIDataContext.tblCentralInventories.InsertOnSubmit(tblCentralInventory)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetMainStockQuantityByItemID(ByVal pItemID As Integer) As Integer Implements IInventory.GetMainStockQuantityByItemID

        Dim q = From MStock In THIDataContext.getTHIDataContext.tblCentralInventories Where MStock.ItemID = pItemID _
                Select MStock.UnitsInStock

        Return q.First

    End Function

End Class
