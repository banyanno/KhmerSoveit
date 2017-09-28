Public Class frmAccountReceivable

    Private Sub cmdAccName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccName.Click
        Dim frmAccName As New frmAccountName
        frmAccName.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

   

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ValidateDateTimePicker(dtpDate, "", ErrAccountReceiveAble) = False Then Exit Sub
        If Me.cboAccountName.Text = "" Then
            MsgBox("Please select any account name. ", MsgBoxStyle.Information, "Account name confirm")
            Me.cboAccountName.Focus()
        ElseIf Me.chkDollar.Checked = False And Me.chkRiel.Checked = False Then
            MsgBox("Please enter any amount Dollar account in Riel or Dollar.", MsgBoxStyle.Information, "Amount Dollar confirm")
            Me.chkDollar.Checked = True
        ElseIf Me.txtAmountUSD.Text = "" And Me.chkDollar.Checked = True Then
            MsgBox("Please enter the amount of account receivable.", MsgBoxStyle.Information, "Amount RIEL confirm")
            Me.txtAmountUSD.Focus()
        ElseIf Me.txtAmountRiel.Text = "" And Me.chkRiel.Checked = True Then
            MsgBox("Please enter the amount RIEL of account receivable.", MsgBoxStyle.Information, "Amount confirm")
            Me.txtAmountRiel.Focus()
        Else
            If LblReceiveAbleID.Text = "0" Then
                If MAccountReceivable.CheckIDAccDate(Me.cboAccountName.SelectedValue.ToString, Format(Me.dtpDate.Value, "MM/dd/yyyy")) = True Then
                    If MessageBox.Show("Do you want save new value's account recieveabl?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Call MAccountReceivable.SaveAccountAount(Me.cboAccountName.SelectedValue.ToString, IIf(Me.chkDollar.Checked = True, Me.txtAmountUSD.Text, 0), IIf(Me.chkRiel.Checked = True, Me.txtAmountRiel.Text, 0), Format(Me.dtpDate.Value, "MM/dd/yyyy"), USER_NAME)
                    End If
                    Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmountByDate(Format(Me.dtpDate.Value, "MM/dd/yyyy"))
                    Me.cboAccountName.SelectedIndex = -1
                    Me.cboAccountName.Focus()
                Else
                    MsgBox("Please confirm that one account receivable validates only one day.", MsgBoxStyle.Information, "Date confirm")
                    Me.dtpDate.Focus()
                End If
            Else
                Dim Dialogbox As DialogResult
                Dialogbox = MessageBox.Show("Do you want to update this account amount?", "Update account amount", MessageBoxButtons.YesNo)
                If Dialogbox = Windows.Forms.DialogResult.Yes Then
                    Call MAccountReceivable.UpdateAccountAount(LblReceiveAbleID.Text, Me.cboAccountName.SelectedValue.ToString, IIf(Me.chkDollar.Checked = True, Me.txtAmountUSD.Text, 0), IIf(Me.chkRiel.Checked = True, Me.txtAmountRiel.Text, 0), Format(Me.dtpDate.Value, "MM/dd/yyyy"), USER_NAME)
                    Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmountByDate(Format(Me.dtpDate.Value, "MM/dd/yyyy"))
                    Call ClearForm()
                Else
                    Me.cboAccountName.Focus()
                End If
            End If
           

            Me.dgvAccountReceivable.ClearSelection()
            Call USDRIELCalculate()
        End If
    End Sub

    Sub ClearForm()
        Me.lblAID.Text = 0
        Me.LblReceiveAbleID.Text = 0
        Me.cboAccountName.SelectedIndex = -1
        Me.dtpDate.Value = Now
        Me.dtpDate.Checked = False
        Me.txtAmountUSD.Text = ""
        Me.txtAmountRiel.Text = ""
        Me.cboAccountName.Focus()
        Me.chkDollar.Checked = False
        Me.chkRiel.Checked = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Call ClearForm()
        Me.dgvAccountReceivable.ClearSelection()
    End Sub

    Private Sub chkDollar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDollar.CheckedChanged
        If Me.chkDollar.Checked = True Then
            Me.txtAmountUSD.Enabled = True
            Me.txtAmountUSD.Focus()
        Else
            Me.txtAmountUSD.Enabled = False
            Me.txtAmountUSD.Text = ""
        End If
    End Sub

    Private Sub chkRiel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRiel.CheckedChanged
        If Me.chkRiel.Checked = True Then
            Me.txtAmountRiel.Enabled = True
            Me.txtAmountRiel.Focus()
        Else
            Me.txtAmountRiel.Enabled = False
            Me.txtAmountRiel.Text = ""
        End If
    End Sub

    Private Sub USDRIELCalculate()
        Dim i As Integer
        Dim USD, RIEL As Double
        For i = 0 To Me.dgvAccountReceivable.Rows.Count - 1
            USD += Val(Me.dgvAccountReceivable.Rows(i).Cells(3).Value)
            RIEL += Val(Me.dgvAccountReceivable.Rows(i).Cells(4).Value)
        Next
        Me.lblUSD.Text = USD & " $    " & RIEL & " R"
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        'Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmountByDate(Format(Me.dtpDate.Value, "MM/dd/yyyy"))
        Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmmountByDateBetweent(Format(DateFrom.Value, "MM/dd/yyyy"), Format(DateTo.Value, "MM/dd/yyyy"))
        Me.dgvAccountReceivable.ClearSelection()
        Call USDRIELCalculate()
    End Sub

    Private Sub dgvAccountReceivable_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountReceivable.CellDoubleClick
        Dim i As Integer
        For i = 0 To Me.dgvAccountReceivable.Rows.Count - 1
            If Me.dgvAccountReceivable.Rows(i).Selected = True Then
                Me.LblReceiveAbleID.Text = Me.dgvAccountReceivable.Rows(i).Cells(0).Value
                Me.lblAID.Text = Me.dgvAccountReceivable.Rows(i).Cells(1).Value
                Me.dtpDate.Checked = True
                Me.dtpDate.Text = Me.dgvAccountReceivable.Rows(i).Cells(5).Value
                Me.cboAccountName.SelectedValue = Me.dgvAccountReceivable.Rows(i).Cells(1).Value
                If Me.dgvAccountReceivable.Rows(i).Cells(3).Value > 0 Then
                    Me.chkDollar.Checked = True
                    Me.txtAmountUSD.Text = Me.dgvAccountReceivable.Rows(i).Cells(3).Value
                Else
                    Me.chkDollar.Checked = False
                End If
                If Me.dgvAccountReceivable.Rows(i).Cells(4).Value > 0 Then
                    Me.chkRiel.Checked = True
                    Me.txtAmountRiel.Text = Me.dgvAccountReceivable.Rows(i).Cells(4).Value
                Else
                    Me.chkRiel.Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub frmAccountReceivable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblAID.Text = 0
        Me.lblUSD.Text = ""
        Try
            With Me.cboAccountName
                .DataSource = MAccountReceivable.SelectAccountCombo
                .ValueMember = "AID"
                .DisplayMember = "AccountName"
                .SelectedIndex = -1
            End With
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmountAll()
        Me.dgvAccountReceivable.ClearSelection()
        Call USDRIELCalculate()
    End Sub

    Private Sub mnModifyDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnModifyDate.Click
        If Me.dgvAccountReceivable.Rows.Count > 0 Then
            Dim index As Long = ModCommon.GetRowIndexDataGrid(Me.dgvAccountReceivable)
            AIDAR = Me.dgvAccountReceivable.Rows(index).Cells(0).Value
            DateAR = Me.dgvAccountReceivable.Rows(index).Cells(5).Value
            Dim frmUpdateAR As New frmAccountReceivableDate
            frmUpdateAR.ShowDialog()
            Me.dgvAccountReceivable.DataSource = MAccountReceivable.SelectAccountAmountByAID(AIDAR)
            Me.dgvAccountReceivable.ClearSelection()
        End If
    End Sub

    Private Sub cboAccountName_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAccountName.SelectedValueChanged
        Try
            lblAID.Text = cboAccountName.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmountUSD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountUSD.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtAmountRiel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmountRiel.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class