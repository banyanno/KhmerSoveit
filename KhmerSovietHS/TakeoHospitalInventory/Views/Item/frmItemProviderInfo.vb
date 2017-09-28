Imports System.Data.Common

Public Class frmItemProviderInfo

    Public myitemID As Integer
    Public myitemName As String
    Public myBarcode As String

    Dim DonationDataAdapter As DSOpticalShopTableAdapters.DONATIONTableAdapter
    Dim ProviderDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Dim CurrDataAdapter As DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DonationDataAdapter = New DSOpticalShopTableAdapters.DONATIONTableAdapter
        ProviderDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        CurrDataAdapter = New DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmItemProviderInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        myRefresh()
    End Sub

    Sub myRefresh()

        Try
            TxtItemName.Text = myitemName
            Dim THIDataContext As New BaseDataContext
            Dim q = From item In THIDataContext.getTHIDataContext.tblCentralInventories Where item.ItemID = myitemID
            Dim itemDT As tblCentralInventory = q.SingleOrDefault
            TxtUnitsInStock.Text = itemDT.UnitsInStock
        Catch ex As Exception

        End Try
        
        With CbCur
            .DataSource = CurrDataAdapter.GetData
            .ValueMember = "CurrencyID"
            .DisplayMember = "Currency"            
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbDonation
            .DataSource = ProviderDataAdapter.GetDonatorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"            
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ProviderDataAdapter.GetVendorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"            
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        CbDonation.Enabled = False
        CbVendor.Enabled = False

    End Sub

    Private Sub TxtUnitsInStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnitsInStock.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RbVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbVendor.CheckedChanged

        TxtQuantity.Text = ""

        If RbVendor.Checked = True Then
            CbVendor.Enabled = True
            CbDonation.Enabled = False
            TxtSellQty.Enabled = True
            TxtFreeQty.Enabled = True
            TxtSellQty.Text = "0"
            TxtFreeQty.Text = "0"
        Else
            CbVendor.Enabled = False
            CbDonation.Enabled = True
            TxtSellQty.Enabled = False
            TxtFreeQty.Enabled = False
            TxtSellQty.Text = "0"
            TxtFreeQty.Text = "0"
        End If



    End Sub

    Private Sub RbDonator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDonator.CheckedChanged

        TxtQuantity.Text = ""

        If RbDonator.Checked = True Then
            CbVendor.Enabled = False
            CbDonation.Enabled = True
            TxtSellQty.Text = "0"
            TxtFreeQty.Text = "0"
        Else
            CbVendor.Enabled = True
            CbDonation.Enabled = False
            TxtSellQty.Text = "0"
            TxtFreeQty.Text = "0"
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        If ValidateTextField(TxtCost, "", ErrorProvider) = False Then Exit Sub
        If ValidateTextField(TxtQuantity, "", ErrorProvider) = False Then Exit Sub
        If RbDonator.Checked = False And RbVendor.Checked = False Then
            MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Val(TxtSellQty.Text) > Val(TxtQuantity.Text) Then
            MessageBox.Show("Sell Quantity cannot exceed then Source Quantity", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        '--- Validate sometimes user select combo box and press button delete before attempt to add
        If RbDonator.Checked = True Then
            'If CbDonation.SelectedValue Is Nothing Then
            '    MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If ValidateCombobox(CbDonation, "", ErrorProvider) = False Then Exit Sub
        End If

        If RbVendor.Checked = True Then
            'If CbVendor.SelectedValue Is Nothing Then
            '    MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            If ValidateCombobox(CbVendor, "", ErrorProvider) = False Then Exit Sub
        End If




        Dim obj(7) As Object
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
            obj(1) = TxtQuantity.Text
            obj(2) = TxtCost.Text
            obj(3) = CbCur.Text
            obj(4) = ProviderID
            obj(5) = CbCur.SelectedValue
            obj(6) = TxtSellQty.Text
            obj(7) = TxtFreeQty.Text

            If gridProviderDetail.Rows.Count = 0 Then
                '--- Check item provider exist in database
                If IsDupRegisteredProvider(ProviderID, myitemID) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    TxtTotalProItemQTY.Text = Val(TxtTotalProItemQTY.Text) + Val(TxtQuantity.Text)
                Else
                    MessageBox.Show("Item's provider already registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                '--- Check add duplicate item provider
                If IsDupValidateProvider(obj, ProviderID) = False Then
                    '--- Check item provider exist in database
                    If IsDupRegisteredProvider(ProviderID, myitemID) = False Then
                        gridProviderDetail.Rows.Add(obj)
                        TxtTotalProItemQTY.Text = Val(TxtTotalProItemQTY.Text) + Val(TxtQuantity.Text)
                    Else
                        MessageBox.Show("Item's provider already registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
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

    Function IsDupRegisteredProvider(ByVal pProviderID As Integer, ByVal pItemID As Integer) As Boolean

        Try
            Dim THIDataContext As New BaseDataContext
            Dim q = From TItemProvider In THIDataContext.getTHIDataContext.tblVendorItemSupplyStatus Where TItemProvider.VendorID = pProviderID And TItemProvider.ItemID = pItemID
            If q.ToList.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error function IsDupRegisteredProvider :" & ex.Message)
        End Try

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ValidateTextField(TxtUnitsInStock, "", ErrorProvider) = False Then Exit Sub

        If MessageBox.Show("Do you want save item provider information ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            '--- Insert to tblVendorItemSupplyStatus
            Dim THIDataContext As New BaseDataContext
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Implement business update transaction
                With gridProviderDetail
                    For Each rRow As DataGridViewRow In .Rows
                        Dim TItemProvider As New tblVendorItemSupplyStatus
                        TItemProvider.VendorID = Val(rRow.Cells("ProviderID").Value)
                        TItemProvider.ItemID = myitemID
                        TItemProvider.Cost = Val(rRow.Cells("Cost").Value)
                        TItemProvider.CurrencyID = Val(rRow.Cells("CurrencyID").Value)
                        TItemProvider.Quantity = Val(rRow.Cells("Quantity").Value)
                        TItemProvider.Sell = Val(rRow.Cells("Sell").Value)
                        TItemProvider.Free = Val(rRow.Cells("Free").Value)

                        THIDataContext.getTHIDataContext.tblVendorItemSupplyStatus.InsertOnSubmit(TItemProvider)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                End With

                '--- Update field UnitsInStock of Item
                Dim q = From MainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where MainStock.ItemID = myitemID
                Dim TMainStock As tblCentralInventory = q.SingleOrDefault
                TMainStock.UnitsInStock = TMainStock.UnitsInStock + Val(TxtTotalProItemQTY.Text)
                THIDataContext.getTHIDataContext.SubmitChanges()

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()
                '--- Message batch transaction successfully

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MsgBox("Error : " & ex.Message)
            Finally
                trans = Nothing
            End Try
            MessageBox.Show("Save item provider successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        With gridProviderDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete selected provider ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    TxtTotalProItemQTY.Text = Val(TxtTotalProItemQTY.Text) - Val(rRow.Cells("Quantity").Value)
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub TxtSellQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSellQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtFreeQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFreeQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtSellQty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSellQty.Leave
        If TxtSellQty.Text <> "" Then
            If Val(TxtSellQty.Text) > Val(TxtQuantity.Text) Then
                MessageBox.Show("Sell quantity cannot exceed Source quantity", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtSellQty.Focus()
            End If
        End If
    End Sub

    Private Sub TxtSellQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSellQty.TextChanged
        CalcuFreeQty()
    End Sub

    Sub CalcuFreeQty()
        If RbVendor.Checked = True Then
            TxtFreeQty.Text = Val(TxtQuantity.Text) - Val(TxtSellQty.Text)
        End If
    End Sub

End Class