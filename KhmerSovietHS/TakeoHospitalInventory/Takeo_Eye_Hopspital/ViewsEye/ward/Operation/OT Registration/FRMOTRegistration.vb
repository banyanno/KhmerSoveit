Imports System.Data.Common
Public Class FRMOTRegistration
    Public isCloseOT As Boolean = False
    Dim ItemListInDepartDataAdapter As New DSCategoriesAndItemsTableAdapters.VItemListInDepartTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            With CboSurgeon
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With TxtCirculation
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAssistant
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAnesthetist
                .DataSource = ModDoctor.SelectDoctor
                .DisplayMember = "DoctorName"
                .ValueMember = "DoctorNo"
                .Text = Nothing
            End With
            With CboOperationType
                .DataSource = ModSurgeries.SelectSurgeries()
                .DisplayMember = "Surgeries"
                .ValueMember = "SID"
                .Text = Nothing
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
    Private Function CheckCurrentStockIOL(ByVal itemID As Integer) As Integer
        Dim tblIOL As DataTable = ItemListInDepartDataAdapter.GetItemDataInDepartByItemID(13, itemID)
        If tblIOL.Rows.Count = 0 Then
            Return 0
        Else
            For Each rows As DataRow In tblIOL.Rows
                Return rows("UnitsInStock")
            Next
        End If
    End Function
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim IOL As String = ""
        Dim OTSurgeryOther As String
        Dim OTTime As String
        Dim DOperated As String
        Dim WaitingOT As Integer
        If ValidateDateTimePicker(DateOT, "Please select date opteration", ErrOT) = False Then
            Exit Sub
        End If

        If ValidateDateTimePicker(CboOperationTime, "Time operation", ErrOT) = False Then
            Exit Sub
        End If
        If ValidateCombobox(CboOperationType, "operation type", ErrOT) = False Then
            Exit Sub
        End If
        If ChPrepareOT.Checked = True Then
            WaitingOT = 2
        Else
            WaitingOT = 1
        End If
        If CboIOLItem.Text.Trim <> "" Then
            IOL = CboIOLItem.Text.Trim
        Else
            IOL = ""
        End If
        If CboOperationTime.Checked = True Then
            OTTime = "'" & CboOperationTime.Text & "'"
        Else
            OTTime = "NULL"
        End If
        If DateOperated.Checked = True Then
            DOperated = "'" & DateOperated.Value.Date & "'"
        Else
            DOperated = "NULL"
        End If
        
        If ModSurgeries.CheckSurgeries(CboOperationType.Text) = 0 Then
            MsgBox("Surgery not exist in system. could you contact system adiminstrator to create surgery name.", MsgBoxStyle.Critical, "Error")
            CboOperationType.Focus()
            CboOperationType.SelectAll()
            Exit Sub
        End If


        If ChOT.Checked = True Then
            OTSurgeryOther = "Others"
        Else
            OTSurgeryOther = CboOperationType.Text
        End If

        If CboIOLItem.Text.Trim = "" Then
        Else
            If ModNewInPatient.CheckIOLExist(CboIOLItem.SelectedValue, CboIOLItem.Text) = False Then
                MsgBox("IOL not exist in system. Could you check again.", MsgBoxStyle.Critical, "Error")
                CboIOLItem.Focus()
                CboIOLItem.SelectAll()
                Exit Sub
            End If
            'If CheckCurrentStockIOL(CboIOLItem.SelectedValue) = 0 Then
            '    MsgBox("IOL out of stock in system. Could you check again.", MsgBoxStyle.Critical, "Error")
            '    CboIOLItem.Focus()
            '    CboIOLItem.SelectAll()
            '    Exit Sub
            'End If
        End If
        If LblSaveOption.Text = "0" Then
            
            DIALOG_SAVE = MessageBox.Show(MSG_SAVE, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_SAVE = Windows.Forms.DialogResult.Yes Then
                'If ModOTRegistration.CheckExistingOTR(TxtInpatientNo.Text) = True Then
                '    MsgBox("This patient waiting operation. Could you select other patient.", MsgBoxStyle.Critical, "Error")
                '    Exit Sub
                'End If
                If ModOTRegistration.SaveNewOTRegist(TxtInpatientNo.Text, _
                TxtPatientNo.Text, _
                OTTime, _
                TxtAnesthesia.Text, _
                CboAnesthetist.Text, _
                CboEye.Text, _
                CboOperationType.Text, _
                OTSurgeryOther, CInt(CboIOLItem.SelectedValue), CInt(CboIOLItem.SelectedValue), CboIOLItem.Text, _
                CboSurgeon.Text, _
                CboAssistant.Text, _
                TxtCirculation.Text, _
                TxtCompli.Text, _
                ChOT.Checked, _
                DateOT.Value.Date, _
                DateOT.Value.Date, _
                TxtOther.Text) = 1 Then
                    If ModNewInPatient.UpdateOTWating(TxtInpatientNo.Text, WaitingOT) = 1 Then
                        ModNewInPatient.UpdateOTHistory(TxtInpatientNo.Text, WaitingOT, Now.Date)
                        MsgBox("Save Registration in OT successfully.", MsgBoxStyle.Information, "Save")
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        isCloseOT = True
                        Me.Close()
                    End If

                Else
                    MsgBox("Error save registration in OT.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            DIALOG_UPDATE = MessageBox.Show(MSG_UPDATE, "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DIALOG_UPDATE = Windows.Forms.DialogResult.Yes Then
                If IOL.Trim = "".Trim Then
                    lblIOLIDOLD.Text = "0"
                End If
                If ModOTRegistration.UpdateOTRegistration(LblSaveOption.Text, _
                TxtInpatientNo.Text, _
                TxtPatientNo.Text, _
                OTTime, _
                TxtAnesthesia.Text, _
                CboAnesthetist.Text, _
                CboEye.Text, _
                CboOperationType.Text, _
                OTSurgeryOther, _
                CboIOLItem.SelectedValue, lblIOLIDOLD.Text, _
                CboIOLItem.Text, _
                CboSurgeon.Text, _
                CboAssistant.Text, _
                TxtCirculation.Text, _
                ChOT.Checked, _
                TxtCompli.Text, _
                DateOT.Value.Date, _
                TxtOther.Text, "Edited by " & USER_NAME & " at " & Now) = 1 Then
                    MsgBox("Update registration in OT successfully.", MsgBoxStyle.Information, "Update")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    isCloseOT = True
                    Me.Close()
                Else
                    MsgBox("Error update registration in OT.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        isCloseOT = False
        Me.Close()
    End Sub


    Private Sub txtExamNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInpatientNo.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub txtExamNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtInpatientNo.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtPatientName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientName.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtPatientName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientName.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAge_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAge.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtSex_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSex.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtSex_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSex.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAddress.KeyPress
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtDiagnosis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub TxtDiagnosis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtVARE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub TxtVARE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ModCommon.SetDisableKey(e)
    End Sub

    Private Sub txtVALE_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        ModCommon.SetDisableKeyDelete(e)
    End Sub

    Private Sub txtVALE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ModCommon.SetDisableKey(e)
    End Sub


    Private Sub DateOT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateOT.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboOperationTime.Focus()
        End If
    End Sub

    Private Sub CboOperationTime_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboOperationTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAnesthesia.Focus()
        End If
    End Sub

    Private Sub CboAnesthetist_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboAnesthetist.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboEye.Focus()
        End If
    End Sub

    Private Sub TxtAnesthesia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAnesthesia.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboAnesthetist.Focus()
        End If
    End Sub

    Private Sub CboEye_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboEye.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboOperationType.Focus()
        End If
    End Sub

    Private Sub CboOperationType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboOperationType.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboIOLItem.Focus()
        End If
    End Sub

    Private Sub TxtIOl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CboSurgeon.Focus()
        End If
    End Sub

    Private Sub CboSurgeon_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboSurgeon.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboAssistant.Focus()
        End If
    End Sub

    Private Sub CboAssistant_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboAssistant.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCirculation.Focus()
        End If
    End Sub

    Private Sub TxtCirculation_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCirculation.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCompli.Focus()
        End If
    End Sub

    Private Sub TxtCompli_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompli.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.Focus()
        End If
    End Sub


   
    Private Sub FRMOTRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class