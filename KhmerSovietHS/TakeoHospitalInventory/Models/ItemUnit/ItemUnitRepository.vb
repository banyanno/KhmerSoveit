Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext
Public Class ItemUnitRepository
    Implements IItemUnitRepository
    Private THIDataContext As New BaseDataContext

    Public Function ListItemUnit() As List(Of tblItemUnit) Implements IItemUnitRepository.ListItemUnit
        Return THIDataContext.getTHIDataContext.tblItemUnits.ToList
    End Function

    Public Function GetItemUnitByID(ByVal pItemUnitID As Integer) As tblItemUnit Implements IItemUnitRepository.GetItemUnitByID
        Dim itemUnit = From tblItemUnit In THIDataContext.getTHIDataContext.tblItemUnits Where tblItemUnit.ItemUnitID = pItemUnitID
        Return itemUnit.SingleOrDefault
    End Function

    Public Function DeleteItemUnit(ByVal tblItemUnit) As String Implements IItemUnitRepository.DeleteItemUnit

        THIDataContext.getTHIDataContext.Connection.Close()

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblItemUnits.DeleteOnSubmit(tblItemUnit)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()

        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            THIDataContext.getTHIDataContext.Connection.Close()
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function UpdateItemUnit() As String Implements IItemUnitRepository.UpdateItemUnit

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function CreateItemUnit(ByVal tblItemUnit) As String Implements IItemUnitRepository.CreateItemUnit
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblItemUnits.InsertOnSubmit(tblItemUnit)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()
        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function DeleteItemUnitWithoutTransCover(ByVal tblItemUnit) As Boolean Implements IItemUnitRepository.DeleteItemUnitWithoutTransCover
        THIDataContext.getTHIDataContext.tblItemUnits.DeleteOnSubmit(tblItemUnit)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function UpdateItemUnitWithoutTransCover() As Boolean Implements IItemUnitRepository.UpdateItemUnitWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function CreateItemUnitWithoutTransCover(ByVal tblItemUnit) As Boolean Implements IItemUnitRepository.CreateItemUnitWithoutTransCover
        THIDataContext.getTHIDataContext.tblItemUnits.InsertOnSubmit(tblItemUnit)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Private Function GetItemNameIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements IItemUnitRepository.GetItemNameIEnum
        Dim Filtered = THIDataContext.getTHIDataContext.tblItemUnits.Where(Function(itemU) _
                                    itemU.ItemUnitName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Function isUnitItemExistSearchByUnitItemName(ByVal pUnitItemName As String) As Boolean Implements IItemUnitRepository.isUnitItemExistSearchByUnitItemName
        Dim unitItem = (From ui In THIDataContext.getTHIDataContext.tblItemUnits Where ui.ItemUnitName.ToUpper = UCase(pUnitItemName) _
                        Select ui).Count()
        If unitItem > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetUnitItemIDByUnitItemName(ByVal pUnitItemName As String) As Integer Implements IItemUnitRepository.GetUnitItemIDByUnitItemName

        Dim str As Integer = 0
        Dim unitItem = From ui In THIDataContext.getTHIDataContext.tblItemUnits Where ui.ItemUnitName = pUnitItemName

        If unitItem.Count <> 0 Then
            Return unitItem.SingleOrDefault.ItemUnitID
        Else
            Return 0
        End If

    End Function

    Public Function GenerateItemUnitID() As Integer Implements IItemUnitRepository.GenerateItemUnitID
        If THIDataContext.getTHIDataContext.tblItemUnits.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From IU In THIDataContext.getTHIDataContext.tblItemUnits _
        Select IU.ItemUnitID).Max
            Return Val(q) + 1
        End If
    End Function

End Class
