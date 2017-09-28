Imports System.Data.Common

Public Class frmAdjustStock

    Public adjustItemID As Integer
    Public adjustItemName As String
    Public adjustBarcode As String
    Public isAdjustExistItem As Boolean
    Dim itemRepo As IItem = New Item
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository    
    Dim DepartStockDataAdapter As DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DepartStockDataAdapter = New DSDepartmentStockTableAdapters.VAdjustStockHistoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If ValidateTextField(txtBarcode, "Container name", ErrorAdjustStock) = False _
        Or ValidateTextField(txtItemName, "Item name", ErrorAdjustStock) = False _
        Or ValidateTextField(txtDifferent, "", ErrorAdjustStock) = False Then
            Exit Sub
        End If

        Dim THIDataContextForAdjustment As New BaseDataContext

        If txtDifferent.Text = "" Then
            MessageBox.Show("Please input different item quantity item for adjustment.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If IsNumeric(txtDifferent.Text) = False Then
            MessageBox.Show("Please input different item quantity item for adjustment in numeric.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtNewQtyInStock.Text = "" Then
            MessageBox.Show("New quantity in stock is require, Please enter new quantity in stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If rtbComment.Text = "" Then
            MessageBox.Show("Please specify comment for adjustment particular item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If txtItemName.Text <> "" Then
            If MessageBox.Show("Do you want adjust quantity of item: " & txtItemName.Text & " ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                THIDataContextForAdjustment.getTHIDataContext.Connection.Close()
                THIDataContextForAdjustment.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContextForAdjustment.getTHIDataContext.Connection.BeginTransaction
                THIDataContextForAdjustment.getTHIDataContext.Transaction = trans

                Dim myAdjustRecord As New tblAdjustStockHistory
                Try
                    myAdjustRecord.ItemID = Val(LblItemID.Text)
                    myAdjustRecord.DepartID = CInt(DEPART_ID)
                    myAdjustRecord.AdjustDate = GetDateServer()
                    myAdjustRecord.CurrentQty = Val(txtCurQtyInStock.Text)
                    myAdjustRecord.NewQty = Val(txtNewQtyInStock.Text)
                    myAdjustRecord.Difference = Val(txtDifferent.Text)
                    myAdjustRecord.UserID = CInt(USER_ID)
                    myAdjustRecord.Comment = rtbComment.Text
                    myAdjustRecord.IsApproval = False

                    '*** Insert adjustment record to table tblAdjustStockHis
                    THIDataContextForAdjustment.getTHIDataContext.tblAdjustStockHistories.InsertOnSubmit(myAdjustRecord)

                    THIDataContextForAdjustment.getTHIDataContext.SubmitChanges()
                    trans.Commit()
                    THIDataContextForAdjustment.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()
                    THIDataContextForAdjustment.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("Adjustment submitted successfully, Waiting for Approval !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepartID(CInt(DEPART_ID))
                gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), CInt(LblItemID.Text))

                ClearMe()

            End If
        End If

        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Sub ClearMe()

        txtBarcode.Text = ""
        txtItemName.Text = ""
        txtCurQtyInStock.Text = ""
        txtNewQtyInStock.Text = ""
        txtDifferent.Text = ""
        rtbComment.Text = ""

    End Sub

    Private Sub frmAdjustStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Adjust particular item
        'If isAdjustExistItem = True Then
        lbDepartName.Text = "Adjust Stock In Department: " & DEPART_NAME

        'Load info item to adjust in main stock
        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then

            txtItemName.Text = adjustItemName
            txtBarcode.Text = adjustBarcode
            txtCurQtyInStock.Text = itemRepo.GetItemUnitInStockMain(adjustItemID)
            txtNewQtyInStock.Text = "0"
            LblItemID.Text = adjustItemID

            'GetAdjustmentDataByDepatIDAndItemID
            'gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepartID(CInt(DEPART_ID))
            gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), adjustItemID)

        Else 'Load info item to adjust in Department Stock

            txtItemName.Text = adjustItemName
            txtBarcode.Text = adjustBarcode
            txtCurQtyInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), adjustItemID)
            txtNewQtyInStock.Text = "0"
            LblItemID.Text = adjustItemID

            ' initail grid Adjustment History
            'gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepartID(CInt(DEPART_ID))
            gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), adjustItemID)

        End If

        'End If
    End Sub

    Private Sub txtNewQtyInStock_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewQtyInStock.KeyPress
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

    Private Sub txtDifferent_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDifferent.Leave
        If IsNumeric(txtDifferent.Text) Then
            txtNewQtyInStock.Text = Val(txtCurQtyInStock.Text) + Val(txtDifferent.Text)
        End If
    End Sub

    'Private Sub txtBarcode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.Leave

    '    txtNewQtyInStock.Text = ""

    '    If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
    '        If txtBarcode.Text <> "" Then
    '            ' Check valid item barcode
    '            If itemRepo.isValidItemBarcode(txtBarcode.Text) Then
    '                'In case Barcode of item exist in database
    '                Dim mytblItem As tblItem = itemRepo.GetItemByBarcode(txtBarcode.Text)
    '                LblItemID.Text = mytblItem.ItemID
    '                txtItemName.Text = mytblItem.ItemName
    '                txtCurQtyInStock.Text = itemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

    '                gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), CInt(mytblItem.ItemID))

    '            Else
    '                MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                txtBarcode.Focus()
    '            End If
    '        End If

    '    Else

    '        If txtBarcode.Text <> "" Then
    '            If itemRepo.isValidItemBarcode(txtBarcode.Text) Then

    '                Dim mytblItem As tblItem = itemRepo.GetItemByBarcode(txtBarcode.Text)
    '                LblItemID.Text = mytblItem.ItemID
    '                ' Check item is exist in department stock 
    '                If DepartStockRepo.isItemExistInDepartStock(CInt(DEPART_ID), Val(LblItemID.Text)) Then
    '                    txtItemName.Text = mytblItem.ItemName
    '                    txtCurQtyInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), Val(LblItemID.Text))

    '                    gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), CInt(mytblItem.ItemID))

    '                Else
    '                    MessageBox.Show("Item does not exist in department", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    txtBarcode.Focus()
    '                End If

    '            Else
    '                MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                txtBarcode.Focus()
    '            End If

    '        End If
    '    End If

    'End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNewQtyInStock.Text = ""

            If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                If txtBarcode.Text <> "" Then
                    ' Check valid item barcode
                    If itemRepo.isValidItemBarcode(txtBarcode.Text) Then
                        'In case Barcode of item exist in database
                        Dim mytblItem As tblItem = itemRepo.GetItemByBarcode(txtBarcode.Text)
                        LblItemID.Text = mytblItem.ItemID
                        txtItemName.Text = mytblItem.ItemName
                        txtCurQtyInStock.Text = itemRepo.GetItemUnitInStockMain(Val(LblItemID.Text))

                        gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), CInt(mytblItem.ItemID))

                    Else
                        MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBarcode.Focus()
                    End If
                End If

            Else

                If txtBarcode.Text <> "" Then
                    If itemRepo.isValidItemBarcode(txtBarcode.Text) Then

                        Dim mytblItem As tblItem = itemRepo.GetItemByBarcode(txtBarcode.Text)
                        LblItemID.Text = mytblItem.ItemID
                        ' Check item is exist in department stock 
                        If DepartStockRepo.isItemExistInDepartStock(CInt(DEPART_ID), Val(LblItemID.Text)) Then
                            txtItemName.Text = mytblItem.ItemName
                            txtCurQtyInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), Val(LblItemID.Text))

                            gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepatIDAndItemID(CInt(DEPART_ID), CInt(mytblItem.ItemID))

                        Else
                            MessageBox.Show("Item does not exist in department", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtBarcode.Focus()
                        End If

                    Else
                        MessageBox.Show("Invalid item Barcode", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBarcode.Focus()
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub BtnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowAll.Click
        gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataByDepartID(CInt(DEPART_ID))
    End Sub

    Private Sub BtnShowCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowCurrent.Click
        gridAdjustmentHistory.DataSource = DepartStockDataAdapter.GetAdjustmentDataCurDateByDepartID(CInt(DEPART_ID), GetDateServer.Date)
    End Sub

End Class