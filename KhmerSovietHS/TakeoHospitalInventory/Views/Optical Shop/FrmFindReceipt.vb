Public Class FrmFindReceipt
    Dim UCWaitingPayment As UCDashboardWaitingPayment
    Sub New(ByVal waitingPayment As UCDashboardWaitingPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.UCWaitingPayment = waitingPayment
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub FrmFindReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If UCWaitingPayment.FindReceiptByNo(TxtReceiptNo.Text) = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Receipt No do not exist in system. Could you check receipt no agian.", "Find Receipt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class