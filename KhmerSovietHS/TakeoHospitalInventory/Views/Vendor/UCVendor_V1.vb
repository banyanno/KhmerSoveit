Imports System.Data.Common

Public Class UCVendor_V1

    Dim VendorDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Dim vendorRepo As IVendorRepository = New VendorRepository
    Dim VendorItemsAdapter As DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
    Dim ListItemVendorSupplyAdapter As DSVendorsTableAdapters.VVendorItemSupplyStatusTableAdapter
    Dim ListItemDonatorSupplyAdapter As DSVendorsTableAdapters.VDonatorItemSupplyStatusTableAdapter
    Dim ItemProviderDataAdapter As DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
    Private THIDataContext As New BaseDataContext

    'Initialize object VendorDataAdapter
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        VendorDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        VendorItemsAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        ListItemVendorSupplyAdapter = New DSVendorsTableAdapters.VVendorItemSupplyStatusTableAdapter
        ListItemDonatorSupplyAdapter = New DSVendorsTableAdapters.VDonatorItemSupplyStatusTableAdapter
        ItemProviderDataAdapter = New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub UCVendor_V1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initVendorAndDonatorList()
    End Sub    
    Private Sub initVendorAndDonatorList()

        'Initial Vendor list
        Dim myDataTable As New DataTable
        myDataTable = VendorDataAdapter.GetVendorDataList

        If myDataTable.Rows.Count > 0 Then

            Dim VendorLists As New ArrayList()
            For Each aRow As DataRow In myDataTable.Rows
                VendorLists.Add(New clsList(aRow("VenderName"), aRow("VenderID")))
            Next

            With listVendor
                .DataSource = VendorLists
                .DisplayMember = "ItemDisplay"
                .ValueMember = "ItemValue"
            End With
        End If

        'Initial Donator list
        Dim myDataTable1 As New DataTable
        myDataTable1 = VendorDataAdapter.GetDonatorDataList

        If myDataTable1.Rows.Count > 0 Then
            Dim DonatorsLists As New ArrayList()

            For Each aRow As DataRow In myDataTable1.Rows
                DonatorsLists.Add(New clsList(aRow("VenderName"), aRow("VenderID")))
            Next

            With listDonator
                .DataSource = DonatorsLists
                .DisplayMember = "ItemDisplay"
                .ValueMember = "ItemValue"
            End With
        End If

    End Sub
    Private Sub listVendor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listVendor.SelectedIndexChanged

        Dim myitemValue As Integer
        Dim myitemDisplay As String = ""
        Dim mySelectList As clsList
        Try
            mySelectList = listVendor.SelectedValue
            myitemValue = mySelectList.ItemValue
            myitemDisplay = mySelectList.ItemDisplay
        Catch ex As Exception
            myitemValue = listVendor.SelectedValue
            mySelectList = listVendor.Items.Item(listVendor.SelectedIndex)
            myitemDisplay = mySelectList.ItemDisplay
        End Try

        'txtID.Text = myitemValue
        'GetVendorOrDonatorInfo(myitemValue)
        'GetVendorItems(myitemValue)
        Label9.Text = "Detail Items Information (" & gridItems.RowCount & ")"
        gridItems.DataSource = ItemProviderDataAdapter.GetItemByProviderID(myitemValue)
        LbVID.Text = myitemValue
        'txtVendorID.Text = myitemValue

    End Sub

    Private Sub listDonator_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listDonator.SelectedIndexChanged

        Dim myitemValue As Integer
        Dim myitemDisplay As String = ""
        Dim mySelectList As clsList
        Try
            mySelectList = listDonator.SelectedValue
            myitemValue = mySelectList.ItemValue
            myitemDisplay = mySelectList.ItemDisplay
        Catch ex As Exception
            myitemValue = listDonator.SelectedValue
            mySelectList = listDonator.Items.Item(listDonator.SelectedIndex)
            myitemDisplay = mySelectList.ItemDisplay
        End Try

        'txtID.Text = myitemValue
        'GetVendorOrDonatorInfo(myitemValue)
        'GetDonatorItems(myitemValue)
        Label9.Text = "Detail Items Information (" & gridItems.RowCount & ")"
        gridItems.DataSource = ItemProviderDataAdapter.GetItemByProviderID(myitemValue)
        LbDID.Text = myitemValue
        'txtVendorID.Text = myitemValue
    End Sub

    'Private Sub GetVendorOrDonatorInfo(ByVal plistIndex As Integer)
    '    Dim myContext As New tblVender
    '    myContext = vendorRepo.GetVenderByID(plistIndex)
    '    txtVendorName.Text = myContext.VenderName
    '    txtTelephone.Text = myContext.VenderPhone
    '    txtFax.Text = myContext.VenderFax
    '    txtEmail.Text = myContext.VenderEmail
    '    txtWebsite.Text = myContext.Website
    '    rtbAddress.Text = myContext.VenderAddress
    '    txtTempVendorName.Text = myContext.VenderName
    'End Sub

    'Private Sub GetVendorItems(ByVal plistIndex As Integer)
    '    gridItems.DataSource = ListItemVendorSupplyAdapter.GetListItemVendorSupply(plistIndex)
    'End Sub

    'Private Sub GetDonatorItems(ByVal plistIndex As Integer)
    '    gridItems.DataSource = ListItemDonatorSupplyAdapter.GetListItemDonatorSupply(plistIndex)
    'End Sub

    Private Sub BtnNewVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewVendor.Click

        Dim FVendor As New frmVender(Me)
        FVendor.isVendor = True
        FVendor.isDonator = False
        If FVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            initVendorAndDonatorList()
            FVendor.Close()
            FVendor.Dispose()
        End If

    End Sub

    Private Sub btnNewDonator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDonator.Click
        Dim FVendor As New frmVender(Me)
        FVendor.isVendor = False
        FVendor.isDonator = True
        If FVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            initVendorAndDonatorList()
            FVendor.Close()
            FVendor.Dispose()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim FVendor As New frmVender()
        FVendor.lblSaveOption.Text = "1"
        FVendor.venderID = Val(LbVID.Text)
        FVendor.TxtTempProviderName.Text = listVendor.Text

        If FVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            initVendorAndDonatorList()
            FVendor.Close()
            FVendor.Dispose()
        End If




    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim vendor As New tblVender
    '    Dim vendorTransMsgStatus As String

    '    ' Validation
    '    If ValidateTextField(txtVendorName, "Vendor name", ErrorVendor) = False _
    '    Or ValidateTextField(txtEmail, "Email", ErrorVendor) = False _
    '    Or ValidateTextField(txtTelephone, "Telephone", ErrorVendor) = False Then
    '        Exit Sub
    '    End If

    '    If UCase(txtTempVendorName.Text) <> UCase(txtVendorName.Text) Then
    '        If vendorRepo.isVendorExistSearchByVendorName(txtVendorName.Text) Then
    '            MsgBox("Vendor Or Donator name already exist.")
    '            Exit Sub
    '        End If
    '    End If

    '    If MessageBox.Show("Do you want save new Vendor ?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        vendor = vendorRepo.GetVenderByID(CInt(txtID.Text))
    '        vendor.VenderName = txtVendorName.Text
    '        vendor.VenderPhone = txtTelephone.Text
    '        vendor.VenderEmail = txtEmail.Text
    '        vendor.VenderFax = txtFax.Text
    '        vendor.Website = txtWebsite.Text
    '        vendor.VenderAddress = rtbAddress.Text

    '        vendorTransMsgStatus = vendorRepo.Update
    '        If vendorTransMsgStatus <> "True" Then
    '            MsgBox("Error update Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
    '        Else
    '            MessageBox.Show("Save update Vendor successfull.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            initVendorAndDonatorList()
    '        End If
    '    End If
    'End Sub

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    '    Dim vendor As New tblVender
    '    Dim vendorTransMsgStatus As String = ""

    '    If MessageBox.Show("Do you want delete Vendor ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        vendor = vendorRepo.GetVenderByID(CInt(txtID.Text))
    '        vendor.IsMarkDelete = True

    '        vendorTransMsgStatus = vendorRepo.Update
    '        If vendorTransMsgStatus <> "True" Then
    '            MsgBox("Error update Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
    '        Else
    '            MessageBox.Show("This Vendor Or Donator is mark as delete status , Please contact administrator to recover this Vendor or Donator.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            initVendorAndDonatorList()
    '        End If
    '    End If
    'End Sub

    Private Sub btnUnStoreItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnStoreItem.Click


        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'get an array with all the rows that the user checked.
        checkedRows = gridItems.GetCheckedRows()

        Dim message As String
        message = String.Format("Don't you supply {0} item(s)," _
                    & vbCrLf & "Do you want to continue?", checkedRows.Length)
        If MessageBox.Show(message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
        System.Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Dim row As Janus.Windows.GridEX.GridEXRow
            For Each row In checkedRows

                Try

                    Dim myItemID As Integer = CInt(row.Cells("ItemID").Value)
                    Dim myVendorID As Integer = CInt(row.Cells("VenderID").Value)

                    'Dim q = From VISS In THIDataContext.getTHIDataContext.tblVendorItemSupplyStatus Where VISS.ItemID = myItemID And VISS.VendorID = myVendorID

                    'If q.ToList.Count > 0 Then




                    'End If

                    'Dim myVendorItemSupplyStatus As tblVendorItemSupplyStatus = q.SingleOrDefault
                    'myVendorItemSupplyStatus.IsUnSupply = True
                    'THIDataContext.getTHIDataContext.SubmitChanges()

                    trans.Commit()                    
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()                   
                    THIDataContext.getTHIDataContext.Connection.Close()

                Finally
                    THIDataContext.getTHIDataContext.Connection.Close()
                End Try
            Next
            initVendorAndDonatorList()
        End If

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        initVendorAndDonatorList()
    End Sub

    Private Sub BtnEditDonator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditDonator.Click
        Dim FVendor As New frmVender()
        FVendor.lblSaveOption.Text = "1"
        FVendor.venderID = Val(LbDID.Text)        
        FVendor.TxtTempProviderName.Text = listDonator.Text

        If FVendor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            initVendorAndDonatorList()
            FVendor.Close()
            FVendor.Dispose()
        End If
    End Sub
End Class
