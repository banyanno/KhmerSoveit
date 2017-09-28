Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext
Public Class LabourFactoryRepository
    Implements ILabourFactoryRepository
    Private THIDataContext As New BaseDataContext
    Public Function CreateLabourFactory(ByVal tblLabourFactory As Object) As String Implements ILabourFactoryRepository.CreateLabourFactory

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblLabourFactories.InsertOnSubmit(tblLabourFactory)
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

    Public Function CreateLabourFactoryWithoutTransCover(ByVal tblLabourFactory As Object) As Boolean Implements ILabourFactoryRepository.CreateLabourFactoryWithoutTransCover
        THIDataContext.getTHIDataContext.tblLabourFactories.InsertOnSubmit(tblLabourFactory)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteLabourFactory(ByVal tblLabourFactory As Object) As String Implements ILabourFactoryRepository.DeleteLabourFactory

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblLabourFactories.DeleteOnSubmit(tblLabourFactory)
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

    Public Function DeleteLabourFactoryWithoutTransCover(ByVal tblLabourFactory As Object) As Boolean Implements ILabourFactoryRepository.DeleteLabourFactoryWithoutTransCover
        THIDataContext.getTHIDataContext.tblLabourFactories.DeleteOnSubmit(tblLabourFactory)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetLabourFactoryByID(ByVal pLabourFactoryID As Integer) As tblLabourFactory Implements ILabourFactoryRepository.GetLabourFactoryByID
        Dim labourFactory = From tblLabourFactory In THIDataContext.getTHIDataContext.tblLabourFactories Where tblLabourFactory.LabourFacID = pLabourFactoryID
        Return labourFactory.SingleOrDefault
    End Function

    Public Function ListLabourFactory() As System.Collections.Generic.List(Of tblLabourFactory) Implements ILabourFactoryRepository.ListLabourFactory
        Return THIDataContext.getTHIDataContext.tblLabourFactories.ToList
    End Function

    Public Function UpdateLaborFactoryWithoutTransCover() As Boolean Implements ILabourFactoryRepository.UpdateLaborFactoryWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function UpdateLabourFactory() As String Implements ILabourFactoryRepository.UpdateLabourFactory

        THIDataContext.getTHIDataContext.Connection.Close()
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

    Public Function GetLabouFacNameIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements ILabourFactoryRepository.GetLabouFacNameIEnum
        Dim Filtered = THIDataContext.getTHIDataContext.tblLabourFactories.Where(Function(labourFax) _
                                    labourFax.LabourFacName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Function isLabourFacExistSearchByLabourFacName(ByVal pLabourFacName As String) As Boolean Implements ILabourFactoryRepository.isLabourFacExistSearchByLabourFacName
        Dim labourFac = (From q In THIDataContext.getTHIDataContext.tblLabourFactories Where q.LabourFacName.ToUpper = UCase(pLabourFacName) _
                      Select q).Count()
        If labourFac > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
