Public Class NewCashReceived
    Dim DA_OtherReceipt As New DSPatientReceiptTableAdapters.RECEIPT_OTHERSTableAdapter
    Dim DA_Client As New DSPatientReceiptTableAdapters.CASH_RECEIVED_CUSTOMERTableAdapter
    Dim DA_PatientReceipt As New DSPatientReceiptTableAdapters.tblPatientReceiptTableAdapter
    Dim Da_ReceiptNo As New DSPatientReceiptTableAdapters.RECEIPT_OTHERSTableAdapter
    Dim DA_Patient As New DSPatientReceiptTableAdapters.TblPatientsTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboReceivedFrom
            .DataSource = DA_Client.GetData
            .ValueMember = "CUS_RECEIVEDID"
            .DisplayMember = "CUS_NAME_ENG"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub NewCashReceived_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    '     If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
    '                    MsgBox("Duplicatate ID receipt. Please click to save agian.", MsgBoxStyle.Critical, "Error")
    '                    Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
    '                    Exit Sub
    'End If

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(txtReceiptNumber, "", ErrCashReceived) = False Then Exit Sub
        If ValidateDateTimePicker(DateReceiptIn, "", ErrCashReceived) = False Then Exit Sub
        If ValidateCombobox(CboReceivedFrom, "", ErrCashReceived) = False Then Exit Sub
        If ValidateTextField(TxtCashReceived, "", ErrCashReceived) = False Then Exit Sub
        If CheckEyeGlasses(G1) = False Then
            MessageBox.Show("Please select customer pay as ($ or R)", "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            G1.BackColor = Color.Khaki
            Exit Sub
        Else
            G1.BackColor = Color.Transparent
        End If

        BgSaveNewOtherReceipt.RunWorkerAsync()
    End Sub

    Function CheckEyeGlasses(ByVal GB As GroupBox) As Boolean
        For Each obj As Object In GB.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Sub SaveAndUpdateReceiptOther()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf SaveAndUpdateReceiptOther))
        Else
            If lblSaveOption.Text = "0" Then
                
                If MessageBox.Show("Do you want save new other receipt?", "Other Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    MainForm.StatusLoading(True)
                    Dim tblTem As DataTable = DA_Patient.FindPatientNo(EmptyString(TxtPatientNo.Text))
                    If tblTem.Rows.Count > 0 Then
                        For Each rows In tblTem.Rows
                            Dim tblCashRe As DataTable = DA_Client.SelectByName(rows("NameEng"))
                            If tblCashRe.Rows.Count > 0 Then
                                CboReceivedFrom.Text = rows("NameEng")
                                TxtPatientKHName.Text = rows("NameKhmer")
                            Else
                                DA_Client.InsertNewClient(rows("NameKhmer"), rows("NameEng"), rows("Sex"), rows("Age"), "Medical Certificate")
                                With CboReceivedFrom
                                    .DataSource = DA_Client.GetData
                                    .ValueMember = "CUS_RECEIVEDID"
                                    .DisplayMember = "CUS_NAME_ENG"
                                    .SelectedIndex = -1
                                End With
                                CboReceivedFrom.Text = rows("NameEng")
                                'TxtPatientKHName.Text = rows("NameKhmer")
                            End If
                        Next


                    End If
                    Application.DoEvents()
                    If MCashReceipt.CheckDuplicateReceiptNo(Me.txtReceiptNumber.Text, "tblPatientReceipt") = True Then
                        Me.txtReceiptNumber.Text = MCashReceipt.getMaxID()
                    End If
                    If DA_PatientReceipt.InsertNewPatientReceipt(txtReceiptNumber.Text, CboReceivedFrom.SelectedValue, CboReceivedFrom.Text, CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), 4000, USER_NAME, DateReceiptIn.Value.Date, 1, "0", GetDateServer.Year, 0, "OTR", 0) = 1 Then
                        DA_OtherReceipt.InsertNewReceiptOther(txtReceiptNumber.Text, DateReceiptIn.Value.Date, CboReceivedFrom.SelectedValue, CboReceivedFrom.Text, TxtReceivedNote.Text, CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CBool(IIf(RadDolar.Checked = True, True, False)), False, TxtPatientKHName.Text, txtAmountWord.Text)
                        Dim ROtherReceipt As New ReportOtherReceipt
                        Dim TblTemReceipt As DataTable = Da_ReceiptNo.SelectByReceiptNo(txtReceiptNumber.Text)
                        ROtherReceipt.SetDataSource(TblTemReceipt)
                        ROtherReceipt.PrintToPrinter(1, False, 1, 1)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Else
                If MessageBox.Show("Do you want update receipt?", "Other Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    MainForm.StatusLoading(True)
                    Dim tblTem As DataTable = DA_Patient.FindPatientNo(EmptyString(TxtPatientNo.Text))
                    If tblTem.Rows.Count > 0 Then
                        For Each rows In tblTem.Rows
                            Dim tblCashRe As DataTable = DA_Client.SelectByName(rows("NameEng"))
                            If tblCashRe.Rows.Count > 0 Then
                                CboReceivedFrom.Text = rows("NameEng")
                                TxtPatientKHName.Text = rows("NameKhmer")
                            Else
                                DA_Client.InsertNewClient(rows("NameKhmer"), rows("NameEng"), rows("Sex"), rows("Age"), "Medical Certificate")
                                With CboReceivedFrom
                                    .DataSource = DA_Client.GetData
                                    .ValueMember = "CUS_RECEIVEDID"
                                    .DisplayMember = "CUS_NAME_ENG"
                                    .SelectedIndex = -1
                                End With
                                CboReceivedFrom.Text = rows("NameEng")
                                'TxtPatientKHName.Text = rows("NameKhmer")
                            End If
                        Next


                    End If
                    Application.DoEvents()
                    If DA_OtherReceipt.UpdateReceiptOther(DateReceiptIn.Value.Date, CboReceivedFrom.SelectedValue, CboReceivedFrom.Text, TxtReceivedNote.Text, CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CBool(IIf(RadDolar.Checked = True, True, False)), TxtPatientKHName.Text, txtAmountWord.Text, lblSaveOption.Text) = 1 Then

                        'DA_PatientReceipt.InsertNewPatientReceipt(txtReceiptNumber.Text, CboReceivedFrom.SelectedValue, CboReceivedFrom.Text, CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), 4000, USER_NAME, DateReceiptIn.Value.Date, 1, "0", GetDateServer.Year, 0, "OTR", 0)
                        DA_PatientReceipt.UpdateOtherReceipt(CboReceivedFrom.SelectedValue, CboReceivedFrom.Text, CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadReil.Checked = True, TxtCashReceived.Text, 0)), CDbl(IIf(RadDolar.Checked = True, TxtCashReceived.Text, 0)), 4000, USER_NAME, USER_NAME, 1, DateReceiptIn.Value.Date, Now, Now, TxtCashReceived.Text, TxtCashReceived.Text, txtReceiptNumber.Text)
                        Dim ROtherReceipt As New ReportOtherReceipt
                        Dim TblTemReceipt As DataTable = Da_ReceiptNo.SelectByReceiptNo(txtReceiptNumber.Text)
                        ROtherReceipt.SetDataSource(TblTemReceipt)
                        ROtherReceipt.PrintToPrinter(1, False, 1, 1)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BgSaveNewOtherReceipt_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgSaveNewOtherReceipt.DoWork

        SaveAndUpdateReceiptOther()
    End Sub

    Private Sub BgSaveNewOtherReceipt_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgSaveNewOtherReceipt.RunWorkerCompleted
        MainForm.StatusLoading(False)
    End Sub

    Private Sub RadReil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReil.CheckedChanged
        TxtCashReceived.Select()
        TxtCashReceived.SelectAll()
        TxtCashReceived.Focus()
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        If Me.RadReil.Checked = True Then
            Me.txtAmountWord.Text = Riel.Convert(Me.TxtCashReceived.Text)
        ElseIf Me.RadDolar.Checked = True Then
            Me.txtAmountWord.Text = Dollar.Convert(Me.TxtCashReceived.Text)
        End If
    End Sub

    Private Sub RadDolar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDolar.CheckedChanged
        TxtCashReceived.Select()
        TxtCashReceived.SelectAll()
        TxtCashReceived.Focus()
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        If Me.RadReil.Checked = True Then
            Me.txtAmountWord.Text = Riel.Convert(Me.TxtCashReceived.Text)
        ElseIf Me.RadDolar.Checked = True Then
            Me.txtAmountWord.Text = Dollar.Convert(Me.TxtCashReceived.Text)
        End If
    End Sub

    Private Sub CboReceivedFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboReceivedFrom.SelectedIndexChanged
        Try
            Dim tblCostomer As DataTable = DA_Client.SelectClientID(CboReceivedFrom.SelectedValue)
            For Each row As DataRow In tblCostomer.Rows
                TxtReceivedNote.Text = row("DES_INFO")
                TxtPatientKHName.Text = row("CUS_NAME")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub TxtCashReceived_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCashReceived.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnFindPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPatient.Click
        Dim tblTem As DataTable = DA_Patient.FindPatientNo(EmptyString(TxtPatientNo.Text))
        If tblTem.Rows.Count <= 0 Then
            'MessageBox.Show("Patient No not found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboReceivedFrom.SelectedIndex = -1
            TxtPatientKHName.Text = ""
        Else
            For Each Rows As DataRow In tblTem.Rows
                Dim tblCashRe As DataTable = DA_Client.SelectByName(Rows("NameEng"))
                If tblCashRe.Rows.Count = 0 Then
                    CboReceivedFrom.Text = Rows("NameEng")
                    TxtPatientKHName.Text = Rows("NameKhmer")
                Else
                    'MessageBox.Show("Patient already add to client list!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CboReceivedFrom.Text = Rows("NameEng")
                End If


                '.Text = Rows("NameKhmer")
                'TxtCusNameEng.Text = Rows("NameEng")
                'TxtAge.Text = Rows("Age")
                'CboSex.Text = Rows("Sex")
            Next
        End If
    End Sub

    Private Sub ChPatient_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPatient.CheckedChanged
        TxtPatientNo.Enabled = ChPatient.Checked
        BtnFindPatient.Enabled = ChPatient.Checked
        CboReceivedFrom.SelectedIndex = -1
        If ChPatient.Checked = True Then
            CboReceivedFrom.Enabled = False
        Else
            CboReceivedFrom.Enabled = True
        End If
    End Sub

    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtCashReceived_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCashReceived.KeyUp
        Dim Riel As New riel()
        Dim Dollar As New dollar()
        If Me.RadReil.Checked = True Then
            Me.txtAmountWord.Text = Riel.Convert(Me.TxtCashReceived.Text)
        ElseIf Me.RadDolar.Checked = True Then
            Me.txtAmountWord.Text = Dollar.Convert(Me.TxtCashReceived.Text)
        End If
    End Sub
End Class