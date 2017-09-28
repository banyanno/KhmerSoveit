
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Public Class PDFPrinter

    Public Shared Function PrintPDFs(ByVal pdfFileName As String, ByVal PrintName As String) As [Boolean]
        Try
            Dim proc As New Process()
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proc.StartInfo.Verb = "print"

            'Define location of adobe reader/command line
            'switches to launch adobe in "print" mode
            proc.StartInfo.FileName = "C:\Program Files (x86)\Adobe\Reader 11.0\Reader\AcroRd32.exe"
            proc.StartInfo.Arguments = [String].Format("/p /h {0}", pdfFileName)
            proc.StartInfo.UseShellExecute = False
            proc.StartInfo.CreateNoWindow = True

            proc.Start()
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            If proc.HasExited = False Then
                proc.WaitForExit(10000)
            End If

            proc.EnableRaisingEvents = True
            proc.Close()
            KillAdobe("AcroRd32")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try

    End Function

    'For whatever reason, sometimes adobe likes to be a stage 5 clinger.
    'So here we kill it with fire.
    'Private Shared Function KillAdobe(ByVal name As String) As Boolean
    '    For Each clsProcess As Process In Process.GetProcesses().Where(Function(clsProcess) clsProcess.ProcessName.StartsWith(name))
    '        clsProcess.Kill()
    '        Return True
    '    Next
    '    Return False
    'End Function
    Private Shared Function KillAdobe(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcessesByName(name) '.Where(Function(clsProcess) clsProcess.ProcessName.StartsWith(name))
            clsProcess.Kill()
            Return True
        Next
        Return False
    End Function

    Public Sub printPDF(ByVal PDFFile As String)
        Dim pd As New Printing.PrintDocument()
        Dim defPrinter As String = pd.PrinterSettings.PrinterName
        Try
            If pd.PrinterSettings.IsValid Then
                Dim SPrinter As String = defPrinter.Trim
                Dim pathToExecutable As String = "C:\Program Files (x86)\Adobe\Reader 11.0\Reader\AcroRd32.exe"
                Dim sReport As String = PDFFile '"C:\ERMC\DataFiles\AutoBatchRPT.pdf" 'Complete name/path of PDF file
                Dim starter As New ProcessStartInfo(pathToExecutable, "/t " + sReport + " " + SPrinter + "")
                Dim Process As New Process()
                Process.StartInfo = starter
                Process.Start()
                'try and close the process with 10 seconds delay System.Threading.Thread.Sleep(10000)
                Process.CloseMainWindow()
                Dim iLoop As Int16 = 0
                'check the process has exited or not
                If Process.HasExited = False Then
                    'if not then loop for 100 time to try and close the process‘with 5 seconds delay
                    While Not Process.HasExited
                        System.Threading.Thread.Sleep(5000)
                        Process.CloseMainWindow()
                        iLoop = CShort(iLoop + 1)
                        If iLoop >= 100 Then
                            Process.Kill()
                            Exit While
                        End If
                    End While
                End If
                Process.Close()
                Process.Dispose()
                Process = Nothing
                starter = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
