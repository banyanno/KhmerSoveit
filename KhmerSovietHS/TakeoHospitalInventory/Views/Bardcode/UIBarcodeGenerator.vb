Public Class UIBarcodeGenerator
    Dim DABarcode As New DSBarCodeTableAdapters.BARCODETableAdapter
    Dim DSBarcodde As New DSBarCode
    Dim TblBarcodePrint As DataTable = DSBarcodde.Tables("BarcodeForPrint")
    Private Sub BtnNewBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewBarcode.Click
        Dim GBardcode As New NewGenerateBarcode(Me)
        GBardcode.TopMost = True
        GBardcode.ShowDialog()
    End Sub
    Sub RefreshBarcode()
        GridBarcode.DataSource = DABarcode.GetData
    End Sub

    Private Sub UIBarcodeGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshBarcode()
    End Sub

    Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshData.Click
        RefreshBarcode()
    End Sub

    Private Sub BtnPrintPreviewBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreviewBarcode.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'get an array with all the rows that the user checked.
        checkedRows = GridBarcode.GetCheckedRows()
        'if the user didn't check any row, you will get an empty array
        'MsgBox(checkedRows)
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please select at least 1 barcode to print.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'Dim message As String
            'message = String.Format("You are about to grant {0} permistion(s) to department." _
            '            & vbCrLf & "Do you want to Save?", checkedRows.Length)
            'If MessageBox.Show(message, "Takeo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            'System.Windows.Forms.DialogResult.Yes Then
            For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                Dim row1 As DataRow = TblBarcodePrint.NewRow
                row1("BarcodeNo") = row.Cells("BarcodeNo").Value
                row1("Column") = 10
                row1("Rows") = 5
                TblBarcodePrint.Rows.Add(row1)
            Next
            Dim FPrintBarcode As New FormPrintBarCode
            FPrintBarcode.GridPrintBarcode.DataSource = TblBarcodePrint
            FPrintBarcode.ShowDialog()
            'End If
        End If
    End Sub
End Class
