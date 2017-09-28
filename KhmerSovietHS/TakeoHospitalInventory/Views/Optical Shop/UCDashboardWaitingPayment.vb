Imports System.Data.Common

Public Class UCDashboardWaitingPayment
    Dim DAWaitingPayment As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Dim ReceiptDataContext As IOpticalShop = New OpticalshopImp
    Dim ObjReceip As New RECEIPT
    Public IsEditReceipt As New Boolean
    Public ReceiptNum As String

    Private Sub BtnWaitingReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWaitingReceipt.Click
        LoadPaymentWaiting(0)
    End Sub

    Private Sub BtnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayment.Click
        LoadPayment()
    End Sub
    Sub LoadPaymentWaiting(ByVal isPay As Integer)
        'GridReceipt.DataSource = DAWaitingPayment.GetDataByPaid(isPay)
        GridReceipt.DataSource = DAWaitingPayment.GetDataByPaidAndDate(isPay, DTPFrom.Value.Date, DTPTo.Value.Date)
    End Sub

    Sub LoadPayment()

        If GridReceipt.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to pay.", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim fPayment As New FormPayment
            Dim isDisplayAmountCur As Integer = 0
            ''' <summary>
            ''' >>>>>>>>Income Type<<<<<<<<<<<<<
            ''' Sun Glasses=2
            ''' Spectacle = 4
            ''' Read Mod = 3
            ''' Medicine = 1
            ''' Fund Raising = 5
            ''' Other = 6
            ''' </summary>
            ''' <returns></returns>
            ''' <remarks></remarks>
            Dim TypeNo As Integer = GridReceipt.GetRow.Cells("IncomType").Value
            If TypeNo = 1 Then
                fPayment.RadMedicine.Checked = True
            ElseIf TypeNo = 2 Then
                fPayment.RadSunGlasses.Checked = True
            ElseIf TypeNo = 3 Then
                fPayment.RadReadMod.Checked = True
            ElseIf TypeNo = 4 Then
                fPayment.RadSpectacle.Checked = True
            ElseIf TypeNo = 5 Then
                fPayment.RadFundRaising.Checked = True
            ElseIf TypeNo = 6 Then
                fPayment.RadOther.Checked = True
            End If
            fPayment.LblReceiptID.Text = GridReceipt.GetRow.Cells("ReceiptID").Value
            fPayment.lblReceiptNo.Text = GridReceipt.GetRow.Cells("ReceiptNo").Value
            fPayment.LblReceiptDate.Text = GridReceipt.GetRow.Cells("ReceiptDate").Text
            fPayment.TxtCustomerNo.Text = GridReceipt.GetRow.Cells("CustomerNo").Value
            fPayment.TxtCustomerName.Text = GridReceipt.GetRow.Cells("CusName").Value
            fPayment.TxtAge.Text = GridReceipt.GetRow.Cells("Age").Value
            fPayment.TxtSex.Text = GridReceipt.GetRow.Cells("Sex").Value
            fPayment.TxtTotalAsDolar.Text = GridReceipt.GetRow.Cells("TotalDolar").Value
            fPayment.TxtTotalAsReal.Text = GridReceipt.GetRow.Cells("TotalReal").Value
            If TypeOf GridReceipt.GetRow.Cells("Donation").Value Is DBNull Then
                fPayment.TxtFundName.Text = ""
            Else

                fPayment.TxtFundName.Text = GridReceipt.GetRow.Cells("Donation").Value
                If TypeOf GridReceipt.GetRow.Cells("DonateAmount").Value Is DBNull Then
                    fPayment.TxtDonateAmount.Text = ""
                Else
                    fPayment.TxtDonateAmount.Text = GridReceipt.GetRow.Cells("DonateAmount").Value
                End If

            End If
            If TypeOf GridReceipt.GetRow.Cells("PayByDonation").Value Is DBNull Then
                fPayment.TxtPayByFund.Text = ""
            Else
                fPayment.TxtPayByFund.Text = GridReceipt.GetRow.Cells("PayByDonation").Value
            End If
            If TypeOf GridReceipt.GetRow.Cells("PayBySelf").Value Is DBNull Then
                fPayment.TxtPayBySelf.Text = ""
            Else
                fPayment.TxtPayBySelf.Text = GridReceipt.GetRow.Cells("PayBySelf").Value
            End If


            '--- Load Payment type currency
            If TypeOf GridReceipt.GetRow.Cells("PaymentCur").Value Is DBNull = False Then
                If GridReceipt.GetRow.Cells("PaymentCur").Value = "USD" Then
                    fPayment.RadUSD.Checked = True
                    fPayment.ChDolar.Checked = True
                    isDisplayAmountCur = 1
                Else
                    fPayment.RadKHR.Checked = True
                    fPayment.ChReal.Checked = True
                    isDisplayAmountCur = 2
                End If
            End If

            '--- Load Payment type information
            'MsgBox("Payment Type : ----> " & GridReceipt.GetRow.Cells("PaymentType").Value)
            If TypeOf GridReceipt.GetRow.Cells("PaymentType").Value Is DBNull = False Then
                If GridReceipt.GetRow.Cells("PaymentType").Value = 1 Then
                    If TypeOf GridReceipt.GetRow.Cells("FullAmount").Value Is DBNull = False Then
                        fPayment.TxtFullAmount.Text = GridReceipt.GetRow.Cells("FullAmount").Value
                        fPayment.RadFull.Checked = True
                        If isDisplayAmountCur = 1 Then
                            fPayment.TxtAmountDolar.Text = GridReceipt.GetRow.Cells("FullAmount").Value
                        Else
                            fPayment.TxtAmounInReal.Text = GridReceipt.GetRow.Cells("FullAmount").Value
                        End If
                    Else
                        fPayment.TxtFullAmount.Text = ""
                    End If
                ElseIf GridReceipt.GetRow.Cells("PaymentType").Value = 2 Then
                    If TypeOf GridReceipt.GetRow.Cells("NilAmount").Value Is DBNull = False Then
                        fPayment.TxtNilAmount.Text = GridReceipt.GetRow.Cells("NilAmount").Value
                        fPayment.RadNil.Checked = True
                    Else
                        fPayment.TxtNilAmount.Text = ""
                    End If
                Else
                    If TypeOf GridReceipt.GetRow.Cells("SocialAmount").Value Is DBNull = False Then
                        fPayment.TxtSocialAmount.Text = GridReceipt.GetRow.Cells("SocialAmount").Value
                        fPayment.TxtTemSocialAmount.Text = GridReceipt.GetRow.Cells("SocialAmount").Value

                        fPayment.RadSocial.Checked = True
                        If isDisplayAmountCur = 1 Then
                            fPayment.TxtAmountDolar.Text = GridReceipt.GetRow.Cells("SocialAmount").Value
                        Else
                            fPayment.TxtAmounInReal.Text = GridReceipt.GetRow.Cells("SocialAmount").Value
                        End If
                    Else
                        fPayment.TxtSocialAmount.Text = ""
                    End If
                End If
            End If

            '--- Pass Receipt status value
            fPayment.LblIsPaidStatus.Text = GridReceipt.GetRow.Cells("IsPaid").Value
            '--- Load information receipt paid
            If CInt(GridReceipt.GetRow.Cells("IsPaid").Value) = 1 Then

                fPayment.LblAmountInFigureR.Visible = True
                fPayment.LblAmountInFigureD.Visible = True
                fPayment.Label19.Visible = True
                If TypeOf GridReceipt.GetRow.Cells("Comment").Value Is DBNull Then
                    fPayment.TxtComment.Text = ""
                Else
                    fPayment.TxtComment.Text = GridReceipt.GetRow.Cells("Comment").Value
                End If

                '--- Amount Customer Paid
                If TypeOf GridReceipt.GetRow.Cells("PaidR").Value Is DBNull Then
                    fPayment.TxtAmounInReal.Text = ""
                    fPayment.LblAmountInFigureR.Text = "0.00"
                Else
                    'fPayment.TxtAmounInReal.Text = GridReceipt.GetRow.Cells("PaidR").Value
                    fPayment.LblAmountInFigureR.Text = GridReceipt.GetRow.Cells("PaidR").Value
                    'fPayment.ChReal.Checked = True

                End If

                If TypeOf GridReceipt.GetRow.Cells("PaidDollar").Value Is DBNull Then
                    fPayment.TxtAmountDolar.Text = ""
                    fPayment.LblAmountInFigureD.Text = "0.00"
                Else
                    'fPayment.TxtAmountDolar.Text = GridReceipt.GetRow.Cells("PaidDollar").Value
                    fPayment.LblAmountInFigureD.Text = GridReceipt.GetRow.Cells("PaidDollar").Value
                    'fPayment.ChDolar.Checked = True
                End If

                '--- Amount Return 
                If TypeOf GridReceipt.GetRow.Cells("ReturnReal").Value Is DBNull Then
                    fPayment.TxtReturnReal.Text = ""
                Else
                    fPayment.TxtReturnReal.Text = GridReceipt.GetRow.Cells("ReturnReal").Value
                End If

                If TypeOf GridReceipt.GetRow.Cells("ReturnDolar").Value Is DBNull Then
                    fPayment.TxtReturnDolar.Text = ""
                Else
                    fPayment.TxtReturnDolar.Text = GridReceipt.GetRow.Cells("ReturnDolar").Value
                End If
                '--- Enable Box edit Reciept's comment purpose
                fPayment.TxtComment.Enabled = True
            End If



            If fPayment.ShowDialog = DialogResult.OK Then
                LoadPaymentWaiting(0)
            End If
        End If

    End Sub


    Private Sub BtnCancelReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelReceipt.Click
        If GridReceipt.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            If MessageBox.Show("Do you want to cancel this receipt?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ObjReceip = ReceiptDataContext.GetReceipt(GridReceipt.GetRow.Cells("ReceiptID").Value)
                ObjReceip.IsPaid = 2
                If ReceiptDataContext.UpdateReceiptPay = True Then
                    MessageBox.Show("The receipt have canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GridReceipt.DataSource = DAWaitingPayment.GetDataByPaid(0)
                End If
            End If
        End If
    End Sub

    Private Sub BtnViewReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewReceipt.Click
        LoadPaymentWaiting(2)
    End Sub

    Private Sub BtnUndoReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUndoReceipt.Click
        If GridReceipt.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            If MessageBox.Show("Do you want to undo this receipt?", "Undo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ObjReceip = ReceiptDataContext.GetReceipt(GridReceipt.GetRow.Cells("ReceiptID").Value)
                ObjReceip.IsPaid = 0
                If ReceiptDataContext.UpdateReceiptPay = True Then
                    MessageBox.Show("The undo receipt successful.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GridReceipt.DataSource = DAWaitingPayment.GetDataByPaid(0)
                End If
            End If
        End If

    End Sub

    Private Sub GridReceipt_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridReceipt.RowDoubleClick
        Try
            If GridReceipt.GetValue("PaymentType") <> 2 Then
                BtnApproveNilInvoice.Enabled = False
                BtnPayment.Enabled = True
                LoadPayment()
            Else
                BtnApproveNilInvoice.Enabled = True
                BtnPayment.Enabled = False

            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub BtnFindReceiptForUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindReceiptForUpdate.Click
        Dim FFindReceiptNo As New FrmFindReceipt(Me)
        FFindReceiptNo.ShowDialog()
    End Sub
    Function FindReceiptByNo(ByVal ReceiptNo As String) As Integer
        GridReceipt.DataSource = DAWaitingPayment.GetDataByReceiptNo(ReceiptNo)
        If GridReceipt.SelectedItems.Count > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub BtnWaitingNilInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWaitingNilInvoice.Click
        GridReceipt.DataSource = DAWaitingPayment.GetDataByPayTypeAndIsPaid(0, 2, DTPFrom.Value.Date, DTPTo.Value.Date)
    End Sub

    Private Sub BtnApproveNilInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApproveNilInvoice.Click

        If GridReceipt.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to pay.", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If MessageBox.Show("Do you want to approve NIL Invoice?", "Approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim ReceiptDataContext As IOpticalShop = New OpticalshopImp
                Dim ObjReceip As New RECEIPT
                Dim THIDataContext As New BaseDataContext
                Dim THTOpticalShopContext As New BaseDataContext

                ObjReceip = ReceiptDataContext.GetReceipt(GridReceipt.GetValue("ReceiptID"))
                ObjReceip.IsPaid = 1

                If ReceiptDataContext.UpdateReceiptPay = True Then
                    '================= Transaction cut stock ================
                    THIDataContext.getTHIDataContext.Connection.Close()
                    THIDataContext.getTHIDataContext.Connection.Open()
                    Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                    THIDataContext.getTHIDataContext.Transaction = trans
                    Try
                        '--- Validate department have medicine available for particular prescription                    
                        Dim receiptNo As String = GridReceipt.GetValue("ReceiptNo")
                        Dim listReceiptDetail = From receiptDetail In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_DETAILs Where receiptDetail.ReceiptNo = receiptNo

                        For Each recDetail As RECEIPT_DETAIL In listReceiptDetail.ToList

                            Dim itemID As Integer = CInt(recDetail.ItemID)
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

                        '--- Insert tblUsed 
                        Dim mytblUsed As New tblUsed
                        mytblUsed.UsedDepartID = OPTICALSHOP_DEPART_ID
                        mytblUsed.UsedDate = GetDateServer.Date

                        mytblUsed.UsedDescription = "Sold in Optical Shop receipt : " & receiptNo
                        mytblUsed.UsedUserID = CInt(USER_ID)

                        THIDataContext.getTHIDataContext.tblUseds.InsertOnSubmit(mytblUsed)
                        THIDataContext.getTHIDataContext.SubmitChanges()

                        For Each recDetail As RECEIPT_DETAIL In listReceiptDetail.ToList

                            Dim itemID As Integer = CInt(recDetail.ItemID)
                            '--- Updata Pharmacy stock
                            Dim qDepartStock = From departStock In THIDataContext.getTHIDataContext.tblDeptStocks Where departStock.DepartID = OPTICALSHOP_DEPART_ID And departStock.ItemID = itemID
                            Dim myDepartStock = qDepartStock.SingleOrDefault
                            myDepartStock.UnitsInStock = myDepartStock.UnitsInStock - recDetail.ItemQTY
                            THIDataContext.getTHIDataContext.SubmitChanges()

                            '--- Insert tblUsedDetail
                            Dim mytblUsedDetail As New tblUsedDetail
                            mytblUsedDetail.UsedID = mytblUsed.UsedID
                            mytblUsedDetail.ItemID = itemID
                            mytblUsedDetail.UsedQuantity = recDetail.ItemQTY

                            THIDataContext.getTHIDataContext.tblUsedDetails.InsertOnSubmit(mytblUsedDetail)
                            THIDataContext.getTHIDataContext.SubmitChanges()
                        Next

                        trans.Commit()
                        THIDataContext.getTHIDataContext.Connection.Close()
                    Catch ex As Exception
                        trans.Rollback()
                        THIDataContext.getTHIDataContext.Connection.Close()
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    MessageBox.Show("The receipt save successfully.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPaymentWaiting(0)

                End If
            End If            
        End If

    End Sub
    Private Sub GridReceipt_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridReceipt.SelectionChanged
        Try
            If GridReceipt.GetValue("PaymentType") <> 2 Then
                BtnApproveNilInvoice.Enabled = False
                BtnPayment.Enabled = True
            Else
                BtnApproveNilInvoice.Enabled = True
                BtnPayment.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

  
 
    
End Class
