Imports System.Data

Public Interface IVendorRepository

    Function ListVender() As List(Of tblVender)
    Function GetVenderByID(ByVal pVenderID As Integer) As tblVender

    Function DeleteVender(ByVal tblVender) As String
    Function Update() As String
    Function CreateVender(ByVal tblVender) As String

    Function UpdateVendorWithoutTransCover() As Boolean
    Function DeleteVendorWithoutTransCover(ByVal tblVender) As Boolean
    Function CreateVendorWithoutTransCover(ByVal tblVender) As Boolean

    Function GetVendorNameIEnum(ByVal mycombo As ComboBox) As IEnumerable

    Function isVendorExistSearchByVendorName(ByVal pVendorName As String) As Boolean

    Function GetVendorItemSupplyStatusByID(ByVal pID As Integer) As tblVendorItemSupplyStatus

    Function GetVendorNameByID(ByVal pID As Integer) As String

End Interface
