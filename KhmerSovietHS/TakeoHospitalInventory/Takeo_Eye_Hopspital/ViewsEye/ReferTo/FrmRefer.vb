Public Class FrmRefer
    Public isClosed As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboRefer
            .DataSource = ModRefer.SelectRefer()
            .ValueMember = "ReferNo"
            .DisplayMember = "Refer"
            .SelectedIndex = -1
        End With
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

        If DateRefer.Checked = False Then
            MessageBox.Show("Please check date refer to other place.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateCombobox(CboRefer, "Refer To", ErrRefer) = False Then Exit Sub
        If ValidateCombobox(CboDiagnosis, "", ErrRefer) = False Then Exit Sub

        If LblSaveOption.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModRefer.InsertReferTo(DateRefer.Value, TxtPatientNo.Text, CboDiagnosis.Text.Trim, CboRefer.Text.Trim, TxtNote.Text.Trim) = 1 Then
                    MsgBox(MSG_SAVE_SUCCESS, MsgBoxStyle.Information, "Save")
                    isClosed = True
                    Me.Close()
                Else
                    MsgBox(MSG_SAVE_ERROR, MsgBoxStyle.Critical, "Error")
                    isClosed = False
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModRefer.UpdateReferto(LblSaveOption.Text, CboDiagnosis.Text.Trim, DateRefer.Value, CboRefer.Text, TxtNote.Text) = 1 Then
                    MsgBox(MSG_UPDATE_SUCCESS, MsgBoxStyle.Information, "Update")
                    isClosed = True
                    Me.Close()
                Else
                    MsgBox(MSG_UPDATE_ERROR, MsgBoxStyle.Critical, "Error")
                    isClosed = False
                End If
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

   
End Class