Public NotInheritable Class frmWelcome

    ' Set the progress.
    Public Delegate Sub ShowProgressDelegate(ByVal progress As Integer)
    Public Sub ShowProgress(ByVal progress As Integer)
        pbarLoad.Value = progress
    End Sub

    ' Get or set the progress indicator.
    Public Property Progress() As Integer
        Get
            Return pbarLoad.Value
        End Get
        Set(ByVal value As Integer)
            If Me.InvokeRequired Then
                Dim show_progress_delegate As ShowProgressDelegate
                show_progress_delegate = AddressOf ShowProgress
                Me.Invoke(show_progress_delegate, New Object() {value})
            Else
                ShowProgress(value)
            End If
        End Set
    End Property


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''Set up the dialog text at runtime according to the application's assembly information.  

        ''TODO: Customize the application's assembly information in the "Application" pane of the project 
        ''  properties dialog (under the "Project" menu).

        ''Application title
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'If the application title is missing, use the application name, without the extension
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        ''Format the version information using the text set into the Version control at design time as the
        ''  formatting string.  This allows for effective localization if desired.
        ''  Build and revision information could be included by using the following code and changing the 
        ''  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        ''  String.Format() in Help for more information.
        ''
        ''    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        ''Copyright info
        'Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub pbarLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbarLoad.Click

    End Sub
End Class
