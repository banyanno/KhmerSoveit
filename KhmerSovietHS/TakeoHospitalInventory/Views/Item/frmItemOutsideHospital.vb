Imports System.Data.Common

Public Class frmItemOutsideHospital

    Dim MainAddItemNotExistInHos As UCMedicineOutsideHospital
    Private THIDataContext As New BaseDataContext
    Dim ContainerDataAdapter As DSContainerTableAdapters.tblContainerTableAdapter
    Dim LabourDataAdapter As DSLabourFacTableAdapters.tblLabourFactoryTableAdapter

    Public ID As Double


    Public Sub New(ByVal pMain As UCMedicineOutsideHospital)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        MainAddItemNotExistInHos = pMain
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Validation
        If ValidateTextField(TxtItemName, "Container name", ErrorItemOutsideHospital) = False Then
            Exit Sub
        End If

        '--- Validate Item name Already exist
        Dim myItemOutside = From IOS In THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies Where IOS.ItemName.ToUpper = TxtItemName.Text.ToUpper
        If myItemOutside.ToList.Count <> 0 Then
            MessageBox.Show("Item name already registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want to create new item outside hospital?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    Dim ItemOutside As New ITEM_OUTSIDE_INVENTORY
                    ItemOutside.ItemName = TxtItemName.Text
                    ItemOutside.DepartID = CInt(DEPART_ID)
                    ItemOutside.IsRegistered = False
                    ItemOutside.ContainerID = cbItemContainer.SelectedValue
                    ItemOutside.LabourFacID = cbLabourFac.SelectedValue
                    ItemOutside.Quantity = 0
                    ItemOutside.RegisterDate = GetDateServer()

                    THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies.InsertOnSubmit(ItemOutside)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MessageBox.Show("Add new item successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MainAddItemNotExistInHos.FillDataByItemName(TxtItemName.Text)

                    'Me.Close()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Catch ex As Exception
                    
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing
                End Try

            End If
        Else
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try

                Dim TemItemOutsideHos = From query In THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies Where query.ItemID = ID
                Dim ItemOutside As ITEM_OUTSIDE_INVENTORY = TemItemOutsideHos.SingleOrDefault

                ItemOutside.ItemName = TxtItemName.Text
                ItemOutside.ContainerID = cbItemContainer.SelectedValue
                ItemOutside.LabourFacID = cbLabourFac.SelectedValue
                ItemOutside.DepartID = CInt(DEPART_ID)


                THIDataContext.getTHIDataContext.SubmitChanges()

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()
                MessageBox.Show("Save successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MainAddItemNotExistInHos.FillDataByItemName(TxtItemName.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                trans = Nothing
            End Try
        End If

    End Sub

    Private Sub frmItemOutsideHospital_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LbDepartName.Text = DEPART_NAME
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

        If lblSaveOption.Text <> "0" Then

            Dim TemItemOutsideHos = From query In THIDataContext.getTHIDataContext.ITEM_OUTSIDE_INVENTORies Where query.ItemID = ID
            Dim ItemOutside As ITEM_OUTSIDE_INVENTORY = TemItemOutsideHos.SingleOrDefault

            If ItemOutside.ContainerID IsNot Nothing Then cbItemContainer.SelectedValue = ItemOutside.ContainerID
            If ItemOutside.LabourFacID IsNot Nothing Then cbLabourFac.SelectedValue = ItemOutside.LabourFacID

        End If

    End Sub

    
End Class