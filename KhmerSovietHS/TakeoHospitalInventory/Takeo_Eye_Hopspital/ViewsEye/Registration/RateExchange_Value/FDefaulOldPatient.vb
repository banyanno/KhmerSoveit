Public Class FDefaulOldPatient
    Dim DA_Val_Old As New DSDEFAULT_VAL_OLD_NEWTableAdapters.DEFAULT_VALUE_OLDTableAdapter
   
    Private Sub txtValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValue.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ValidateTextField(txtValue, "", ErrOld) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want set new value on old patient receipt?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If DA_Val_Old.InsertValOld(EmptyString(txtValue.Text), Now, True) = 1 Then
                    MessageBox.Show("Save new value successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    GetListOldValue()
                Else
                    MessageBox.Show("Error new value.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        Else
            If MessageBox.Show("Do you want set update value on old patient receipt?", "upate", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If DA_Val_Old.UpdateValOld(EmptyString(txtValue.Text), Now, True, LblSaveOption.Text) = 1 Then
                    MessageBox.Show("Update value successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    GetListOldValue()
                Else
                    MessageBox.Show("Error update value.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        End If
    End Sub

    Private Sub FDefaulOldPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetListOldValue()
    End Sub
    Sub GetListOldValue()
        GridValue.DataSource = DA_Val_Old.GetData
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

   
    Private Sub GridValue_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridValue.RowDoubleClick
        If GridValue.SelectedItems.Count = 0 Then Exit Sub
        LblSaveOption.Text = GridValue.GetRow.Cells("ValueID").Value
        txtValue.Text = GridValue.GetRow.Cells("DefaultValue").Value
    End Sub
End Class