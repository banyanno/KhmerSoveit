Public Class frmInpuItemQty

    Public myItemName As String
    Public myItemQTY As Integer
    Public myItemAlertQTY As Integer
    Public IsCancelProcess As Boolean

    Private Sub txtQuantity_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            '--- Validation
            If ValidateTextField(txtQuantity, "", ErrorProvider1) = False _
               Or ValidateTextField(txtAlertQty, "", ErrorProvider1) = False Then
                Exit Sub
            End If
            myItemQTY = CInt(txtQuantity.Text)
            myItemAlertQTY = CInt(txtAlertQty.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

        If e.KeyCode = Keys.Escape Then
            IsCancelProcess = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub frmInpuItemQty_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = myItemName
    End Sub

    Private Sub txtAlertQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlertQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            '--- Validation
            If ValidateTextField(txtQuantity, "", ErrorProvider1) = False _
               Or ValidateTextField(txtAlertQty, "", ErrorProvider1) = False Then
                Exit Sub
            End If

            myItemQTY = CInt(txtQuantity.Text)
            myItemAlertQTY = CInt(txtAlertQty.Text)

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If

        If e.KeyCode = Keys.Escape Then
            IsCancelProcess = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub frmInpuItemQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            IsCancelProcess = True
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub txtAlertQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlertQty.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class