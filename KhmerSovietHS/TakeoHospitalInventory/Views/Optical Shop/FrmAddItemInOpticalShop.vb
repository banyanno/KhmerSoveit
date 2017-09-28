Imports System.Math
Public Class FrmAddItemInOpticalShop
    Dim DA_Item_Tem As New DSOpticalShopTableAdapters.V_ITEM_OPT_TEMTableAdapter
    Dim ValueOfBarcode As String
    Dim ValQTY As String
    Dim FNewReceipt As FrmNewReceipt
    'Dim FNewReceiptNil As FrmNewReceiptNil
    Private ItemPrice As New DSItemPriceTableAdapters.VItemPriceOpticalShopTableAdapter
    Dim DAIncomeType As New DSOpticalShopTableAdapters.INCOME_TYPETableAdapter
    Dim ImageStream As System.IO.MemoryStream
    Dim IsDolar As Boolean = True
    Public IsPaymentNil As Boolean = False
    'Dim itemRepo As IItem = New Item
    Dim itemDepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Public Rate As Double

    'Sub New(ByVal FNewReceiptNil As FrmNewReceiptNil)
    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()
    '    Me.FNewReceiptNil = FNewReceiptNil
    '    ' Add any initialization after the InitializeComponent() call.
    'End Sub
    Sub New(ByVal FNewReceipt As FrmNewReceipt)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FNewReceipt = FNewReceipt
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub FrmAddItemInOpticalShop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddItem()
        End If
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Sub CleanItem()

        'TxtItemBarcode.Text = ""
        LblItemID.Text = ""
        TxtItemName.Text = ""
        TxtItemPrice.Text = ""
        TxtItemQTY.Text = ""
        TxtUnitInstock.Text = ""
        LblPrice.Text = "Item Price:*"
        PictItem.Visible = False
    End Sub
    Sub AddItem()

        If ValidateTextField(TxtBarcode, "", ErrReceipt) = False Then Exit Sub
        If ValidateTextField(TxtItemName, "", ErrReceipt) = False Then Exit Sub
        If ValidateTextField(TxtItemPrice, "You don't have permision enter price. Please contact maint inventory to enter price of item.", ErrReceipt) = False Then Exit Sub
        If ValidateTextField(TxtItemQTY, "", ErrReceipt) = False Then Exit Sub

        '--- Validate item unit in department stock
        'Dim TblDepartStock As New tblDeptStock
        'TblDepartStock = itemDepartStockRepo.GetDepartStockByDepartIDAndItemID(OPTICALSHOP_DEPART_ID, CInt(LblItemID.Text))
        If CInt(TxtUnitInstock.Text) < CInt(TxtItemQTY.Text) Then
            MessageBox.Show("Item sale quantity must not be exceed than item in department's stock", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Do you want to add this item?", "Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim SubTotalR As Double
            Dim SubTotalD As Double
            If IsDolar = True Then
                SubTotalR = Round((Val(TxtItemPrice.Text) * Val(Rate)) * Val(TxtItemQTY.Text))
                'Calculate for Dolar
                SubTotalD = Round(Val(TxtItemPrice.Text) * Val(TxtItemQTY.Text), 2)
            Else
                SubTotalR = Math.Round(Val(TxtItemPrice.Text) * Val(TxtItemQTY.Text))
                SubTotalD = Round((Val(TxtItemPrice.Text) / Val(Rate)) * Val(TxtItemQTY.Text), 2)
            End If

            If IsPaymentNil = True Then
                'SubTotalR = 0
                'SubTotalD = 0
                Me.FNewReceipt.AddItemDetial(LblItemID.Text, TxtBarcode.Text, TxtItemName.Text, TxtItemPrice.Text, TxtItemQTY.Text, Nothing, SubTotalR, SubTotalD)
            Else
                Me.FNewReceipt.AddItemDetial(LblItemID.Text, TxtBarcode.Text, TxtItemName.Text, TxtItemPrice.Text, TxtItemQTY.Text, Nothing, SubTotalR, SubTotalD)
            End If
            CleanItem()
            TxtBarcode.Text = ""
            TxtBarcode.Focus()
            'Me.Close()

        End If

    End Sub
    Sub SearchItemByBarcode(ByVal ItemCodeNo As String)
        Dim TblTemItem As DataTable = ItemPrice.GetDataByBarcode(ItemCodeNo, DEPART_ID) '  ItemOpticalshop.GetDataByBarcode(TxtItemBarcode.Text)
        If TblTemItem.Rows.Count <= 0 Then
            'CboBarcode.Focus()
            MessageBox.Show("Can not find ItemNo In System. Could you check item No again.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            CleanItem()
            Exit Sub
        Else
            For Each row As DataRow In TblTemItem.Rows
                LblItemID.Text = row("ItemID")
                TxtItemName.Text = row("ItemName")
                Dim TblDepartStock As New tblDeptStock
                TblDepartStock = itemDepartStockRepo.GetDepartStockByDepartIDAndItemID(OPTICALSHOP_DEPART_ID, CInt(LblItemID.Text))
                Dim QTYTem As Integer = 0
                For Each DROW As DataRow In DA_Item_Tem.GetDataByItemID(LblItemID.Text).Rows
                    QTYTem = QTYTem + CInt(DROW("ItemQTY"))
                Next

                TxtUnitInstock.Text = TblDepartStock.UnitsInStock - QTYTem
                If TypeOf row("IsKHR") Is DBNull Then

                Else

                    If row("IsKHR") = True Then
                        '' Exchange rate when Item price In Khmer
                        If TypeOf row("Price") Is DBNull Then
                            TxtItemPrice.Text = ""
                        Else

                            TxtItemPrice.Text = (row("Price") / GetRates())
                        End If
                    Else
                        '' Exchange rate when Item price In Dolar
                        If TypeOf row("Price") Is DBNull Then
                            TxtItemPrice.Text = ""
                        Else

                            TxtItemPrice.Text = row("Price")
                        End If
                    End If


                End If


                If TypeOf row("Picture") Is DBNull Then
                    PictItem.Visible = False
                Else
                    ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                    PictItem.Visible = True
                    PictItem.Image = Image.FromStream(ImageStream)
                End If

            Next
            TxtItemPrice.Focus()
        End If

    End Sub
    Function  GetRates As Double 
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Return .Rows(0).Item(0)
            End If
        End With
    End Function
    Private Sub CboBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'SearchItemByBarcode(CboBarcode.Text)
    End Sub

    Private Sub TxtItemQTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemQTY.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtItemQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemQTY.KeyPress
        SetDisableKeyString(e)
        'Me.KeyPreview = False        
    End Sub

    Private Sub TxtBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItemByBarcode(TxtBarcode.Text)
        ElseIf e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmAddItemInOpticalShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtItemPrice.Focus()
    End Sub
    Private Sub TxtItemPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtItemQTY.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub

    Private Sub TxtItemPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemPrice.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class