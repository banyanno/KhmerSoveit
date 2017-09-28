Public Class frmCabinet
    Dim UCabinet As UCCabinet
    Dim cabinetRepo As ICabinetRepository = New CabinetRepository
    Public myCabinetID As Integer

    Public Sub New(ByVal mainCabinet As UCCabinet)
        UCabinet = mainCabinet
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmCabinet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Add new cabinet
        If lblSaveOption.Text = "0" Then
            txtCabinetID.Text = cabinetRepo.GenerateCabinetID()
        Else ' Edit Cabinet
            Dim cabinet As New tblCabinet
            cabinet = cabinetRepo.GetCabinetByID(myCabinetID)
            txtCabinetID.Text = cabinet.CabinetID
            txtCabinetName.Text = cabinet.CabinetName
            txtTempCabinetName.Text = cabinet.CabinetName
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim myCabinet As New tblCabinet
        ' Validation
        If ValidateTextField(txtCabinetName, "", ErrorCabinet) = False Then
            Exit Sub
        End If

        If UCase(txtTempCabinetName.Text) <> UCase(txtCabinetName.Text) Then
            If cabinetRepo.isCabinetExistSearchByCabinetName(txtCabinetName.Text, CInt(DEPART_ID)) Then
                MsgBox("Cabinet name already exist.")
                Exit Sub
            End If
        End If        
        '===
        'Save new Cabinet
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Cabinet ?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                myCabinet.CabinetID = txtCabinetID.Text
                myCabinet.CabinetName = txtCabinetName.Text
                myCabinet.DepartID = CInt(DEPART_ID)
                cabinetRepo.CreateCabinet(myCabinet)
            End If
        Else ' Save update Cabinet
            If MessageBox.Show("Do you want save Cabinet ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                myCabinet = cabinetRepo.GetCabinetByID(myCabinetID)
                myCabinet.CabinetName = txtCabinetName.Text
                cabinetRepo.UpdateCabinet()
            End If        
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class