Public Class frmCompareItemInStock
    Public myItemID As Integer
    Dim ItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Public isDepartRequestShow As Boolean

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frmCompareItemInStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridCompareItemInStock.CardCaptionPrefix = "Unit In Stock Of Departement: " & DEPART_NAME
        If isDepartRequestShow = False Then
            gridCompareItemInStock.DataSource = ItemDataAdapter.GetDataByItemID(myItemID)
        Else
            gridCompareItemInStock.DataSource = ItemDepartDataAdapter.GetItemDataInDepartByItemID(CInt(DEPART_ID), myItemID)
        End If
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmCompareItemInStock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub gridCompareItemInStock_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridCompareItemInStock.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub
End Class