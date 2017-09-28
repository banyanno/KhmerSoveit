Public Class frmAccountName

    Dim AccEdit As Integer

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.txtAID.Text = "" Then
            MsgBox("Please enter the ID account name.", MsgBoxStyle.Information, "ID account confirm")
            Me.txtAID.Focus()
        ElseIf Me.txtAccName.Text = "" Then
            MsgBox("Please enter the account name.", MsgBoxStyle.Information, "Account name confirm")
            Me.txtAccName.Focus()
        Else
            If AccEdit = 1 Then
                Dim Dialogbox As DialogResult
                Dialogbox = MessageBox.Show("Do you really want to update this account name?", "Update Account Name", MessageBoxButtons.YesNo)
                If Dialogbox = Windows.Forms.DialogResult.Yes Then
                    Call MAccountReceivable.UpdateAccountName(Me.txtAID.Text, Me.txtAccName.Text.Trim)
                    AccEdit = 0
                Else
                    Me.txtAccName.Focus()
                End If
            Else
                If MAccountReceivable.CheckIDAcc(Me.txtAID.Text) = True Then
                    Call MAccountReceivable.SaveAccountName(Me.txtAID.Text, Me.txtAccName.Text, Format(Date.Now(), "MM/dd/yyyy"), USER_NAME)
                    Me.txtAID.Text = MAccountReceivable.getMaxIDAcc()
                Else
                    MsgBox("This account ID already existed.", MsgBoxStyle.Information, "ID confirm")
                    Me.txtAccName.Focus()
                    Me.txtAID.Text = MAccountReceivable.getMaxIDAcc()
                End If
                Me.txtAccName.Text = ""
                Me.txtAccName.Focus()
            End If
            Me.dgvAccountName.DataSource = MAccountReceivable.SelectAccountName()
        End If
    End Sub

    Private Sub frmAccountName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtAID.Text = MAccountReceivable.getMaxIDAcc()
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Me.dgvAccountName.DataSource = MAccountReceivable.SelectAccountName()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Me.txtAID.Text = MAccountReceivable.getMaxIDAcc()
        Me.txtAccName.Text = ""
        Me.txtAccName.Focus()
        AccEdit = 0
    End Sub

    Private Sub dgvAccountName_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountName.CellContentClick

    End Sub

    Private Sub dgvAccountName_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAccountName.CellDoubleClick
        Dim i As Integer
        For i = 0 To Me.dgvAccountName.Rows.Count - 1
            If Me.dgvAccountName.Rows(i).Selected = True Then
                Me.txtAID.Text = Me.dgvAccountName.Rows(i).Cells(0).Value
                Me.txtAccName.Text = Me.dgvAccountName.Rows(i).Cells(1).Value
                AccEdit = 1
            End If
        Next
    End Sub
End Class