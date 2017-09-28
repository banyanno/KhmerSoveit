Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FormPrintBarCode
    Dim ObjRptBarcode As CryBarcodeVeiwer
    Dim DSBarcodde As New DSBarCode
    Dim TblBarcodePrint As DataTable = DSBarcodde.Tables("DynamicBarcode")
   

    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim checkedRows() As Janus.Windows.GridEX.GridEXRow
        'get an array with all the rows that the user checked.
        checkedRows = GridPrintBarcode.GetCheckedRows()
        'if the user didn't check any row, you will get an empty array
        'MsgBox(checkedRows)
        If checkedRows.Length = 0 Then
            MessageBox.Show("Please select at least 1 barcode to print.", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Dim Drow As DataRow
            ObjRptBarcode = New CryBarcodeVeiwer
            TblBarcodePrint.Clear()
            For Each row As Janus.Windows.GridEX.GridEXRow In checkedRows
                Try
                    Dim j As Integer = row.Cells("Rows").Text
                    For k As Integer = 0 To j - 1
                        Drow = TblBarcodePrint.NewRow
                        Drow("DataColumn1") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn2") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn3") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn4") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn5") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn6") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn7") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn8") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn9") = "*" & row.Cells("BarcodeNo").Value & "*"
                        Drow("DataColumn10") = "*" & row.Cells("BarcodeNo").Value & "*"
                        TblBarcodePrint.Rows.Add(Drow)
                    Next
                    j = 0
                Catch ex As Exception

                End Try
              
            Next
            ObjRptBarcode.SetDataSource(TblBarcodePrint)
            CRViewer1.Refresh()
            CRViewer1.ReportSource = ObjRptBarcode

        End If
    End Sub

    Private Sub GridPrintBarcode_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridPrintBarcode.FormattingRow

    End Sub
End Class