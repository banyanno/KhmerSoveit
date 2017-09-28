Public Class frmRequestItemsDetail

    Dim ItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim PurchaseOrderDataAdapter As PurchaseOrderTableAdapters.VItemListVisibleForDepartTableAdapter
    Dim ItemForDepartDataAdapter As PurchaseOrderTableAdapters.VItemListForDepartmentTableAdapter
    Dim ItemOutsideHospitalDataAdapter As DSPharmacyTableAdapters.ITEM_OUTSIDE_INVENTORYTableAdapter
    'Dim ItemListInDepart As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim ItemListInDepart As PurchaseOrderTableAdapters.VItemListInDepartTableAdapter

    Dim FAddRequestOrder As New frmAddRequestOrder
    Public objDataTable As New System.Data.DataTable

    Public isRequestStoreItemInCabinet As Boolean = False
    Public objDataTableItemInCabinet As New System.Data.DataTable
    Public myLocatinID As String
    Dim cabinetRepo As ICabinetRepository = New CabinetRepository

    'Dim frmAddRequest As frmAddRequestOrder
    Public isDisplayItemInMainStock As Boolean
    Public isDisplayItemDepart As Boolean
    Public stockDepartID As Integer
    Public isCheckStockRequest As Boolean = False
    Public ItemRequestDT As New DSCategoriesAndItems.ItemReqDataTable

    '--- Hospital request to Caritas parameters
    Public isCaritasReqOrder As Boolean
    Public isDisplayItemOutside As Boolean
    Public ReqStatus As String
    'Public CaritasDataTable As New System.Data.DataTable
    Public CaritasDataTable As New DSHospitalRequestToCaritas.CaritasReqDataTableDataTable
    Public frmReqOrder As frmAddRequestOrder
    Public frmCaritasReqOrder As frmAddCaritasRequestOrder


    Dim DA_ItemUsed As New DSRequestTableAdapters.VUsedWithUsedDetailTableAdapter

    Public Sub New()        
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'frmAddRequest = pfrmAddRequest
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal CaritasReqOrder As frmAddCaritasRequestOrder)
        ' This call is required by the Windows Form Designer.
        frmCaritasReqOrder = CaritasReqOrder
        InitializeComponent()
        'frmAddRequest = pfrmAddRequest
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal reqOrder As frmAddRequestOrder)
        frmReqOrder = reqOrder
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'frmAddRequest = pfrmAddRequest
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub MyRefresh()

        If isDisplayItemInMainStock = True Then            
            DGVItemInStock.DataSource = ItemForDepartDataAdapter.GetItemListForDepart(stockDepartID)
            DGVItemInStock.Columns.Item("cInStock").Visible = False
        End If

        If isDisplayItemDepart = True Then
            DGVItemInStock.DataSource = ItemListInDepart.GetItemDataByDepartID(stockDepartID)
            DGVItemInStock.Columns.Item("cInStock").Visible = False

        End If

        '--- Hospital request to Caritas
        If isDisplayItemOutside = True Then            
            Dim myDataTable As New DataTable
            Dim obj(9) As Object
            DGVItemInStock.Rows.Clear()
            'myDataTable = ItemOutsideHospitalDataAdapter.GetData()
            myDataTable = ItemOutsideHospitalDataAdapter.GetItemOutsideNotRegistered() '--- Get item not yet register to inventory
            For Each aRow As DataRow In myDataTable.Rows
                With DGVItemInStock
                    obj(0) = False
                    obj(1) = aRow("ItemID")
                    obj(2) = aRow("ItemName")
                    obj(3) = ""
                    obj(4) = ""
                    obj(5) = ""
                    obj(6) = ""
                    obj(7) = "" ' Request Quantity
                    obj(8) = "" ' Barcode
                    obj(9) = ""
                    .Rows.Add(obj)
                End With
            Next

            With cbItems
                .DataSource = ItemOutsideHospitalDataAdapter.GetData()
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If
        ' Initial grid Item Request depend user select request order
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Delete item to grid Items Request
        With DGVItemInStock
            For Each rRow As DataGridViewRow In .SelectedRows
                .Rows.Remove(rRow)
            Next
        End With
    End Sub
    Private Sub frmRequestItemsDetail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GroupBoxItemUsed.Text = "List of Item used in " & DEPART_NAME
        PurchaseOrderDataAdapter = New PurchaseOrderTableAdapters.VItemListVisibleForDepartTableAdapter
        ItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ItemOutsideHospitalDataAdapter = New DSPharmacyTableAdapters.ITEM_OUTSIDE_INVENTORYTableAdapter
        ItemForDepartDataAdapter = New PurchaseOrderTableAdapters.VItemListForDepartmentTableAdapter
        ItemListInDepart = New PurchaseOrderTableAdapters.VItemListInDepartTableAdapter
        MyRefresh()
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If isCaritasReqOrder = False Then
            ''=================================== Addd reques Insite site ======================================
            If isRequestStoreItemInCabinet = False Then
                Dim itemName As String = ""
                '=============================================Add by dialy item used========================
                If ChItemUsed.Checked = True Then
                    Try
                        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
                        checkedRows = GridItemUsed.GetCheckedRows()

                        If checkedRows.Length = 0 Then
                            MessageBox.Show("Please select item in the list used.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Else
                            If MessageBox.Show("Do you want add these item to list?", "add", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                                    'Dim row1 As DataRow = TblBarcodePrint.NewRow
                                    'row1("BarcodeNo") = row.Cells("BarcodeNo").Value
                                    'row1("Column") = 10
                                    'row1("Rows") = 5
                                    'TblBarcodePrint.Rows.Add(row1)

                                    itemName = row.Cells("ItemName").Value
                                    Dim dataRow As DataRow = ItemRequestDT.NewRow
                                    dataRow("ItemID") = row.Cells("ItemID").Value
                                    dataRow("ItemName") = row.Cells("ItemName").Value
                                    dataRow("CateName") = row.Cells("CateName").Value
                                    dataRow("ItemUnitName") = row.Cells("ItemUnitName").Value
                                    dataRow("ContainerName") = row.Cells("ContainerName").Value
                                    dataRow("cInStock") = 0
                                    dataRow("Quantity") = row.Cells("TotalItemUsed").Value
                                    dataRow("Barcode") = row.Cells("Barcode").Value
                                    ItemRequestDT.Rows.Add(dataRow)
                                Next
                            End If
                            Me.DialogResult = Windows.Forms.DialogResult.OK

                        End If


                    Catch ex As Exception
                        'frmReqOrder.RefreshDataAfterAddItemReDetailClick(ItemRequestDT)
                        MessageBox.Show("Item : " & itemName & " already exist in request list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                    '=============================================Add by Itedm that don't have in used ========================
                Else
                    Try
                        With DGVItemInStock

                            '--- Validation user must be select item in the list
                            Dim isContainItems As Boolean = False
                            For Each rRow As DataGridViewRow In .Rows
                                Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells(0), DataGridViewCheckBoxCell)
                                If chk.Value = True Then
                                    isContainItems = True
                                End If
                            Next

                            If isContainItems = False Then
                                MessageBox.Show("Please select item in the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                If MessageBox.Show("Do you want add these item to list?", "add", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                                    For Each rRow As DataGridViewRow In .Rows
                                        Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells(0), DataGridViewCheckBoxCell)
                                        If chk.Value = True Then
                                            itemName = rRow.Cells("cItemName").Value
                                            Dim dataRow As DataRow = ItemRequestDT.NewRow
                                            dataRow("ItemID") = rRow.Cells("cItemNo").Value
                                            dataRow("ItemName") = rRow.Cells("cItemName").Value
                                            dataRow("CateName") = rRow.Cells("cCategory").Value
                                            dataRow("ItemUnitName") = rRow.Cells("cUnitItem").Value
                                            dataRow("ContainerName") = rRow.Cells("cContaining").Value
                                            dataRow("cInStock") = rRow.Cells("cInStock").Value
                                            dataRow("Quantity") = rRow.Cells("cRQuantity").Value
                                            dataRow("Barcode") = rRow.Cells("cBarcode").Value
                                            ItemRequestDT.Rows.Add(dataRow)
                                        End If
                                    Next
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                End If
                            End If


                        End With

                    Catch ex As Exception
                        'frmReqOrder.RefreshDataAfterAddItemReDetailClick(ItemRequestDT)
                        MessageBox.Show("Item : " & itemName & " already exist in request list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End Try
                End If



                ' ================================= request store item in cabinet ==========================================
            Else
                With DGVItemInStock
                    For Each rRow As DataGridViewRow In .Rows
                        Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells(0), DataGridViewCheckBoxCell)
                        If chk.Value = True Then
                            If cabinetRepo.isItemExistInLocationItemDetial(Val(myLocatinID), Val(rRow.Cells("cItemNo").Value)) = False Then
                                Dim myLocationItemDetail As New tblLocationItemDetail
                                myLocationItemDetail.LocationID = Val(myLocatinID)
                                myLocationItemDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                                cabinetRepo.AddLocationItemDetail(myLocationItemDetail)
                            End If
                        End If
                    Next
                End With
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Dim itemName As String = ""
            If ChItemUsed.Checked = True Then
                Try
                    Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
                    checkedRows = GridItemUsed.GetCheckedRows()

                    If checkedRows.Length = 0 Then
                        MessageBox.Show("Please select item in the list used.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Else
                        If MessageBox.Show("Do you want add these item to list?", "add", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                                itemName = row.Cells("ItemName").Value
                                Dim dataRow As DataRow = CaritasDataTable.NewRow
                                dataRow("ItemID") = row.Cells("ItemID").Value
                                dataRow("ItemName") = row.Cells("ItemName").Value
                                dataRow("RequestQuantity") = row.Cells("TotalItemUsed").Value
                                dataRow("Barcode") = row.Cells("Barcode").Value
                                CaritasDataTable.Rows.Add(dataRow)


                                'itemName = row.Cells("ItemName").Value
                                'Dim dataRow As DataRow = ItemRequestDT.NewRow
                                'dataRow("ItemID") = row.Cells("ItemID").Value
                                'dataRow("ItemName") = row.Cells("ItemName").Value
                                'dataRow("CateName") = row.Cells("CateName").Value
                                'dataRow("ItemUnitName") = row.Cells("ItemUnitName").Value
                                'dataRow("ContainerName") = row.Cells("ContainerName").Value
                                'dataRow("cInStock") = 0
                                'dataRow("Quantity") = row.Cells("TotalItemUsed").Value
                                'dataRow("Barcode") = row.Cells("Barcode").Value
                                'ItemRequestDT.Rows.Add(dataRow)
                            Next
                        End If
                        Me.DialogResult = Windows.Forms.DialogResult.OK

                    End If


                Catch ex As Exception
                    'frmReqOrder.RefreshDataAfterAddItemReDetailClick(ItemRequestDT)
                    MessageBox.Show("Item : " & itemName & " already exist in request list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                Try
                    With DGVItemInStock

                        '--- Validation user must be select item in the list
                        Dim isContainItems As Boolean = False
                        For Each rRow As DataGridViewRow In .Rows
                            Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells(0), DataGridViewCheckBoxCell)
                            If chk.Value = True Then
                                isContainItems = True
                            End If
                        Next

                        If isContainItems = False Then
                            MessageBox.Show("Please select item in the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If

                        For Each rRow As DataGridViewRow In .Rows
                            Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells(0), DataGridViewCheckBoxCell)
                            If chk.Value = True Then
                                itemName = rRow.Cells("cItemName").Value
                                Dim dataRow As DataRow = CaritasDataTable.NewRow
                                dataRow("ItemID") = rRow.Cells("cItemNo").Value
                                dataRow("ItemName") = rRow.Cells("cItemName").Value
                                dataRow("RequestQuantity") = rRow.Cells("cRQuantity").Value
                                dataRow("Barcode") = rRow.Cells("cBarcode").Value
                                CaritasDataTable.Rows.Add(dataRow)
                            End If
                        Next

                    End With
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Catch ex As Exception
                    MessageBox.Show("Item : " & itemName & " already exist in request list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End Try

            End If
            
        End If
    End Sub
    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        If isDisplayItemOutside = False Then

            If isDisplayItemInMainStock = True Then
                DGVItemInStock.DataSource = ItemForDepartDataAdapter.GetSearchItemInDepartByItemName(stockDepartID, TxtItemName.Text & "%")
            Else
                DGVItemInStock.DataSource = ItemListInDepart.SearchItemInDepartByItemName(stockDepartID, TxtItemName.Text & "%")
            End If
        Else
            DGVItemInStock.DataSource = ItemOutsideHospitalDataAdapter.GetItemDataOutsideFilterByItemName(TxtItemName.Text & "%")
        End If
    End Sub

    Private Sub DGVItemInStock_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVItemInStock.CellContentClick
        If isCheckStockRequest = True Then
            Exit Sub
        Else

            Dim DGCheckBox As DataGridViewCheckBoxCell = DGVItemInStock.CurrentRow.Cells(0)
            Try
                If DGVItemInStock.CurrentCellAddress.X = 0 Then
                    DGCheckBox = DGVItemInStock.CurrentRow.Cells(0)
                    If (DGVItemInStock.IsCurrentCellDirty) Then
                        DGVItemInStock.CommitEdit(DataGridViewDataErrorContexts.Commit)
                        Dim CInstock As Integer = DGVItemInStock.CurrentRow.Cells("cInStock").Value
                        If CInstock <= 0 Then
                            MessageBox.Show("You can not request Item. Because current stock department that you request out of stock." & vbCrLf & "PLEASE INFORM TO MAIN INVENTORY.", "Alert stock", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            DGCheckBox.Value = False
                            DGCheckBox.Selected = False
                            'DGVItemInStock.Refresh()
                        End If

                    End If
                End If
            Catch ex As Exception

            End Try
        End If

       
        
    End Sub

    Private Sub DGVItemInStock_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVItemInStock.CellMouseUp
        If e.ColumnIndex = 0 Then
            DGVItemInStock.EndEdit()
        End If
    End Sub

    Private Sub BtnViewItemUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewItemUsed.Click
        Dim TblTemItemUsed As DataTable = DA_ItemUsed.DialyUsedRequest(DateUsedFrom.Value.Date, DateUsedTo.Value.Date, DEPART_ID)
        GridItemUsed.DataSource = TblTemItemUsed
    End Sub
End Class