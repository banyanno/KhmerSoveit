Imports System.Data.Common

Public Class frmHospitalRecItem

    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Dim CaritasReqDetailDataAdapter As DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
    Private THIDataContext As New BaseDataContext

    Public RequestCreator As String
    Public RequestNumber As String
    Public RequestDate As String
    Public Comment As String
    Public RequestID As Integer
    Public IsRequestExistingItem As Boolean
    Public Status As Integer

    Private Sub frmHospitalRecItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LbReqCreator.Text = "sam_user"
        LbReqOrderNum.Text = RequestNumber
        LbComment.Text = Comment
        LbReqOrderDate.Text = RequestDate
        LbReqCreator.Text = RequestCreator

        '--- Loading Request Item ----
        Dim myDataTable As New DataTable
        Dim obj(8) As Object
        DGVRequestItemsDetail.Rows.Clear()
        myDataTable = CaritasReqDetailDataAdapter.GetDataCaristasReqDetailByReqID(RequestID)

        For Each aRow As DataRow In myDataTable.Rows

            With DGVRequestItemsDetail
                obj(0) = aRow("IsReceive") ' IsReceive
                obj(1) = aRow("Barcode")  'cBarcode
                obj(2) = aRow("RequestDetailID")
                obj(3) = aRow("ItemID") 'cItemNo
                obj(4) = aRow("ItemName") 'cItemName
                obj(5) = aRow("RequestQuantity") 'cRQuantity
                obj(6) = aRow("ReceivedQuantity") 'cReceived                
                obj(7) = aRow("ExpiredDate")  'cExpiredDate 
                obj(8) = aRow("IsReady") 'IsReady
                .Rows.Add(obj)
            End With
        Next

        If IsRequestExistingItem = False Then
            If Status = 1 Then
                BtnRegisterItem.Visible = False
            End If
        Else
            BtnRegisterItem.Visible = False
        End If

    End Sub

    Public Sub New(ByVal mainCaritasRequestOrder As UCCaritasRequestOrder)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UCaritasRequestOrder = mainCaritasRequestOrder
        CaritasReqDetailDataAdapter = New DSHospitalRequestToCaritasTableAdapters.CARITAS_REQUEST_DETAIL_INVENTORYTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DGVRequestItemsDetail_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DGVRequestItemsDetail.MouseDoubleClick
        Dim DGColmReady As DataGridViewCheckBoxCell = DGVRequestItemsDetail.CurrentRow.Cells("IsReady")
        If DGColmReady.Value = True Then
            MessageBox.Show("You can not add item quanlity request. Because the Item that request already received!", "Received", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            '--- In case request item exist in Hospital
            With DGVRequestItemsDetail
                For Each rRow As DataGridViewRow In .SelectedRows
                    '--- Validate item has been registered
                    If IsDBNull(rRow.Cells("cBarcode").Value) Then
                        MessageBox.Show("Please register item before enter receive item quantity.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    '--- Parse reference variables to frmRecItemAttribute
                    Dim FRecItemAttibute As New frmRecItemAttribute
                    FRecItemAttibute.ItemName = rRow.Cells("cItemName").Value
                    FRecItemAttibute.ReqQuantity = rRow.Cells("cRQuantity").Value
                    FRecItemAttibute.ItemID = rRow.Cells("cItemNo").Value
                    FRecItemAttibute.RequestDetailID = rRow.Cells("cRequestDetailID").Value

                    '--- Get parse result back from frmRecItemAttribute
                    If FRecItemAttibute.ShowDialog() = DialogResult.OK Then
                        Dim TmpRecItemAtt As DataTable = New DSHospitalRequestToCaritas.REC_ITEM_ATTDataTable
                        TmpRecItemAtt = FRecItemAttibute.DTTmpRecItemAtt

                        For Each aRow As DataRow In TmpRecItemAtt.Rows
                            rRow.Cells("cReceived").Value = aRow("ReceivedQuantity")
                            rRow.Cells("cExpiredDate").Value = aRow("ExpiredDate")

                            '--- Update to table CARITAS_REQUEST_DETAIL_INVENTORY
                            Dim THIDataContext As New BaseDataContext
                            THIDataContext.getTHIDataContext.Connection.Close()
                            THIDataContext.getTHIDataContext.Connection.Open()
                            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                            THIDataContext.getTHIDataContext.Transaction = trans

                            Try
                                '--- Implement business update transaction
                                THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_DETAIL_INVENTORY SET ReceivedQuantity={0},ExpiredDate={1} WHERE RequestDetailID={2}", Val(rRow.Cells("cReceived").Value), rRow.Cells("cExpiredDate").Value, Val(rRow.Cells("cRequestDetailID").Value))
                                THIDataContext.getTHIDataContext.SubmitChanges()

                                trans.Commit()
                                THIDataContext.getTHIDataContext.Connection.Close()
                            Catch ex As Exception
                                trans.Rollback()
                                THIDataContext.getTHIDataContext.Connection.Close()
                                MsgBox("Error : " & ex.Message)
                            Finally
                                trans = Nothing
                            End Try

                        Next

                    End If
                    DGVRequestItemsDetail.CurrentRow.Cells("CIsReceive").Value = True
                    DGVRequestItemsDetail.EndEdit()
                    FRecItemAttibute.Close()
                    FRecItemAttibute.Dispose()
                Next
            End With
        End If
        

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim IsNotComplet As Boolean = False
        '--- Validation ---
        Dim itemName As String = ""
        Try
            For Each row As DataGridViewRow In DGVRequestItemsDetail.Rows
                itemName = row.Cells("cItemName").Value
                If row.Cells("cReceived").Value.ToString = "0" And row.Cells("CIsReceive").Value = True Then
                    MessageBox.Show("Please input item Received Quantity << " & itemName & " >>", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    row.DefaultCellStyle.BackColor = Color.BlueViolet
                    IsNotComplet = True
                End If
                
                If row.Cells("cBarcode").Value.ToString = "" And row.Cells("CIsReceive").Value = True Then
                    MessageBox.Show("Please input item Barcode << " & itemName & " >>", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    IsNotComplet = True
                End If

            Next
        Catch ex As Exception
            MessageBox.Show("Please input item Received Quantity , Cost and cBarcode << " & itemName & " >>", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        If IsNotComplet = True Then
            Exit Sub
        End If

        If MessageBox.Show("Do you want save new Request Order ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            THIDataContext.getTHIDataContext.Connection.Close()
            THIDataContext.getTHIDataContext.Connection.Open()
            Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
            THIDataContext.getTHIDataContext.Transaction = trans

            Try
                '--- Update status of request have been received and waiting for approve
                THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE CARITAS_REQUEST_INVENTORY SET Status={0} WHERE RequestID={1}", 1, RequestID)

                '--- Update data to table CARITAS_REQUEST_DETAIL_INVENTORY 
                For Each row As DataGridViewRow In DGVRequestItemsDetail.Rows
                    Dim unitsInStock As Integer = 0
                    If row.Cells("IsReady").Value = True Then
                    Else
                        Dim query = From CRD In THIDataContext.getTHIDataContext.CARITAS_REQUEST_DETAIL_INVENTORies Where CRD.RequestDetailID = Val(row.Cells("cRequestDetailID").Value)
                        Dim CaritasRequestDetail As CARITAS_REQUEST_DETAIL_INVENTORY = query.SingleOrDefault
                        If TypeOf row.Cells("cExpiredDate").Value Is DBNull Then
                            CaritasRequestDetail.ExpiredDate = Nothing
                        Else
                            CaritasRequestDetail.ExpiredDate = DateTime.Parse(row.Cells("cExpiredDate").Value)
                        End If

                        CaritasRequestDetail.ReceivedQuantity = Val(row.Cells("cReceived").Value)
                        If IsDBNull(row.Cells("cBarcode").Value) Then
                            CaritasRequestDetail.Barcode = Nothing
                        Else
                            CaritasRequestDetail.Barcode = row.Cells("cBarcode").Value
                        End If
                        If IsDBNull(row.Cells("cItemNo").Value) Then
                            CaritasRequestDetail.ItemID = Nothing
                        Else
                            CaritasRequestDetail.ItemID = row.Cells("cItemNo").Value
                        End If
                        If IsDBNull(row.Cells("CIsReceive").Value) Then
                            CaritasRequestDetail.IsReceive = Nothing
                        Else
                            CaritasRequestDetail.IsReceive = row.Cells("CIsReceive").Value
                        End If

                        CaritasRequestDetail.IsReady = False
                        '--- Get item balance current stock
                        'Dim qMainStock = From mainStock In THIDataContext.getTHIDataContext.tblCentralInventories Where mainStock.ItemID = Val(row.Cells("cItemNo").Value)
                        'unitsInStock = qMainStock.SingleOrDefault.UnitsInStock
                        'CaritasRequestDetail.PresentStock = unitsInStock

                        THIDataContext.getTHIDataContext.SubmitChanges()
                    End If
                Next

                trans.Commit()
                THIDataContext.getTHIDataContext.Connection.Close()

                MessageBox.Show("Save new request order successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Catch ex As Exception
                trans.Rollback()
                THIDataContext.getTHIDataContext.Connection.Close()
                MsgBox("Error : " & ex.Message)
            Finally
                trans = Nothing
            End Try
        End If
    End Sub

    Private Sub BtnRegisterItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegisterItem.Click

        With DGVRequestItemsDetail
            For Each rRow As DataGridViewRow In .SelectedRows
                If IsDBNull(rRow.Cells("cBarcode").Value) = False Then
                    MessageBox.Show("Item already register.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim FItem As New frmItem
                FItem.lblSaveOption.Text = "0"
                FItem.pItemName = rRow.Cells("cItemName").Value
                FItem.ReqDetailIDItemNotExistInHos = rRow.Cells("cRequestDetailID").Value
                FItem.IsHopRecItem = True

                If FItem.ShowDialog() = DialogResult.OK Then
                    rRow.Cells("cBarcode").Value = FItem.Barcode
                    rRow.Cells("cItemNo").Value = FItem.pItemID
                End If

                FItem.Close()
                FItem.Dispose()

            Next
        End With

    End Sub

    Private Sub DGVRequestItemsDetail_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVRequestItemsDetail.CellContentClick
        'Try
        Dim DGColmCh As DataGridViewCheckBoxCell = DGVRequestItemsDetail.CurrentRow.Cells("CIsReceive")
        If DGVRequestItemsDetail.CurrentCellAddress.X = 0 Then
            DGColmCh = DGVRequestItemsDetail.CurrentRow.Cells("CIsReceive")
            If (DGVRequestItemsDetail.IsCurrentCellDirty) Then
                DGVRequestItemsDetail.CommitEdit(DataGridViewDataErrorContexts.Commit)
                'MsgBox(DGColmCh.Value)
                'Dim CInstock As Integer = DGVRequestItemsDetail.CurrentRow.Cells("cInStock").Value
                'If CInstock <= 0 Then
                '    MessageBox.Show("You can not request Item. Because current stock department that you request out of stock." & vbCrLf & "PLEASE INFORM TO MAIN INVENTORY.", "Alert stock", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    DGCheckBox.Value = False
                '    DGCheckBox.Selected = False
                '    'DGVItemInStock.Refresh()
                'End If

            End If
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DGVRequestItemsDetail_CellMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVRequestItemsDetail.CellMouseUp
        If e.ColumnIndex = 0 Then
            DGVRequestItemsDetail.EndEdit()
            Dim DGColmChNotyet As DataGridViewCheckBoxCell = DGVRequestItemsDetail.CurrentRow.Cells("CIsReceive")
            Dim DGColmReady As DataGridViewCheckBoxCell = DGVRequestItemsDetail.CurrentRow.Cells("IsReady")
            'If DGColmReady Is DBNull = False Then Exit Sub
            If DGColmReady.Value = True Then
                MessageBox.Show("You can not edit item request QTY. Because the Item that request already received!", "Received", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DGColmChNotyet.Value = True
            End If
            DGVRequestItemsDetail.EndEdit()
            'MsgBox(DGColmCh.Value)
        End If
    End Sub
End Class