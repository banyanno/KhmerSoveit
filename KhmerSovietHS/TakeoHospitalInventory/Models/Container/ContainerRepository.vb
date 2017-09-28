Imports System.Data.Common

Public Class ContainerRepository
    Implements IContainerRepository

    Private THIDataContext As New BaseDataContext

    Public Function CreateContainer(ByVal tblContainer As Object) As String Implements IContainerRepository.CreateContainer

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblContainers.InsertOnSubmit(tblContainer)
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

    Public Function CreateContainerWithoutTransCover(ByVal tblContainer As Object) As Boolean Implements IContainerRepository.CreateContainerWithoutTransCover
        THIDataContext.getTHIDataContext.tblContainers.InsertOnSubmit(tblContainer)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteContainer(ByVal tblContainer As Object) As String Implements IContainerRepository.DeleteContainer

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblContainers.DeleteOnSubmit(tblContainer)
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

    Public Function DeleteContainerWithoutTransCover(ByVal tblContainer As Object) As Boolean Implements IContainerRepository.DeleteContainerWithoutTransCover
        THIDataContext.getTHIDataContext.tblContainers.DeleteOnSubmit(tblContainer)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetContainerByID(ByVal pContainerID As Integer) As tblContainer Implements IContainerRepository.GetContainerByID
        Dim container = From tblContainer In THIDataContext.getTHIDataContext.tblContainers Where tblContainer.ContainerID = pContainerID
        Return container.SingleOrDefault
    End Function

    Public Function ListContainer() As System.Collections.Generic.List(Of tblContainer) Implements IContainerRepository.ListContainer
        Return THIDataContext.getTHIDataContext.tblContainers.ToList
    End Function

    Public Function UpdateContainer() As String Implements IContainerRepository.UpdateContainer

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

    Public Function UpdateContainerWithoutTransCover() As Boolean Implements IContainerRepository.UpdateContainerWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function


    Public Function GetContainerIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements IContainerRepository.GetContainerIEnum
        Dim Filtered = THIDataContext.getTHIDataContext.tblContainers.Where(Function(container) _
                                    container.ContainerName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Function isContainerExistSearchByContainerName(ByVal pContaName As String) As Boolean Implements IContainerRepository.isContainerExistSearchByContainerName

        Dim container = (From cn In THIDataContext.getTHIDataContext.tblContainers Where cn.ContainerName.ToUpper = UCase(pContaName) _
                         Select cn).Count()
        If container > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GenerateContainerID() As Integer Implements IContainerRepository.GenerateContainerID
        If THIDataContext.getTHIDataContext.tblContainers.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From conta In THIDataContext.getTHIDataContext.tblContainers _
        Select conta.ContainerID).Max
            Return Val(q) + 1
        End If
    End Function

End Class
