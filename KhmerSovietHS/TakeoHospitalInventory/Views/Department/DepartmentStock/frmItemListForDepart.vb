Imports Janus.Windows.GridEX
Imports System.Data.Common

Public Class frmItemListForDepart

    Dim DepartmentStockDataAdapter1 As New DSDepartmentStockTableAdapters.VItemListDepartPermissionTableAdapter
    Dim VItemInDep As New DSDepartmentStockTableAdapters.VItemListInDepartTableAdapter
    Dim DepartmentStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Dim InitailItemDataTable As DataTable = New DSDepartmentStock.InitialItemDTDataTable




    Private Sub frmItemListForDepart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        
        'Try

        'Dim myDepartItemDT As New DataTable

        'Dim myItemAvailableForDepartDT As DataTable = DepartmentStockDataAdapter.GetListItemAvailableForDepart(DEPART_ID)
        'Dim myDepartItemDT As DataTable = VItemInDepartDataAdapter.GetItemDataByDepartID(DEPART_ID)
        'Dim Key(1) As DataColumn
        'Key(0) = myItemAvailableForDepartDT.Columns(
        ''myItemAvailableForDepartDT.PrimaryKey = New DataColumn() {myItemAvailableForDepartDT.Columns(0)} '--- Set PrimaryKey
        'myItemAvailableForDepartDT.PrimaryKey = Key

        'MsgBox(myItemAvailableForDepartDT.Rows.Count)
        'MsgBox(myDepartItemDT.Rows.Count)

        'For Each row1 As DataRow In myItemAvailableForDepartDT.Rows
        '    MsgBox(row1("ItemID"))
        'Next

        'For Each row As DataRow In myDepartItemDT.Rows
        '    'Try
        '    MsgBox(row("ItemID"))
        '    'myItemAvailableForDepartDT.Rows.Find(row("ItemID").ToString).Delete()
        '    'MsgBox(myItemAvailableForDepartDT.Rows.Find(row("ItemID")).Item(0).ToString)
        '    'Catch ex As Exception

        '    'End Try

        'Next
       


        GridItemAvailable.DataSource = DepartmentStockDataAdapter1.GetListItemAvailableForDepart(DEPART_ID)

        'Catch ex As Exception
        '    MsgBox("Error item permission " & ex.Message)
        'End Try

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtAlertQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        Dim isTransSuccess As Boolean = True
        Dim countNewItemRegister As Integer = 0
        For Each rRow As Janus.Windows.GridEX.GridEXRow In gridItemInDepart.GetRows()
            '*** check department stock already have item             
            Dim isItemExistInDepartStock As Boolean
            Dim myitemID As Integer = CInt(rRow.Cells("itemID").Value)
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                Dim q = (From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = myitemID Select departStock.ItemID).Count()
                If q Then
                    isItemExistInDepartStock = True
                Else
                    isItemExistInDepartStock = False
                End If
                ' Add item to table tblDeptStock
                If isItemExistInDepartStock = False Then
                    Dim myDepartStock As New tblDeptStock
                    myDepartStock.ItemID = myitemID
                    myDepartStock.DepartID = CInt(DEPART_ID)
                    myDepartStock.UnitsInStock = CInt(rRow.Cells("UnitsInStock").Value)
                    myDepartStock.StockAlertQty = CInt(rRow.Cells("StockAlertQty").Value)
                    THIDataContext.getTHIDataContext.tblDeptStocks.InsertOnSubmit(myDepartStock)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    countNewItemRegister = countNewItemRegister + 1
                End If

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                isTransSuccess = False
            Finally
                trans = Nothing
            End Try
            If isTransSuccess = False Then
                MessageBox.Show("Transaction Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)           
            End If

        Next

        If countNewItemRegister = 0 Then
            MessageBox.Show("Transaction not found new item register to department.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Transaction found " & countNewItemRegister & " new item registered to department successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GridItemAvailable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridItemAvailable.DoubleClick
        '--- Check item user attempt to register does not exist in Department Stock
        If Not GridItemAvailable.CurrentRow Is Nothing AndAlso GridItemAvailable.CurrentRow.RowType = RowType.Record Then

            Dim itemQTY As Integer = 0
            Dim itemAlertQTY As Integer = 0

            Dim frm As New frmInpuItemQty
            frm.myItemName = GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemName").Value
            Dim myitemID As Integer = CInt(GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemID").Value)

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frm.IsCancelProcess = True Then
                    Exit Sub
                End If
                itemQTY = frm.myItemQTY
                itemAlertQTY = frm.myItemAlertQTY
            End If

            Try

                Dim NewDr As DataRow = InitailItemDataTable.NewRow
                NewDr("ItemID") = myitemID
                NewDr("Barcode") = GridItemAvailable.SelectedItems(0).GetRow.Cells("Barcode").Value
                NewDr("ItemName") = GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemName").Value
                NewDr("ItemQTY") = itemQTY
                NewDr("itemAlertQTY") = itemAlertQTY
                InitailItemDataTable.Rows.Add(NewDr)

                gridItemInDepart.DataSource = InitailItemDataTable

            Catch ex As Exception
                MessageBox.Show("The selected item already added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Please select item in the list that you want to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        '--- Check item user attempt to register does not exist in Department Stock
        If Not GridItemAvailable.CurrentRow Is Nothing AndAlso GridItemAvailable.CurrentRow.RowType = RowType.Record Then

            Dim itemQTY As Integer = 0
            Dim itemAlertQTY As Integer = 0

            Dim frm As New frmInpuItemQty
            frm.myItemName = GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemName").Value
            Dim myitemID As Integer = CInt(GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemID").Value)

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If frm.IsCancelProcess = True Then
                    Exit Sub
                End If
                itemQTY = frm.myItemQTY
                itemAlertQTY = frm.myItemAlertQTY
            End If

            Try

                Dim NewDr As DataRow = InitailItemDataTable.NewRow
                NewDr("ItemID") = myitemID
                NewDr("Barcode") = GridItemAvailable.SelectedItems(0).GetRow.Cells("Barcode").Value
                NewDr("ItemName") = GridItemAvailable.SelectedItems(0).GetRow.Cells("ItemName").Value
                NewDr("ItemQTY") = itemQTY
                NewDr("itemAlertQTY") = itemAlertQTY
                InitailItemDataTable.Rows.Add(NewDr)

                gridItemInDepart.DataSource = InitailItemDataTable

            Catch ex As Exception
                MessageBox.Show("The selected item already added.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Else
            MessageBox.Show("Please select item in the list that you want to add.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        If Not gridItemInDepart.CurrentRow Is Nothing AndAlso gridItemInDepart.CurrentRow.RowType = RowType.Record Then
            '--- Find and Delete item in grid
            Dim ItemID As String = gridItemInDepart.GetValue("ItemID")
            InitailItemDataTable.Rows.Find(ItemID).Delete()

            gridItemInDepart.DataSource = InitailItemDataTable

        End If


    End Sub

End Class