Public Class frmAddDrug


    Dim ItemUnitDataAdapter As DSItemUnitTableAdapters.tblItemUnitTableAdapter    
    Dim MedicineDataAdapter As DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Dim ContainerDataAdapter As DSContainerTableAdapters.tblContainerTableAdapter
    Dim LabourDataAdapter As DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
    Dim DACheckItemStock As New DSPharmacyTableAdapters.VPRESCRIP_CHECK_STOCKTableAdapter
    Dim FNewPrescription As frmPrescription


    Private Sub frmAddDrug_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ItemUnitDataAdapter = New DSItemUnitTableAdapters.tblItemUnitTableAdapter
        'MedicineDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListTableAdapter
        MedicineDataAdapter = New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        '--- Initial ItemUnit
        With cbItemUnit
            .DataSource = ItemUnitDataAdapter.GetData
            .ValueMember = "ItemUnitID"
            .DisplayMember = "ItemUnitName"
            '.SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With

        '--- Initial Medicine in Hospital
        With CboItemName
            .DataSource = MedicineDataAdapter.GetItemDataByDepartID(PHARMACY_DEPART_ID)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"

            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        With CboOpticalShop
            .DataSource = MedicineDataAdapter.GetItemDataByDepartID(OPTICALSHOP_DEPART_ID)
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = -1
        End With
        '--- Initial Remark
        With cbRemark
            .Items.Add("Free In Pharmacy")
            .Items.Add("Outside-Purchase")
            .Items.Add("Item In Optical-Shop")
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0
        End With


        With cbItemContainer
            .DataSource = ContainerDataAdapter.GetData
            .ValueMember = "ContainerID"
            .DisplayMember = "ContainerName"
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

        cbRemark.Enabled = False
        '---
        TxtItemName.Enabled = False

    End Sub

    Private Sub RbDrugInHos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDrugInHos.CheckedChanged
        If RbDrugInHos.Checked Then
            Try
                CboItemName.Enabled = True
                cbRemark.SelectedIndex = 0
                CboOpticalShop.SelectedIndex = -1
                CboOpticalShop.Enabled = False
                GroupMedicineInfo.Enabled = False
            Catch ex As Exception

            End Try
           
        End If
        'ElseIf RbDrugOutsideHos.Checked Then
        '    CboItemName.Enabled = False
        '    CboItemName.SelectedIndex = -1
        '    CboOpticalShop.SelectedIndex = -1
        '    CboOpticalShop.Enabled = False
        '    TxtItemName.Enabled = True
        '    GroupMedicineInfo.Enabled = True
        'ElseIf RadItemInOpticalShop.Checked = True Then
        '    CboOpticalShop.SelectedIndex = -1
        '    CboOpticalShop.Enabled = True
        '    CboItemName.Enabled = False
        '    CboItemName.SelectedIndex = -1
        '    GroupMedicineInfo.Enabled = False
        'End If
    End Sub

    Private Sub RbDrugOutsideHos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbDrugOutsideHos.CheckedChanged
        If RbDrugOutsideHos.Checked Then
            CboItemName.Enabled = False
            TxtItemName.Enabled = True
            cbRemark.SelectedIndex = 1
            CboOpticalShop.SelectedIndex = -1
            CboOpticalShop.Enabled = False
            GroupMedicineInfo.Enabled = True
        End If
    End Sub

    Private Sub frmAddDrug_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F1 Then
            CleanMedicine()
            RbDrugInHos.Focus()
        ElseIf e.KeyCode = Keys.F2 Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddItem()
        End If

    End Sub

    Private Sub cbRemark_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbRemark.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddItem()
        End If
    End Sub

    Sub AddItem()
        If RbDrugOutsideHos.Checked = True Then
            If ValidateTextField(TxtItemName, "", ErroAddMedicine) = False Then Exit Sub
        End If
        If RbDrugInHos.Checked = True Then
            If ValidateCombobox(CboItemName, "", ErroAddMedicine) = False Then Exit Sub
        End If
        If RadItemInOpticalShop.Checked = True Then
            If ValidateCombobox(CboOpticalShop, "", ErroAddMedicine) = False Then Exit Sub
        End If
        If ValidateTextField(TxtQuantity, "", ErroAddMedicine) = False Then Exit Sub

        If RbDrugInHos.Checked = True Then
            If Val(TxtQuantity.Text) > Val(TxtUnitsInStock.Text) Then
                MessageBox.Show("Item quantity cannot greater than quantity present in stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If MessageBox.Show("Do you want to add this medicine ?", "medicine", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If RbDrugInHos.Checked = True Then
                Me.FNewPrescription.AddMedicineDetail(CboItemName.SelectedValue, CboItemName.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 1, cbRemark.Text, 0, 0)
            End If

            If RbDrugOutsideHos.Checked = True Then
                Me.FNewPrescription.AddMedicineDetail(0, TxtItemName.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 0, cbRemark.Text, cbItemContainer.SelectedValue, cbLabourFac.SelectedValue)
            End If

            If RadItemInOpticalShop.Checked = True Then
                Me.FNewPrescription.AddMedicineDetail(CboOpticalShop.SelectedValue, CboOpticalShop.Text, cbItemUnit.SelectedValue, CInt(TxtQuantity.Text), 2, cbRemark.Text, 0, 0)
            End If
            CleanMedicine()
            RbDrugInHos.Focus()
        End If

    End Sub
    Sub CleanMedicine()
        Try
            CboItemName.SelectedIndex = -1
            TxtItemName.Text = ""
            cbItemUnit.SelectedIndex = -1
            TxtQuantity.Text = ""
            cbRemark.SelectedIndex = 0
        Catch ex As Exception
            CboItemName.SelectedIndex = -1
            TxtQuantity.Text = ""
        End Try
        
    End Sub

    Public Sub New(ByVal FNewPrescrip As frmPrescription)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        FNewPrescription = FNewPrescrip
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub TxtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQuantity.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboItemName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboItemName.SelectedValueChanged
        Dim TotalItem As Integer = 0
        Dim CurrentStock As Integer = 0
        Try
            TotalItem = DACheckItemStock.SelectTotalQTYItem(CboItemName.SelectedValue)
        Catch ex As Exception

        End Try
        Try

            CurrentStock = (DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), CInt(CboItemName.SelectedValue)))

        Catch ex As Exception
        End Try
        TxtUnitsInStock.Text = CurrentStock - TotalItem
    End Sub
   
    Private Sub RadItemInOpticalShop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadItemInOpticalShop.CheckedChanged
        CboOpticalShop.Enabled = True
        CboOpticalShop.SelectedIndex = -1
        cbRemark.SelectedIndex = 2
        CboItemName.SelectedIndex = -1
        CboItemName.Enabled = False
        GroupMedicineInfo.Enabled = False
    End Sub
End Class