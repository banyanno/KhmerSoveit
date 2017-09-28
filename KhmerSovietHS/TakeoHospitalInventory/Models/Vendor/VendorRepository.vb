Imports System.Linq
Imports System.Data.Common
Imports System.Data.Linq.DataContext

Public Class VendorRepository
    Implements IVendorRepository

    Private THIDataContext As New BaseDataContext

    Public Function ListVender() As List(Of tblVender) Implements IVendorRepository.ListVender
        Return THIDataContext.getTHIDataContext.tblVenders.ToList
    End Function

    Public Function GetVenderByID(ByVal pVenderID As Integer) As tblVender Implements IVendorRepository.GetVenderByID
        Dim vender = From tblVender In THIDataContext.getTHIDataContext.tblVenders Where tblVender.VenderID = pVenderID
        Return vender.SingleOrDefault
    End Function

    Public Function DeleteVender(ByVal tblVender) As String Implements IVendorRepository.DeleteVender

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblVenders.DeleteOnSubmit(tblVender)
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

    Public Function Update() As String Implements IVendorRepository.Update
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
            Return ex.Message
        Finally
            trans = Nothing
        End Try
        Return "True"
    End Function

    Public Function CreateVender(ByVal tblVender) As String Implements IVendorRepository.CreateVender
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblVenders.InsertOnSubmit(tblVender)
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

    Public Function UpdateVendorWithoutTransCover() As Boolean Implements IVendorRepository.UpdateVendorWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteVendorWithoutTransCover(ByVal tblVender) As Boolean Implements IVendorRepository.DeleteVendorWithoutTransCover
        THIDataContext.getTHIDataContext.tblVenders.DeleteOnSubmit(tblVender)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function CreateVendorWithoutTransCover(ByVal tblVender) As Boolean Implements IVendorRepository.CreateVendorWithoutTransCover
        THIDataContext.getTHIDataContext.tblVenders.InsertOnSubmit(tblVender)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetVendorNameIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements IVendorRepository.GetVendorNameIEnum
        Dim Filtered = THIDataContext.getTHIDataContext.tblVenders.Where(Function(vendor) _
                                    vendor.VenderName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Function isVendorExistSearchByVendorName(ByVal pVendorName As String) As Boolean Implements IVendorRepository.isVendorExistSearchByVendorName

        Dim vendor = (From q In THIDataContext.getTHIDataContext.tblVenders Where q.VenderName.ToUpper = UCase(pVendorName) _
                       Select q).Count()
        If vendor > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function GetVendorItemSupplyStatusByID(ByVal pID As Integer) As tblVendorItemSupplyStatus Implements IVendorRepository.GetVendorItemSupplyStatusByID
        Dim venderISS = From tblVendorItemSupplyStatus In THIDataContext.getTHIDataContext.tblVendorItemSupplyStatus Where tblVendorItemSupplyStatus.VendorItemSupplyStatusID = pID
        Return venderISS.SingleOrDefault
    End Function

    Public Function GetVendorNameByID(ByVal pID As Integer) As String Implements IVendorRepository.GetVendorNameByID

        Try
            Dim q = From vendor In THIDataContext.getTHIDataContext.tblVenders Where vendor.VenderID = pID
            Return q.SingleOrDefault.VenderName
        Catch ex As Exception
            MsgBox("Error : " & ex.Message)
            Return ""
        End Try
    End Function

End Class
