Imports System.Data.Common

Public Class frmMainStockResponseItem

    Public myRequestDetailID As Integer
    Public myItemName As String
    Public myComment As String
    Public myResponseQty As String
    Public myRequestQty As String
    Public myItemID As String
    Public myRequestID As String
    Public ReqFromDepartID As Integer

    Public isRequestInputFromDepart As Boolean
    Private DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Private InventoryRepo As IInventory = New Inventory
    Private RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Dim ItemProviderDataAdapter As New DSCategoriesAndItemsTableAdapters.V_ITEM_PROVIDERTableAdapter
    Dim ItemProResToDepartDataAdapter As New DSRequestTableAdapters.ITEM_PROVIDER_TRANSTableAdapter
    Public VendorRepo As IVendorRepository = New VendorRepository


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtResponseQuantity.Text <> "" Then
            '--- Validate response quantity must smaller than request quantity
            If Val(txtRequestQuantity.Text) <> 0 Then
                If Val(txtResponseQuantity.Text) > Val(txtRequestQuantity.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than Request Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            Else '--- In case request quantity equals 0 so we validate response quantity must be smaller than units in stock.
                If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            End If
        End If

        '--- In case reqeust quantity greater than quantity in stock
        If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
            MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResponseQuantity.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Do you want save response item information ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Update table tblRequestDetail
                Dim q = From RD In THIDataContext.getTHIDataContext.tblRequestDetails Where RD.RequestDetailID = myRequestDetailID
                Dim RequestDetail As tblRequestDetail = q.SingleOrDefault
                RequestDetail.ResponseQuantity = Val(txtResponseQuantity.Text)
                RequestDetail.Status = 2 'Sent            
                THIDataContext.getTHIDataContext.SubmitChanges()
                '===

                '--- Update table tblRequestStatusTracking (UserID update , Comment update)
                Dim RequestST = From RST In THIDataContext.getTHIDataContext.tblRequestStatusTrackings Where RST.RequestID = Val(myRequestID)
                Dim myRequestStatusTracking As tblRequestStatusTracking = RequestST.SingleOrDefault
                myRequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)
                myRequestStatusTracking.Comment = rtbComment.Text
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Delete ITEM_PROVIDER_TRANS
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM ITEM_PROVIDER_TRANS WHERE RequestID={0} AND ItemID={1}", myRequestID, myItemID)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- ITEM_PROVIDER_TRANS update
                With gridProviderDetail
                    For Each rRow As DataGridViewRow In .Rows
                        '--- Save ITEM_PROVIDER_TRANS
                        Dim ItemProTrans As New ITEM_PROVIDER_TRAN
                        ItemProTrans.ItemID = myItemID
                        ItemProTrans.RequestID = myRequestID
                        ItemProTrans.ProviderID = Val(rRow.Cells("ProviderID").Value)
                        ' ItemProTrans.TransDate '--- Update when department received item
                        ItemProTrans.DepartUseID = ReqFromDepartID
                        ItemProTrans.Quantity = Val(rRow.Cells("GivenQty").Value)
                        ItemProTrans.Status = 0 '--- Incomplete status, When department received item status is Complete

                        THIDataContext.getTHIDataContext.ITEM_PROVIDER_TRANs.InsertOnSubmit(ItemProTrans)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                    Next
                End With

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
            End Try

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponseQuantity.KeyPress
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

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateTextField(TxtGivenQty, "", Errors) = False Then Exit Sub
        If RbDonator.Checked = False And RbVendor.Checked = False Then
            MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '--- Validate sometimes user select combo box and press button delete before attempt to add
        If RbDonator.Checked = True Then
            'If CbDonation.SelectedValue Is Nothing Then
            '    MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If ValidateCombobox(CbDonation, "", Errors) = False Then Exit Sub
        End If

        If RbVendor.Checked = True Then
            'If CbVendor.SelectedValue Is Nothing Then
            '    MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If ValidateCombobox(CbVendor, "", Errors) = False Then Exit Sub
        End If

        Dim obj(3) As Object
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
            obj(3) = 0

            If gridProviderDetail.Rows.Count = 0 Then
                gridProviderDetail.Rows.Add(obj)
                txtResponseQuantity.Text = Val(txtResponseQuantity.Text) + Val(TxtGivenQty.Text)
            Else
                If IsDupValidateProvider(obj, ProviderID) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    txtResponseQuantity.Text = Val(txtResponseQuantity.Text) + Val(TxtGivenQty.Text)
                Else
                    MessageBox.Show("Item's provider already Exist.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End With

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected provider ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    txtResponseQuantity.Text = Val(txtResponseQuantity.Text) - Val(rRow.Cells("GivenQty").Value)
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

    Private Sub TxtGivenQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGivenQty.KeyPress
        SetDisableKeyString(e)
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

    Private Sub frmMainStockResponseItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtItemName.Text = myItemName
        txtResponseQuantity.Text = myResponseQty
        txtRequestQuantity.Text = myRequestQty

        If isRequestInputFromDepart = False Then
            txtInStock.Text = InventoryRepo.GetMainStockQuantityByItemID(CInt(myItemID))
        Else
            txtInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), CInt(myItemID))
        End If

        rtbComment.Text = myComment

        With CbDonation
            .DataSource = ItemProviderDataAdapter.GetItemDonorByItemID(CInt(myItemID))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ItemProviderDataAdapter.GetItemVendorByItemID(CInt(myItemID))
            .ValueMember = "VendorID"
            .DisplayMember = "VenderName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        CbDonation.Enabled = False
        CbVendor.Enabled = False

        '--- Load gridProviderDetail
        Dim ItemProResToDepartDT As DataTable = ItemProResToDepartDataAdapter.GetProInfoResToDepart(Val(myItemID), Val(myRequestID))

        For Each row As DataRow In ItemProResToDepartDT.Rows
            Dim obj(2) As Object
            With gridProviderDetail
                obj(0) = VendorRepo.GetVendorNameByID(CInt(row("ProviderID")))
                obj(1) = row("Quantity")
                obj(2) = row("ProviderID")
                .Rows.Add(obj)
            End With
        Next

    End Sub

End Class