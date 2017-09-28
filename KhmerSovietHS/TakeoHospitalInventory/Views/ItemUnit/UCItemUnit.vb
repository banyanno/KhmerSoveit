Imports Janus.Windows.GridEX

Public Class UCItemUnit

    Dim ItemUnitDataAdapter As DSItemUnitTableAdapters.tblItemUnitTableAdapter
    Dim itemUnitRepo As IItemUnitRepository = New ItemUnitRepository


    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FItemUnit As New frmItemUnit(Me)
        FItemUnit.ShowDialog()
        FItemUnit.Close()
        FItemUnit.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not gridItemUnit.CurrentRow Is Nothing AndAlso gridItemUnit.CurrentRow.RowType = RowType.Record Then
            Dim FItemUnit As New frmItemUnit(Me)
            FItemUnit.lblSaveOption.Text = "1"
            FItemUnit.itemUnitID = gridItemUnit.GetValue("ItemUnitID")
            FItemUnit.ShowDialog()
            FItemUnit.Close()
            FItemUnit.Dispose()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim itemUnit As New tblItemUnit
        Dim itemUnitTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete Item Unit ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Not gridItemUnit.CurrentRow Is Nothing AndAlso gridItemUnit.CurrentRow.RowType = RowType.Record Then

                itemUnit = itemUnitRepo.GetItemUnitByID(gridItemUnit.GetValue("ItemUnitID"))
                itemUnitTransMsgStatus = itemUnitRepo.DeleteItemUnit(itemUnit)

                If itemUnitTransMsgStatus <> "True" Then
                    MsgBox("Error delete Item Unit .", MsgBoxStyle.Critical, "Error : " & itemUnitTransMsgStatus)
                Else
                    MessageBox.Show("Delete ItemUnit successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BindIntoDataGrid()
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        BindIntoDataGrid()
    End Sub
    Public Sub BindIntoDataGrid()
        gridItemUnit.DataSource = ItemUnitDataAdapter.GetData
    End Sub
    Public Sub FillDataByItemUnitName(ByVal pItemUnitName As String)
        gridItemUnit.DataSource = ItemUnitDataAdapter.GetDataByItemUnitName(pItemUnitName)
    End Sub

    Private Sub UCItemUnit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindIntoDataGrid()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ItemUnitDataAdapter = New DSItemUnitTableAdapters.tblItemUnitTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gridItemUnit.DataSource = ItemUnitDataAdapter.GetDataBySearchItemUnitName("%" & txtSItemUnitName.Text & "%")
    End Sub
End Class
