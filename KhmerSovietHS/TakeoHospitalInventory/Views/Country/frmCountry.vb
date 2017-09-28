Imports System.Data.Common

Public Class frmCountry

    Dim UCountry As UCCountry
    Public countryID As Integer
    Public countryName As String

    Public Sub New(ByVal mainCountry As UCCountry)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        UCountry = mainCountry
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmCountry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '--- Edit country mode
        If lblSaveOption.Text <> "0" Then
            TxtCountry.Text = countryName
            TxtTempCountryName.Text = countryName
        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim THIDataContext As New BaseDataContext

        '--- Validation
        If ValidateTextField(TxtCountry, "Country name", ErrorProvider) = False Then Exit Sub
        If lblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Country ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If IsCountryExist(TxtCountry.Text) = True Then
                    MessageBox.Show("Country name already Registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    '--- Implement business update transaction
                    Dim TCoun As New COUNTRY
                    TCoun.Country = TxtCountry.Text

                    '--- Implement business insert transaction
                    THIDataContext.getTHIDataContext.COUNTRies.InsertOnSubmit(TCoun)
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    '--- Message batch transaction successfully
                Catch ex As Exception
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MsgBox("Error register country: " & ex.Message)
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("Save new country successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UCountry.FillDataByCountryName(TxtCountry.Text)
                Me.Close()

            End If

        Else

            If MessageBox.Show("Do you want save country ?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If TxtCountry.Text.ToUpper <> TxtTempCountryName.Text.ToUpper Then
                    If IsCountryExist(TxtCountry.Text) = True Then
                        MessageBox.Show("Country name already Registered.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If

                THIDataContext.getTHIDataContext.Connection.Close()
                THIDataContext.getTHIDataContext.Connection.Open()
                Dim trans As DbTransaction = THIDataContext.getTHIDataContext.Connection.BeginTransaction
                THIDataContext.getTHIDataContext.Transaction = trans

                Try
                    '--- Implement business update transaction
                    Dim q = From Coun In THIDataContext.getTHIDataContext.COUNTRies Where Coun.CountryID = countryID
                    Dim TCoun As COUNTRY = q.SingleOrDefault
                    TCoun.Country = TxtCountry.Text

                    '--- Implement business insert transaction                   
                    THIDataContext.getTHIDataContext.SubmitChanges()

                    trans.Commit()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    '--- Message batch transaction successfully
                Catch ex As Exception
                    trans.Rollback()
                    THIDataContext.getTHIDataContext.Connection.Close()
                    MsgBox("Error register country: " & ex.Message)
                Finally
                    trans = Nothing
                End Try

                MessageBox.Show("Save country successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UCountry.FillDataByCountryName(TxtCountry.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Function IsCountryExist(ByVal pCounName As String) As Boolean
        Try
            Dim THIDataContext As New BaseDataContext
            Dim q = From TCoun In THIDataContext.getTHIDataContext.COUNTRies Where TCoun.Country.ToUpper = pCounName.ToUpper
            If q.ToList.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error function IsCountryExist :" & ex.Message)
        End Try
    End Function

End Class