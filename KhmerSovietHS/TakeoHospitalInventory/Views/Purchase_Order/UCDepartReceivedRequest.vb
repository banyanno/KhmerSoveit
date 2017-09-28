Imports System.Data.Common
Imports Janus.Windows.GridEX

Public Class UCDepartReceivedRequest

    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Dim RequestDataAdapter As New DSRequestTableAdapters.VRequestDepartmentDetailTableAdapter
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim DepartStockRepo As IDepartStockRepository = New DepartStockRepository

    Dim VIncomingRequestHistoryStatusTraceMasterDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VIncomingRequestHistoryStatusTraceMasterTableAdapter
    Dim VRequestHistoryStatusTraceDetailDataAdapter As New DSRptRequestHistoryStatusTraceTableAdapters.VRequestHistoryStatusTraceDetailTableAdapter


    Private Sub UCDepartReceivedRequest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshRequestOrderTV()
    End Sub

    Public Sub RefreshRequestOrderTV()
        'Display data category TreeView
        TVRequestOrderStatus.Nodes.Clear()
        TVRequestOrderStatus.Nodes.Add(New TreeNode("Received Request Order List"))
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.Nodes(0)
        RequestOrderRepo.PopulateTreeViewDepartReceivedRequestOrder(0, tNode)
        tNode.Expand()
        'Select fist node prevent user attempt to create new category without select on tree view node
        tNode.TreeView.SelectedNode = tNode.FirstNode
        tNode.TreeView.Focus()
    End Sub

    Private Sub TVRequestOrderStatus_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TVRequestOrderStatus.AfterSelect
        Dim tNode As New TreeNode
        tNode = TVRequestOrderStatus.SelectedNode

        Select Case tNode.Text
            Case "Department Request"
                btnMarkOrderApproved.Enabled = True
                GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), SENT)
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
            Case "Approved"
                btnMarkOrderApproved.Enabled = False
                GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), RESPONSE) 'CInt(tNode.Tag))
                GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        End Select

        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub btnMarkOrderApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarkOrderApproved.Click


        Dim RequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""
        Dim myRequestHistoryStatusTracking As New tblRequestHistoryStatusTracking


        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim requestID As Integer = Val(GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value)
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

                    '** Transaction process tblRequestDetail
                    '** Delete records in tblRquestDetail depend on requestID
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", requestID)
                    ' ===

                    ' *** Insert new records in tblRequestDetail                             
                    For Each rRow As Janus.Windows.GridEX.GridEXRow In GridItemRequestDetail.GetRows

                        Dim itemUnitInStockDepart As Integer = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), Val(rRow.Cells("ItemID").Value))
                        Dim RequestDetail As New tblRequestDetail
                        RequestDetail.RequestID = requestID 'Request.RequestID                            
                        RequestDetail.ItemID = Val(rRow.Cells("ItemID").Value)

                        ' Incase response quantity equal null we apply item response quantity equal item request quantity
                        If IsDBNull(rRow.Cells("ResponseQuantity").Value) Then
                            ' Incase request quantity is smaller than quantity item in stock
                            If itemUnitInStockDepart >= Val(rRow.Cells("Quantity").Value) Then
                                RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                                RequestDetail.ResponseQuantity = Val(rRow.Cells("Quantity").Value)
                            Else ' Incase request quantity is greater than quantity item in stock
                                RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                                RequestDetail.ResponseQuantity = itemUnitInStockDepart
                            End If
                        Else ' Incase user has modified item response quantity
                            RequestDetail.Quantity = Val(rRow.Cells("Quantity").Value)
                            RequestDetail.ResponseQuantity = Val(rRow.Cells("ResponseQuantity").Value)
                        End If

                        RequestDetail.Status = RESPONSE
                        THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    Next
                    '====

                    '** Transaction process tblRequestStatusTracking
                    THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", Val(requestID))

                    '--- Insert new record in tblRequestStatusTracking                        
                    RequestStatusTracking.RequestID = requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                    RequestStatusTracking.POStatusID = RESPONSE
                    RequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                    RequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(RequestStatusTracking)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    '--- insert record in table tblRequestHistoryStatusTracking
                    myRequestHistoryStatusTracking.RequestID = requestID
                    myRequestHistoryStatusTracking.POStatusID = APPROVED ' Response status to department request
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
                    RefreshGridRequest()
                Else
                    MsgBox("Transaction Error: " & TransMsgStatus)
                End If
            End If
        End If
    End Sub


    Private Sub RefreshItemDetail()
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


        Else
            GridRequestDetail.DataSource = RequestDataAdapter.GetDataReceivedRequestList(CInt(DEPART_ID), CInt(tNode.Tag))

            GridRequestDetail.RowFormatStyle.BackColor = Color.AliceBlue
        End If

    End Sub

    Private Sub GridRequestDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridRequestDetail.SelectionChanged
        Try
            Dim str As String = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
            GridItemRequestDetail.DataSource = RequestItemDetailAdapter.GetDataByRequestID(str)
        Catch ex As Exception
            GridItemRequestDetail.DataSource = Nothing
        End Try
    End Sub

    Private Sub menuInStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInStock.Click
        If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then
            Dim itemID As Integer = Val(GridItemRequestDetail.GetValue("ItemID"))
            Dim FCompareItemInStock As New frmCompareItemInStock
            FCompareItemInStock.myItemID = itemID
            FCompareItemInStock.isDepartRequestShow = True
            FCompareItemInStock.ShowDialog()
            FCompareItemInStock.Close()
            FCompareItemInStock.Dispose()
        End If
    End Sub

    Private Sub menuEditQtyApprovedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuEditQtyApprovedItem.Click

        If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
            If Not GridItemRequestDetail.CurrentRow Is Nothing AndAlso GridItemRequestDetail.CurrentRow.RowType = RowType.Record Then

                ' Incase request have been approved edit quantity of item in request item list. (2 equals status sent)
                If GridRequestDetail.SelectedItems(0).GetRow.Cells("POStatusID").Value <> 2 Then
                    MessageBox.Show("Cannot edit item quantity , Request has been approved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If Not GridRequestDetail.CurrentRow Is Nothing AndAlso GridRequestDetail.CurrentRow.RowType = RowType.Record Then
                    frmDepartResponseItem.myRequestID = GridRequestDetail.SelectedItems(0).GetRow.Cells("RequestID").Value
                Else
                    Exit Sub
                End If

                frmDepartResponseItem.myRequestDetailID = Val(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("RequestDetailID").Value)
                frmDepartResponseItem.myItemName = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemName").Value

                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value) Then
                    frmDepartResponseItem.myComment = ""
                Else
                    frmDepartResponseItem.myComment = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Comment").Value
                End If

                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value) Then
                    frmDepartResponseItem.myResponseQty = "0"
                Else
                    frmDepartResponseItem.myResponseQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ResponseQuantity").Value
                End If

                If IsDBNull(GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value) Then
                    frmDepartResponseItem.myRequestQty = "0"
                Else
                    frmDepartResponseItem.myRequestQty = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("Quantity").Value
                End If

                frmDepartResponseItem.myItemID = GridItemRequestDetail.SelectedItems(0).GetRow.Cells("ItemID").Value
                frmDepartResponseItem.isRequestInputFromDepart = True

                If frmDepartResponseItem.ShowDialog() = DialogResult.OK Then
                    'RefreshGridRequest()
                    RefreshItemDetail()
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
            ' display item in department stock.
            frm.isDisplayItemDepart = True
            frm.stockDepartID = CInt(DEPART_ID)

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
                            RequestDetail.Status = 2 'Sent  
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
End Class
