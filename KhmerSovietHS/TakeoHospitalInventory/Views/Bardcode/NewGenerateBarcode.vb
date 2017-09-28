Public Class NewGenerateBarcode
    Dim GenerateBarcode As IBarcode = New BarcodeGenerater
    Dim UBarcode As UIBarcodeGenerator
    Sub New(ByVal UBarcode As UIBarcodeGenerator)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.UBarcode = UBarcode
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtAmountGenerate, "", ErrGenerate) = False Then Exit Sub
        If CInt(TxtAmountGenerate.Text) <= 0 Then
            MsgBox("Please enter amount generate great than 0.", MsgBoxStyle.Critical, "Info")
        End If
        If MessageBox.Show("Do you want generate new barcode?", "Generate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For i As Integer = 0 To CInt(TxtAmountGenerate.Text)
                Dim bar As New BARCODE
                bar.BarcodeNo = "I" & String.Format("{0:0000}", GenerateBarcode.GetMaxBarCodeID())
                GenerateBarcode.SaveBardCode(bar)
            Next
            Me.UBarcode.RefreshBarcode()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub TxtAmountGenerate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAmountGenerate.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class