Imports Janus.Windows.GridEX

Public Class UCContainer

    Dim ContainerDataAdapter As DSContainerTableAdapters.tblContainerTableAdapter
    Dim containerRepo As IContainerRepository = New ContainerRepository


    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FContainer As New frmContainer(Me)
        FContainer.ShowDialog()
        FContainer.Close()
        FContainer.Dispose()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Not gridContainer.CurrentRow Is Nothing AndAlso gridContainer.CurrentRow.RowType = RowType.Record Then
            Dim FContainer As New frmContainer(Me)
            FContainer.lblSaveOption.Text = "1"
            FContainer.containerID = gridContainer.GetValue("ContainerID")
            FContainer.ShowDialog()
            FContainer.Close()
            FContainer.Dispose()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim container As New tblContainer
        Dim containerTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete container ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Not gridContainer.CurrentRow Is Nothing AndAlso gridContainer.CurrentRow.RowType = RowType.Record Then

                container = containerRepo.GetContainerByID(gridContainer.GetValue("ContainerID"))
                containerTransMsgStatus = containerRepo.DeleteContainer(container)

                If containerTransMsgStatus <> "True" Then
                    MsgBox("Error delete container.", MsgBoxStyle.Critical, "Error : " & containerTransMsgStatus)
                Else
                    MessageBox.Show("Delete container successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ContainerDataAdapter = New DSContainerTableAdapters.tblContainerTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub BindIntoDataGrid()
        gridContainer.DataSource = ContainerDataAdapter.GetData
    End Sub

    Private Sub UCContainer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' load department display in gridview
        BindIntoDataGrid()
    End Sub
    Public Sub FillDataByDepName(ByVal ContainerName As String)
        gridContainer.DataSource = ContainerDataAdapter.GetDataByContainerName(ContainerName)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gridContainer.DataSource = ContainerDataAdapter.GetDataBySearchContainerName("%" & txtSContainerName.Text & "%")
    End Sub
End Class
