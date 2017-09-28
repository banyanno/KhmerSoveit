Imports System.Math
Public Class FormMainDonateReport
    Dim DADonation As New DSDonationTableAdapters.DONATION_DETAILTableAdapter
    Dim ObjCryDonateNormal As New CryDonatev1
    Dim ObjCryDonateWithSocial As New CryDonate
    Dim TblDonateTem As DataTable
    Dim DonateNo As String
    Dim DONATE_IN As String = ""
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Dim FNewDonation As New NewDonation
        If FNewDonation.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridDonation.DataSource = ModDonation.GetDonation
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If GridDonation.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            Dim FDonation As New NewDonation
            FDonation.LblSaveOption.Text = GridDonation.GetRow.Cells(0).Value
            FDonation.TxtDonation.Text = GridDonation.GetRow.Cells(1).Value
            FDonation.TxtDescription.Text = GridDonation.GetRow.Cells(2).Value
            If FDonation.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridDonation.DataSource = ModDonation.GetDonation
            End If
        End If
    End Sub

    Private Sub BtnRefreshData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefreshData.Click

        LoadData()
    End Sub
    Sub LoadData()
        GridDonation.DataSource = ModDonation.GetDonation
    End Sub


    Private Sub FormMainDonateReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' LoadData()
        'InitDonate()
    End Sub
    Sub InitDonate()
        With CboDonation
            .DataSource = ModDonation.GetDonation
            .ValueMember = "DonationID"
            .DisplayMember = "DonationName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub GridDonation_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridDonation.SelectionChanged
        If ValidateDateTimePicker(DatePickerFrom, "", ErrDonate) = False Then Exit Sub
        If ValidateDateTimePicker(DatePickTo, "", ErrDonate) = False Then Exit Sub
        If GridDonation.SelectedItems.Count = 0 Then
            Exit Sub
        Else
            'PicLoading.Visible = True
            'BgSelectDonate.RunWorkerAsync()
            If RadShowAllDonate.Checked = True Then
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation1(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value)
            ElseIf RadDonateInOpticalShop.Checked = True Then
                DONATE_IN = "OP"
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value, DONATE_IN)
            ElseIf RadDonateInPatient.Checked = True Then
                DONATE_IN = "IP"
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value, DONATE_IN)
            End If
        End If
    End Sub


    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If ValidateDateTimePicker(DatePickerFrom, "", ErrDonate) = False Then Exit Sub
        If ValidateDateTimePicker(DatePickTo, "", ErrDonate) = False Then Exit Sub
        PicLoading.Visible = True
        BgLoadDonateRepord.RunWorkerAsync()
    End Sub
    Sub PreviewDataBySelectedDonate()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewDataBySelectedDonate))
        Else
            If ValidateDateTimePicker(DatePickerFrom, "", ErrDonate) = False Then Exit Sub
            If ValidateDateTimePicker(DatePickTo, "", ErrDonate) = False Then Exit Sub
            If RadShowAllDonate.Checked = True Then
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation1(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value)
            ElseIf RadDonateInOpticalShop.Checked = True Then
                DONATE_IN = "OP"
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value, DONATE_IN)
            ElseIf RadDonateInPatient.Checked = True Then
                DONATE_IN = "IP"
                GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, GridDonation.GetRow.Cells("DonationID").Value, DONATE_IN)
            End If

        End If
    End Sub
    Sub PreviewData()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PreviewData))
        Else
            If ValidateDateTimePicker(DatePickerFrom, "", ErrDonate) = False Then Exit Sub
            If ValidateDateTimePicker(DatePickTo, "", ErrDonate) = False Then Exit Sub
            '' Case view as Table

            If RadAsGrid.Checked = True Then
                If ChViewall.Checked = True Then
                    If RadShowAllDonate.Checked = True Then
                        GridDonatedDetail.DataSource = DADonation.GetDataByDateFromTO1(DatePickerFrom.Value, DatePickTo.Value)
                    ElseIf RadDonateInOpticalShop.Checked = True Then
                        DONATE_IN = "OP"
                        If RadGlasessAndMedicince.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                        End If
                        If RadGlasess.Checked = True Then
                            TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1)
                        End If
                        If RadMedicince.Checked = True Then
                            TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2)
                        End If
                        GridDonatedDetail.DataSource = TblDonateTem ' DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                    ElseIf RadDonateInPatient.Checked = True Then
                        DONATE_IN = "IP"
                        GridDonatedDetail.DataSource = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                    End If
                End If
                If ChViewall.Checked = False Then
                    If ValidateCombobox(CboDonation, "", ErrDonate) = False Then Exit Sub
                    If RadShowAllDonate.Checked = True Then
                        GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation1(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue)
                    ElseIf RadDonateInOpticalShop.Checked = True Then
                        DONATE_IN = "OP"
                        If RadGlasess.Checked = True Then
                            TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1, CboDonation.SelectedValue)
                        End If
                        If RadMedicince.Checked = True Then
                            TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2, CboDonation.SelectedValue)
                        End If
                        If RadGlasessAndMedicince.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                        End If

                        GridDonatedDetail.DataSource = TblDonateTem 'DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                    ElseIf RadDonateInPatient.Checked = True Then
                        DONATE_IN = "IP"
                        GridDonatedDetail.DataSource = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                    End If

                End If
            ElseIf RadAsReports.Checked = True Then
                '============== View Report ===============================
                If RadNormalReport.Checked = True Then
                    If ChViewall.Checked = True Then
                        If RadShowAllDonate.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateFromTO1(DatePickerFrom.Value, DatePickTo.Value)
                            ObjCryDonateNormal.SetDataSource(TblDonateTem)
                            ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateNormal.SetParameterValue("SubHeader", "Type Of Surgery/Optical Shop".ToString)
                        ElseIf RadDonateInOpticalShop.Checked = True Then
                            DONATE_IN = "OP"
                            If RadGlasessAndMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                            End If
                            If RadGlasess.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1)
                            End If
                            If RadMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2)
                            End If
                            ObjCryDonateNormal.SetDataSource(TblDonateTem)
                            If RadGlasess.Checked = True Then
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Glasess From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Glasess")
                            End If
                            If RadMedicince.Checked = True Then
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Medicince".ToString)
                            End If
                            If RadGlasessAndMedicince.Checked = True Then
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Glasess/Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Glasess/Medicince".ToString)
                            End If
                        ElseIf RadDonateInPatient.Checked = True Then
                            DONATE_IN = "IP"
                            TblDonateTem = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                            ObjCryDonateNormal.SetDataSource(TblDonateTem)
                            ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported In (IN-PATIENT) From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateNormal.SetParameterValue("SubHeader", "Type Of Surgery".ToString)
                        End If
                        CrysViewerDonation.ReportSource = ObjCryDonateNormal

                    End If
                    '............End of view all donation ....................


                    If ChViewall.Checked = False Then
                        If ValidateCombobox(CboDonation, "", ErrDonate) = False Then Exit Sub
                        If RadShowAllDonate.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateWithDonation1(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue)
                            ObjCryDonateNormal.SetDataSource(TblDonateTem)
                            ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Supported by " & CboDonation.Text & " From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateNormal.SetParameterValue("SubHeader", "Type Of Surgery/Optical Shop".ToString)
                        ElseIf RadDonateInOpticalShop.Checked = True Then
                            DONATE_IN = "OP"
                            If RadGlasess.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1, CboDonation.SelectedValue)
                                ObjCryDonateNormal.SetDataSource(TblDonateTem)
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & " In (OPTICAL-SHOP) Of Glasess From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Glasess")
                            End If
                            If RadMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2, CboDonation.SelectedValue)
                                ObjCryDonateNormal.SetDataSource(TblDonateTem)
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & "  In (OPTICAL-SHOP) Of Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Medicince".ToString)
                            End If
                            If RadGlasessAndMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                                ObjCryDonateNormal.SetDataSource(TblDonateTem)
                                ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & " In (OPTICAL-SHOP) Of Glasess/Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateNormal.SetParameterValue("SubHeader", "List of Glasess/Medicince".ToString)
                            End If

                        ElseIf RadDonateInPatient.Checked = True Then
                            DONATE_IN = "IP"
                            TblDonateTem = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                            ObjCryDonateNormal.SetDataSource(TblDonateTem)
                            ObjCryDonateNormal.SetParameterValue("TitleName", "List of Patient Supported by " & CboDonation.Text & " of (IN-PATIENT) From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateNormal.SetParameterValue("SubHeader", "Type Of Surgery".ToString)
                        End If
                        CrysViewerDonation.ReportSource = ObjCryDonateNormal
                    End If
                Else
                    If ChViewall.Checked = True Then
                        If RadShowAllDonate.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateFromTO1(DatePickerFrom.Value, DatePickTo.Value)
                            ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                            ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateWithSocial.SetParameterValue("SubHeader", "Type Of Surgery/Optical Shop".ToString)
                        ElseIf RadDonateInOpticalShop.Checked = True Then
                            DONATE_IN = "OP"
                            If RadGlasessAndMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                            End If
                            If RadGlasess.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1)
                            End If
                            If RadMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasess(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2)
                            End If
                            ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                            If RadGlasess.Checked = True Then
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Glasess From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Glasess")
                            End If
                            If RadMedicince.Checked = True Then
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Medicince".ToString)
                            End If
                            If RadGlasessAndMedicince.Checked = True Then
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported In (OPTICAL-SHOP) By Glasess/Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Glasess/Medicince".ToString)
                            End If
                        ElseIf RadDonateInPatient.Checked = True Then
                            DONATE_IN = "IP"
                            TblDonateTem = DADonation.GetDataByDateFromTO(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN)
                            ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                            ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported In (IN-PATIENT) From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateWithSocial.SetParameterValue("SubHeader", "Type Of Surgery".ToString)
                        End If
                        CrysViewerDonation.ReportSource = ObjCryDonateWithSocial

                    End If
                    '............End of view all donation ....................


                    If ChViewall.Checked = False Then
                        If ValidateCombobox(CboDonation, "", ErrDonate) = False Then Exit Sub
                        If RadShowAllDonate.Checked = True Then
                            TblDonateTem = DADonation.GetDataByDateWithDonation1(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue)
                            ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                            ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Supported by " & CboDonation.Text & " From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateWithSocial.SetParameterValue("SubHeader", "Type Of Surgery/Optical Shop".ToString)
                        ElseIf RadDonateInOpticalShop.Checked = True Then
                            DONATE_IN = "OP"
                            If RadGlasess.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 1, CboDonation.SelectedValue)
                                ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & " In (OPTICAL-SHOP) Of Glasess From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Glasess")
                            End If
                            If RadMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByOpticalShopWithGlasessAndDonate(DatePickerFrom.Value, DatePickTo.Value, DONATE_IN, 2, CboDonation.SelectedValue)
                                ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & "  In (OPTICAL-SHOP) Of Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Medicince".ToString)
                            End If
                            If RadGlasessAndMedicince.Checked = True Then
                                TblDonateTem = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                                ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                                ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Suported By " & CboDonation.Text.ToUpper & " In (OPTICAL-SHOP) Of Glasess/Medicince From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                                ObjCryDonateWithSocial.SetParameterValue("SubHeader", "List of Glasess/Medicince".ToString)
                            End If

                        ElseIf RadDonateInPatient.Checked = True Then
                            DONATE_IN = "IP"
                            TblDonateTem = DADonation.GetDataByDateWithDonation(DatePickerFrom.Value, DatePickTo.Value, CboDonation.SelectedValue, DONATE_IN)
                            ObjCryDonateWithSocial.SetDataSource(TblDonateTem)
                            ObjCryDonateWithSocial.SetParameterValue("TitleName", "List of Patient Supported by " & CboDonation.Text & " of (IN-PATIENT) From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                            ObjCryDonateWithSocial.SetParameterValue("SubHeader", "Type Of Surgery".ToString)
                        End If
                        CrysViewerDonation.ReportSource = ObjCryDonateWithSocial
                    End If
                End If


                ' We view as report Delete
            ElseIf RadReportDelete.Checked = True Then
                TblDonateTem = DADonation.GetDataByDonatedDelete(True, DatePickerFrom.Value.Date, DatePickTo.Value.Date)
                ObjCryDonateNormal.SetDataSource(TblDonateTem)
                ObjCryDonateNormal.SetParameterValue("TitleName", "List of patient that delete From " & Format(DatePickerFrom.Value, "dd/MM/yyyy") & " To " & Format(DatePickTo.Value, "dd/MM/yyyy"))
                ObjCryDonateNormal.SetParameterValue("SubHeader", "Type Of Surgery/Optical Shop".ToString)
                CrysViewerDonation.ReportSource = ObjCryDonateNormal
            End If


        End If

    End Sub
    Private Sub ChViewall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChViewall.CheckedChanged
        If ChViewall.Checked = False Then
            CboDonation.Enabled = True
            InitDonate()
        Else
            CboDonation.Enabled = False
            CboDonation.SelectedIndex = -1
        End If
    End Sub

    Private Sub RadAsGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAsGrid.CheckedChanged
        SplitContainer2.Panel1Collapsed = False
        SplitContainer2.Panel2Collapsed = True
    End Sub

    Private Sub RadAsReports_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAsReports.CheckedChanged
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.Panel2Collapsed = False
    End Sub


    Private Sub GridDonatedDetail_LoadingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridDonatedDetail.LoadingRow
        If e.Row.RowType = Janus.Windows.GridEX.RowType.Record Then
            If e.Row.Cells("IsPatientNill").Value = True Then
                Try
                    e.Row.Cells("Unbound").Value = "0"
                Catch ex As Exception

                End Try
            Else
                e.Row.Cells("Unbound").Value = e.Row.Cells("ReceiptNo").Value
            End If
            If TypeOf e.Row.Cells("HosFee").Value Is DBNull Then
                e.Row.Cells("HosDolar").Value = 0
                e.Row.Cells("HNPaid").Value = 0
                e.Row.Cells("SupportedReil").Value = 0
                e.Row.Cells("SupportedDolar").Value = 0
            Else
                Dim DonateGiveReil As Single = 0
                Dim DonateGiveDolar As Single = 0
                If TypeOf e.Row.Cells("DonatedPay").Value Is DBNull Then
                    DonateGiveDolar = 0
                Else
                    DonateGiveDolar = CType(e.Row.Cells("DonatedPay").Value, Single)
                End If

                DonateGiveReil = Round((DonateGiveDolar * 4000), 2)
                If TypeOf e.Row.Cells("CashTotal").Value Is DBNull Then
                    e.Row.Cells("HosDolar").Value = 0
                    e.Row.Cells("HNPaid").Value = 0
                    e.Row.Cells("SupportedReil").Value = 0
                    e.Row.Cells("SupportedDolar").Value = 0
                Else
                    Dim PaidDolar As Single = CType(e.Row.Cells("CashTotal").Value, Single)
                    Dim PaidReil As Single = Round(PaidDolar * 4000, 2)
                    Dim SupReil As Single
                    Dim SupDolar As Single
                    If CType(e.Row.Cells("DonationID").Value, Decimal) = 7 Then
                        SupReil = 0
                        SupDolar = 0
                    Else
                        If e.Row.Cells("DonatedPay").Value = 0 Then
                            SupReil = 0
                            SupDolar = 0
                        Else
                            SupReil = DonateGiveReil - PaidReil
                            SupDolar = DonateGiveDolar - PaidDolar
                        End If
                        
                    End If
                   
                    e.Row.Cells("HosDolar").Value = Round(e.Row.Cells("HosFee").Value / 4000, 2)
                    e.Row.Cells("HNPaid").Value = PaidReil
                    e.Row.Cells("SupportedReil").Value = SupReil
                    e.Row.Cells("SupportedDolar").Value = SupDolar
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BgLoadDonateRepord_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadDonateRepord.DoWork
        PreviewData()
    End Sub

    Private Sub BgLoadDonateRepord_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadDonateRepord.RunWorkerCompleted
        PicLoading.Visible = False
    End Sub

    Private Sub BgSelectDonate_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgSelectDonate.DoWork

        PreviewDataBySelectedDonate()

    End Sub

    Private Sub BgSelectDonate_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgSelectDonate.RunWorkerCompleted
        PicLoading.Visible = False
    End Sub

    Private Sub BtnUpdateDonate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateDonate.Click
        Try
            Dim FUpdateDonatePaid As New FormUpdateDonatePaid
            FUpdateDonatePaid.LblSaveOption.Text = GridDonatedDetail.GetRow.Cells("ID").Value
            FUpdateDonatePaid.CboDonate.SelectedValue = GridDonatedDetail.GetRow.Cells("DonationID").Value
            FUpdateDonatePaid.TxtReceiptNo.Text = GridDonatedDetail.GetRow.Cells("ReceiptNo").Value
            FUpdateDonatePaid.TxtPatientNo.Text = GridDonatedDetail.GetRow.Cells("HN").Value
            FUpdateDonatePaid.TxtPatientName.Text = GridDonatedDetail.GetRow.Cells("NameKhmer").Value
            FUpdateDonatePaid.CboSurgery.Text = GridDonatedDetail.GetRow.Cells("Operation").Value
            FUpdateDonatePaid.DateDonate.Value = GridDonatedDetail.GetRow.Cells("DateIn").Value
            FUpdateDonatePaid.TxtPatientPaid.Text = GridDonatedDetail.GetRow.Cells("CashTotal").Value
            FUpdateDonatePaid.TxtHospitalFee.Text = GridDonatedDetail.GetRow.Cells("HosFee").Value
            If TypeOf (GridDonatedDetail.GetRow.Cells("DonatedPay").Value) Is DBNull Then
            Else
                FUpdateDonatePaid.TxtDonatePaid.Text = GridDonatedDetail.GetRow.Cells("DonatedPay").Value
            End If
            If FUpdateDonatePaid.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridDonatedDetail.DataSource = DADonation.GetDataByID(FUpdateDonatePaid.LblSaveOption.Text, False)
            End If
            FUpdateDonatePaid.Dispose()
            FUpdateDonatePaid.Close()
        Catch ex As Exception
            MessageBox.Show("Please select donated before update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub RadDonateInOpticalShop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadDonateInOpticalShop.CheckedChanged
        GroupOpticalShop.Enabled = RadDonateInOpticalShop.Checked
        RadGlasessAndMedicince.Checked = RadDonateInOpticalShop.Checked
    End Sub

    Private Sub DeleteDonateSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteDonateSupportToolStripMenuItem.Click
        If MessageBox.Show("Do you want delete donated support?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                If ModDonation.DisableDonatedPay(GridDonatedDetail.GetRow.Cells("ID").Value, True) > 0 Then
                    MessageBox.Show("Delete donated support successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GridDonatedDetail.DataSource = DADonation.GetDataByID(GridDonatedDetail.GetRow.Cells("ID").Value, True)
                End If
            Catch ex As Exception
                MessageBox.Show("Please select donate support.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        End If
    End Sub

    Private Sub UndodeleteDonateSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndodeleteDonateSupportToolStripMenuItem.Click
        If MessageBox.Show("Do you want undo donated support?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                If ModDonation.DisableDonatedPay(GridDonatedDetail.GetRow.Cells("ID").Value, False) > 0 Then
                    MessageBox.Show("Undo donated support successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GridDonatedDetail.DataSource = DADonation.GetDataByID(GridDonatedDetail.GetRow.Cells("ID").Value, False)
                End If
            Catch ex As Exception
                MessageBox.Show("Please select donate support.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        End If
    End Sub

    Private Sub ViewDonateDeletedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDonateDeletedToolStripMenuItem.Click
        If ValidateDateField(DatePickerFrom, "", ErrDonate) = False Then Exit Sub
        If ValidateDateField(DatePickTo, "", ErrDonate) = False Then Exit Sub
        TblDonateTem = DADonation.GetDataByIsDeleteByDate(DatePickerFrom.Value, DatePickTo.Value)
        GridDonatedDetail.DataSource = TblDonateTem
    End Sub

    Private Sub RadReportDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReportDelete.CheckedChanged
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.Panel2Collapsed = False
    End Sub
End Class