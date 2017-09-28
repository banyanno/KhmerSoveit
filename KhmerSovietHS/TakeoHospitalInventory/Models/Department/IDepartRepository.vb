Public Interface IDepartRepository

    Function ListDepart() As List(Of tblDepartment)
    Function GetDepartByID(ByVal pDepartID As Integer) As tblDepartment

    Function DeleteDepart(ByVal tblDepartment) As String
    Function UpdateDepart() As String
    Function CreateDepart(ByVal tblDepartment) As String


    Function DeleteDepartWithoutTransCover(ByVal tblDepartment) As Boolean
    Function UpdateDepartWithoutTransCover() As Boolean
    Function CreateDepartWithoutTransCover(ByVal tblDepartment) As Boolean

    Function isDepartExistSearchByDepartName(ByVal pDepartName As String) As Boolean

    Function GenerateDepartmentID() As Integer

    Function GetDepartNameByID(ByVal pId As Integer) As String

End Interface
