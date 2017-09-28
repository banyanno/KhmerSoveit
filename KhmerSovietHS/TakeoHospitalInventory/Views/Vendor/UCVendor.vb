Imports Janus.Windows.GridEX

Public Class UCVendor

    Dim VendorDataAdapter As DSVendorsTableAdapters.tblVenderTableAdapter
    Dim vendorRepo As IVendorRepository = New VendorRepository
    Private Sub UCVendor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindIntoDataGrid()
    End Sub

    Public Sub BindIntoDataGrid()
        gridVendors.DataSource = VendorDataAdapter.GetData
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        VendorDataAdapter = New DSVendorsTableAdapters.tblVenderTableAdapter
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        BindIntoDataGrid()
    End Sub


    Private Sub gridVendors_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridVendors.Click

        Dim vendor As New tblVender
        If Not gridVendors.CurrentRow Is Nothing AndAlso gridVendors.CurrentRow.RowType = RowType.Record Then
            vendor = vendorRepo.GetVenderByID(gridVendors.GetValue("VenderID"))
            txtVendorName.Text = vendor.VenderName
            txtTelephone.Text = vendor.VenderPhone
            txtFax.Text = vendor.VenderPhone
            txtEmail.Text = vendor.VenderEmail
            rtbAddress.Text = vendor.VenderAddress
        Else
            MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim vendor As New tblVender
        Dim vendorTransMsgStatus As String = ""

        If MessageBox.Show("Do you want delete Vendor ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Not gridVendors.CurrentRow Is Nothing AndAlso gridVendors.CurrentRow.RowType = RowType.Record Then

                vendor = vendorRepo.GetVenderByID(gridVendors.GetValue("VenderID"))
                vendorTransMsgStatus = vendorRepo.DeleteVender(vendor)

                If vendorTransMsgStatus <> "True" Then
                    MsgBox("Error delete Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
                Else
                    MessageBox.Show("Delete Vendor successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BindIntoDataGrid()
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        'Dim FVendor As New frmVender(Me)
        'FVendor.ShowDialog()
        'FVendor.Close()
        'FVendor.Dispose()
    End Sub

    Public Sub FillDataByVendorName(ByVal pVendorName As String)        
        gridVendors.DataSource = VendorDataAdapter.GetDataByVendorName(pVendorName)
    End Sub

    Private Sub btnEditVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditVendor.Click
        Dim vendor As New tblVender
        Dim vendorTransMsgStatus As String = ""

        If MessageBox.Show("Do you want save Vendor ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Not gridVendors.CurrentRow Is Nothing AndAlso gridVendors.CurrentRow.RowType = RowType.Record Then

                vendor = vendorRepo.GetVenderByID(gridVendors.GetValue("VenderID"))                
                vendor.VenderName = txtVendorName.Text
                vendor.VenderPhone = txtTelephone.Text
                vendor.VenderEmail = txtEmail.Text
                vendor.VenderFax = txtFax.Text
                vendor.VenderAddress = rtbAddress.Text
                vendorTransMsgStatus = vendorRepo.Update

                If vendorTransMsgStatus <> "True" Then
                    MsgBox("Error save Vendor.", MsgBoxStyle.Critical, "Error : " & vendorTransMsgStatus)
                Else
                    MessageBox.Show("Save Vendor successful.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'BindIntoDataGrid()
                    FillDataByVendorName(txtVendorName.Text)
                End If
            Else
                MessageBox.Show("Select the message you want to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

  
End Class
