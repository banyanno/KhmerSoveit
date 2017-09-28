Public Class AddLaserService
    Dim DashPayment As DashboardPayment
    Dim DA_Laser As New DS_Invest_LaserTableAdapters.S_LASERTableAdapter
    Dim DA_AddService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Sub New(ByVal DashPayment As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DashPayment = DashPayment
        ' Add any initialization after the InitializeComponent() call.
        With CboLaser
            .DataSource = DA_Laser.GetData
            .ValueMember = "LASER_ID"
            .DisplayMember = "LASER_NAME"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub CboLaser_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboLaser.SelectedValueChanged
        Try
            TxtFree.Text = DA_Laser.SelectLaserPrice(CInt(CboLaser.SelectedValue))
        Catch ex As Exception
            TxtFree.Text = 0
        End Try
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboLaser, "", ErroLaser) = False Then Exit Sub
        If ValidateTextField(TxtFree, "", ErroLaser) = False Then Exit Sub
        If MessageBox.Show("Do you want add more service fee?", "Service Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_AddService.InsertNewWaitingPayment(LblWaitingID.Text, "Laser " & CboLaser.Text, EmptyString(TxtFree.Text)) = 1 Then
                Me.DashPayment.ViewPatientWaitingPay(LblWaitingID.Text)
                CboLaser.SelectedIndex = -1
                TxtFree.Text = 0
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class