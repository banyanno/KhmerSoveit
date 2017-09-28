Public Class frmChemical
    Dim chemicalRepo As IChemicalRepository = New ChemicalRepository
    Dim UChemical As UCChemical
    Public chemicalID As Integer
    Dim isNewChemicalFromItemForm As Boolean



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        isNewChemicalFromItemForm = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmChemical_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim chemical As New tblChemical
        If lblSaveOption.Text <> "0" Then
            chemical = chemicalRepo.GetChemicalByID(chemicalID)
            txtChemicalID.Text = chemical.ChemicalID
            txtChemicalName.Text = chemical.ChemicalName
            rtbDescript.Text = chemical.Description
            txtTempChemicalName.Text = chemical.ChemicalName
        Else 'Add new chemical
            txtChemicalID.Text = chemicalRepo.GenerateChemicalID
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub New(ByVal mainChemical As UCChemical)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UChemical = mainChemical
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim chemical As New tblChemical
        Dim chemicalTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtChemicalName, "Chemical name", ErrorChemical) = False Then
            Exit Sub
        End If

        If UCase(txtTempChemicalName.Text) <> UCase(txtChemicalName.Text) Then
            If chemicalRepo.isChemicalExistSearchByChemicalName(txtChemicalName.Text) Then
                MsgBox("Chemical name already exist.")
                Exit Sub
            End If
        End If
        '==

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new chemical ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                chemical.ChemicalName = txtChemicalName.Text
                chemical.Description = rtbDescript.Text
                chemicalTransMsgStatus = chemicalRepo.CreateChemical(chemical)

                If chemicalTransMsgStatus <> "True" Then
                    MsgBox("Error save chemical.", MsgBoxStyle.Critical, "Error : " & chemicalTransMsgStatus)

                Else

                    MessageBox.Show("Save new chemical successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If isNewChemicalFromItemForm = False Then
                        UChemical.FillDataByDepName(txtChemicalName.Text)
                        Me.Close()
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If

            End If
        Else
            If chemicalID = 0 Then ' get item unit attempt to update
                MsgBox("Invalid Chemical ID.")
                Exit Sub
            End If

            If MessageBox.Show("Do you want save chemical ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                chemical = chemicalRepo.GetChemicalByID(chemicalID)
                chemical.ChemicalName = txtChemicalName.Text
                chemical.Description = rtbDescript.Text
                chemicalTransMsgStatus = chemicalRepo.UpdateChemical

                If chemicalTransMsgStatus <> "True" Then
                    MsgBox("Error update chemical.", MsgBoxStyle.Critical, "Error : " & chemicalTransMsgStatus)
                Else
                    UChemical.FillDataByDepName(txtChemicalName.Text)
                    Me.Close()
                End If
            End If

        End If

    End Sub


End Class