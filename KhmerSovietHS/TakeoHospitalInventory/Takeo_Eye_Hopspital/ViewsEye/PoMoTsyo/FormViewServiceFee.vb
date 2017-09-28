Public Class FormViewServiceFee
    Dim DAPatientReceipt As New DSDashboardPatientTableAdapters.tblPatientReceiptTableAdapter

   
    Private Sub FormViewServiceFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridServiceFee.DataSource = DAPatientReceipt.GetDataByHN(TxtPatientNo.Text)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class