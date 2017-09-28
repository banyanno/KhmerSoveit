Imports System.Net
Imports System.Data.SqlClient

Public Class FRMLockSystem
    'Inherits System.Windows.Forms.Form
    Dim isAltF4 As Boolean = False
    Dim LoginCount As Integer
    Dim StrUserName As String
    Dim MainForm As MainTakeoInventory
    Sub New(ByVal main As MainTakeoInventory)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainForm = main
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmLogOff_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.Alt = True And e.Control = True And e.KeyCode = Keys.Enter Then
            If Me.Height <> 308 Then
                Me.Height = 308
                Me.txtPassword.Enabled = True
                Me.txtUserName.Enabled = True
                Me.cmdCancel.Enabled = True
                Me.cmdOK.Enabled = True
                Me.txtPassword.Text = ""
                Me.txtUserName.Text = USER_NAME
                Me.txtUserName.Focus()
            End If
        End If
    End Sub

    Private Sub frmLogOff_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Call cmdCancel_Click(sender, e)
        End If
    End Sub

    Private Sub frmLogOff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        MainForm.Hide()
        Me.lblName.Text = UserGlobleVariable.USER_NAME
        Me.lblDate.Text = TimeString 'modGlobal.vLogonTime
        Me.Height = 169
        Me.Focus()
    End Sub

    Private Sub frmLogOff_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If isAltF4 = True Then
            e.Cancel = True
        End If
        isAltF4 = False
    End Sub

    Private Sub frmLogOff_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt = True And e.KeyCode = Keys.F4 Then
            isAltF4 = True
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        On Error Resume Next
        Me.Height = 169
        Me.txtPassword.Enabled = False
        Me.txtUserName.Enabled = False
        Me.cmdCancel.Enabled = False
        Me.cmdOK.Enabled = False
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If Me.txtPassword.Text.ToUpper.Trim = UserGlobleVariable.USER_PWD Then
            MainForm.Show()
            Me.Close()
        Else
            MsgBox("Password not currect by user login.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub txtUserName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus
        Me.txtUserName.SelectionStart = 0
        Me.txtUserName.SelectionLength = Me.txtUserName.TextLength
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.SelectionLength = Me.txtPassword.TextLength
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.cmdOK_Click(sender, e)
        End If
    End Sub

End Class