Imports Janus.Windows.GridEX
Imports System.Data.Common
Imports System.Threading

Public Class UCCaritasRequestOrder

    Dim DSHosRequestCaritas As New DSHospitalRequestToCaritas
    Dim CaristasRequestMain As New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_INVENTORYTableAdapter
    Dim CaristasRequestDetail As New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Dim IUser As IUserManagement = New UserManagementImplement
    Private THIDataContext As New BaseDataContext


    Dim RequestItemRepo As IRequestDetailRepository = New RequestDetailRepository

    Private Sub subMenuRequestExitingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuRequestExitingItem.Click

        Dim FAddCaritasRequestOrder As New frmAddCaritasRequestOrder(Me)
        FAddCaritasRequestOrder.labelStatus = "Open"
        FAddCaritasRequestOrder.IsRequestExistingItem = True
        If FAddCaritasRequestOrder.ShowDialog() = DialogResult.OK Then
            LoadByDateRequest(dptFromDate.Value, dptToDate.Value)
        End If

        FAddCaritasRequestOrder.Close()
        FAddCaritasRequestOrder.Dispose()

    End Sub

    Private Sub subMenuRequestNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subMenuRequestNewItem.Click

        Dim FAddCaritasRequestOrder As New frmAddCaritasRequestOrder(Me)
        FAddCaritasRequestOrder.labelStatus = "Open"
        FAddCaritasRequestOrder.IsRequestExistingItem = False

        If FAddCaritasRequestOrder.ShowDialog() = DialogResult.OK Then
            LoadByDateRequest(dptFromDate.Value, dptToDate.Value)
        End If

        FAddCaritasRequestOrder.Close()
        FAddCaritasRequestOrder.Dispose()

    End Sub

    Sub LoadGridCaritasRequest()

        'CaristasRequestMain.GetData()
        CaristasRequestMain.FillBy(DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY)
        'CaristasRequestDetail.GetData()
        CaristasRequestDetail.Fill(DSHosRequestCaritas.CARITAS_REQUEST_DETAIL_INVENTORY)
        gridCaritasRequestOrder123.DataSource = DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY
        gridCaritasRequestOrder123.RootTable.ChildTables(0).DataMember = "CARITAS_REQUEST_INVENTORY_CARITAS_REQUEST_DETAIL_INVENTORY"

    End Sub
    Sub FillByRequestID(ByVal requestNo As Double)
        'CaristasRequestMain.GetData()
        CaristasRequestMain.FillByRequestID(DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY, requestNo)
        'CaristasRequestDetail.GetData()
        CaristasRequestDetail.Fill(DSHosRequestCaritas.CARITAS_REQUEST_DETAIL_INVENTORY)
        gridCaritasRequestOrder123.DataSource = DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY
        gridCaritasRequestOrder123.RootTable.ChildTables(0).DataMember = "CARITAS_REQUEST_INVENTORY_CARITAS_REQUEST_DETAIL_INVENTORY"

    End Sub
    Sub LoadByDateRequest(ByVal DFrom As Date, ByVal DTo As Date)
        CaristasRequestMain.FillByDateRequest(DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY, DFrom, DTo)
        CaristasRequestDetail.Fill(DSHosRequestCaritas.CARITAS_REQUEST_DETAIL_INVENTORY)
        gridCaritasRequestOrder123.DataSource = DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY
        gridCaritasRequestOrder123.RootTable.ChildTables(0).DataMember = "CARITAS_REQUEST_INVENTORY_CARITAS_REQUEST_DETAIL_INVENTORY"

    End Sub
    Sub FillReceivedStatus(ByVal Status As Integer)
        CaristasRequestMain.FillReceivedStatus(DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY, Status)
        CaristasRequestDetail.Fill(DSHosRequestCaritas.CARITAS_REQUEST_DETAIL_INVENTORY)
        gridCaritasRequestOrder123.DataSource = DSHosRequestCaritas.CARITAS_REQUEST_INVENTORY
        gridCaritasRequestOrder123.RootTable.ChildTables(0).DataMember = "CARITAS_REQUEST_INVENTORY_CARITAS_REQUEST_DETAIL_INVENTORY"

    End Sub

    Private Sub UCCaritasRequestOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'LoadGridCaritasRequest()
        LoadByDateRequest(dptFromDate.Value, dptToDate.Value)
    End Sub

    Private Sub menuRecRequestItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRecRequestItem.Click

        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then

                Dim FHospitalRecItem As New frmHospitalRecItem(Me)
                FHospitalRecItem.RequestID = gridCaritasRequestOrder123.GetValue("RequestID")
                FHospitalRecItem.RequestNumber = gridCaritasRequestOrder123.GetValue("RequestOrderNumber")
                FHospitalRecItem.RequestDate = gridCaritasRequestOrder123.GetValue("RequestDate")
                FHospitalRecItem.Comment = gridCaritasRequestOrder123.GetValue("Comment")
                FHospitalRecItem.IsRequestExistingItem = gridCaritasRequestOrder123.GetValue("IsRequestExistingItem")
                FHospitalRecItem.RequestCreator = IUser.GetUserNameByID(CInt(gridCaritasRequestOrder123.GetValue("UserID")))
                FHospitalRecItem.Status = gridCaritasRequestOrder123.GetValue("Status")

                If FHospitalRecItem.ShowDialog() = DialogResult.OK Then
                    FillByRequestID(FHospitalRecItem.RequestID)
                End If

                FHospitalRecItem.Close()
                FHospitalRecItem.Dispose()

            End If
        Catch ex As Exception
            MessageBox.Show("Please select main request order ", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub menuApprovedRecRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuApprovedRecRequest.Click

        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then
                '--- Add validation approve receive request order
                'If gridCaritasRequestOrder.GetValue("Status") = 0 Then
                '    MessageBox.Show("Please enter received item quantity before approve receive order.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Sub
                'End If

                If gridCaritasRequestOrder123.GetValue("Status") = 2 Then
                    MessageBox.Show("Request order already Approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim IsRequestExistingItem As Boolean = gridCaritasRequestOrder123.GetValue("IsRequestExistingItem")
                Dim requestID As Integer = gridCaritasRequestOrder123.GetValue("RequestID")

                '--- Update item quantity in stock
                If IsRequestExistingItem = True Then
                    'ApprovedRecReqExistItem(requestID)
                    If MessageBox.Show("Do you want save approved Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        BgRunReceived.RunWorkerAsync()
                    End If

                Else
                    '--- Update request status to close (equals 1)
                    'ApprovedRecReqNotExistItem(requestID)

                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Please select main request order ", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Delegate Sub DelegateAppovedReqExitItem(ByVal requestID As Integer)

    Private Sub BgRunReceived_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgRunReceived.DoWork
        Thread.Sleep(1000)
        Dim approveDelegate As DelegateAppovedReqExitItem = New DelegateAppovedReqExitItem(AddressOf ApprovedRecReqExistItem)

        Dim requestID As Integer = gridCaritasRequestOrder123.GetRow.Cells("RequestID").Value ' GetValue("RequestID")
        'update the text using Control.invoke to call UI thread to update the text box.

        Me.Invoke(approveDelegate, requestID)
    End Sub

    Sub ApprovedRecReqExistItem(ByVal pRequestID As Integer)

        Dim TransMsgStatus As String = ""
        Dim ErrorMessage As String = ""

        Dim IsNotCompletReceive As Boolean = False
        Dim THIDataContextStockUpdate As New BaseDataContext
        THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
        THIDataContextStockUpdate.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContextStockUpdate.getTHIDataContext.Connection.BeginTransaction
        THIDataContextStockUpdate.getTHIDataContext.Transaction = trans

        Try

            Dim lstCaritasReqDetail As New List(Of CARITAS_REQUEST_DETAIL_INVENTORY)
            Dim CRDs = From listCRD In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where listCRD.RequestID = pRequestID
            lstCaritasReqDetail = CRDs.ToList

            For Each CaritasReqDetail As CARITAS_REQUEST_DETAIL_INVENTORY In lstCaritasReqDetail
                ErrorMessage = ""
                '------- Check condition when user order recieve not yet complet--------------
                If CaritasReqDetail.IsReceive = False Then
                    IsNotCompletReceive = True
                End If
                If CaritasReqDetail.IsReceive = True And CaritasReqDetail.IsReady = False Then
                    '--- Update Quantity item in Stock 

                    Dim recQuantity As Integer = CaritasReqDetail.ReceivedQuantity
                    Dim myItemID As Integer = CaritasReqDetail.ItemID
                    Dim myItemName As String = CaritasReqDetail.ItemName

                    Dim myMainStock = From mainStock In THIDataContextStockUpdate.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = myItemID
                    Dim centralStock As tblCentralInventory = myMainStock.SingleOrDefault
                    Dim balanceStock As Integer = centralStock.UnitsInStock + recQuantity

                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblCentralInventory SET UnitsInStock={0} WHERE ItemID={1}", balanceStock, myItemID)

                    '---- Update CostInUSD of item
                    Dim cost As Decimal
                    Dim getCost = From itemProRecieved In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQ_ITEM_PROVIDER_INFOs Where itemProRecieved.ItemID = myItemID And itemProRecieved.RequestDetailID = CaritasReqDetail.RequestDetailID
                    ErrorMessage = ".Pleas set cost and provider on Item Name= " & myItemName & " Item ID=" & myItemID & " Request Detail=" & CaritasReqDetail.RequestDetailID
                    Dim itemProRecieve As CARITAS_REQ_ITEM_PROVIDER_INFO = getCost.First
                    cost = itemProRecieve.CostInUSD
                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET UnitPrice={0} WHERE ItemID={1}", cost, myItemID)

                    '========================= Management Begin balance item quantity before perform transaction =========================
                    Dim qBBT = From BBT In THIDataContextStockUpdate.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer().Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = myItemID
                    If qBBT.ToList.Count = 0 Then
                        '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                        Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        mytblBeginBalanceTrace.Date = GetDateServer()
                        mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                        mytblBeginBalanceTrace.BeginBalanceOfDay = centralStock.UnitsInStock
                        mytblBeginBalanceTrace.ItemID = myItemID

                        THIDataContextStockUpdate.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                    End If

                    '--- Update item Expired date
                    Dim expiredDate As Date = CaritasReqDetail.ExpiredDate
                    If recQuantity <> 0 Then '--- Update expired date in case received item quantity greater than 0
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET DateExpired={0} WHERE ItemID={1}", expiredDate, myItemID)
                    End If
                    '--- Update Date item that received
                    ' THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET ReceivedDateDetail={0} WHERE ItemID={1} and RequestID={2}", GetDateServer.Date, myItemID, CaritasReqDetail.RequestDetailID)
                    '--- Update request Status to close (equals 2) in table CARITAS_REQUEST_INVENTORY for approved
                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_INVENTORY SET Status={0},ReceivedDate={1} WHERE RequestID={2}", 2, GetDateServer.Date, pRequestID)

                    '--- Update request Balance in table CARITAS_REQUEST_DETAIL_INVENTORY (balance = PresentStock + ReceivedQuantity)
                    Dim pReqDetailID As Integer = CaritasReqDetail.RequestDetailID
                    'Dim balance As Integer = CaritasReqDetail.PresentStock + CaritasReqDetail.ReceivedQuantity
                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET IsReady={0} ,ReceiveDateDetail={1} WHERE RequestDetailID={2}", True, GetDateServer.Date, pReqDetailID)
                    THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()

                    '--- Update Item Provider Quantity 
                    Dim CRTRecDetailID As Double = CaritasReqDetail.RequestDetailID
                    Dim CRTProviderRecDetail = From context In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQ_ITEM_PROVIDER_INFOs Where context.RequestDetailID = CRTRecDetailID
                    Dim lstCRTProviderRecDetail = CRTProviderRecDetail.ToList

                    '--- Loop CARITAS_REQ_ITEM_PROVIDER_INFO each RequestDetailID
                    For Each CRTProRecDetail As CARITAS_REQ_ITEM_PROVIDER_INFO In lstCRTProviderRecDetail

                        Dim itemID As Integer = CRTProRecDetail.ItemID
                        Dim proID As Integer = CRTProRecDetail.ProviderID

                        Dim q = From ProItem In THIDataContextStockUpdate.getTHIDataContext.tblVendorItemSupplyStatus Where ProItem.ItemID = itemID And ProItem.VendorID = proID
                        If q.ToList.Count = 0 Then
                            '--- Insert new item provider
                            Dim ProItem As New tblVendorItemSupplyStatus
                            ProItem.VendorID = proID
                            ProItem.ItemID = itemID
                            ProItem.Cost = CRTProRecDetail.Cost
                            ProItem.CurrencyID = CRTProRecDetail.CurrencyID
                            ProItem.Quantity = CRTProRecDetail.GivenQty

                            THIDataContextStockUpdate.getTHIDataContext.tblVendorItemSupplyStatus.InsertOnSubmit(ProItem)
                            THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                        Else
                            '--- Update item provider Quantity,Cost and CurrencyID
                            Dim ProItem As tblVendorItemSupplyStatus = q.SingleOrDefault
                            ProItem.Quantity = ProItem.Quantity + CRTProRecDetail.GivenQty
                            ProItem.Cost = CRTProRecDetail.Cost
                            ProItem.CurrencyID = CRTProRecDetail.CurrencyID

                            THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                        End If
                    Next
                End If

                '----------- If case not yet complet transaction receive update CARITAS_REQUEST_INVENTORY status =1-----------------------
                If IsNotCompletReceive = True Then
                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_INVENTORY SET Status={0} WHERE RequestID={1}", 3, pRequestID)
                    THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                End If
            Next

            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
            TransMsgStatus = ex.Message & " Error ID " & ErrorMessage
        Finally
            THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
            trans = Nothing
        End Try

        If TransMsgStatus = "" Then
            ' MessageBox.Show("Save approved request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FillByRequestID(pRequestID)
        Else
            MessageBox.Show("Transaction Error: " & TransMsgStatus, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Sub ApprovedRecReqNotExistItem(ByVal pRequestID As Integer)

        Dim TransMsgStatus As String = ""
        If MessageBox.Show("Do you want save approved Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim IsNotCompletReceive As Boolean = False
            Dim THIDataContextStockUpdate As New BaseDataContext
            THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
            THIDataContextStockUpdate.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContextStockUpdate.getTHIDataContext.Connection.BeginTransaction
            THIDataContextStockUpdate.getTHIDataContext.Transaction = trans

            Try

                Dim lstCaritasReqDetail As New List(Of CARITAS_REQUEST_DETAIL_INVENTORY)
                Dim CRDs = From listCRD In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where listCRD.RequestID = pRequestID
                lstCaritasReqDetail = CRDs.ToList

                For Each CaritasReqDetail As CARITAS_REQUEST_DETAIL_INVENTORY In lstCaritasReqDetail

                    If CaritasReqDetail.IsReceive = False Then
                        IsNotCompletReceive = True
                    End If
                    If CaritasReqDetail.IsReceive = True And CaritasReqDetail.IsReady = False Then
                        '--- Update Quantity item in Stock 
                        Dim recQuantity As Integer = CaritasReqDetail.ReceivedQuantity
                        Dim myItemID As Integer = CaritasReqDetail.ItemID

                        Dim myMainStock = From mainStock In THIDataContextStockUpdate.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = myItemID
                        Dim centralStock As tblCentralInventory = myMainStock.SingleOrDefault
                        Dim balanceStock As Integer = centralStock.UnitsInStock + recQuantity
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblCentralInventory SET UnitsInStock={0} WHERE ItemID={1}", balanceStock, myItemID)

                        '---- Update CostInUSD of item
                        Dim cost As Decimal
                        Dim getCost = From itemProRecieved In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQ_ITEM_PROVIDER_INFOs Where itemProRecieved.ItemID = myItemID And itemProRecieved.RequestDetailID = CaritasReqDetail.RequestDetailID
                        Dim itemProRecieve As CARITAS_REQ_ITEM_PROVIDER_INFO = getCost.First
                        cost = itemProRecieve.CostInUSD
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET UnitPrice={0} WHERE ItemID={1}", cost, myItemID)

                        '========================= Management Begin balance item quantity before perform transaction =========================
                        Dim qBBT = From BBT In THIDataContextStockUpdate.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer().Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = myItemID
                        If qBBT.ToList.Count = 0 Then
                            '========================= Register Begin Balance of item (myRequestToDepartID) =========================                        
                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = GetDateServer()
                            mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                            mytblBeginBalanceTrace.BeginBalanceOfDay = centralStock.UnitsInStock
                            mytblBeginBalanceTrace.ItemID = myItemID

                            THIDataContextStockUpdate.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                        End If

                        '--- Update item Expired date
                        Dim expiredDate As Date = CaritasReqDetail.ExpiredDate
                        Dim itemName As String = CaritasReqDetail.ItemName

                        If recQuantity <> 0 Then '--- Update expired date in case received item quantity greater than 0
                            THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE tblItem SET DateExpired={0} WHERE ItemID={1}", expiredDate, myItemID)
                        End If

                        '--- Update request Status to close (equals 2) in table CARITAS_REQUEST_INVENTORY for approved
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_INVENTORY SET Status={0},ReceivedDate={1} WHERE RequestID={2}", 2, GetDateServer, pRequestID)

                        '--- Update request Balance in table CARITAS_REQUEST_DETAIL_INVENTORY (balance = PresentStock + ReceivedQuantity)
                        Dim pReqDetailID As Integer = CaritasReqDetail.RequestDetailID
                        Dim balance As Integer = CaritasReqDetail.PresentStock + CaritasReqDetail.ReceivedQuantity
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET Balance={0},IsReady={1} WHERE RequestDetailID={2}", balance, True, pReqDetailID)

                        '--- Update Item Provider Quantity 
                        Dim CRTRecDetailID As Double = CaritasReqDetail.RequestDetailID
                        Dim CRTProviderRecDetail = From context In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQ_ITEM_PROVIDER_INFOs Where context.RequestDetailID = CRTRecDetailID
                        Dim lstCRTProviderRecDetail = CRTProviderRecDetail.ToList

                        '--- Loop CARITAS_REQ_ITEM_PROVIDER_INFO each RequestDetailID
                        For Each CRTProRecDetail As CARITAS_REQ_ITEM_PROVIDER_INFO In lstCRTProviderRecDetail

                            Dim itemID As Integer = CRTProRecDetail.ItemID
                            Dim proID As Integer = CRTProRecDetail.ProviderID

                            Dim q = From ProItem In THIDataContextStockUpdate.getTHIDataContext.tblVendorItemSupplyStatus Where ProItem.ItemID = itemID And ProItem.VendorID = proID
                            If q.ToList.Count = 0 Then
                                '--- Insert new item provider
                                Dim ProItem As New tblVendorItemSupplyStatus
                                ProItem.VendorID = proID
                                ProItem.ItemID = itemID
                                ProItem.Cost = CRTProRecDetail.Cost
                                ProItem.CurrencyID = CRTProRecDetail.CurrencyID
                                ProItem.Quantity = CRTProRecDetail.GivenQty

                                THIDataContextStockUpdate.getTHIDataContext.tblVendorItemSupplyStatus.InsertOnSubmit(ProItem)
                                THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                            Else
                                '--- Update item provider Quantity,Cost and CurrencyID
                                Dim ProItem As tblVendorItemSupplyStatus = q.SingleOrDefault
                                ProItem.Quantity = ProItem.Quantity + CRTProRecDetail.GivenQty
                                ProItem.Cost = CRTProRecDetail.Cost
                                ProItem.CurrencyID = CRTProRecDetail.CurrencyID

                                THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                            End If
                        Next
                    End If
                    '----------- If case not yet complet transaction receive update CARITAS_REQUEST_INVENTORY status =1-----------------------
                    If IsNotCompletReceive = True Then
                        THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_INVENTORY SET Status={0} WHERE RequestID={1}", 3, pRequestID)
                        THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                    End If
                Next

                trans.Commit()
                THIDataContextStockUpdate.getTHIDataContext.Connection.Close()

            Catch ex As Exception
                trans.Rollback()
                THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
                TransMsgStatus = ex.Message
            Finally
                DEP_EOD.BtnEndofDay_Click(sender, e)
                trans = Nothing
            End Try

            If TransMsgStatus = "" Then
                MessageBox.Show("Save approved request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FillByRequestID(pRequestID)
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If
        End If

    End Sub

    

    Private Sub menuRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRefreshData.Click
        LoadGridCaritasRequest()
    End Sub

    Private Sub menuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDelete.Click

        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then

                If gridCaritasRequestOrder123.GetValue("Status") = 1 Then
                    MessageBox.Show("This request already received and waiting for approval so cannot delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim TransMsgStatus As String = ""
                Dim requestID As Integer
                requestID = gridCaritasRequestOrder123.GetValue("RequestID")

                If MessageBox.Show("Do you want delete Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans

                    Try
                        '--- Delete record in table CARITAS_REQUEST_INVENTORY
                        THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM CARITAS_REQUEST_INVENTORY WHERE RequestID={0}", requestID)

                        '--- Delete record in table CARITAS_REQUEST_DETAIL_INVENTORY
                        THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM CARITAS_REQUEST_DETAIL_INVENTORY WHERE RequestID={0}", requestID)

                        THIDataContext.getTHIDataContext.SubmitChanges()

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                        TransMsgStatus = ex.Message
                    Finally
                        trans = Nothing
                    End Try

                    If TransMsgStatus = "" Then
                        MessageBox.Show("Save delete request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadGridCaritasRequest()
                    Else
                        MsgBox("Transaction Error: " & TransMsgStatus)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub menuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEdit.Click

        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then
                If gridCaritasRequestOrder123.GetValue("Status") = 1 Then
                    MessageBox.Show("This request already received and waiting for approval so Cannot Edit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    Dim FAddCaritasRequestOrder As New frmAddCaritasRequestOrder(Me)
                    FAddCaritasRequestOrder.labelStatus = "OpenEdit"
                    FAddCaritasRequestOrder.IsRequestExistingItem = gridCaritasRequestOrder123.GetValue("IsRequestExistingItem")
                    FAddCaritasRequestOrder.Comment = gridCaritasRequestOrder123.GetValue("Comment")
                    FAddCaritasRequestOrder.RequestCreator = IUser.GetUserNameByID(CInt(gridCaritasRequestOrder123.GetValue("UserID")))
                    FAddCaritasRequestOrder.RequestDate = gridCaritasRequestOrder123.GetValue("RequestDate")
                    FAddCaritasRequestOrder.requestID = gridCaritasRequestOrder123.GetValue("RequestID")
                    FAddCaritasRequestOrder.RequestNumber = gridCaritasRequestOrder123.GetValue("RequestOrderNumber")
                    FAddCaritasRequestOrder.ChDateFrom.Checked = True
                    FAddCaritasRequestOrder.ChDateFrom.Value = gridCaritasRequestOrder123.GetValue("ItemUsedFrom")
                    FAddCaritasRequestOrder.ChDateTo.Checked = True
                    FAddCaritasRequestOrder.ChDateTo.Value = gridCaritasRequestOrder123.GetValue("ItemUsedTo")
                    If FAddCaritasRequestOrder.ShowDialog() = DialogResult.OK Then
                        'LoadGridCaritasRequest()
                        BtnFilter_Click(sender, e)
                    End If

                    FAddCaritasRequestOrder.Close()
                    FAddCaritasRequestOrder.Dispose()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please select main request order ", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------------------ get banlance -------------------------

    Dim DA_USED As New DSHospitalRequestToCaritasTableAdapters.VREQUEST_USEDTableAdapter
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



    Private Sub menuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPrint.Click
        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then
                '---------- Update ending balance stock ..........................
                Dim BeginStock As Integer
                Dim UsedInStock As Integer
                Dim Endbalace As Integer
                Dim Recieve As Integer
                Dim CalEndBalance As Integer
                Dim THIDataContextStockUpdate As New BaseDataContext
                THIDataContextStockUpdate.getTHIDataContext.Connection.Close()
                THIDataContextStockUpdate.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContextStockUpdate.getTHIDataContext.Connection.BeginTransaction
                THIDataContextStockUpdate.getTHIDataContext.Transaction = trans

                Dim lstCaritasReqDetail As New List(Of CARITAS_REQUEST_DETAIL_INVENTORY)
                Dim CRDs = From listCRD In THIDataContextStockUpdate.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where listCRD.RequestID = CInt(gridCaritasRequestOrder123.GetRow.Cells("RequestID").Value)
                lstCaritasReqDetail = CRDs.ToList
                For Each CaritasReqDetail As CARITAS_REQUEST_DETAIL_INVENTORY In lstCaritasReqDetail
                    Dim pReqDetailID As Integer = CaritasReqDetail.RequestDetailID
                    BeginStock = TotalBeginStock(CaritasReqDetail.ItemID, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedFrom").Value, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedTo").Value)
                    UsedInStock = TotalUsed(CaritasReqDetail.ItemID, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedFrom").Value, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedTo").Value)
                    EndBalance = TotalEndingBalacne(CaritasReqDetail.ItemID, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedFrom").Value, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedTo").Value)
                    Recieve = TotalReceived(CaritasReqDetail.ItemID, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedFrom").Value, gridCaritasRequestOrder123.GetRow.Cells("ItemUsedTo").Value)
                    CalEndBalance = (BeginStock + Recieve) - UsedInStock
                    'Dim balance As Integer = CaritasReqDetail.PresentStock + CaritasReqDetail.ReceivedQuantity
                    THIDataContextStockUpdate.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET PresentStock={0}, ReceivedDoReport={1},ItemUsed={2},Balance={3} WHERE RequestDetailID={4}", BeginStock, Recieve, UsedInStock, CalEndBalance, pReqDetailID)
                    THIDataContextStockUpdate.getTHIDataContext.SubmitChanges()
                Next
                trans.Commit()
                THIDataContextStockUpdate.getTHIDataContext.Connection.Close()



                '---- print request order ----------
                Dim FRptRequestView As New frmReportViewer
                FRptRequestView.CaritasRequestID = CInt(gridCaritasRequestOrder123.GetValue("RequestID"))
                FRptRequestView.ReportOption = 7
                FRptRequestView.ShowDialog()
                FillByRequestID(CInt(gridCaritasRequestOrder123.GetRow.Cells("RequestID").Value))



            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnPrintSupGinven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintSupGinven.Click

        'If Not gridCaritasRequestOrder.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder.CurrentRow.RowType = RowType.Record Then
        Try
            Dim FRptRequestView As New frmReportViewer
            'FRptRequestView.CaritasRequestID = Val(gridCaritasRequestOrder.GetValue("RequestID"))
            FRptRequestView.ReportOption = 12
            FRptRequestView.FDate = dptFromDate.Value.Date
            FRptRequestView.TDate = dptToDate.Value.Date
            If FRptRequestView.ShowDialog = DialogResult.OK Then

            End If
        Catch ex As Exception

        End Try
        'End If

    End Sub

    Private Sub BtnItemSupUsed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemSupUsed.Click

        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then

                Dim FRptRequestView As New frmReportViewer
                FRptRequestView.CaritasRequestID = Val(gridCaritasRequestOrder123.GetValue("RequestID"))
                FRptRequestView.ReportOption = 13
                FRptRequestView.FDate = dptFromDate.Value.Date
                FRptRequestView.TDate = dptToDate.Value.Date
                If FRptRequestView.ShowDialog = DialogResult.OK Then

                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Please select record in request order table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click

        LoadByDateRequest(dptFromDate.Value, dptToDate.Value)
    End Sub

    Private Sub BtnRequestCaristas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequestCaristas.Click

        'Dim DA_TemEOD As New DSHospitalRequestToCaritasTableAdapters.tblEndofDayRunTableAdapter
        'Dim DA_TemAllRequest As New DSHospitalRequestToCaritasTableAdapters.VAllRequestItemTableAdapter
        'Dim TableTemRequst As New DSHospitalRequestToCaritas.TABLE_TEM_OF_REQUEST_CARISTASDataTable
        'Dim tblEOD As DataTable = DA_TemEOD.SelectCaristasEOD(dptFromDate.Value.Date, dptToDate.Value.Date)
        'For Each rowEOD As DataRow In tblEOD.Rows
        '    Dim obj As Object = DA_TemAllRequest.SelectTotalCost(rowEOD("ItemID"), dptFromDate.Value.Date, dptToDate.Value.Date)
        '    System.Diagnostics.Debug.WriteLine(CDbl(obj) & " Item ID " & rowEOD("ItemID"))
        '    'MsgBox(rowEOD("ItemID"))
        '    '' System.Diagnostics.Debug.WriteLine("  Item ID =" & rowEOD("ItemID"))
        '    'If DA_TemAllRequest.SelectTotalCost(rowEOD("ItemID"), dptFromDate.Value.Date, dptToDate.Value.Date) Is  Then
        '    '    System.Diagnostics.Debug.WriteLine()
        '    'End If


        '    'For Each rowCost As DataRow In tblTemCost.Rows
        '    '    System.Diagnostics.Debug.WriteLine()
        '    'Next
        'Next
        'Dim DicItemsRequest As New Dictionary(Of String, VAllRequestItem)
        'Dim DicItemsUsed As New Dictionary(Of String, Double)
        'Dim DicItemsItemBeginBalance As New Dictionary(Of String, Double)
        ''--- Get items transaction in selected periods of time
        'Dim myItemsRequest As List(Of VAllRequestItem) = RequestItemRepo.AllItemRequestList(dptFromDate.Value.Date, dptToDate.Value.Date)
        'Dim myItemsUsed As List(Of VAllUsedItem) = RequestItemRepo.AllItemUsedList(dptFromDate.Value.Date, dptToDate.Value.Date)
        'Dim myItemsBeginBalance As List(Of VAllBeginBalance) = RequestItemRepo.AllItemBeginBalanceList(dptFromDate.Value.Date, dptToDate.Value.Date)

        ''--- There is no transactions in selected periods of time
        'If myItemsRequest.Count > 0 Then
        '    DicItemsRequest = RequestItemRepo.GetDicItemsRequest(myItemsRequest)
        'End If
        'If myItemsUsed.Count > 0 Then
        '    DicItemsUsed = RequestItemRepo.GetDicItemsUsed(myItemsUsed)
        'End If
        'If myItemsBeginBalance.Count > 0 Then
        '    DicItemsItemBeginBalance = RequestItemRepo.GetDicItemsBeginBalance(myItemsBeginBalance)
        'End If

        ''--- Maintence Transaction                
        'Dim TransMsgStatus As String = ""
        'Dim TempVRequestItem As New VAllRequestItem
        'Dim TempVUsedItem As New VAllUsedItem

        'THIDataContext.getTHIDataContext.Connection.Close()
        'THIDataContext.getTHIDataContext.Connection.Open()
        'Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        'THIDataContext.getTHIDataContext.Transaction = trans
        'Try
        '    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblTempRequestAllItem")
        '    THIDataContext.getTHIDataContext.SubmitChanges()

        '    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblTempUsedItem")
        '    THIDataContext.getTHIDataContext.SubmitChanges()

        '    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblTempBeginBalance")
        '    THIDataContext.getTHIDataContext.SubmitChanges()

        '    Dim pair As KeyValuePair(Of String, VAllRequestItem)
        '    For Each pair In DicItemsRequest
        '        Dim RequesItem As VAllRequestItem = pair.Value
        '        Dim ItemRequest As New tblTempRequestAllItem
        '        ItemRequest.ItemID = Val(pair.Key)
        '        ItemRequest.Request = RequesItem.Request
        '        ItemRequest.Received = RequesItem.ReceivedQuantity
        '        THIDataContext.getTHIDataContext.tblTempRequestAllItems.InsertOnSubmit(ItemRequest)
        '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    Next
        '    'If myItemsRequest.Count > 0 Then
        '    '    For Each TemRequest As VAllRequestItem In myItemsRequest
        '    '        Dim ItemRequest As New tblTempRequestAllItem
        '    '        ItemRequest.ItemID = TemRequest.ItemID
        '    '        ItemRequest.Request = TemRequest.Request
        '    '        ItemRequest.Received = TemRequest.ReceivedQuantity
        '    '        THIDataContext.getTHIDataContext.tblTempRequestAllItems.InsertOnSubmit(ItemRequest)
        '    '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    '    Next
        '    'End If

        '    Dim pairUsed As KeyValuePair(Of String, Double)
        '    For Each pairUsed In DicItemsUsed
        '        'Dim useItem As VAllUsedItem = pairUsed.Value
        '        Dim ItemUsed As New tblTempUsedItem
        '        ItemUsed.ItemID = Val(pairUsed.Key)
        '        ItemUsed.Used = pairUsed.Value
        '        THIDataContext.getTHIDataContext.tblTempUsedItems.InsertOnSubmit(ItemUsed)
        '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    Next
        '    'If myItemsUsed.Count > 0 Then
        '    '    For Each used As VAllUsedItem In myItemsUsed
        '    '        Dim ItemUsed As New tblTempUsedItem
        '    '        ItemUsed.ItemID = used.ItemID
        '    '        ItemUsed.Used = used.Used
        '    '        THIDataContext.getTHIDataContext.tblTempUsedItems.InsertOnSubmit(ItemUsed)
        '    '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    '    Next

        '    'End If

        '    Dim pairBeginBalance As KeyValuePair(Of String, Double)
        '    For Each pairBeginBalance In DicItemsItemBeginBalance
        '        'MsgBox(pairBeginBalance.Value & "  " & pairBeginBalance.Key)
        '        ' Dim BegItem As VAllBeginBalance = pairBeginBalance.Value
        '        Dim ItemBeginBalance As New tblTempBeginBalance
        '        ItemBeginBalance.ItemID = Val(pairBeginBalance.Key)
        '        ItemBeginBalance.BeginBalance = pairBeginBalance.Value
        '        THIDataContext.getTHIDataContext.tblTempBeginBalances.InsertOnSubmit(ItemBeginBalance)
        '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    Next
        '    'If myItemsBeginBalance.Count > 0 Then
        '    '    For Each BeginBalance In myItemsBeginBalance
        '    '        Dim ItemBeginBalance As New tblTempBeginBalance
        '    '        ItemBeginBalance.ItemID = BeginBalance.ItemID
        '    '        ItemBeginBalance.BeginBalance = BeginBalance.BeginBalance
        '    '        THIDataContext.getTHIDataContext.tblTempBeginBalances.InsertOnSubmit(ItemBeginBalance)
        '    '        THIDataContext.getTHIDataContext.SubmitChanges()
        '    '    Next
        '    'End If

        '    trans.Commit()
        '    THIDataContext.getTHIDataContext.Connection.Close()

        'Catch ex As Exception
        '    trans.Rollback()
        '    THIDataContext.getTHIDataContext.Connection.Close()
        '    TransMsgStatus = ex.Message
        'Finally
        '    trans = Nothing
        'End Try

        'If TransMsgStatus <> "" Then
        '    MsgBox("Transaction Error: " & TransMsgStatus)
        '    Exit Sub
        'End If

        ''--- View Report
        Try
            Dim FRptRequestView As New frmReportViewer
            FRptRequestView.ReportOption = 17
            FRptRequestView.FDate = dptFromDate.Value.Date
            FRptRequestView.TDate = dptToDate.Value.Date
            FRptRequestView.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select record in request order table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub BtnNotyetComplet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotyetComplet.Click
        FillReceivedStatus(0)
    End Sub

    Private Sub btnRecieveNotComplet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecieveNotComplet.Click
        FillReceivedStatus(3)
    End Sub


    
    Private Sub BgRunReceived_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgRunReceived.RunWorkerCompleted
        Thread.Sleep(1000)
        DEP_EOD.cbDepart.SelectedValue = MAIN_STOCK_DEPART_ID
        DEP_EOD.BtnEndofDay_Click(sender, e)
    End Sub

    Private Sub gridCaritasRequestOrder123_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridCaritasRequestOrder123.SelectionChanged
        Try
            If Not gridCaritasRequestOrder123.CurrentRow Is Nothing AndAlso gridCaritasRequestOrder123.CurrentRow.RowType = RowType.Record Then
                If gridCaritasRequestOrder123.GetValue("Status") = 2 Then
                    menuApprovedRecRequest.Enabled = False
                    menuDelete.Enabled = False
                    menuEdit.Enabled = False
                    menuRecRequestItem.Enabled = False

                ElseIf gridCaritasRequestOrder123.GetValue("Status") = 3 Then
                    menuEdit.Enabled = False
                    menuDelete.Enabled = False
                    menuApprovedRecRequest.Enabled = True
                    menuRecRequestItem.Enabled = True
                Else
                    menuApprovedRecRequest.Enabled = True
                    menuDelete.Enabled = True
                    menuEdit.Enabled = True
                    menuRecRequestItem.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
