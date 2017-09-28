Imports System.Data.Common

Public Class frmResponseRequestOrder
    Dim UReceivedRequest As UCReceivedRequest
    Public labelStatus As String
    Public requestID As String
    Dim DepartDataAdapter As DSDepartmentTableAdapters.tblDepartmentTableAdapter
    Dim UserRepo As IUserManagement = New UserManagementImplement
    Dim DepartRepo As IDepartRepository = New DepartRepository
    Dim RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository
    Dim RequestItemDetailAdapter As New DSRequestTableAdapters.VRequestItemDetailTableAdapter
    Private THIDataContext As New BaseDataContext

    Public Sub New(ByVal mainReceivedRequest As UCReceivedRequest)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UReceivedRequest = mainReceivedRequest
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmResponseRequestOrder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '*** Initail combobox department        
        DepartDataAdapter = New DSDepartmentTableAdapters.tblDepartmentTableAdapter
        With cbDepart
            .DataSource = DepartDataAdapter.GetData
            .ValueMember = "DepartID"
            .DisplayMember = "DepartName"
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With

        Select Case labelStatus

            Case "ApprovedEdit"

                'lblStatus.Text = "Approved"
                'PicChecked.Visible = Trues
                labelComment.Visible = True
                rtbComment.Visible = True
                LoadDataRequestOrderInStatusCFA()

            Case "ForwardEdit"
                'lblStatus.Text = "Forward"
                'PicForward.Visible = True
                labelComment.Visible = True
                rtbComment.Visible = True
                LoadDataRequestOrderInStatusCFA()

            Case "ApprovedItems"
                labelComment.Visible = True
                rtbComment.Visible = True
                LoadDataRequestOrderInStatusCFA()

        End Select

        '*** Initail department and user request
        lbOwnerDepart.Text = DepartRepo.GetDepartNameByID(CInt(DEPART_ID))
        lbUserRequest.Text = UserRepo.GetUserNameByID(CInt(USER_ID))

    End Sub
    Private Sub LoadDataRequestOrderInStatusCFA()

        Dim Request As New tblRequest
        If Val(requestID) <> 0 Then
            ' Load data request order (Status : Open or Checked) depend on requestID
            Request = RequestOrderRepo.GetRequestOrderByID(requestID)
            txtReOrNum.Text = Request.RequestOrderNumber
            dtpRDate.Value = Request.RequestDate
            cbDepart.SelectedValue = Request.RequestFromDepartID
            rtbDes.Text = Request.RequestDescription

            ' Load data request items detail (Status : Open or Checked) depend on requestID                    
            Dim myDataTable As New DataTable
            Dim obj(8) As Object
            DGVRequestItemsDetail.Rows.Clear()
            myDataTable = RequestItemDetailAdapter.GetDataByRequestID(requestID)
            For Each aRow As DataRow In myDataTable.Rows
                With DGVRequestItemsDetail
                    obj(0) = aRow("ItemID")
                    obj(1) = aRow("ItemName")
                    obj(2) = aRow("CateName")
                    obj(3) = aRow("ItemUnitName")
                    obj(4) = aRow("ContainerName")
                    obj(5) = aRow("UnitsInStock") '"" 'UnitsInStock (Not Need)
                    obj(6) = aRow("Quantity")
                    obj(7) = aRow("ResponseQuantity")

                    ' Manage request item detail display status
                    If IsDBNull(aRow("Status")) = False Then
                        If aRow("Status") = 7 Then
                            obj(8) = "Approved"
                        Else
                            obj(8) = "Forward"
                        End If
                    Else
                        obj(8) = ""
                    End If
                    '=======

                    .Rows.Add(obj)
                End With
            Next
        End If
        lbNumEntries.Text = DGVRequestItemsDetail.RowCount

        If DGVRequestItemsDetail.RowCount > 0 Then

            If IsDBNull(DGVRequestItemsDetail.Rows(0).Cells("cItemName").Value) = False Then txtItemName.Text = DGVRequestItemsDetail.Rows(0).Cells("cItemName").Value
            If IsDBNull(DGVRequestItemsDetail.Rows(0).Cells("cInStock").Value) = False Then txtInStock.Text = DGVRequestItemsDetail.Rows(0).Cells("cInStock").Value

            If IsDBNull(DGVRequestItemsDetail.Rows(0).Cells("cRQuantity").Value) = False Then txtRequestQty.Text = DGVRequestItemsDetail.Rows(0).Cells("cRQuantity").Value
            If IsDBNull(DGVRequestItemsDetail.Rows(0).Cells("ResponseQty").Value) = False Then txtResponseQty.Text = DGVRequestItemsDetail.Rows(0).Cells("ResponseQty").Value

            If DGVRequestItemsDetail.Rows(0).Cells("cStatus").Value = "Approved" Then
                rbApproved.Checked = True
            End If

            If DGVRequestItemsDetail.Rows(0).Cells("cStatus").Value = "Forward" Then
                rbForward.Checked = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        SaveRequestOrderInStatusApprovedAndForward(9) ' Status Approved and Forward Item

    End Sub
    Private Sub SaveRequestOrderInStatusApprovedAndForward(ByVal pPOStatusID As Integer)

        Dim Request As New tblRequest
        Dim RequestStatusTracking As New tblRequestStatusTracking
        Dim TransMsgStatus As String = ""

        If MessageBox.Show("Do you want save Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try

                '** Transaction process tblRequestDetail
                '** Delete records in tblRquestDetail depend on requestID
                THIDataContext.getTHIDataContext.ExecuteCommand("DELETE FROM tblRequestDetail where RequestID={0}", Val(requestID))
                ' ===

                ' *** Insert new records in tblRequestDetail                             
                For Each rRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim RequestDetail As New tblRequestDetail
                    RequestDetail.RequestID = requestID 'Request.RequestID                            
                    RequestDetail.ItemID = Val(rRow.Cells("cItemNo").Value)
                    RequestDetail.Quantity = Val(rRow.Cells("cRQuantity").Value)

                    If IsDBNull(rRow.Cells("ResponseQty").Value) Then
                        RequestDetail.ResponseQuantity = 0
                    Else
                        RequestDetail.ResponseQuantity = Val(rRow.Cells("ResponseQty").Value)
                    End If

                    ' Manage Item request detail status
                    If rRow.Cells("cStatus").Value = "Approved" Then RequestDetail.Status = 7
                    If rRow.Cells("cStatus").Value = "Forward" Then RequestDetail.Status = 10

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
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddItemReDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemReDetail.Click

        Dim frm As New frmRequestItemsDetail()
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RefreshDataAfterAddItemReDetailClick(frm.objDataTable)
            'Select Case labelStatus
            '    Case "ForwardEdit"
            '        RefreshDataAfterAddItemReDetailClick(frm.objDataTable)
            '    Case "ApprovedEdit"
            '        RefreshDataAfterAddItemReDetailClick(frm.objDataTable)
            'End Select
        End If

    End Sub

    Private Sub RefreshDataAfterAddItemReDetailClick(ByVal pDataTable As DataTable)

        Dim isItemExist As Boolean = False
        Dim obj(8) As Object

        ' Check validate before add to grid not duplicate item
        For Each aRow As DataRow In pDataTable.Rows
            For Each myRow As DataGridViewRow In DGVRequestItemsDetail.Rows
                If myRow.Cells("cItemNo").Value = aRow("ItemID") Then
                    isItemExist = True
                    Exit For
                Else
                    isItemExist = False
                End If
            Next
            If isItemExist = False Then
                With DGVRequestItemsDetail
                    obj(0) = aRow("ItemID")
                    obj(1) = aRow("ItemName")
                    obj(2) = aRow("CateName")
                    obj(3) = aRow("ItemUnitName")
                    obj(4) = aRow("ContainerName")
                    obj(5) = aRow("cInStock")
                    obj(6) = aRow("Quantity")
                    obj(7) = ""
                    obj(8) = ""
                    .Rows.Add(obj)
                End With
            End If
        Next

        lbNumEntries.Text = DGVRequestItemsDetail.RowCount

    End Sub

    Private Sub txtResponseQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponseQty.KeyPress
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

    Private Sub DGVRequestItemsDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGVRequestItemsDetail.SelectionChanged
        ' Load Date Item Response
        For Each myRow As DataGridViewRow In DGVRequestItemsDetail.SelectedRows
            If IsDBNull(myRow.Cells("cRQuantity").Value) = False Then txtRequestQty.Text = myRow.Cells("cRQuantity").Value
            If IsDBNull(myRow.Cells("cInStock").Value) = False Then txtInStock.Text = myRow.Cells("cInStock").Value
            If IsDBNull(myRow.Cells("cItemName").Value) = False Then txtItemName.Text = myRow.Cells("cItemName").Value
            If IsDBNull(myRow.Cells("ResponseQty").Value) = False Then txtResponseQty.Text = myRow.Cells("ResponseQty").Value

            If myRow.Cells("cStatus").Value = "Approved" Then rbApproved.Checked = True
            If myRow.Cells("cStatus").Value = "Forward" Then rbForward.Checked = True
        Next
    End Sub

    Private Sub txtResponseQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResponseQty.TextChanged


        If txtRequestQty.Text <> "" Then
            If Val(txtResponseQty.Text) > Val(txtRequestQty.Text) Then
                MessageBox.Show("Response Quantity must be smaller than Request Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        If Val(txtResponseQty.Text) > Val(txtInStock.Text) Then
            MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If Val(txtResponseQty.Text) > 0 Then
            rbApproved.Checked = True
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'Modify data selected row in gridview
        ' Load Date Item Response
        For Each myRow As DataGridViewRow In DGVRequestItemsDetail.SelectedRows           

            If rbApproved.Checked = True Then
                myRow.Cells("cStatus").Value = "Approved"
                If txtResponseQty.Text = "" Then
                    myRow.Cells("ResponseQty").Value = txtRequestQty.Text
                Else
                    myRow.Cells("ResponseQty").Value = txtResponseQty.Text
                End If
            End If

            If rbForward.Checked = True Then
                myRow.Cells("cStatus").Value = "Forward"
            End If

        Next
    End Sub

    Private Sub rbApproved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbApproved.CheckedChanged
        If rbApproved.Checked = True Then
            If txtResponseQty.Text = "" Then txtResponseQty.Text = txtRequestQty.Text
        Else
            txtResponseQty.Text = ""
        End If
    End Sub

    Private Sub rbForward_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbForward.CheckedChanged

        If rbForward.Checked = True Then
            txtResponseQty.Text = ""
        Else
            txtResponseQty.Text = txtRequestQty.Text
        End If

    End Sub

End Class