Imports System.Data.Common
Imports System.Math

Public Class frmRecItemAttribute

    Public ItemName As String
    Public ReqQuantity As String
    Public ItemID As Integer
    Public RequestDetailID As Double

    Dim CurrDataAdapter As DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
    Public DTTmpRecItemAtt As DataTable = New DSHospitalRequestToCaritas.REC_ITEM_ATTDataTable
    Public DonationDataAdapter As DSOpticalShopTableAdapters.DONATIONTableAdapter
    Public ProviderDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Public CaritasReqDetailDataAdapter As DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Public CaritasItemProvider As DSHospitalRequestToCaritasTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
    Public VendorRepo As IVendorRepository = New VendorRepository

    Sub GetRates()
        With MRates.GetRateChange()
            If .Rows.Count > 0 Then
                Me.txtRate.Text = .Rows(0).Item(0)
            End If
        End With
    End Sub
    Private Sub frmRecItemAttribute_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call GetRates()
        TxtItemName.Text = ItemName
        With CbCost
            .DataSource = CurrDataAdapter.GetData
            .ValueMember = "CurrencyID"
            .DisplayMember = "Currency"
            .SelectedIndex = 0
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbDonation
            .DataSource = ProviderDataAdapter.GetDonatorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = 0
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        With CbVendor
            .DataSource = ProviderDataAdapter.GetVendorDataList
            .ValueMember = "VenderID"
            .DisplayMember = "VenderName"
            .SelectedIndex = 0
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        CbDonation.Enabled = False
        CbVendor.Enabled = False

        '--- Loading gridProviderDetail
        Dim CaritasReDetailDT As DataTable = CaritasReqDetailDataAdapter.GetCaritasReqDetailByID(RequestDetailID)
        For Each row As DataRow In CaritasReDetailDT.Rows
            If TypeOf row("ReceivedQuantity") Is DBNull = False Then
                TxtRecQuantity.Text = row("ReceivedQuantity")
            End If

            If TypeOf row("ExpiredDate") Is DBNull = False Then
                dtpExDate.Checked = True
                dtpExDate.Value = row("ExpiredDate")
            End If

        Next

        Dim CaristasItemProviderDT As DataTable = CaritasItemProvider.GetItemProviderInfoByReqDetailID(RequestDetailID)
        For Each row As DataRow In CaristasItemProviderDT.Rows

            Dim obj(6) As Object
            With gridProviderDetail
                obj(0) = VendorRepo.GetVendorNameByID(CInt(row("ProviderID")))
                obj(1) = row("GivenQty")
                obj(2) = row("Cost")
                obj(3) = GetCurByCurID(CInt(row("CurrencyID")))
                obj(4) = row("TotalCost")
                obj(5) = row("ProviderID")
                obj(6) = row("CurrencyID")
                .Rows.Add(obj)
            End With
        Next

        gridProviderDetail.Columns("ProviderID").Visible = False
        gridProviderDetail.Columns("CurrencyID").Visible = False



    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        CurrDataAdapter = New DSCategoriesAndItemsTableAdapters.CURRENCYTableAdapter
        DonationDataAdapter = New DSOpticalShopTableAdapters.DONATIONTableAdapter
        ProviderDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        CaritasReqDetailDataAdapter = New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
        CaritasItemProvider = New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQ_ITEM_PROVIDER_INFOTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If ValidateTextField(TxtRecQuantity, "", ErrorValidation) = False Then Exit Sub
        If MessageBox.Show("Do you want save received item information ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim NewDR As DataRow = Me.DTTmpRecItemAtt.NewRow
            NewDR("ExpiredDate") = dtpExDate.Value.Date

            NewDR("ReceivedQuantity") = TxtRecQuantity.Text
            DTTmpRecItemAtt.Rows.Add(NewDR)

            Dim THIDataContext As New BaseDataContext
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Delete CARITAS_REQ_ITEM_PROVIDER_INFO
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM CARITAS_REQ_ITEM_PROVIDER_INFO WHERE RequestDetailID={0}", RequestDetailID)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Save CARITAS_REQ_ITEM_PROVIDER_INFO 
                With gridProviderDetail
                    For Each rRow As DataGridViewRow In .Rows
                        Dim CaritasProInfo As New CARITAS_REQ_ITEM_PROVIDER_INFO
                        CaritasProInfo.RequestDetailID = RequestDetailID
                        CaritasProInfo.ItemID = ItemID
                        CaritasProInfo.ProviderID = Val(rRow.Cells("ProviderID").Value)
                        CaritasProInfo.GivenQty = Val(rRow.Cells("GivenQty").Value)
                        CaritasProInfo.Cost = Val(rRow.Cells("Cost").Value)
                        CaritasProInfo.CurrencyID = Val(rRow.Cells("CurrencyID").Value)
                        If Val(rRow.Cells("CurrencyID").Value) = 2 Then '--- In case import cost in KHR
                            CaritasProInfo.CostInUSD = Round(Val(rRow.Cells("Cost").Value) / Val(txtRate.Text), 2)
                        ElseIf Val(rRow.Cells("CurrencyID").Value) = 1 Then
                            CaritasProInfo.CostInUSD = Val(rRow.Cells("Cost").Value)
                        Else ' incase item cost in other currency beside from KHR or USD
                            CaritasProInfo.CostInUSD = 0
                        End If

                        CaritasProInfo.TotalCost = Val(rRow.Cells("TotalCost").Value)
                        CaritasProInfo.ExpiredDateRecItem = rRow.Cells("ExpiredDate").Value
                        THIDataContext.getTHIDataContext.CARITAS_REQ_ITEM_PROVIDER_INFOs.InsertOnSubmit(CaritasProInfo)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                End With

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MsgBox("Error : " & ex.Message)
            Finally
                trans = Nothing
            End Try
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub TxtRecQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecQuantity.KeyPress
        SetDisableKeyString(e)
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

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click


        If ValidateTextField(TxtCost, "", ErrorValidation) = False Then Exit Sub
        If ValidateTextField(TxtGivenQty, "", ErrorValidation) = False Then Exit Sub
        If RbDonator.Checked = False And RbVendor.Checked = False Then
            MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If RbDonator.Checked = True Then
            If CbDonation.SelectedValue Is Nothing Then
                MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If RbVendor.Checked = True Then
            If CbVendor.SelectedValue Is Nothing Then
                MessageBox.Show("Please select item's provider", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Dim obj(7) As Object
        Dim ProviderName As String = ""
        Dim ProviderID As Integer = 0
        Dim totalCost As Double = 0
        If RbDonator.Checked = True Then
            ProviderName = CbDonation.Text
            ProviderID = CbDonation.SelectedValue
        End If

        If RbVendor.Checked = True Then
            ProviderName = CbVendor.Text
            ProviderID = CbVendor.SelectedValue
        End If

        totalCost = Val(TxtCost.Text) * Val(TxtGivenQty.Text)

        With gridProviderDetail
            obj(0) = ProviderName
            obj(1) = TxtGivenQty.Text
            obj(2) = TxtCost.Text
            obj(3) = CbCost.Text
            obj(4) = totalCost
            obj(5) = ProviderID
            obj(6) = CbCost.SelectedValue
            If DTPRecItemExpired.Checked = True Then
                obj(7) = DTPRecItemExpired.Value.Date
            Else
                obj(7) = Nothing
            End If

            If gridProviderDetail.Rows.Count = 0 Then
                gridProviderDetail.Rows.Add(obj)
                TxtRecQuantity.Text = Val(TxtRecQuantity.Text) + Val(TxtGivenQty.Text)
            Else
                If IsDupValidateProvider(obj, ProviderID) = False Then
                    gridProviderDetail.Rows.Add(obj)
                    TxtRecQuantity.Text = Val(TxtRecQuantity.Text) + Val(TxtGivenQty.Text)
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
                    TxtRecQuantity.Text = Val(TxtRecQuantity.Text) - Val(rRow.Cells("GivenQty").Value)
                    .Rows.Remove(rRow)
                End If
            Next
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

    Private Sub TxtGivenQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGivenQty.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCost.KeyPress
        SetDisableKeyString(e)
    End Sub

    Function GetCurByCurID(ByVal CurID As Integer) As String
        Dim THIDataContext As New BaseDataContext
        Try
            Dim q = From cur In THIDataContext.getTHIDataContext.CURRENCies Where cur.CurrencyID = CurID
            Return q.SingleOrDefault.Currency
        Catch ex As Exception
            MsgBox("Error get currency : " & ex.Message)
            Return ""
        End Try
    End Function

End Class