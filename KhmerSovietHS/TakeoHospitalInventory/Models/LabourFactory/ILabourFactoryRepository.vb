Public Interface ILabourFactoryRepository

    Function ListLabourFactory() As List(Of tblLabourFactory)
    Function DeleteLabourFactory(ByVal tblLabourFactory) As String

    Function UpdateLabourFactory() As String
    Function CreateLabourFactory(ByVal tblLabourFactory) As String
    Function GetLabourFactoryByID(ByVal pLabourFactoryID As Integer) As tblLabourFactory

    Function DeleteLabourFactoryWithoutTransCover(ByVal tblLabourFactory) As Boolean
    Function UpdateLaborFactoryWithoutTransCover() As Boolean
    Function CreateLabourFactoryWithoutTransCover(ByVal tblLabourFactory) As Boolean

    Function GetLabouFacNameIEnum(ByVal mycombo As ComboBox) As IEnumerable

    Function isLabourFacExistSearchByLabourFacName(ByVal pLabourFacName As String) As Boolean

End Interface
