Public Interface IItemUnitRepository

    Function ListItemUnit() As List(Of tblItemUnit)
    Function DeleteItemUnit(ByVal tblItemUnit) As String

    Function UpdateItemUnit() As String
    Function CreateItemUnit(ByVal tblItemUnit) As String
    Function GetItemUnitByID(ByVal pItemUnitID As Integer) As tblItemUnit

    Function DeleteItemUnitWithoutTransCover(ByVal tblItemUnit) As Boolean
    Function UpdateItemUnitWithoutTransCover() As Boolean
    Function CreateItemUnitWithoutTransCover(ByVal tblItemUnit) As Boolean

    Function GetItemNameIEnum(ByVal mycombo As ComboBox) As IEnumerable

    Function isUnitItemExistSearchByUnitItemName(ByVal pUnitItemName As String) As Boolean

    Function GetUnitItemIDByUnitItemName(ByVal pUnitItemName As String) As Integer

    Function GenerateItemUnitID() As Integer

End Interface
