Public Class NewCustomer
    Dim DAProvince As New DSCustomerTableAdapters.tblProvincesTableAdapter
    Dim DADistrict As New DSCustomerTableAdapters.tblDistrictsTableAdapter
    Dim DACommune As New DSCustomerTableAdapters.tblCommunesTableAdapter
    Dim DAVillage As New DSCustomerTableAdapters.tblVillagesTableAdapter
    Dim DAOccupation As New DSCustomerTableAdapters.TblOccupationTableAdapter
    Dim P_Customer As New OpticalshopImp
    Public CutomereID As Double = 0
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitProvince()
        InitOccupation()
    End Sub
    Private Sub InitOccupation()
        With CboOccupation
            .DataSource = DAOccupation.GetData
            .DisplayMember = "Occupation"
            .ValueMember = "OccNo"
            .SelectedIndex = -1
        End With
    End Sub
    Sub InitProvince()
        With CboProvince
            .DataSource = DAProvince.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
            .SelectedIndex = -1
        End With
    End Sub
    Sub InitDistrict(ByVal ProvincID As String)
        With CboDistrict
            .DataSource = DADistrict.GetDataByProID(ProvincID)
            .ValueMember = "SrokCode"
            .DisplayMember = "DISTRICT"
            .SelectedIndex = -1
        End With
    End Sub
    Sub InitCommune(ByVal DistrictID As String)
        With CboCommune
            .DataSource = DACommune.GetDataByDistrictID(DistrictID)
            .ValueMember = "KhumCode"
            .DisplayMember = "Commune"
            .SelectedIndex = -1
        End With
    End Sub
    Sub InitVillage(ByVal CommuneID As String)
        With CboVillage
            .DataSource = DAVillage.GetDataByCommuneID(CommuneID)
            .ValueMember = "PhumCode"
            .DisplayMember = "VILLAGE"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(TxtCusNo, "", ErrCustomer) = False Then Exit Sub
        If ValidateTextField(TxtCusName, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboSex, "", ErrCustomer) = False Then Exit Sub
        If ValidateTextField(TxtAge, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboOccupation, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboProvince, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboDistrict, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboCommune, "", ErrCustomer) = False Then Exit Sub
        If ValidateCombobox(CboVillage, "", ErrCustomer) = False Then Exit Sub
        If MessageBox.Show("Do you want to save new customer?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim Re_Customer As New RECEIPT_CUSTOMER
            Re_Customer.CustomerNo = TxtCusNo.Text
            Re_Customer.CusName = TxtCusName.Text
            Re_Customer.CusNameEng = TxtCusNameEng.Text
            Re_Customer.Sex = CboSex.Text
            Re_Customer.Age = TxtAge.Text
            Re_Customer.OccNo = CInt(CboOccupation.SelectedValue)
            Re_Customer.Occupation = CboOccupation.Text
            Re_Customer.Province = CInt(CboProvince.SelectedValue)
            Re_Customer.District = CInt(CboDistrict.SelectedValue)
            Re_Customer.Commune = CInt(CboCommune.SelectedValue)
            Re_Customer.Village = CInt(CboVillage.SelectedValue)
            Re_Customer.Address = TxtAddress.Text
            Re_Customer.IsPatient = False
            '--- For Optical shop customer statistic report purpose
            If CboSex.Text = "F" Then
                Re_Customer.Female = "F"
            Else
                Re_Customer.Male = "M"
            End If

            Dim status = P_Customer.SaveNewCustomer(Re_Customer)
            If status Then
                MessageBox.Show("Save new customer successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CutomereID = status
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub CboProvince_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboProvince.DropDown
        InitProvince()
    End Sub

    Private Sub CboDistrict_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDistrict.DropDown
        InitDistrict(CboProvince.SelectedValue)
    End Sub

    Private Sub CboCommune_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCommune.DropDown
        InitCommune(CboDistrict.SelectedValue)
    End Sub

    Private Sub CboVillage_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboVillage.DropDown
        InitVillage(CboCommune.SelectedValue)
    End Sub

    Private Sub NewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtCusNo.Text = P_Customer.GetMaxCustomerID()
    End Sub

   
    Private Sub TxtAge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAge.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub CboVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboVillage.SelectedIndexChanged
        GenerateAddres()
    End Sub
    Sub GenerateAddres()
        TxtAddress.Text = "Province:" & CboProvince.Text & " District:" & CboDistrict.Text & " commune:" & CboCommune.Text & " Village:" & CboVillage.Text
    End Sub
End Class