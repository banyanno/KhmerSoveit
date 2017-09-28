Public Interface IInventory

    'Function ListCate() As List(Of tblCategory)
    'Function DeleteCate(ByVal tblCategory) As String

    'Function UpdateCate() As String
    'Function CreateCate(ByVal tblCategory) As String
    'Function GetCateByID(ByVal pCateID As Integer) As tblCategory

    'Function DeleteCateWithoutTransCover(ByVal tblCategory) As Boolean
    'Function UpdateCateWithoutTransCover() As Boolean

    Function AddItemIntoInventory(ByVal tblCentralInventory) As Boolean
    'Function GetCateNameIEnum(ByVal mycombo As ComboBox) As IEnumerable
    Function GetMainStockQuantityByItemID(ByVal pItemID As Integer) As Integer


End Interface
