Public Class AddLaboratory

    Dim MWaitingPay As DashboardPayment
    Dim DA_LABO As New DS_Invest_LaserTableAdapters.S_LABORATORYTableAdapter
    Dim DA_AddService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Sub New(ByVal MWaitingPay As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MWaitingPay = MWaitingPay
        ' Add any initialization after the InitializeComponent() call.
        With CboLabo
            .DataSource = DA_LABO.GetData
            .ValueMember = "LABO_ID"
            .DisplayMember = "LABO_NAME"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboLabo, "", ErrLaboratory) = False Then Exit Sub
        If ValidateTextField(TxtLaboFee, "", ErrLaboratory) = False Then Exit Sub
        If MessageBox.Show("Do you want add more service fee?", "Service Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_AddService.InsertNewWaitingPayment(LblWaitingID.Text, "Labo:" & CboLabo.Text, EmptyString(TxtLaboFee.Text)) = 1 Then
                Me.MWaitingPay.ViewPatientWaitingPay(LblWaitingID.Text)
                CboLabo.SelectedIndex = -1
                TxtLaboFee.Text = 0
            End If
        End If
    End Sub

    Private Sub CboLabo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboLabo.SelectedIndexChanged
        Try
            TxtLaboFee.Text = DA_LABO.GetLaboPriceByID(CboLabo.SelectedValue.ToString)
        Catch ex As Exception

        End Try
    End Sub
End Class