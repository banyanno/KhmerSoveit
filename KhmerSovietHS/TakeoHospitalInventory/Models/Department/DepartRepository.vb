Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext

Public Class DepartRepository
    Implements IDepartRepository

    Private THIDataContext As New BaseDataContext

    Public Function GetDepartNameByID(ByVal pId As Integer) As String Implements IDepartRepository.GetDepartNameByID
        Dim q = From depart In THIDataContext.getTHIDataContext.tblDepartments Where depart.DepartID = pId _
                        Select depart.DepartName

        Return q.First
    End Function


    Public Function ListDepart() As List(Of tblDepartment) Implements IDepartRepository.ListDepart
        Return THIDataContext.getTHIDataContext.tblDepartments.ToList

    End Function

    Public Function GetDepartByID(ByVal pDepartID As Integer) As tblDepartment Implements IDepartRepository.GetDepartByID

        Dim depart = From tblDepartment In THIDataContext.getTHIDataContext.tblDepartments Where tblDepartment.DepartID = pDepartID
        Return depart.SingleOrDefault

    End Function

    Public Function DeleteDepart(ByVal tblDepartment) As String Implements IDepartRepository.DeleteDepart

        THIDataContext.getTHIDataContext.Connection.Close()

        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblDepartments.DeleteOnSubmit(tblDepartment)
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

    

    Public Function CreateDepart(ByVal tblDepartment) As String Implements IDepartRepository.CreateDepart
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblDepartments.InsertOnSubmit(tblDepartment)
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

    Public Function DeleteDepartWithoutTransCover(ByVal tblDepartment) As Boolean Implements IDepartRepository.DeleteDepartWithoutTransCover
        THIDataContext.getTHIDataContext.tblDepartments.DeleteOnSubmit(tblDepartment)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function UpdateDepartWithoutTransCover() As Boolean Implements IDepartRepository.UpdateDepartWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function CreateDepartWithoutTransCover(ByVal tblDepartment) As Boolean Implements IDepartRepository.CreateDepartWithoutTransCover
        THIDataContext.getTHIDataContext.tblDepartments.InsertOnSubmit(tblDepartment)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function isDepartExistSearchByDepartName(ByVal pDepartName As String) As Boolean Implements IDepartRepository.isDepartExistSearchByDepartName
        Dim depart = (From de In THIDataContext.getTHIDataContext.tblDepartments Where de.DepartName.ToUpper = UCase(pDepartName) _
                        Select de).Count()
        If depart > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function GenerateDepartmentID() As Integer Implements IDepartRepository.GenerateDepartmentID

        Try
            Dim departNum As Integer = Val((From de In THIDataContext.getTHIDataContext.tblDepartments Select de.DepartID).Max)
            If THIDataContext.getTHIDataContext.tblDepartments.ToList.Count = 0 Then
                Return 1
            Else
                Return departNum + 1
            End If
        Catch ex As Exception
            MessageBox.Show("Error getting department number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Function


    Public Function UpdateDepart() As String Implements IDepartRepository.UpdateDepart
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
End Class
