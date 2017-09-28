Public Interface IItem

    Function ListItem() As List(Of tblItem)
    Function DeleteItem(ByVal tblItem) As String
    Function UpdateItem() As String
    Function CreateItem(ByVal tblItem) As String
    Function GetItemByID(ByVal pItemID As Integer) As tblItem
    Function DeleteItemWithoutTransCover(ByVal tblItem) As Boolean
    Function UpdateItemWithoutTransCover() As Boolean
    Function CreateItemWithoutTransCover(ByVal tblItem) As Boolean
    Function GetMaxItemID() As Integer
    Function GetItemInMainStock(ByVal pItemID As Integer) As tblCentralInventory
    Function GetItemUnitInStockMain(ByVal pItemdID As Integer) As Integer
    Function isItemExistInMainStock(ByVal pBarcode As String) As Boolean
    Function GetItemByBarcode(ByVal pBarcode As String) As tblItem
    Function isValidItemBarcode(ByVal pBarcode As String) As Boolean
    Function GetItemPriceByItemPriceID(ByVal pItemPriceID As Double) As tblItemPrice
    'Function GetDepartItemBalance(ByVal pItemID As Integer, ByVal pDepartID As Integer) As tblDeptStock


End Interface
