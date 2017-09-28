Public Class frmCategory
    Dim cateRepo As ICategoryRepository = New CategoryRepository
    Public isCateClose As Boolean = False
    Public cateID As Integer = 0
    Public isCreateMainCate As Boolean
    Dim UCategory As UCCategories
    Public isNewCateFromItemForm As Boolean


    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cate As New tblCategory
        Dim cateTransMsgStatus As String

        ' Validation
        If ValidateTextField(txtCateName, "Category name", ErrorCate) = False Then
            Exit Sub
        End If

        'validate category name must be unique
        If UCase(txtTempDepartName.Text) <> UCase(txtCateName.Text) Then
            If cateRepo.isCateExistSearchByCateName(txtCateName.Text) = True Then
                MsgBox("Category Name already exist.")
                Exit Sub
            End If
        End If
        
        ' Add new vendor to database        
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Category ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If isCreateMainCate = False Then ' Create Sub Category
                    ' Set attributes of new category
                    cate.ParentID = cateID
                    cate.CateName = txtCateName.Text
                    cate.CateDescription = txtDes.Text
                    cate.ItemCount = 0
                Else ' Create Main Category
                    cate.ParentID = 0
                    cate.CateName = txtCateName.Text
                    cate.CateDescription = txtDes.Text
                    cate.ItemCount = 0
                End If                
                cateTransMsgStatus = cateRepo.CreateCate(cate)

                If cateTransMsgStatus <> "True" Then
                    MsgBox("Error save category.", MsgBoxStyle.Critical, "Error : " & cateTransMsgStatus)
                Else

                    MsgBox("Add new category successful.")
                    If isNewCateFromItemForm = True Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If

                End If
            End If

        Else ' Update vendor to database
            If MessageBox.Show("Do you want save Category ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cate = cateRepo.GetCateByID(cateID)
                cate.CateName = txtCateName.Text
                cate.CateDescription = txtDes.Text
                cateTransMsgStatus = cateRepo.UpdateCate
                If cateTransMsgStatus <> "True" Then
                    MsgBox("Error update category.", MsgBoxStyle.Critical, "Error : " & cateTransMsgStatus)
                Else
                    MsgBox("Update category successful.")
                End If
            End If            
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        isCateClose = False
        Me.Close()
    End Sub
    Public Sub New(ByVal mainCate As UCCategories)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UCategory = mainCate
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Add new Category
        If lblSaveOption.Text = "0" Then
            txtCateID.Text = cateRepo.GenerateCateID

        Else ' Edit Category
            Dim cate As New tblCategory
            cate = cateRepo.GetCateByID(cateID)
            txtCateID.Text = cate.CateID
            txtCateName.Text = cate.CateName
            txtDes.Text = cate.CateDescription
            txtTempDepartName.Text = cate.CateName
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        isNewCateFromItemForm = True
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class