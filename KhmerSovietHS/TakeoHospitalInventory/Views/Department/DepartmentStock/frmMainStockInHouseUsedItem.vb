Imports Janus.Windows.GridEX
Imports System.Data.Common

Public Class frmMainStockInHouseUsedItem

    Dim ItemRepo As IItem = New Item
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Dim MainStockItemDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ItemInDepartDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim ItemListDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ImageStream As System.IO.MemoryStream
    Dim ItemProviderDataAdapter As DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MainStockItemDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemInDepartDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ItemListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ItemProviderDataAdapter = New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMainStockInHouseUsedItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            With cbItem
                .DataSource = MainStockItemDataAdapter.GetData
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .SelectedIndex = -1
            End With

            '--- First load clear form
            TxtItemBarcode.Text = ""
            LblItemID.Text = ""
            TxtStockQty.Text = "0"
            InitialItemProvider()
            dptUsedDate.Value = ModGlobleVariable.GeteDateServer.Date

        Catch ex As Exception

        End Try

    End Sub

    Sub InitialItemProvider()

        CbDonation.DataSource = Nothing
        CbVendor.DataSource = Nothing

        With CbDonation
            .DataSource = ItemProviderDataAdapter.GetItemDonorByItemID(CInt(LblItemID.Text))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ItemProviderDataAdapter.GetItemVendorByItemID(CInt(LblItemID.Text))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        CbDonation.Enabled = False
        CbVendor.Enabled = False

    End Sub

    Private Sub TxtItemBarcode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemBarcode.Leave

        If TxtItemBarcode.Text <> "" Then

            '--- Check valid item barcode
            If ItemRepo.isValidItemBarcode(TxtItemBarcode.Text) Then
                '--- In case Barcode of item exist in database
                Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
                LblItemID.Text = mytblItem.ItemID
                cbItem.SelectedValue = mytblItem.ItemID
                TxtStockQty.Text = ItemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

                InitialItemProvider()
                gridProviderDetail.Rows.Clear()
                TxtUsedQTY.Text = "0"

                '--- Get Picture of Item
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

    Private Sub cbItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItem.SelectedValueChanged


        Try
            Dim myselectedItem As tblItem = ItemRepo.GetItemByID(CInt(cbItem.SelectedValue.ToString))
            TxtItemBarcode.Text = myselectedItem.Barcode

            '--- In case Barcode of item exist in database
            Dim mytblItem As tblItem = ItemRepo.GetItemByBarcode(TxtItemBarcode.Text)
            LblItemID.Text = mytblItem.ItemID
            TxtStockQty.Text = ItemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

            InitialItemProvider()
            gridProviderDetail.Rows.Clear()
            TxtUsedQTY.Text = "0"

            '--- Get Picture of Item
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


        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateTextField(TxtGivenQty, "", ErrorInHouseUsed) = False Then Exit Sub
        If RbDonator.Checked = False And RbVendor.Checked = False Then
            MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '--- Validate sometimes user select combo box and press button delete before attempt to add
        If RbDonator.Checked = True Then
            If ValidateCombobox(CbDonation, "", ErrorInHouseUsed) = False Then Exit Sub
        End If

        If RbVendor.Checked = True Then
            If ValidateCombobox(CbVendor, "", ErrorInHouseUsed) = False Then Exit Sub
        End If


        Dim obj(2) As Object
        Dim ProviderName As String = ""
        Dim ProviderID As Integer = 0

        If RbDonator.Checked = True Then
            ProviderName = CbDonation.Text
            ProviderID = CbDonation.SelectedValue
        End If

        If RbVendor.Checked = True Then
            ProviderName = CbVendor.Text
            ProviderID = CbVendor.SelectedValue
        End If

        With gridProviderDetail
            obj(0) = ProviderName
            obj(1) = TxtGivenQty.Text
            obj(2) = ProviderID

            If gridProviderDetail.Rows.Count = 0 Then
                gridProviderDetail.Rows.Add(obj)
                TxtUsedQTY.Text = Val(TxtUsedQTY.Text) + Val(TxtGivenQty.Text)
            Else
                If IsDupValidateProvider(obj, ProviderID) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    TxtUsedQTY.Text = Val(TxtUsedQTY.Text) + Val(TxtGivenQty.Text)
                Else
                    MessageBox.Show("Item's provider already Exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With

    End Sub

    Function IsDupValidateProvider(ByVal pObj() As Object, ByVal pProviderID As Integer) As Boolean

        Dim IsExist As Boolean = False
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .Rows
                If rRow.Cells("ProviderID").Value = pProviderID Then
                    IsExist = True
                    Exit For
                End If
            Next
        End With

        Return IsExist

    End Function

    Private Sub TxtGivenQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGivenQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected provider ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    TxtUsedQTY.Text = Val(TxtUsedQTY.Text) - Val(rRow.Cells("GivenQty").Value)
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub RbVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbVendor.CheckedChanged
        If RbVendor.Checked = True Then
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        Else
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        End If
    End Sub

    Private Sub RbDonator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDonator.CheckedChanged
        If RbDonator.Checked = True Then
            CbVendor.Enabled = False
            CbDonation.Enabled = True
        Else
            CbVendor.Enabled = True
            CbDonation.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ValidateTextField(TxtItemBarcode, "", ErrorInHouseUsed) = False Then Exit Sub

        If TxtUsedQTY.Text <> "" Then

            If Val(TxtUsedQTY.Text) = 0 Then
                MessageBox.Show("Item use quantity must be greater that zero.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsedQTY.Focus()
                Exit Sub
            End If

            If Val(TxtUsedQTY.Text) > Val(TxtStockQty.Text) Then
                MessageBox.Show("Used item quanity cannnot greater than item quantity in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtUsedQTY.Focus()
                Exit Sub
            End If
        End If



        If rtbComment.Text = "" Then
            MessageBox.Show("Please specify comment for using item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Do you want save used items ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        System.Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- ITEM_PROVIDER_TRANS update
                With gridProviderDetail

                    For Each rRow As DataGridViewRow In .Rows
                        '--- Save ITEM_PROVIDER_TRANS
                        Dim ItemProTrans As New ITEM_PROVIDER_TRAN
                        ItemProTrans.ItemID = Val(LblItemID.Text)
                        ItemProTrans.RequestID = 0
                        ItemProTrans.ProviderID = Val(rRow.Cells("ProviderID").Value)
                        ItemProTrans.TransDate = dptUsedDate.Value.Date
                        ItemProTrans.DepartUseID = Val(DEPART_ID)
                        ItemProTrans.Quantity = Val(rRow.Cells("GivenQty").Value)
                        ItemProTrans.Status = 1 '--- Complete transaction

                        THIDataContext.getTHIDataContext.ITEM_PROVIDER_TRANs.InsertOnSubmit(ItemProTrans)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    Next
                End With

                '=========== tblUsed ==============
                Dim mytblUsed As New tblUsed
                mytblUsed.UsedDepartID = CInt(DEPART_ID)
                mytblUsed.UsedDescription = rtbComment.Text
                mytblUsed.UsedUserID = CInt(USER_ID)
                mytblUsed.UsedDate = dptUsedDate.Value.Date

                THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '============ tblUsedDetail ============
                Dim mytblUsedDetail As New tblUsedDetail
                mytblUsedDetail.UsedID = mytblUsed.UsedID
                mytblUsedDetail.ItemID = Val(LblItemID.Text)
                mytblUsedDetail.UsedQuantity = Val(TxtUsedQTY.Text)

                THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                THIDataContext.getTHIDataContext.SubmitChanges()

                Dim myMainStock As New tblCentralInventory
                '--- Query to particular record to cut balance in main stock 
                Dim q = From centralStock In THIDataContext.getTHIDataContext.tblCentralInventories Where centralStock.ItemID = Val(LblItemID.Text)
                myMainStock = q.SingleOrDefault

                '========================= Management Begin item quantity before perform transaction =========================
                Dim qBBT = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = dptUsedDate.Value.Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = Val(LblItemID.Text) Select BBT.BeginBalanceTraceID).Count
                If qBBT = 0 Then
                    '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                    Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                    mytblBeginBalanceTrace.Date = dptUsedDate.Value.Date
                    mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                    mytblBeginBalanceTrace.BeginBalanceOfDay = myMainStock.UnitsInStock
                    mytblBeginBalanceTrace.ItemID = Val(LblItemID.Text)

                    THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                End If

                '========================= Update UnitsInStock of CentralInventory ===============
                myMainStock.UnitsInStock = myMainStock.UnitsInStock - Val(TxtUsedQTY.Text)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Finished
              



                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MsgBox("Error : " & ex.Message)
            Finally
                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()
                trans = Nothing
                MessageBox.Show("Used items save successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DEP_EOD.BtnEndofDay_Click(sender, e)
            End Try

            

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    
End Class