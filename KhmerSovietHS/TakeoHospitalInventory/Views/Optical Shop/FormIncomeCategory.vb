Public Class FormIncomeCategory
    Private OpticalDataControl As IOpticalShop = New OpticalshopImp
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtIncomeType, "", ErrIncomeType) = False Then
            Exit Sub
        End If
        If MessageBox.Show("Do you want save new income type?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim IncomeTypeObj As New INCOME_TYPE
            IncomeTypeObj.ICType = TxtIncomeType.Text
            IncomeTypeObj.Description = TxtIncomeTypeDescription.Text
            If OpticalDataControl.SaveNewIncomeType(IncomeTypeObj) = True Then
                MessageBox.Show("Save new income type successful", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class