Public Interface IContainerRepository

    Function ListContainer() As List(Of tblContainer)
    Function GetContainerByID(ByVal pContainerID As Integer) As tblContainer

    Function DeleteContainer(ByVal tblContainer) As String
    Function UpdateContainer() As String
    Function CreateContainer(ByVal tblContainer) As String


    Function DeleteContainerWithoutTransCover(ByVal tblContainer) As Boolean
    Function UpdateContainerWithoutTransCover() As Boolean
    Function CreateContainerWithoutTransCover(ByVal tblContainer) As Boolean

    Function GetContainerIEnum(ByVal mycombo As ComboBox) As IEnumerable

    Function isContainerExistSearchByContainerName(ByVal pContaName As String) As Boolean

    Function GenerateContainerID() As Integer

End Interface
