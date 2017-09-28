Imports TakeoHospitalInventory
Public Class UCDashbordCashReceipt

    Private Sub cmdIPReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIPReceipt.Click
        Dim frmIPR As New frmInpatientReceipt
        frmIPR.ShowDialog()
    End Sub

    Private Sub cmdNPReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNPReceipt.Click
        Dim frmNOPR As New frmNewOutpatientReceipt
        frmNOPR.ShowDialog()
    End Sub

    Private Sub cmdOPReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOPReceipt.Click
        Dim frmOOPR As New frmOldOutPatientReceipt
        frmOOPR.GReferralFrom.Visible = False
        frmOOPR.GroupBox2.Visible = False
        frmOOPR.GDifficulty.Visible = False
        frmOOPR.ShowDialog()
    End Sub

    Private Sub cmdCashReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCashReceipt.Click
        'Dim frmCR As New frmCashReceipt
        'frmCR.ShowDialog()
        Dim FCashReceived As New FormCashReceive
        FCashReceived.ShowDialog()
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim frmView As New frmPaymentList
        frmView.ShowDialog()
    End Sub

    Private Sub cmdReceiptControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReceiptControl.Click
        Dim frmRContr As New frmReportReceiptController
        frmRContr.ShowDialog()
    End Sub

    Private Sub UCDashbordCashReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccRolesCashier = False
        For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
            With TBLACCESS_ROLE.Rows(i)
                If .Item(0) = "Cashier" Then
                    AccRolesCashier = True
                ElseIf .Item(0) = "Register" Then
                    AccRolesCashier = False
                    Me.cmdView.Enabled = False
                    Me.cmdReceiptControl.Enabled = False
                End If
            End With
        Next
    End Sub
    Dim DAPaymentWaiting As New DSPaymentListTableAdapters.tblPatientReceiptTableAdapter
    Dim DAOpticalShop As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
        'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentList(DateReceipt.Value)
        'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
    End Sub

    Private Sub dgvPaymentList_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentList.CellClick
        Dim i As Integer
        Try
            If Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked Then
                Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Unchecked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = False
                'Me.dgvSearch.Rows(e.RowIndex).Selected = False
            Else
                Me.dgvPaymentList.Rows(e.RowIndex).Cells("Check").Value = CheckState.Checked
                'Me.dgvSearch.Rows(e.RowIndex).Cells(e.RowIndex).Selected = True
                'Me.dgvSearch.Rows(e.RowIndex).Selected = True
            End If
            For i = 0 To Me.dgvPaymentList.Rows.Count - 1
                If Me.dgvPaymentList.Rows(i).Cells(0).Value = CheckState.Checked Then
                    Me.dgvPaymentList.Rows(i).Selected = True
                Else
                    Me.dgvPaymentList.Rows(i).Selected = False
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvPaymentList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentList.CellDoubleClick
        Dim i As Integer
        If Me.dgvPaymentList.RowCount > 0 Then
            For i = 0 To Me.dgvPaymentList.Rows.Count - 1
                With Me.dgvPaymentList.Rows(i)
                    If .Selected = True Then
                        RIDs = .Cells(8).Value
                        CONDs = .Cells(6).Value
                        If CONDs = "CR" Then
                            CRID = .Cells(4).Value
                        End If
                    End If
                End With
            Next
            Dim frmCashReceipt As New frmCashReceipt
            Dim frmInpatientR As New frmInpatientReceipt
            Dim frmNewOPR As New frmNewOutpatientReceipt
            Dim frmOldOPR As New frmOldOutPatientReceipt
            If CONDs = "IR" Then
                isTrueFalse = True
                frmInpatientR.lblID.Text = RIDs
                frmInpatientR.lblReceiptToPrintID.Text = RIDs
                frmInpatientR.ShowDialog()
                '--------Refresh data------------------
                Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            End If
            If CONDs = "NR" Then
                isTrueFalse = True
                frmNewOPR.lblID.Text = RIDs
                frmNewOPR.lblReceiptToPrintID.Text = RIDs
                frmNewOPR.ShowDialog()
                '--------Refresh data------------------
                Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                ' NumberofRecord()
                '--------------------------------------
            End If
            If CONDs = "OR" Then
                isTrueFalse = True
                frmOldOPR.lblID.Text = RIDs
                frmOldOPR.lblReceiptToPrintID.Text = RIDs
                frmOldOPR.GrpReferal.Visible = False
                frmOldOPR.ShowDialog()
                '--------Refresh data------------------
                Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            End If
            If CONDs = "CR" Then
                isTrueFalse = True
                frmCashReceipt.lblID.Text = RIDs
                frmCashReceipt.txtCashReceiptNumber.Text = CRID
                frmCashReceipt.lblReceiptToPrintID.Text = CRID
                frmCashReceipt.ShowDialog()
                '--------Refresh data------------------
                Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            End If
        End If
    End Sub
    'Sub NumberofRecord()
    '    Dim i, j As Integer
    '    For i = 0 To Me.dgvPaymentList.Rows.Count - 1
    '        j = j + 1
    '        Me.dgvPaymentList.Rows(i).Cells(0).Value = j
    '    Next
    'End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim i As Integer
        Dim DialogBox As DialogResult
        If GridJanusWaitingPayment.SelectedItems.Count = 0 Then Exit Sub
        DialogBox = MessageBox.Show("Do you really want to delete this (these) selected receipts?" & Chr(13) & "* Note: The system can  restore the deleted data after deletion.", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
        If DialogBox = Windows.Forms.DialogResult.Yes Then
            '===== update delete status in TblPatient Receipt....................
            Call MReceiptController.DeleteReceipt(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value)
            If GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "OP" Then
                Dim ReceiptDataContext As IOpticalShop = New OpticalshopImp
                Dim ObjReceip As RECEIPT = ReceiptDataContext.GetReceiptNo(CStr(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value))
                ObjReceip.IsPaid = 2
                ReceiptDataContext.UpdateReceiptPay()
            End If
            Me.GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
            '===== Update status delete in Receipt of Opticalshop.................
        End If



        'Dim i As Integer
        'Dim DialogBox As DialogResult
        'If Me.dgvPaymentList.RowCount > 0 Then
        '    DialogBox = MessageBox.Show("Do you really want to delete this (these) selected receipts?" & Chr(13) & "* Note: The system can  restore the deleted data after deletion.", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2)
        '    If DialogBox = Windows.Forms.DialogResult.Yes Then
        '        For i = 0 To Me.dgvPaymentList.Rows.Count - 1
        '            If Me.dgvPaymentList.Rows(i).Cells(0).Value = CheckState.Checked Then
        '                Call MReceiptController.DeleteReceipt(Me.dgvPaymentList.Rows(i).Cells(3).Value)
        '            End If
        '        Next
        '        Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
        '        ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
        '    Else
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Dim frmUndoDel As New frmUndoDelete
        frmUndoDel.ShowDialog()
    End Sub



    Private Sub dgvPaymentList_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPaymentList.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
    End Sub

    Private Sub cmdViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewAll.Click
        GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentListAll
        'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListAll()
        'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
    End Sub

    Private Sub BtnDonated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDonated.Click
        Dim FMainDonation As New FormMainDonateReport
        FMainDonation.ShowDialog()
    End Sub

    Private Sub GridJanusWaitingPayment_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridJanusWaitingPayment.RowDoubleClick
        If GridJanusWaitingPayment.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select receipt to pay.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim frmCashReceipt As New frmCashReceipt
            Dim frmInpatientR As New frmInpatientReceipt
            Dim frmNewOPR As New frmNewOutpatientReceipt
            Dim frmOldOPR As New frmOldOutPatientReceipt

            If GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "IR" Then
                isTrueFalse = True
                frmInpatientR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmInpatientR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmInpatientR.ShowDialog()
                '--------Refresh data------------------
                GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "NR" Then
                isTrueFalse = True
                frmNewOPR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmNewOPR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmNewOPR.ShowDialog()
                '--------Refresh data------------------
                GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                ' NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "OR" Then
                isTrueFalse = True
                frmOldOPR.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmOldOPR.lblReceiptToPrintID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                frmOldOPR.GrpReferal.Visible = False
                frmOldOPR.ShowDialog()
                '--------Refresh data------------------
                GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                'NumberofRecord()
                '--------------------------------------
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "OP" Then
                PaymentForOpticalShop()
                GridJanusWaitingPayment.DataSource = DAPaymentWaiting.GetDataByGetPaymentList(DateReceipt.Value)
            ElseIf GridJanusWaitingPayment.GetRow.Cells("ConGeneral").Value = "CR" Then
                'isTrueFalse = True
                'frmCashReceipt.lblID.Text = GridJanusWaitingPayment.GetRow.Cells("ID").Value
                'frmCashReceipt.txtCashReceiptNumber.Text = CRID
                'frmCashReceipt.lblReceiptToPrintID.Text = CRID
                'frmCashReceipt.ShowDialog()
                ''--------Refresh data------------------
                'Me.dgvPaymentList.DataSource = MPaymentList.GetPaymentListToday(Format(DateReceipt.Value, "MM/dd/yyyy"))
                'ModCommon.NumberAllRowHeaderDataGrid(dgvPaymentList)
                ''NumberofRecord()
                ''--------------------------------------
            End If

        End If
       
    End Sub

    Sub PaymentForOpticalShop()
        ' MsgBox(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value)
        Dim TblOpticalShop As DataTable = DAOpticalShop.GetDataByReceiptNo(GridJanusWaitingPayment.GetRow.Cells("ReceiptNo").Value)
        ' if Rows count > 1 mean have multi receipt.....
        If TblOpticalShop.Rows.Count > 1 Then
        Else
            Dim fPayment As New FormPayment
            Dim isDisplayAmountCur As Integer = 0

            For Each DROW As DataRow In TblOpticalShop.Rows
                Dim TypeNo As Integer = DROW("IncomType")
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
                ElseIf TypeNo = 7 Then
                    fPayment.RadLV.Checked = True
                End If
                fPayment.LblReceiptID.Text = DROW("ReceiptID")
                fPayment.lblReceiptNo.Text = DROW("ReceiptNo")
                fPayment.LblReceiptDate.Text = DROW("ReceiptDate")
                fPayment.TxtCustomerNo.Text = DROW("CustomerNo")
                fPayment.TxtCustomerName.Text = DROW("CusName")
                fPayment.TxtAge.Text = DROW("Age")
                fPayment.TxtSex.Text = DROW("Sex")
                fPayment.TxtTotalAsDolar.Text = DROW("TotalDolar")
                fPayment.TxtTotalAsReal.Text = DROW("TotalReal")
                If TypeOf DROW("isDonation") Is DBNull Then
                    fPayment.TxtFundName.Text = ""
                Else

                    fPayment.TxtFundName.Text = DROW("isDonation")
                    If TypeOf DROW("DonateAmount") Is DBNull Then
                        fPayment.TxtDonateAmount.Text = ""
                    Else
                        fPayment.TxtDonateAmount.Text = DROW("DonateAmount")
                    End If
                End If
                If TypeOf DROW("PayByDonation") Is DBNull Then
                    fPayment.TxtPayByFund.Text = ""
                Else
                    fPayment.TxtPayByFund.Text = DROW("PayByDonation")
                End If
                If TypeOf DROW("PayBySelf") Is DBNull Then
                    fPayment.TxtPayBySelf.Text = ""
                Else
                    fPayment.TxtPayBySelf.Text = DROW("PayBySelf")
                End If


                '--- Load Payment type currency
                If TypeOf DROW("PaymentCur") Is DBNull = False Then
                    If DROW("PaymentCur") = "USD" Then
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
                If TypeOf DROW("PaymentType") Is DBNull = False Then
                    If DROW("PaymentType") = 1 Then
                        If TypeOf DROW("FullAmount") Is DBNull = False Then
                            fPayment.TxtFullAmount.Text = DROW("FullAmount")
                            fPayment.RadFull.Checked = True
                            If isDisplayAmountCur = 1 Then
                                fPayment.TxtAmountDolar.Text = DROW("FullAmount")
                            Else
                                fPayment.TxtAmounInReal.Text = DROW("FullAmount")
                            End If
                        Else
                            fPayment.TxtFullAmount.Text = ""
                        End If
                    ElseIf DROW("PaymentType") = 2 Then
                        If TypeOf DROW("NilAmount") Is DBNull = False Then
                            fPayment.TxtNilAmount.Text = DROW("NilAmount")
                            fPayment.RadNil.Checked = True
                        Else
                            fPayment.TxtNilAmount.Text = ""
                        End If
                    Else
                        If TypeOf DROW("SocialAmount") Is DBNull = False Then
                            fPayment.TxtSocialAmount.Text = DROW("SocialAmount")
                            fPayment.TxtTemSocialAmount.Text = DROW("SocialAmount")
                            fPayment.RadSocial.Checked = True
                            If isDisplayAmountCur = 1 Then
                                fPayment.TxtAmountDolar.Text = DROW("SocialAmount")
                            Else
                                fPayment.TxtAmounInReal.Text = DROW("SocialAmount")
                            End If
                        Else
                            fPayment.TxtSocialAmount.Text = ""
                        End If
                    End If
                End If

                '--- Pass Receipt status value
                fPayment.LblIsPaidStatus.Text = DROW("IsPaid")
                '--- Load information receipt paid
                If CInt(DROW("IsPaid")) = 1 Then

                    fPayment.LblAmountInFigureR.Visible = True
                    fPayment.LblAmountInFigureD.Visible = True
                    fPayment.Label19.Visible = True
                    If TypeOf DROW("Comment") Is DBNull Then
                        fPayment.TxtComment.Text = ""
                    Else
                        fPayment.TxtComment.Text = DROW("Comment")
                    End If

                    '--- Amount Customer Paid
                    If TypeOf DROW("PaidR") Is DBNull Then
                        fPayment.TxtAmounInReal.Text = ""
                        fPayment.LblAmountInFigureR.Text = "0.00"
                    Else
                        'fPayment.TxtAmounInReal.Text = GridReceipt.GetRow.Cells("PaidR").Value
                        fPayment.LblAmountInFigureR.Text = DROW("PaidR")
                        'fPayment.ChReal.Checked = True

                    End If

                    If TypeOf DROW("PaidDollar") Is DBNull Then
                        fPayment.TxtAmountDolar.Text = ""
                        fPayment.LblAmountInFigureD.Text = "0.00"
                    Else
                        'fPayment.TxtAmountDolar.Text = GridReceipt.GetRow.Cells("PaidDollar").Value
                        fPayment.LblAmountInFigureD.Text = DROW("PaidDollar")
                        'fPayment.ChDolar.Checked = True
                    End If

                    '--- Amount Return 
                    If TypeOf DROW("ReturnReal") Is DBNull Then
                        fPayment.TxtReturnReal.Text = ""
                    Else
                        fPayment.TxtReturnReal.Text = DROW("ReturnReal")
                    End If

                    If TypeOf DROW("ReturnDolar") Is DBNull Then
                        fPayment.TxtReturnDolar.Text = ""
                    Else
                        fPayment.TxtReturnDolar.Text = DROW("ReturnDolar")
                    End If
                    '--- Enable Box edit Reciept's comment purpose
                    fPayment.TxtComment.Enabled = True
                End If
            Next
            If fPayment.ShowDialog = DialogResult.OK Then

            End If
        End If

    End Sub

    Private Sub GridJanusWaitingPayment_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridJanusWaitingPayment.FormattingRow

    End Sub

    Private Sub BtnSocialServiceInpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSocialServiceInpatient.Click
        Dim InpatientPay As New InPatientPayFor
        InpatientPay.ShowDialog()
    End Sub

    Private Sub BtnSocialOpticalShop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSocialOpticalShop.Click
        Dim PaymentType As New PPayInOpticalShop
        PaymentType.ShowDialog()
    End Sub
End Class
