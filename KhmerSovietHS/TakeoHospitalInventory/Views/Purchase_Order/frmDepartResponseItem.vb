Imports System.Data.Common

Public Class frmDepartResponseItem

    Public myRequestDetailID As Integer
    Public myItemName As String
    Public myComment As String
    Public myResponseQty As String
    Public myRequestQty As String
    Public myItemID As String
    Public myRequestID As String
    Public isRequestInputFromDepart As Boolean

    Private DepartStockRepo As IDepartStockRepository = New DepartStockRepository
    Private THIDataContext As New BaseDataContext
    Private InventoryRepo As IInventory = New Inventory
    Private RequestOrderRepo As IRequestOrderRepository = New RequestOrderRepository


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtResponseQuantity.Text <> "" Then
            ' Validate response quantity must smaller than request quantity
            If Val(txtRequestQuantity.Text) <> 0 Then
                If Val(txtResponseQuantity.Text) > Val(txtRequestQuantity.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than Request Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            Else ' In case request quantity equals 0 so we validate response quantity must be smaller than units in stock.
                If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
                    MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtResponseQuantity.Focus()
                    Exit Sub
                End If
            End If
        End If

        ' In case reqeust quantity greater than quantity in stock
        If Val(txtResponseQuantity.Text) > Val(txtInStock.Text) Then
            MessageBox.Show("Response Quantity must be smaller than InStock Quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResponseQuantity.Focus()
            Exit Sub
        End If


        THIDataContext.getTHIDataContext.Connection.Close()
        THIDataContext.getTHIDataContext.Connection.Open()
        Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
        THIDataContext.getTHIDataContext.Transaction = trans

        Try
            ' Update table tblRequestDetail
            Dim q = From RD In THIDataContext.getTHIDataContext.tblRequestDetails Where RD.RequestDetailID = myRequestDetailID
            Dim RequestDetail As tblRequestDetail = q.SingleOrDefault
            RequestDetail.ResponseQuantity = Val(txtResponseQuantity.Text)
            RequestDetail.Status = 2 'Sent            
            THIDataContext.getTHIDataContext.SubmitChanges()
            '===

            ' Update table tblRequestStatusTracking (UserID update , Comment update)
            Dim RequestST = From RST In THIDataContext.getTHIDataContext.tblRequestStatusTrackings Where RST.RequestID = Val(myRequestID)
            Dim myRequestStatusTracking As tblRequestStatusTracking = RequestST.SingleOrDefault
            myRequestStatusTracking.UserIDRequestUpdateStatus = CInt(USER_ID)
            myRequestStatusTracking.Comment = rtbComment.Text
            THIDataContext.getTHIDataContext.SubmitChanges()

            trans.Commit()
            THIDataContext.getTHIDataContext.Connection.Close()

        Catch ex As Exception
            trans.Rollback()
            THIDataContext.getTHIDataContext.Connection.Close()
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub frmInputQuantityApproved_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtItemName.Text = myItemName
        txtResponseQuantity.Text = myResponseQty
        txtRequestQuantity.Text = myRequestQty

        If isRequestInputFromDepart = False Then
            txtInStock.Text = InventoryRepo.GetMainStockQuantityByItemID(CInt(myItemID))
        Else
            txtInStock.Text = DepartStockRepo.GetUnitInStockDepartByDepartIDAndItemID(CInt(DEPART_ID), CInt(myItemID))
        End If
        rtbComment.Text = myComment

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponseQuantity.KeyPress
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

End Class