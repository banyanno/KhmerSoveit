Imports Janus.Windows.GridEX

Public Class UCChemical

    Dim ChemicalDataAdapter As DSChemicalTableAdapters.tblChemicalTableAdapter
    Dim chemicalRepo As IChemicalRepository = New ChemicalRepository

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FChemical As New frmChemical(Me)
        FChemical.ShowDialog()
        FChemical.Close()
        FChemical.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not gridChemical.CurrentRow Is Nothing AndAlso gridChemical.CurrentRow.RowType = RowType.Record Then
            Dim FChemical As New frmChemical(Me)
            FChemical.lblSaveOption.Text = "1"
            FChemical.chemicalID = gridChemical.GetValue("ChemicalID")
            FChemical.ShowDialog()
            FChemical.Close()
            FChemical.Dispose()            
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim chemical As New tblChemical
        Dim chemicalTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete chemical ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            If Not gridChemical.CurrentRow Is Nothing AndAlso gridChemical.CurrentRow.RowType = RowType.Record Then

                chemical = chemicalRepo.GetChemicalByID(gridChemical.GetValue("ChemicalID"))
                chemicalTransMsgStatus = chemicalRepo.DeleteChemical(chemical)

                If chemicalTransMsgStatus <> "True" Then
                    MsgBox("Error delete chemical.", MsgBoxStyle.Critical, "Error : " & chemicalTransMsgStatus)
                Else
                    MessageBox.Show("Delete chemical successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub UCChemical_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindIntoDataGrid()
    End Sub
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ChemicalDataAdapter = New DSChemicalTableAdapters.tblChemicalTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub BindIntoDataGrid()
        gridChemical.DataSource = ChemicalDataAdapter.GetData
    End Sub
    Public Sub FillDataByDepName(ByVal ChemicalName As String)
        gridChemical.DataSource = ChemicalDataAdapter.GetDataByChemicalName(ChemicalName)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gridChemical.DataSource = ChemicalDataAdapter.GetDataBySearchItemName("%" & txtSChemicalName.Text & "%")
    End Sub
End Class
