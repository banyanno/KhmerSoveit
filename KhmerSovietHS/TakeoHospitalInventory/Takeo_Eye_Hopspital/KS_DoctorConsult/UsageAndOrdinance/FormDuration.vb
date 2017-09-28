Public Class FormDuration
    Dim DA_Duration As New DSOrdinanceTableAdapters.S_DURATIONTableAdapter
    Private Sub FormDuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDuration()
    End Sub
    Sub LoadDuration()
        GridDuration.DataSource = DA_Duration.GetData
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If MessageBox.Show("Do you want to add new duration?", "Duration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Duration.InsertNewDuration(TxtOrdinance.Text) = 1 Then
                LoadDuration()
            End If
        End If
    End Sub

    Private Sub BtnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSub.Click
        If GridDuration.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete duration?", "Duration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Duration.DeleteDuration(GridDuration.GetRow.Cells("DURATION_ID").Value) = 1 Then
                LoadDuration()
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to update duration?", "Duration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_Duration.UpdateDuration(TxtOrdinance.Text, GridDuration.GetRow.Cells("DURATION_ID").Value) = 1 Then
                LoadDuration()
            End If
        End If
    End Sub

    Private Sub GridDuration_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDuration.RowDoubleClick
        TxtOrdinance.Text = GridDuration.GetRow.Cells("DURATION").Value
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class