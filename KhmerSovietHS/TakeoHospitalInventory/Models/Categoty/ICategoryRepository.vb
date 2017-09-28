Public Interface ICategoryRepository

    Function ListCate() As List(Of tblCategory)
    Function DeleteCate(ByVal tblCategory) As String

    Function UpdateCate() As String
    Function CreateCate(ByVal tblCategory) As String
    Function GetCateByID(ByVal pCateID As Integer) As tblCategory

    Function DeleteCateWithoutTransCover(ByVal tblCategory) As Boolean
    Function UpdateCateWithoutTransCover() As Boolean
    Function CreateCateWithoutTransCover(ByVal tblCategory) As Boolean

    Function GetCateNameIEnum(ByVal mycombo As ComboBox) As IEnumerable

    Sub PopulateTreeView(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode)
    Function GetCateIDByCateName(ByVal pCateName As String) As Integer
    Function isCateExistSearchByCateName(ByVal pCateName As String) As Boolean
    Function GenerateCateID() As Integer
    Function isCateHasSubCate(ByVal pCateID As Integer) As Boolean
    Function GetItemCountByCateID(ByVal pCateID As Integer) As Integer





End Interface
