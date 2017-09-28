Public Class FormMoreMoPoTsyo
    Dim NumDiabete As String = "", NumDiagnosis As String = "", NumTypeOfDR As String = ""
    Dim PatientDataAdapter As New DSPharmacyTableAdapters.TblPatientsTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        BindNumber()
        If ValidateTextField(TxtPatientNo, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateDateTimePicker(DateExam, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateTextField(TxtMPCode, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateDateTimePicker(DateAppointment, "", ErrMoPoTyso) = False Then Exit Sub

        ''Check Debete
        'If NumDiabete = "" Then
        '    'MessageBox.Show("Pleas select diabete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    'GrpDiabete.BackColor = Color.AliceBlue
        '    'Exit Sub
        '    NumDiabete
        'Else
        '    GrpDiabete.BackColor = Color.Transparent
        'End If
        'If CheckStatusDiagnosis() = False Then
        '    MessageBox.Show("Pleas select Diagnosis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    GrpDiagnosis1.BackColor = Color.AliceBlue
        '    Exit Sub
        'Else
        '    GrpDiagnosis1.BackColor = Color.Transparent
        'End If

  
        'If NumTypeOfDR = 0 Then
        '    MessageBox.Show("Pleas select type of DR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    GrpTypeDR.BackColor = Color.AliceBlue
        '    Exit Sub
        'Else
        '    GrpTypeDR.BackColor = Color.Transparent
        'End If

        If ValidateTextField(TxtNewPatientReceipt, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateTextField(TxtOldPatientReceipt, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateTextField(TxtInPatientReceipt, "", ErrMoPoTyso) = False Then Exit Sub
        If ValidateTextField(TxtOPTPatientReceipt, "", ErrMoPoTyso) = False Then Exit Sub
        'If ValidateTextField(TxtTreatment, "", ErrMoPoTyso) = False Then Exit Sub


        If LblSaveOption.Text = "0" Then
            If CheckPatientNo() = False Then
                Exit Sub
            End If
            If MessageBox.Show("Do you want save new Mo.Po.Tyso's patient?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ModMoPoTsyo.SaveNewMoPoTsyo(TxtMPCode.Text, TxtPatientNo.Text, NumDiabete, GetCombindDiagnosis, ChDiagnosis1.Checked, ChDiagnosis2.Checked, ChDiagnosis3.Checked, _
                                               ChDiagnosis4.Checked, ChDiagnosis5.Checked, ChDiagnosis6.Checked, _
                                               NumTypeOfDR, TxtTreatment.Text, TxtNewPatientReceipt.Text, _
                                               TxtOldPatientReceipt.Text, TxtInPatientReceipt.Text, TxtOPTPatientReceipt.Text, _
                                               EmptyString(TxtTotalFee.Text), DateAppointment.Value) = 1 Then
                    MessageBox.Show("Save new Mo.Po.Tyso's patient successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save Mo.Po.Tyso's patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want update Mo.Po.Tyso's patient?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ModMoPoTsyo.UpdateMoPoTsyo(LblSaveOption.Text, TxtMPCode.Text, NumDiabete, GetCombindDiagnosis, _
                                              ChDiagnosis1.Checked, ChDiagnosis2.Checked, ChDiagnosis3.Checked, _
                                               ChDiagnosis4.Checked, ChDiagnosis5.Checked, ChDiagnosis6.Checked, _
                                              NumTypeOfDR, TxtTreatment.Text, TxtNewPatientReceipt.Text, TxtOldPatientReceipt.Text, _
                                              TxtInPatientReceipt.Text, TxtOPTPatientReceipt.Text, EmptyString(TxtTotalFee.Text), DateAppointment.Value) = 1 Then
                    MessageBox.Show("Update Mo.Po.Tyso's patient successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update Mo.Po.Tyso's patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Function ValueRadioOrder(ByVal gp As GroupBox) As String
        For I As Integer = 0 To gp.Controls.Count - 1
            Dim Obj As Object = gp.Controls(I)
            If TypeOf Obj Is RadioButton Then
                Dim rd As RadioButton = CType(Obj, RadioButton)
                If rd.Checked = True Then
                    Return rd.Tag
                End If
            End If
        Next
        Return ""
        'For Each obj As Object In gp.Controls
        '    Dim rd As RadioButton = CType(obj, RadioButton)
        '    If rd.Checked = True Then
        '        Return rd.TabIndex
        '        Exit For
        '    End If
        'Next

    End Function
    Sub BindNumber()
        NumDiabete = ValueRadioOrder(GrpDiabete)
        NumTypeOfDR = ValueRadioOrder(GrpTypeDR)
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

   
    Function CheckPatientNo() As Boolean
        Dim tblPatientTem As DataTable = GetPatientByNo(EmptyString(TxtPatientNo.Text))
        If tblPatientTem.Rows.Count > 0 Then
            For Each row As DataRow In tblPatientTem.Rows
                TxtPatientName.Text = row("NameKhmer")
                TxtAge.Text = row("Age")
                TxtSex.Text = row("Sex")
                TxtAddress.Text = row("Address")
                DateExam.Value = row("CreateDate")
            Next
            Return True
        Else
            MessageBox.Show("Patient do not have in system. Could you check patien no agian.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPatientNo.Focus()
            TxtPatientNo.Select()
            Return False
        End If
    End Function

    Function GetCombindDiagnosis() As String
        Try
            Dim str As String
            For i As Int16 = 0 To GrpDiagnosis1.Controls.Count - 1
                Dim ch As CheckBox = CType(GrpDiagnosis1.Controls(i), CheckBox)
                If ch.Checked = True Then
                    str = str & " , " & ch.Tag
                End If
            Next
            Return str.Substring(3)
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Sub TotalMoPoTsyoFee(ByVal NewReceipt As Double, ByVal OldReceipt As Double, ByVal InReceipt As Double, ByVal OPTReceipt As Double)
        TxtTotalFee.Text = NewReceipt + OldReceipt + InReceipt + OPTReceipt
    End Sub
    Function CheckStatusDiagnosis() As Boolean
        For Each obj As Object In GrpDiagnosis1.Controls
            If TypeOf obj Is CheckBox Then
                Dim rd As CheckBox = CType(obj, CheckBox)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function

 

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Dim TblTempPatient As DataTable = PatientDataAdapter.GetDataPatientByID(EmptyString(TxtPatientNo.Text))
        If TblTempPatient.Rows.Count < 1 Then
            MessageBox.Show("Can not find this pateint no. Could you check Pattient No again.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            For Each DRow As DataRow In TblTempPatient.Rows
                TxtPatientName.Text = DRow("NameKhmer")
                TxtAge.Text = DRow("Age")
                TxtSex.Text = DRow("Sex")
                TxtAddress.Text = DRow("Address")
            Next
        End If
    End Sub

    Private Sub BtnViewServiceFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewServiceFee.Click
        Dim FViewServiceFee As New FormViewServiceFee
        FViewServiceFee.TxtPatientNo.Text = Me.TxtPatientNo.Text
        FViewServiceFee.TxtPatientName.Text = Me.TxtPatientName.Text
        FViewServiceFee.TxtSex.Text = Me.TxtSex.Text
        FViewServiceFee.TxtAge.Text = Me.TxtAge.Text
        FViewServiceFee.Show()
    End Sub

    Private Sub TxtNewPatientReceipt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNewPatientReceipt.KeyPress
        SetDisableKeyString(e)

    End Sub

    Private Sub TxtInPatientReceipt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInPatientReceipt.KeyPress
        SetDisableKeyString(e)
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtOldPatientReceipt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOldPatientReceipt.KeyPress
        SetDisableKeyString(e)
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtOPTPatientReceipt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOPTPatientReceipt.KeyPress
        SetDisableKeyString(e)
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtNewPatientReceipt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNewPatientReceipt.KeyUp
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtInPatientReceipt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtInPatientReceipt.KeyUp
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtOldPatientReceipt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOldPatientReceipt.KeyUp
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    Private Sub TxtOPTPatientReceipt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOPTPatientReceipt.KeyUp
        TotalMoPoTsyoFee(EmptyString(TxtNewPatientReceipt.Text), EmptyString(TxtOldPatientReceipt.Text), EmptyString(TxtInPatientReceipt.Text), EmptyString(TxtOPTPatientReceipt.Text))
    End Sub

    
    Private Sub LblClearSelect1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblClearSelect1.LinkClicked
        For I As Integer = 0 To GrpDiabete.Controls.Count - 1
            Dim Obj As Object = GrpDiabete.Controls(I)
            If TypeOf Obj Is RadioButton Then
                Dim rd As RadioButton = CType(Obj, RadioButton)
                rd.Checked = False
            End If

        Next

    End Sub

    Private Sub LblClearSelect2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblClearSelect2.LinkClicked
        For I As Integer = 0 To GrpTypeDR.Controls.Count - 1
            Dim Obj As Object = GrpTypeDR.Controls(I)
            If TypeOf Obj Is RadioButton Then
                Dim rd As RadioButton = CType(Obj, RadioButton)
                rd.Checked = False
            End If
            
        Next
    End Sub
End Class