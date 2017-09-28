Public Interface ICabinetRepository

    Function GetCabinetByID(ByVal pCabinetID As Integer) As tblCabinet
    Function GetLocationByID(ByVal pLoca As Integer) As tblCabinetLocation

    'Function DeleteCabinet(ByVal tblCabinet) As String
    'Function UpdateCabinet() As String
    Function CreateCabinet(ByVal tblCabinet) As String
    'Function isLocationExistSearchByLocationID(ByVal pLocationID As Integer, ByVal pDepartID As Integer, ByVal CabinetID As Integer) As Boolean
    Function GenerateCabinetID() As Integer
    Function isCabinetExistSearchByCabinetName(ByVal pCName As String, ByVal pDepart As Integer) As Boolean
    Function UpdateCabinet() As String
    Function GenerateLocationID() As Integer
    Function GetCabinetNameByID(ByVal pCabinetID As Integer) As String
    Function isLocationExistSearchByLocationName(ByVal pLName As String, ByVal pCabinetID As Integer) As Boolean
    Function CreateLocation(ByVal tblCabinetLocation) As String
    Function GetCabinetIDByCabinetName(ByVal pCN As String, ByVal pDepart As Integer) As Integer
    Function Update() As String

    Function AddLocationItemDetail(ByVal tblLocationItemDetail) As String

    Function isItemExistInLocationItemDetial(ByVal pLocationID As Integer, ByVal pItemID As Integer) As Boolean

    Function DeleteLocationItemDetail(ByVal tblLocationItemDetail) As String

    Function GetLocationItemDetailByID(ByVal pId As Integer) As tblLocationItemDetail

    Function isItemExistInLocation(ByVal pLocaID As Integer) As Boolean

    Function DeleteLocation(ByVal tblCabinetLocation) As String


End Interface
