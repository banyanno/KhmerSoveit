Imports System.Windows.Forms.CheckedListBox
Imports System.Data.Common
Imports System.IO
Imports Janus.Windows.GridEX


Public Class frmItem

    Dim itemUnitRepo As IItemUnitRepository = New ItemUnitRepository
    Dim labourFacRepo As ILabourFactoryRepository = New LabourFactoryRepository
    Dim containerRepo As IContainerRepository = New ContainerRepository
    Dim chemicalRepo As IChemicalRepository = New ChemicalRepository
    Dim cateRepo As ICategoryRepository = New CategoryRepository
    Dim vendorRepo As IVendorRepository = New VendorRepository
    Dim itemRepo As IItem = New Item
    Dim inventoryRepo As IInventory = New Inventory
    Dim itemChemicalDetailRepo As IItemChemicalDetail = New ItemChemicalDetail
    Private THIDataContext As New BaseDataContext
    Dim UCategory As UCCategories
    Public cateID As Integer
    Dim CateDataAdapter As DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
    Dim UnitItemDataAdapter As DSItemUnitTableAdapters.tblItemUnitTableAdapter
    Dim LabourDataAdapter As DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
    Dim ContainerDataAdapter As DSContainerTableAdapters.tblContainerTableAdapter
    Dim ChemicalDataAdapter As DSChemicalTableAdapters.tblChemicalTableAdapter
    Dim VendorDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim ItemListDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim VItemChemicalDetailDataAdapter As DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter
    Dim DepartmentStockDataAdapter As DSDepartmentStockTableAdapters.VItemListDepartPermissionTableAdapter
    Dim CurrDataAdapter As DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
    Dim VItemExpiredDateListDataAdapter As DSCategoriesAndItemsTableAdapters.VItemExpiredDateListTableAdapter
    Dim CountryDataAdapter As DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter

    Public myItemID As Integer
    Public myBarcode As String
    Public myCateID As Integer
    Dim ImageStream As System.IO.MemoryStream

    '--- Received new item from Caritas
    Public pItemName As String
    Public IsHopRecItem As Boolean
    Public Barcode As String
    Public pItemID As Integer
    Public ReqDetailIDItemNotExistInHos As Double
    Dim DA_ItemPrice As New DSItemPriceTableAdapters.tblItemPriceTableAdapter

    Public Sub New(ByVal mainItem As UCCategories)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ItemListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VItemChemicalDetailDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter
        DepartmentStockDataAdapter = New DSDepartmentStockTableAdapters.VItemListDepartPermissionTableAdapter
        CountryDataAdapter = New DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter
        UCategory = mainItem
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ItemListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        VItemChemicalDetailDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemChemicalDetailTableAdapter
        DepartmentStockDataAdapter = New DSDepartmentStockTableAdapters.VItemListDepartPermissionTableAdapter
        CountryDataAdapter = New DSCategoriesAndItemsTableAdapters.COUNTRYTableAdapter
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmItem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        txtBarCode.Focus()
    End Sub

    Private Sub frmItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtBarCode.Select()
        txtBarCode.Focus()

        If lblSaveOption.Text = "0" Then

            myRefresh()
            InitPriviledgeTab()
            txtExpireAlert.Text = "0"
            txtStockAlertQty.Text = "0"
            txtQuantity.Text = "0"
            txtUnitOnOrder.Text = "0"
            '--- Hospital received item
            If IsHopRecItem = True Then
                dtpDateExpired.Enabled = False
                txtItemName.Text = pItemName
                txtItemName.ReadOnly = True
            End If

        Else 'Edit item
            txtBarCode.ReadOnly = True
            myRefresh()
            InitPriviledgeTab()
            Dim TblTemItem As DataTable = ItemListDataAdapter.GetDataByItemID(myItemID)
            For Each row As DataRow In TblTemItem.Rows

                labelItemID.Text = row("ItemID")
                lbItemID.Text = row("ItemID")
                txtItemName.Text = row("ItemName")
                txtEDItemName.Text = row("ItemName")
                txtBarCode.Text = row("Barcode")

                If TypeOf row("Picture") Is DBNull = False Then
                    ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                    PicItem.Image = System.Drawing.Image.FromStream(ImageStream)
                End If

                '---- Get Item chemical detail ----
                If row("IsMedicine") = True Then
                    ckbMedicine.Checked = True

                    Dim TblTemItemChemicalDetail As DataTable = VItemChemicalDetailDataAdapter.GetItemChemicalDataByItemID(myItemID)
                    Dim obj(3) As Object
                    For Each cheRow As DataRow In TblTemItemChemicalDetail.Rows
                        With gridChemical
                            obj(0) = cheRow("ChemicalName")
                            obj(1) = cheRow("ContainerName")
                            obj(2) = cheRow("ChemicalID")
                            obj(3) = cheRow("ContainerID")
                            .Rows.Add(obj)
                        End With
                    Next
                End If

                If TypeOf row("ContainerID") Is DBNull = False Then
                    cbItemContainer.SelectedValue = row("ContainerID")
                End If

                If TypeOf row("LabourFacID") Is DBNull = False Then
                    cbLabourFac.SelectedValue = row("LabourFacID")
                End If

                If TypeOf row("CateID") Is DBNull = False Then
                    cbCate.SelectedValue = row("CateID")
                End If

                If TypeOf row("CountryID") Is DBNull = False Then
                    cbCountry.SelectedValue = row("CountryID")
                End If

                If TypeOf row("ItemUnitID") Is DBNull = False Then
                    cbItemUnit.SelectedValue = row("ItemUnitID")
                End If

                If TypeOf row("StockAlertQty") Is DBNull = False Then
                    txtStockAlertQty.Text = row("StockAlertQty")
                End If

                If TypeOf row("ExpiredAlert") Is DBNull = False Then
                    txtExpireAlert.Text = row("ExpiredAlert")
                End If

                If TypeOf row("ItemDescription") Is DBNull = False Then
                    txtDescription.Text = row("ItemDescription")
                End If

                If TypeOf row("UnitPrice") Is DBNull = False Then
                    TxtCost.Text = row("UnitPrice")
                End If

                If TypeOf row("DateExpired") Is DBNull = False Then
                    dtpDateExpired.Checked = True
                    dtpDateExpired.Value = row("DateExpired")
                End If

            Next
            DisplayItemPermissionForDepartment()
        End If
    End Sub

    Sub DisplayItemPermissionForDepartment()

        '---  Loading edit permission display for department  ---
        Dim myDataTable As New DataTable
        Dim objDept(2) As Object
        myDataTable = DepartDataAdapter.GetDataByListDepartment(MAIN_STOCK_DEPART_ID)
        With gridDepartPriviledge
            .Rows.Clear()
            For Each aRow As DataRow In myDataTable.Rows
                objDept(0) = aRow("DepartID")
                objDept(1) = aRow("DepartName")
                objDept(2) = False
                .Rows.Add(objDept)
            Next
        End With


        Dim TBLTemPermissionItemForDepart As DataTable = DepartmentStockDataAdapter.GetItemPrivilege(myItemID, MAIN_STOCK_DEPART_ID)
        Dim objPer(2) As Object
        With gridDepartPriviledge
            '.Rows.Clear()
            For Each pRow As DataRow In TBLTemPermissionItemForDepart.Rows
                For Each rRow As DataGridViewRow In .Rows
                    If rRow.Cells("cDepartmentID").Value = pRow("DepartID") Then
                        If pRow("IsShow") = True Then
                            rRow.Cells("cIsShow").Value = True
                        End If
                    End If
                Next
            Next
        End With

    End Sub

    Private Sub InitPriviledgeTab()
        '--- Init Permission item for department        
        Dim myDataTable As New DataTable
        Dim obj(2) As Object
        myDataTable = DepartDataAdapter.GetDataByListDepartment(MAIN_STOCK_DEPART_ID)
        'GridPermistion.DataSource = myDataTable
        With gridDepartPriviledge
            .Rows.Clear()
            For Each aRow As DataRow In myDataTable.Rows
                obj(0) = aRow("DepartID")
                obj(1) = aRow("DepartName")
                obj(2) = True
                .Rows.Add(obj)
            Next
        End With
    End Sub

    Private Sub myRefresh()

        CateDataAdapter = New DSCategoriesAndItemsTableAdapters.tblCategoryTableAdapter
        UnitItemDataAdapter = New DSItemUnitTableAdapters.tblItemUnitTableAdapter
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        ChemicalDataAdapter = New DSChemicalTableAdapters.tblChemicalTableAdapter
        VendorDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        CurrDataAdapter = New DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
        VItemExpiredDateListDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemExpiredDateListTableAdapter

        With cbItemUnit
            .DataSource = UnitItemDataAdapter.GetData
            .ValueMember = "ItemUnitID"
            .DisplayMember = "ItemUnitName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbLabourFac
            .DataSource = LabourDataAdapter.GetData
            .ValueMember = "LabourFacID"
            .DisplayMember = "LabourFacName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbContainer
            .DataSource = ContainerDataAdapter.GetData
            .ValueMember = "ContainerID"
            .DisplayMember = "ContainerName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbItemContainer
            .DataSource = ContainerDataAdapter.GetData
            .ValueMember = "ContainerID"
            .DisplayMember = "ContainerName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbChemical
            .DataSource = ChemicalDataAdapter.GetData
            .ValueMember = "ChemicalID"
            .DisplayMember = "ChemicalName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With cbCate
            .DataSource = CateDataAdapter.GetData
            .ValueMember = "CateID"
            .DisplayMember = "CateName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

        With cbCountry
            .DataSource = CountryDataAdapter.GetData
            .ValueMember = "CountryID"
            .DisplayMember = "Country"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems            
        End With

        If lblSaveOption.Text = "0" Then

            'Select specific category to add item
            cbCate.SelectedValue = cateID

            'initialse item ID
            labelItemID.Text = itemRepo.GetMaxItemID() + 1
            lbItemID.Text = labelItemID.Text

            'initialse Medicine block
            gbMedicine.Enabled = False

        End If


    End Sub

    Function GetByImage(ByVal FilePath As String, ByVal pic As PictureBox) As Byte()

        ' PREPARE DATA TO BE PASSED TO DATABASE:
        ' You only need to save the filename, not the entire path. Therefore, 
        ' Split the path, creating an array of strings. Make sure you pass in 
        ' the delimiter. Then reverse the array so that you can assign the 
        ' first string in the array to the SQL parameter.
        Dim arrFilename() As String = Split(FilePath, "\")
        Array.Reverse(arrFilename)
        ' The SQL Server Image datatype is a binary datatype. Therefore, to save 
        ' it to the database you must convert the image to an array of bytes. You
        ' could use a FileStream object to open the image file and then read it to 
        ' the stream, but a MemoryStream with the Image.Save method is a bit easier.

        Dim ms As New MemoryStream
        Dim bm As New Bitmap(pic.Image)
        Dim width As Integer = 158 'image width. 
        Dim height As Integer = 169 'image height
        Dim thumb As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(thumb)
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, _
bm.Height), GraphicsUnit.Pixel)
        'pic.Image.Save(ms, pic.Image.RawFormat)
        'thumb.Save("C:\newimage.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        thumb.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = ms.GetBuffer

        ' Close the stream object to release the resource.
        ms.Dispose()
        bm.Dispose()
        thumb.Dispose()
        Return arrImage
    End Function

    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    With OpenFileImage
    '        .InitialDirectory = "C:\"
    '        .Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*bmp"
    '        .FilterIndex = 4
    '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            With PicItem
    '                .Image = Image.FromFile(OpenFileImage.FileName)
    '                .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    '            End With
    '            lblPicFilePath.Text = OpenFileImage.FileName
    '        End If
    '    End With
    'End Sub



    'Private Sub btnClearPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not (PicItem.Image Is Nothing) Then
    '        PicItem.Image.Dispose()
    '        PicItem.Image = Nothing
    '    End If
    'End Sub

    Private Sub ckbMedicine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbMedicine.CheckedChanged
        If ckbMedicine.Checked = True Then
            gbMedicine.Enabled = True
            dtpDateExpired.Checked = True
        Else
            gbMedicine.Enabled = False
            dtpDateExpired.Checked = False
        End If
    End Sub

    Private Sub btnAddChemical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChemical.Click
        Dim isDuplicate As Boolean = False
        Dim obj(3) As Object
        With gridChemical
            If .Rows.Count = 0 Then
                obj(0) = cbChemical.Text
                obj(1) = cbContainer.Text
                obj(2) = cbChemical.SelectedValue
                obj(3) = cbContainer.SelectedValue
                .Rows.Add(obj)
            Else
                For Each aRow As DataGridViewRow In .Rows
                    If aRow.Cells("cChemical").Value = cbChemical.Text Then
                        isDuplicate = True
                        Exit For
                    End If
                Next
                If isDuplicate = False Then
                    obj(0) = cbChemical.Text
                    obj(1) = cbContainer.Text
                    obj(2) = cbChemical.SelectedValue
                    obj(3) = cbContainer.SelectedValue
                    .Rows.Add(obj)
                Else
                    MsgBox("Chemical already exist.")
                End If
            End If
        End With


    End Sub

    Private Sub btnDeleteChemical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteChemical.Click
        With gridChemical
            For Each rRow As DataGridViewRow In .SelectedRows
                .Rows.Remove(rRow)
            Next
        End With
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim item As New tblItem
        Dim inventory As New tblCentralInventory
        Dim category As New tblCategory
        Dim itemTransMsgStatus As String
        Dim myVendorSupply As New tblVendorItemSupplyStatus
        Dim myDonatorSupply As New tblVendorItemSupplyStatus

        ' Validation
        If ValidateTextField(txtItemName, "Item name", ErrorItem) = False _
        Or ValidateTextField(txtBarCode, "Barcode", ErrorItem) = False Then
            Exit Sub
        End If

        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                'Check validate item already exist by Barcode
                If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
                    MessageBox.Show("Item already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Try
                    'item.ItemRegisterDate  
                    item.ItemName = txtItemName.Text
                    item.ItemCode = txtItemName.Text & cbItemUnit.SelectedValue & cbContainer.SelectedValue
                    item.Barcode = txtBarCode.Text
                    ' Save Bind image
                    If lblPicFilePath.Text <> "" Then
                        item.Picture = GetByImage(lblPicFilePath.Text, PicItem)
                    End If

                    ' (Medicine block)  
                    If ckbMedicine.Checked = True Then
                        'Add tblItemChemicalDetail
                        With gridChemical
                            For Each rRow As DataGridViewRow In .Rows
                                Dim chemical As New tblItemChemicalDetail
                                chemical.ItemID = labelItemID.Text
                                chemical.ChemicalID = rRow.Cells("cChemicalID").Value
                                chemical.ContainerID = rRow.Cells("cContainerID").Value
                                THIDataContext.getTHIDataContext.tblItemChemicalDetails.InsertOnSubmit(chemical)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Next
                        End With
                        item.ContainerID = cbItemContainer.SelectedValue
                        item.LabourFacID = cbLabourFac.SelectedValue
                        item.IsMedicine = ckbMedicine.Checked ' dedicate that item is medicine or normal Product
                    Else
                        item.IsMedicine = ckbMedicine.Checked

                    End If
                    ' === End block Medicine

                    ' (Package Info block)
                    item.CateID = cbCate.SelectedValue
                    item.ItemUnitID = cbItemUnit.SelectedValue 'UoM                    
                    item.CountryID = cbCountry.SelectedValue

                    ' ==== Resgist item in Inventory
                    inventory.ItemID = labelItemID.Text
                    inventory.UnitsInStock = 0
                    If txtStockAlertQty.Text <> "" Then inventory.StockAlertQty = txtStockAlertQty.Text
                    If txtExpireAlert.Text <> "" Then inventory.ExpiredAlert = txtExpireAlert.Text

                    ' Save inventory
                    THIDataContext.getTHIDataContext.tblCentralInventories.InsertOnSubmit(inventory)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    ' === End block Package Info

                    item.ItemDescription = txtDescription.Text
                    If Trim(TxtCost.Text) = "" Then
                        item.UnitPrice = 0
                    Else
                        item.UnitPrice = Val(TxtCost.Text)
                    End If
                    ' === End block Source Info

                    ' Save item
                    THIDataContext.getTHIDataContext.tblItems.InsertOnSubmit(item)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    ' === End Add item


                    '*** Manage Priviledge for department
                    With gridDepartPriviledge
                        For Each rRow As DataGridViewRow In .Rows
                            Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells("cIsShow"), DataGridViewCheckBoxCell)
                            Dim myDepartPriviledge As New tblPermissionItemShoworHideForDepart
                            If chk.Value = True Then
                                myDepartPriviledge.ItemID = labelItemID.Text
                                myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                myDepartPriviledge.IsShow = True
                            Else
                                myDepartPriviledge.ItemID = labelItemID.Text
                                myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                myDepartPriviledge.IsShow = False
                            End If
                            THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        Next
                    End With
                    '===
                    '== Manage Save Expire Date for item
                    Dim myGRow As Janus.Windows.GridEX.GridEXRow
                    For Each myGRow In gridExpiredDate.GetDataRows
                        Dim myItemExpireDate As New tblItemExpireControl
                        myItemExpireDate.ItemID = labelItemID.Text
                        myItemExpireDate.ItemExpireDate = myGRow.Cells("ItemExpireDate").Value()
                        myItemExpireDate.Quantity = CInt(myGRow.Cells("Quantity").Value())

                        THIDataContext.getTHIDataContext.tblItemExpireControls.InsertOnSubmit(myItemExpireDate)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                    '== End manage save expire date for item

                    ' === Update ItemCount in Category table
                    category = cateRepo.GetCateByID(cbCate.SelectedValue)
                    category.ItemCount = category.ItemCount + 1
                    cateRepo.UpdateCate()
                    ' === End Update ItemCount in Category table

                    trans.Commit()
                    itemTransMsgStatus = "True"
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()
                    itemTransMsgStatus = ex.Message
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing
                End Try

                If itemTransMsgStatus = "True" Then
                    MsgBox("New item register successfully.")                    
                Else
                    MsgBox("Error update item.", MsgBoxStyle.Critical, "Error : " & itemTransMsgStatus)
                End If
            End If
        Else ' Update item to database
        End If
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtUnitPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, System.Windows.Forms.TextBox).Text.Contains(Chr(46)) Then
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

    Private Sub txtUnitInStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, System.Windows.Forms.TextBox).Text.Contains(Chr(46)) Then
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

    Private Sub txtStockAlertQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockAlertQty.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, System.Windows.Forms.TextBox).Text.Contains(Chr(46)) Then
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

    Private Sub txtExpireAlert_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtExpireAlert.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, System.Windows.Forms.TextBox).Text.Contains(Chr(46)) Then
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

    Private Sub txtEDItemName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEDItemName.Leave
        txtEDItemName.Text = txtItemName.Text
    End Sub

    Private Sub txtItemName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemName.Leave
        txtEDItemName.Text = txtItemName.Text
    End Sub

    Private Sub btnAddExpireDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddExpireDate.Click

        If txtEDItemName.Text = "" Then
            MessageBox.Show("Please input Commercial Name in tab item , So this value retrive automatically", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtTmpQtyInStock.Text = "" Then
            MessageBox.Show("Please input Unit In Stock in tab item before register item expired date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtQuantity.Text = "" Or txtQuantity.Text = "0" Then
            MessageBox.Show("Please input item quantity for particular date attempt to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If CInt(txtQuantity.Text) = CInt(txtTmpQtyAlreadyAsignExDate.Text) Then
            MessageBox.Show("You already asinged expire date for all items.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If CInt(txtQuantity.Text) > (CInt(txtTmpQtyInStock.Text) - CInt(txtTmpQtyAlreadyAsignExDate.Text)) Then
            MessageBox.Show("You cannot input quantity more than " & (CInt(txtTmpQtyInStock.Text) - CInt(txtTmpQtyAlreadyAsignExDate.Text)) & ".", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtQuantity.Focus()
            Exit Sub
        End If

        ' Add items expired date detail.
        Dim obj(4) As Object
        With gridExpiredDate
            obj(0) = lbItemID.Text
            obj(1) = txtEDItemName.Text
            obj(2) = dtpExDate.Value.Date
            obj(3) = txtQuantity.Text
            obj(4) = ""
            .AddItem(obj)
        End With

        ' End add items expired date detail
        UpdatetxtTmpQtyAlreadyAsignExDate()
    End Sub

    Private Sub btnDeleteExDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteExDate.Click
        If Not gridExpiredDate.CurrentRow Is Nothing AndAlso gridExpiredDate.CurrentRow.RowType = RowType.Record Then
            gridExpiredDate.GetRow.Delete()
            UpdatetxtTmpQtyAlreadyAsignExDate()
        End If
    End Sub

    Private Sub UpdatetxtTmpQtyAlreadyAsignExDate()
        ' Update data in textBox txtTmpQtyAlreadyAsignExDate
        Dim QtyItemAlreadyAsingED As Integer
        Dim myGRow As Janus.Windows.GridEX.GridEXRow

        For Each myGRow In gridExpiredDate.GetDataRows
            QtyItemAlreadyAsingED = QtyItemAlreadyAsingED + CInt(myGRow.Cells("Quantity").Value())
        Next
        txtTmpQtyAlreadyAsignExDate.Text = QtyItemAlreadyAsingED
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        With OpenFileImage
            .InitialDirectory = "C:\"
            .Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*bmp"
            .FilterIndex = 4
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                With PicItem
                    .Image = System.Drawing.Image.FromFile(OpenFileImage.FileName)
                    .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                End With
                lblPicFilePath.Text = OpenFileImage.FileName
            End If
        End With
    End Sub

    Private Sub btnClearPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearPic.Click
        If Not (PicItem.Image Is Nothing) Then
            PicItem.Image.Dispose()
            PicItem.Image = Nothing
        End If
    End Sub

    Private Sub menuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuSave.Click

        Dim item As New tblItem
        Dim inventory As New tblCentralInventory
        Dim category As New tblCategory
        Dim itemTransMsgStatus As String
        Dim myVendorSupply As New tblVendorItemSupplyStatus
        Dim myDonatorSupply As New tblVendorItemSupplyStatus

        ' Validation
        If ValidateTextField(txtItemName, "Item name", ErrorItem) = False Then
            'Or ValidateTextField(txtBarCode, "Barcode", ErrorItem) = False Then
            Exit Sub
        End If
        If ValidateCombobox(cbCate, "Select category", ErrorItem) = False Then
            Exit Sub
        End If

        If IsHopRecItem = False Then



            If lblSaveOption.Text = "0" Then
                If MessageBox.Show("Do you want save new item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans

                    'Check validate item already exist by Barcode
                    'If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
                    '    MessageBox.Show("Item Barcode already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    Exit Sub
                    'End If
                    Try
                        'item.ItemRegisterDate  
                        item.ItemName = txtItemName.Text
                        item.ItemCode = txtItemName.Text & cbItemUnit.SelectedValue & cbContainer.SelectedValue
                        item.Barcode = txtBarCode.Text
                        ' Save Bind image
                        If lblPicFilePath.Text <> "" Then
                            item.Picture = GetByImage(lblPicFilePath.Text, PicItem)
                        End If

                        ' (Medicine block)  
                        If ckbMedicine.Checked = True Then

                            item.ContainerID = cbItemContainer.SelectedValue
                            item.LabourFacID = cbLabourFac.SelectedValue
                            item.IsMedicine = ckbMedicine.Checked ' dedicate that item is medicine or normal Product
                        Else
                            item.IsMedicine = ckbMedicine.Checked

                        End If
                        ' === End block Medicine

                        ' (Package Info block)
                        item.CateID = cbCate.SelectedValue
                        item.ItemUnitID = cbItemUnit.SelectedValue 'UoM                        
                        item.CountryID = cbCountry.SelectedValue
                        item.ItemDescription = txtDescription.Text
                        '--- Cost of item
                        If Trim(TxtCost.Text) = "" Then
                            item.UnitPrice = 0
                        Else
                            item.UnitPrice = Val(TxtCost.Text)
                        End If

                        '--- Save date expired of item
                        If dtpDateExpired.Checked = True Then
                            item.DateExpired = dtpDateExpired.Value.Date
                        End If
                        ' === End block Source Info

                        ' Save item
                        THIDataContext.getTHIDataContext.tblItems.InsertOnSubmit(item)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        ' === End Add item

                        If ckbMedicine.Checked = True Then
                            'Add tblItemChemicalDetail
                            With gridChemical
                                For Each rRow As DataGridViewRow In .Rows
                                    Dim chemical As New tblItemChemicalDetail
                                    chemical.ItemID = item.ItemID
                                    chemical.ChemicalID = rRow.Cells("cChemicalID").Value
                                    chemical.ContainerID = rRow.Cells("cContainerID").Value
                                    THIDataContext.getTHIDataContext.tblItemChemicalDetails.InsertOnSubmit(chemical)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                Next
                            End With
                        End If


                        ' ==== Resgist item in Inventory
                        inventory.ItemID = item.ItemID
                        inventory.UnitsInStock = 0
                        If txtStockAlertQty.Text <> "" Then inventory.StockAlertQty = txtStockAlertQty.Text
                        If txtExpireAlert.Text <> "" Then inventory.ExpiredAlert = txtExpireAlert.Text
                        inventory.DepartID = MAIN_STOCK_DEPART_ID
                        ' Save inventory
                        THIDataContext.getTHIDataContext.tblCentralInventories.InsertOnSubmit(inventory)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        ' === End block Package Info

                        '*** Manage Priviledge for department                        
                        With gridDepartPriviledge
                            For Each rRow As DataGridViewRow In .Rows
                                Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells("cIsShow"), DataGridViewCheckBoxCell)
                                Dim myDepartPriviledge As New tblPermissionItemShoworHideForDepart
                                If chk.Value = True Then
                                    myDepartPriviledge.ItemID = item.ItemID
                                    myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                    myDepartPriviledge.IsShow = True
                                    THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                Else
                                    myDepartPriviledge.ItemID = item.ItemID
                                    myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                    myDepartPriviledge.IsShow = False
                                    THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                End If
                            Next

                        End With
                        '-- Priviledge for Main Stock
                        Dim MainStockPriviledge As New tblPermissionItemShoworHideForDepart
                        MainStockPriviledge.ItemID = item.ItemID
                        MainStockPriviledge.DepartID = MAIN_STOCK_DEPART_ID
                        MainStockPriviledge.IsShow = True

                        THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(MainStockPriviledge)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        '--- Manage Save Expire Date for item
                        'Dim myGRow As Janus.Windows.GridEX.GridEXRow
                        'For Each myGRow In gridExpiredDate.GetDataRows
                        '    Dim myItemExpireDate As New tblItemExpireControl
                        '    myItemExpireDate.ItemID = labelItemID.Text
                        '    myItemExpireDate.ItemExpireDate = myGRow.Cells("ItemExpireDate").Value()
                        '    myItemExpireDate.Quantity = CInt(myGRow.Cells("Quantity").Value())

                        '    THIDataContext.getTHIDataContext.tblItemExpireControls.InsertOnSubmit(myItemExpireDate)
                        '    THIDataContext.getTHIDataContext.SubmitChanges()
                        'Next
                        '== End manage save expire date for item

                        '--- Update ItemCount in Category table
                        DA_ItemPrice.InsertItemPrice(item.ItemID, EmptyString(TxtPrice.Text), True, False, True, 96, Now.Date)
                        Dim cate = From qCate In THIDataContext.getTHIDataContext.tblCategories Where qCate.CateID = CInt(cbCate.SelectedValue)
                        Dim myCategory As tblCategory = cate.SingleOrDefault
                        myCategory.ItemCount = myCategory.ItemCount + 1
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        TxtPrice.Text = "0"
                        trans.Commit()
                        itemTransMsgStatus = "True"
                        THIDataContext.getTHIDataContext.Connection.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        itemTransMsgStatus = ex.Message
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Finally
                        trans = Nothing
                    End Try

                    If itemTransMsgStatus = "True" Then
                        MessageBox.Show("New Item Registered Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Refresh data for user create new item without close the window item
                        myRefresh()
                        InitPriviledgeTab()
                        txtExpireAlert.Text = "0"
                        txtStockAlertQty.Text = "0"
                        txtQuantity.Text = "0"
                        txtUnitOnOrder.Text = "0"
                        txtItemName.Text = ""
                        txtBarCode.Text = ""
                        ckbMedicine.Checked = False
                        gridChemical.Rows.Clear()
                        txtDescription.Text = ""
                        TxtCost.Text = "0"
                        '--- Tab Expired date reset for register new item
                        gridExpiredDate.ClearItems() '--- Clear grid item Expired Date after user save item.
                        txtEDItemName.Text = ""
                        txtQuantity.Text = "0"
                        txtTmpQtyInStock.Text = ""
                        txtTmpQtyAlreadyAsignExDate.Text = ""
                        UiTabPage1.Selected = True
                    Else
                        MsgBox("Error update item.", MsgBoxStyle.Critical, "Error : " & itemTransMsgStatus)
                    End If
                End If
            Else ' ========================== Implement for update item to database =========================================================================

                If MessageBox.Show("Do you want upate this item ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans

                    'Check validate item already exist by Barcode
                    If myBarcode <> txtBarCode.Text Then
                        If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
                            MessageBox.Show("Item Barcode already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    '--- get item edit by itemID
                    Dim qItem = From myEditItem In THIDataContext.getTHIDataContext.tblItems Where myEditItem.ItemID = myItemID
                    Dim myItem As tblItem = qItem.SingleOrDefault

                    Try

                        myItem.ItemName = txtItemName.Text
                        myItem.ItemCode = txtItemName.Text & cbItemUnit.SelectedValue & cbContainer.SelectedValue
                        myItem.Barcode = txtBarCode.Text

                        '--- Save image
                        If lblPicFilePath.Text <> "" Then
                            myItem.Picture = GetByImage(lblPicFilePath.Text, PicItem)
                        End If

                        '--- (Medicine block)  
                        If ckbMedicine.Checked = True Then
                            '--- Add tblItemChemicalDetail
                            With gridChemical
                                '--- Delete item chemical detail before add new
                                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblItemChemicalDetail where ItemID={0}", myItemID)

                                For Each rRow As DataGridViewRow In .Rows
                                    Dim chemical As New tblItemChemicalDetail
                                    chemical.ItemID = labelItemID.Text
                                    chemical.ChemicalID = rRow.Cells("cChemicalID").Value
                                    chemical.ContainerID = rRow.Cells("cContainerID").Value
                                    THIDataContext.getTHIDataContext.tblItemChemicalDetails.InsertOnSubmit(chemical)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                Next

                            End With
                            myItem.ContainerID = cbItemContainer.SelectedValue
                            myItem.LabourFacID = cbLabourFac.SelectedValue
                            myItem.IsMedicine = ckbMedicine.Checked ' dedicate that item is medicine or normal Product
                        Else
                            myItem.IsMedicine = ckbMedicine.Checked
                        End If

                        '--- Package Info block
                        myItem.CateID = cbCate.SelectedValue
                        myItem.ItemUnitID = cbItemUnit.SelectedValue
                        myItem.CountryID = cbCountry.SelectedValue
                        myItem.ItemDescription = txtDescription.Text
                        '--- Cost of item
                        If Trim(TxtCost.Text) = "" Then
                            myItem.UnitPrice = 0
                        Else
                            myItem.UnitPrice = Val(TxtCost.Text)
                        End If
                        '--- Save Country

                        '--- Resgist item in Inventory
                        Dim centralStock = From CI In THIDataContext.getTHIDataContext.tblCentralInventories Where CI.ItemID = myItemID
                        Dim mycentralStock As tblCentralInventory = centralStock.SingleOrDefault
                        If txtStockAlertQty.Text <> "" Then mycentralStock.StockAlertQty = Val(txtStockAlertQty.Text)
                        If txtExpireAlert.Text <> "" Then mycentralStock.ExpiredAlert = Val(txtExpireAlert.Text)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        '--- Save date expired of item
                        If dtpDateExpired.Checked = True Then
                            myItem.DateExpired = dtpDateExpired.Value.Date
                        End If

                        myItem.ItemDescription = txtDescription.Text
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        '---  Manage Priviledge for department
                        THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblPermissionItemShoworHideForDepart where ItemID={0}", myItemID)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        With gridDepartPriviledge
                            For Each rRow As DataGridViewRow In .Rows
                                Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells("cIsShow"), DataGridViewCheckBoxCell)
                                Dim myDepartPriviledge As New tblPermissionItemShoworHideForDepart
                                If chk.Value = True Then
                                    myDepartPriviledge.ItemID = labelItemID.Text
                                    myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                    myDepartPriviledge.IsShow = True
                                    THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                Else
                                    myDepartPriviledge.ItemID = labelItemID.Text
                                    myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                    myDepartPriviledge.IsShow = False
                                    THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                    THIDataContext.getTHIDataContext.SubmitChanges()
                                End If

                            Next


                        End With
                        '-- Priviledge for Main Stock
                        Dim MainStockPriviledge As New tblPermissionItemShoworHideForDepart
                        MainStockPriviledge.ItemID = myItem.ItemID ' item.ItemID
                        MainStockPriviledge.DepartID = MAIN_STOCK_DEPART_ID
                        MainStockPriviledge.IsShow = True
                        THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(MainStockPriviledge)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                        '--- Update ItemCount in Category table
                        If myCateID <> cbCate.SelectedValue Then

                            '--- decrease field itemcount of old category
                            Dim cate1 = From qCate1 In THIDataContext.getTHIDataContext.tblCategories Where qCate1.CateID = myCateID

                            Dim myCate1 As tblCategory = cate1.SingleOrDefault
                            myCate1.ItemCount = myCate1.ItemCount - 1
                            THIDataContext.getTHIDataContext.SubmitChanges()

                            '--- increase field itemcount of new category that user just modified
                            category = cateRepo.GetCateByID(cbCate.SelectedValue)
                            category.ItemCount = category.ItemCount + 1
                            cateRepo.UpdateCate()

                        End If

                        trans.Commit()
                        itemTransMsgStatus = "True"
                        THIDataContext.getTHIDataContext.Connection.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        itemTransMsgStatus = ex.Message
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Finally
                        trans = Nothing
                    End Try

                    If itemTransMsgStatus = "True" Then
                        MessageBox.Show("Save item successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MsgBox("Error update item.", MsgBoxStyle.Critical, "Error : " & itemTransMsgStatus)
                    End If

                End If
            End If
            '=============================================== Register for Caritas =====================================
        Else

            If MessageBox.Show("Do you want save new item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                'Check validate item already exist by Barcode

                If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
                    MessageBox.Show("Item Barcode already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If


                Try
                    'item.ItemRegisterDate  
                    item.ItemName = txtItemName.Text
                    item.ItemCode = txtItemName.Text & cbItemUnit.SelectedValue & cbContainer.SelectedValue
                    item.Barcode = txtBarCode.Text
                    ' Save Bind image
                    If lblPicFilePath.Text <> "" Then
                        item.Picture = GetByImage(lblPicFilePath.Text, PicItem)
                    End If

                    ' (Medicine block)  
                    If ckbMedicine.Checked = True Then
                        item.ContainerID = cbItemContainer.SelectedValue
                        item.LabourFacID = cbLabourFac.SelectedValue
                        item.IsMedicine = ckbMedicine.Checked ' dedicate that item is medicine or normal Product
                    Else
                        item.IsMedicine = ckbMedicine.Checked

                    End If
                    ' === End block Medicine

                    ' (Package Info block)
                    item.CateID = cbCate.SelectedValue
                    item.ItemUnitID = cbItemUnit.SelectedValue 'UoM                    
                    item.CountryID = cbCountry.SelectedValue
                    item.ItemDescription = txtDescription.Text
                    '--- Cost of item
                    If Trim(TxtCost.Text) = "" Then
                        item.UnitPrice = 0
                    Else
                        item.UnitPrice = Val(TxtCost.Text)
                    End If
                    '--- Save date expired of item
                    If dtpDateExpired.Checked = True Then
                        item.DateExpired = dtpDateExpired.Value.Date
                    End If
                    ' === End block Source Info

                    ' Save item
                    THIDataContext.getTHIDataContext.tblItems.InsertOnSubmit(item)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    If ckbMedicine.Checked = True Then
                        'Add tblItemChemicalDetail
                        With gridChemical
                            For Each rRow As DataGridViewRow In .Rows
                                Dim chemical As New tblItemChemicalDetail
                                chemical.ItemID = item.ItemID
                                chemical.ChemicalID = rRow.Cells("cChemicalID").Value
                                chemical.ContainerID = rRow.Cells("cContainerID").Value
                                THIDataContext.getTHIDataContext.tblItemChemicalDetails.InsertOnSubmit(chemical)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Next
                        End With
                    End If


                    ' ==== Resgist item in Inventory
                    inventory.ItemID = item.ItemID
                    inventory.UnitsInStock = 0
                    If txtStockAlertQty.Text <> "" Then inventory.StockAlertQty = txtStockAlertQty.Text
                    If txtExpireAlert.Text <> "" Then inventory.ExpiredAlert = txtExpireAlert.Text
                    inventory.DepartID = MAIN_STOCK_DEPART_ID
                    ' Save inventory
                    THIDataContext.getTHIDataContext.tblCentralInventories.InsertOnSubmit(inventory)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    ' === End block Package Info

                    ' === End Add item

                    '*** Manage Priviledge for department
                    With gridDepartPriviledge
                        For Each rRow As DataGridViewRow In .Rows
                            Dim chk As DataGridViewCheckBoxCell = CType(rRow.Cells("cIsShow"), DataGridViewCheckBoxCell)
                            Dim myDepartPriviledge As New tblPermissionItemShoworHideForDepart
                            If chk.Value = True Then
                                myDepartPriviledge.ItemID = item.ItemID
                                myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                myDepartPriviledge.IsShow = True
                                THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            Else
                                myDepartPriviledge.ItemID = item.ItemID
                                myDepartPriviledge.DepartID = rRow.Cells("cDepartmentID").Value
                                myDepartPriviledge.IsShow = False
                                THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(myDepartPriviledge)
                                THIDataContext.getTHIDataContext.SubmitChanges()
                            End If

                        Next

                        '-- Priviledge for Main Stock
                        Dim MainStockPriviledge As New tblPermissionItemShoworHideForDepart
                        MainStockPriviledge.ItemID = item.ItemID
                        MainStockPriviledge.DepartID = MAIN_STOCK_DEPART_ID
                        MainStockPriviledge.IsShow = True
                        THIDataContext.getTHIDataContext.tblPermissionItemShoworHideForDeparts.InsertOnSubmit(MainStockPriviledge)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    End With
                    '===

                    Dim cate = From qCate In THIDataContext.getTHIDataContext.tblCategories Where qCate.CateID = CInt(cbCate.SelectedValue)
                    Dim myCategory As tblCategory = cate.SingleOrDefault
                    myCategory.ItemCount = myCategory.ItemCount + 1
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    ' === End Update ItemCount in Category table


                    '--- Update table CARITAS_REQUEST_DETAIL_INVENTORY
                    THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET ItemID={0},Barcode={1} WHERE RequestDetailID={2}", item.ItemID, txtBarCode.Text, ReqDetailIDItemNotExistInHos)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- Update table ITEM_OUTSIDE_INVENTORY   
                    'THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM ITEM_OUTSIDE_INVENTORY WHERE ItemName={0}", txtItemName.Text)
                    THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE ITEM_OUTSIDE_INVENTORY SET IsRegistered={0} WHERE ItemName={1}", True, txtItemName.Text)
                    THIDataContext.getTHIDataContext.SubmitChanges()


                    trans.Commit()
                    itemTransMsgStatus = "True"
                    THIDataContext.getTHIDataContext.Connection.Close()
                Catch ex As Exception
                    trans.Rollback()
                    itemTransMsgStatus = ex.Message
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing
                End Try

                If itemTransMsgStatus = "True" Then
                    Barcode = txtBarCode.Text
                    pItemID = item.ItemID
                    MessageBox.Show("New item register successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox("Error update item.", MsgBoxStyle.Critical, "Error : " & itemTransMsgStatus)
                End If
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        txtBarCode.Focus()
    End Sub

    Private Sub menuCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCancel.Click
        'Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnItemContaining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemContaining.Click

        Dim FContainer As New frmContainer
        If FContainer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbItemContainer
                .DataSource = ContainerDataAdapter.GetData
                .ValueMember = "ContainerID"
                .DisplayMember = "ContainerName"
                .SelectedIndex = .Items.Count - 1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If
    End Sub

    Private Sub BtnNewChemical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewChemical.Click

        Dim fChemical As New frmChemical
        If fChemical.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbChemical
                .DataSource = ChemicalDataAdapter.GetData
                .ValueMember = "ChemicalID"
                .DisplayMember = "ChemicalName"
                .SelectedIndex = .Items.Count - 1   ' selected the latest chemical just created
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If

    End Sub

    Private Sub BtnNewLaboratory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLaboratory.Click

        Dim fLabouratory As New frmLabourFactory
        If fLabouratory.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbLabourFac
                .DataSource = LabourDataAdapter.GetData
                .ValueMember = "LabourFacID"
                .DisplayMember = "LabourFacName"
                .SelectedIndex = .Items.Count - 1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If

    End Sub

    Private Sub BtnUom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUom.Click

        Dim fUoM As New frmItemUnit
        If fUoM.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbItemUnit
                .DataSource = UnitItemDataAdapter.GetData
                .ValueMember = "ItemUnitID"
                .DisplayMember = "ItemUnitName"
                .SelectedIndex = .Items.Count - 1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If
    End Sub

    Private Sub BtnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategories.Click

        Dim fCate As New frmCategory
        If fCate.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbCate
                .DataSource = CateDataAdapter.GetData
                .ValueMember = "CateID"
                .DisplayMember = "CateName"
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
                .SelectedIndex = .Items.Count - 1
            End With
        End If
    End Sub

    Private Sub BtnNewDonation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim fVendor As New frmVender
        fVendor.isVendor = False
        fVendor.isDonator = True

        'If fVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    With cbDonator
        '        .DataSource = VendorDataAdapter.GetVendorDataRecord
        '        .ValueMember = "VenderID"
        '        .DisplayMember = "VenderName"
        '        .SelectedIndex = .Items.Count - 1
        '        .AutoCompleteMode = AutoCompleteMode.Suggest
        '        .AutoCompleteSource = AutoCompleteSource.ListItems
        '    End With
        'End If


    End Sub

    Private Sub BtnNewVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim fVendor As New frmVender
        fVendor.isVendor = True
        fVendor.isDonator = False

        If fVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'With cbVendor
            '    .DataSource = VendorDataAdapter.GetDonatorDataRecord
            '    .ValueMember = "VenderID"
            '    .DisplayMember = "VenderName"
            '    .SelectedIndex = .Items.Count - 1
            '    .AutoCompleteMode = AutoCompleteMode.Suggest
            '    .AutoCompleteSource = AutoCompleteSource.ListItems
            'End With

        End If

    End Sub

    Private Sub BtnNewContaining_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewContaining.Click

        Dim FContainer As New frmContainer
        If FContainer.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With cbContainer
                .DataSource = ContainerDataAdapter.GetData
                .ValueMember = "ContainerID"
                .DisplayMember = "ContainerName"
                .SelectedIndex = .Items.Count - 1
                .AutoCompleteMode = AutoCompleteMode.Suggest
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, System.Windows.Forms.TextBox).Text.Contains(Chr(46)) Then
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

    Private Sub txtBarCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtItemName.Focus()
        End If
    End Sub

    Private Sub BtnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            For Each rRow As DataGridViewRow In gridDepartPriviledge.Rows
                rRow.Cells("cIsShow").Value = True
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnUnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            For Each rRow As DataGridViewRow In gridDepartPriviledge.Rows
                rRow.Cells("cIsShow").Value = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtBarCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.Leave

        ''--- Check validate item already exist by Barcode
        'If lblSaveOption.Text = "0" Then
        '    If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
        '        MessageBox.Show("Item Barcode already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        txtBarCode.Focus()
        '    End If
        'Else
        '    If myBarcode <> txtBarCode.Text Then
        '        If itemRepo.isItemExistInMainStock(txtBarCode.Text) Then
        '            MessageBox.Show("Item Barcode already registered", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            txtBarCode.Focus()
        '        End If
        '    End If
        'End If

    End Sub

    Private Sub BtnUnCheckAll_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnCheckAll.Click
        Try
            For Each rRow As DataGridViewRow In gridDepartPriviledge.Rows
                rRow.Cells("cIsShow").Value = False
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCheckAll_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheckAll.Click

        Try
            For Each rRow As DataGridViewRow In gridDepartPriviledge.Rows
                rRow.Cells("cIsShow").Value = True
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub gridDepartPriviledge_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDepartPriviledge.CurrentCellDirtyStateChanged
        If gridDepartPriviledge.IsCurrentCellDirty Then
            gridDepartPriviledge.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub




    Private Sub TxtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrice.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class