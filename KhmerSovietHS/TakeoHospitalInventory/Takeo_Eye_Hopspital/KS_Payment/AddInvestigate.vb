Public Class AddInvestigate
    Dim MWaitingPay As DashboardPayment
    Dim DA_Invest As New DS_Invest_LaserTableAdapters.S_INVESTIGATETableAdapter
    Dim DA_AddService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Sub New(ByVal MWaitingPay As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MWaitingPay = MWaitingPay
        ' Add any initialization after the InitializeComponent() call.
        With CboInvestigate
            .DataSource = DA_Invest.GetData
            .ValueMember = "INVES_ID"
            .DisplayMember = "INVEST_NAME"
            .SelectedIndex = -1
        End With
    End Sub
   
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboInvestigate, "", ErrInvestigage) = False Then Exit Sub
        If ValidateTextField(TxtFree, "", ErrInvestigage) = False Then Exit Sub
        If MessageBox.Show("Do you want add more service fee?", "Service Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_AddService.InsertNewWaitingPayment(LblWaitingID.Text, "Investigate " & CboInvestigate.Text, EmptyString(TxtFree.Text)) = 1 Then
                Me.MWaitingPay.ViewPatientWaitingPay(LblWaitingID.Text)
                CboInvestigate.SelectedIndex = -1
                TxtFree.Text = 0
            End If
        End If
    End Sub

    Private Sub CboInvestigate_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboInvestigate.SelectedValueChanged
        Try
            TxtFree.Text = DA_Invest.SelectInvestPrice(CboInvestigate.SelectedValue)
        Catch ex As Exception
            TxtFree.Text = "0"
        End Try
    End Sub
End Class