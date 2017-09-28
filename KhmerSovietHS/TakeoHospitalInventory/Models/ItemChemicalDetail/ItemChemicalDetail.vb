Public Class ItemChemicalDetail
    Implements IItemChemicalDetail
    Private THIDataContext As New BaseDataContext
    Public Function AddItemChemical(ByVal ptblItemChemicalDetail As Object) As Boolean Implements IItemChemicalDetail.AddItemChemical
        THIDataContext.getTHIDataContext.tblItemChemicalDetails.InsertOnSubmit(ptblItemChemicalDetail)
        THIDataContext.getTHIDataContext.SubmitChanges()
        Return True
    End Function
End Class
