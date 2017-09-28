Imports System.Math
Imports System.Data.Common

Public Class FrmNewReceipt

    Dim MainReceipt As MainOpticalShop
    Const MEDICINCE As String = "Medicince"
    Const SPECTACLE As String = "Spectacle"
    Const SUN_GLASSES As String = "Sun Glasses"
    Const OTHER As String = "Other"
    Dim DTblItemDetial As DataTable = New DSOpticalShop.TemItemDetialDataTable
    Dim DADonation As New DSOpticalShopTableAdapters.DONATIONTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim DaReceipt As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim DaReceiptPrint As New DSOpticalShopTableAdapters.V_Receipt_InvoiceTableAdapter
    Dim DaReceiptDetail As New DSOpticalShopTableAdapters.VReceiptDetailTableAdapter
    Dim DaReceiptCustomer As New DSOpticalShopTableAdapters.RECEIPT_CUSTOMERTableAdapter
    Dim ItemRepo As IItem = New Item
    Dim ValueTotalReal As Double = 0
    Dim valueEyeGlassesReal As Double = 0
    Dim ValueTotalDolar As Double = 0
    Dim ValueEyeGlassesDolar As Double = 0
    Private OpticalDataControl As IOpticalShop = New OpticalshopImp
    Dim FReceiptPrintPreview As New FrmReceiptPrintPreview
    Dim ObjReceiptCry As New CryReceipt
    Dim ObjReceiptCry_V1 As New CryReceipt_V1
    Dim P_Customer As New OpticalshopImp
    Private PARAMETKHMER As String = ""
    Private PARAMETENG As String = ""
    Private ItemPrice As New DSItemPriceTableAdapters.VItemPriceOpticalShopTableAdapter
    Dim ImageStream As System.IO.MemoryStream
    Dim IsPatient As Boolean = False
    Dim MTakeoInventory As MainTakeoInventory
    Public InvoiceNo As String '--- Pass ReceiptNo from MainOpticalShop 
    'LblSaveStatus.Text --> Store ReceiptID from MainOpticalShop
    Private TotalSocial As Double = 0


    Dim DA_Consult_Detail As New DSConsultTableAdapters.V_CONSULTINGTableAdapter
    Dim DS_Consult As New DSConsultTableAdapters.CONSULINGTableAdapter

    Sub New(ByVal MainReceipt As MainOpticalShop)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.MainReceipt = MainReceipt
        InitDonation()
    End Sub
    Sub New(ByVal MTakeoInventory As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MTakeoInventory = MTakeoInventory
        ' Add any initialization after the InitializeComponent() call.
        InitDonation()
    End Sub
    Sub AddItemDetial(ByVal ItemID As Integer, ByVal ItemBarcode As String, ByVal ItemName As String, _
                      ByVal ItemPrice As Double, ByVal ItemQTY As Integer, _
                      ByVal Pic() As Byte, ByVal SubTotalR As Double, ByVal SubTotalD As Double)
        Try
            Dim NewDR As DataRow = Me.DTblItemDetial.NewRow
            NewDR("ColumnItemID") = ItemID
            NewDR("ColumnBarcode") = ItemBarcode
            NewDR("ColumnName") = ItemName
            NewDR("ColumnPrice") = ItemPrice
            NewDR("ColumnQTY") = ItemQTY
            NewDR("SubTotalReal") = SubTotalR
            NewDR("SubTotalDolar") = SubTotalD
            NewDR("Picture") = Pic
            DTblItemDetial.Rows.Add(NewDR)
            GridItemDetail.DataSource = DTblItemDetial

            'this Function Call when we have issue receipt
            CheckCalculatReceipt()

            '--- Refresh Full Amount value in case the new item is added.
            If RadFull.Checked = True Then
                If RadKHR.Checked = True Then
                    TxtFullAmount.Text = TxtTotalAsReal.Text
                End If
                If RadUSD.Checked = True Then
                    TxtFullAmount.Text = TxtTotalAsDolar.Text
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("This Item already exist, could you check againt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub FrmNewReceipt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        GetBarcod()
    End Sub
    Private Sub FrmNewReceipt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If TxtCustomerNo.Text = "" Then
            MessageBox.Show("Please select customer first before add Item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If e.KeyCode = Keys.F1 Then
            'Dim FAddNewItem As New FrmAddItemInOpticalShop(Me)
            'FAddNewItem.ShowDialog()

            Dim FAddNewItem As New FrmAddItemInOpticalShop(Me)
            If RadNil.Checked = True Then
                FAddNewItem.IsPaymentNil = True
            Else
                FAddNewItem.IsPaymentNil = False
            End If
            FAddNewItem.Rate = Val(txtRate.Text)
            FAddNewItem.ShowDialog()
            CheckIsPatientConsult(EmptyString(TxtCustomerNo.Text), "Optical Shop", 0)
        End If
    End Sub
    Sub InitDonation()
        With CboDonation
            .DataSource = DADonation.GetData
            .DisplayMember = "DonationName"
            .ValueMember = "DonationID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If TxtCustomerNo.Text = "" Then
            MessageBox.Show("Please select customer first before add Item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim FAddNewItem As New FrmAddItemInOpticalShop(Me)
        If RadNil.Checked = True Then
            FAddNewItem.IsPaymentNil = True
        Else
            FAddNewItem.IsPaymentNil = False
        End If
        FAddNewItem.Rate = Val(txtRate.Text)
        FAddNewItem.ShowDialog()
        'CheckIsPatientConsult(EmptyString(TxtCustomerNo.Text), "Optical Shop", 0)
    End Sub

    Sub EditItem()
        If MessageBox.Show("Do you want edit this item?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Dim index As Integer = GridItemDetail.CurrentRow.Index
            'TableItemDetial.Rows(index).BeginEdit()
            'TableItemDetial.Rows(index)("ColumnItemID") = TxtItemBarcode.Text
            'TableItemDetial.Rows(index)("ColumnBarcode") = TxtItemBarcode.Text
            'TableItemDetial.Rows(index)("ColumnName") = TxtItemName.Text
            'TableItemDetial.Rows(index)("ColumnPrice") = TxtItemPrice.Text
            'TableItemDetial.Rows(index)("ColumnQTY") = TxtItemQTY.Text
            'If RadMedicine.Checked = True Then
            '    TableItemDetial.Rows(index)("ColumnPaymentType") = RadMedicine.Text
            'End If
            'If RadEyeClasses.Checked = True Then
            '    TableItemDetial.Rows(index)("ColumnPaymentType") = RadEyeClasses.Text
            'End If
            'TableItemDetial.Rows(index).EndEdit()
            'TableItemDetial.AcceptChanges()
            'GridItemDetail.Refresh()
            'GridItemDetail.DataSource = TableItemDetial
            'BtnModifyItem.Enabled = False
        End If
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click

        If GridItemDetail.CurrentRow Is Nothing Then
            MessageBox.Show("Please selected at least one item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If MessageBox.Show("Do you want remove this item?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GridItemDetail.Refresh()
                Dim Index As Integer = GridItemDetail.CurrentRow.Index
                DTblItemDetial.Rows(Index).Delete()
                DTblItemDetial.AcceptChanges()
                CheckCalculatReceipt()

                '--- Refresh value Full Amount
                If RadFull.Checked = True Then
                    If RadKHR.Checked = True Then
                        TxtFullAmount.Text = TxtTotalAsReal.Text
                    End If
                    If RadUSD.Checked = True Then
                        TxtFullAmount.Text = TxtTotalAsDolar.Text
                    End If
                End If

            End If
        End If

    End Sub

    Sub ClearCustomer()
        TxtCustomerID.Text = ""
        TxtCusNameEng.Text = ""
        TxtCustomerName.Text = ""
        TxtCusOccupation.Text = ""
        TxtSex.Text = ""
        TxtAge.Text = ""
        txtAddress.Text = ""
        CheOldPatient.Checked = False
    End Sub
    Sub CalculatReceipAsReal()

        ValueTotalReal = 0
        For Each row As DataRow In DTblItemDetial.Rows
            ValueTotalReal = ValueTotalReal + row("SubTotalReal")
        Next
        TxtTotalAsReal.Text = ValueTotalReal
    End Sub
    Sub CalculateReceiptAsDolar()
        ValueTotalDolar = 0
        For Each row As DataRow In DTblItemDetial.Rows
            ValueTotalDolar = ValueTotalDolar + row("SubTotalDolar")
        Next
        TxtTotalAsDolar.Text = ValueTotalDolar
    End Sub
    Sub CheckCalculatReceipt()
        'If RadReal.Checked = True Then
        '    CleanDolar()
        CalculatReceipAsReal()
        'Else
        'CleanReal()
        CalculateReceiptAsDolar()

        'End If
    End Sub
    Sub CleanReal()

        TxtTotalAsReal.Text = "0"
    End Sub
    Sub CleanDolar()
        TxtTotalAsDolar.Text = "0"
    End Sub
    Private Sub RadReal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckCalculatReceipt()
    End Sub

    Private Sub RadDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CheckCalculatReceipt()
    End Sub

    Private Sub ChDonation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDonation.CheckedChanged
        'CboDonation.Enabled = ChDonation.Checked
        'TxtDonateAmount.Enabled = ChDonation.Checked

        'CboDonation.SelectedIndex = -1

        'CboDonation.Focus()
        'CboDonation.Select()
    End Sub

    'Private Sub CboDonation_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDonation.DropDown

    'End Sub

    'Private Sub BtnAddDonation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDonation.Click
    '    Dim FMainDonation As New MainDonation
    '    If FMainDonation.ShowDialog = Windows.Forms.DialogResult.Yes Then
    '        InitDonation()
    '    End If
    'End Sub
    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub
    Sub LoadNewReceiptNo()
        Me.TxtReceiptNo.Text = MCashReceipt.getMaxID()
    End Sub

    Public Function CheckIsPatientConsult(ByVal PatientNo As Double, ByVal ConsultFor As String, ByVal Status As Integer) As Boolean
        Dim DataTbl As DataTable = DA_Consult_Detail.GetDataByConsultFor(PatientNo, ConsultFor, Status)
        If DataTbl.Rows.Count >= 1 Then
            For i As Integer = 0 To DataTbl.Rows.Count - 1
                ' MsgBox(DataTbl.Rows(i).Item("CONSULT_FOR"))
                LblConsultID.Text = DataTbl.Rows(i).Item("CONSULING_ID")
                LblConsultDate.Text = DataTbl.Rows(i).Item("CONSULING_DATE")
                LblConsultType.Text = DataTbl.Rows(i).Item("DONATE_TYPE")
                lblConsultFor.Text = DataTbl.Rows(i).Item("CONSULT_FOR")
                LblSendBy.Text = DataTbl.Rows(i).Item("APROVE_BY")
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Nil" Then
                    RadNil.Checked = True
                    'If DataTbl.Rows(i).Item("ORG") = "No Refer" Then
                    '    ChDonation.Checked = False
                    '    CboDonation.Text = ""
                    '    TxtDonateAmount.Text = ""
                    '    ChDonation.Enabled = False
                    '    GroupBox5.Enabled = False

                    'Else
                    If DataTbl.Rows(i).Item("ORG") = "" Then
                        ChDonation.Checked = False
                        CboDonation.Text = ""
                        TxtDonateAmount.Text = ""
                        ChDonation.Enabled = False
                        GroupBox5.Enabled = False
                    Else
                        ChDonation.Checked = True
                        CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                        TxtDonateAmount.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                        ChDonation.Enabled = False
                        GroupBox5.Enabled = False
                    End If
                    RadKHR.Checked = True
                End If
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Social" Then
                    RadSocial.Checked = True
                    If DataTbl.Rows(i).Item("IS_RIEL_DOLAR") = True Then
                        RadKHR.Checked = True
                        TxtSocialAmount.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    Else
                        RadUSD.Checked = True
                        TxtSocialAmount.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                    End If



                    TxtSocialAmount.ReadOnly = True
                    'If DataTbl.Rows(i).Item("ORG") = "No Refer" Then
                    '    ChDonation.Checked = False
                    '    CboDonation.Text = ""
                    '    TxtDonateAmount.Text = ""
                    '    ChDonation.Enabled = False
                    '    GroupBox5.Enabled = False
                    'Else
                    If DataTbl.Rows(i).Item("ORG") = "" Then
                        ChDonation.Checked = False
                        CboDonation.Text = ""
                        TxtDonateAmount.Text = ""
                        ChDonation.Enabled = False
                        GroupBox5.Enabled = False
                    Else

                        ChDonation.Checked = True
                        CboDonation.Text = DataTbl.Rows(i).Item("ORG")
                        TxtDonateAmount.Text = DataTbl.Rows(i).Item("DONATE_DOLAR")
                        ChDonation.Enabled = False
                        GroupBox5.Enabled = False
                    End If

                End If
                If DataTbl.Rows(i).Item("DONATE_TYPE") = "Full" Then
                    'MsgBox(DataTbl.Rows(i).Item("DONATE_RIEL"))
                    RadFull.Checked = True
                    If DataTbl.Rows(i).Item("IS_RIEL_DOLAR") = True Then
                        RadKHR.Checked = True

                        TxtSocialAmount.Text = DataTbl.Rows(i).Item("DONATE_RIEL")
                    Else
                        RadUSD.Checked = True
                        TxtSocialAmount.Text = DataTbl.Rows(i).Item("PATIENT_PAY_DOLAR")
                    End If
                    TxtFullAmount.ReadOnly = True
                End If
            Next
            LblTotalConsult.Text = "Total Consult: " & DataTbl.Rows.Count
            GroupPayCorrency.Enabled = False
            Return True
        Else
            RadFull.Checked = True
            LblConsultID.Text = "0"
            LblConsultDate.Text = "No Consult"
            LblConsultType.Text = "No Consult"
            lblConsultFor.Text = "No Consult"
            LblSendBy.Text = "No Consult"
            LblTotalConsult.Text = "Total Consult: 0"
            GroupPayCorrency.Enabled = True
            GroupBox5.Enabled = True
            Return False
        End If
    End Function
    Private Sub FrmNewReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadNewReceiptNo()
        Me.Focus()
        Call GetRates()
        GetBarcod()
        '--- Loading invoice information for edit invoice purpose
        If LblSaveStatus.Text <> "0" Then

            '--- Get Invoice information
            Dim DTblReceipt As DataTable = DaReceipt.GetDataByReceiptID(LblSaveStatus.Text)
            '--- Get Invoice's item information
            Dim DTblReceiptDetail As DataTable = DaReceiptDetail.GetDataByReceiptNo(LblSaveStatus.Text)

            '--- Get Receipt Customer
            For Each row As DataRow In DTblReceipt.Rows
                '--- Get Invoice's information
                If TypeOf row("CustID") Is DBNull = False Then
                    '--- Get Invoice's customer information                    
                    Dim DTblReceiptCus As DataTable = DaReceiptCustomer.GetDataByCustomerNo(row("CustID"))
                    GetReceiptCustomerInfo(DTblReceiptCus)
                    TxtCustomerID.Text = row("CustID")
                End If
            Next
            '--- Get Received Information
            GetReceiptInfo(DTblReceipt)
            '--- Get Received item detail
            GetReceiptDetailInfo(DTblReceiptDetail)
            TxtSocialAmount.Enabled = False
        End If
    End Sub

    Sub GetReceiptCustomerInfo(ByVal DTReceiptCus As DataTable)
        For Each row As DataRow In DTReceiptCus.Rows
            If TypeOf row("CusNameEng") Is DBNull = False Then TxtCusNameEng.Text = row("CusNameEng")
            If TypeOf row("CusName") Is DBNull = False Then TxtCustomerName.Text = row("CusName")
            If TypeOf row("Occupation") Is DBNull = False Then TxtCusOccupation.Text = row("Occupation")
            If TypeOf row("Sex") Is DBNull = False Then TxtSex.Text = row("Sex")
            If TypeOf row("Age") Is DBNull = False Then TxtAge.Text = row("Age")
            If TypeOf row("Address") Is DBNull = False Then txtAddress.Text = row("Address")
            If TypeOf row("CustomerNo") Is DBNull = False Then TxtCustomerNo.Text = row("CustomerNo")
        Next
    End Sub

    Sub GetReceiptInfo(ByVal DTReceipt As DataTable)

        '--- Initialize combo donation
        InitDonation()
        For Each row As DataRow In DTReceipt.Rows
            If TypeOf row("ReceiptID") Is DBNull = False Then LblReceiptID.Text = row("ReceiptID")
            If TypeOf row("ReceiptNo") Is DBNull = False Then TxtReceiptNo.Text = row("ReceiptNo")
            If TypeOf row("IsOldPatient") Is DBNull = False Then CheOldPatient.Checked = row("IsOldPatient")
            If TypeOf row("ReceiptDate") Is DBNull = False Then
                DateCreateReceipt.Checked = True
                DateCreateReceipt.Value = row("ReceiptDate")
            End If
            If TypeOf row("Glasses") Is DBNull = False Then
                TxtNumGlasses.Text = row("Glasses")
                ChbNewGlasses.Checked = True
            End If
           
            '--- Load PaymentType
            If TypeOf row("PaymentCur") Is DBNull = False Then
                If row("PaymentCur") = "KHR" Then
                    RadKHR.Checked = True
                Else
                    RadUSD.Checked = True
                End If
            End If
            If TypeOf row("PaymentType") Is DBNull = False Then
                If row("PaymentType") = 1 Then
                    RadFull.Checked = True
                    GroupPayCorrency.Enabled = True
                    If TypeOf row("FullAmount") Is DBNull = False Then TxtFullAmount.Text = row("FullAmount")
                   
                ElseIf row("PaymentType") = 2 Then
                    RadNil.Checked = True
                    If TypeOf row("NilAmount") Is DBNull = False Then TxtNilAmount.Text = row("NilAmount")
                   
                Else
                    RadSocial.Checked = True
                    If TypeOf row("SocialAmount") Is DBNull = False Then TxtSocialAmount.Text = row("SocialAmount")
                End If
            End If
           
           

            If TypeOf row("TotalReal") Is DBNull = False Then TxtTotalAsReal.Text = row("TotalReal")
            If TypeOf row("TotalDolar") Is DBNull = False Then TxtTotalAsDolar.Text = row("TotalDolar")

            If TypeOf row("IncomType") Is DBNull = False Then
                If row("IncomType") = "1" Then
                    RadMedicine.Checked = True
                ElseIf row("IncomType") = "2" Then
                    RadSunGlasses.Checked = True
                ElseIf row("IncomType") = "4" Then
                    RadCustomerMadeSpectacle.Checked = True
                    If TypeOf row("SubReceiptType") Is DBNull = False Then
                        If row("SubReceiptType") = "Distance" Then
                            RadDistance1.Checked = True
                        End If
                        If row("SubReceiptType") = "Redding" Then
                            RadRedding1.Checked = True
                        End If
                        If row("SubReceiptType") = "Bifocal" Then
                            RadBifocal.Checked = True
                        End If
                    End If

                ElseIf row("IncomType") = "3" Then
                    RadReadyMadeSpectacle.Checked = True
                    If TypeOf row("SubReceiptType") Is DBNull = False Then
                        If row("SubReceiptType") = "Distance" Then
                            RadDistance2.Checked = True
                        End If
                        If row("SubReceiptType") = "Redding" Then
                            RadRedding2.Checked = True
                        End If
                    End If
                ElseIf row("IncomType") = "5" Then
                    RadFundRaising.Checked = True
                ElseIf row("IncomType") = "6" Then
                    RadOther.Checked = True
                ElseIf row("IncomType") = "7" Then
                    RadLV.Checked = True
                End If
            End If

            '--- Source of Fund DonationID,DonateAmount
            If TypeOf row("IsDonation") Is DBNull = False Then
                If row("IsDonation") = True Then
                    If TypeOf row("DonateAmount") Is DBNull = False Then TxtDonateAmount.Text = row("DonateAmount")
                    ChDonation.Checked = True
                End If
                If TypeOf row("DonationID") Is DBNull = False Then
                    CboDonation.SelectedValue = row("DonationID")
                End If
            End If
        Next

    End Sub

    Sub GetReceiptDetailInfo(ByVal DTReceiptDetail As DataTable)
        Dim obj(7) As Object
        Dim Pic() As Byte = Nothing
        For Each row As DataRow In DTReceiptDetail.Rows
            Dim TItem As New tblItem
            TItem = ItemRepo.GetItemByID(Val(row("ItemID")))
            Dim NewDR As DataRow = Me.DTblItemDetial.NewRow
            NewDR("ColumnItemID") = row("ItemID")
            NewDR("ColumnBarcode") = TItem.Barcode
            NewDR("ColumnName") = TItem.ItemName
            NewDR("ColumnPrice") = row("ItemPrice")
            NewDR("ColumnQTY") = row("ItemQTY")
            NewDR("SubTotalReal") = row("SubTotalReal")
            NewDR("SubTotalDolar") = row("SubTotalDolar")
            NewDR("Picture") = Pic
            DTblItemDetial.Rows.Add(NewDR)
        Next
        GridItemDetail.DataSource = DTblItemDetial
    End Sub

    Private Sub BtnSaveReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveReceipt.Click
        BgSaveAndPrinting.RunWorkerAsync()
    End Sub

    Private Sub BtnAddCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCustomer.Click
        Dim FUMainCustomer As New MainCustomer
        If FUMainCustomer.ShowDialog = DialogResult.OK Then
            Me.TxtCustomerID.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("CustID").Value
            Me.TxtCustomerNo.Text = FUMainCustomer.GridCustomer.GetRow.Cells("CustomerNo").Value
            Me.TxtCustomerName.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("CusName").Value
            Me.TxtCusNameEng.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("CusNameEng").Value
            Me.LblCombindReferal.Text = ModNew_Outpatient.Get_CombindReferal(FUMainCustomer.GridCustomer.GetRow.Cells("CustomerNo").Value)
            If FUMainCustomer.GridCustomer.GetRow.Cells("IsPatient").Value = True Then
                RadFull.Checked = True
                'CheOldPatient.Checked = True
            Else
                'CheOldPatient.Checked = False
                RadFull.Checked = True
                ChDonation.Checked = False
                CboDonation.Text = ""
                TxtDonateAmount.Text = ""
                LblConsultDate.Text = "No Consult"
                LblConsultType.Text = "No Consult"
                lblConsultFor.Text = "No Consult"
                LblSendBy.Text = "No Consult"
                LblConsultID.Text = "0"
            End If

            If TypeOf FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("Occupation").Value Is DBNull Then
                Me.TxtCusOccupation.Text = ""
            Else
                Me.TxtCusOccupation.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("Occupation").Value
            End If

            Me.TxtSex.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("Sex").Value
            Me.TxtAge.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("Age").Value
            Me.txtAddress.Text = FUMainCustomer.GridCustomer.SelectedItems(0).GetRow.Cells("Address").Value
            CheckIsPatientConsult(EmptyString(TxtCustomerNo.Text), "Optical Shop", 0)
        End If
    End Sub

    Private Sub BtnCleanCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCleanCustomer.Click
        ClearCustomer()
    End Sub

    Sub SaveReceipt()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SaveReceipt))
        Else
            If ValidateTextField(TxtCustomerName, "", ErrReceipt) = False Then Exit Sub
            If ValidateDateField(DateCreateReceipt, "", ErrReceipt) = False Then Exit Sub
            If ChbNewGlasses.Checked = True Then
                If ValidateTextField(TxtNumGlasses, "", ErrReceipt) = False Then Exit Sub
            End If

            If ValidateTextField(TxtTotalAsReal, "", ErrReceipt) = False Then Exit Sub

            If ValidateTextField(TxtTotalAsDolar, "", ErrReceipt) = False Then Exit Sub
            'End If
            If ChDonation.Checked = True Then
                If ValidateCombobox(CboDonation, "", ErrReceipt) = False Then Exit Sub
                If ValidateTextField(TxtDonateAmount, "", ErrReceipt) = False Then Exit Sub
            End If

            If RadSocial.Checked = True Then
                If ValidateTextField(TxtSocialAmount, "", ErrReceipt) = False Then Exit Sub
            End If

            If DTblItemDetial.Rows.Count <= 0 Then
                MessageBox.Show("Atleas have one item add to list.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckEyeGlasses(GroupPayCorrency) = False Then
                MessageBox.Show("Please select customer pay as ($ or R)", "Invioce", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GroupPayCorrency.BackColor = Color.Khaki
                Exit Sub
            Else
                GroupPayCorrency.BackColor = Color.Transparent
            End If


            If CheckStatusIncome() = False Then
                MessageBox.Show("Please select income type.", "Income", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GPIncomeType.BackColor = Color.Khaki
                Exit Sub
            Else
                GPIncomeType.BackColor = Color.Transparent
                If RadCustomerMadeSpectacle.Checked = True Then
                    If CheckEyeGlasses(GBoxCustomerMade) = False Then
                        'MessageBox.Show("Please select payment type.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GBoxCustomerMade.BackColor = Color.Khaki
                        Exit Sub
                    Else
                        GBoxCustomerMade.BackColor = Color.Transparent
                    End If

                End If
                If RadReadyMadeSpectacle.Checked = True Then
                    If CheckEyeGlasses(GBoxReadyMade) = False Then
                        'MessageBox.Show("Please select payment type.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        GBoxReadyMade.BackColor = Color.Khaki
                        Exit Sub
                    Else
                        GBoxReadyMade.BackColor = Color.Transparent
                    End If
                End If
            End If

            If CheckPaymentType() = False Then
                MessageBox.Show("Please select payment type.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GBPaymentType.BackColor = Color.Khaki
                Exit Sub
            Else
                GBPaymentType.BackColor = Color.Transparent
            End If

            If RadSocial.Checked = True Then
                If ValidateTextField(TxtSocialAmount, "", ErrReceipt) = False Then Exit Sub
            End If
            If RadKHR.Checked = True Then
                TotalSocial = (EmptyString(TxtFullAmount.Text) + EmptyString(TxtSocialAmount.Text)) / txtRate.Text
            End If
            If RadUSD.Checked = True Then
                TotalSocial = EmptyString(TxtFullAmount.Text) + EmptyString(TxtSocialAmount.Text)
            End If
            If MessageBox.Show("Do you want to  save receipt?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                '============================= Start Edit Optical Receipt ======================================

                If LblSaveStatus.Text <> "0" Then '--- Edit Mode
                    'Try
                    Dim ReceiptType As String = ""
                    MTakeoInventory.StatusLoading(True)
                    Application.DoEvents()
                    Dim ObjReceipt As New RECEIPT
                    'ObjReceipt = OpticalDataControl.GetReceiptByReceiptNo(InvoiceNo)
                    ObjReceipt = OpticalDataControl.GetReceiptByReceiptNo(LblSaveStatus.Text)
                    ObjReceipt.ReceiptID = LblReceiptID.Text
                    ObjReceipt.ReceiptNo = TxtReceiptNo.Text
                    ObjReceipt.ReceiptDate = DateCreateReceipt.Value
                    ObjReceipt.TotalSocial = TotalSocial
                    '--- In Case user select Customer
                    ObjReceipt.CustomerNo = EmptyString(TxtCustomerNo.Text)
                    ObjReceipt.CustID = EmptyString(TxtCustomerID.Text)

                    'Case Patient not yet add to table Receipt_Customer
                    If IsPatient = True Then

                        Dim Re_Customer As New RECEIPT_CUSTOMER
                        Re_Customer.CustomerNo = TxtCustomerID.Text
                        Re_Customer.CusName = TxtCustomerName.Text
                        Re_Customer.Sex = TxtSex.Text
                        '--- For Optical shop customer statistic report purpose
                        If TxtSex.Text = "F" Then
                            Re_Customer.Female = "F"
                        Else
                            Re_Customer.Male = "M"
                        End If
                        Re_Customer.Age = CInt(TxtAge.Text)
                        Re_Customer.Occupation = TxtCusOccupation.Text
                        Re_Customer.Address = txtAddress.Text
                        Re_Customer.IsPatient = True
                        Re_Customer.CusNameEng = TxtCusNameEng.Text
                        ObjReceipt.CustomerNo = P_Customer.SaveNewCustomer(Re_Customer)
                        ObjReceipt.CustID = Re_Customer.CustID
                    End If


                    ObjReceipt.MedicReal = 0
                    ObjReceipt.MedicDolar = 0
                    ObjReceipt.EyeGlassesReal = 0
                    ObjReceipt.EyeGlassesDolar = 0
                    ObjReceipt.FundRaisingDolar = 0
                    ObjReceipt.FundRaisingR = 0
                    ObjReceipt.SpectacleDolar = 0
                    ObjReceipt.SpectacleR = 0
                    ObjReceipt.ReadyModDolar = 0
                    ObjReceipt.ReadyModR = 0
                    ObjReceipt.OtherDolar = 0
                    ObjReceipt.OtherR = 0
                    ObjReceipt.TotalReal = TxtTotalAsReal.Text
                    ObjReceipt.TotalDolar = TxtTotalAsDolar.Text
                    ObjReceipt.IncomType = IncomeTypeCondition.ToString


                    If ChDonation.Checked = True Then ObjReceipt.DonateAmount = Val(EmptyString(TxtDonateAmount.Text))
                    If ChbNewGlasses.Checked = True Then ObjReceipt.Glasses = Val(EmptyString(TxtNumGlasses.Text))

                    If RadFundRaising.Checked = True Then ReceiptType = RadFundRaising.Text '"Fund Raising"
                    If RadOther.Checked = True Then ReceiptType = RadOther.Text '"Other"
                    If RadReadyMadeSpectacle.Checked = True Then ReceiptType = RadReadyMadeSpectacle.Text '"Ready Made(Glasses)"
                    If RadMedicine.Checked = True Then ReceiptType = RadMedicine.Text '"Medicine"
                    If RadSunGlasses.Checked = True Then ReceiptType = RadSunGlasses.Text '"Sun Glasses"
                    If RadCustomerMadeSpectacle.Checked = True Then ReceiptType = RadCustomerMadeSpectacle.Text '"Spectacle(Glasses)"
                    If RadLV.Checked = True Then ReceiptType = RadLV.Text
                    ObjReceipt.ReceiptType = ReceiptType
                    If RadCustomerMadeSpectacle.Checked = True Then
                        If RadDistance1.Checked = True Then
                            ObjReceipt.SubReceiptType = RadDistance1.Text
                        End If
                        If RadRedding1.Checked = True Then
                            ObjReceipt.SubReceiptType = RadRedding1.Text
                        End If
                        If RadBifocal.Checked = True Then
                            ObjReceipt.SubReceiptType = RadBifocal.Text
                        End If
                    ElseIf RadReadyMadeSpectacle.Checked = True Then
                        If RadDistance2.Checked = True Then
                            ObjReceipt.SubReceiptType = RadDistance2.Text
                        End If
                        If RadRedding2.Checked = True Then
                            ObjReceipt.SubReceiptType = RadRedding2.Text
                        End If
                    Else
                        ObjReceipt.SubReceiptType = Nothing
                    End If



                    'If ChDonation.Checked = True Then
                    '    ObjReceipt.IsDonation = True
                    '    ObjReceipt.DonationID = CboDonation.SelectedValue
                    '    If RadNil.Checked = True Then
                    '        ModDonation.SaveNewDonatPay(0, TxtCustomerNo.Text, TxtCusNameEng.Text, "", TxtAge.Text, TxtSex.Text, txtAddress.Text, PaymentTypeLabel, TxtDonateAmount.Text, FormatDateTime(DateCreateReceipt.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, PaymentTypeLabel, "", TxtTotalAsReal.Text, TotalSocial, "OP", PaymentForGlasessOrMedicine, LblCombindReferal.Text)
                    '    Else
                    '        ModDonation.SaveNewDonatPay(TxtReceiptNo.Text, TxtCustomerNo.Text, TxtCusNameEng.Text, "", TxtAge.Text, TxtSex.Text, txtAddress.Text, "", TxtDonateAmount.Text, FormatDateTime(DateCreateReceipt.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, PaymentTypeLabel, "", TxtTotalAsReal.Text, TotalSocial, "OP", PaymentForGlasessOrMedicine, LblCombindReferal.Text)
                    '    End If
                    'Else
                    '    ObjReceipt.IsDonation = False
                    '    ObjReceipt.PayBySelf = 0
                    '    ObjReceipt.PayByDonation = 0
                    'End If



                    '------------- Save New Donation for Donation-------------- 
                    If ChDonation.Checked = True Then
                        ObjReceipt.IsDonation = True
                        ObjReceipt.DonationID = CboDonation.SelectedValue

                    Else
                        ObjReceipt.IsDonation = False
                        ObjReceipt.PayBySelf = 0
                        ObjReceipt.PayByDonation = 0
                    End If

                    ObjReceipt.IsPaid = "0"
                    ObjReceipt.UserID = USER_ID
                    ObjReceipt.UserName = USER_NAME

                    '--- Save PaymentType for Full=1,Social=3 and Nill =2
                    If RadFull.Checked = True Then
                        ObjReceipt.PaymentType = 1
                        ObjReceipt.FullAmount = Val(TxtFullAmount.Text)
                        ObjReceipt.SocialAmount = 0
                        ObjReceipt.NilAmount = 0
                    ElseIf RadNil.Checked = True Then
                        ObjReceipt.PaymentType = 2
                        ObjReceipt.NilAmount = Val(TxtNilAmount.Text)
                        ObjReceipt.FullAmount = 0
                        ObjReceipt.SocialAmount = 0
                    Else
                        ObjReceipt.PaymentType = 3
                        ObjReceipt.FullAmount = 0
                        ObjReceipt.NilAmount = 0
                        ObjReceipt.SocialAmount = Val(TxtSocialAmount.Text)
                    End If

                    '--- Save PaymentType Currency
                    If RadKHR.Checked = True Then
                        ObjReceipt.PaymentCur = "KHR"
                    Else
                        ObjReceipt.PaymentCur = "USD"
                    End If

                    '--- Save status of Patient
                    ObjReceipt.IsOldPatient = CheOldPatient.Checked

                    ' New Customer for Patient.
                    If OpticalDataControl.SaveUpdateReceipt(ObjReceipt) = True Then
                        '--- Delete before save update
                        If OpticalDataControl.DeleteReceiptItemDetailByReceiptID(LblSaveStatus.Text) = True Then
                            '--- Save new receipt item                                
                            For Each row As DataRow In DTblItemDetial.Rows
                                Dim ObjReceiptDetail As New RECEIPT_DETAIL
                                'ObjReceiptDetail.ReceiptNo = TxtReceiptNo.Text
                                ObjReceiptDetail.ReceiptNo = LblSaveStatus.Text
                                ObjReceiptDetail.ItemID = row("ColumnItemID")
                                ObjReceiptDetail.ItemPrice = Val(row("ColumnPrice"))
                                ObjReceiptDetail.ItemQTY = Val(row("ColumnQTY"))
                                ObjReceiptDetail.SubTotalReal = Val(row("SubTotalReal"))
                                ObjReceiptDetail.SubTotalDolar = Val(row("SubTotalDolar"))
                                ObjReceiptDetail.ReceiptDate = DateCreateReceipt.Value
                                OpticalDataControl.SaveReceiptDetail(ObjReceiptDetail)
                            Next
                        End If
                        Try
                            '-------- Set Object For Receip TblPatientReceipt----------
                            Dim ObjTblPatientReceipt As tblPatientReceipt
                            Dim ObjPatientReceipt As IOpticalShop = New OpticalshopImp
                            ObjTblPatientReceipt = ObjPatientReceipt.GetTblPatientReceipt(CDbl(InvoiceNo))
                            ObjTblPatientReceipt.DateIn = DateCreateReceipt.Value
                            ObjTblPatientReceipt.DateUpdate = Format(Date.Now(), "MM/dd/yyyy")
                            ObjTblPatientReceipt.ReceiptNo = TxtReceiptNo.Text
                            ObjTblPatientReceipt.IDCashReceipt = 0
                            ObjTblPatientReceipt.HN = TxtCustomerNo.Text
                            ObjTblPatientReceipt.PatientName = TxtCustomerName.Text
                            ObjTblPatientReceipt.CashTotal = TxtTotalAsDolar.Text
                            '======== Set valud Cashe
                            ObjTblPatientReceipt.CashUSD = 0
                            ObjTblPatientReceipt.CashRiel = 0
                            ObjTblPatientReceipt.TotalUSD = 0
                            ObjTblPatientReceipt.TotalRiel = 0
                            ObjTblPatientReceipt.GlassFeeUSD = 0
                            ObjTblPatientReceipt.GlassFeeRiel = 0
                            ObjTblPatientReceipt.MedicineFeeRiel = 0
                            ObjTblPatientReceipt.MedicineFeeUSD = 0
                            ObjTblPatientReceipt.OtherFeeUSD = 0
                            ObjTblPatientReceipt.OtherFeeRiel = 0
                            ObjTblPatientReceipt.ConsultationFeeRiel = 0
                            ObjTblPatientReceipt.ConsultationFeeUSD = 0
                            ObjTblPatientReceipt.FollowUpFeeRiel = 0
                            ObjTblPatientReceipt.FollowUpFeeUSD = 0
                            ObjTblPatientReceipt.SocialFeeRiel = 0
                            ObjTblPatientReceipt.SocialFeeUSD = 0
                            ObjTblPatientReceipt.FullFeeRiel = 0
                            ObjTblPatientReceipt.FullFeeUSD = 0
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.CashRiel = EmptyString(TxtFullAmount.Text)
                                    ObjTblPatientReceipt.TotalRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.CashRiel = EmptyString(TxtSocialAmount.Text)
                                    ObjTblPatientReceipt.TotalRiel = EmptyString(TxtSocialAmount.Text)
                                End If

                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.CashUSD = EmptyString(TxtFullAmount.Text)
                                    ObjTblPatientReceipt.TotalUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.CashUSD = EmptyString(TxtSocialAmount.Text)
                                    ObjTblPatientReceipt.TotalUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                            If RadCustomerMadeSpectacle.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If
                            End If
                            If RadSunGlasses.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If

                            End If
                            If RadReadyMadeSpectacle.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If

                            End If
                            If RadMedicine.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.MedicineFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.MedicineFeeRiel = EmptyString(TxtSocialAmount.Text)
                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.MedicineFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.MedicineFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If


                                End If
                            End If
                            If RadFundRaising.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtSocialAmount.Text)

                                    End If

                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If
                            End If
                            If RadOther.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtSocialAmount.Text)

                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If
                            End If
                            If RadLV.Checked = True Then
                                If RadKHR.Checked = True Then
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                    End If
                                Else
                                    If RadFull.Checked = True Then
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                    Else
                                        ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                    End If
                                End If
                            End If
                            ObjTblPatientReceipt.Rates = txtRate.Text
                            ObjTblPatientReceipt.AmoutWord = ""
                            ObjTblPatientReceipt.ConPay = "0"
                            ObjTblPatientReceipt.ConDelete = "0"
                            ObjTblPatientReceipt.ConGeneral = "OP"
                            ObjTblPatientReceipt.CashierIn = USER_NAME
                            ObjTblPatientReceipt.PrintCount = 1
                            ObjTblPatientReceipt.Years = Me.DateCreateReceipt.Value.Year
                            ObjTblPatientReceipt.DateNow = Now
                            If ChDonation.Checked = True Then
                                ObjTblPatientReceipt.IsDonation = ChDonation.Checked
                                ObjTblPatientReceipt.DonationID = CboDonation.SelectedValue
                                ObjTblPatientReceipt.DonationName = CboDonation.Text
                                ObjTblPatientReceipt.DonationPay = Val(EmptyString(TxtDonateAmount.Text))
                                ObjTblPatientReceipt.DonateNote = CboDonation.Text
                            Else
                                ObjTblPatientReceipt.IsDonation = False
                                ObjTblPatientReceipt.DonationPay = 0
                            End If
                            If RadKHR.Checked = True Then
                                ObjTblPatientReceipt.HosFee = TxtTotalAsReal.Text
                            Else
                                ObjTblPatientReceipt.CashTotal = TxtTotalAsDolar.Text
                            End If
                            ObjTblPatientReceipt.OperationFeeRiel = 0
                            ObjTblPatientReceipt.OperationFeeUSD = 0
                            ObjTblPatientReceipt.ArtificialEyeFeeRiel = 0
                            ObjTblPatientReceipt.ArtificialEyeFeeUSD = 0
                            ObjTblPatientReceipt.IsPatientNill = False
                            ObjPatientReceipt.UpdateReceiptPay()
                            'MainReceipt.LoadByReceiptNo(TxtReceiptNo.Text)
                        Catch ex As Exception

                        End Try
                        
                        If RadNil.Checked = False Then
                            GenerateReceipt(TxtReceiptNo.Text)
                        End If

                        '''''''''''''''''''''Clean and Create New Receipt''''''''''''''''
                        CleanReceiptInfomation()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                        Me.Dispose()
                    End If
                    IsPatient = False
                    GetBarcod()
                    If LblConsultID.Text = "0" Then

                    Else
                        DS_Consult.UpdateStatus(1, LblConsultID.Text)
                    End If

                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End Try
                    '============================= End Edit In Optical Shop ======================================
                    '=============================                               ======================================
                    '============================= Start Save In Optical Receipt ======================================

                Else '--- Add New
                    Try
                        If MCashReceipt.CheckDuplicateReceiptNo(Me.TxtReceiptNo.Text, "tblPatientReceipt") = True Then
                            LoadNewReceiptNo()
                        End If
                        Dim ReceiptType As String = ""
                        MTakeoInventory.StatusLoading(True)
                        Application.DoEvents()

                        '-------- Set Object For Receip TblPatientReceipt----------
                        Dim ObjTblPatientReceipt As New tblPatientReceipt
                        ObjTblPatientReceipt.DateIn = DateCreateReceipt.Value
                        ObjTblPatientReceipt.DateUpdate = Format(Date.Now(), "MM/dd/yyyy")
                        ObjTblPatientReceipt.ReceiptNo = TxtReceiptNo.Text
                        ObjTblPatientReceipt.IDCashReceipt = 0
                        ObjTblPatientReceipt.HN = TxtCustomerNo.Text
                        ObjTblPatientReceipt.PatientName = TxtCustomerName.Text
                        ObjTblPatientReceipt.CashTotal = TxtTotalAsDolar.Text
                        '======== Set valud Cashe
                        ObjTblPatientReceipt.CashUSD = 0
                        ObjTblPatientReceipt.CashRiel = 0
                        ObjTblPatientReceipt.TotalUSD = 0
                        ObjTblPatientReceipt.TotalRiel = 0
                        ObjTblPatientReceipt.GlassFeeUSD = 0
                        ObjTblPatientReceipt.GlassFeeRiel = 0
                        ObjTblPatientReceipt.MedicineFeeRiel = 0
                        ObjTblPatientReceipt.MedicineFeeUSD = 0
                        ObjTblPatientReceipt.OtherFeeUSD = 0
                        ObjTblPatientReceipt.OtherFeeRiel = 0
                        ObjTblPatientReceipt.ConsultationFeeRiel = 0
                        ObjTblPatientReceipt.ConsultationFeeUSD = 0
                        ObjTblPatientReceipt.FollowUpFeeRiel = 0
                        ObjTblPatientReceipt.FollowUpFeeUSD = 0
                        ObjTblPatientReceipt.SocialFeeRiel = 0
                        ObjTblPatientReceipt.SocialFeeUSD = 0
                        ObjTblPatientReceipt.FullFeeRiel = 0
                        ObjTblPatientReceipt.FullFeeUSD = 0
                        If RadKHR.Checked = True Then
                            If RadFull.Checked = True Then
                                ObjTblPatientReceipt.CashRiel = EmptyString(TxtFullAmount.Text)
                                ObjTblPatientReceipt.TotalRiel = EmptyString(TxtFullAmount.Text)
                            Else
                                ObjTblPatientReceipt.CashRiel = EmptyString(TxtSocialAmount.Text)
                                ObjTblPatientReceipt.TotalRiel = EmptyString(TxtSocialAmount.Text)
                            End If

                        Else
                            If RadFull.Checked = True Then
                                ObjTblPatientReceipt.CashUSD = EmptyString(TxtFullAmount.Text)
                                ObjTblPatientReceipt.TotalUSD = EmptyString(TxtFullAmount.Text)
                            Else
                                ObjTblPatientReceipt.CashUSD = EmptyString(TxtSocialAmount.Text)
                                ObjTblPatientReceipt.TotalUSD = EmptyString(TxtSocialAmount.Text)
                            End If
                        End If
                        If RadCustomerMadeSpectacle.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                        End If
                        If RadSunGlasses.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If

                        End If
                        If RadReadyMadeSpectacle.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If

                        End If
                        If RadMedicine.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.MedicineFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.MedicineFeeRiel = EmptyString(TxtSocialAmount.Text)
                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.MedicineFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.MedicineFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                        End If
                        If RadFundRaising.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtSocialAmount.Text)

                                End If

                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                        End If
                        If RadOther.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.OtherFeeRiel = EmptyString(TxtSocialAmount.Text)

                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.OtherFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                        End If
                        If RadLV.Checked = True Then
                            If RadKHR.Checked = True Then
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeRiel = EmptyString(TxtSocialAmount.Text)
                                End If
                            Else
                                If RadFull.Checked = True Then
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtFullAmount.Text)
                                Else
                                    ObjTblPatientReceipt.GlassFeeUSD = EmptyString(TxtSocialAmount.Text)
                                End If
                            End If
                        End If
                        ObjTblPatientReceipt.Rates = txtRate.Text
                        ObjTblPatientReceipt.AmoutWord = ""
                        ObjTblPatientReceipt.ConPay = "0"
                        ObjTblPatientReceipt.ConDelete = "0"
                        ObjTblPatientReceipt.ConGeneral = "OP"
                        ObjTblPatientReceipt.CashierIn = USER_NAME
                        ObjTblPatientReceipt.PrintCount = 1
                        ObjTblPatientReceipt.Years = ModGlobleVariable.GeteDateServer.Year
                        ObjTblPatientReceipt.DateNow = Now
                        If ChDonation.Checked = True Then
                            ObjTblPatientReceipt.IsDonation = ChDonation.Checked
                            ObjTblPatientReceipt.DonationID = CboDonation.SelectedValue
                            ObjTblPatientReceipt.DonationName = CboDonation.Text
                            ObjTblPatientReceipt.DonationPay = Val(EmptyString(TxtDonateAmount.Text))
                            ObjTblPatientReceipt.DonateNote = CboDonation.Text
                        Else
                            ObjTblPatientReceipt.IsDonation = False
                            ObjTblPatientReceipt.DonationPay = 0
                        End If
                        If RadKHR.Checked = True Then
                            ObjTblPatientReceipt.HosFee = TxtTotalAsReal.Text
                        Else
                            ObjTblPatientReceipt.CashTotal = TxtTotalAsDolar.Text
                        End If
                        ObjTblPatientReceipt.OperationFeeRiel = 0
                        ObjTblPatientReceipt.OperationFeeUSD = 0
                        ObjTblPatientReceipt.ArtificialEyeFeeRiel = 0
                        ObjTblPatientReceipt.ArtificialEyeFeeUSD = 0
                        ObjTblPatientReceipt.IsPatientNill = False
                        '======== Set Object To Receipt Optical Shop=============

                        Dim ObjReceipt As New RECEIPT
                        ObjReceipt.ReceiptID = LblReceiptID.Text
                        ObjReceipt.ReceiptNo = TxtReceiptNo.Text
                        ObjReceipt.ReceiptDate = DateCreateReceipt.Value
                        ObjReceipt.CustID = EmptyString(TxtCustomerID.Text)

                        '--- In Case user select Customer
                        ObjReceipt.CustomerNo = EmptyString(TxtCustomerNo.Text)
                        ObjReceipt.CustID = EmptyString(TxtCustomerID.Text)
                        ObjReceipt.TotalSocial = TotalSocial
                        'Case Patient not yet add to table Receipt_Customer
                        If IsPatient = True Then
                            Dim Re_Customer As New RECEIPT_CUSTOMER
                            Re_Customer.CustomerNo = TxtCustomerID.Text
                            Re_Customer.CusName = TxtCustomerName.Text
                            Re_Customer.Sex = TxtSex.Text
                            '--- For Optical shop customer statistic report purpose
                            If TxtSex.Text = "F" Then
                                Re_Customer.Female = "F"
                            Else
                                Re_Customer.Male = "M"
                            End If
                            Re_Customer.Age = CInt(TxtAge.Text)
                            Re_Customer.Occupation = TxtCusOccupation.Text
                            Re_Customer.Address = txtAddress.Text
                            Re_Customer.IsPatient = True
                            Re_Customer.CusNameEng = TxtCusNameEng.Text
                            ObjReceipt.CustomerNo = P_Customer.SaveNewCustomer(Re_Customer)
                            ObjReceipt.CustID = Re_Customer.CustID
                        End If

                        ObjReceipt.MedicReal = 0
                        ObjReceipt.MedicDolar = 0
                        ObjReceipt.EyeGlassesReal = 0
                        ObjReceipt.EyeGlassesDolar = 0
                        ObjReceipt.FundRaisingDolar = 0
                        ObjReceipt.FundRaisingR = 0
                        ObjReceipt.SpectacleDolar = 0
                        ObjReceipt.SpectacleR = 0
                        ObjReceipt.ReadyModDolar = 0
                        ObjReceipt.ReadyModR = 0
                        ObjReceipt.OtherDolar = 0
                        ObjReceipt.OtherR = 0
                        ObjReceipt.TotalReal = TxtTotalAsReal.Text
                        ObjReceipt.TotalDolar = TxtTotalAsDolar.Text
                        ObjReceipt.IncomType = IncomeTypeCondition.ToString


                        If ChDonation.Checked = True Then ObjReceipt.DonateAmount = Val(EmptyString(TxtDonateAmount.Text))
                        If ChbNewGlasses.Checked = True Then ObjReceipt.Glasses = Val(EmptyString(TxtNumGlasses.Text))

                        '--- Set  Receipt Type
                        If RadFundRaising.Checked = True Then ReceiptType = RadFundRaising.Text '"Fund Raising"
                        If RadOther.Checked = True Then ReceiptType = RadOther.Text '"Other"
                        If RadReadyMadeSpectacle.Checked = True Then ReceiptType = RadReadyMadeSpectacle.Text '"Ready Made(Glasses)"
                        If RadMedicine.Checked = True Then ReceiptType = RadMedicine.Text '"Medicine"
                        If RadSunGlasses.Checked = True Then ReceiptType = RadSunGlasses.Text '"Sun Glasses"
                        If RadCustomerMadeSpectacle.Checked = True Then ReceiptType = RadCustomerMadeSpectacle.Text '"Spectacle(Glasses)"
                        If RadLV.Checked = True Then ReceiptType = RadLV.Text
                        ObjReceipt.ReceiptType = ReceiptType
                        If RadCustomerMadeSpectacle.Checked = True Then
                            If RadDistance1.Checked = True Then
                                ObjReceipt.SubReceiptType = RadDistance1.Text
                            End If
                            If RadRedding1.Checked = True Then
                                ObjReceipt.SubReceiptType = RadRedding1.Text
                            End If
                            If RadBifocal.Checked = True Then
                                ObjReceipt.SubReceiptType = RadBifocal.Text
                            End If
                        ElseIf RadReadyMadeSpectacle.Checked = True Then
                            If RadDistance2.Checked = True Then
                                ObjReceipt.SubReceiptType = RadDistance2.Text
                            End If
                            If RadRedding2.Checked = True Then
                                ObjReceipt.SubReceiptType = RadRedding2.Text
                            End If
                        Else
                            ObjReceipt.SubReceiptType = Nothing
                        End If


                        If ChDonation.Checked = True Then
                            ObjReceipt.IsDonation = True
                            ObjReceipt.DonationID = CboDonation.SelectedValue
                            If RadNil.Checked = True Then
                                ModDonation.SaveNewDonatPay(0, TxtCustomerNo.Text, TxtCusNameEng.Text, "", TxtAge.Text, TxtSex.Text, txtAddress.Text, PaymentTypeLabel, TxtDonateAmount.Text, FormatDateTime(DateCreateReceipt.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, PaymentTypeLabel, "", TxtTotalAsReal.Text, 0, "OP", PaymentForGlasessOrMedicine, LblCombindReferal.Text, LblConsultType.Text)
                            Else
                                ModDonation.SaveNewDonatPay(TxtReceiptNo.Text, TxtCustomerNo.Text, TxtCusNameEng.Text, "", TxtAge.Text, TxtSex.Text, txtAddress.Text, "", TxtDonateAmount.Text, FormatDateTime(DateCreateReceipt.Value, DateFormat.ShortDate), CboDonation.SelectedValue, CboDonation.Text, PaymentTypeLabel, "", TxtTotalAsReal.Text, TotalSocial, "OP", PaymentForGlasessOrMedicine, LblCombindReferal.Text, LblConsultType.Text)
                            End If
                        Else
                            ObjReceipt.IsDonation = False
                            ObjReceipt.PayBySelf = 0
                            ObjReceipt.PayByDonation = 0
                        End If

                        ObjReceipt.IsPaid = "0"
                        ObjReceipt.UserID = USER_ID
                        ObjReceipt.UserName = USER_NAME

                        '--- Save PaymentType 
                        If RadFull.Checked = True Then
                            ObjReceipt.PaymentType = 1
                            ObjReceipt.FullAmount = Val(TxtFullAmount.Text)
                        ElseIf RadNil.Checked = True Then
                            ObjReceipt.PaymentType = 2
                            ObjReceipt.NilAmount = Val(TxtNilAmount.Text)
                        Else
                            ObjReceipt.PaymentType = 3
                            ObjReceipt.SocialAmount = Val(TxtSocialAmount.Text)
                        End If

                        '--- Save PaymentType Currency
                        If RadKHR.Checked = True Then
                            ObjReceipt.PaymentCur = "KHR"
                        Else
                            ObjReceipt.PaymentCur = "USD"
                        End If

                        '--- Save status of Patient
                        ObjReceipt.IsOldPatient = CheOldPatient.Checked
                        '..... Save to table TblPatient Receipt .........


                        '.......... In Cashe Nill -------------------------------
                        If RadNil.Checked = True Then
                            ' New Customer for Patient.
                            ObjReceipt.ReceiptNo = 0
                            If OpticalDataControl.SaveNewReceipt(ObjReceipt) = True Then
                                Dim IDReceipt As Double = ObjReceipt.ReceiptID
                                'MsgBox(IDReceipt)
                                For Each row As DataRow In DTblItemDetial.Rows
                                    Dim ObjReceiptDetail As New RECEIPT_DETAIL
                                    ObjReceiptDetail.ReceiptNo = IDReceipt 'TxtReceiptNo.Text
                                    ObjReceiptDetail.ItemID = row("ColumnItemID")
                                    ObjReceiptDetail.ItemPrice = Val(row("ColumnPrice"))
                                    ObjReceiptDetail.ItemQTY = Val(row("ColumnQTY"))
                                    ObjReceiptDetail.SubTotalReal = Val(row("SubTotalReal"))
                                    ObjReceiptDetail.SubTotalDolar = Val(row("SubTotalDolar"))
                                    ObjReceiptDetail.ReceiptDate = DateCreateReceipt.Value
                                    OpticalDataControl.SaveReceiptDetail(ObjReceiptDetail)
                                Next

                                '--- Process Cut Stock For the Nil ------------------------------------------
                                '================= Transaction cut stock ================
                                THIDataContext.getTHIDataContext.Connection.Close()
                                THIDataContext.getTHIDataContext.Connection.Open()
                                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                                THIDataContext.getTHIDataContext.Transaction = trans

                                Try
                                    For Each Row As DataRow In DTblItemDetial.Rows

                                        Dim itemID As Double = Val(Row("ColumnItemID"))
                                        Dim unitsInStock As Integer = 0
                                        '--- Register Begin Balance of item (myRequestToDepartID) 
                                        Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = OPTICALSHOP_DEPART_ID And departStock.ItemID = itemID
                                        unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock
                                        Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = OPTICALSHOP_DEPART_ID And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                                        If q = 0 Then
                                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                                            mytblBeginBalanceTrace.Date = GetDateServer()
                                            mytblBeginBalanceTrace.DepartID = OPTICALSHOP_DEPART_ID
                                            mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                                            mytblBeginBalanceTrace.ItemID = itemID
                                            THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                                            THIDataContext.getTHIDataContext.SubmitChanges()
                                        End If
                                    Next

                                    '--- Insert tblUsed & tblUsedDetail
                                    Dim mytblUsed As New tblUsed
                                    mytblUsed.UsedDepartID = OPTICALSHOP_DEPART_ID
                                    mytblUsed.UsedDate = GetDateServer.Date
                                    mytblUsed.UsedDescription = "Used in Optical Shop Nil Receipt : " & ObjReceipt.ReceiptID
                                    mytblUsed.UsedUserID = CInt(USER_ID)
                                    THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                                    THIDataContext.getTHIDataContext.SubmitChanges()

                                    For Each Rec As DataRow In DTblItemDetial.Rows
                                        Dim itemID As Double = Val(Rec("ColumnItemID"))
                                        '--- Updata Optical Shop stock
                                        Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = OPTICALSHOP_DEPART_ID And departStock.ItemID = itemID
                                        Dim myDepartStock = qDepartStock.SingleOrDefault
                                        myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - Val(Rec("ColumnQTY"))
                                        THIDataContext.getTHIDataContext.SubmitChanges()
                                        '--- Insert tblUsedDetail
                                        Dim mytblUsedDetail As New tblUsedDetail
                                        mytblUsedDetail.UsedID = mytblUsed.UsedID
                                        mytblUsedDetail.ItemID = itemID
                                        mytblUsedDetail.UsedQuantity = Val(Rec("ColumnQTY"))

                                        THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                                        THIDataContext.getTHIDataContext.SubmitChanges()
                                    Next
                                    trans.Commit()
                                    THIDataContext.getTHIDataContext.Connection.Close()
                                Catch ex As Exception
                                    trans.Rollback()
                                    THIDataContext.getTHIDataContext.Connection.Close()
                                    MessageBox.Show(ex.Message & "--- Update Stock ---", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                                '---- End Process Cut Stock ----------------------------------------------------------------------

                                'MainReceipt.LoadByReceiptNo(TxtReceiptNo.Text)
                                If RadNil.Checked = False Then
                                    GenerateReceipt(TxtReceiptNo.Text)
                                End If

                                '''''''''''''''''''''Clean and Create New Receipt''''''''''''''''
                                CleanReceiptInfomation()
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                                Me.Close()
                                Me.Dispose()
                            End If
                            IsPatient = False
                            GetBarcod()

                            '.......... Finish Cashe Nill ------------------------------- 
                            '------------------------------------------------------------
                        Else
                            '1 ......Save to TblPatientReceipt first ...............
                            If OpticalDataControl.SaveNewReceiptPatient(ObjTblPatientReceipt) = True Then
                                ' New Customer for Patient.
                                If OpticalDataControl.SaveNewReceipt(ObjReceipt) = True Then
                                    Dim IDReceipt As Double = ObjReceipt.ReceiptID
                                    'MsgBox(IDReceipt)
                                    For Each row As DataRow In DTblItemDetial.Rows
                                        Dim ObjReceiptDetail As New RECEIPT_DETAIL
                                        ObjReceiptDetail.ReceiptNo = IDReceipt 'TxtReceiptNo.Text
                                        ObjReceiptDetail.ItemID = row("ColumnItemID")
                                        ObjReceiptDetail.ItemPrice = Val(row("ColumnPrice"))
                                        ObjReceiptDetail.ItemQTY = Val(row("ColumnQTY"))
                                        ObjReceiptDetail.SubTotalReal = Val(row("SubTotalReal"))
                                        ObjReceiptDetail.SubTotalDolar = Val(row("SubTotalDolar"))
                                        ObjReceiptDetail.ReceiptDate = DateCreateReceipt.Value
                                        OpticalDataControl.SaveReceiptDetail(ObjReceiptDetail)
                                    Next
                                    'MainReceipt.LoadByReceiptNo(TxtReceiptNo.Text)
                                    If RadNil.Checked = False Then
                                        GenerateReceipt(TxtReceiptNo.Text)
                                    End If

                                    '''''''''''''''''''''Clean and Create New Receipt''''''''''''''''
                                    CleanReceiptInfomation()
                                    Me.DialogResult = Windows.Forms.DialogResult.OK
                                    Me.Close()
                                    Me.Dispose()
                                End If
                                IsPatient = False
                                GetBarcod()
                            End If
                        End If
                        If LblConsultID.Text = "0" Then
                        Else
                            DS_Consult.UpdateStatus(1, LblConsultID.Text)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub
    Dim PrinterDocName As New System.Drawing.Printing.PrintDocument

    Sub GenerateReceipt(ByVal ReceipNo As String)
        'CreateParameterCrystal()
        'ObjReceiptCry.SetDataSource(CType(DaReceipt.GetDataByReceiptNo(ReceipNo), DataTable))
        'If ChPrintPreview.Checked = True Then
        '    FReceiptPrintPreview.CryPrintPreview.ReportSource = ObjReceiptCry
        '    ObjReceiptCry.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
        '    ObjReceiptCry.SetParameterValue("ParameterEng", PARAMETENG)
        '    FReceiptPrintPreview.ShowDialog()
        '    FReceiptPrintPreview.Close()
        '    FReceiptPrintPreview.Dispose()
        '    ObjReceiptCry.Dispose()
        '    ObjReceiptCry.Close()
        'Else
        '    ObjReceiptCry.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
        '    ObjReceiptCry.SetParameterValue("ParameterEng", PARAMETENG)
        '    ObjReceiptCry.PrintOptions.PrinterName = PrinterDocName.PrinterSettings.PrinterName
        '    ObjReceiptCry.PrintToPrinter(1, True, 1, 1)
        '    ObjReceiptCry.Close()
        '    ObjReceiptCry.Dispose()
        'End If
        CreateParameterCrystal()
        ObjReceiptCry_V1.SetDataSource(CType(DaReceiptPrint.GetDataByReceiptNo(ReceipNo), DataTable))
        If ChPrintPreview.Checked = True Then
            FReceiptPrintPreview.CryPrintPreview.ReportSource = ObjReceiptCry_V1
            ObjReceiptCry_V1.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
            ObjReceiptCry_V1.SetParameterValue("ParameterEng", PARAMETENG)
            FReceiptPrintPreview.ShowDialog()
            FReceiptPrintPreview.Close()
            FReceiptPrintPreview.Dispose()
            ObjReceiptCry_V1.Dispose()
            ObjReceiptCry_V1.Close()
        Else
            ObjReceiptCry_V1.SetParameterValue("InPaymentForKhmer", PARAMETKHMER)
            ObjReceiptCry_V1.SetParameterValue("ParameterEng", PARAMETENG)
            ObjReceiptCry_V1.PrintOptions.PrinterName = PrinterDocName.PrinterSettings.PrinterName
            ObjReceiptCry_V1.PrintToPrinter(1, True, 1, 1)
            ObjReceiptCry_V1.Close()
            ObjReceiptCry_V1.Dispose()
        End If
    End Sub
    Sub CleanReceiptInfomation()
        DateCreateReceipt.Checked = False
        LoadNewReceiptNo()
        ChPrintPreview.Checked = False
        DTblItemDetial.Rows.Clear()
        GridItemDetail.DataSource = DTblItemDetial
        TxtTotalAsDolar.Text = ""
        TxtTotalAsReal.Text = ""
        ChDonation.Checked = False
        ClearCustomer()

        RadFundRaising.Checked = False
        RadCustomerMadeSpectacle.Checked = False
        RadSunGlasses.Checked = False
        RadOther.Checked = False
        RadMedicine.Checked = False
        RadReadyMadeSpectacle.Checked = False
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' >>>>>>>>Income Type<<<<<<<<<<<<<
    ''' Sun Glasses=2
    ''' Spectacle = 4
    ''' Read Mod = 3
    ''' Medicine = 1
    ''' Fund Raising = 5
    ''' Other = 6
    ''' LV Device=7
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function IncomeTypeCondition() As Integer
        If RadFundRaising.Checked = True Then
            Return RadFundRaising.Tag
        ElseIf RadSunGlasses.Checked = True Then
            Return RadSunGlasses.Tag
        ElseIf RadCustomerMadeSpectacle.Checked = True Then
            Return RadCustomerMadeSpectacle.Tag
        ElseIf RadReadyMadeSpectacle.Checked = True Then
            Return RadReadyMadeSpectacle.Tag
        ElseIf RadMedicine.Checked = True Then
            Return RadMedicine.Tag
        ElseIf RadOther.Checked = True Then
            Return RadOther.Tag
        ElseIf RadLV.Checked = True Then
            Return RadLV.Tag
        End If
    End Function
    Sub CreateParameterCrystal()
        If RadFundRaising.Checked = True Then
            PARAMETKHMER = ""
            PARAMETENG = "Fund Raising"
        ElseIf RadSunGlasses.Checked = True Then
            PARAMETKHMER = "Ev:nta"
            PARAMETENG = "(Eye Glasses)"
        ElseIf RadCustomerMadeSpectacle.Checked = True Then
            PARAMETKHMER = "Ev:nta"
            PARAMETENG = "(Eye Glasses)"
        ElseIf RadReadyMadeSpectacle.Checked = True Then
            PARAMETKHMER = "Ev:nta"
            PARAMETENG = "(Eye Glasses)"
        ElseIf RadMedicine.Checked = True Then
            PARAMETKHMER = "fñaMeBTüepSg²"
            PARAMETENG = "(Special medicine)"
        ElseIf RadLV.Checked = True Then
            PARAMETKHMER = ""
            PARAMETENG = "(LV Device)"
        ElseIf RadOther.Checked = True Then
            PARAMETKHMER = ""
            PARAMETENG = "Other"
        End If
    End Sub
    Function CheckStatusIncome() As Boolean
        For Each obj As Object In GPIncomeType.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function

    Function CheckPaymentType() As Boolean
        For Each obj As Object In GBPaymentType.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function CheckEyeGlasses(ByVal GB As GroupBox) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function CheckRadio(ByVal GBox As GroupBox, ByVal Value As Boolean) As Boolean
        For Each Obj As Object In GBox.Controls
            If TypeOf Obj Is RadioButton Then
                Dim rd As RadioButton = CType(Obj, RadioButton)
                rd.Checked = Value
            End If
        Next
    End Function

    Private Sub GridItemDetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridItemDetail.GotFocus
        GetBarcod()
    End Sub
    Sub GetBarcod()
        TxtGetBarcode.Text = ""
        TxtGetBarcode.Focus()
    End Sub

    Private Sub TxtGetBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGetBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadItemToAddProduct(TxtGetBarcode.Text)
            TxtGetBarcode.Text = ""
            TxtGetBarcode.Focus()
        End If
    End Sub
    Sub LoadItemToAddProduct(ByVal ProductCode As String)
        Dim TblTemItem As DataTable = ItemPrice.GetDataByBarcode(ProductCode, DEPART_ID) '  ItemOpticalshop.GetDataByBarcode(TxtItemBarcode.Text)
        Dim FAddNewItem As New FrmAddItemInOpticalShop(Me)
        If TblTemItem.Rows.Count <= 0 Then
            'CboBarcode.Focus()
            Exit Sub
        Else
            For Each row As DataRow In TblTemItem.Rows
                FAddNewItem.TxtBarcode.Text = TxtGetBarcode.Text
                FAddNewItem.TxtBarcode.ReadOnly = True
                FAddNewItem.LblItemID.Text = row("ItemID")
                FAddNewItem.TxtItemName.Text = row("ItemName")
                If TypeOf row("Price") Is DBNull Then
                    FAddNewItem.TxtItemPrice.Text = ""
                Else
                    FAddNewItem.TxtItemPrice.Text = row("Price")
                End If

                'If row("IsUSD") = True Then
                '    LblPrice.Text = "Price:(ដុល្លារ)"
                '    IsDolar = True
                'Else
                '    IsDolar = False
                'End If
                'If row("IsKHR") = True Then
                '    LblPrice.Text = "Price:(រៀល)"
                'End If
                If TypeOf row("Picture") Is DBNull Then
                    FAddNewItem.PictItem.Visible = False
                Else
                    ImageStream = New System.IO.MemoryStream(CType(row("Picture"), Byte()))
                    FAddNewItem.PictItem.Visible = True
                    FAddNewItem.PictItem.Image = Image.FromStream(ImageStream)
                End If
            Next
            FAddNewItem.TxtItemQTY.Focus()
            FAddNewItem.ShowDialog()
        End If
    End Sub

    Private Sub BtnAddCustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddCustomer.GotFocus
        GetBarcod()
    End Sub

    Private Sub BtnCleanCustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCleanCustomer.GotFocus
        GetBarcod()
    End Sub

    Private Sub TxtCustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustomerName.GotFocus
        GetBarcod()
    End Sub

    Private Sub BtnNewCustomer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        GetBarcod()
    End Sub

    Private Sub DateCreateReceipt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateCreateReceipt.GotFocus
        GetBarcod()
    End Sub

    Private Sub BtnAddItem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAddItem.GotFocus
        GetBarcod()
    End Sub

    Private Sub BtnRemoveItem_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.GotFocus
        GetBarcod()
    End Sub

    Private Sub TxtCusOccupation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCusOccupation.GotFocus
        GetBarcod()
    End Sub

    Private Sub TxtSex_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSex.GotFocus
        GetBarcod()
    End Sub

    Private Sub TxtAge_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAge.GotFocus
        GetBarcod()
    End Sub

    Private Sub TxtTotalAsReal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalAsReal.GotFocus
        GetBarcod()
    End Sub

    Private Sub ChPrintPreview_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChPrintPreview.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadSpectacle_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadCustomerMadeSpectacle.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadSunGlasses_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadSunGlasses.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadReadMod_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadReadyMadeSpectacle.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadMedicine_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadMedicine.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadFundRaising_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadFundRaising.GotFocus
        GetBarcod()
    End Sub

    Private Sub RadOther_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadOther.GotFocus
        GetBarcod()
    End Sub

    Private Sub ChDonation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChDonation.GotFocus
        GetBarcod()
    End Sub

    Private Sub CboDonation_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        GetBarcod()
    End Sub

    Private Sub BtnSelectPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelectPatient.Click
        'If ChPatient.Checked = False Then
        Dim FSelectPatient As New SelectPatient
        FSelectPatient.PatientOption = 1 '--- Select Patient to create invoice
        If FSelectPatient.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtCustomerID.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("PatientNo").Value
            TxtCustomerNo.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("PatientNo").Value
            TxtCustomerName.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("NameKhmer").Value
            TxtCusNameEng.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("NameEng").Value
            TxtSex.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("Sex").Value
            TxtAge.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("Age").Value
            txtAddress.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("Address").Value
            TxtCusOccupation.Text = FSelectPatient.GridPatientInformation.GetRow(0).Cells("Occupation").Value
            Me.LblCombindReferal.Text = ModNew_Outpatient.Get_CombindReferal(FSelectPatient.GridPatientInformation.GetRow(0).Cells("PatientNo").Value)
            IsPatient = True
            'CheOldPatient.Checked = False
            CheckIsPatientConsult(EmptyString(TxtCustomerNo.Text), "Optical Shop", 0)

        End If
        'Else
        '    Dim FNewCustomer As New NewCustomer
        '    If FNewCustomer.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        TxtCustomerName.Text = FNewCustomer.TxtCusName.Text
        '        TxtCustomerNo.Text = FNewCustomer.CutomereID
        '        TxtSex.Text = FNewCustomer.CboSex.Text
        '        TxtAge.Text = FNewCustomer.TxtAge.Text
        '        txtAddress.Text = FNewCustomer.TxtAddress.Text
        '        TxtCusOccupation.Text = FNewCustomer.CboOccupation.Text
        '    End If
        'End If
    End Sub

    Private Sub BgSaveAndPrinting_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgSaveAndPrinting.DoWork
        SaveReceipt()
    End Sub

    Private Sub BgSaveAndPrinting_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgSaveAndPrinting.RunWorkerCompleted
        Me.MTakeoInventory.StatusLoading(False)
        Application.DoEvents()
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub TxtDonateAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SetDisableKeyString(e)
    End Sub

    Private Sub ChbNewGlasses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChbNewGlasses.CheckedChanged

        TxtNumGlasses.Enabled = ChbNewGlasses.Checked
        If ChbNewGlasses.Checked = True Then
            TxtNumGlasses.Text = "1"
        Else
            TxtNumGlasses.Text = ""
        End If

    End Sub

    Private Sub TxtNumGlasses_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumGlasses.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadMedicine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMedicine.CheckedChanged
        ChbNewGlasses.Enabled = Not (RadMedicine.Checked)

        If RadMedicine.Checked = True Then
            TxtNumGlasses.Text = ""
            TxtNumGlasses.Enabled = False
            ChbNewGlasses.Checked = False
        End If
    End Sub

    Private Sub RadOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOther.CheckedChanged
        ChbNewGlasses.Enabled = Not (RadOther.Checked)
        If RadOther.Checked = True Then
            TxtNumGlasses.Text = ""
            TxtNumGlasses.Enabled = False
            ChbNewGlasses.Checked = False
        End If
    End Sub

    Private Sub RadFundRaising_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFundRaising.CheckedChanged
        ChbNewGlasses.Enabled = Not (RadFundRaising.Checked)
        If RadFundRaising.Checked = True Then
            TxtNumGlasses.Text = ""
            TxtNumGlasses.Enabled = False
            ChbNewGlasses.Checked = False
        End If
    End Sub

    Private Sub RadSpectacle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCustomerMadeSpectacle.CheckedChanged
        ChbNewGlasses.Enabled = RadCustomerMadeSpectacle.Checked
        TxtNumGlasses.Enabled = True
        If RadCustomerMadeSpectacle.Checked = True Then
            CheckRadio(GBoxCustomerMade, False)

        Else
            CheckRadio(GBoxCustomerMade, False)
        End If
        GBoxCustomerMade.Enabled = RadCustomerMadeSpectacle.Checked
    End Sub

    Private Sub RadSunGlasses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSunGlasses.CheckedChanged
        ChbNewGlasses.Enabled = RadSunGlasses.Checked
        TxtNumGlasses.Enabled = True
    End Sub

    Private Sub RadReadMod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReadyMadeSpectacle.CheckedChanged
        ChbNewGlasses.Enabled = RadReadyMadeSpectacle.Checked
        TxtNumGlasses.Enabled = True
        If RadReadyMadeSpectacle.Checked = True Then
            CheckRadio(GBoxReadyMade, False)
        Else
            CheckRadio(GBoxReadyMade, False)
        End If
        GBoxReadyMade.Enabled = RadReadyMadeSpectacle.Checked
    End Sub

    Private Sub RadFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFull.CheckedChanged
        ' TxtFullAmount.ReadOnly = True
        TxtNilAmount.ReadOnly = Not (RadFull.Checked)
        TxtSocialAmount.ReadOnly = Not (RadFull.Checked)
        ChDonation.Enabled = False
        '--- Recalculate everything relate to amount incase user select Nil first
        CalculatePaymentNil()

        If RadKHR.Checked = True Then
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsReal.Text
            End If
        Else
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsDolar.Text
            End If
        End If

        'TxtFullAmount.ReadOnly = True
        TxtNilAmount.Text = ""
        TxtSocialAmount.Text = ""

    End Sub

    Private Sub RadNil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadNil.CheckedChanged

        If RadNil.Checked = True Then
            TxtReceiptNo.Text = 0
            TxtFullAmount.Enabled = Not (RadNil.Checked)
            TxtNilAmount.Enabled = RadNil.Checked
            TxtSocialAmount.Enabled = Not (RadNil.Checked)
            ChDonation.Enabled = True
            'TxtNilAmount.Text = "0.00"
            'TxtNilAmount.ReadOnly = True
            'TxtFullAmount.Text = ""
            'TxtSocialAmount.Text = ""

            ''-- Clear everything relate to amount equal zero
            'TxtTotalAsReal.Text = "0.00"
            'TxtTotalAsDolar.Text = "0.00"

            ''--- Set column Total R and Total $ equal zero
            CalculatePaymentNil()
        Else
            LoadNewReceiptNo()
        End If

    End Sub

    Private Sub RadSocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSocial.CheckedChanged
        TxtFullAmount.Enabled = Not (RadSocial.Checked)
        TxtNilAmount.Enabled = Not (RadSocial.Checked)
        TxtSocialAmount.Enabled = RadSocial.Checked
        ChDonation.Enabled = True
        TxtFullAmount.Text = ""
        TxtNilAmount.Text = ""

        '--- Recalculate everything relate to amount incase user select Nil first
        CalculatePaymentNil()
    End Sub
    Private Sub TxtFullAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFullAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtNilAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNilAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtSocialAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSocialAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CalculatePaymentNil()

        If RadNil.Checked = True Then
            'With GridItemDetail
            '    For Each rRow As DataGridViewRow In .Rows
            '        rRow.Cells("SubTotal").Value = "0"
            '        rRow.Cells("SubTotalDolar").Value = "0"
            '    Next
            'End With
            'TxtTotalAsReal.Text = "0"
            'TxtTotalAsDolar.Text = "0"
        Else
            '--- Suppose item price in USD
            With GridItemDetail
                For Each rRow As DataGridViewRow In .Rows
                    rRow.Cells("SubTotal").Value = Round(rRow.Cells("ColumnPrice").Value * rRow.Cells("ColumnQTY").Value * Val(txtRate.Text), 2)
                    rRow.Cells("SubTotalDolar").Value = Round(rRow.Cells("ColumnPrice").Value * rRow.Cells("ColumnQTY").Value, 2)
                Next
            End With
            '--- ReCalculate Invoice Total
            CheckCalculatReceipt()
        End If

    End Sub

    Private Sub RadKHR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadKHR.CheckedChanged
        If RadKHR.Checked = True Then
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsReal.Text
            End If
        Else
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsDolar.Text
            End If
        End If
    End Sub

    Private Sub RadUSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadUSD.CheckedChanged
        If RadUSD.Checked = True Then
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsDolar.Text
            End If
        Else
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsReal.Text
            End If
        End If
    End Sub


    Private Sub cmdAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRate.Click
        GetRates()
    End Sub
    Function PaymentTypeLabel() As String
        If RadCustomerMadeSpectacle.Checked = True Then
            If RadDistance1.Checked = True Then
                Return RadCustomerMadeSpectacle.Text & " For " & RadDistance1.Text
            End If
            If RadRedding1.Checked = True Then
                Return RadCustomerMadeSpectacle.Text & " For " & RadRedding1.Text
            End If
            If RadBifocal.Checked = True Then
                Return RadCustomerMadeSpectacle.Text & " For " & RadBifocal.Text
            End If
        ElseIf RadReadyMadeSpectacle.Checked = True Then
            If RadDistance2.Checked = True Then
                Return RadReadyMadeSpectacle.Text & " For " & RadDistance2.Text
            End If
            If RadRedding2.Checked = True Then
                Return RadReadyMadeSpectacle.Text & " For " & RadRedding2.Text
            End If
        ElseIf RadSunGlasses.Checked = True Then
            Return RadSunGlasses.Text
        ElseIf RadFundRaising.Checked = True Then
            Return RadFundRaising.Text
        ElseIf RadLV.Checked = True Then
            Return RadLV.Text
        ElseIf RadMedicine.Checked = True Then
            Dim StrMedicine As String = ""
            For I As Integer = 0 To GridItemDetail.Rows.Count - 1
                StrMedicine = StrMedicine & " ," & GridItemDetail.Rows(I).Cells("ColumnName").Value
            Next
            Return StrMedicine
        ElseIf RadOther.Checked = True Then
            Return RadOther.Text
        End If
    End Function
    Function PaymentForGlasessOrMedicine() As Integer
        If RadCustomerMadeSpectacle.Checked = True Then
            Return 1
        ElseIf RadReadyMadeSpectacle.Checked = True Then
            Return 1
        ElseIf RadSunGlasses.Checked = True Then
            Return 1
        ElseIf RadLV.Checked = True Then
            Return 1
        ElseIf RadFundRaising.Checked = True Then
            Return 0
        ElseIf RadMedicine.Checked = True Then
            Return 2
        ElseIf RadOther.Checked = True Then
            Return 0
        End If
    End Function



    Private Sub TxtDonateAmount_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonateAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub RadLV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadLV.CheckedChanged
        ChbNewGlasses.Enabled = Not (RadLV.Checked)
        If RadFundRaising.Checked = True Then
            TxtNumGlasses.Text = ""
            TxtNumGlasses.Enabled = False
            ChbNewGlasses.Checked = False
        End If
    End Sub
End Class