Public Class FormMainCategory

    Private Sub BtnIncomeType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIncomeType.Click
        Dim FrmIncomeType As New FormIncomeCategory
        If FrmIncomeType.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class