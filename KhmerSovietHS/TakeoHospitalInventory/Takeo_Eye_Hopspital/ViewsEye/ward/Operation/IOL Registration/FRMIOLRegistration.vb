Public Class FRMIOLRegistration
    Public isClose As Boolean = False
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboSurgeon
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .SelectedIndex = -1
            End With

            With CboIOLItem
                .DataSource = ItemListInDepartDataAdapter.GetItemDataByDepartID(CInt(13))
                .ValueMember = "ItemID"
                .DisplayMember = "ItemName"
                .SelectedIndex = -1
            End With
        Catch ex As Exception

        End Try
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If DateIOL.Checked = False Then
            MessageBox.Show("Please check date IOL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ValidateTextField(txtPatientNo, "Patient No", ErrIOL) = False Then Exit Sub
        If ValidateCombobox(CboSurgeon, "Surgeon", ErrIOL) = False Then Exit Sub
        If ValidateCombobox(CboEye, "Eye", ErrIOL) = False Then Exit Sub
        If ValidateCombobox(CboIOLItem, "IOL Number", ErrIOL) = False Then Exit Sub

       
        If CboIOLItem.Text.Trim = "" Then
        Else
            If ModNewInPatient.CheckIOLExist(CboIOLItem.SelectedValue, CboIOLItem.Text) = False Then
                MsgBox("IOL not exist in system. Could you check again.", MsgBoxStyle.Critical, "Error")
                CboIOLItem.Focus()
                CboIOLItem.SelectAll()
                Exit Sub
            End If
        End If
        If LblOptionSave.Text = "0" Then
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                If ModIOLRegistration.CheckSaveIOL(LblOTNo.Text) = True Then
                    MsgBox("IOL registration have already.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                If ModIOLRegistration.SaveNewIOL(LblOTNo.Text, txtPatientNo.Text, CboSurgeon.Text, CboEye.Text, CboIOLItem.Text, DateIOL.Value) = 1 Then
                    MsgBox("IOL registration successfully.", MsgBoxStyle.Information, "Save")
                    isClose = True
                    Me.Close()
                Else
                    MsgBox("IOL Registration Error", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            If DateIOL.Checked = False Then
                MessageBox.Show("Please check date IOL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If ModIOLRegistration.UpdateIOL(LblOptionSave.Text, CboSurgeon.Text, CboEye.Text, CboIOLItem.Text, DateIOL.Value) = 1 Then
                    MsgBox("Update IOL registration successfully.", MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    isClose = True
                    Me.Close()
                Else
                    MsgBox("Error update IOL registration.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isClose = False
        Me.Close()
    End Sub

    Private Sub txtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPatientNo.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub txtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPatientNo.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtName.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtName.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAge_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAge.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtSex_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSex.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtSex_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSex.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    'Private Sub CboSurgeon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboSurgeon.KeyPress
    '    e.Handled = True
    'End Sub

    Private Sub CboSurgeon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSurgeon.KeyDown
        'ModCommon.SetDisableKeyDelete(e)
    End Sub

   
  
    Private Sub FRMIOLRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class