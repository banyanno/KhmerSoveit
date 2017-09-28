Public Class frmLabourFactory
    Dim labourFacRepo As ILabourFactoryRepository = New LabourFactoryRepository
    Dim ULabour As UCLabourFactory
    Public isDoctorClose As Boolean = False
    Public labourID As Integer
    Dim isNewLabourFromItemForm As Boolean

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        isNewLabourFromItemForm = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal mainLab As UCLabourFactory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ULabour = mainLab
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim labourFac As New tblLabourFactory
        Dim labourFacTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtLabourFacName, "Labour Factory name", ErrorLabourFac) = False _
        Or ValidateTextField(txtEmail, "Email", ErrorLabourFac) = False _
        Or ValidateTextField(txtTelephone, "Telephone", ErrorLabourFac) = False Then
            Exit Sub
        End If

        If UCase(txtTempLabourName.Text) <> UCase(txtLabourFacName.Text) Then
            If labourFacRepo.isLabourFacExistSearchByLabourFacName(txtLabourFacName.Text) Then
                MsgBox("Labouratory name already exist.")
                Exit Sub
            End If
        End If
        '===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new labouratory ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                labourFac.LabourFacName = txtLabourFacName.Text
                labourFac.LabourPhone = txtTelephone.Text
                labourFac.LabourFacAddress = txtAddress.Text
                labourFac.LabourFacEmail = txtEmail.Text
                labourFac.LabourFacFax = txtFax.Text
                labourFac.LabourFacRegisterDate = System.DateTime.Today

                labourFacTransMsgStatus = labourFacRepo.CreateLabourFactory(labourFac)

                If labourFacTransMsgStatus <> "True" Then
                    MsgBox("Error save labour factory.", MsgBoxStyle.Critical, "Error : " & labourFacTransMsgStatus)
                Else
                    MessageBox.Show("Save new labouratory successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If isNewLabourFromItemForm = False Then
                        ULabour.FillDataByLabourName(txtLabourFacName.Text)
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK                        
                    End If
                End If
            End If
            
        Else ' Update vendor to database
            labourFacTransMsgStatus = labourFacRepo.UpdateLabourFactory        
            If labourID = 0 Then ' get item unit attempt to update
                MsgBox("Invalid labour ID.")
                Exit Sub
            End If

            If MessageBox.Show("Do you want save labouratory ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                labourFac = labourFacRepo.GetLabourFactoryByID(labourID)
                labourFac.LabourFacName = txtLabourFacName.Text
                labourFac.LabourFacAddress = txtAddress.Text
                labourFac.LabourFacEmail = txtEmail.Text
                labourFac.LabourPhone = txtTelephone.Text
                labourFac.LabourFacFax = txtFax.Text
                labourFacTransMsgStatus = labourFacRepo.UpdateLabourFactory

                If labourFacTransMsgStatus <> "True" Then
                    MsgBox("Error update labouratory.", MsgBoxStyle.Critical, "Error : " & labourFacTransMsgStatus)
                Else                    
                    ULabour.FillDataByLabourName(txtLabourFacName.Text)
                    Me.Close()
                End If

            End If        
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.isDoctorClose = False
        Me.Close()
    End Sub

    Private Sub frmLabourFactory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim labour As New tblLabourFactory
        If lblSaveOption.Text <> "0" Then
            labour = labourFacRepo.GetLabourFactoryByID(labourID)
            txtLabourFacName.Text = labour.LabourFacName
            txtAddress.Text = labour.LabourFacAddress
            txtEmail.Text = labour.LabourFacEmail
            txtTelephone.Text = labour.LabourPhone
            txtFax.Text = labour.LabourFacFax
            txtTempLabourName.Text = labour.LabourFacName
        End If
    End Sub

End Class