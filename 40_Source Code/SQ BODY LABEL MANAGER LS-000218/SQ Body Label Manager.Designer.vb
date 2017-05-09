<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpbxGPIB_TEGAM = New System.Windows.Forms.GroupBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnOPEN = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.btnREAD = New System.Windows.Forms.Button()
        Me.txtbReadGPIB = New System.Windows.Forms.TextBox()
        Me.txtbWriteGPIB = New System.Windows.Forms.TextBox()
        Me.btnWRITE = New System.Windows.Forms.Button()
        Me.btnTERMINATE = New System.Windows.Forms.Button()
        Me.btnTRIGGER = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.grpbxINIT = New System.Windows.Forms.GroupBox()
        Me.txtbLOGfolder = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbPRNfolder = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbPRINTERstatus = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbPRN_TEMPLATE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbPART_NUMBER_SELECT = New System.Windows.Forms.TextBox()
        Me.txtbBARCODEstatus = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbTEGAMstatus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbDBfilepath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbSHOP_PACK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtbLOWERresistanceLIMIT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbUPPERresistanceLIMIT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbRESISTANCE = New System.Windows.Forms.TextBox()
        Me.txtbDATECODE = New System.Windows.Forms.TextBox()
        Me.txtbIEC_IR = New System.Windows.Forms.TextBox()
        Me.txtbUL_DC_IR = New System.Windows.Forms.TextBox()
        Me.txtbUL_AC_IR = New System.Windows.Forms.TextBox()
        Me.txtbAMPERAGE = New System.Windows.Forms.TextBox()
        Me.txtbPART_NUMBER = New System.Windows.Forms.TextBox()
        Me.btnUSBprintZPL = New System.Windows.Forms.Button()
        Me.grpbxBarcodeScannerST1A = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btnOpenBarcodeDeviceST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDsOFFST1A = New System.Windows.Forms.Button()
        Me.txtbBCDevice_ReadST1A = New System.Windows.Forms.TextBox()
        Me.btnBCDevice_LEDGreenONST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDRedONST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_BeepST1A = New System.Windows.Forms.Button()
        Me.btnBCDeviceEventSubscribeST1A = New System.Windows.Forms.Button()
        Me.btnCloseBarcodeDeviceST1A = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbEXITapp = New System.Windows.Forms.Button()
        Me.txtbLOG = New System.Windows.Forms.TextBox()
        Me.bkgworkSleep1 = New System.ComponentModel.BackgroundWorker()
        Me.prgsbarSleep1 = New System.Windows.Forms.ProgressBar()
        Me.grpbxGPIB_TEGAM.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grpbxINIT.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxBarcodeScannerST1A.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxGPIB_TEGAM
        '
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label42)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label28)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnOPEN)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnCLOSE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnREAD)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbReadGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbWriteGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnWRITE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnTERMINATE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnTRIGGER)
        Me.grpbxGPIB_TEGAM.Location = New System.Drawing.Point(828, 317)
        Me.grpbxGPIB_TEGAM.Name = "grpbxGPIB_TEGAM"
        Me.grpbxGPIB_TEGAM.Size = New System.Drawing.Size(567, 80)
        Me.grpbxGPIB_TEGAM.TabIndex = 57
        Me.grpbxGPIB_TEGAM.TabStop = False
        Me.grpbxGPIB_TEGAM.Text = "TEGAM 1750 ST1A"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label42.Location = New System.Drawing.Point(277, 35)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 13)
        Me.Label42.TabIndex = 55
        Me.Label42.Text = "GPIB Commands"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(6, 36)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Initialize TEGAM 1750"
        '
        'btnOPEN
        '
        Me.btnOPEN.Location = New System.Drawing.Point(9, 52)
        Me.btnOPEN.Name = "btnOPEN"
        Me.btnOPEN.Size = New System.Drawing.Size(86, 23)
        Me.btnOPEN.TabIndex = 0
        Me.btnOPEN.Text = "Open GPIB"
        Me.btnOPEN.UseVisualStyleBackColor = True
        '
        'btnCLOSE
        '
        Me.btnCLOSE.Location = New System.Drawing.Point(200, 53)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(74, 22)
        Me.btnCLOSE.TabIndex = 1
        Me.btnCLOSE.Text = "Close GPIB"
        Me.btnCLOSE.UseVisualStyleBackColor = True
        '
        'btnREAD
        '
        Me.btnREAD.Location = New System.Drawing.Point(417, 52)
        Me.btnREAD.Name = "btnREAD"
        Me.btnREAD.Size = New System.Drawing.Size(45, 21)
        Me.btnREAD.TabIndex = 8
        Me.btnREAD.Text = "Read"
        Me.btnREAD.UseVisualStyleBackColor = True
        '
        'txtbReadGPIB
        '
        Me.txtbReadGPIB.Location = New System.Drawing.Point(468, 53)
        Me.txtbReadGPIB.Name = "txtbReadGPIB"
        Me.txtbReadGPIB.ReadOnly = True
        Me.txtbReadGPIB.Size = New System.Drawing.Size(94, 20)
        Me.txtbReadGPIB.TabIndex = 9
        '
        'txtbWriteGPIB
        '
        Me.txtbWriteGPIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtbWriteGPIB.Location = New System.Drawing.Point(280, 53)
        Me.txtbWriteGPIB.Name = "txtbWriteGPIB"
        Me.txtbWriteGPIB.Size = New System.Drawing.Size(32, 20)
        Me.txtbWriteGPIB.TabIndex = 10
        Me.txtbWriteGPIB.Text = "Q1X"
        '
        'btnWRITE
        '
        Me.btnWRITE.Location = New System.Drawing.Point(318, 52)
        Me.btnWRITE.Name = "btnWRITE"
        Me.btnWRITE.Size = New System.Drawing.Size(42, 22)
        Me.btnWRITE.TabIndex = 11
        Me.btnWRITE.Text = "Write"
        Me.btnWRITE.UseVisualStyleBackColor = True
        '
        'btnTERMINATE
        '
        Me.btnTERMINATE.Location = New System.Drawing.Point(101, 53)
        Me.btnTERMINATE.Name = "btnTERMINATE"
        Me.btnTERMINATE.Size = New System.Drawing.Size(93, 22)
        Me.btnTERMINATE.TabIndex = 12
        Me.btnTERMINATE.Text = "Term. Asynch. "
        Me.btnTERMINATE.UseVisualStyleBackColor = True
        '
        'btnTRIGGER
        '
        Me.btnTRIGGER.Location = New System.Drawing.Point(366, 51)
        Me.btnTRIGGER.Name = "btnTRIGGER"
        Me.btnTRIGGER.Size = New System.Drawing.Size(45, 22)
        Me.btnTRIGGER.TabIndex = 14
        Me.btnTRIGGER.Text = "Trig."
        Me.btnTRIGGER.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(829, 22)
        Me.StatusStrip1.TabIndex = 61
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(15, 17)
        Me.ToolStripStatusLabel1.Text = "--"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.StartToolStripMenuItem.Text = "INICIO..."
        '
        'StartToolStripMenuItem1
        '
        Me.StartToolStripMenuItem1.Name = "StartToolStripMenuItem1"
        Me.StartToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.StartToolStripMenuItem1.Text = "INICIO"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "SALIR (Exit)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AboutToolStripMenuItem.Text = "Ayuda"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ViewHelpToolStripMenuItem.Text = "Ver Ayuda"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.AboutToolStripMenuItem1.Text = "Acerca de..."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 24)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'grpbxINIT
        '
        Me.grpbxINIT.Controls.Add(Me.txtbLOGfolder)
        Me.grpbxINIT.Controls.Add(Me.Label17)
        Me.grpbxINIT.Controls.Add(Me.txtbPRNfolder)
        Me.grpbxINIT.Controls.Add(Me.Label16)
        Me.grpbxINIT.Controls.Add(Me.txtbPRINTERstatus)
        Me.grpbxINIT.Controls.Add(Me.Label15)
        Me.grpbxINIT.Controls.Add(Me.Label14)
        Me.grpbxINIT.Controls.Add(Me.txtbPRN_TEMPLATE)
        Me.grpbxINIT.Controls.Add(Me.Label13)
        Me.grpbxINIT.Controls.Add(Me.txtbPART_NUMBER_SELECT)
        Me.grpbxINIT.Controls.Add(Me.txtbBARCODEstatus)
        Me.grpbxINIT.Controls.Add(Me.Label12)
        Me.grpbxINIT.Controls.Add(Me.txtbTEGAMstatus)
        Me.grpbxINIT.Controls.Add(Me.Label3)
        Me.grpbxINIT.Controls.Add(Me.txtbDBfilepath)
        Me.grpbxINIT.Controls.Add(Me.Label2)
        Me.grpbxINIT.Controls.Add(Me.txtbSHOP_PACK)
        Me.grpbxINIT.Controls.Add(Me.Label1)
        Me.grpbxINIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.grpbxINIT.Location = New System.Drawing.Point(11, 27)
        Me.grpbxINIT.Name = "grpbxINIT"
        Me.grpbxINIT.Size = New System.Drawing.Size(810, 166)
        Me.grpbxINIT.TabIndex = 81
        Me.grpbxINIT.TabStop = False
        Me.grpbxINIT.Text = "CONFIGURACION INICIAL"
        '
        'txtbLOGfolder
        '
        Me.txtbLOGfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbLOGfolder.Location = New System.Drawing.Point(639, 63)
        Me.txtbLOGfolder.Name = "txtbLOGfolder"
        Me.txtbLOGfolder.ReadOnly = True
        Me.txtbLOGfolder.Size = New System.Drawing.Size(158, 22)
        Me.txtbLOGfolder.TabIndex = 97
        Me.txtbLOGfolder.Text = "--"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(462, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(170, 16)
        Me.Label17.TabIndex = 96
        Me.Label17.Text = "Archivo Bitacora (Log) :"
        '
        'txtbPRNfolder
        '
        Me.txtbPRNfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPRNfolder.Location = New System.Drawing.Point(639, 38)
        Me.txtbPRNfolder.Name = "txtbPRNfolder"
        Me.txtbPRNfolder.ReadOnly = True
        Me.txtbPRNfolder.Size = New System.Drawing.Size(158, 22)
        Me.txtbPRNfolder.TabIndex = 95
        Me.txtbPRNfolder.Text = "--"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(467, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(165, 16)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Folder Plantillas PRN :"
        '
        'txtbPRINTERstatus
        '
        Me.txtbPRINTERstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPRINTERstatus.Location = New System.Drawing.Point(639, 137)
        Me.txtbPRINTERstatus.Name = "txtbPRINTERstatus"
        Me.txtbPRINTERstatus.ReadOnly = True
        Me.txtbPRINTERstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbPRINTERstatus.TabIndex = 93
        Me.txtbPRINTERstatus.Text = "--"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(477, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 16)
        Me.Label15.TabIndex = 92
        Me.Label15.Text = "Printer ZT410 Status :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(24, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 25)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Plantilla PRN:"
        '
        'txtbPRN_TEMPLATE
        '
        Me.txtbPRN_TEMPLATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPRN_TEMPLATE.Location = New System.Drawing.Point(189, 109)
        Me.txtbPRN_TEMPLATE.Name = "txtbPRN_TEMPLATE"
        Me.txtbPRN_TEMPLATE.ReadOnly = True
        Me.txtbPRN_TEMPLATE.Size = New System.Drawing.Size(252, 31)
        Me.txtbPRN_TEMPLATE.TabIndex = 90
        Me.txtbPRN_TEMPLATE.Text = "--"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(6, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 25)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Num. de Parte :"
        '
        'txtbPART_NUMBER_SELECT
        '
        Me.txtbPART_NUMBER_SELECT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPART_NUMBER_SELECT.Location = New System.Drawing.Point(189, 75)
        Me.txtbPART_NUMBER_SELECT.Name = "txtbPART_NUMBER_SELECT"
        Me.txtbPART_NUMBER_SELECT.ReadOnly = True
        Me.txtbPART_NUMBER_SELECT.Size = New System.Drawing.Size(252, 31)
        Me.txtbPART_NUMBER_SELECT.TabIndex = 88
        Me.txtbPART_NUMBER_SELECT.Text = "--"
        '
        'txtbBARCODEstatus
        '
        Me.txtbBARCODEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbBARCODEstatus.Location = New System.Drawing.Point(639, 112)
        Me.txtbBARCODEstatus.Name = "txtbBARCODEstatus"
        Me.txtbBARCODEstatus.ReadOnly = True
        Me.txtbBARCODEstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbBARCODEstatus.TabIndex = 87
        Me.txtbBARCODEstatus.Text = "--"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(519, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 16)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "LS2208 Status :"
        '
        'txtbTEGAMstatus
        '
        Me.txtbTEGAMstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbTEGAMstatus.Location = New System.Drawing.Point(639, 88)
        Me.txtbTEGAMstatus.Name = "txtbTEGAMstatus"
        Me.txtbTEGAMstatus.ReadOnly = True
        Me.txtbTEGAMstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbTEGAMstatus.TabIndex = 85
        Me.txtbTEGAMstatus.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(480, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "TEGAM 1750 Status :"
        '
        'txtbDBfilepath
        '
        Me.txtbDBfilepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbDBfilepath.Location = New System.Drawing.Point(639, 14)
        Me.txtbDBfilepath.Name = "txtbDBfilepath"
        Me.txtbDBfilepath.ReadOnly = True
        Me.txtbDBfilepath.Size = New System.Drawing.Size(158, 22)
        Me.txtbDBfilepath.TabIndex = 83
        Me.txtbDBfilepath.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(481, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Ruta de Archivo DB :"
        '
        'txtbSHOP_PACK
        '
        Me.txtbSHOP_PACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbSHOP_PACK.Location = New System.Drawing.Point(189, 41)
        Me.txtbSHOP_PACK.Name = "txtbSHOP_PACK"
        Me.txtbSHOP_PACK.ReadOnly = True
        Me.txtbSHOP_PACK.Size = New System.Drawing.Size(252, 31)
        Me.txtbSHOP_PACK.TabIndex = 81
        Me.txtbSHOP_PACK.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(23, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Shop Pack # :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtbLOWERresistanceLIMIT)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtbUPPERresistanceLIMIT)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtbRESISTANCE)
        Me.GroupBox1.Controls.Add(Me.txtbDATECODE)
        Me.GroupBox1.Controls.Add(Me.txtbIEC_IR)
        Me.GroupBox1.Controls.Add(Me.txtbUL_DC_IR)
        Me.GroupBox1.Controls.Add(Me.txtbUL_AC_IR)
        Me.GroupBox1.Controls.Add(Me.txtbAMPERAGE)
        Me.GroupBox1.Controls.Add(Me.txtbPART_NUMBER)
        Me.GroupBox1.Controls.Add(Me.btnUSBprintZPL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 415)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS A IMPRIMIR"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(93, 315)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(175, 20)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "(LIMITE INFERIOR):"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label21.Location = New System.Drawing.Point(345, 314)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 25)
        Me.Label21.TabIndex = 98
        Me.Label21.Text = "mΩ"
        '
        'txtbLOWERresistanceLIMIT
        '
        Me.txtbLOWERresistanceLIMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbLOWERresistanceLIMIT.Location = New System.Drawing.Point(273, 312)
        Me.txtbLOWERresistanceLIMIT.Name = "txtbLOWERresistanceLIMIT"
        Me.txtbLOWERresistanceLIMIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbLOWERresistanceLIMIT.Size = New System.Drawing.Size(71, 26)
        Me.txtbLOWERresistanceLIMIT.TabIndex = 97
        Me.txtbLOWERresistanceLIMIT.Text = "--"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(86, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(182, 20)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "(LIMITE SUPERIOR):"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label19.Location = New System.Drawing.Point(345, 235)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 25)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "mΩ"
        '
        'txtbUPPERresistanceLIMIT
        '
        Me.txtbUPPERresistanceLIMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbUPPERresistanceLIMIT.Location = New System.Drawing.Point(274, 231)
        Me.txtbUPPERresistanceLIMIT.Name = "txtbUPPERresistanceLIMIT"
        Me.txtbUPPERresistanceLIMIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbUPPERresistanceLIMIT.Size = New System.Drawing.Size(71, 26)
        Me.txtbUPPERresistanceLIMIT.TabIndex = 94
        Me.txtbUPPERresistanceLIMIT.Text = "--"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(12, 276)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 20)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "RESISTENCIA (MEDICION):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(81, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 20)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "DATE CODE :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(26, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 20)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "IEC VOLTAGE, I.R. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(3, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 20)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "UL DC VOLTAGE, I.R. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(1, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 20)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "UL AC VOLTAGE, I.R. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(85, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "AMPERAJE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(13, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 20)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "NUMERO DE PARTE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.Label5.Location = New System.Drawing.Point(345, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 25)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "mΩ"
        '
        'txtbRESISTANCE
        '
        Me.txtbRESISTANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtbRESISTANCE.Location = New System.Drawing.Point(256, 270)
        Me.txtbRESISTANCE.Name = "txtbRESISTANCE"
        Me.txtbRESISTANCE.Size = New System.Drawing.Size(88, 35)
        Me.txtbRESISTANCE.TabIndex = 85
        Me.txtbRESISTANCE.Text = "--"
        '
        'txtbDATECODE
        '
        Me.txtbDATECODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbDATECODE.Location = New System.Drawing.Point(205, 198)
        Me.txtbDATECODE.Name = "txtbDATECODE"
        Me.txtbDATECODE.Size = New System.Drawing.Size(180, 29)
        Me.txtbDATECODE.TabIndex = 84
        Me.txtbDATECODE.Text = "--"
        '
        'txtbIEC_IR
        '
        Me.txtbIEC_IR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbIEC_IR.Location = New System.Drawing.Point(205, 161)
        Me.txtbIEC_IR.Name = "txtbIEC_IR"
        Me.txtbIEC_IR.Size = New System.Drawing.Size(180, 29)
        Me.txtbIEC_IR.TabIndex = 83
        Me.txtbIEC_IR.Text = "--"
        '
        'txtbUL_DC_IR
        '
        Me.txtbUL_DC_IR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbUL_DC_IR.Location = New System.Drawing.Point(205, 124)
        Me.txtbUL_DC_IR.Name = "txtbUL_DC_IR"
        Me.txtbUL_DC_IR.Size = New System.Drawing.Size(180, 29)
        Me.txtbUL_DC_IR.TabIndex = 82
        Me.txtbUL_DC_IR.Text = "--"
        '
        'txtbUL_AC_IR
        '
        Me.txtbUL_AC_IR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbUL_AC_IR.Location = New System.Drawing.Point(205, 87)
        Me.txtbUL_AC_IR.Name = "txtbUL_AC_IR"
        Me.txtbUL_AC_IR.Size = New System.Drawing.Size(180, 29)
        Me.txtbUL_AC_IR.TabIndex = 81
        Me.txtbUL_AC_IR.Text = "--"
        '
        'txtbAMPERAGE
        '
        Me.txtbAMPERAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbAMPERAGE.Location = New System.Drawing.Point(205, 50)
        Me.txtbAMPERAGE.Name = "txtbAMPERAGE"
        Me.txtbAMPERAGE.Size = New System.Drawing.Size(180, 29)
        Me.txtbAMPERAGE.TabIndex = 80
        Me.txtbAMPERAGE.Text = "--"
        '
        'txtbPART_NUMBER
        '
        Me.txtbPART_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtbPART_NUMBER.Location = New System.Drawing.Point(205, 13)
        Me.txtbPART_NUMBER.Name = "txtbPART_NUMBER"
        Me.txtbPART_NUMBER.Size = New System.Drawing.Size(180, 29)
        Me.txtbPART_NUMBER.TabIndex = 79
        Me.txtbPART_NUMBER.Text = "--"
        '
        'btnUSBprintZPL
        '
        Me.btnUSBprintZPL.BackColor = System.Drawing.Color.Lime
        Me.btnUSBprintZPL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnUSBprintZPL.Location = New System.Drawing.Point(16, 348)
        Me.btnUSBprintZPL.Name = "btnUSBprintZPL"
        Me.btnUSBprintZPL.Size = New System.Drawing.Size(377, 61)
        Me.btnUSBprintZPL.TabIndex = 78
        Me.btnUSBprintZPL.Text = "MEDIR E IMPRIMIR ETIQUETA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Barra de espacio)"
        Me.btnUSBprintZPL.UseVisualStyleBackColor = False
        '
        'grpbxBarcodeScannerST1A
        '
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.Label40)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.Label29)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnOpenBarcodeDeviceST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDsOFFST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.txtbBCDevice_ReadST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDGreenONST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDRedONST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_BeepST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDeviceEventSubscribeST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnCloseBarcodeDeviceST1A)
        Me.grpbxBarcodeScannerST1A.Location = New System.Drawing.Point(828, 400)
        Me.grpbxBarcodeScannerST1A.Name = "grpbxBarcodeScannerST1A"
        Me.grpbxBarcodeScannerST1A.Size = New System.Drawing.Size(150, 180)
        Me.grpbxBarcodeScannerST1A.TabIndex = 84
        Me.grpbxBarcodeScannerST1A.TabStop = False
        Me.grpbxBarcodeScannerST1A.Text = "Symbol Barcode ST1A"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(4, 84)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 13)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "LEDs and Beep"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.Location = New System.Drawing.Point(5, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(145, 13)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "Initialize Symbol LS2208"
        '
        'btnOpenBarcodeDeviceST1A
        '
        Me.btnOpenBarcodeDeviceST1A.Location = New System.Drawing.Point(5, 37)
        Me.btnOpenBarcodeDeviceST1A.Name = "btnOpenBarcodeDeviceST1A"
        Me.btnOpenBarcodeDeviceST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnOpenBarcodeDeviceST1A.TabIndex = 15
        Me.btnOpenBarcodeDeviceST1A.Text = "Open"
        Me.btnOpenBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDsOFFST1A
        '
        Me.btnBCDevice_LEDsOFFST1A.Location = New System.Drawing.Point(101, 106)
        Me.btnBCDevice_LEDsOFFST1A.Name = "btnBCDevice_LEDsOFFST1A"
        Me.btnBCDevice_LEDsOFFST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDsOFFST1A.TabIndex = 17
        Me.btnBCDevice_LEDsOFFST1A.Text = "ALL OFF"
        Me.btnBCDevice_LEDsOFFST1A.UseVisualStyleBackColor = True
        '
        'txtbBCDevice_ReadST1A
        '
        Me.txtbBCDevice_ReadST1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbBCDevice_ReadST1A.Location = New System.Drawing.Point(5, 146)
        Me.txtbBCDevice_ReadST1A.Multiline = True
        Me.txtbBCDevice_ReadST1A.Name = "txtbBCDevice_ReadST1A"
        Me.txtbBCDevice_ReadST1A.ReadOnly = True
        Me.txtbBCDevice_ReadST1A.Size = New System.Drawing.Size(140, 25)
        Me.txtbBCDevice_ReadST1A.TabIndex = 16
        Me.txtbBCDevice_ReadST1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBCDevice_LEDGreenONST1A
        '
        Me.btnBCDevice_LEDGreenONST1A.Location = New System.Drawing.Point(5, 106)
        Me.btnBCDevice_LEDGreenONST1A.Name = "btnBCDevice_LEDGreenONST1A"
        Me.btnBCDevice_LEDGreenONST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDGreenONST1A.TabIndex = 18
        Me.btnBCDevice_LEDGreenONST1A.Text = "Green ON"
        Me.btnBCDevice_LEDGreenONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDRedONST1A
        '
        Me.btnBCDevice_LEDRedONST1A.Location = New System.Drawing.Point(53, 106)
        Me.btnBCDevice_LEDRedONST1A.Name = "btnBCDevice_LEDRedONST1A"
        Me.btnBCDevice_LEDRedONST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDRedONST1A.TabIndex = 19
        Me.btnBCDevice_LEDRedONST1A.Text = "Red ON"
        Me.btnBCDevice_LEDRedONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_BeepST1A
        '
        Me.btnBCDevice_BeepST1A.Location = New System.Drawing.Point(101, 81)
        Me.btnBCDevice_BeepST1A.Name = "btnBCDevice_BeepST1A"
        Me.btnBCDevice_BeepST1A.Size = New System.Drawing.Size(45, 19)
        Me.btnBCDevice_BeepST1A.TabIndex = 21
        Me.btnBCDevice_BeepST1A.Text = "BEEP"
        Me.btnBCDevice_BeepST1A.UseVisualStyleBackColor = True
        '
        'btnBCDeviceEventSubscribeST1A
        '
        Me.btnBCDeviceEventSubscribeST1A.Location = New System.Drawing.Point(53, 37)
        Me.btnBCDeviceEventSubscribeST1A.Name = "btnBCDeviceEventSubscribeST1A"
        Me.btnBCDeviceEventSubscribeST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDeviceEventSubscribeST1A.TabIndex = 22
        Me.btnBCDeviceEventSubscribeST1A.Text = "Event Subs."
        Me.btnBCDeviceEventSubscribeST1A.UseVisualStyleBackColor = True
        '
        'btnCloseBarcodeDeviceST1A
        '
        Me.btnCloseBarcodeDeviceST1A.Location = New System.Drawing.Point(102, 37)
        Me.btnCloseBarcodeDeviceST1A.Name = "btnCloseBarcodeDeviceST1A"
        Me.btnCloseBarcodeDeviceST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnCloseBarcodeDeviceST1A.TabIndex = 23
        Me.btnCloseBarcodeDeviceST1A.Text = "Close"
        Me.btnCloseBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbEXITapp)
        Me.GroupBox2.Controls.Add(Me.txtbLOG)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.GroupBox2.Location = New System.Drawing.Point(416, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 415)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BITACORA"
        '
        'txtbEXITapp
        '
        Me.txtbEXITapp.BackColor = System.Drawing.Color.Red
        Me.txtbEXITapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbEXITapp.Location = New System.Drawing.Point(109, 20)
        Me.txtbEXITapp.Name = "txtbEXITapp"
        Me.txtbEXITapp.Size = New System.Drawing.Size(282, 38)
        Me.txtbEXITapp.TabIndex = 94
        Me.txtbEXITapp.Text = "GUARDAR BITACORA && SALIR"
        Me.txtbEXITapp.UseVisualStyleBackColor = False
        '
        'txtbLOG
        '
        Me.txtbLOG.BackColor = System.Drawing.Color.Black
        Me.txtbLOG.Font = New System.Drawing.Font("Courier New", 8.25!)
        Me.txtbLOG.ForeColor = System.Drawing.Color.Lime
        Me.txtbLOG.Location = New System.Drawing.Point(6, 64)
        Me.txtbLOG.Multiline = True
        Me.txtbLOG.Name = "txtbLOG"
        Me.txtbLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbLOG.Size = New System.Drawing.Size(391, 345)
        Me.txtbLOG.TabIndex = 0
        '
        'bkgworkSleep1
        '
        '
        'prgsbarSleep1
        '
        Me.prgsbarSleep1.Location = New System.Drawing.Point(636, 613)
        Me.prgsbarSleep1.Name = "prgsbarSleep1"
        Me.prgsbarSleep1.Size = New System.Drawing.Size(170, 18)
        Me.prgsbarSleep1.TabIndex = 86
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 632)
        Me.Controls.Add(Me.prgsbarSleep1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbxBarcodeScannerST1A)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxINIT)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpbxGPIB_TEGAM)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NPD: SQ BODY LABEL MANAGER Rev.0.4."
        Me.grpbxGPIB_TEGAM.ResumeLayout(False)
        Me.grpbxGPIB_TEGAM.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpbxINIT.ResumeLayout(False)
        Me.grpbxINIT.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxBarcodeScannerST1A.ResumeLayout(False)
        Me.grpbxBarcodeScannerST1A.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxGPIB_TEGAM As GroupBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnOPEN As Button
    Friend WithEvents btnCLOSE As Button
    Friend WithEvents btnREAD As Button
    Friend WithEvents txtbReadGPIB As TextBox
    Friend WithEvents txtbWriteGPIB As TextBox
    Friend WithEvents btnWRITE As Button
    Friend WithEvents btnTERMINATE As Button
    Friend WithEvents btnTRIGGER As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents grpbxINIT As GroupBox
    Friend WithEvents txtbPRINTERstatus As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbPRN_TEMPLATE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbPART_NUMBER_SELECT As TextBox
    Friend WithEvents txtbBARCODEstatus As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbTEGAMstatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbDBfilepath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbSHOP_PACK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbRESISTANCE As TextBox
    Friend WithEvents txtbDATECODE As TextBox
    Friend WithEvents txtbIEC_IR As TextBox
    Friend WithEvents txtbUL_DC_IR As TextBox
    Friend WithEvents txtbUL_AC_IR As TextBox
    Friend WithEvents txtbAMPERAGE As TextBox
    Friend WithEvents txtbPART_NUMBER As TextBox
    Friend WithEvents btnUSBprintZPL As Button
    Friend WithEvents grpbxBarcodeScannerST1A As GroupBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnOpenBarcodeDeviceST1A As Button
    Friend WithEvents btnBCDevice_LEDsOFFST1A As Button
    Friend WithEvents txtbBCDevice_ReadST1A As TextBox
    Friend WithEvents btnBCDevice_LEDGreenONST1A As Button
    Friend WithEvents btnBCDevice_LEDRedONST1A As Button
    Friend WithEvents btnBCDevice_BeepST1A As Button
    Friend WithEvents btnBCDeviceEventSubscribeST1A As Button
    Friend WithEvents btnCloseBarcodeDeviceST1A As Button
    Friend WithEvents txtbPRNfolder As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbLOG As TextBox
    Friend WithEvents txtbEXITapp As Button
    Friend WithEvents txtbLOGfolder As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbLOWERresistanceLIMIT As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtbUPPERresistanceLIMIT As TextBox
    Friend WithEvents bkgworkSleep1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents prgsbarSleep1 As ProgressBar
End Class
