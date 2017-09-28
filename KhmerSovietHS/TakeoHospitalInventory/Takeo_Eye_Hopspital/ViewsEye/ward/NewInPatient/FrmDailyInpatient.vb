Public Class FrmDailyInpatient

    Private Sub BtnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplay.Click
        GridDailyInpatiet.DataSource = SelectDailyInpatient(DateFrom.Value, DateTo.Value)
        LblTotalM.Text = CountDailyPatient("Male", DateFrom.Value, DateTo.Value)
        LblTotalF.Text = CountDailyPatient("Female", DateFrom.Value, DateTo.Value)
        LblTotal.Text = CInt(LblTotalM.Text) + CInt(LblTotalF.Text)
    End Sub

    Private Sub GridDailyInpatiet_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDailyInpatiet.DoubleClick
        Try
            Dim frmNurseOC As New FormNurseOnCallEdit
            frmNurseOC.tbNurseOnCall.Text = "Infos: " & Format(Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(1).Value, "dd/MM/yyyy")
            frmNurseOC.DateIn.Text = ""
            frmNurseOC.DateIn.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(1).Value
            frmNurseOC.txtInpatient.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(2).Value
            frmNurseOC.txtAdmission.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(3).Value
            frmNurseOC.txtDischarged.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(4).Value
            frmNurseOC.txtTotal.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(5).Value
            frmNurseOC.txtSurgery.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(6).Value
            frmNurseOC.txtPostCat.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(7).Value
            frmNurseOC.txtPostOther.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(8).Value
            frmNurseOC.txtUlcer.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(9).Value
            frmNurseOC.txtWaiting.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(10).Value
            frmNurseOC.txtOthers.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(11).Value
            frmNurseOC.txtNote.Text = Me.GridDailyInpatiet.SelectedItems(0).GetRow.Cells(12).Value
            frmNurseOC.ShowDialog()
            '------------Show updated data----------------------------
            If frmNurseOC.DialogResult = Windows.Forms.DialogResult.OK Then
                GridDailyInpatiet.DataSource = SelectDailyInpatient(DateFrom.Value, DateTo.Value)
                LblTotalM.Text = CountDailyPatient("Male", DateFrom.Value, DateTo.Value)
                LblTotalF.Text = CountDailyPatient("Female", DateFrom.Value, DateTo.Value)
                LblTotal.Text = CInt(LblTotalM.Text) + CInt(LblTotalF.Text)
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub GridDailyInpatiet_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridDailyInpatiet.FormattingRow
        If (e.Row.RowType = Janus.Windows.GridEX.RowType.Record) Then
            e.Row.CardCaptionText = Me.GridDailyInpatiet.CardCaptionPrefix & Format(e.Row.Cells(GridDailyInpatiet.RootTable.Columns("Date").Index).Value, "dd/MM/yyyy")
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class