Imports Janus.Windows.GridEX

Public Class UCLabourFactory
    Dim LabourDataAdapter As DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
    Dim labourRepo As ILabourFactoryRepository = New LabourFactoryRepository

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        LabourDataAdapter = New DSLabourFacTableAdapters.tblLabourFactoryTableAdapter
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub BindIntoDataGrid()
        gridLabouratory.DataSource = LabourDataAdapter.GetData
    End Sub
    Public Sub FillDataByLabourName(ByVal LabourName As String)
        gridLabouratory.DataSource = LabourDataAdapter.GetDataByLabourName(LabourName)
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click

        Dim FLabour As New frmLabourFactory(Me)
        FLabour.ShowDialog()
        FLabour.Close()
        FLabour.Dispose()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If Not gridLabouratory.CurrentRow Is Nothing AndAlso gridLabouratory.CurrentRow.RowType = RowType.Record Then
            Dim FLabour As New frmLabourFactory(Me)
            FLabour.lblSaveOption.Text = "1"
            FLabour.labourID = gridLabouratory.GetValue("LabourFacID")
            FLabour.ShowDialog()
            FLabour.Close()
            FLabour.Dispose()
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim labour As New tblLabourFactory
        Dim labourTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete labouratory ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not gridLabouratory.CurrentRow Is Nothing AndAlso gridLabouratory.CurrentRow.RowType = RowType.Record Then
                labour = labourRepo.GetLabourFactoryByID(gridLabouratory.GetValue("LabourFacID"))
                labourTransMsgStatus = labourRepo.DeleteLabourFactory(labour)

                If labourTransMsgStatus <> "True" Then
                    MsgBox("Error delete labouratory.", MsgBoxStyle.Critical, "Error : " & labourTransMsgStatus)
                Else
                    MessageBox.Show("Delete labouratory successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BindIntoDataGrid()
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        BindIntoDataGrid()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UCLabourFactory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindIntoDataGrid()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gridLabouratory.DataSource = LabourDataAdapter.GetDataBySearchLaboName("%" & txtSLabour.Text & "%")
    End Sub
End Class
