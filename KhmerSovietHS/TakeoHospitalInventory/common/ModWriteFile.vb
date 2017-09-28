Imports System.IO
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Module ModWriteFile
    Public Function GetFileContents(ByVal FullPath As String, _
           Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    Public Function SaveTextToFile(ByVal strData As String, _
     ByVal FullPath As String, _
       Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try
            If File.Exists(FullPath) = False Then
                Dim fs As New FileStream(FullPath, FileMode.Create, FileAccess.Write)
                fs.Close()
                objReader = New StreamWriter(FullPath)
                objReader.Write(strData)
                objReader.Close()
                bAns = True
            Else
                objReader = New StreamWriter(FullPath)
                objReader.Write(strData)
                objReader.Close()
                bAns = True
            End If


        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function

    Public Function ImageToByArray(ByVal img As System.Drawing.Image) As Byte()
        Dim ms As New MemoryStream
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray
    End Function

    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Try
            Dim ms As New MemoryStream(byteArrayIn)
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        Catch ex As Exception

        End Try
        
    End Function
    Public Function ReadFileToBye(ByVal FilePath As String) As Byte()
        Dim dataBye As Byte()
        Dim fileInFo As New FileInfo(FilePath)
        Dim numBye As Long = fileInFo.Length
        Dim fileStream As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
        Dim BinaryArray As New BinaryReader(fileStream)
        dataBye = BinaryArray.ReadBytes(numBye)
        Return dataBye
    End Function
    Public Sub EXPORT_PDF_PRINTER(ByVal CRYSTAL_REPORT As ReportDocument, ByVal DATA_TABLE As DataTable, ByVal PDF_VIEWER As AxAcroPDFLib.AxAcroPDF, ByVal FILE_NAME As String)

        'Dim FPrintLabel As New FormLabelPrinter
        'CRYSTAL_REPORT = New Object
        CRYSTAL_REPORT.SetDataSource(DATA_TABLE)

        ' ================ Invoice ====================
        Dim CrExportLabel As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\" & FILE_NAME & ".pdf"
        CrExportLabel = CRYSTAL_REPORT.ExportOptions
        With CrExportLabel
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        CRYSTAL_REPORT.Export()
        Application.DoEvents()
        Application.DoEvents()
        PDF_VIEWER.src = My.Application.Info.DirectoryPath & "\" & FILE_NAME & ".pdf"
        PDF_VIEWER.setZoom(100)
        CRYSTAL_REPORT.Dispose()
        CRYSTAL_REPORT.Close()
        ' WIN_FORM.ShowDialog()
    End Sub
End Module
