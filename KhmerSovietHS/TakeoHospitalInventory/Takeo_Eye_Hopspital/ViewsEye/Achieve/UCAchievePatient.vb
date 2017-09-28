Public Class UCAchievePatient
    Dim TblNewPatientBook As DataTable
    Dim DateFrom, DateTo As Date
    Dim PatientNo = "0"
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FAchieveNew As New FRMAChievNew(Me)
        FAchieveNew.ShowDialog()
    End Sub
    Sub showNewPatientBook(ByVal DFrom As Date, ByVal DTo As Date)
        DateFrom = DFrom
        DateTo = DTo
        Try
            BgLoadNewPatientBook.RunWorkerAsync()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BgLoadNewPatientBook_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadNewPatientBook.DoWork
        Try
            If (BgLoadNewPatientBook.CancellationPending) Then ' Test if user hit Cancel key
                e.Cancel = True
                Return
            End If
            TblNewPatientBook = ModNew_Outpatient.SelectNewOutpatientByDate(PatientNo, DateFrom, DateTo, True)
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub BgLoadNewPatientBook_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadNewPatientBook.RunWorkerCompleted
        GridNewOutpatient.DataSource = TblNewPatientBook
        ModCommon.NumberAllRowHeaderDataGrid(GridNewOutpatient)
    End Sub

   
    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click
        PatientNo = EmptyString(TxtPatientNo.Text)
        showNewPatientBook(DateFromAcheive.Value, DateToAchieve.Value)
    End Sub

    Private Sub GridNewOutpatient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridNewOutpatient.CellContentClick

    End Sub

    Private Sub GridNewOutpatient_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridNewOutpatient.ColumnHeaderMouseClick
        ModCommon.NumberAllRowHeaderDataGrid(GridNewOutpatient)
    End Sub
End Class
