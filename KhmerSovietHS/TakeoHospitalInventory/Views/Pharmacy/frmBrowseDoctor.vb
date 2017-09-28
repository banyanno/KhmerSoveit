Imports Janus.Windows.GridEX

Public Class frmBrowseDoctor

    Dim DoctorDataAdapter As DSPharmacyTableAdapters.TblDoctorTableAdapter
    Public DoctorNo As Integer
    Public DoctorName As String
    Public DocSex As String

    Private Sub frmBrowseDoctor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gridDoctor.DataSource = DoctorDataAdapter.GetData
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        DoctorDataAdapter = New DSPharmacyTableAdapters.TblDoctorTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If Not gridDoctor.CurrentRow Is Nothing AndAlso gridDoctor.CurrentRow.RowType = RowType.Record Then
            DoctorNo = gridDoctor.GetValue("DoctorNo")
            DoctorName = gridDoctor.GetValue("DoctorName")
            DocSex = gridDoctor.GetValue("Sex")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Please select doctor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class