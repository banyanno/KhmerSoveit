Imports System.Data.Common

Public Class CabinetRepository
    Implements ICabinetRepository
    Private THIDataContext As New BaseDataContext
    Public Function GetCabinetByID(ByVal pCabinetID As Integer) As tblCabinet Implements ICabinetRepository.GetCabinetByID
        Dim q = From cabinet In THIDataContext.getTHIDataContext.tblCabinets Where cabinet.CabinetID = pCabinetID
        Return q.SingleOrDefault
    End Function

    Public Function GenerateCabinetID() As Integer Implements ICabinetRepository.GenerateCabinetID

        If THIDataContext.getTHIDataContext.tblCabinets.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From cabinet In THIDataContext.getTHIDataContext.tblCabinets _
        Select cabinet.CabinetID).Max
            Return Val(q) + 1
        End If

    End Function

    Public Function CreateCabinet(ByVal tblCabinet) As String Implements ICabinetRepository.CreateCabinet
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblCabinets.InsertOnSubmit(tblCabinet)
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

    Public Function isCabinetExistSearchByCabinetName(ByVal pCName As String, ByVal pDepart As Integer) As Boolean Implements ICabinetRepository.isCabinetExistSearchByCabinetName


        Dim q = (From cabi In THIDataContext.getTHIDataContext.tblCabinets Where cabi.CabinetName.ToUpper = UCase(pCName) And cabi.DepartID = pDepart _
                         Select cabi).Count()
        If q > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function UpdateCabinet() As String Implements ICabinetRepository.UpdateCabinet
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

    Public Function GenerateLocationID() As Integer Implements ICabinetRepository.GenerateLocationID
        If THIDataContext.getTHIDataContext.tblCabinetLocations.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From location In THIDataContext.getTHIDataContext.tblCabinetLocations _
        Select location.LocationID).Max
            Return Val(q) + 1
        End If
    End Function

    Public Function GetCabinetNameByID(ByVal pCabinetID As Integer) As String Implements ICabinetRepository.GetCabinetNameByID
        Dim q = From cabinet In THIDataContext.getTHIDataContext.tblCabinets Where cabinet.CabinetID = pCabinetID _
                        Select cabinet.CabinetName

        Return q.First

    End Function

    Public Function isLocationExistSearchByLocationName(ByVal pLName As String, ByVal pCabinetID As Integer) As Boolean Implements ICabinetRepository.isLocationExistSearchByLocationName
        Dim q = (From loca In THIDataContext.getTHIDataContext.tblCabinetLocations Where loca.LocationName.ToUpper = UCase(pLName) And loca.CabinetID = pCabinetID _
                        Select loca).Count()
        If q > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function CreateLocation(ByVal tblCabinetLocation) As String Implements ICabinetRepository.CreateLocation
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblCabinetLocations.InsertOnSubmit(tblCabinetLocation)
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

    Public Function GetCabinetIDByCabinetName(ByVal pCN As String, ByVal pDepart As Integer) As Integer Implements ICabinetRepository.GetCabinetIDByCabinetName
        Try
            Dim q = From cabi In THIDataContext.getTHIDataContext.tblCabinets Where cabi.CabinetName.ToUpper = UCase(pCN) And cabi.DepartID = pDepart _
                         Select cabi.CabinetID
            Return q.First
        Catch ex As Exception

        End Try
    End Function

    Public Function GetLocationByID(ByVal pLoca As Integer) As tblCabinetLocation Implements ICabinetRepository.GetLocationByID
        Dim q = From loca In THIDataContext.getTHIDataContext.tblCabinetLocations Where loca.LocationID = pLoca
        Return q.SingleOrDefault
    End Function

    Public Function Update() As String Implements ICabinetRepository.Update
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

    Public Function AddLocationItemDetail(ByVal tblLocationItemDetail) As String Implements ICabinetRepository.AddLocationItemDetail
        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblLocationItemDetails.InsertOnSubmit(tblLocationItemDetail)
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

    Public Function isItemExistInLocationItemDetial(ByVal pLocationID As Integer, ByVal pItemID As Integer) As Boolean Implements ICabinetRepository.isItemExistInLocationItemDetial

        Dim q = (From loca In THIDataContext.getTHIDataContext.tblLocationItemDetails Where loca.LocationID = pLocationID And loca.ItemID = pItemID _
                     Select loca).Count()
        If q > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function DeleteLocationItemDetail(ByVal tblLocationItemDetail) As String Implements ICabinetRepository.DeleteLocationItemDetail

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblLocationItemDetails.DeleteOnSubmit(tblLocationItemDetail)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()

        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function GetLocationItemDetailByID(ByVal pId As Integer) As tblLocationItemDetail Implements ICabinetRepository.GetLocationItemDetailByID
        Dim q = From locaID In THIDataContext.getTHIDataContext.tblLocationItemDetails Where locaID.LocationItemDetailID = pId
        Return q.SingleOrDefault
    End Function

    Public Function isItemExistInLocation(ByVal pLocaID As Integer) As Boolean Implements ICabinetRepository.isItemExistInLocation
        Dim q = (From loca In THIDataContext.getTHIDataContext.tblLocationItemDetails Where loca.LocationID = pLocaID _
                Select loca).Count()
        If q > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DeleteLocation(ByVal tblCabinetLocation) As String Implements ICabinetRepository.DeleteLocation

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblCabinetLocations.DeleteOnSubmit(tblCabinetLocation)
            THIDataContext.getTHIDataContext.SubmitChanges()
            trans.Commit()

        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

End Class
