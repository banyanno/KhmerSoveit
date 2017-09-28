Public Class FormEditDonateOpticalShop
    Dim DADonation As New DSOpticalShopTableAdapters.DONATIONTableAdapter
    Dim DA_ReceiptOptical As New DSDonationTableAdapters.RECEIPTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitDonation()
    End Sub
    Sub InitDonation()
        With CboDonation
            .DataSource = DADonation.GetData
            .DisplayMember = "DonationName"
            .ValueMember = "DonationID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub FormEditDonateOpticalShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboDonation, "", ErroDonate) = False Then Exit Sub
        If ValidateTextField(TxtDonateAmount, "", ErroDonate) = False Then Exit Sub
        If MessageBox.Show("Do you want to update donate in optical shop?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_ReceiptOptical.UpdateDonateAmount(CboDonation.SelectedValue, TxtDonateAmount.Text, LblOpticalShopID.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub TxtDonateAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDonateAmount.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class