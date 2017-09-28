Public Class frmVender
    Dim vendorRepo As IVendorRepository = New VendorRepository
    Public isDoctorClose As Boolean = False
    Dim UVendor As UCVendor
    Dim UVendor_V1 As UCVendor_V1
    Public venderID As Integer
    Public isDonator As Boolean
    Public isVendor As Boolean

    Public Sub New(ByVal mainVendor As UCVendor_V1)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UVendor_V1 = mainVendor
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmVender_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim vendor As New tblVender
        If lblSaveOption.Text <> "0" Then
            vendor = vendorRepo.GetVenderByID(venderID)
            txtVendorName.Text = vendor.VenderName
            txtPhone.Text = vendor.VenderPhone
            txtFax.Text = vendor.VenderFax
            txtEmail.Text = vendor.VenderEmail
            rtbAddress.Text = vendor.VenderAddress            
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click


        Dim vendorTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtVendorName, "Vendor name", ErrorVendor) = False Then
            Exit Sub
        End If

        If lblSaveOption.Text = "0" Then
            If vendorRepo.isVendorExistSearchByVendorName(txtVendorName.Text) Then
                MsgBox("Vendor name already exist.")
                Exit Sub
            End If
        Else
            If TxtTempProviderName.Text <> txtVendorName.Text Then
                If vendorRepo.isVendorExistSearchByVendorName(txtVendorName.Text) Then
                    MsgBox("Vendor name already exist.")
                    Exit Sub
                End If
            End If
        End If
        
        '===

        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Vendor ?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim vendor As New tblVender
                vendor.VenderName = txtVendorName.Text
                vendor.VenderPhone = txtPhone.Text
                vendor.VenderEmail = txtEmail.Text
                vendor.VenderFax = txtFax.Text
                vendor.Website = txtWebsite.Text
                vendor.VenderAddress = rtbAddress.Text
                vendor.IsDonator = isDonator
                vendor.IsVendor = isVendor
                vendor.IsMarkDelete = False
                vendorTransMsgStatus = vendorRepo.CreateVender(vendor)

                If vendorTransMsgStatus <> "True" Then
                    MsgBox("Error save Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
                Else
                    MessageBox.Show("Save new successfully.", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        Else ' Update item unit to database

            Dim vendor As tblVender = vendorRepo.GetVenderByID(venderID)
            vendor.VenderName = txtVendorName.Text
            vendor.VenderPhone = txtPhone.Text
            vendor.VenderEmail = txtEmail.Text
            vendor.VenderFax = txtFax.Text
            vendor.Website = txtWebsite.Text
            vendor.VenderAddress = rtbAddress.Text
            vendor.IsMarkDelete = False
            vendorTransMsgStatus = vendorRepo.Update()

            If vendorTransMsgStatus <> "True" Then
                MsgBox("Error save Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
            Else
                MessageBox.Show("Save successfully.", "New", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click        
        Me.Close()
    End Sub

    
End Class
