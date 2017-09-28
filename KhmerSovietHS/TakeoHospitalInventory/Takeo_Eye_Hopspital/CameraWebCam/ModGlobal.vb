
Imports System.Data.OleDb

Module ModGlobal

    'Global
    Public OleCn As New OleDbConnection()
    Public OleDa As New OleDbDataAdapter()
    Public DtaSet As New DataSet()

    'For Edit
    Public DtaSet2 As DataSet

    Public Function StrConnection() As String
        StrConnection = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\Students\Students.Accdb;"
        Return StrConnection
    End Function

    Public Enum Form_State
        Add_RecordState = 0  'Use DtaSet
        Edit_RecordState = 1 'Use DtaSet2 
    End Enum

    Dim StudentIDColumn As New DataGridViewTextBoxColumn()
    Dim FirstNameColumn As New DataGridViewTextBoxColumn()
    Dim LastNameColumn As New DataGridViewTextBoxColumn()
    Dim MIColumn As New DataGridViewTextBoxColumn
    Dim GenderColumn As New DataGridViewTextBoxColumn()
    Dim DateOfBirthColumn As New DataGridViewTextBoxColumn()
    Dim SchoolColumn As New DataGridViewTextBoxColumn()
    Dim CourseColumn As New DataGridViewTextBoxColumn()
    Dim MajorColumn As New DataGridViewTextBoxColumn()
    Dim BlockColumn As New DataGridViewTextBoxColumn()

    'Customize Datagridview...
    Public Sub DataConnection(ByVal DgV As DataGridView)
        DgV.AutoGenerateColumns = False
        With StudentIDColumn
            .DataPropertyName = "Student_ID"
            .HeaderText = "Student ID"
            .Width = 95
        End With
        With FirstNameColumn
            .DataPropertyName = "FirstName"
            .HeaderText = "First Name"
            .Width = 100
        End With
        With LastNameColumn
            .DataPropertyName = "LastName"
            .HeaderText = "Last Name"
            .Width = 100
        End With
        With MIColumn
            .DataPropertyName = "MiddleName"
            .HeaderText = "MI"
            .Width = 40
        End With
        With GenderColumn
            .DataPropertyName = "Gender"
            .HeaderText = "Gender"
            .Width = 50
        End With
        With DateOfBirthColumn
            .DataPropertyName = "Date_Of_Birth"
            .HeaderText = "Date of Birth"
            .Width = 100
        End With
        With SchoolColumn
            .DataPropertyName = "School"
            .HeaderText = "School"
            .Width = 170
        End With
        With CourseColumn
            .DataPropertyName = "Course"
            .HeaderText = "Course"
            .Width = 170
        End With
        With MajorColumn
            .DataPropertyName = "Major"
            .HeaderText = "Major"
            .Width = 130
        End With
        With BlockColumn
            .DataPropertyName = "Block"
            .HeaderText = "Block"
            .Width = 50
        End With
        With DgV
            .DataSource = DtaSet
            .DataMember = "Students"
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False ' Disabled or hide (*) Symbol...
            .AllowUserToResizeColumns = False 'Disable HearderText Resize Column...
            .AllowUserToResizeRows = False 'Disabled  row resize...
            .RowHeadersVisible = False 'To hide Left indicator...
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue  'Selection backcolor....
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow 'Alternating Backcolor
            .Columns.AddRange(New DataGridViewColumn() {StudentIDColumn, FirstNameColumn, LastNameColumn, MIColumn, GenderColumn, DateOfBirthColumn, SchoolColumn, CourseColumn, MajorColumn, BlockColumn})
        End With
    End Sub
End Module
