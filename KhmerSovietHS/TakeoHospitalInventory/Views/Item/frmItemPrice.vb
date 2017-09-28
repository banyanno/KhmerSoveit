Imports System.Data.Common

Public Class frmItemPrice

    Public myItemID As Integer
    Public myBarcode As String
    Public myItemName As String
    Public myItemPriceID As Double
    Private THIDataContext As New BaseDataContext
    Private ItemRepo As IItem = New Item

    Private Sub frmItemPrice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If lblSaveOption.Text = "0" Then
            txtItemName.Text = myItemName
            txtBarcode.Text = myBarcode
            cbCurrentPrice.Checked = True
            rbUSD.Checked = True

        Else '--- Loading data for editable mode

            txtItemName.Text = myItemName
            txtBarcode.Text = myBarcode

            Dim itemPrice As tblItemPrice = ItemRepo.GetItemPriceByItemPriceID(myItemPriceID)
            txtPrice.Text = itemPrice.Price

            If itemPrice.IsCurPrice = True Then
                cbCurrentPrice.Checked = True
            End If

            If itemPrice.IsUSD = True Then
                rbUSD.Checked = True
            End If

            If itemPrice.IsKHR = True Then
                rbKHR.Checked = True
            End If

        End If


    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
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

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        ' Validation
        If ValidateTextField(txtPrice, "Price", ErrorPrice) = False Then
            Exit Sub
        End If

        If lblSaveOption.Text = "0" Then

            If MessageBox.Show("Do you want save new item price ?" & txtItemName.Text & " ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    If cbCurrentPrice.Checked = True Then
                        ' Set all item price record to false
                        THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItemPrice SET IsCurPrice={0} where ItemID={1}", 0, myItemID)
                    End If

                    ' Insert new Price to table tblItemPrice
                    Dim myItemPrice As New tblItemPrice
                    myItemPrice.ItemID = myItemID
                    myItemPrice.IsCurPrice = cbCurrentPrice.Checked
                    myItemPrice.Price = Val(txtPrice.Text)
                    myItemPrice.IsKHR = rbKHR.Checked
                    myItemPrice.IsUSD = rbUSD.Checked
                    myItemPrice.PriceDate = GetDateServer()
                    myItemPrice.UserID = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.tblItemPrices.InsertOnSubmit(myItemPrice)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                    Exit Sub
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("New Item Price save successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Else
            If MessageBox.Show("Do you want save item price " & txtItemName.Text & " ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try

                    If cbCurrentPrice.Checked = True Then
                        ' Set all item price record to false
                        THIDataContext.getTHIDataContext.ExecuteCommand("UPDATE tblItemPrice SET IsCurPrice={0} where ItemID={1}", 0, myItemID)
                        THIDataContext.getTHIDataContext.SubmitChanges()
                    End If

                    ' Update Price to table tblItemPrice
                    'Dim myItemPrice As tblItemPrice = ItemRepo.GetItemPriceByItemPriceID(myItemPriceID)
                    Dim GetItemPrice = From itemPrice In THIDataContext.getTHIDataContext.tblItemPrices Where itemPrice.ItemPriceID = myItemPriceID
                    Dim myItemPrice As tblItemPrice = GetItemPrice.SingleOrDefault

                    myItemPrice.ItemID = myItemID
                    myItemPrice.IsCurPrice = cbCurrentPrice.Checked
                    myItemPrice.Price = Val(txtPrice.Text)
                    myItemPrice.IsKHR = rbKHR.Checked
                    myItemPrice.IsUSD = rbUSD.Checked
                    myItemPrice.PriceDate = GetDateServer()
                    myItemPrice.UserID = CInt(USER_ID)

                    THIDataContext.getTHIDataContext.SubmitChanges()
                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()

                Catch ex As Exception
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MsgBox("Error :" + ex.Message)
                    Exit Sub
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("Item Price save successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
        End If
    End Sub
End Class