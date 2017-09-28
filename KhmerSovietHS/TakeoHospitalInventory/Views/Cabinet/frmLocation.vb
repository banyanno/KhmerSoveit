Public Class frmLocation
    Dim UCabinet As UCCabinet
    Dim cabinetRepo As ICabinetRepository = New CabinetRepository
    Public myCabinetID As Integer
    Public myLocationID As Integer

    Public Sub New(ByVal mainCabinet As UCCabinet)

        ' This call is required by the Windows Form Designer.
        UCabinet = mainCabinet
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmLocation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Add new cabinet
        If lblSaveOption.Text = "0" Then
            txtLocationID.Text = cabinetRepo.GenerateLocationID
            lblCabinetName.Text = cabinetRepo.GetCabinetNameByID(myCabinetID)

        Else ' Edit Cabinet
            Dim loca As New tblCabinetLocation
            lblCabinetName.Text = cabinetRepo.GetCabinetNameByID(myCabinetID)
            loca = cabinetRepo.GetLocationByID(myLocationID)
            txtLocationID.Text = loca.LocationID
            txtLocationName.Text = loca.LocationName
            txtShelfNum.Text = loca.ShelfNum
            txtBlockNum.Text = loca.BlockNum
            txtTempLocationName.Text = loca.LocationName

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim myLocation As New tblCabinetLocation

        ' Validation
        If ValidateTextField(txtShelfNum, "", ErrorLocation) = False _
        Or ValidateTextField(txtBlockNum, "", ErrorLocation) = False Then
            Exit Sub
        End If

        If UCase(txtTempLocationName.Text) <> UCase(txtLocationName.Text) Then
            If cabinetRepo.isLocationExistSearchByLocationName(txtLocationName.Text, myCabinetID) Then ' TODO : change it(17) to dynamic value depend on user log in
                MsgBox("Location name already exist in Cabinet.")
                Exit Sub
            End If
        End If

        '===
        'Save new Cabinet
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Location ?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                myLocation.LocationID = txtLocationID.Text
                myLocation.LocationName = txtLocationName.Text
                myLocation.ShelfNum = txtShelfNum.Text
                myLocation.BlockNum = txtBlockNum.Text
                myLocation.CabinetID = myCabinetID
                cabinetRepo.CreateLocation(myLocation)
            End If
        Else ' Save update Cabinet

            If MessageBox.Show("Do you want save Location ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                myLocation = cabinetRepo.GetLocationByID(myLocationID)
                myLocation.LocationID = txtLocationID.Text
                myLocation.LocationName = txtLocationName.Text
                myLocation.ShelfNum = txtShelfNum.Text
                myLocation.BlockNum = txtBlockNum.Text
                myLocation.CabinetID = myCabinetID                
                cabinetRepo.Update()
            End If

            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub txtShelfNum_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShelfNum.Leave
        txtLocationName.Text = lblCabinetName.Text & txtShelfNum.Text & txtBlockNum.Text ' "L" & txtShelfNum.Text & txtBlockNum.Text

    End Sub

    Private Sub txtBlockNum_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBlockNum.Leave
        txtLocationName.Text = lblCabinetName.Text & txtShelfNum.Text & txtBlockNum.Text '"L" & txtShelfNum.Text & txtBlockNum.Text
    End Sub
End Class