Public Class BaseDataContext
    Private THIDataContext As TakeoHospitalInventoryDataContext
    Private THIDataContextUser As DataClassesUserManagmentDataContext
    Private THIDataContextOpticalShop As LinqOpticalShopClassesDataContext

    Public Sub New()
        THIDataContext = New TakeoHospitalInventoryDataContext
        THIDataContextUser = New DataClassesUserManagmentDataContext
        THIDataContextOpticalShop = New LinqOpticalShopClassesDataContext
    End Sub

    ReadOnly Property getTHIDataContext() As TakeoHospitalInventoryDataContext
        Get
            Return THIDataContext
        End Get
    End Property

    ReadOnly Property getTHIDataContextUserManagement() As DataClassesUserManagmentDataContext
        Get
            Return THIDataContextUser
        End Get
    End Property
    ReadOnly Property getTHIDataContextOpticalShop() As LinqOpticalShopClassesDataContext
        Get
            Return THIDataContextOpticalShop
        End Get
    End Property
End Class
