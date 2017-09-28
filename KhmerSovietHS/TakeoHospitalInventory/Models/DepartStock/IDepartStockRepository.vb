Public Interface IDepartStockRepository

    Function GetDepartStockByDepartIDAndItemID(ByVal pDepartID As Integer, ByVal pItemID As Integer) As tblDeptStock
    Function UpdateDepartStock() As String
    Function isItemExistInDepartStock(ByVal pDepartID As Integer, ByVal pItemID As Integer) As Boolean
    Function GetUnitInStockDepartByDepartIDAndItemID(ByVal pDepartID As Integer, ByVal pItemID As Integer) As Integer


End Interface
