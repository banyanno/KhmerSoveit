Public Class FindPatientPrescription
    Dim MainPrescription As UCPrescriptionList
    Sub New(ByVal MainPrescription As UCPrescriptionList)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainPrescription = MainPrescription
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If ValidateTextField(TxtPatientNo, "", ErrFind) = False Then Exit Sub
        MainPrescription.FindPatientPrescription(EmptyString(TxtPatientNo.Text))
        Me.Close()

    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class