Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCReceivedRequest

    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Dim RequestDataAdapter As New DSRequestTableAdapters.VRequestDepartmentDetailTableAdapter
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Dim ItemRepo As IItem = New Item
    Private THIDataContext As New BaseDataContext
    Dim DepDataAdapter As New DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim VIncomingRequestHistoryStatusTraceMasterDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VIncomingRequestHistoryStatusTraceMasterTableAdapter
    Dim VRequestHistoryStatusTraceDetailDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VRequestHistoryStatusTraceDetailTableAdapter

    Private Sub UCReceivedRequest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        RefreshRequestOrderTV()
        CbDepartment.Enabled = False

    End Sub

    Public Sub RefreshRequestOrderTV()
        'Display data category TreeView
        TVRequestOrderStatus.Nodes.Clear()
        TVRequestOrderStatus.Nodes.Add(New TreeNode("Received Request Order List"))
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.Nodes(0)
        RequestOrderRepo.PopulateTreeViewReceivedRequestOrder(0, tNode)
        tNode.Expand()
        'Select fist node prevent user attempt to create new category without select on tree view node
        tNode.TreeView.SelectedNode = tNode.FirstNode
        tNode.TreeView.Focus()

        With CbDepartment
            .DataSource = DepDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedValue = -1
        End With

    End Sub

    Private Sub TVRequestOrderStatus_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVRequestOrderStatus.AfterSelect

        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode

        Select Case tNode.Text
            Case "Department Request"                
                btnAproItems.Enabled = True
                btnMarkOrderForward.Enabled = True
                btnMarkOrderApproved.Enabled = True
                GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), SENT)
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

            Case "Approved"
                btnAproItems.Enabled = False
                btnMarkOrderForward.Enabled = False
                btnMarkOrderApproved.Enabled = False
                GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), RESPONSE) ',CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

                'Case "Forward"
                '    btnAproItems.Enabled = True
                '    btnMarkOrderForward.Enabled = False
                '    btnMarkOrderApproved.Enabled = True
                '    GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), CInt(tNode.Tag))
                '    GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

                'Case "Approved And Forward"
                '    btnAproItems.Enabled = True
                '    btnMarkOrderForward.Enabled = True
                '    btnMarkOrderApproved.Enabled = True
                '    GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), CInt(tNode.Tag))
                '    GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

        End Select
        RadApproved.Checked = False
        RadRequest.Checked = False

        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True

    End Sub

    Private Sub GridRequestDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRequestDetail.SelectionChanged
        Try
            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
        Catch ex As Exception
            GridItemRequestDetail.DataSource = Nothing
        End Try
    End Sub

    '*** Remark : RequestStatusTracking.POStatusID equals 10 (this value depend on tblPurchaseOrderStatus)
    Private Sub btnMarkOrderForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderForward.Click
        Dim Request As New tblRequest
        Dim RequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim requestID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)
            If MessageBox.Show("Do you want save Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    '** Transaction process tblRequestDetail
                    '** Delete records in tblRquestDetail depend on requestID
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", requestID)
                    ' ===

                    ' *** Insert new records in tblRequestDetail                             
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                        Dim RequestDetail As New tblRequestDetail
                        RequestDetail.RequestID = requestID 'Request.RequestID                            
                        RequestDetail.ItemID = Val(rRow.Cells("ItemID").Value)
                        RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                        'RequestDetail.ResponseQuantity = Val(rRow.Cells("Quantity").Value)                        
                        RequestDetail.Status = 10 ' Forward
                        THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                    '====

                    '** Transaction process tblRequestStatusTracking
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", Val(requestID))
                    '*** Insert new record in tblRequestStatusTracking                        
                    RequestStatusTracking.RequestID = requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                    RequestStatusTracking.POStatusID = 10
                    RequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    RequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(RequestStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                    ' ====

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    TransMsgStatus = ex.Message
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing
                End Try

                ' Message validation save update request
                If TransMsgStatus = "" Then
                    MsgBox("Save request order successful.")
                    RefreshGridRequest()
                Else
                    MsgBox("Transaction Error: " & TransMsgStatus)
                End If
            End If
        End If


    End Sub

    '*** Remark : RequestStatusTracking.POStatusID equals 7 (this value depend on tblPurchaseOrderStatus)
    Private Sub btnMarkOrderApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderApproved.Click

        Dim RequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""
        Dim myRequestHistoryStatusTracking As New tblRequestHistoryStatusTracking

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim requestID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)

            '--- We require information item use for particular item so need user input response item via window response item
            For Each row As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                If IsDBNull(row.Cells("ResponseQuantity").Value) Then
                    MessageBox.Show("Please enter response quantity item : " & row.Cells("ItemName").Value & " .", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next

            If MessageBox.Show("Do you want save Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try

                    '--- Update User Approved  
                    Dim ObjRequest = From q In THIDataContext.getTHIDataContext.tblRequests Where q.RequestID = Val(requestID)
                    Dim Request As tblRequest = ObjRequest.SingleOrDefault
                    Request.UserApproveName = USER_NAME
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- Transaction process tblRequestDetail
                    '--- Delete records in tblRquestDetail depend on requestID
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", requestID)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- Insert new records in tblRequestDetail                             
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                        Dim RequestDetail As New tblRequestDetail
                        RequestDetail.RequestID = requestID 'Request.RequestID                            
                        RequestDetail.ItemID = Val(rRow.Cells("ItemID").Value)
                        Dim itemUnitInStockInMainStock As Integer = ItemRepo.GetItemUnitInStockMain(Val(rRow.Cells("ItemID").Value))

                        '--- Incase response quantity equal null we apply item response quantity equal item request quantity
                        If IsDBNull(rRow.Cells("ResponseQuantity").Value) Then
                            '--- Incase request quantity is smaller than quantity item in stock
                            If itemUnitInStockInMainStock >= Val(rRow.Cells("Quantity").Value) Then
                                RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                                RequestDetail.ResponseQuantity = Val(rRow.Cells("Quantity").Value)
                            Else '--- Incase request quantity is greater than quantity item in stock
                                RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                                RequestDetail.ResponseQuantity = itemUnitInStockInMainStock
                            End If
                        Else '--- Incase user has modified item response quantity
                            RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                            RequestDetail.ResponseQuantity = Val(rRow.Cells("ResponseQuantity").Value)
                        End If

                        '--- RequestDetail.IsApproved = True
                        RequestDetail.Status = RESPONSE
                        THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                    '====

                    '--- Transaction process tblRequestStatusTracking
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", Val(requestID))
                    '*** Insert new record in tblRequestStatusTracking                        
                    RequestStatusTracking.RequestID = requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                    RequestStatusTracking.POStatusID = RESPONSE '7
                    RequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    RequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(RequestStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- insert record in table tblRequestHistoryStatusTracking
                    myRequestHistoryStatusTracking.RequestID = requestID
                    myRequestHistoryStatusTracking.POStatusID = APPROVED '11          ' Response status to department request
                    myRequestHistoryStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    myRequestHistoryStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestHistoryStatusTrackings.InsertOnSubmit(myRequestHistoryStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()


                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    TransMsgStatus = ex.Message
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                Finally
                    trans = Nothing
                End Try

                ' Message validation save update request
                If TransMsgStatus = "" Then
                    MessageBox.Show("Save approved request order successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    '---- print request order ----------
                    Dim FRptRequestView As New frmReportViewer
                    FRptRequestView.RequestOrderID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                    FRptRequestView.ReportOption = 1
                    If FRptRequestView.ShowDialog = DialogResult.OK Then

                    End If

                    RefreshGridRequest()                   
                Else
                    MsgBox("Transaction Error: " & TransMsgStatus)
                End If
            End If
        End If
    End Sub

    Private Sub btnAproItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAproItems.Click
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode

        Dim FResponseRequestOrder As New frmResponseRequestOrder(Me)
        FResponseRequestOrder.labelStatus = "ApprovedItems"

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            FResponseRequestOrder.requestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            If FResponseRequestOrder.ShowDialog = DialogResult.OK Then
                '    Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                '    GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
                'GridRequestDetail.DataSource = RequestDataAdapter.GetDataByRequestStatusID(CInt(tNode.Tag))
                RefreshGridRequest()
            End If

            FResponseRequestOrder.Close()
            FResponseRequestOrder.Dispose()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshRequestOrderTV()
    End Sub

    Private Sub RefreshGirdItemDetail()
        Try
            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
        Catch ex As Exception
            GridItemRequestDetail.DataSource = Nothing
        End Try

    End Sub

    Private Sub RefreshGridRequest()

        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode

        If tNode.Text = "Department Request" Then
            GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), 2)
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
            btnAproItems.Enabled = True
            btnEdit.Enabled = False
        Else
            GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), CInt(tNode.Tag))
            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue

            btnAproItems.Enabled = False
            btnEdit.Enabled = True
        End If

    End Sub

    Private Sub btnApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproved.Click

        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
            If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Status").Value) Then
                MessageBox.Show("Please approved these item before edit , Cannot modify Response Quantity Item ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Status").Value = "Forward" Then
                MessageBox.Show("Current selected item in Forward status , Cannot modify Response Quantity Item ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
                frmMainStockResponseItem.myRequestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            Else
                Exit Sub
            End If

            frmMainStockResponseItem.myRequestDetailID = Val(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("RequestDetailID").Value)
            frmMainStockResponseItem.myItemName = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemName").Value

            If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value) Then
                frmMainStockResponseItem.myComment = ""
            Else
                frmMainStockResponseItem.myComment = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value
            End If

            If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value) Then
                frmMainStockResponseItem.myResponseQty = "0"
            Else
                frmMainStockResponseItem.myResponseQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value
            End If

            ' Pass Request Quantity of item.
            If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value) Then
                frmMainStockResponseItem.myRequestQty = "0"
            Else
                frmMainStockResponseItem.myRequestQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value
            End If

            frmMainStockResponseItem.myItemID = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemID").Value

            frmMainStockResponseItem.isRequestInputFromDepart = False
            If frmMainStockResponseItem.ShowDialog() = DialogResult.OK Then
                RefreshGridRequest()
            End If

        End If

    End Sub

    Private Sub btnInStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInStock.Click
        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim itemID As Integer = Val(GridItemRequestDetail.GetValue("ItemID"))
            Dim FCompareItemInStock As New frmCompareItemInStock
            FCompareItemInStock.myItemID = itemID
            FCompareItemInStock.ShowDialog()
            FCompareItemInStock.Close()
            FCompareItemInStock.Dispose()
        End If
    End Sub

    Private Sub btnAddApprovedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddApprovedItem.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim frm As New frmRequestItemsDetail()
            ' display item in main stock
            frm.isDisplayItemInMainStock = True

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim isItemExist As Boolean = False
                For Each aRow As DataRow In frm.objDataTable.Rows
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                        If rRow.Cells("ItemID").Value = aRow("ItemID") Then
                            isItemExist = True
                            Exit For
                        Else
                            isItemExist = False
                        End If
                    Next
                    If isItemExist = False Then
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        Try
                            ' Update table tblRequestDetail
                            Dim RequestDetail As New tblRequestDetail
                            RequestDetail.RequestID = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)
                            RequestDetail.ItemID = Val(aRow("ItemID"))
                            RequestDetail.ResponseQuantity = 0
                            RequestDetail.Status = APPROVED 'Approved    
                            THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                            '===
                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()

                        Catch ex As Exception
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        End Try
                    End If
                Next
            End If

            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
            'Refresh grid requet items detail


        End If


    End Sub

    Private Sub menuInStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInStock.Click
        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim itemID As Integer = Val(GridItemRequestDetail.GetValue("ItemID"))
            Dim FCompareItemInStock As New frmCompareItemInStock
            FCompareItemInStock.myItemID = itemID
            FCompareItemInStock.ShowDialog()
            FCompareItemInStock.Close()
            FCompareItemInStock.Dispose()
        End If
    End Sub

    Private Sub menuEditQtyApprovedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditQtyApprovedItem.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then

                '--- Validate request has been approved
                If GridRequestDetail.SelectedItems(0).GetRow.Cells("POStatusID").Value <> 2 Then
                    MessageBox.Show("Cannot edit item quantity , Request has been approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim FMainStockResItem As New frmMainStockResponseItem

                If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
                    FMainStockResItem.myRequestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                    FMainStockResItem.ReqFromDepartID = GridRequestDetail.GetValue("RequestFromDepartID")
                Else
                    Exit Sub
                End If

                FMainStockResItem.myRequestDetailID = Val(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("RequestDetailID").Value)
                FMainStockResItem.myItemName = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemName").Value

                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value) Then
                    FMainStockResItem.myComment = ""
                Else
                    FMainStockResItem.myComment = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value
                End If

                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value) Then
                    FMainStockResItem.myResponseQty = "0"
                Else
                    FMainStockResItem.myResponseQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value
                End If

                ' Pass Request Quantity of item.
                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value) Then
                    FMainStockResItem.myRequestQty = "0"
                Else
                    FMainStockResItem.myRequestQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value
                End If

                FMainStockResItem.myItemID = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemID").Value

                FMainStockResItem.isRequestInputFromDepart = False
                If FMainStockResItem.ShowDialog() = DialogResult.OK Then
                    'RefreshGridRequest()
                    RefreshGirdItemDetail()
                    FMainStockResItem.Dispose()
                End If
            End If
        End If

    End Sub

    Private Sub menuAddApprovedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAddApprovedItem.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then

            ' Incase request have been approved edit quantity of item in request item list. (2 equals status sent)
            If GridRequestDetail.SelectedItems(0).GetRow.Cells("POStatusID").Value <> 2 Then
                MessageBox.Show("Cannot add item , Request has been approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim frm As New frmRequestItemsDetail()
            ' display item in main stock
            frm.isDisplayItemInMainStock = True
            frm.stockDepartID = MAIN_STOCK_DEPART_ID

            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim isItemExist As Boolean = False
                For Each aRow As DataRow In frm.ItemRequestDT.Rows
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows
                        If rRow.Cells("ItemID").Value = aRow("ItemID") Then
                            isItemExist = True
                            Exit For
                        Else
                            isItemExist = False
                        End If
                    Next
                    If isItemExist = False Then
                        THIDataContext.getTHIDataContext.Connection.Close()
                        THIDataContext.getTHIDataContext.Connection.Open()
                        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                        THIDataContext.getTHIDataContext.Transaction = trans
                        Try
                            ' Update table tblRequestDetail
                            Dim RequestDetail As New tblRequestDetail
                            RequestDetail.RequestID = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)
                            RequestDetail.ItemID = Val(aRow("ItemID"))
                            RequestDetail.ResponseQuantity = 0
                            RequestDetail.Status = 2 ' Sent
                            RequestDetail.IsOrginalItemReq = 0
                            THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                            '===
                            trans.Commit()
                            THIDataContext.getTHIDataContext.Connection.Close()

                        Catch ex As Exception
                            trans.Rollback()
                            THIDataContext.getTHIDataContext.Connection.Close()
                        End Try
                    End If
                Next
            End If

            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
            'Refresh grid requet items detail

        End If
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
                If GridRequestDetail.SelectedItems(0).GetRow.Cells("POStatusID").Value <> 2 Then
                    MessageBox.Show("Cannot remove item. , Request has been approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If GridItemRequestDetail.GetValue("IsOrginalItemReq") = 1 Then
                    MessageBox.Show("Cannot delete original department request item.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If MessageBox.Show("Do you want remove selected item ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        ' Delete request item detail
                        THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail WHERE ItemID={0} AND RequestID={1}", CInt(GridItemRequestDetail.GetValue("ItemID")), Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()

                        GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value))

                    Catch ex As Exception
                        trans.Rollback()
                        MsgBox("Error : " & ex.Message)
                        THIDataContext.getTHIDataContext.Connection.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub RadRequest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadRequest.CheckedChanged
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub RadApproved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadApproved.CheckedChanged
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.Panel2Collapsed = False
    End Sub

    Private Sub btnGridDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridDisplay.Click

        If CBAllDepart.Checked = True Then

            Dim RptRequestHistoryStatusTraceDS As New DSRptRequestHistoryStatusTrace

            Dim myPOStatusID As New Integer

            If RadRequest.Checked = True Then
                myPOStatusID = SENT
                gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = False
            End If

            If RadApproved.Checked = True Then
                myPOStatusID = APPROVED
                gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = True
            End If

            VIncomingRequestHistoryStatusTraceMasterDataAdapter.GetHisIncomingReq(CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date)
            VIncomingRequestHistoryStatusTraceMasterDataAdapter.FillBy(RptRequestHistoryStatusTraceDS.VIncomingRequestHistoryStatusTraceMaster, CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date)
            VRequestHistoryStatusTraceDetailDataAdapter.GetData()
            VRequestHistoryStatusTraceDetailDataAdapter.Fill(RptRequestHistoryStatusTraceDS.VRequestHistoryStatusTraceDetail)

            gridRequestHis.DataSource = RptRequestHistoryStatusTraceDS.VIncomingRequestHistoryStatusTraceMaster
            gridRequestHis.RootTable.ChildTables(0).DataMember = "VIncomingRequestHistoryStatusTraceMaster_VRequestHistoryStatusTraceDetail"

        Else '--- Search Specific department

            If ValidateCombobox(CbDepartment, "", ErrorPro) = False Then Exit Sub
            Dim RptRequestHistoryStatusTraceDS As New DSRptRequestHistoryStatusTrace

            Dim myPOStatusID As New Integer

            If RadRequest.Checked = True Then
                myPOStatusID = SENT
                gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = False
            End If

            If RadApproved.Checked = True Then
                myPOStatusID = APPROVED
                gridRequestHis.RootTable.ChildTables(0).Columns("ResponseQuantity").Visible = True
            End If

            VIncomingRequestHistoryStatusTraceMasterDataAdapter.GetHisIncomingReqSpecificDepart(CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date, CbDepartment.SelectedValue)
            VIncomingRequestHistoryStatusTraceMasterDataAdapter.FillBy1(RptRequestHistoryStatusTraceDS.VIncomingRequestHistoryStatusTraceMaster, CInt(DEPART_ID), myPOStatusID, dptFromDate.Value.Date, dptToDate.Value.Date, CbDepartment.SelectedValue)

            VRequestHistoryStatusTraceDetailDataAdapter.GetData()
            VRequestHistoryStatusTraceDetailDataAdapter.Fill(RptRequestHistoryStatusTraceDS.VRequestHistoryStatusTraceDetail)

            gridRequestHis.DataSource = RptRequestHistoryStatusTraceDS.VIncomingRequestHistoryStatusTraceMaster
            gridRequestHis.RootTable.ChildTables(0).DataMember = "VIncomingRequestHistoryStatusTraceMaster_VRequestHistoryStatusTraceDetail"

        End If

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click

        Dim FRptRequestView As New frmReportViewer

        FRptRequestView.ReportOption = 6
        FRptRequestView.FDate = dptFromDate.Value.Date
        FRptRequestView.TDate = dptToDate.Value.Date
        FRptRequestView.IsIncomingReq = True

        If RadRequest.Checked = True Then
            FRptRequestView.POStatus = SENT
            FRptRequestView.StrOPStatus = "INCOMING REQUEST"
        End If

        If RadApproved.Checked = True Then
            FRptRequestView.POStatus = APPROVED
            FRptRequestView.StrOPStatus = "APPROVED"
        End If

        If FRptRequestView.ShowDialog = DialogResult.OK Then

        End If

    End Sub

    Private Sub BtnPrintRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintRequest.Click

        'If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
        Try
            '---- print request order ----------
            Dim FRptRequestView As New frmReportViewer

            If RadApproved.Checked = True Then
                FRptRequestView.RequestOrderID = gridRequestHis.SelectedItems(0).GetRow.Cells("RequestID").Value
                FRptRequestView.paraDepRequest = gridRequestHis.SelectedItems(0).GetRow.Cells("DepReqName").Value
            ElseIf RadRequest.Checked = True Then
                FRptRequestView.RequestOrderID = gridRequestHis.SelectedItems(0).GetRow.Cells("RequestID").Value
                FRptRequestView.paraDepRequest = gridRequestHis.SelectedItems(0).GetRow.Cells("DepReqName").Value
            Else
                FRptRequestView.RequestOrderID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                FRptRequestView.paraDepRequest = GridRequestDetail.SelectedItems(0).GetRow.Cells("DepartName").Value
            End If
            FRptRequestView.ReportOption = 1
            If FRptRequestView.ShowDialog = DialogResult.OK Then

            End If

        Catch ex As Exception
            MessageBox.Show("Please select request in list.", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

    Private Sub CBAllDepart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBAllDepart.CheckedChanged

        If CBAllDepart.Checked = True Then
            CbDepartment.Enabled = False
        Else
            CbDepartment.Enabled = True
        End If

    End Sub
End Class
