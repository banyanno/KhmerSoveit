Imports Janus.Windows.GridEX
Imports System.Data.Common

Public Class frmDepartInHouseUsedItem
    Dim ItemRepo As IItem = New Item
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim ItemListDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ImageStream As System.IO.MemoryStream

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ItemListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmInHouseUsedItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Initial item in department
        If DEPART_ID = MAIN_STOCK_DEPART_ID Then ' In case Mainstock
            With cbItem
                .DataSource = MainStockItemDataAdapter.GetData
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With

        Else ' In case department
            With cbItem
                .DataSource = ItemInDepartDataAdapter.GetItemDataByDepartID(CInt(DEPART_ID))
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .SelectedIndex = -1
            End With
        End If
        dptUsedDate.Value = ModGlobleVariable.GeteDateServer().Date
        dptUsedDate.Enabled = False
        'MsgBox(cbItem.SelectedValue)
        'cbItem.SelectedValue = 65

    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click

        If ValidateTextField(TxtItemBarcode, "", ErrorInHouseUsed) = False Then Exit Sub
        If ValidateTextField(TxtUsedQTY, "", ErrorInHouseUsed) = False Then Exit Sub

        If TxtUsedQTY.Text = "0" Then
            MessageBox.Show("Please input item used quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtUsedQTY.Text <> "" Then
            If Val(TxtUsedQTY.Text) > Val(TxtStockQty.Text) Then
                MessageBox.Show("Used item quanity cannnot greater than item quantity in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsedQTY.Focus()
                Exit Sub
            End If
        End If


        If MessageBox.Show("Do you want add this item into Used Item List?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim isItemExist As Boolean = False
            For Each rRow As Janus.Windows.GridEX.GridEXRow In gridUsedItemDetail.GetRows
                If rRow.Cells("Barcode").Value = TxtItemBarcode.Text Then
                    isItemExist = True
                    Exit For
                End If
            Next
            'Check Item exists in current used item list.
            If isItemExist = False Then
                Dim Obj(6) As Object
                With gridUsedItemDetail
                    Obj(0) = DEPART_NAME
                    Obj(1) = TxtItemBarcode.Text
                    Obj(2) = LblItemID.Text
                    Obj(3) = cbItem.Text
                    Obj(4) = TxtStockQty.Text
                    Obj(5) = TxtUsedQTY.Text
                    Obj(6) = GetDateServer()
                    .AddItem(Obj)
                End With
                cbItem.SelectedIndex = -1
                TxtUsedQTY.Text = "0"
            Else
                MessageBox.Show("Item already exist in current used item list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub TxtItemBarcode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemBarcode.Leave

        'In house main stock used item
        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
            If TxtItemBarcode.Text <> "" Then
                ' Check valid item barcode
                If ItemRepo.isValidItemBarcode(TxtItemBarcode.Text) Then
                    'In case Barcode of item exist in database
                    Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
                    LblItemID.Text = mytblItem.ItemID
                    cbItem.SelectedValue = mytblItem.ItemID
                    TxtStockQty.Text = ItemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

                    ' Get Picture of Item
                    Dim TblTemItem As DataTable = ItemListDataAdapter.GetDataByItemID(cbItem.SelectedValue)
                    For Each row As DataRow In TblTemItem.Rows
                        If TypeOf row("Picture") Is DBNull Then
                            PictItem.Visible = False
                        Else
                            ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                            PictItem.Visible = True
                            PictItem.Image = Image.FromStream(ImageStream)
                        End If
                    Next
                Else
                    MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtItemBarcode.Focus()
                End If
            End If
        Else ' In house department used item
            If TxtItemBarcode.Text <> "" Then
                If ItemRepo.isValidItemBarcode(TxtItemBarcode.Text) Then
                    Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
                    cbItem.SelectedValue = mytblItem.ItemID
                    LblItemID.Text = mytblItem.ItemID
                    ' Check item is exist in department stock 
                    If DepartStockRepo.isItemExistInDepartStock(CInt(DEPART_ID), Val(LblItemID.Text)) Then
                        TxtStockQty.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), Val(LblItemID.Text))
                        ' Get Picture of Item
                        Dim TblTemItem As DataTable = ItemListDataAdapter.GetDataByItemID(cbItem.SelectedValue)
                        For Each row As DataRow In TblTemItem.Rows
                            If TypeOf row("Picture") Is DBNull Then
                                PictItem.Visible = False
                            Else
                                ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                                PictItem.Visible = True
                                PictItem.Image = Image.FromStream(ImageStream)
                            End If
                        Next
                    Else
                        MessageBox.Show("Item does not exist in department", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TxtItemBarcode.Focus()
                    End If


                Else
                    MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtItemBarcode.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TxtUsedQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsedQTY.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUsedQTY_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsedQTY.Leave

        If TxtUsedQTY.Text <> "" Then
            If Val(TxtUsedQTY.Text) > Val(TxtStockQty.Text) Then
                MessageBox.Show("Used item quanity cannnot greater than item quantity in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsedQTY.Focus()
            End If
        End If

    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click
        If Not gridUsedItemDetail.CurrentRow Is Nothing AndAlso gridUsedItemDetail.CurrentRow.RowType = RowType.Record Then
            gridUsedItemDetail.SelectedItems(0).GetRow.Delete()
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Clear item information
        TxtItemBarcode.Text = ""
        TxtStockQty.Text = "0"
        TxtUsedQTY.Text = ""
        rtbComment.Text = ""
    End Sub

    Private Sub gridUsedItemDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridUsedItemDetail.SelectionChanged
        If Not gridUsedItemDetail.CurrentRow Is Nothing AndAlso gridUsedItemDetail.CurrentRow.RowType = RowType.Record Then
            TxtItemBarcode.Text = gridUsedItemDetail.SelectedItems(0).GetRow.Cells("Barcode").Value
            cbItem.SelectedValue = gridUsedItemDetail.SelectedItems(0).GetRow.Cells("ItemID").Value
            TxtStockQty.Text = gridUsedItemDetail.SelectedItems(0).GetRow.Cells("UnitsInStock").Value
            TxtUsedQTY.Text = gridUsedItemDetail.SelectedItems(0).GetRow.Cells("UsedQuantity").Value
            TxtUsedQTY.Focus()
        End If
    End Sub

    Private Sub BtnModifyItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModifyItem.Click
        If Not gridUsedItemDetail.CurrentRow Is Nothing AndAlso gridUsedItemDetail.CurrentRow.RowType = RowType.Record Then
            If TxtUsedQTY.Text <> "" Then
                gridUsedItemDetail.SelectedItems(0).GetRow.BeginEdit()
                gridUsedItemDetail.SelectedItems(0).GetRow.Cells("UsedQuantity").Value = TxtUsedQTY.Text
                gridUsedItemDetail.Refresh()
            End If
        End If
    End Sub

    Private Sub BtnSaveNewUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveNewUsed.Click

        If TxtUsedQTY.Text <> "" Then
            If Val(TxtUsedQTY.Text) > Val(TxtStockQty.Text) Then
                MessageBox.Show("Used item quanity cannnot greater than item quantity in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsedQTY.Focus()
                Exit Sub
            End If
        End If

        If gridUsedItemDetail.GetRows.Count = 0 Then
            MessageBox.Show("There is no item in table used item list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If rtbComment.Text = "" Then
            MessageBox.Show("Please specify comment for using item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rtbComment.Select()
            rtbComment.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Do you want save used items ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        System.Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '=========== tblUsed ==============
                Dim mytblUsed As New tblUsed
                mytblUsed.UsedDepartID = CInt(DEPART_ID)
                mytblUsed.UsedDescription = rtbComment.Text
                mytblUsed.UsedUserID = CInt(USER_ID)
                mytblUsed.UsedDate = dptUsedDate.Value.Date

                THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                THIDataContext.getTHIDataContext.SubmitChanges()
                '============ tblUsedDetail ============
                For Each rRow As Janus.Windows.GridEX.GridEXRow In gridUsedItemDetail.GetRows
                    Dim mytblUsedDetail As New tblUsedDetail
                    mytblUsedDetail.UsedID = mytblUsed.UsedID
                    mytblUsedDetail.ItemID = Val(rRow.Cells("ItemID").Value)
                    mytblUsedDetail.UsedQuantity = Val(rRow.Cells("UsedQuantity").Value)

                    THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '=========== Process cut stock ===========
                    If CInt(DEPART_ID) <> MAIN_STOCK_DEPART_ID Then

                        Dim myDepartStock As New tblDeptStock
                        ' move to particular record to cut balance in department stock
                        Dim qdepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = Val(rRow.Cells("ItemID").Value)
                        myDepartStock = qdepartStock.SingleOrDefault

                        '========================= Management Begin item quantity before perform transaction =========================
                        Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = dptUsedDate.Value.Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = Val(rRow.Cells("ItemID").Value) Select BBT.BeginBalanceTraceID).Count
                        If q = 0 Then
                            '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = dptUsedDate.Value.Date
                            mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                            mytblBeginBalanceTrace.BeginBalanceOfDay = myDepartStock.UnitsInStock
                            mytblBeginBalanceTrace.ItemID = Val(rRow.Cells("ItemID").Value)

                            THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        End If

                        '--- Update balance in department stock
                        myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - Val(rRow.Cells("UsedQuantity").Value)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    Else

                        Dim myMainStock As New tblCentralInventory
                        ' move to particular record to cut balance in main stock 
                        Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = Val(rRow.Cells("ItemID").Value)
                        myMainStock = q.SingleOrDefault


                        '========================= Management Begin item quantity before perform transaction =========================
                        Dim qBBT = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = dptUsedDate.Value.Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = Val(rRow.Cells("ItemID").Value) Select BBT.BeginBalanceTraceID).Count
                        If qBBT = 0 Then
                            '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = dptUsedDate.Value.Date
                            mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                            mytblBeginBalanceTrace.BeginBalanceOfDay = myMainStock.UnitsInStock
                            mytblBeginBalanceTrace.ItemID = Val(rRow.Cells("ItemID").Value)

                            THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        End If

                        '========================= Update UnitsInStock of CentralInventory ===============
                        myMainStock.UnitsInStock = myMainStock.UnitsInStock - Val(rRow.Cells("UsedQuantity").Value)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    End If
                Next

                '*** Finished
                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()


                'process run end of day.

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MsgBox("Error : " & ex.Message)
            Finally

                'MessageBox.Show("Used items save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'DEP_EOD.BtnEndofDay_Click(sender, e) ' BtnEndofDay_Click
                Me.DialogResult = Windows.Forms.DialogResult.OK
                trans = Nothing
            End Try
        End If

       

    End Sub

    Private Sub cbItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItem.SelectedValueChanged
        Try
            Dim myselectedItem As tblItem = ItemRepo.GetItemByID(CInt(cbItem.SelectedValue.ToString))
            TxtItemBarcode.Text = myselectedItem.Barcode

            'In house main stock used item
            If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then

                'In case Barcode of item exist in database
                Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
                LblItemID.Text = mytblItem.ItemID
                TxtStockQty.Text = ItemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

                ' Get Picture of Item
                Dim TblTemItem As DataTable = ItemListDataAdapter.GetDataByItemID(cbItem.SelectedValue)
                For Each row As DataRow In TblTemItem.Rows
                    If TypeOf row("Picture") Is DBNull Then
                        PictItem.Visible = False
                    Else
                        ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                        PictItem.Visible = True
                        PictItem.Image = Image.FromStream(ImageStream)
                    End If
                Next

            Else ' In house department used item
                Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
                LblItemID.Text = mytblItem.ItemID
                TxtStockQty.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), Val(LblItemID.Text))

                ' Get Picture of Item
                Dim TblTemItem As DataTable = ItemListDataAdapter.GetDataByItemID(cbItem.SelectedValue)
                For Each row As DataRow In TblTemItem.Rows
                    If TypeOf row("Picture") Is DBNull Then
                        PictItem.Visible = False
                    Else
                        ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                        PictItem.Visible = True
                        PictItem.Image = Image.FromStream(ImageStream)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try

    End Sub


End Class