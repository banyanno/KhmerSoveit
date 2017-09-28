Public Class FrmEnterNewDialognosis
    Public saveSucc As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDiagnosis
            .DataSource = ModDiagnosis.SelectMainSurgery()
            .ValueMember = "Surgery"
            .SelectedValue = "SID"
            .SelectedIndex = -1
            .SelectAll()
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
   
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ModValidation.ValidateCombobox(CboDiagnosis, "diagnosis", ErrDiagnosis) = False Then
            Exit Sub
        Else
            If CboDiagnosis.Text.Trim <> "" Then
                If ModDiagnosis.CheckNameDiagnosis(CboDiagnosis.Text) = 0 Then
                    MsgBox("Daignosis not exist in system. could you contact system adiminstrator to create diagnosis name.", MsgBoxStyle.Critical, "Error")
                    CboDiagnosis.Focus()
                    CboDiagnosis.SelectAll()
                    Exit Sub
                End If
            End If
            DIALOG_SAVE = MessageBox.Show("Do you realy want enter this diagnosis?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModNew_Outpatient.EnterPatientDiagnosis(lblNewPatientNo.Text, CboDiagnosis.Text) = 1 Then
                    MsgBox("Enter diagnosis successful.", MsgBoxStyle.Information, "Save")
                    saveSucc = True
                    Me.Close()
                Else
                    MsgBox("Error enter diagnosis.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        saveSucc = False
        Me.Close()
    End Sub

 
End Class