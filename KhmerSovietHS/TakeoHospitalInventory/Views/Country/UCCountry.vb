Imports Janus.Windows.GridEX

Public Class UCCountry

    Dim CountryDataAdapter As DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CountryDataAdapter = New DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UCCountry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myRefresh()
    End Sub

    Sub myRefresh()
        gridCountry.DataSource = CountryDataAdapter.GetData
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FCountry As New frmCountry(Me)
        FCountry.ShowDialog()
        FCountry.Close()
        FCountry.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not gridCountry.CurrentRow Is Nothing AndAlso gridCountry.CurrentRow.RowType = RowType.Record Then
            Dim FCountry As New frmCountry(Me)
            FCountry.lblSaveOption.Text = "1"
            FCountry.countryID = gridCountry.GetValue("CountryID")
            FCountry.countryName = gridCountry.GetValue("Country")
            FCountry.ShowDialog()
            FCountry.Close()
            FCountry.Dispose()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        myRefresh()
    End Sub

    Public Sub FillDataByCountryName(ByVal pCountryName As String)
        gridCountry.DataSource = CountryDataAdapter.GetCountryByName(pCountryName)
    End Sub

End Class
