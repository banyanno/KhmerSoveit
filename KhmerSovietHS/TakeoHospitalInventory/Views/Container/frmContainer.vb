Public Class frmContainer
    Dim containerRepo As IContainerRepository = New ContainerRepository
    Dim UContainer As UCContainer
    Public containerID As Integer
    Dim isNewContainingFromItemForm As Boolean

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal mainContainter As UCContainer)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UContainer = mainContainter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        isNewContainingFromItemForm = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim container As New tblContainer
        Dim containerTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtContainerName, "Container name", ErrorContainer) = False Then
            Exit Sub
        End If

        If UCase(txtTempContainerName.Text) <> UCase(txtContainerName.Text) Then
            If containerRepo.isContainerExistSearchByContainerName(txtContainerName.Text) Then
                MsgBox("Container name already exist")
                Exit Sub
            End If
        End If

        '===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Container ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                container.ContainerName = txtContainerName.Text
                container.Description = rtbDescript.Text
                containerTransMsgStatus = containerRepo.CreateContainer(container)

                If containerTransMsgStatus <> "True" Then
                    MsgBox("Error save Container.", MsgBoxStyle.Critical, "Error : " & containerTransMsgStatus)
                Else

                    MessageBox.Show("Save new Container successful.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If isNewContainingFromItemForm = False Then
                        UContainer.FillDataByDepName(txtContainerName.Text)
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End If

            End If
        Else
            If containerID = 0 Then ' get item unit attempt to update
                MsgBox("Invalid Container ID.")
                Exit Sub
            End If

            If MessageBox.Show("Do you want save Container ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                container = containerRepo.GetContainerByID(containerID)
                container.ContainerName = txtContainerName.Text
                container.Description = rtbDescript.Text
                containerTransMsgStatus = containerRepo.UpdateContainer

                If containerTransMsgStatus <> "True" Then
                    MsgBox("Error update Container.", MsgBoxStyle.Critical, "Error : " & containerTransMsgStatus)
                Else
                    UContainer.FillDataByDepName(txtContainerName.Text)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        End If

    End Sub

    Private Sub frmContainer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim container As New tblContainer

        If lblSaveOption.Text <> "0" Then
            container = containerRepo.GetContainerByID(containerID)
            txtContainerID.Text = container.ContainerID
            txtContainerName.Text = container.ContainerName
            rtbDescript.Text = container.Description
            txtTempContainerName.Text = container.ContainerName
        Else ' Add new container
            txtContainerID.Text = containerRepo.GenerateContainerID
        End If
    End Sub

End Class