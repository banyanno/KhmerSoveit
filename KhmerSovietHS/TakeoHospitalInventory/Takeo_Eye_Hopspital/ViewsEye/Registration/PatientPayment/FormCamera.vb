Public Class FormCamera

    Dim FNewPatient As NewPatientPayment
    Dim DSPatientRegis As UCPatientPayment
    Dim FDoctorConsult As NewDoctorConsult
    Public IS_UpdateImage As Integer = 1
    Sub New(ByVal FNewPatient As NewPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FNewPatient = FNewPatient
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal DSPatientRegis As UCPatientPayment)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DSPatientRegis = DSPatientRegis
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal FDoctorConsult As NewDoctorConsult)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.FDoctorConsult = FDoctorConsult
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormCamera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenPriewWindow()
        BCapture.Focus()
    End Sub

    Private Sub OpenPriewWindow()
        Dim iHeight As Integer = Me.PictPatient.Height
        Dim iWidth As Integer = Me.PictPatient.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictPatient.Handle.ToInt64, 0)
        'hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, PictPatient.Width, PictPatient.Height, PictPatient.Handle.ToInt64, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictPatient.Width, PictPatient.Height, SWP_NOMOVE Or SWP_NOZORDER)
            'SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, Me.Size.Width, Me.Size.Height, SWP_NOMOVE Or SWP_NOZORDER)
        End If
    End Sub
    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub BCapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCapture.Click
        If BCapture.Text = "Capture:" Then
            Dim Data As IDataObject
            Dim Bmap As Image
            SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
            Data = Clipboard.GetDataObject()
            If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
                PictPatient.Image = Bmap
                ClosePreviewWindow()
                'MsgBox("Captured...", MsgBoxStyle.Information, "Captured...")
            End If
            B_Ok_Or_Cancel.Text = "Copy:"
            B_Ok_Or_Cancel.Focus()
            BCapture.Text = "Capture Again:"
            'FrmEntry.LblStart.Text = ""
        Else
            If BCapture.Text = "Capture Again:" Then
                B_Ok_Or_Cancel.Text = "Cancel Capture:"
                BCapture.Text = "Capture:"
                Call OpenPriewWindow()
                'FrmEntry.LblStart.Text = "Camera is running..."
            End If
        End If
    End Sub

    Private Sub B_Ok_Or_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Ok_Or_Cancel.Click
        If IS_UpdateImage = 1 Then
            PicForUpdatePatient()
        ElseIf IS_UpdateImage = 2 Then
            PicForNewPatient()
        ElseIf IS_UpdateImage = 3 Then
            AddDiagnosisPatient()
        End If

    End Sub
    Sub PicForNewPatient()
        If Me.B_Ok_Or_Cancel.Text = "Copy:" Then
            FNewPatient.PicturePatient.Image = Me.PictPatient.Image
            Me.Close()
            Exit Sub
        End If
        If Me.B_Ok_Or_Cancel.Text = "Cancel Capture:" Then
            Me.Close()
            Exit Sub
        End If
    End Sub
    Sub PicForUpdatePatient()
        If Me.B_Ok_Or_Cancel.Text = "Copy:" Then
            DSPatientRegis.PictureBox1.Image = Me.PictPatient.Image
            Me.Close()
            Exit Sub
        End If
        If Me.B_Ok_Or_Cancel.Text = "Cancel Capture:" Then
            Me.Close()
            Exit Sub
        End If
    End Sub
    Sub AddDiagnosisPatient()
        If Me.B_Ok_Or_Cancel.Text = "Copy:" Then
            Try

                FDoctorConsult.DA_ImageDiagnosis.InsertNewConsult(FDoctorConsult.LblWaitingNo.Text, ImageToByArray(PictPatient.Image))
                FDoctorConsult.GridImageList.DataSource = FDoctorConsult.DA_ImageDiagnosis.SelectByWaitingNo(FDoctorConsult.LblWaitingNo.Text)
            Catch ex As Exception

            End Try

            Me.Close()
            Exit Sub
        End If
        If Me.B_Ok_Or_Cancel.Text = "Cancel Capture:" Then
            Me.Close()
            Exit Sub
        End If
    End Sub

    'Private Sub FormCamera_MaximumSizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MaximumSizeChanged
    '    OpenPriewWindow()
    '    BCapture.Focus()
    'End Sub

    'Private Sub FormCamera_MaximizedBoundsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MaximizedBoundsChanged
    '    OpenPriewWindow()
    '    BCapture.Focus()
    'End Sub

 
End Class