Public Class frmItemUnit
    Dim itemUnitRepo As IItemUnitRepository = New ItemUnitRepository
    Public isItemUnitClose As Boolean = False
    Public itemUnitID As Integer = 0
    Dim UItemUnit As UCItemUnit
    Dim isNewChemicalFromItemForm As Boolean



    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim itemUnit As New tblItemUnit

        Dim itemUnitTransMsgStatus As String
        ' Validation
        If ValidateTextField(txtItemUnitName, "Item unit name", ErrorItemUnit) = False Then
            Exit Sub
        End If

        If UCase(txtTempItemUnitName.Text) <> UCase(txtItemUnitName.Text) Then
            If itemUnitRepo.isUnitItemExistSearchByUnitItemName(txtItemUnitName.Text) Then
                MsgBox("Item Unit name already exist.")
                Exit Sub
            End If
        End If
        '===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new ItemUnit ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                itemUnit.ItemUnitName = txtItemUnitName.Text
                itemUnitTransMsgStatus = itemUnitRepo.CreateItemUnit(itemUnit)
                'MsgBox("KKDKDK :" & itemUnit.ItemUnitID)

                If itemUnitTransMsgStatus <> "True" Then
                    MsgBox("Error save ItemUnit.", MsgBoxStyle.Critical, "Error : " & itemUnitTransMsgStatus)
                Else
                    MessageBox.Show("Save new ItemUnit successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If isNewChemicalFromItemForm = False Then
                        UItemUnit.FillDataByItemUnitName(txtItemUnitName.Text)
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If

            End If
        Else ' Update item unit to database
            If itemUnitID = 0 Then ' get item unit attempt to update
                MsgBox("Invalid ItemUnit ID.")
                Exit Sub
            End If
            itemUnit = itemUnitRepo.GetItemUnitByID(itemUnitID)
            itemUnit.ItemUnitName = txtItemUnitName.Text
            itemUnitTransMsgStatus = itemUnitRepo.UpdateItemUnit

            If itemUnitTransMsgStatus <> "True" Then
                MsgBox("Error update ItemUnit.", MsgBoxStyle.Critical, "Error : " & itemUnitTransMsgStatus)
            Else
                UItemUnit.FillDataByItemUnitName(txtItemUnitName.Text)
                Me.Close()
            End If

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        isItemUnitClose = False
        Me.Close()
    End Sub

    Private Sub frmItemUnit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim itemUnit As New tblItemUnit
        ' query data from database (update mode)
        If itemUnitID <> 0 And lblSaveOption.Text <> "0" Then
            itemUnit = itemUnitRepo.GetItemUnitByID(itemUnitID)
            txtItemUnitID.Text = itemUnit.ItemUnitID
            txtItemUnitName.Text = itemUnit.ItemUnitName
            txtTempItemUnitName.Text = itemUnit.ItemUnitName
        Else
            txtItemUnitID.Text = itemUnitRepo.GenerateItemUnitID
        End If

    End Sub

    Public Sub New(ByVal mainItemUnit As UCItemUnit)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UItemUnit = mainItemUnit
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        isNewChemicalFromItemForm = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class