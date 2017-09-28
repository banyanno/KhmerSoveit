Public Class FormAddMoreQTY
    Dim DA_Item As New DSAddQTYTableAdapters.tblItemTableAdapter
    Dim DA_QTY As New DSAddQTYTableAdapters.tblCentralInventoryTableAdapter
    Dim CateQTY As UCCategories
    Sub New(ByVal CateQTY As UCCategories)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.CateQTY = CateQTY
        With CboItem
            .DataSource = DA_Item.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboItem, "", ErrQTY) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrQTY) = False Then Exit Sub
        If DA_Item.CheckExistItem(CInt(CboItem.SelectedValue), CboItem.Text) <= 0 Then
            MessageBox.Show("The name of medicince dosen't have in system. Please check again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Focus()
            CboItem.SelectAll()
            Exit Sub
        End If
        If MessageBox.Show("Do you want to add quality", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_QTY.UpdateQTY(EmptyString(TxtQTY.Text), CInt(CboItem.SelectedValue)) = 1 Then
                Me.CboItem.SelectedIndex = -1
                Me.CboItem.Focus()
                Me.TxtQTY.Text = "0"
                CateQTY.RefreshListItemsDataToolStripMenuItem_Click(sender, e)
            End If
        End If

    End Sub

    Private Sub BtnCacel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCacel.Click
        Me.Close()
    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        'SetDisableKeyString(e)
    End Sub
End Class