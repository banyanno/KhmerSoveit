Imports Janus.Windows.GridEX

Public Class frmBrowsePatient

    Dim PatientDataAdapter As DSPharmacyTableAdapters.TblPatientsTableAdapter
    Public PatientNo As Double
    Public PatientName As String
    Public PatientOccupa As String
    Public PatientSex As String
    Public PatientAge As String
    Public PatientAddr As String
    Private Sub frmBrowsePatient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PatientDataAdapter = New DSPharmacyTableAdapters.TblPatientsTableAdapter        
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        If Not gridPatient.CurrentRow Is Nothing AndAlso gridPatient.CurrentRow.RowType = RowType.Record Then
            PatientNo = gridPatient.GetValue("PatientNo")
            PatientName = gridPatient.GetValue("NameEng")
            PatientOccupa = gridPatient.GetValue("Occupation")
            PatientSex = gridPatient.GetValue("Sex")
            PatientAge = gridPatient.GetValue("Age")
            PatientAddr = gridPatient.GetValue("Address")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Please select patient.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Me.ContainerBrowsePatient.Visible = True
        Application.DoEvents()
        BackgroundWorkerPatient.RunWorkerAsync()
    End Sub

    Private Sub FindPatient()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf FindPatient))
        Else
            'gridPatient.DataSource = PatientDataAdapter.GetDataByPatientName("%" & TxtPatientName.Text & "%")
            gridPatient.DataSource = PatientDataAdapter.GetDataPatientByID(EmptyString(TxtPatientName.Text))
        End If

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BackgroundWorkerPatient_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerPatient.DoWork
        FindPatient()
    End Sub

    Private Sub BackgroundWorkerPatient_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerPatient.RunWorkerCompleted
        Application.DoEvents()
        Me.ContainerBrowsePatient.Visible = False
    End Sub

    Private Sub TxtPatientName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPatientName.KeyPress
        SetDisableKeyString(e)
    End Sub
End Class