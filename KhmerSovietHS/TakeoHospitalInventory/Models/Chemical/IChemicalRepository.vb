Public Interface IChemicalRepository

    Function ListChemical() As List(Of tblChemical)
    Function GetChemicalByID(ByVal pChemical As Integer) As tblChemical

    Function DeleteChemical(ByVal tblChemical) As String
    Function UpdateChemical() As String
    Function CreateChemical(ByVal tblChemical) As String

    Function DeleteChemicalWithoutTransCover(ByVal tblChemical) As Boolean
    Function UpdateChemicalWithoutTransCover() As Boolean
    Function CreateChemicalWithoutTransCover(ByVal tblChemical) As Boolean

    Function GetChemicalNameIEnum(ByVal mycombo As ComboBox) As IEnumerable
    Function isChemicalExistSearchByChemicalName(ByVal pChemiName As String) As Boolean

    Function GenerateChemicalID() As Integer

End Interface
