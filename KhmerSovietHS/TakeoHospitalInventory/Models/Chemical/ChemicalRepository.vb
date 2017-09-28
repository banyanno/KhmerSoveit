Imports System.Data.Common

Public Class ChemicalRepository
    Implements IChemicalRepository
    Private THIDataContext As New BaseDataContext

    Public Function CreateChemical(ByVal tblChemical As Object) As String Implements IChemicalRepository.CreateChemical
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            THIDataContext.getTHIDataContext.tblChemicals.InsertOnSubmit(tblChemical)
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

    Public Function CreateChemicalWithoutTransCover(ByVal tblChemical As Object) As Boolean Implements IChemicalRepository.CreateChemicalWithoutTransCover
        THIDataContext.getTHIDataContext.tblChemicals.InsertOnSubmit(tblChemical)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function DeleteChemical(ByVal tblChemical As Object) As String Implements IChemicalRepository.DeleteChemical

        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans
        Try
            THIDataContext.getTHIDataContext.tblChemicals.DeleteOnSubmit(tblChemical)
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

    Public Function DeleteChemicalWithoutTransCover(ByVal tblChemical As Object) As Boolean Implements IChemicalRepository.DeleteChemicalWithoutTransCover
        THIDataContext.getTHIDataContext.tblChemicals.DeleteOnSubmit(tblChemical)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function
    Public Function GetChemicalByID(ByVal pChemical As Integer) As tblChemical Implements IChemicalRepository.GetChemicalByID
        Dim chemical = From tblChemical In THIDataContext.getTHIDataContext.tblChemicals Where tblChemical.ChemicalID = pChemical
        Return chemical.SingleOrDefault
    End Function

    Public Function ListChemical() As System.Collections.Generic.List(Of tblChemical) Implements IChemicalRepository.ListChemical
        Return THIDataContext.getTHIDataContext.tblChemicals.ToList
    End Function

    Public Function UpdateChemical() As String Implements IChemicalRepository.UpdateChemical

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

    Public Function UpdateChemicalWithoutTransCover() As Boolean Implements IChemicalRepository.UpdateChemicalWithoutTransCover
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function

    Public Function GetChemicalNameIEnum(ByVal mycombo As ComboBox) As IEnumerable Implements IChemicalRepository.GetChemicalNameIEnum
        Dim Filtered = THIDataContext.getTHIDataContext.tblChemicals.Where(Function(chemical) _
                                    chemical.ChemicalName.Contains(mycombo.SelectedText))
        Return Filtered
    End Function

    Public Function isChemicalExistSearchByChemicalName(ByVal pChemiName As String) As Boolean Implements IChemicalRepository.isChemicalExistSearchByChemicalName
        Dim chemical = (From ch In THIDataContext.getTHIDataContext.tblChemicals Where ch.ChemicalName.ToUpper = UCase(pChemiName) _
                         Select ch).Count()
        If chemical > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function GenerateChemicalID() As Integer Implements IChemicalRepository.GenerateChemicalID

        If THIDataContext.getTHIDataContext.tblChemicals.ToList.Count = 0 Then
            Return 1
        Else
            Dim q = (From chemi In THIDataContext.getTHIDataContext.tblChemicals _
        Select chemi.ChemicalID).Max
            Return Val(q) + 1
        End If

    End Function

End Class
