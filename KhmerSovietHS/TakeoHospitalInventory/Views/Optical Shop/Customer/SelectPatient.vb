Public Class SelectPatient

    Dim DAPatient As New DSCustomerTableAdapters.TblPatientsTableAdapter
    Dim DAReceiptCustomer As New DSCustomerTableAdapters.RECEIPT_CUSTOMERTableAdapter
    Public PatientOption As Integer


    Private Sub TxtPatientNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientNo.KeyPress
        SetDisableKeyString(e)
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click

        Me.ContainerControlCommand1.Visible = True
        Application.DoEvents()
        BackgroundWorkerPatient.RunWorkerAsync()

    End Sub

    Private Sub FindPatientInfo()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf FindPatientInfo))
        Else
            If ValidateTextField(TxtPatientNo, "", ErrFind) = False Then Exit Sub
            If PatientOption = 1 Then '--- Optical Shop Invoice
                If CheckExistingInCustomerList(TxtPatientNo.Text) > 0 Then
                    MessageBox.Show("The patient already add to optical shop's customer.", "Please go to select in customer list.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(TxtPatientNo.Text)
                End If
            Else '--- NIL
                GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(TxtPatientNo.Text)
            End If
        End If

    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Function CheckExistingInCustomerList(ByVal PatientNo As String) As Integer
        Return DAReceiptCustomer.GetDataByCustomerNo(PatientNo).Count
    End Function
    Private Sub GridPatientInformation_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPatientInformation.RowDoubleClick
        If GridPatientInformation.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub TxtPatientNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPatientNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidateTextField(TxtPatientNo, "", ErrFind) = False Then Exit Sub
            GridPatientInformation.DataSource = DAPatient.GetDataByPatientNo(TxtPatientNo.Text)
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorkerPatient_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerPatient.DoWork
        FindPatientInfo()
    End Sub

    Private Sub BackgroundWorkerPatient_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerPatient.RunWorkerCompleted
        Application.DoEvents()
        Me.ContainerControlCommand1.Visible = False
    End Sub

    Private Sub SelectPatient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ContainerControlCommand1.Visible = False
    End Sub

End Class