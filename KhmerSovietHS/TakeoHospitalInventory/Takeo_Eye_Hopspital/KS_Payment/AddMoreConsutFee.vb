Public Class AddMoreConsutFee
    Dim MWaitingPay As DashboardPayment
    Dim DA_Surgery As New DSWaitingConsultTableAdapters.tblDiagSurgeriesTableAdapter
    Dim DA_AddService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Sub New(ByVal MWaitingPay As DashboardPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MWaitingPay = MWaitingPay
        ' Add any initialization after the InitializeComponent() call.
        With CboSurgery
            .DataSource = DA_Surgery.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
        TxtFree.Text = "0"
    End Sub

    Private Sub CboSurgery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSurgery.SelectedIndexChanged

        Try
            TxtFree.Text = DA_Surgery.SelectSurgeryFee(CboSurgery.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If ValidateCombobox(CboSurgery, "", ErrConsultFee) = False Then Exit Sub
        If ValidateTextField(TxtFree, "", ErrConsultFee) = False Then Exit Sub
        If MessageBox.Show("Do you want add more service fee?", "Service Fee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_AddService.InsertNewWaitingPayment(LblWaitingFee.Text, CboSurgery.Text, EmptyString(TxtFree.Text)) = 1 Then
                Me.MWaitingPay.ViewPatientWaitingPay(LblWaitingFee.Text)
                CboSurgery.Text = ""
                TxtFree.Text = 0
            End If
        End If
    End Sub

    Private Sub TxtFree_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFree.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnService.Click
        Dim FSurgeries As New FRMSurgeryType
        FSurgeries.ShowDialog()
        If FSurgeries.isSurgClose = True Then
            With CboSurgery
                .DataSource = DA_Surgery.GetData
                .ValueMember = "SID"
                .DisplayMember = "Surgeries"
                .SelectedIndex = -1
            End With
            TxtFree.Text = "0"
        End If
        FSurgeries.Dispose()
        FSurgeries.Close()
    End Sub

  
End Class