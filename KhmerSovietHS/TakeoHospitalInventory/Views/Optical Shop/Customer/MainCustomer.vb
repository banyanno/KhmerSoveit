Public Class MainCustomer

    Dim ADCustomer As New DSCustomerTableAdapters.RECEIPT_CUSTOMERTableAdapter

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        Dim FNewCustomer As New NewCustomer
        If FNewCustomer.ShowDialog = Windows.Forms.DialogResult.OK Then
            RadCustomerName.Checked = True
            TxtCustomerName.Text = FNewCustomer.TxtCusNameEng.Text
            GridCustomer.DataSource = ADCustomer.GetDataByCustomberName("%" & TxtCustomerName.Text & "%") 'ADCustomer.GetDataByCustomberName("%" &  & "%")
            Threading.Thread.Sleep(700)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If GridCustomer.SelectedItems.Count = 0 Then Exit Sub
        'If MessageBox.Show("Do you want to select this customer?", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadCustomerNo.Checked = True Then
            GridCustomer.DataSource = ADCustomer.GetDataByCustomerNo(EmptyString(TxtCustomerName.Text))
        Else
            GridCustomer.DataSource = ADCustomer.GetDataByCustomberName("%" & TxtCustomerName.Text & "%")
        End If
    End Sub

    Private Sub BtnViewAllData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAllData.Click
        GridCustomer.DataSource = ADCustomer.GetData
    End Sub

    Private Sub GridCustomer_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridCustomer.RowDoubleClick
        If GridCustomer.SelectedItems.Count <= 0 Then Exit Sub
        If MessageBox.Show("Do you want to select this customer?", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub TxtCustomerName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCustomerName.KeyPress
        If RadCustomerNo.Checked = True Then
            SetDisableKeyString(e)
        End If
    End Sub

    Private Sub RadCustomerNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCustomerNo.CheckedChanged
        TxtCustomerName.Text = ""
    End Sub

    Private Sub RadCustomerName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCustomerName.CheckedChanged
        TxtCustomerName.Text = ""
    End Sub
End Class