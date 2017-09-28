Imports Microsoft.Win32
Public Class MainTakeoInventory
    'Create UI Pannel
    Dim Login As frmLoginInventory
    Dim DAGroupPermistion As New DSUserManagementTableAdapters.VGroupPermistionTableAdapter
    Public Department As UCDepartment
    Public LabourFac As UCLabourFactory
    Public ULabo As UCaseLab
    Public Chemical As UCChemical
    Public UContainer As UCContainer
    Public UItemUnit As UCItemUnit
    Public UVendor As UCVendor
    Public UCate As UCCategories
    Public UCabinet As UCCabinet
    Public UNewReceipt As MainOpticalShop

    Public UIncomeStatementOpticalShop As UCOpticalshopIncomStatement
    Public URequestOrderDep As New UCRequestOrder_V1
    Public UReciepReques As UCReceivedRequest
    Dim UDepToDep As UCDepartReceivedRequest
    Dim UDepartmentCurrenstock As UCDepartCurrentStock

    Dim DashIncomeReport As DashboardIncome
    Dim DashBoardPatientConsult As MainConsuling
    Dim DashBordMedicalCertificate As MainMedicalCertificate
    Dim DSDoctorConsult As New DashboardListCosult
    Dim UVendor_V1 As UCVendor_V1
    Dim UDashboardAdjustStock As UCDashboardAdjustStock
    Dim UPrescriptionList As UCPrescriptionList
    Dim UMedicineOutsideHospital As UCMedicineOutsideHospital
    Dim UCaritasRequestOrder As UCCaritasRequestOrder
    Dim UCountry As UCCountry

    Dim UOPStatisticReport As UCOpticalShopStatistic
    ' Dim UDasboardNil As UCDashBoardNil
    Dim UItemExpiredDate As UCItemExpiredDate

    'User Control for Takeo Eye hospital
    Public PatientPayment As UCPatientPayment
    Public examinationForm As UCRegistrationForm
    Public bed As UCBed
    Public newInPatient As UCNewInPatient
    Public CashReceipDashboad As DashboardPayment
    Public CashCollection As UCashCollection
    Public WeeklySummary As UWeeklyCashCollection
    Public NewOldPatientBook As UCMainNew_Outpatient
    Public OldOutpatient As UCMainOld_Outpatient
    Public Inpatient As UCMainInpatient
    Public ConsultEachProvince As UCEachProvinceAndDistrict
    Public patientReferal As UCPatientReportUtility
    Public patientAchieve As UCAchievePatient
    Public AccountPayAble As UCMainAcountPayable
    Public patientVA As UCMainVA
    Public PatientRefer As CUReferMain
    Public ReportOutPatient As UCOutPatientReport
    Public ReportInpatient As UCInpatientReport
    Public ReportOperation As UCOperationReport
    Public OT_AND_IOLlist As UCOT_AND_IOLList
    Public Doctor As UCDoctor
    Public Diagnosis As UCDiagnosisAndSurgeries
    Dim UserManagement As UCMainUserManagement
    Public ProvinceAndOccupation As UCProvinceAndOccupation
    Dim URunEOD As UCRunEndOfDay
    Dim UShowAllItemBalacne As UIShowAllItemBalanceInDeppartment
    Dim UInhouseUsedITem As UCInhouseUsedItem
    Dim UBarcode As UIBarcodeGenerator
    Dim UReportItemTransaction As UCReportItemTransaction
    Dim URefferral As UCRefferralOfTEH
    Dim DashDoctorConsult As DashboardDoctorConsult
    Dim DashNurseConsult As DashboardNurse
    Dim DsFollowUP As DashboardFollowup
    Dim DashCountMedicine As DashboardCountGlassesAndMedicine
    Dim DashboardHistory As New DashboardPatientHistory
    Dim DasBK As New DashboardBK
    Private Delegate Sub DelShowLoadingPicture(ByVal visible As Boolean)
    Dim DA_Usage As New DSOrdinanceTableAdapters.S_USINAGETableAdapter
    Dim DashMedicince As New DashMedicalCertificate
    Dim DashReferral As New DashboardReferral
    Dim IS_SwitchUser As Boolean = False
    Sub New(ByVal login As frmLoginInventory)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ModGlobleVariable.MainForm = Me
        ModGlobleVariable.FLogin = login
        Me.Login = login
        InitUserControle()
        Application.DoEvents()
        CheckPermistionOnForm()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Sub InitUserControle()
        Login.UpdateLabelStatus("Creating user interface 1.", True)
        Application.DoEvents()
        PatientPayment = New UCPatientPayment(Me)
        Login.UpdateLabelStatus("Creating user interface 2.", True)
        Application.DoEvents()
        examinationForm = New UCRegistrationForm(Me)
        Login.UpdateLabelStatus("Creating user interface 3.", True)
        Application.DoEvents()
        bed = New UCBed
        Login.UpdateLabelStatus("Creating user interface 4.", True)
        Application.DoEvents()
        newInPatient = New UCNewInPatient(Me)
        Login.UpdateLabelStatus("Creating user interface 5.", True)
        Application.DoEvents()
        CashReceipDashboad = New DashboardPayment
        Login.UpdateLabelStatus("Creating user interface 6.", True)
        Application.DoEvents()
        CashCollection = New UCashCollection
        Login.UpdateLabelStatus("Creating user interface 7.", True)
        Application.DoEvents()
        WeeklySummary = New UWeeklyCashCollection
        Login.UpdateLabelStatus("Creating user interface 8.", True)
        Application.DoEvents()
        NewOldPatientBook = New UCMainNew_Outpatient(Me)
        Login.UpdateLabelStatus("Creating user interface 9.", True)
        Application.DoEvents()
        OldOutpatient = New UCMainOld_Outpatient(Me)
        Login.UpdateLabelStatus("Creating user interface 10.", True)
        Application.DoEvents()
        Inpatient = New UCMainInpatient
        Login.UpdateLabelStatus("Creating user interface 11.", True)
        Application.DoEvents()
        ConsultEachProvince = New UCEachProvinceAndDistrict(Me)
        Login.UpdateLabelStatus("Creating user interface 12.", True)
        Application.DoEvents()
        patientReferal = New UCPatientReportUtility()
        Login.UpdateLabelStatus("Creating user interface 13.", True)
        Application.DoEvents()
        patientAchieve = New UCAchievePatient
        Login.UpdateLabelStatus("Creating user interface 14.", True)
        Application.DoEvents()
        patientVA = New UCMainVA
        Login.UpdateLabelStatus("Creating user interface 15.", True)
        Application.DoEvents()
        PatientRefer = New CUReferMain
        Login.UpdateLabelStatus("Creating user interface 16.", True)
        Application.DoEvents()
        ReportOutPatient = New UCOutPatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 17.", True)
        Application.DoEvents()
        ReportInpatient = New UCInpatientReport(Me)
        Login.UpdateLabelStatus("Creating user interface 18.", True)
        Application.DoEvents()
        ReportOperation = New UCOperationReport(Me)
        Login.UpdateLabelStatus("Creating user interface 19.", True)
        Application.DoEvents()
        OT_AND_IOLlist = New UCOT_AND_IOLList
        Login.UpdateLabelStatus("Creating user interface 20.", True)
        Application.DoEvents()
        Doctor = New UCDoctor
        Login.UpdateLabelStatus("Creating user interface 21.", True)
        Application.DoEvents()
        Diagnosis = New UCDiagnosisAndSurgeries
        Login.UpdateLabelStatus("Creating user interface 22.", True)
        Application.DoEvents()
        UserManagement = New UCMainUserManagement
        Login.UpdateLabelStatus("Creating user interface 23.", True)
        Application.DoEvents()
        ProvinceAndOccupation = New UCProvinceAndOccupation
        Login.UpdateLabelStatus("Creating user interface 24.", True)
        Application.DoEvents()
        URunEOD = New UCRunEndOfDay(Me)
        Login.UpdateLabelStatus("Creating user interface 25.", True)
        Application.DoEvents()
        UShowAllItemBalacne = New UIShowAllItemBalanceInDeppartment(Me)
        Login.UpdateLabelStatus("Creating user interface 26.", True)
        Application.DoEvents()
        UInhouseUsedITem = New UCInhouseUsedItem
        Login.UpdateLabelStatus("Creating user interface 27.", True)
        Application.DoEvents()
        UBarcode = New UIBarcodeGenerator
        Login.UpdateLabelStatus("Creating user interface 28.", True)
        Application.DoEvents()
        UReportItemTransaction = New UCReportItemTransaction(Me)
        Login.UpdateLabelStatus("Creating user interface 29.", True)
        Application.DoEvents()
        URefferral = New UCRefferralOfTEH
        Login.UpdateLabelStatus("Creating user interface 40.", True)
        Application.DoEvents()
        ULabo = New UCaseLab


        '=========== Checking user interface
        Department = New UCDepartment
        Login.UpdateLabelStatus("Creating user interface 30.", True)
        Application.DoEvents()
        LabourFac = New UCLabourFactory
        Login.UpdateLabelStatus("Creating user interface 31.", True)
        Application.DoEvents()
        Chemical = New UCChemical
        Login.UpdateLabelStatus("Creating user interface 32.", True)
        Application.DoEvents()
        UContainer = New UCContainer
        Login.UpdateLabelStatus("Creating user interface 33.", True)
        Application.DoEvents()
        UItemUnit = New UCItemUnit
        Login.UpdateLabelStatus("Creating user interface 34.", True)
        Application.DoEvents()
        UVendor = New UCVendor
        Login.UpdateLabelStatus("Creating user interface 35.", True)
        Application.DoEvents()
        UCate = New UCCategories(Me)
        Login.UpdateLabelStatus("Creating user interface 36.", True)
        Application.DoEvents()
        UCabinet = New UCCabinet
        Login.UpdateLabelStatus("Creating user interface 37.", True)
        Application.DoEvents()
        UNewReceipt = New MainOpticalShop(Me)
        Login.UpdateLabelStatus("Creating user interface 38.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 39.", True)
        Application.DoEvents()
        UIncomeStatementOpticalShop = New UCOpticalshopIncomStatement(Me)
        Login.UpdateLabelStatus("Creating user interface 40.", True)
        Application.DoEvents()
        UReciepReques = New UCReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 41.", True)
        Application.DoEvents()
        UDepToDep = New UCDepartReceivedRequest
        Login.UpdateLabelStatus("Creating user interface 42.", True)
        Application.DoEvents()
        UDepartmentCurrenstock = New UCDepartCurrentStock(Me)
        Login.UpdateLabelStatus("Creating user interface 43.", True)
        Application.DoEvents()
        Login.UpdateLabelStatus("Creating user interface 44.", True)
        Application.DoEvents()
        DashIncomeReport = New DashboardIncome
        Login.UpdateLabelStatus("Creating user interface 45.", True)
        DashBoardPatientConsult = New MainConsuling(Me)
        Application.DoEvents()
        DashBordMedicalCertificate = New MainMedicalCertificate(Me)
        UVendor_V1 = New UCVendor_V1
        UDashboardAdjustStock = New UCDashboardAdjustStock
        'Login.UpdateLabelStatus("Creating user interface 46.", True)
        'Application.DoEvents()
        'UPrescriptionList = New UCPrescriptionList(Me)
        'Application.DoEvents()
        'UMedicineOutsideHospital = New UCMedicineOutsideHospital
        'Login.UpdateLabelStatus("Creating user interface 47.", True)
        'Application.DoEvents()
        'UCaritasRequestOrder = New UCCaritasRequestOrder
        Login.UpdateLabelStatus("Creating user interface 48.", True)
        Application.DoEvents()
        UCountry = New UCCountry
        Login.UpdateLabelStatus("Creating user interface 49.", True)
        Application.DoEvents()

        Login.UpdateLabelStatus("Creating user interface 50.", True)
        Application.DoEvents()
        UOPStatisticReport = New UCOpticalShopStatistic(Me)
        Login.UpdateLabelStatus("It is done creatint user interface.", True)
        Application.DoEvents()
        'UDasboardNil = New UCDashBoardNil(Me)
        AccountPayAble = New UCMainAcountPayable(Me)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()

        UItemExpiredDate = New UCItemExpiredDate(Me)
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        DEP_EOD = URunEOD


        ' ======================= User Khmer Soviet ==============================
        DashNurseConsult = New DashboardNurse
        Login.UpdateLabelStatus("Creating user doctor consult.", True)
        Application.DoEvents()

        DashDoctorConsult = New DashboardDoctorConsult
        Login.UpdateLabelStatus("Creating user interface.", True)
        Application.DoEvents()
        DsFollowUP = New DashboardFollowup
        Login.UpdateLabelStatus("Interface create complete.", True)
        Application.DoEvents()
        DashCountMedicine = New DashboardCountGlassesAndMedicine
    End Sub

    Private Sub UpdateVisibleLoading(ByVal v As Boolean)
        ContainerPicloading.Visible = v
    End Sub
    Public Sub StatusLoading(ByVal v As Boolean)
        If Me.Created Then
            RibboStatusBar.Invoke(New DelShowLoadingPicture(AddressOf UpdateVisibleLoading), New Object() {v})
        End If
    End Sub
    Dim DasLaserAndInvest As New DASH_INVEST_LASER
    Private Sub ButtonBarPreferences_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBarPreferences.ItemClick
        Select Case e.Item.Key
            Case "iNewDepartment"
                GeneralAddControl(uiPanelMainContainer, Department, "Department Information.")
                Department.InitDepartment()
            Case "iLabourFac"
                GeneralAddControl(uiPanelMainContainer, LabourFac, "Laboratory Information.")
            Case "Laboratory"
                GeneralAddControl(uiPanelMainContainer, ULabo, "Laboratory Information.")
            Case "iChemical"
                GeneralAddControl(uiPanelMainContainer, Chemical, "Chemical Information.")
            Case "iContainer"
                GeneralAddControl(uiPanelMainContainer, UContainer, "Container Information.")
            Case "iItemUnit"
                GeneralAddControl(uiPanelMainContainer, UItemUnit, "Item Unit Information.")
            Case "iVendors"
                CreateVendorForm()
            Case "iItemCate"
                GeneralAddControl(uiPanelMainContainer, UCate, "Category Information.")
            Case "iCabinet"
                GeneralAddControl(uiPanelMainContainer, UCabinet, "Cabinet Information.")
            Case "iVendorsAndDonators"
                GeneralAddControl(uiPanelMainContainer, UVendor_V1, "Vendors and Donators Information.")
            Case "iCountry"
                GeneralAddControl(uiPanelMainContainer, UCountry, "Country Information.")

                'Eye Admistrator
            Case "Doctor"
                CreateDoctorForm()

            Case "Diagnosis"
                CreateDiagnosisForm()
            Case "Rate"
                CreateRateForm()
            Case "User"
                CreateUserForm()
            Case "ProvinceAndOccupation"
                CreateProviceAndOccupation()
            Case "BackupDatabase"
                Call CreateBackupDBForm()
            Case "ValueOfNewPatient"
                Dim FValNewPatient As New FDefaultNewPatient
                FValNewPatient.ShowDialog()
            Case "Valueofoldpatient"
                Dim FValOldPatient As New FDefaulOldPatient
                FValOldPatient.ShowDialog()
            Case "ReferralofTEH"

                GeneralAddControl(uiPanelMainContainer, URefferral, "Patient Referral pararmenter.")
            Case "UsageLabel"
                Dim FUsage As New UsageLabel
                FUsage.ShowDialog()
            Case "LaserInvestigate"
                GeneralAddControl(uiPanelMainContainer, DasLaserAndInvest, "Investigate Parameter")
        End Select
    End Sub


    Sub CreateVendorForm()
        'uiPanelMainContainer.Controls.Clear()
        'UItemUnit.Dock = DockStyle.Fill
        'Me.Cursor = Cursors.WaitCursor
        'uiPanelMainContainer.Controls.Add(UVendor_V1)
        'Me.Cursor = Cursors.Default
        'uiPanel2.Text = "Vendor Information"
    End Sub





    Sub GeneralAddControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default
        uiPanel2.Text = Info


    End Sub
    Private Sub MainTakeoInventory_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If IS_SwitchUser = False Then
            Application.Exit()
        End If

    End Sub

    Private Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Login.txtUserName.Text = ""
        Login.txtPassword.Text = ""
        Login.txtUserName.Focus()
        Login.Show()
        Me.Close()
    End Sub

    Private Sub MainTakeoInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBtnSwitchUser.Text = "Log out user: " & UserGlobleVariable.EMPLOYEE_NAME.ToUpper
        BtnDateTimeServer.Text = "Server Date: " & Format(ModGlobleVariable.GeteDateServer, "dd/MM/yyyy")
        LblDepartmentLogin.Text = "User in department: " & UserGlobleVariable.DEPART_NAME.ToUpper

    End Sub

   
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnExit.Click
        If MessageBox.Show("Do you want to exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnIncomeStatment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GeneralAddControl(uiPanelMainContainer, UIncomeStatementOpticalShop, "Income Statement.")
        'GeneralAddControl(uiPanelMainContainer, UMainIncomestatment, "Incomstatment Information.")
    End Sub
    Private Sub ButtonMainInventory_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonMainInventory.ItemClick
        Select Case e.Item.Key
            Case "iItemCategory"
                GeneralAddControl(uiPanelMainContainer, UCate, "Detail information of Item.")
            Case "IViewItemsAddDepartment"
                GeneralAddControl(uiPanelMainContainer, UShowAllItemBalacne, "Show Balance information for all Departments.")
            Case "IRunEndOfday"
                GeneralAddControl(uiPanelMainContainer, URunEOD, "Main inventory Run End Of Day.")
            Case "IMSInhouseUsedItem"
                GeneralAddControl(uiPanelMainContainer, UInhouseUsedITem, "Main Stock In-house Used Item Information.")
            Case "IBarcode"
                GeneralAddControl(uiPanelMainContainer, UBarcode, "Generated Barcode For Item Information.")
            Case "iItemTransactionReport"
                GeneralAddControl(uiPanelMainContainer, UReportItemTransaction, "Reports Item Transaction Information.")
            Case "iCabinet"
                GeneralAddControl(uiPanelMainContainer, UCabinet, "Cabinet Information.")

            Case "iMainTODep"
                GeneralAddControl(uiPanelMainContainer, URequestOrderDep, "Information of Request Order from Department.")
            Case "iVeiwDepRequests"
                GeneralAddControl(uiPanelMainContainer, UReciepReques, "View Department Request information.")
            Case "iDashboardAdjustStock"
                GeneralAddControl(uiPanelMainContainer, UDashboardAdjustStock, "Department items adjust stock.")
            Case "iHospitalRequestOrder"
                GeneralAddControl(uiPanelMainContainer, UCaritasRequestOrder, "Hospital request order to Caritas.")
            Case "iItemExpiredDate"
                GeneralAddControl(uiPanelMainContainer, UItemExpiredDate, "Hospital Item Expired Date List.")

        End Select
    End Sub


    Private Sub ButtonMainRequest_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs)
        Select Case e.Item.Key
            Case "iMainTODep"
                GeneralAddControl(uiPanelMainContainer, URequestOrderDep, "View main stock request from department information.")
            Case "iVeiwDepRequests"
                GeneralAddControl(uiPanelMainContainer, UReciepReques, "View Department Request information.")
            Case "iDashboardAdjustStock"
                GeneralAddControl(uiPanelMainContainer, UDashboardAdjustStock, "Department items adjust stock.")
            Case "iHospitalRequestOrder"
                GeneralAddControl(uiPanelMainContainer, UCaritasRequestOrder, "Hospital request order to Caritas.")

        End Select
    End Sub

    Private Sub ButtonBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles MainuDepartmentInventory.ItemClick

        Select Case e.Item.Key
            Case "iDepRequest"
                GeneralAddControl(uiPanelMainContainer, URequestOrderDep, "Request department information.")
            Case "iRequestDepToDep"
                GeneralAddControl(uiPanelMainContainer, UDepToDep, "Request department to department information.")
            Case "iCurrentStockDep"
                GeneralAddControl(uiPanelMainContainer, UDepartmentCurrenstock, "Current stock department information.")
            Case "IDepEOD"
                GeneralAddControl(uiPanelMainContainer, URunEOD, "Department run end of day information.")
            Case "IDInhouseUsedItem"
                GeneralAddControl(uiPanelMainContainer, UInhouseUsedITem, "Department In-house used item information.")
            Case "iDepItemTransactionReport"
                GeneralAddControl(uiPanelMainContainer, UReportItemTransaction, "Department Reports Item Transaction Information..")
            Case "iCabinet"
                GeneralAddControl(uiPanelMainContainer, UCabinet, "Cabinet Information.")
        End Select

    End Sub


    Sub CheckPermistionOnForm()
        'Try
        Dim tblPermistion As DataTable = ModUser.GetMenuPermission(USER_NAME)
        Dim indexBar As Integer
        Dim indexSubBar As Integer
        Dim indexMenu As Integer
        Application.DoEvents()


        '--- Department Permission
        For indexBar = 0 To MainuDepartmentInventory.Groups.Count - 1
            For indexSubBar = 0 To MainuDepartmentInventory.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If MainuDepartmentInventory.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        MainuDepartmentInventory.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next
        Login.UpdateLabelStatus("Checking user permistion...", True)

        '--- OpticalShop Permission        
        For indexBar = 0 To ButtonBarOpticalShop.Groups.Count - 1
            For indexSubBar = 0 To ButtonBarOpticalShop.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButtonBarOpticalShop.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        ButtonBarOpticalShop.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next

        '--- MAIN INVEN Permission 
        For indexBar = 0 To ButtonMainInventory.Groups.Count - 1
            For indexSubBar = 0 To ButtonMainInventory.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButtonMainInventory.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        ButtonMainInventory.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next

        '--- Pharmacy Permission
        For indexBar = 0 To ButtonBarPharmacy.Groups.Count - 1
            For indexSubBar = 0 To ButtonBarPharmacy.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButtonBarPharmacy.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        ButtonBarPharmacy.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next

        '--- Preferences Permission        
        For indexBar = 0 To ButtonBarPreferences.Groups.Count - 1
            For indexSubBar = 0 To ButtonBarPreferences.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If ButtonBarPreferences.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        ButtonBarPreferences.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                    End If
                Next
            Next
        Next


        '--- Takeo Eye Operation Permission
        For indexBar = 0 To BottonBarMain.Groups.Count - 1
            For indexSubBar = 0 To BottonBarMain.Groups(indexBar).Items.Count - 1
                For indexMenu = 0 To tblPermistion.Rows.Count - 1
                    Login.UpdateLabelStatus("Checking user permistion...", True)
                    Application.DoEvents()
                    'MsgBox(BottonBarMain.Groups(indexBar).Items(indexSubBar).Key & "    " & tblPermistion.Rows(indexMenu).Item(0))                    
                    If BottonBarMain.Groups(indexBar).Items(indexSubBar).Key = tblPermistion.Rows(indexMenu).Item(0) Then
                        'Login.UpdateLabelStatus("Checking menu name " & BottonBarMain.Groups(indexBar).Items(indexSubBar).Text, True)
                        'Application.DoEvents()
                        BottonBarMain.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                        'For i As Integer = 0 To TBLACCESS_ROLE.Rows.Count - 1
                        '    With TBLACCESS_ROLE.Rows(i)
                        '        If .Item(0) = "Wards" And BottonBarMain.Groups(indexBar).Items(indexSubBar).Key = "PatientPayment" Then    '------------Ward permission on Patient Payment on weekend----------
                        '            If Today.DayOfWeek = DayOfWeek.Saturday Or Today.DayOfWeek = DayOfWeek.Sunday Then
                        '                BottonBarMain.Groups(indexBar).Items(indexSubBar).Enabled = True
                        '            End If
                        '        Else      '----------------------------For all permission refered to roles----------------------------------
                        '            BottonBarMain.Groups(indexBar).Items(indexSubBar).Enabled = Janus.Windows.UI.InheritableBoolean.True
                        '        End If
                        '    End With
                        'Next
                    End If
                Next
            Next
        Next

        'Catch ex As Exception

        'End Try

        'Dim TblPermistionTem As DataTable = DAGroupPermistion.GetDataByGroupNo(UserGlobleVariable.DEPART_ID)
        'Dim IndexBar As Integer
        'Dim PanelGroup As Janus.Windows.UI.Dock.UIPanelGroup = UiPanelManager1.Panels(0)
        'For IndexBar = 0 To PanelGroup.Panels.Count - 1
        '    For Each row As DataRow In TblPermistionTem.Rows
        '        If row("MenuKey") = PanelGroup.Panels(IndexBar).Name Then
        '            PanelGroup.Panels(IndexBar).Enabled = True
        '        End If
        '    Next
        'Next

    End Sub

    Private Sub BtnChangePWD_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Dim FChangePwd As New FRMChangePwdInventory
        FChangePwd.LblUserID.Text = UserGlobleVariable.USER_ID
        FChangePwd.TxtLoginName.Text = USER_NAME
        FChangePwd.ShowDialog()
    End Sub




    Private Sub MenuBarLeft_SelectedPanelChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Dock.PanelActionEventArgs) Handles MenuBarLeft.SelectedPanelChanged
        'Select Case e.Panel.Name
        '    Case "uiMainInventory"
        '        If e.Panel.Enabled = False Then
        '        Else
        '            GeneralAddControl(uiPanelMainContainer, UCate, "Item Inventory Information.")
        '        End If
        '    Case "uiDepartmentRequest"
        '        If e.Panel.Enabled = False Then
        '        Else
        '            GeneralAddControl(uiPanelMainContainer, URequestOrderDep, "Request department information.")
        '        End If
        '    Case "uiOpticalshop"
        '        If e.Panel.Enabled = False Then
        '        Else
        '            GeneralAddControl(uiPanelMainContainer, UNewReceipt, "New Receipt Information.")
        '        End If
        '    Case "uiPreferences"
        '        If e.Panel.Enabled = False Then
        '        Else
        '            GeneralAddControl(uiPanelMainContainer, Department, "Department Information.")
        '            Department.InitDepartment()
        '        End If
        '    Case "uiPharmacy"
        '        If e.Panel.Enabled = False Then
        '        Else
        '            GeneralAddControl(uiPanelMainContainer, UPrescriptionList, "Prescription List.")
        '        End If
        'End Select
    End Sub




    Private Sub BottonBarMain_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BottonBarMain.ItemClick
        Select Case e.Item.Key
            Case "PatientPayment"
                CreatePaymentForm()
            Case "PaymentOldPatien"
                CreatePaymentOldPatien()
            Case "PaymentInPatient"
                CreatePaymentInPatientForm()
            Case "NewOutpatient"
                CreateNewOut_patientForm()
            Case "OldOutpatient"
                CreateOldOutpatientForm()
            Case "MonthlyInPatient"
                CreateMonthlyInPatient()
                'CreateInPatientForm()
            Case "ConProvince"
                CreateConProvinceForm()
            Case "PatientReferal"
                CreatePatientReferal()
            Case "PatientAchieve"
                CreatePatientAchieve()
            Case "PatientConsult"
                StatusLoading(True)
                Application.DoEvents()
                GeneralAddControl(uiPanelMainContainer, DashBoardPatientConsult, "Patient consulting.")
                StatusLoading(False)
            Case "MedicalCertificate"
                GeneralAddControl(uiPanelMainContainer, DashBordMedicalCertificate, "Medical Certificate.")
            Case "AccountPayable"
                CreateAccountPayable()
                'Cash collection 
            Case "ReceiptPayment"
                CreateReceiptPaymentForm()
            Case "ListDoctorConsult"
                GeneralAddControl(uiPanelMainContainer, DSDoctorConsult, "Doctor Cosultation list")
            Case "IncomeReport"
                StatusLoading(True)
                Application.DoEvents()
                GeneralAddControl(uiPanelMainContainer, DashIncomeReport, "Income Report")
                StatusLoading(False)
            Case "IncomeStatment"
                StatusLoading(True)
                Application.DoEvents()
                GeneralAddControl(uiPanelMainContainer, UIncomeStatementOpticalShop, "Income Statement.")
                StatusLoading(False)
            Case "CashCollection"
                CreateCashCollectionForm()
            Case "WeeklySummary"
                CreateWeeklySummaryForm()
            Case "VAPatient"
                CreateVAPatientForm()
            Case "ReferTo"
                CreatePatientRefer()
                ' Hospital Report
            Case "MonthlyOutpatient"
                CreateMonthlyOutpatient()
            Case "MonthlyInPatient"
                CreateMonthlyInPatient()
            Case "MonthlyOperation"
                CreateMonthlyOperation()


                ' Ward 
            Case "CheckBed"
                'Me.Cursor = Cursors.WaitCursor
                'SplitSubForm.Panel2.Controls.Clear()
                'bed.Dock = DockStyle.Fill
                'SplitSubForm.Panel2.Controls.Add(bed)
                'Me.Cursor = Cursors.Default
            Case "NewInPatient"
                Dim FWardPreview As New FRMWardPreview
                FWardPreview.ShowDialog()
                FWardPreview.Close()
                FWardPreview.Dispose()
                'CreateNewInPatient()
                'Operation
            Case "RegisInOT"
                CreateOT_AND_IOL()
            Case "PatientDischarged"
                CreatePatientDischarged()
                'Admistrator
            Case "Doctor"
                CreateDoctorForm()

            Case "Diagnosis"
                CreateDiagnosisForm()
            Case "Rate"
                CreateRateForm()
            Case "User"
                CreateUserForm()
            Case "ProvinceAndOccupation"
                CreateProviceAndOccupation()
            Case "BackupDatabase"
                Call CreateBackupDBForm()
                ' Tab User Utility
            Case "ChangePassword"
                CreateChagePasswordForm()
            Case "LockSystem"
                CreateLockSystem()
            Case "SwitchUser"
                CreateSwitchUser()
                'Tab user close
                ' ========================================== New Update For Khmer Soviet =========================
            Case "PatientFollowUp"

                GeneralAddControl(uiPanelMainContainer, DsFollowUP, "List of Patient followup...")
            Case "NurseConsult"
                GeneralAddControl(uiPanelMainContainer, DashNurseConsult, "Nourse Consult ...")
            Case "DoctorConsut"
                GeneralAddControl(uiPanelMainContainer, DashDoctorConsult, "Doctor Consult...")
            Case "CountMG"
                GeneralAddControl(uiPanelMainContainer, DashCountMedicine, "Count medicine and glasses...")
            Case "PatientHistory"

                GeneralAddControl(uiPanelMainContainer, DashboardHistory, "Patient Dashbord Consultation...")
            Case "MedicalCertificates"
                GeneralAddControl(uiPanelMainContainer, DashMedicince, "Patient Dashbord Consultation...")
            Case "PatientReferral"
                GeneralAddControl(uiPanelMainContainer, DashReferral, "Patient Referral List...")
        End Select
    End Sub
    Sub CreateNewOut_patientForm()
        GeneralAddControl(uiPanelMainContainer, NewOldPatientBook, "Old Patient Books...")
    End Sub
    Sub CreateOldOutpatientForm()
        GeneralAddControl(uiPanelMainContainer, OldOutpatient, "Ophthalmology Department")
    End Sub
    Sub CreateInPatientForm()
        GeneralAddControl(uiPanelMainContainer, Inpatient, "Ophthalmology Department")
    End Sub
    Sub CreateConProvinceForm()
        GeneralAddControl(uiPanelMainContainer, ConsultEachProvince, "Ophthalmology Department")
    End Sub
    Sub CreatePatientReferal()
        GeneralAddControl(uiPanelMainContainer, patientReferal, "Ophthalmology Department")
    End Sub
    Sub CreatePatientAchieve()
        GeneralAddControl(uiPanelMainContainer, patientAchieve, "Ophthalmology Department")
    End Sub
    Sub CreateAccountPayable()
        GeneralAddControl(uiPanelMainContainer, AccountPayAble, "Ophthalmology Department")
    End Sub

    Sub CreateReceiptPaymentForm()
        GeneralAddControl(uiPanelMainContainer, CashReceipDashboad, "Ophthalmology Department")
    End Sub
    Sub CreateCashCollectionForm()
        GeneralAddControl(uiPanelMainContainer, CashCollection, "Ophthalmology Department")
    End Sub
    Sub CreateWeeklySummaryForm()
        GeneralAddControl(uiPanelMainContainer, WeeklySummary, "Ophthalmology Department")
    End Sub
    Sub CreateVAPatientForm()
        GeneralAddControl(uiPanelMainContainer, patientVA, "Ophthalmology Department")

    End Sub
    Sub CreatePatientRefer()
        GeneralAddControl(uiPanelMainContainer, PatientRefer, "Ophthalmology Department")

    End Sub
    Sub CreateMonthlyInPatient()
        GeneralAddControl(uiPanelMainContainer, ReportInpatient, "Ophthalmology Department")
    End Sub
    Sub CreateMonthlyOperation()
        GeneralAddControl(uiPanelMainContainer, ReportOperation, "Ophthalmology Department")
    End Sub

    Sub CreateMonthlyOutpatient()
        GeneralAddControl(uiPanelMainContainer, ReportOutPatient, "Ophthalmology Department")
    End Sub
    Sub CreateRegisForm()
        GeneralAddControl(uiPanelMainContainer, examinationForm, "Ophthalmology Department")
    End Sub

    Sub CreateOT_AND_IOL()
        GeneralAddControl(uiPanelMainContainer, OT_AND_IOLlist, "Ophthalmology Department")

    End Sub

    Sub CreatePatientDischarged()
        Dim frmPDischarged As New FormPatientDischarged
        frmPDischarged.ShowDialog()
    End Sub

    Sub CreatePaymentForm()
        GeneralAddControl(uiPanelMainContainer, PatientPayment, "Ophthalmology Department")
    End Sub

    Sub CreatePaymentOldPatien()
        Dim FOldPatientReceipt As New frmOldOutPatientReceipt
        FOldPatientReceipt.ShowDialog()
    End Sub
    Sub CreatePaymentInPatientForm()
        Dim FInpatientReceipt As New frmInpatientReceipt
        FInpatientReceipt.ShowDialog()
    End Sub
    Sub CreateDoctorForm()
        GeneralAddControl(uiPanelMainContainer, Doctor, "Ophthalmology Department")
    End Sub
    Sub CreateNewInPatient()
        GeneralAddControl(uiPanelMainContainer, newInPatient, "Ophthalmology Department")
    End Sub
    Sub CreateRateForm()
        Dim frmRate As New frmRates
        frmRate.ShowDialog()
    End Sub

    Sub CreateDiagnosisForm()
        GeneralAddControl(uiPanelMainContainer, Diagnosis, "Ophthalmology Department")
    End Sub

    Sub CreateUserForm()
        GeneralAddControl(uiPanelMainContainer, UserManagement, "Ophthalmology Department")
    End Sub
    Sub CreateProviceAndOccupation()
        GeneralAddControl(uiPanelMainContainer, ProvinceAndOccupation, "Ophthalmology Department")
    End Sub

    Sub CreateBackupDBForm()
        Dim frmBackUpDB As New frmBackupDatabase
        frmBackUpDB.ShowDialog()
    End Sub

    ' Tab User Utility
    Sub CreateChagePasswordForm()
        Dim FChangeUserPwd As New FrmChangeUserPWD
        FChangeUserPwd.TxtUserName.Text = USER_NAME
        FChangeUserPwd.LblUserID.Text = USER_ID
        FChangeUserPwd.ShowDialog()
    End Sub
    Sub CreateLockSystem()
        Dim FLockSys As New FRMLockSystem(Me)
        FLockSys.ShowDialog()
    End Sub
    Sub CreateSwitchUser()
        FLogin.txtUserName.Text = ""
        FLogin.txtPassword.Text = ""
        FLogin.txtUserName.Select()
        FLogin.txtUserName.Focus()
        FLogin.Cursor = Cursors.Default
        FLogin.Show()
        IS_SwitchUser = True
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub DBtnSwitchUser_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnSwitchUser.Click
        CreateSwitchUser()
    End Sub

    Private Sub DBtnLockSystem_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnLockSystem.Click
        CreateLockSystem()
    End Sub

    Private Sub DBtnChangePassword_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles DBtnChangePassword.Click
        CreateChagePasswordForm()
    End Sub

    Private Sub BtnTab_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnTab.Click
        Try
            MenuBarLeft.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.Tab
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnOutLookNavigator_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnOutLookNavigator.Click
        Try
            MenuBarLeft.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnHorizontalTiles_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Try
            MenuBarLeft.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnVerticalTiles_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Try
            MenuBarLeft.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnOfficeTaskPane_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs)
        Try
            MenuBarLeft.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OfficeTaskPane
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ButtonBarOpticalShop_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBarOpticalShop.ItemClick
        Select Case e.Item.Key
            Case "CreateInvoice"
                StatusLoading(True)
                Application.DoEvents()
                GeneralAddControl(uiPanelMainContainer, UNewReceipt, "Receipt Information")
                StatusLoading(False)
            Case "NewItemOutsite"
                StatusLoading(True)
                Application.DoEvents()
                Dim fItemOutSite As New frmItemOutsideHospital
                StatusLoading(False)
                fItemOutSite.ShowDialog()
            Case "IncomeStatment"
                GeneralAddControl(uiPanelMainContainer, UIncomeStatementOpticalShop, "Income Statement.")
            Case "Payment"
                StatusLoading(True)
                Application.DoEvents()
                GeneralAddControl(uiPanelMainContainer, DashIncomeReport, "Payment Optical Shop Information.")
                StatusLoading(False)
            Case "StatisticReports"
                GeneralAddControl(uiPanelMainContainer, UOPStatisticReport, "Statistic Reports.")
                'Case "DonationReport"
                '    GeneralAddControl(uiPanelMainContainer, UDonationReport, "Donation Report.")
            Case "NilDashBoard"
                'GeneralAddControl(uiPanelMainContainer, UDasboardNil, "Optical Shop Nil.")

        End Select
    End Sub

    Private Sub ButtonBar1_ItemClick_1(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBarPharmacy.ItemClick
        Select Case e.Item.Key
            Case "Prescription"
                GeneralAddControl(uiPanelMainContainer, UPrescriptionList, "Prescription List.")
            Case "MedicineOutSideHospital"
                GeneralAddControl(uiPanelMainContainer, UMedicineOutsideHospital, "Medicine outside hospital.")
        End Select
    End Sub

    Dim connectionStatus As Boolean
    Private Sub InitCheckConnection_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles InitCheckConnection.DoWork
        If My.Computer.Network.IsAvailable Then
            connectionStatus = True
        Else
            connectionStatus = False
        End If
    End Sub

    Private Sub InitCheckConnection_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles InitCheckConnection.RunWorkerCompleted
        If connectionStatus = True Then
        Else

        End If
        InitCheckConnection.RunWorkerAsync()
    End Sub

    Private Sub MainTakeoInventory_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If IS_SwitchUser = False Then
            Application.Exit()
        End If
    End Sub

    Private Sub BottonBarMain_GroupSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottonBarMain.GroupSelected
        GeneralAddControl(uiPanelMainContainer, DasBK, "Ophthalmology Department")
    End Sub
End Class