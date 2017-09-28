Imports System.Data.Common

Public Class frmAddCaritasRequestOrder

    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Private THIDataContext As New BaseDataContext
    Public labelStatus As String
    Public IsRequestExistingItem As Boolean
    Public requestID As String

    '--- Parameter for Modification mode ---
    Public RequestCreator As String
    Public RequestNumber As String
    Public Comment As String
    Public RequestDate As String
    Dim CaritasReqDetailDataAdapter As DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Dim CaritasDT As New DSHospitalRequestToCaritas.CaritasReqDataTableDataTable
    Dim DA_USED As New DSHospitalRequestToCaritasTableAdapters.VREQUEST_USEDTableAdapter



    Public Sub New(ByVal mainCaritasRequestOrder As UCCaritasRequestOrder)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UCaritasRequestOrder = mainCaritasRequestOrder
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmAddCaritasRequestOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CaritasReqDetailDataAdapter = New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter

        If IsRequestExistingItem = True Then
            Select Case labelStatus
                Case "Open"
                    '--- Generate Request Order Number (Format : RO 0000000000).
                    txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                    lbUserRequest.Text = USER_NAME
                    dtpRDate.Value = GetDateServer()
                    requestID = GetMaxRequestID()
                    rtbComment.Text = "Request item existing in hospital."

                Case "OpenEdit"
                    txtReOrNum.Text = RequestNumber
                    lbUserRequest.Text = RequestCreator
                    rtbComment.Text = Comment
                    dtpRDate.Value = DateTime.Parse(RequestDate)

                    '--- Load item request detail ----

                    Dim myDataTable As New DataTable
                    Dim obj(3) As Object
                    DGVRequestItemsDetail.Rows.Clear()
                    myDataTable = CaritasReqDetailDataAdapter.GetDataCaristasReqDetailByReqID(requestID)


                    For Each aRow As DataRow In myDataTable.Rows
                        With DGVRequestItemsDetail
                            obj(0) = aRow("ItemID") 'cItemNo
                            obj(1) = aRow("ItemName") 'cItemName
                            obj(2) = aRow("RequestQuantity") 'cRQuantity                            
                            obj(3) = aRow("Barcode")  'cBarcode
                            .Rows.Add(obj)
                        End With

                        Dim dataRow As DataRow = CaritasDT.NewRow
                        dataRow("ItemID") = aRow("ItemID")
                        dataRow("ItemName") = aRow("ItemName")
                        dataRow("RequestQuantity") = aRow("RequestQuantity")
                        dataRow("Barcode") = aRow("Barcode")
                        CaritasDT.Rows.Add(dataRow)

                    Next

            End Select
        Else '--- In case user request item not exist in hospital
            Select Case labelStatus
                Case "Open"
                    '--- Generate Request Order Number (Format : RO 0000000000).
                    txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                    lbUserRequest.Text = USER_NAME
                    dtpRDate.Value = GetDateServer()
                    requestID = GetMaxRequestID()
                    rtbComment.Text = "Request item not existing in hospital."

                Case "OpenEdit"

                    txtReOrNum.Text = RequestNumber
                    lbUserRequest.Text = RequestCreator
                    rtbComment.Text = Comment
                    dtpRDate.Value = DateTime.Parse(RequestDate)

                    '--- Load item request detail ----
                    Dim myDataTable As New DataTable
                    Dim obj(3) As Object
                    DGVRequestItemsDetail.Rows.Clear()
                    myDataTable = CaritasReqDetailDataAdapter.GetDataCaristasReqDetailByReqID(requestID)
                    For Each aRow As DataRow In myDataTable.Rows

                        With DGVRequestItemsDetail
                            obj(0) = aRow("ItemID") 'cItemNo
                            obj(1) = aRow("ItemName") 'cItemName
                            obj(2) = aRow("RequestQuantity") 'cRQuantity                            
                            obj(3) = aRow("Barcode")  'cBarcode
                            .Rows.Add(obj)
                        End With

                        Dim dataRow As DataRow = CaritasDT.NewRow
                        dataRow("ItemID") = aRow("ItemID")
                        dataRow("ItemName") = aRow("ItemName")
                        dataRow("RequestQuantity") = aRow("RequestQuantity")
                        dataRow("Barcode") = aRow("Barcode")
                        CaritasDT.Rows.Add(dataRow)
                    Next
                    '--- Load item request detail ----

            End Select
        End If

    End Sub

    Function GetMaxRequestID() As Double
        Try
            Dim q = (From Reqeust In THIDataContext.getTHIDataContext.CARITAS_REQUEST_INVENTORies _
                    Select Reqeust.RequestID).Max
            ' Return max request order id
            If Val(q) = 0 Then
                Return 1
            Else
                Return Val(q) + 1
            End If
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Private Sub btnAddItemReDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemReDetail.Click

        If IsRequestExistingItem = True Then
            Dim frm As New frmRequestItemsDetail(Me)
            frm.isDisplayItemInMainStock = True
            frm.isCheckStockRequest = True
            frm.stockDepartID = MAIN_STOCK_DEPART_ID
            frm.isCaritasReqOrder = True
            frm.ReqStatus = labelStatus

            'If labelStatus = "OpenEdit" Then
            frm.CaritasDataTable = CaritasDT
            '   End If
          
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.ChDateFrom.Value = frm.DateUsedFrom.Value
                Me.ChDateTo.Value = frm.DateUsedTo.Value
                Select Case labelStatus
                    Case "Open"
                        DGVRequestItemsDetail.DataSource = frm.CaritasDataTable
                    Case "OpenEdit"
                        DGVRequestItemsDetail.DataSource = frm.CaritasDataTable
                End Select
            End If
        Else


            Dim frm As New frmRequestItemsDetail()
            frm.isDisplayItemOutside = True
            frm.isCaritasReqOrder = True

            'If labelStatus = "OpenEdit" Then
            frm.CaritasDataTable = CaritasDT
            'End If
            frm.SplitContainer1.Panel1Collapsed = True
            frm.ChItemUsed.Visible = False
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Select Case labelStatus
                    Case "Open"
                        'DGVRequestItemsDetail.DataSource = frm.CaritasDataTable
                        RefreshgridItems(frm.CaritasDataTable)
                    Case "OpenEdit"
                        'DGVRequestItemsDetail.DataSource = frm.CaritasDataTable
                        RefreshgridItems(frm.CaritasDataTable)
                End Select
            End If
        End If
    End Sub

    Sub RefreshgridItems(ByVal pDataTable As DataTable)
        DGVRequestItemsDetail.DataSource = pDataTable
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        With DGVRequestItemsDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete item Request Detail ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub
    Private Function TotalBeginStock(ByVal ItID As Integer, ByVal dateFrom As Date, ByVal dTo As Date) As Integer
        Dim Begin As Integer = 0
        Dim TblUsded1 As DataTable = DA_USED.SelectItemUsedInfo(ItID, dateFrom, dTo)
        Dim Count As Integer = 0
        For Each row As DataRow In TblUsded1.Rows
            Count = Count + 1
            If Count <= 1 Then
                Return row("BeginBalance")
            End If

        Next

    End Function
    Private Function TotalUsed(ByVal ItID As Integer, ByVal dateFrom As Date, ByVal dTo As Date) As Integer
        Dim Used As Integer = 0
        Dim TblUsded1 As DataTable = DA_USED.SelectItemUsedInfo(ItID, dateFrom, dTo)
        For Each row As DataRow In TblUsded1.Rows
            Used = Used + row("UsedQTY")
        Next
        Return Used
    End Function
    Private Function TotalEndingBalacne(ByVal ItID As Integer, ByVal dateFrom As Date, ByVal dTo As Date) As Integer
        Dim EndBalance As Integer = 0
        Dim TblUsded1 As DataTable = DA_USED.SelectItemUsedInfo(ItID, dateFrom, dTo)
        For Each row As DataRow In TblUsded1.Rows
            EndBalance = row("EndBalance")
        Next
        Return EndBalance
    End Function
    Private Function TotalReceived(ByVal ItID As Integer, ByVal dateFrom As Date, ByVal dTo As Date) As Integer
        Dim TotalReceive As Integer = 0
        Dim TblUsded1 As DataTable = DA_USED.SelectItemUsedInfo(ItID, dateFrom, dTo)
        For Each row As DataRow In TblUsded1.Rows
            TotalReceive = TotalReceive + row("ReceivedQty")
        Next
        Return TotalReceive
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateDateTimePicker(ChDateFrom, "", ErrRequest) = False Then Exit Sub
        If ValidateDateTimePicker(ChDateTo, "", ErrRequest) = False Then Exit Sub
        If IsRequestExistingItem = True Then
            Select Case labelStatus
                Case "Open"
                    SaveCaritasRequestOrderInStatusOpen()
                Case "OpenEdit"
                    SaveEditCaritasRequestOrderInStatusOpen()
            End Select
        Else
            'Select Case labelStatus
            '    Case "Open"
            '        SaveCaritasRequestOrderInStatusOpenItemOutside()
            '    Case "OpenEdit"
            '        SaveEditCaritasRequestOrderInStatusOpenItemOutside()
            'End Select

        End If


    End Sub

    Sub SaveEditCaritasRequestOrderInStatusOpen()
        Dim TransMsgStatus As String = ""

        '--- Validation before add new request
        If DGVRequestItemsDetail.Rows.Count = 0 Then
            MessageBox.Show("Please add request item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows

            If IsDBNull(rRow.Cells("cRQuantity").Value) Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If rRow.Cells("cRQuantity").Value = Nothing Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If rRow.Cells("cRQuantity").Value.ToString = "" Or rRow.Cells("cRQuantity").Value.ToString = "0" Then
                    MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next

        If MessageBox.Show("Do you want save new Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try

                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM CARITAS_REQUEST_DETAIL_INVENTORY WHERE RequestID={0}", Val(requestID))
                THIDataContext.getTHIDataContext.SubmitChanges()

                'CaritasRequestOrder.ItemUsedFrom = ChDateFrom.Value.Date
                'CaritasRequestOrder.ItemUsedTo = ChDateTo.Value.Date

                '--- Insert into CARITAS_REQUEST_DETAIL_INVENTORY
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim BeginStock As Integer = 0
                    Dim UsedInStock As Integer = 0
                    Dim EndBalance As Integer = 0
                    Dim Recieve As Integer = 0
                    Dim CaritasRequestDetail As New CARITAS_REQUEST_DETAIL_INVENTORY
                    CaritasRequestDetail.RequestID = Val(requestID)
                    CaritasRequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    CaritasRequestDetail.RequestQuantity = Val(rRow.Cells("cRQuantity").Value)
                    CaritasRequestDetail.ItemName = rRow.Cells("cItemName").Value
                    CaritasRequestDetail.Barcode = rRow.Cells("cBarcode").Value
                    CaritasRequestDetail.ReceivedQuantity = 0
                   
                    CaritasRequestDetail.IsReceive = False
                    CaritasRequestDetail.IsReady = False
                    '--- Get item balance current stock
                    'Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = Val(rRow.Cells("cItemNo").Value)
                    'BeginStock = qMainStock.SingleOrDefault.UnitsInStock

                    'CaritasRequestDetail.PresentStock = BeginStock

                    BeginStock = TotalBeginStock(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    UsedInStock = TotalUsed(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    EndBalance = TotalEndingBalacne(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    Recieve = TotalReceived(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    CaritasRequestDetail.PresentStock = BeginStock
                    CaritasRequestDetail.ItemUsed = UsedInStock
                    CaritasRequestDetail.ReceivedQuantity = 0
                    CaritasRequestDetail.ReceivedDoReport = Recieve
                    CaritasRequestDetail.Balance = (BeginStock + Recieve) - UsedInStock
                    THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies.InsertOnSubmit(CaritasRequestDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                Next

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                requestID = GetMaxRequestID()
                THIDataContext.getTHIDataContext.Connection.Close()
                TransMsgStatus = ex.Message
            Finally
                trans = Nothing
            End Try

            If TransMsgStatus = "" Then
                MsgBox("Save new request order successful.")
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
    Sub SaveEditCaritasRequestOrderInStatusOpenItemOutside()
        Dim TransMsgStatus As String = ""

        '--- Validation before add new request
        If DGVRequestItemsDetail.Rows.Count = 0 Then
            MessageBox.Show("Please add request item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows

            If IsDBNull(rRow.Cells("cRQuantity").Value) Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If rRow.Cells("cRQuantity").Value = Nothing Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If rRow.Cells("cRQuantity").Value.ToString = "" Or rRow.Cells("cRQuantity").Value.ToString = "0" Then
                    MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next


        If MessageBox.Show("Do you want save new Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try

                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM CARITAS_REQUEST_DETAIL_INVENTORY WHERE RequestID={0}", Val(requestID))
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Insert into CARITAS_REQUEST_DETAIL_INVENTORY
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim unitsInStock As Integer = 0
                    Dim CaritasRequestDetail As New CARITAS_REQUEST_DETAIL_INVENTORY
                    CaritasRequestDetail.RequestID = Val(requestID)
                    CaritasRequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    CaritasRequestDetail.RequestQuantity = Val(rRow.Cells("cRQuantity").Value)
                    CaritasRequestDetail.ItemName = rRow.Cells("cItemName").Value

                    THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies.InsertOnSubmit(CaritasRequestDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                Next

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                requestID = GetMaxRequestID()
                THIDataContext.getTHIDataContext.Connection.Close()
                TransMsgStatus = ex.Message
            Finally
                trans = Nothing
            End Try

            If TransMsgStatus = "" Then
                MessageBox.Show("Save new request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Sub SaveCaritasRequestOrderInStatusOpen()

        Dim TransMsgStatus As String = ""

        '--- Validation before add new request
        If DGVRequestItemsDetail.Rows.Count = 0 Then
            MessageBox.Show("Please add request item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows

            If IsDBNull(rRow.Cells("cRQuantity").Value) Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If rRow.Cells("cRQuantity").Value = Nothing Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If rRow.Cells("cRQuantity").Value.ToString = "" Or rRow.Cells("cRQuantity").Value.ToString = "0" Then
                    MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next

        If MessageBox.Show("Do you want save new Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Insert into CARITAS_REQUEST_INVENTORY
                Dim CaritasRequestOrder As New CARITAS_REQUEST_INVENTORY
                CaritasRequestOrder.RequestOrderNumber = txtReOrNum.Text
                CaritasRequestOrder.RequestDate = dtpRDate.Value.Date
                CaritasRequestOrder.Comment = rtbComment.Text
                CaritasRequestOrder.IsRequestExistingItem = True
                CaritasRequestOrder.UserID = CInt(USER_ID)
                CaritasRequestOrder.ItemUsedFrom = ChDateFrom.Value.Date
                CaritasRequestOrder.ItemUsedTo = ChDateTo.Value.Date
                CaritasRequestOrder.Status = 0

                THIDataContext.getTHIDataContext.CARITAS_REQUEST_INVENTORies.InsertOnSubmit(CaritasRequestOrder)
                THIDataContext.getTHIDataContext.SubmitChanges()

              
                '--- Insert into CARITAS_REQUEST_DETAIL_INVENTORY
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim BeginStock As Integer = 0
                    Dim UsedInStock As Integer = 0
                    Dim EndBalance As Integer = 0
                    Dim Recieve As Integer = 0
                   
                    Dim CaritasRequestDetail As New CARITAS_REQUEST_DETAIL_INVENTORY
                    CaritasRequestDetail.RequestID = CaritasRequestOrder.RequestID
                    CaritasRequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    CaritasRequestDetail.RequestQuantity = Val(rRow.Cells("cRQuantity").Value)
                    CaritasRequestDetail.ItemName = rRow.Cells("cItemName").Value
                    CaritasRequestDetail.Barcode = rRow.Cells("cBarcode").Value
                    CaritasRequestDetail.ReceivedQuantity = 0
                    CaritasRequestDetail.IsReceive = False
                    CaritasRequestDetail.IsReady = False
                    '--- Get item balance current stock
                    'Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = Val(rRow.Cells("cItemNo").Value)
                    'unitsInStock = qMainStock.SingleOrDefault.UnitsInStock
                    BeginStock = TotalBeginStock(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    UsedInStock = TotalUsed(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    EndBalance = TotalEndingBalacne(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    Recieve = TotalReceived(rRow.Cells("cItemNo").Value, ChDateFrom.Value.Date, ChDateTo.Value.Date)
                    CaritasRequestDetail.PresentStock = BeginStock
                    CaritasRequestDetail.ItemUsed = UsedInStock
                    CaritasRequestDetail.ReceivedQuantity = 0
                    CaritasRequestDetail.ReceivedDoReport = Recieve
                    CaritasRequestDetail.Balance = (BeginStock + Recieve) - UsedInStock
                    THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies.InsertOnSubmit(CaritasRequestDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                Next

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                requestID = GetMaxRequestID()
                THIDataContext.getTHIDataContext.Connection.Close()
                TransMsgStatus = ex.Message
            Finally
                trans = Nothing
            End Try

            If TransMsgStatus = "" Then                
                MessageBox.Show("Save new request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Sub SaveCaritasRequestOrderInStatusOpenItemOutside()


        Dim TransMsgStatus As String = ""

        '--- Validation before add new request
        If DGVRequestItemsDetail.Rows.Count = 0 Then
            MessageBox.Show("Please add request item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows

            If IsDBNull(rRow.Cells("cRQuantity").Value) Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If rRow.Cells("cRQuantity").Value = Nothing Then
                MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                If rRow.Cells("cRQuantity").Value.ToString = "" Or rRow.Cells("cRQuantity").Value.ToString = "0" Then
                    MessageBox.Show("Please input request item quantity of <<" & rRow.Cells("cItemName").Value & ">> in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        Next


        If MessageBox.Show("Do you want save new Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Insert into CARITAS_REQUEST_INVENTORY
                Dim CaritasRequestOrder As New CARITAS_REQUEST_INVENTORY
                CaritasRequestOrder.RequestOrderNumber = txtReOrNum.Text
                CaritasRequestOrder.RequestDate = dtpRDate.Value.Date
                CaritasRequestOrder.Comment = rtbComment.Text
                CaritasRequestOrder.IsRequestExistingItem = False
                CaritasRequestOrder.UserID = CInt(USER_ID)
                CaritasRequestOrder.Status = 0

                THIDataContext.getTHIDataContext.CARITAS_REQUEST_INVENTORies.InsertOnSubmit(CaritasRequestOrder)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Insert into CARITAS_REQUEST_DETAIL_INVENTORY
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim unitsInStock As Integer = 0
                    Dim CaritasRequestDetail As New CARITAS_REQUEST_DETAIL_INVENTORY
                    CaritasRequestDetail.RequestID = CaritasRequestOrder.RequestID
                    CaritasRequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    CaritasRequestDetail.RequestQuantity = Val(rRow.Cells("cRQuantity").Value)
                    CaritasRequestDetail.ItemName = rRow.Cells("cItemName").Value
                    CaritasRequestDetail.ReceivedQuantity = 0
                    CaritasRequestDetail.IsReceive = False
                    CaritasRequestDetail.IsReady = False
                    THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies.InsertOnSubmit(CaritasRequestDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                Next

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                txtReOrNum.Text = "RO" & String.Format("{0:0000000000}", GetMaxRequestID())
                requestID = GetMaxRequestID()
                THIDataContext.getTHIDataContext.Connection.Close()
                TransMsgStatus = ex.Message
            Finally
                trans = Nothing
            End Try

            If TransMsgStatus = "" Then
                MessageBox.Show("Save new request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class