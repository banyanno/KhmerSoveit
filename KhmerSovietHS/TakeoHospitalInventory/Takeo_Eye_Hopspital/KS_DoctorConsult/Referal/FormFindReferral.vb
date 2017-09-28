Public Class FormFindReferral
    Dim MainReferral As DashboardReferral
    Sub New(ByVal MainReferral As DashboardReferral)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainReferral = MainReferral
        ' Add any initialization after the InitializeComponent() call.

    End Sub
   
    Private Sub PatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadPatientNo.Checked = True Then
            MainReferral.FindPatientNo(EmptyString(PatientNo.Text))
        End If
        If RadDateToDate.Checked = True Then
            MainReferral.FindByDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If
    End Sub

    Private Sub RadDateToDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDateToDate.CheckedChanged
        PatientNo.Enabled = False
        DateFrom.Enabled = True
        DateTo.Enabled = True
    End Sub

    Private Sub RadPatientNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPatientNo.CheckedChanged
        PatientNo.Enabled = True
        PatientNo.Focus()
        PatientNo.Select()
        DateFrom.Enabled = False
        DateTo.Enabled = False
    End Sub
End Class