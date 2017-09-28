Imports Janus.Windows.GridEX

Public Class UCCabinet
    Dim CabinetDataAdapter As DSCabinetTableAdapters.tblCabinetTableAdapter
    Dim LocationDateAdapter As DSCabinetTableAdapters.tblCabinetLocationTableAdapter
    Dim cabinetRepo As ICabinetRepository = New CabinetRepository
    Dim ItemLocationDetail As DSLocationItemDetailTableAdapters.VLocationItemDetailTableAdapter
    Dim SearchItemLocationDataAdapter As DSLocationItemDetailTableAdapters.VItemsInCabinetTableAdapter
    Dim ItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter


    Private Sub subMenuAddCabinet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuAddCabinet.Click
        Dim FCabinet As New frmCabinet(Me)
        If FCabinet.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RefreshListCabinet()
            FCabinet.Close()
            FCabinet.Dispose()
        End If
    End Sub

    Private Sub UCCabinet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshListCabinet()
        RefreshgridLocation()
        RefreshgridItems()

        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then

            'Initialize Items
            With cbItems
                .DataSource = ItemDataAdapter.GetData
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Else

            With cbItems
                .DataSource = ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With

        End If


    End Sub
    Private Sub RefreshgridItems()
        If Not gridLocation.CurrentRow Is Nothing AndAlso gridLocation.CurrentRow.RowType = RowType.Record Then            
            gridItems.DataSource = ItemLocationDetail.GetDataItemByLocationID(Val(gridLocation.GetValue("LocationID")))
            lbItemCount.Text = "Items in Location : " & gridItems.RowCount
        End If
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CabinetDataAdapter = New DSCabinetTableAdapters.tblCabinetTableAdapter
        LocationDateAdapter = New DSCabinetTableAdapters.tblCabinetLocationTableAdapter
        ItemLocationDetail = New DSLocationItemDetailTableAdapters.VLocationItemDetailTableAdapter
        SearchItemLocationDataAdapter = New DSLocationItemDetailTableAdapters.VItemsInCabinetTableAdapter
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RefreshListCabinet()

        Dim myDataTable As New DataTable
        myDataTable = CabinetDataAdapter.GetCabinetDataByDepartID(CInt(DEPART_ID))

        Dim CabinetLists As New ArrayList()
        For Each aRow As DataRow In myDataTable.Rows
            CabinetLists.Add(New CabinetList(aRow("CabinetName"), aRow("CabinetID")))
        Next

        If CabinetLists.Count > 0 Then
            With listCabinet
                .DataSource = CabinetLists
                .DisplayMember = "ItemDisplay"
                .ValueMember = "ItemValue"
                .SelectedIndex = -1
            End With
        End If

    End Sub

    Private Sub RefreshgridLocation()
        gridLocation.DataSource = LocationDateAdapter.GetDataLocationsByCabinetID(Val(listCabinet.SelectedValue))
        lbLocaInCabi.Text = "Locations in Cabinet : " & gridLocation.RowCount
    End Sub

    Private Sub subMenuEditCabinet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuEditCabinet.Click

        Dim FCabinet As New frmCabinet(Me)
        If listCabinet.SelectedValue <> 0 Then
            FCabinet.lblSaveOption.Text = "1"
            FCabinet.myCabinetID = listCabinet.SelectedValue
            If FCabinet.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshListCabinet()
                FCabinet.Close()
                FCabinet.Dispose()
            End If
        End If

    End Sub

    Private Sub subMenuAddLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuAddLocation.Click
        Dim FLocation As New frmLocation(Me)
        If listCabinet.SelectedValue <> 0 Then
            FLocation.myCabinetID = listCabinet.SelectedValue
            If FLocation.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshgridLocation()
                FLocation.Close()
                FLocation.Dispose()
            End If
        End If
    End Sub
    Private Sub listCabinet_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles listCabinet.SelectedIndexChanged

        Try
            Dim cabiID As Integer = cabinetRepo.GetCabinetIDByCabinetName(listCabinet.GetItemText(listCabinet.Items.Item(listCabinet.SelectedIndex)), CInt(DEPART_ID))
            gridLocation.DataSource = LocationDateAdapter.GetDataLocationsByCabinetID(cabiID)
            lbLocaInCabi.Text = "Locations in Cabinet : " & gridLocation.RowCount
        Catch ex As Exception

        End Try

    End Sub

    Private Sub subMenuEditLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuEditLocation.Click
        Dim FLocation As New frmLocation(Me)

        If Not gridLocation.CurrentRow Is Nothing AndAlso gridLocation.CurrentRow.RowType = RowType.Record Then
            FLocation.lblSaveOption.Text = "1"
            FLocation.myLocationID = gridLocation.GetValue("LocationID")
            FLocation.myCabinetID = listCabinet.SelectedValue
            If FLocation.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshgridLocation()
                FLocation.Close()
                FLocation.Dispose()
            End If
        End If

    End Sub

    Private Sub btnStoreItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStoreItem.Click

        Dim frm As New frmRequestItemsDetail()
        frm.isRequestStoreItemInCabinet = True

        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
            frm.isDisplayItemInMainStock = True
        Else
            frm.isDisplayItemDepart = True
            frm.stockDepartID = CInt(DEPART_ID)
        End If


        If Not gridLocation.CurrentRow Is Nothing AndAlso gridLocation.CurrentRow.RowType = RowType.Record Then
            frm.myLocatinID = gridLocation.GetValue("LocationID")
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RefreshgridItems()

            End If
        End If

    End Sub

    Private Sub gridLocation_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridLocation.SelectionChanged
        Try
            RefreshgridItems()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUnStoreItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnStoreItem.Click
        Dim myLocationItemDetail As New tblLocationItemDetail
        If Not gridItems.CurrentRow Is Nothing AndAlso gridItems.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want UnStore selected item ?", "Unstore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                myLocationItemDetail = cabinetRepo.GetLocationItemDetailByID(Val(gridItems.GetValue("LocationItemDetailID")))
                cabinetRepo.DeleteLocationItemDetail(myLocationItemDetail)
                RefreshgridItems()
            End If
        End If
    End Sub

    Private Sub subMenuDeleteLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuDeleteLocation.Click
        Dim myCabinetLocation As New tblCabinetLocation
        If Not gridLocation.CurrentRow Is Nothing AndAlso gridLocation.CurrentRow.RowType = RowType.Record Then
            If MessageBox.Show("Do you want delete location ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If cabinetRepo.isItemExistInLocation(Val(gridLocation.GetValue("LocationID"))) = False Then
                    myCabinetLocation = cabinetRepo.GetLocationByID(Val(gridLocation.GetValue("LocationID")))
                    cabinetRepo.DeleteLocation(myCabinetLocation)
                    RefreshgridLocation()
                Else
                    MsgBox("Cannot delete location contents of items inside.")
                End If
            End If
        End If
       
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim myDataTable = SearchItemLocationDataAdapter.GetLocationItemDataByItemID(cbItems.SelectedValue, CInt(DEPART_ID))
        Dim myCabinetList As New ArrayList
        Dim i As Integer
        Dim isExisting As Boolean

        For Each aRow As DataRow In myDataTable.Rows
            isExisting = False
            If myCabinetList.Count < 0 Then
                myCabinetList.Add(aRow("CabinetName"))
            Else
                For i = 0 To myCabinetList.Count - 1
                    If aRow("CabinetName") = myCabinetList.Item(i) Then
                        isExisting = True                        
                        Exit For
                    End If
                Next
                If isExisting = False Then
                    myCabinetList.Add(aRow("CabinetName"))
                End If
            End If
        Next

        Dim myStrCabinets As String = ""
        Dim myStrLocation As String = ""
        If myCabinetList.Count > 0 Then
            For i = 0 To myCabinetList.Count - 1
                myStrCabinets = myStrCabinets & myCabinetList.Item(i) & vbCrLf
                For Each aRow As DataRow In myDataTable.Rows
                    If myCabinetList.Item(i) = aRow(("CabinetName")) Then
                        myStrLocation = myStrLocation & aRow(("LocationName")) & "   "
                    End If
                Next
                myStrLocation = myStrLocation & vbCrLf
            Next
        End If

        lbCabinet.Text = myStrCabinets
        lbLocation.Text = myStrLocation            
    End Sub
    Private Sub menuRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRefreshData.Click
        RefreshListCabinet()
        RefreshgridLocation()
        RefreshgridItems()
    End Sub
End Class
