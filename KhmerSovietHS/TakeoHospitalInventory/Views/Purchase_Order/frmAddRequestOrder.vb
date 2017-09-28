Imports System.Data.Common

Public Class frmAddRequestOrder

    Dim URequestOrder As UCRequestOrder
    Dim URequestOrder_V1 As UCRequestOrder_V1
    Public labelStatus As String
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Private THIDataContext As New BaseDataContext
    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Public requestID As String
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Dim RequestDetailRepo As IRequestDetailRepository = New RequestDetailRepository
    Dim TransMsgStatus As String = ""
    Dim UserRepo As IUserManagement = New UserManagementImplement
    Dim DepartRepo As IDepartRepository = New DepartRepository
    Dim ItemRequestDT As New DSCategoriesAndItems.ItemReqDataTable


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub New(ByVal mainRequestOrder As UCRequestOrder)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        URequestOrder = mainRequestOrder
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal mainRequestOrder_V1 As UCRequestOrder_V1)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        URequestOrder_V1 = mainRequestOrder_V1
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmAddRequestOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        dtpRDate.Value = GetDateServer()
        ' Initail combobox department
        ' TODO : Prevent request to owner department        
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter

        With cbDepart
            '.DataSource = DepartDataAdapter.GetData
            .DataSource = DepartDataAdapter.GetDepartListExcludeOwner(Val(DEPART_ID))
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        Select Case labelStatus
            Case "Open"
                lblStatus.Text = "Open"
                'PicOpen.Visible = True
                txtReOrNum.Visible = False
                Label3.Visible = False

            Case "OpenEdit"
                lblStatus.Text = "Open"
                'PicOpen.Visible = True
                LoadDataRequestOrderInStatusCFA()
            Case "Checked"

                lblStatus.Text = "Checked"
                'PicChecked.Visible = True
                labelComment.Visible = True
                rtbComment.Visible = True
                LoadDataRequestOrderInStatusCFA()
                
            Case "Forward"
                lblStatus.Text = "Forward"
                'PicForward.Visible = True
                labelComment.Visible = True
                rtbComment.Visible = True
                LoadDataRequestOrderInStatusCFA()

            Case "Approved"
                lblStatus.Text = "Approved"
                'PicApproved.Visible = True
                lblDescription.Text = "Comment :"
                LoadDataRequestOrderInStatusCFA()
        End Select

        '*** Initail department and user request
        lbOwnerDepart.Text = DepartRepo.GetDepartNameByID(CInt(DEPART_ID))
        lbUserRequest.Text = UserRepo.GetUserNameByID(CInt(USER_ID))

    End Sub

    Public Sub RefreshGridRequestDetailItem(ByVal pArrList As ArrayList)
        'Dim obj(6) As Object
        'obj(0) = "dfsdf"
        'obj(1) = "dfsdf"
        'obj(2) = "dfsdf"
        'obj(3) = "dfsdf"
        'obj(4) = "dfsdf"
        'obj(5) = "dfsdf"
        'obj(6) = "dfsdf"
        'gridRequestDetailItem.AddItem(obj)
        'For iterator As Integer = 0 To pArrList.Count - 1
        '    gridRequestDetailItem.AddItem(pArrList(iterator))
        'Next
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim Request As New tblRequest        
        Dim RequestStatusTracking As New tblRequestStatusTracking

        If ValidateCombobox(cbDepart, "Department", ErrorRequestOrder) = False Then
            Exit Sub
        End If

        If Val(DEPART_ID) = cbDepart.SelectedValue Then
            MessageBox.Show("Self request are not allowed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Select Case labelStatus
            Case "Open"
                SaveRequestOrderInStatusOpen()
            Case "OpenEdit"
                SaveUpdateRequestOrderInStatusOCFA(OPEN)
                'Case "Checked"
                '    SaveUpdateRequestOrderInStatusOCFA(2)
                'Case "Forward"
                '    SaveUpdateRequestOrderInStatusOCFA(3)
                'Case "Approved"
                '    SaveUpdateRequestOrderInStatusOCFA(4)
        End Select

    End Sub

    Sub RefreshDataAfterAddItemReDetailClick(ByVal pDataTable As DataTable)
        Dim obj(7) As Object
        DGVRequestItemsDetail.Rows.Clear()
        For Each aRow As DataRow In pDataTable.Rows
            With DGVRequestItemsDetail
                obj(0) = aRow("ItemID")
                obj(1) = aRow("ItemName")
                obj(2) = aRow("CateName")
                obj(3) = aRow("ItemUnitName")
                obj(4) = aRow("ContainerName")
                obj(5) = aRow("cInStock")
                obj(6) = aRow("Quantity")
                obj(7) = aRow("Barcode")
                .Rows.Add(obj)
            End With
        Next
        lbNumEntries.Text = DGVRequestItemsDetail.RowCount
    End Sub
    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub DGVRequestItemsDetail_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVRequestItemsDetail.EditingControlShowing
        If DGVRequestItemsDetail.CurrentCell.ColumnIndex = 6 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub
    Private Sub LoadDataRequestOrderInStatusCFA()

        Dim Request As New tblRequest
        If Val(requestID) <> 0 Then

            ' Load data request order (Status : Open or Checked) depend on requestID
            Request = RequestOrderRepo.GetRequestOrderByID(requestID)
            txtReOrNum.Text = Request.RequestOrderNumber
            dtpRDate.Value = Request.RequestDate
            cbDepart.SelectedValue = Request.RequestToDepartID
            rtbDes.Text = Request.RequestDescription

            ' Load data request items detail (Status : Open or Checked) depend on requestID                    
            Dim myDataTable As New DataTable
            Dim obj(7) As Object
            DGVRequestItemsDetail.Rows.Clear()
            myDataTable = RequestItemDetailAdapter.GetDataByRequestID(requestID)
            For Each aRow As DataRow In myDataTable.Rows
                With DGVRequestItemsDetail
                    obj(0) = aRow("ItemID")
                    obj(1) = aRow("ItemName")
                    obj(2) = aRow("CateName")
                    obj(3) = aRow("ItemUnitName")
                    obj(4) = aRow("ContainerName")
                    obj(5) = "" 'UnitsInStock (Not Need)
                    obj(6) = aRow("Quantity")
                    obj(7) = aRow("Barcode")
                    .Rows.Add(obj)
                End With

                Dim dataRow As DataRow = ItemRequestDT.NewRow
                dataRow("ItemID") = aRow("ItemID")
                dataRow("ItemName") = aRow("ItemName")
                dataRow("CateName") = aRow("CateName")
                dataRow("ItemUnitName") = aRow("ItemUnitName")
                dataRow("ContainerName") = aRow("ContainerName")
                dataRow("cInStock") = ""
                dataRow("Quantity") = aRow("Quantity")
                dataRow("Barcode") = aRow("Barcode")
                ItemRequestDT.Rows.Add(dataRow)

            Next
        End If
        lbNumEntries.Text = DGVRequestItemsDetail.RowCount
    End Sub

    Private Sub SaveRequestOrderInStatusOpen()

        Dim Request As New tblRequest
        Dim RequestStatusTracking As New tblRequestStatusTracking
        Dim RequestHistoryStatusTracking As New tblRequestHistoryStatusTracking

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

                Request.RequestFromDepartID = CInt(DEPART_ID)
                Request.RequestDate = dtpRDate.Value
                Request.RequestToDepartID = Val(cbDepart.SelectedValue)
                Request.RequestDescription = rtbDes.Text
                'Request.UserID = CInt(USER_ID)s
                Request.UserRequestName = USER_NAME

                THIDataContext.getTHIDataContext.tblRequests.InsertOnSubmit(Request)
                THIDataContext.getTHIDataContext.SubmitChanges()
                '===
                ' Insert new record in tblRequestDetail     
                'DGVRequestItemsDetail
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows

                    Dim itemID As Integer = Val(rRow.Cells("cItemNo").Value)

                    Dim unitsInStock As Integer = 0
                    If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                        Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = itemID
                        unitsInStock = qMainStock.SingleOrDefault.UnitsInStock
                    Else

                        '--- Verify item exit in department stock before get item's quantity
                        Dim itemCount = (From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = itemID).Count                        
                        If Val(itemCount) <> 0 Then
                            Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = itemID
                            unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock
                        End If

                    End If

        Dim RequestDetail As New tblRequestDetail
        RequestDetail.RequestID = Request.RequestID 'requestID 'Request.RequestID                            
        RequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
        RequestDetail.Quantity = Val(rRow.Cells("cRQuantity").Value)
        RequestDetail.CurrentBalance = unitsInStock
        THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
        THIDataContext.getTHIDataContext.SubmitChanges()

                Next

                '--- Insert new record in tblRequestStatusTracking                 
                RequestStatusTracking.RequestID = Request.RequestID 'requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                RequestStatusTracking.POStatusID = OPEN ' 1
                RequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                RequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                THIDataContext.getTHIDataContext.tblRequestStatusTrackings.InsertOnSubmit(RequestStatusTracking)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '---  insert record in table tblRequestHistoryStatusTracking
                RequestHistoryStatusTracking.RequestID = Request.RequestID 'requestID
                RequestHistoryStatusTracking.POStatusID = OPEN '1                
                RequestHistoryStatusTracking.UpdateRequestStatusDate = GetDateServer()
                RequestHistoryStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)

                THIDataContext.getTHIDataContext.tblRequestHistoryStatusTrackings.InsertOnSubmit(RequestHistoryStatusTracking)
                THIDataContext.getTHIDataContext.SubmitChanges()

                '--- Update Request order numberd
                Dim requestOrderNumber As String = "RO" & String.Format("{0:0000000000}", Request.RequestID)
                THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblRequest SET RequestOrderNumber={0} where RequestID={1}", requestOrderNumber, Request.RequestID)
                THIDataContext.getTHIDataContext.SubmitChanges()


                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim itemID As Integer = Val(rRow.Cells("cItemNo").Value)
                    Try
                        '--- Register Begin Balance of item 
                        Dim unitsInStock As Integer = 0
                        If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                            Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = itemID
                            unitsInStock = qMainStock.SingleOrDefault.UnitsInStock
                        Else
                            Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = itemID
                            unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock
                        End If

                        Dim q = (From BBT In THIDataContext.getTHIDataContext.tblBeginBalanceTraces Where BBT.Date.Value.Date = GetDateServer.Date And BBT.DepartID = CInt(DEPART_ID) And BBT.ItemID = itemID Select BBT.BeginBalanceTraceID).Count
                        If q = 0 Then

                            Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                            mytblBeginBalanceTrace.Date = GetDateServer()
                            mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                            mytblBeginBalanceTrace.BeginBalanceOfDay = unitsInStock
                            mytblBeginBalanceTrace.ItemID = itemID

                            THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        End If


                    Catch ex As Exception
                        Dim mytblBeginBalanceTrace As New tblBeginBalanceTrace
                        mytblBeginBalanceTrace.Date = GetDateServer()
                        mytblBeginBalanceTrace.DepartID = CInt(DEPART_ID)
                        mytblBeginBalanceTrace.BeginBalanceOfDay = 0
                        mytblBeginBalanceTrace.ItemID = itemID

                        THIDataContext.getTHIDataContext.tblBeginBalanceTraces.InsertOnSubmit(mytblBeginBalanceTrace)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    End Try
                Next


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
                MessageBox.Show("Save new request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub

    Private Sub SaveUpdateRequestOrderInStatusOCFA(ByVal pPOStatusID As Integer)

        Dim Request As New tblRequest
        Dim RequestStatusTracking As New tblRequestStatusTracking

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


        If MessageBox.Show("Do you want save Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                'Update record in tblRequest
                Request = RequestOrderRepo.GetRequestOrderByID(Val(requestID))
                Request.RequestID = requestID
                Request.RequestOrderNumber = txtReOrNum.Text
                Request.RequestFromDepartID = CInt(DEPART_ID)
                Request.RequestDate = dtpRDate.Value
                Request.RequestToDepartID = Val(cbDepart.SelectedValue)
                Request.RequestDescription = rtbDes.Text

                RequestOrderRepo.UpdateRequestOrder() ' User this statement instead of statement below cause statement cannot update table in database
                'THIDataContext.getTHIDataContext.SubmitChanges()
                '===

                '** Transaction process tblRequestDetail
                '** Delete records in tblRquestDetail depend on requestID
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", Val(requestID))
                ' ===

                ' *** Insert new records in tblRequestDetail                             
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    '--- Get current balance in stock before send request
                    Dim itemID As Integer = Val(rRow.Cells("cItemNo").Value)

                    Dim unitsInStock As Integer = 0
                    If CInt(DEPART_ID) = MAIN_STOCK_DEPART_ID Then
                        Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = itemID
                        unitsInStock = qMainStock.SingleOrDefault.UnitsInStock
                    Else
                        '--- Verify item exit in department stock before get item's quantity
                        Dim itemCount = (From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = itemID).Count
                        If Val(itemCount) <> 0 Then
                            Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = CInt(DEPART_ID) And departStock.ItemID = itemID
                            unitsInStock = qDepartStock.SingleOrDefault.UnitsInStock
                        End If

                    End If

                    Dim RequestDetail As New tblRequestDetail
                    RequestDetail.RequestID = requestID 'Request.RequestID                            
                    RequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    RequestDetail.Quantity = Val(rRow.Cells("cRQuantity").Value)
                    RequestDetail.CurrentBalance = unitsInStock
                    THIDataContext.getTHIDataContext.tblRequestDetails.InsertOnSubmit(RequestDetail)
                    THIDataContext.getTHIDataContext.SubmitChanges()
                Next
                '====

                '** Transaction process tblRequestStatusTracking
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestStatusTracking where RequestID={0}", Val(requestID))
                '*** Insert new record in tblRequestStatusTracking                        
                RequestStatusTracking.RequestID = requestID 'RequestOrderRepo.GetMaxRequestID().ToString
                RequestStatusTracking.POStatusID = pPOStatusID
                RequestStatusTracking.UpdateRequestStatusDate = GetDateServer()
                RequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)
                RequestStatusTracking.Comment = rtbComment.Text

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
                Me.Close()
            Else
                MsgBox("Transaction Error: " & TransMsgStatus)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub

    Private Sub btnAddItemReDetail1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemReDetail1.Click
        Dim frm As New frmRequestItemsDetail(Me)

        If cbDepart.SelectedValue = MAIN_STOCK_DEPART_ID Then
            frm.isDisplayItemInMainStock = True
            'frm.stockDepartID = MAIN_STOCK_DEPART_ID
            frm.stockDepartID = CInt(DEPART_ID) '--- Request to Main stock and display item has permission
            frm.ItemRequestDT = ItemRequestDT
            frm.LblItemInstock.Text = "Items available in stock : " & cbDepart.Text.ToUpper
        Else
            frm.isDisplayItemDepart = True
            frm.stockDepartID = cbDepart.SelectedValue
            frm.ItemRequestDT = ItemRequestDT
            frm.LblItemInstock.Text = "Items available in stock : " & cbDepart.Text.ToUpper
        End If

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Select Case labelStatus
                Case "Open"
                    DGVRequestItemsDetail.DataSource = frm.ItemRequestDT
                Case "OpenEdit"
                    RefreshDataAfterAddItemReDetailClick(frm.ItemRequestDT)
                Case "Checked"
                    RefreshDataAfterAddItemReDetailClick(frm.ItemRequestDT)
                Case "Forward"
                    RefreshDataAfterAddItemReDetailClick(frm.ItemRequestDT)
                Case "Approved"
                    RefreshDataAfterAddItemReDetailClick(frm.ItemRequestDT)
            End Select
        End If
    End Sub

    Private Sub btnRemoveItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem1.Click
        With DGVRequestItemsDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If MessageBox.Show("Do you want delete item Request Detail ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    .Rows.Remove(rRow)
                End If
            Next
        End With
    End Sub

    Private Sub cbDepart_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDepart.SelectedValueChanged

        Try
            If cbDepart.SelectedValue = CInt(DEPART_ID) Then
                MessageBox.Show("Self request are not allowed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbDepart.Focus()
            End If
        Catch ex As Exception

        End Try
       

        '--- Block of code below use instead of DGVRequestItemsDetail.Rows.Clear()
        For Each row As DataGridViewRow In DGVRequestItemsDetail.Rows
            DGVRequestItemsDetail.Rows.RemoveAt(row.Index)
        Next

        Dim rowCount As Integer = DGVRequestItemsDetail.Rows.Count
        For i As Integer = 0 To rowCount - 1
            Try
                Dim delRow As DataGridViewRow = DGVRequestItemsDetail.Rows(i)
                DGVRequestItemsDetail.Rows.Remove(delRow)
            Catch ex As Exception
                Dim delRow1 As DataGridViewRow = DGVRequestItemsDetail.Rows(0)
                DGVRequestItemsDetail.Rows.Remove(delRow1)
            End Try
        Next


    End Sub


End Class