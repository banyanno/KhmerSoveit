Imports System.Math
Imports System.Data.Common

Public Class FormPayment

    Dim ReceiptDataContext As IOpticalShop = New OpticalshopImp
    Dim ObjReceip As New RECEIPT
    Dim ObjTblPatientReceipt As New tblPatientReceipt
    Dim ReturnReal As Double
    Dim ReturnDolar As Double
    Dim StrAmountInDolar As String
    Dim strAmonutInRiel As String
    Private THIDataContext As New BaseDataContext
    Private THTOpticalShopContext As New BaseDataContext
    Dim UCWaitingPayment As New UCDashboardWaitingPayment
    Dim DAWaitingPayment As New DSOpticalShopTableAdapters.VMainReceiptDetailTableAdapter

    Private Sub TxtAmounInReal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmounInReal.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtAmountDolar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountDolar.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub BtnSavePayingReceip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSavePayingReceip.Click

        If ChDolar.Checked = False And ChReal.Checked = False Then
            MsgBox("Please enter any amount in figure Riel or Dollar.", MsgBoxStyle.Information, "Amount figure Riel or Dollar confirm")
            TxtAmounInReal.Select()
            TxtAmounInReal.Focus()
            Exit Sub
        End If

        If ChReal.Checked = True Then
            If ValidateTextField(TxtAmounInReal, "", ErrPayment) = False Then Exit Sub
        End If
        If ChDolar.Checked = True Then
            If ValidateTextField(TxtAmountDolar, "", ErrPayment) = False Then Exit Sub
        End If

        If RadSocial.Checked = True Then
            If ValidateTextField(TxtSocialAmount, "", ErrPayment) = False Then Exit Sub
        End If

        If LblIsPaidStatus.Text = "1" Then
            If Trim(TxtComment.Text) = "" Then
                MessageBox.Show("Please enter Reciept's comment", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtComment.Focus()
                Exit Sub
            End If
        End If

        If MessageBox.Show("Do you want to save this payment?", "pay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObjTblPatientReceipt = ReceiptDataContext.GetTblPatientReceipt(lblReceiptNo.Text)
            ObjReceip = ReceiptDataContext.GetReceipt(LblReceiptID.Text)
            ObjReceip.ReturnDolar = EmptyString(TxtReturnDolar.Text)
            ObjReceip.ReturnReal = EmptyString(TxtReturnReal.Text)
            ObjReceip.AmountInWords = TxtAmountInWord.Text
            ObjReceip.PaidDollar = EmptyString(TxtAmountDolar.Text)
            ObjReceip.PaidR = EmptyString(TxtAmounInReal.Text)

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

            ''' <summary>
            ''' >>>>>>>>Payment Type<<<<<<<<<<<<<
            ''' Full=2
            ''' Nil = 4
            ''' Social = 3
            ''' </summary>

            If RadFundRaising.Checked = True Then
                ObjReceip.FundRaisingR = EmptyString(TxtAmounInReal.Text)
                ObjReceip.FundRaisingDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadSunGlasses.Checked = True Then
                ObjReceip.EyeGlassesReal = EmptyString(TxtAmounInReal.Text)
                ObjReceip.EyeGlassesDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadLV.Checked = True Then
                ObjReceip.EyeGlassesReal = EmptyString(TxtAmounInReal.Text)
                ObjReceip.EyeGlassesDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadSpectacle.Checked = True Then
                ObjReceip.SpectacleR = EmptyString(TxtAmounInReal.Text)
                ObjReceip.SpectacleDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadReadMod.Checked = True Then
                ObjReceip.ReadyModR = EmptyString(TxtAmounInReal.Text)
                ObjReceip.ReadyModDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadMedicine.Checked = True Then
                ObjReceip.MedicReal = EmptyString(TxtAmounInReal.Text)
                ObjReceip.MedicDolar = EmptyString(TxtAmountDolar.Text)
            End If
            If RadOther.Checked = True Then
                ObjReceip.OtherR = EmptyString(TxtAmounInReal.Text)
                ObjReceip.OtherDolar = EmptyString(TxtAmountDolar.Text)
            End If

            If TxtDonateAmount.Text <> "" Then
                '--- Calculate Supported Amount
                Dim SRiel As Double = 0
                Dim SDolar As Double = 0
                CalcuSupportedAmount(SRiel, SDolar)
                ObjReceip.SupportedAmtDolar = SDolar
                ObjReceip.SupportedAmtR = SRiel
            End If

            '--- Save PaymentType 
            If RadFull.Checked = True Then
                ObjReceip.PaymentType = 1
                ObjReceip.FullAmount = Val(TxtFullAmount.Text)
            ElseIf RadNil.Checked = True Then
                ObjReceip.PaymentType = 2
                ObjReceip.NilAmount = Val(TxtNilAmount.Text)
            Else
                ObjReceip.PaymentType = 3
                ObjReceip.SocialAmount = Val(TxtSocialAmount.Text)
            End If

            '--- Save PaymentType Currency
            If RadKHR.Checked = True Then
                ObjReceip.PaymentCur = "KHR"
            Else
                ObjReceip.PaymentCur = "USD"
            End If

            '--- Save comment edit purpose
            If LblIsPaidStatus.Text = "1" Then
                ObjReceip.Comment = TxtComment.Text
            End If
            '---------------- Update TblPatientReceipt to pay ----------------------
            ObjTblPatientReceipt.ConPay = "1"
            ObjTblPatientReceipt.AmoutWord = TxtAmountInWord.Text
            ObjReceip.IsPaid = 1
            If ReceiptDataContext.UpdateReceiptPay = True And LblIsPaidStatus.Text <> "1" Then
                '================= Transaction cut stock ================
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans
                Try
                    '--- Validate department have medicine available for particular prescription 
                    Dim receiptNo As String = lblReceiptNo.Text

                    Dim listReceiptDetail = From receiptDetail In THTOpticalShopContext.getTHIDataContextOpticalShop.RECEIPT_DETAILs Where receiptDetail.ReceiptNo = CDbl(LblReceiptID.Text)
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

                    mytblUsed.UsedDescription = "Sold in Optical Shop receipt : " & lblReceiptNo.Text
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

                MessageBox.Show("The receipt is paid successfully.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UCWaitingPayment.IsEditReceipt = False
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If

        If LblIsPaidStatus.Text = "1" Then
            MessageBox.Show("The receipt was modified.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub FormPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtAmounInReal.Select()
        TxtAmounInReal.Focus()
        'MsgBox(LblIsPaidStatus.Text & "----------------")
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub ChReal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChReal.CheckedChanged
        TxtAmounInReal.Enabled = ChReal.Checked
        TxtAmounInReal.Text = "0"
        TxtAmounInReal.Focus()
        CalculatePaymentReturn()
        WriteAmountInWord()
    End Sub

    Private Sub ChDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDolar.CheckedChanged
        TxtAmountDolar.Enabled = ChDolar.Checked
        TxtAmountDolar.Text = "0"
        TxtAmountDolar.Focus()
        CalculatePaymentReturn()
        WriteAmountInWord()
    End Sub
    Sub CalculatePaymentReturn()


        Dim ReturnReal As Double
        Dim ReturnDolar As Double

        If RadPayRiel.Checked = True And ChDolar.Checked = True And ChReal.Checked = True Then
            ReturnReal = Round(Val(TxtAmountDolar.Text) * 4000, 2)
            TxtReturnReal.Text = Round((Val(EmptyString(TxtAmounInReal.Text)) + ReturnReal) - Val(TxtTotalAsReal.Text), 2)
            TxtReturnDolar.Text = Round(Val(TxtReturnReal.Text) / 4000, 2)
        ElseIf RadPayDolar.Checked = True And ChDolar.Checked = True And ChReal.Checked = True Then
            ReturnDolar = Round(Val(TxtAmounInReal.Text) / 4000, 2)
            TxtReturnDolar.Text = Round((Val(TxtAmountDolar.Text) + ReturnDolar) - Val(TxtTotalAsDolar.Text), 2)
            TxtReturnReal.Text = Round(Val(TxtReturnDolar.Text) * 4000, 2)
        ElseIf RadPayRiel.Checked = True And ChReal.Checked = True Then
            TxtReturnReal.Text = Round(Val(TxtAmounInReal.Text) - Val(TxtTotalAsReal.Text), 2)
            TxtReturnDolar.Text = Round(Val(TxtReturnReal.Text) / 4000, 2)
        ElseIf RadPayRiel.Checked = True And ChDolar.Checked = True Then
            ReturnReal = Val(TxtAmountDolar.Text) * 4000
            TxtReturnReal.Text = Round((Val(TxtAmounInReal.Text) + ReturnReal) - Val(TxtTotalAsReal.Text), 2)
            TxtReturnDolar.Text = Round(Val(TxtReturnReal.Text) / 4000, 2)
        ElseIf RadPayDolar.Checked = True And ChReal.Checked = True Then
            ReturnDolar = Round(Val(TxtAmounInReal.Text) / 4000, 2)
            TxtReturnDolar.Text = Round((Val(TxtAmountDolar.Text) + ReturnDolar) - Val(TxtTotalAsDolar.Text), 2)
            TxtReturnReal.Text = Round(Val(TxtReturnDolar.Text) * 4000, 2)
        ElseIf RadPayDolar.Checked = True And ChDolar.Checked = True Then
            TxtReturnDolar.Text = Round(Val(TxtAmountDolar.Text) - Val(TxtTotalAsDolar.Text), 2)
            TxtReturnReal.Text = Round(Val(TxtReturnDolar.Text) * 4000)
        End If


    End Sub

    Private Sub TxtAmounInReal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAmounInReal.TextChanged
        CalculatePaymentReturn()
        WriteAmountInWord()
    End Sub

    Private Sub TxtAmountDolar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAmountDolar.TextChanged

        CalculatePaymentReturn()
        WriteAmountInWord()

    End Sub
    Sub WriteAmountInWord()
        Dim AmoundInWordRiel As New riel
        Dim AmoundInWordDolar As New dollar
        TxtAmountInWord.Text = AmoundInWordRiel.Convert(TxtAmounInReal.Text) & " និង " & AmoundInWordDolar.Convert(TxtAmountDolar.Text)
        'If ChReal.Checked = True Then
        '    StrAmountInDolar = AmoundInWordRiel.Convert(TxtAmounInReal.Text)
        'End If
    End Sub
    Private Sub RadPayRiel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPayRiel.CheckedChanged
        CalculatePaymentReturn()
        WriteAmountInWord()
    End Sub

    Private Sub RadPayDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPayDolar.CheckedChanged
        CalculatePaymentReturn()
        WriteAmountInWord()
    End Sub

    Sub CalcuSupportedAmount(ByRef SupAmtRiel As Double, ByRef SupAmtDolar As Double)
        If ChReal.Checked = True And ChDolar.Checked = True Then ' Pay both Dolar & Riel
            If Round(Val(EmptyString(TxtDonateAmount.Text)), 2) = (Round(Val(EmptyString(TxtAmountDolar.Text)), 2) + Round(Val(EmptyString(TxtAmounInReal.Text)) / EX_RATE, 2)) Then
                SupAmtDolar = Round(Val(EmptyString(TxtDonateAmount.Text)), 2)
                SupAmtRiel = Round(Val(EmptyString(TxtDonateAmount.Text)) * EX_RATE, 2)
            Else
                SupAmtDolar = Val(TxtDonateAmount.Text) - (Round(Val(EmptyString(TxtAmounInReal.Text)) / EX_RATE, 2) + Round(Val(EmptyString(TxtAmountDolar.Text)), 2))
                SupAmtRiel = Round((Val(TxtDonateAmount.Text) * EX_RATE), 2) - (Round(Val(EmptyString(TxtAmounInReal.Text)), 2) + Round(Val(EmptyString(TxtAmountDolar.Text)) * EX_RATE, 2))
            End If

        ElseIf ChReal.Checked = True And ChDolar.Checked = False Then ' Pay in Riel

            If Round(Val(EmptyString(TxtDonateAmount.Text)), 2) = Round(Val(EmptyString(TxtAmounInReal.Text)) / EX_RATE, 2) Then
                SupAmtDolar = Round(Val(EmptyString(TxtDonateAmount.Text)), 2)
                SupAmtRiel = Round(Val(EmptyString(TxtDonateAmount.Text)) * EX_RATE, 2)
            Else
                SupAmtDolar = Round(Val(TxtDonateAmount.Text), 2) - Round(Val(EmptyString(TxtAmounInReal.Text)) / EX_RATE, 2)
                SupAmtRiel = Round(Val(TxtDonateAmount.Text) * EX_RATE, 2) - Round(Val(EmptyString(TxtAmounInReal.Text)), 2)
            End If

        Else ' Pay in Dolar
            If Round(Val(EmptyString(TxtDonateAmount.Text)), 2) = Round(Val(EmptyString(TxtAmountDolar.Text)), 2) Then
                SupAmtDolar = Round(Val(EmptyString(TxtDonateAmount.Text)), 2)
                SupAmtRiel = Round(Val(EmptyString(TxtDonateAmount.Text)) * EX_RATE, 2)
            Else
                SupAmtDolar = Round(Val(TxtDonateAmount.Text), 2) - Round(Val(EmptyString(TxtAmountDolar.Text)), 2)
                SupAmtRiel = Round(Val(TxtDonateAmount.Text) * EX_RATE, 2) - Round(Val(EmptyString(TxtAmountDolar.Text)) * EX_RATE, 2)
            End If
        End If
    End Sub

    Private Sub RadFull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadFull.CheckedChanged
        TxtFullAmount.Enabled = RadFull.Checked
        TxtNilAmount.Enabled = Not (RadFull.Checked)
        TxtSocialAmount.Enabled = Not (RadFull.Checked)

        If RadKHR.Checked = True Then
            If RadFull.Checked = True Then
                ChReal.Checked = True
                ChDolar.Checked = False
                TxtFullAmount.Text = TxtTotalAsReal.Text
                TxtAmounInReal.Text = TxtTotalAsReal.Text
            End If
        Else
            If RadFull.Checked = True Then
                ChDolar.Checked = True
                ChReal.Checked = False
                TxtFullAmount.Text = TxtTotalAsDolar.Text
                TxtAmountDolar.Text = TxtTotalAsDolar.Text
            End If
        End If

        TxtFullAmount.ReadOnly = True
        TxtNilAmount.Text = ""
        TxtSocialAmount.Text = ""

    End Sub

    Private Sub RadSocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadSocial.CheckedChanged

        TxtFullAmount.Enabled = Not (RadSocial.Checked)
        TxtNilAmount.Enabled = Not (RadSocial.Checked)
        TxtSocialAmount.Enabled = RadSocial.Checked
        TxtSocialAmount.Text = TxtTemSocialAmount.Text

        TxtFullAmount.Text = ""
        TxtNilAmount.Text = ""
        If RadKHR.Checked = True Then
            If RadSocial.Checked = True Then
                ChReal.Checked = True
                TxtAmounInReal.Text = TxtSocialAmount.Text
            End If
        Else
            If RadSocial.Checked = True Then
                ChDolar.Checked = True
                TxtAmountDolar.Text = TxtSocialAmount.Text
            End If
        End If

    End Sub

    Private Sub RadKHR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadKHR.CheckedChanged
        If RadKHR.Checked = True Then
            ChReal.Checked = True
            ChDolar.Checked = False
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsReal.Text
                TxtAmounInReal.Text = TxtFullAmount.Text
            End If
            If RadSocial.Checked = True Then
                TxtAmounInReal.Text = TxtSocialAmount.Text
            End If
        Else
            ChDolar.Checked = True
            ChReal.Checked = False
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsDolar.Text
                TxtAmountDolar.Text = TxtSocialAmount.Text
            End If
            If RadSocial.Checked = True Then
                TxtAmountDolar.Text = TxtSocialAmount.Text
            End If
        End If
    End Sub

    Private Sub RadUSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadUSD.CheckedChanged
        If RadUSD.Checked = True Then
            ChDolar.Checked = True
            ChReal.Checked = False
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsDolar.Text
                TxtAmountDolar.Text = TxtFullAmount.Text
            End If
            If RadSocial.Checked = True Then
                TxtAmountDolar.Text = TxtSocialAmount.Text
            End If
        Else
            ChReal.Checked = True
            ChDolar.Checked = False
            If RadFull.Checked = True Then
                TxtFullAmount.Text = TxtTotalAsReal.Text
                TxtAmounInReal.Text = TxtFullAmount.Text
            End If

            If RadSocial.Checked = True Then
                TxtAmounInReal.Text = TxtSocialAmount.Text
            End If
        End If
    End Sub

    Private Sub TxtSocialAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSocialAmount.TextChanged
        InitAmountFigure()
    End Sub

    Sub InitAmountFigure()
        If RadUSD.Checked = True Then
            ChDolar.Checked = True
            TxtAmountDolar.Text = TxtSocialAmount.Text
        Else
            ChReal.Checked = True
            TxtAmounInReal.Text = TxtSocialAmount.Text
        End If
    End Sub

End Class