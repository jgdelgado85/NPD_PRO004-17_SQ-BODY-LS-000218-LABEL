Imports System
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.NI4882
Imports System.Xml
Imports System.Net.Sockets
Imports System.Threading
Imports CoreScanner
Imports System.Net
Imports System.Globalization

Public Class Form1
    Public GPIB_Device As NationalInstruments.NI4882.Device
    Public WithEvents cCoreScanner As CCoreScanner
    Dim DBfilepath As String = ""
    Dim BCScannerReady As String = ""
    Dim BCScannerDirection As String = "SHOP_PACK"


    ' Public BarcodeScanner_Device2 As _ICoreScannerEvents
    Dim PrinterSelected As Boolean = False
    Dim PRNstring As String = ""
    Dim PRNfolder As String = ""
    Dim LogFolder As String = ""
    Public strdata As New System.Text.StringBuilder(255)
    Dim INIpath As String
    Dim LogSetup As Boolean = False
    Dim LogDateAndTime As String
    Dim gpibWAIT As Integer
    Dim ccorescannerWAIT As Integer

    Const LED_GREEN_ON As String = "43"   ' Green  LED On                            
    Const LED_RED_ON As String = "47"  ' Red  LED On                              
    Const LED_GREEN_OFF As String = "42"  ' Green  LED Off                            
    Const LED_RED_OFF As String = "48"   ' Red  LED Off
    Const SCANNER_BEEP As String = "1"   ' Red  LED Off

    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal IpApplication As String, ByVal Ipkeyname As String, ByVal IpString As String, ByVal IpFileName As String) As Integer

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal IpApplicationName As String, ByVal IpKeyName As String, ByVal IpDefault As String, ByVal IPReturnedString As System.Text.StringBuilder, ByVal nsize As Integer, ByVal IpFileName As String) As Integer

    Private Sub WriteINIFile(INIsection As String, INIkey As String, INIvalue As String, INIpath As String)
        WritePrivateProfileString(INIsection, INIkey, INIvalue, INIpath)
    End Sub

    Private Function readIniFile(INIsection As String, INIkey As String, INIpath As String) As String
        GetPrivateProfileString(INIsection, INIkey, "", strdata, 100, INIpath)
        readIniFile = strdata.ToString
    End Function

    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter",
       SetLastError:=True, CharSet:=CharSet.Unicode,
       ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)>
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array of  
        ' bytes, the function sends those bytes to the print queue.
        ' Returns True on success or False on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim hPrinter As IntPtr      ' The printer handle.
            Dim dwError As Int32        ' Last error - in case there was trouble.
            Dim di As DOCINFOW          ' Describes your document (name, port, data type).
            Dim dwWritten As Int32      ' The number of bytes written by WritePrinter().
            Dim bSuccess As Boolean     ' Your success code.

            ' Set up the DOCINFO structure.
            With di
                .pDocName = "My Visual Basic .NET RAW Document"
                .pDataType = "RAW"
            End With
            ' Assume failure unless you specifically succeed.
            bSuccess = False
            If OpenPrinter(szPrinterName, hPrinter, 0) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        ' Write your printer-specific bytes to the printer.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If
            Return bSuccess
        End Function ' SendBytesToPrinter()

        ' SendFileToPrinter()
        ' When the function is given a file name and a printer name, 
        ' the function reads the contents of the file and sends the
        ' contents to the printer.
        ' Presumes that the file contains printer-ready data.
        ' Shows how to use the SendBytesToPrinter function.
        ' Returns True on success or False on failure.
        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As New BinaryReader(fs)
            ' Dim an array of bytes large enough to hold the file's contents.
            Dim bytes(fs.Length) As Byte
            Dim bSuccess As Boolean
            ' Your unmanaged pointer.
            Dim pUnmanagedBytes As IntPtr

            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(fs.Length)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function ' SendFileToPrinter()

        ' When the function is given a string and a printer name,
        ' the function sends the string to the printer as raw bytes.
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length()
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
        End Function
    End Class
    'Private Sub btnUSBprintFILE_Click(sender As Object, e As EventArgs)
    '    Dim ZPLraw As String = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR4,4~SD15^JUS^LRN^CI0^XZ^XA^MMT^PW1080^LL0780^LS0^FO160,128^GFA,10880,10880,00020,:Z64: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:31A5^FT556,112^A0R,83,81^FH\^FDPOWER-^FS^FT558,405^A0R,83,81^FH\^FDSPEED^FS^PQ1,0,1,Y^XZ"
    '    ' Allow the user to select a file.
    '    Dim ofd As New OpenFileDialog()
    '    If ofd.ShowDialog(Me) Then
    '        ' Allow the user to select a printer.
    '        Dim pd As New PrintDialog()
    '        pd.PrinterSettings = New PrinterSettings()
    '        If (pd.ShowDialog() = DialogResult.OK) Then
    '            ' Print the file to the printer.
    '            RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName)
    '        End If
    '    End If
    'End Sub

    Private Sub btnUSBprintZPL_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOPEN_Click(sender As Object, e As EventArgs) Handles btnOPEN.Click
        GPIB_Open(0, 12, 0) 'Default board 0, Address 12, Secondary 0
    End Sub
    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        GPIB_Close()
    End Sub
    Private Sub btnREAD_Click(sender As Object, e As EventArgs) Handles btnREAD.Click
        GPIB_Read()
    End Sub
    Private Sub btnWRITE_Click(sender As Object, e As EventArgs) Handles btnWRITE.Click
        GPIB_Write(txtbWriteGPIB.Text)
    End Sub
    Private Sub btnTERMINATE_Click(sender As Object, e As EventArgs) Handles btnTERMINATE.Click
        GPIB_Terminate()
    End Sub
    Sub GPIB_Terminate()
        Try
            GPIB_Device.AbortAsynchronousIO()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'terminateButton_Click
    Sub GPIB_Open(Optional boardID As Integer = 0, Optional primaryAddress As Integer = 1, Optional secondaryAddress As Integer = 0)
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'Dim boardID As Integer = 0
            'Dim primaryAddress As Integer = 1
            'Dim secondaryAddress As Integer = 0
            'If secondaryAddressComboBox.SelectedIndex <> 0 Then
            '    currentSecondaryAddress = secondaryAddressComboBox.SelectedItem
            'Else
            '    currentSecondaryAddress = 0
            'End If
            ' GPIB_Device = New Device(CInt(boardIdNumericUpDown.Value), CByte(primaryAddressNumericUpDown.Value), CByte(currentSecondaryAddress))
            GPIB_Device = New Device(boardID, primaryAddress, secondaryAddress)
            '#If NETFX2_0 Then
            '            'For .NET Framework 2.0, use SynchronizeCallbacks to specify that the object 
            '            'marshals callbacks across threads appropriately.
            '            GPIB_Device.SynchronizeCallbacks = True
            '#Else
            '            'For .NET Framework 1.1, set SynchronizingObject to the Windows Form to specify 
            '            'that the object marshals callbacks across threads appropriately.
            '            GPIB_Device.SynchronizingObject = Me
            '#End If
            '            SetupControlState(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
    Sub GPIB_Close()
        Try
            GPIB_Device.Dispose()
            'SetupControlState(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub GPIB_Write(stringToWrite As String)
        'stringToWrite = "*IDN?\n"
        Try
            GPIB_Device.BeginWrite(stringToWrite + vbLf, New AsyncCallback(AddressOf OnWriteComplete), Nothing)
            'GPIB_Device.BeginWrite(ReplaceCommonEscapeSequences(stringToWrite), New AsyncCallback(AddressOf OnWriteComplete), Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OnWriteComplete(ByVal result As IAsyncResult)
        Dim elementsTransferred As String
        Dim lastIOStatus As String
        Try
            GPIB_Device.EndWrite(result)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        elementsTransferred = GPIB_Device.LastCount.ToString()
        lastIOStatus = GPIB_Device.LastStatus.ToString()
    End Sub 'OnWriteComplete
    Sub GPIB_Read()
        Try
            GPIB_Device.BeginRead(New AsyncCallback(AddressOf OnReadComplete), Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'readButton_Click
    Private Sub OnReadComplete(ByVal result As IAsyncResult)
        Dim elementsTransferred As String
        Dim lastIOStatus As String
        Dim stringReadTextBox As String = ""
        Try
            stringReadTextBox = InsertCommonEscapeSequences(GPIB_Device.EndReadString(result))
            stringReadTextBox = stringReadTextBox.Replace("\r\n", "")
            'stringReadTextBox = stringReadTextBox.Replace("mOhm", "mΩ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        elementsTransferred = GPIB_Device.LastCount.ToString()
        lastIOStatus = GPIB_Device.LastStatus.ToString()
        txtbReadGPIB.Text = stringReadTextBox ' + vbCrLf + txtbReadGPIB.Text
    End Sub 'OnReadComplete
    Private Function ReplaceCommonEscapeSequences(ByVal s As String) As String
        Return s.Replace("\n", ControlChars.Lf).Replace("\r", ControlChars.Cr)
    End Function 'ReplaceCommonEscapeSequences
    Private Function InsertCommonEscapeSequences(ByVal s As String) As String
        Return s.Replace(ControlChars.Lf, "\n").Replace(ControlChars.Cr, "\r")
    End Function 'InsertCommonEscapeSequences
    'Private Sub LoadDBfile()
    '    Dim myStream As Stream = Nothing
    '    Dim openFileDialog1 As New OpenFileDialog()

    '    openFileDialog1.InitialDirectory = "C:\NPD_jdelgado2\NPD_PRO\Production"
    '    openFileDialog1.Filter = "ini files (*.ini)|*.ini|All files (*.*)|*.*"
    '    openFileDialog1.FilterIndex = 1
    '    openFileDialog1.RestoreDirectory = True

    '    If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '        Try
    '            myStream = openFileDialog1.OpenFile()
    '            If (myStream IsNot Nothing) Then
    '                ' Insert code to read the stream here.
    '            End If
    '        Catch Ex As Exception
    '            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
    '        Finally
    '            ' Check this again, since we need to make sure we didn't throw an exception on open.
    '            If (myStream IsNot Nothing) Then
    '                myStream.Close()
    '            End If
    '        End Try
    '    End If
    '    DBfilepath = openFileDialog1.FileName
    'End Sub
    Private Sub SelectPRNTemplate()
        Dim myStream As Stream = Nothing
        Dim PRNfilePath As String = ""
        'Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.InitialDirectory = "C:\NPD_jdelgado2\NPD_PRO\Production"
        'openFileDialog1.Filter = "ini files (*.prn)|*.prn|All files (*.*)|*.*"
        'openFileDialog1.FilterIndex = 1
        'openFileDialog1.RestoreDirectory = True

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        myStream = openFileDialog1.OpenFile()
        '        If (myStream IsNot Nothing) Then
        '            ' Insert code to read the stream here.
        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        '    Finally
        '        ' Check this again, since we need to make sure we didn't throw an exception on open.
        '        If (myStream IsNot Nothing) Then
        '            myStream.Close()
        '        End If
        '    End Try
        'End If
        PRNfilePath = PRNfolder + txtbPRN_TEMPLATE.Text + ".prn"
        ToolStripStatusLabel1.Text = PRNfilePath
        'Convert the PRN file into a local string variable called PRNstring
        Using sr As StreamReader = File.OpenText(PRNfilePath)
            Do Until sr.EndOfStream
                PRNstring = PRNstring + sr.ReadLine
            Loop
        End Using
    End Sub

    Public Shared Function DefaultPrinterName() As String
        Dim oPS As New System.Drawing.Printing.PrinterSettings

        Try
            DefaultPrinterName = oPS.PrinterName
        Catch ex As System.Exception
            DefaultPrinterName = ""
        Finally
            oPS = Nothing
        End Try
    End Function


    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds
            System.Threading.Thread.Sleep(1)
            Application.DoEvents()
        Next
    End Sub



    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnREQUESTBARCODE_Click(sender As Object, e As EventArgs)
        ScannerOpenDevice(1)
    End Sub

    Private Sub btnSendBarcodeOpcode_Click(sender As Object, e As EventArgs)
        ScannerOpCodesSend(1, LED_GREEN_OFF)
    End Sub

    Private Sub ScannerOpenDevice(deviceID As Integer)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        Dim numberOfScanners As Short
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 6000
        Dim inXML As String
        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>3</arg-int></cmdArgs></inArgs>"
        cCoreScanner = New CCoreScanner
        cCoreScanner.Open(0, scannerTypes, numberOfScannerTypes, status)
        cCoreScanner.GetScanners(numberOfScanners, connectedScannerIDList, outXML, status)
    End Sub

    Private Sub ScannerCloseDevice(deviceID As Integer)
        Dim status As Integer
        cCoreScanner.Close(0, status) 'Reserved argument set to 0
    End Sub
    Private Sub ScannerOpCodesSend(deviceID As Integer, actionCode As String)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        'Dim numberOfScanners As Short
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 6000
        Dim inXML As String
        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>" & actionCode & "</arg-int></cmdArgs></inArgs>"
        cCoreScanner.ExecCommand(opcode, inXML, outXML, status)
    End Sub

    Private Sub ScannerSubscribeEvent(deviceID As Integer)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 1001
        Dim inXML As String

        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>1</arg-int><arg-int>1</arg-int></cmdArgs></inArgs>"
        cCoreScanner.ExecCommand(opcode, inXML, outXML, status)
        BCScannerReady = outXML
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ScannerOpCodesSend(1, LED_GREEN_ON)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ScannerOpCodesSend(1, LED_RED_ON)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ScannerOpCodesSend(1, LED_RED_OFF)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ScannerOpCodesSend(1, SCANNER_BEEP)
    End Sub


    Private Sub cCoreScanner_BarcodeEvent(eventType As Short, ByRef pscanData As String) Handles cCoreScanner.BarcodeEvent
        Dim Barcode As String
        Dim deviceID As String
        Dim ScannerID As Integer
        Dim RawData As String
        Dim RawDataStart As Integer
        Dim RawDataEnd As Integer
        Dim CharIndex As Integer
        Dim FormedString As String = ""
        Dim I As Integer
        Dim CurrentChar As String

        Barcode = pscanData
        deviceID = pscanData
        'MessageBox.Show(deviceID)

        '*******************************************************************************Decode Device ID
        RawDataStart = InStr(deviceID, "<scannerID>")
        deviceID = deviceID.Remove(0, RawDataStart + 10)
        RawDataEnd = InStr(deviceID, "</scannerID>")
        deviceID = deviceID.Remove(RawDataEnd - 1, deviceID.Length - RawDataEnd)
        ScannerID = Convert.ToInt32(deviceID)
        '*******************************************************************************Decode Raw Data
        RawDataStart = InStr(Barcode, "<rawdata>")
        Barcode = Barcode.Remove(0, RawDataStart + 8)
        RawDataEnd = InStr(Barcode, "</rawdata>")
        RawData = Barcode.Remove(RawDataEnd - 1, Barcode.Length - RawDataEnd)

        RawData = RawData.Replace("0x", "")
        RawData = RawData.Replace(" ", "")
        CharIndex = RawData.Length - 2
        For I = 8 To CharIndex Step 2
            CurrentChar = RawData.Substring(I, 2)
            FormedString = FormedString + Convert.ToChar((Convert.ToInt32(CurrentChar, 16)))
        Next

        If ScannerID = 1 Then

            Me.Invoke(New MethodInvoker(Sub() txtbBCDevice_ReadST1A.Text = FormedString))
        End If




    End Sub


    Private Sub btnEventSubscribe_Click(sender As Object, e As EventArgs)
        ScannerSubscribeEvent(1)

    End Sub



    Private Sub btnCloseBarcodeDevice_Click(sender As Object, e As EventArgs)
        ScannerCloseDevice(1)

    End Sub

    Private Sub StartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem1.Click
        Dim PrinterName As String = ""

        'Main Sequencer

        '*******************************************************************Initialize TEGAM 1750
        Dim gpibCommand As String = ""
        'Open GPIB connection
        btnOPEN.PerformClick()
        wait(gpibWAIT)                  'Value in ms between commands sent
        txtbWriteGPIB.Text = "Q1X" 'Read Revision
        btnWRITE.PerformClick()
        wait(gpibWAIT)
        btnREAD.PerformClick()
        wait(gpibWait)
        If txtbReadGPIB.Text IsNot "" Then
            txtbTEGAMstatus.Text = txtbReadGPIB.Text
            txtbTEGAMstatus.BackColor = Color.LightGreen
        Else
            txtbTEGAMstatus.Text = "Check Connection"
            txtbTEGAMstatus.BackColor = Color.Red
        End If

        wait(gpibWait)
        txtbWriteGPIB.Text = "R3X" 'Set Range R3X 20mΩ @ 100mA
        btnWRITE.PerformClick()
        wait(gpibWait)
        btnREAD.PerformClick()
        wait(gpibWait)
        ToolStripStatusLabel1.Text = txtbReadGPIB.Text

        '******************************************************************Initialize Symbol Barcode Scanner
        btnOpenBarcodeDeviceST1A.PerformClick()
        wait(ccorescannerWAIT)
        btnBCDeviceEventSubscribeST1A.PerformClick()
        wait(ccorescannerWAIT)
        btnBCDevice_BeepST1A.PerformClick()
        wait(ccorescannerWAIT)
        btnBCDevice_LEDGreenONST1A.PerformClick()

        txtbBARCODEstatus.Text = "Online"
        txtbBARCODEstatus.BackColor = Color.LightGreen

        '*******************************************************************Capture Shop Pack & Part Number
        BCScannerDirection = "SHOP_PACK"

        '*******************************************************************Select Data from INI File based on Part Number

        '*******************************************************************Default Printer Name
        PrinterName = DefaultPrinterName()
        If PrinterName IsNot "" Then
            txtbPRINTERstatus.Text = PrinterName
            txtbPRINTERstatus.BackColor = Color.LightGreen
        Else
            txtbPRINTERstatus.Text = "No Printer found"
            txtbPRINTERstatus.BackColor = Color.Red
        End If
    End Sub
    Private Sub btnOpenBarcodeDeviceST1A_Click(sender As Object, e As EventArgs) Handles btnOpenBarcodeDeviceST1A.Click
        ScannerOpenDevice(1)
    End Sub
    Private Sub btnBCDeviceEventSubscribeST1A_Click(sender As Object, e As EventArgs) Handles btnBCDeviceEventSubscribeST1A.Click
        ScannerSubscribeEvent(1)
    End Sub
    Private Sub btnCloseBarcodeDeviceST1A_Click(sender As Object, e As EventArgs) Handles btnCloseBarcodeDeviceST1A.Click
        ScannerCloseDevice(1)
    End Sub
    Private Sub btnBCDevice_LEDGreenONST1A_Click(sender As Object, e As EventArgs) Handles btnBCDevice_LEDGreenONST1A.Click
        ScannerOpCodesSend(1, LED_GREEN_ON)
    End Sub
    Private Sub btnBCDevice_LEDRedONST1A_Click(sender As Object, e As EventArgs) Handles btnBCDevice_LEDRedONST1A.Click
        ScannerOpCodesSend(1, LED_RED_ON)
    End Sub
    Private Sub btnBCDevice_LEDsOFFST1A_Click(sender As Object, e As EventArgs) Handles btnBCDevice_LEDsOFFST1A.Click
        ScannerOpCodesSend(1, LED_RED_OFF)
    End Sub
    Private Sub btnBCDevice_BeepST1A_Click(sender As Object, e As EventArgs) Handles btnBCDevice_BeepST1A.Click
        ScannerOpCodesSend(1, SCANNER_BEEP)
    End Sub
    Private Sub txtbBCDevice_ReadST1A_TextChanged(sender As Object, e As EventArgs) Handles txtbBCDevice_ReadST1A.TextChanged
        Dim ScannedString As String
        If BCScannerDirection = "SHOP_PACK" Then
            ScannedString = txtbBCDevice_ReadST1A.Text
            If ScannedString.Length = 10 Then 'Shop Pack Data detecion
                txtbSHOP_PACK.Text = ScannedString
                BCScannerDirection = "PART_NUMBER"
            End If
        ElseIf BCScannerDirection = "PART_NUMBER" Then
            ScannedString = txtbBCDevice_ReadST1A.Text
            If ScannedString.Length = 13 Then            'Shop Pack Data detecion
                txtbPART_NUMBER_SELECT.Text = ScannedString
                BCScannerDirection = "SHOP_PACK"
            End If
        End If
        txtbPART_NUMBER.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "PART_NUMBER", DBfilepath)
        txtbAMPERAGE.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "AMPERAGE", DBfilepath)
        txtbUL_AC_IR.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "UL_AC_VOLTAGE", DBfilepath) + ", " + readIniFile(txtbPART_NUMBER_SELECT.Text, "UL_AC_IR", DBfilepath)
        txtbUL_DC_IR.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "UL_DC_VOLTAGE", DBfilepath) + ", " + readIniFile(txtbPART_NUMBER_SELECT.Text, "UL_DC_IR", DBfilepath)
        txtbIEC_IR.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "IEC_VOLTAGE", DBfilepath) + ", " + readIniFile(txtbPART_NUMBER_SELECT.Text, "IEC_IR", DBfilepath)
        txtbUPPERresistanceLIMIT.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "RESISTANCE_MAX", DBfilepath)
        txtbLOWERresistanceLIMIT.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "RESISTANCE_MIN", DBfilepath)



        txtbDATECODE.Text = "L" + DateAndTime.Now.Year.ToString.Last + MonthLetter() + DateAndTime.Now.Day.ToString + "F"
        txtbPRN_TEMPLATE.Text = readIniFile(txtbPART_NUMBER_SELECT.Text, "LABEL_STYLE", DBfilepath)

        If txtbPRN_TEMPLATE.Text IsNot "" Then
            SelectPRNTemplate()
        End If



    End Sub
    Private Function MonthLetter() As String
        Select Case Date.Now.Month
            Case 1
                MonthLetter = "A"
            Case 2
                MonthLetter = "B"
            Case 3
                MonthLetter = "C"
            Case 4
                MonthLetter = "D"
            Case 5
                MonthLetter = "F"
            Case 6
                MonthLetter = "G"
            Case 7
                MonthLetter = "H"
            Case 8
                MonthLetter = "I"
            Case 9
                MonthLetter = "J"
            Case 10
                MonthLetter = "K"
            Case 11
                MonthLetter = "L"
            Case 12
                MonthLetter = "M"
            Case Else
                MonthLetter = "Error"
        End Select
    End Function
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub
    Private Sub btnUSBprintZPL_Click(sender As Object, e As EventArgs) Handles btnUSBprintZPL.Click
        ' Click event handler for a button - designed to show how to use the
        ' SendBytesToPrinter function to send a string to the printer.
        Dim LOWERlimit As Single
        Dim UPPERlimit As Single
        Dim ACTUALresistance As Single

        If txtbPRINTERstatus.BackColor = Color.Red Then
            MessageBox.Show("No Printer available, check your connections.")
            Exit Sub
        End If

        If txtbTEGAMstatus.BackColor = Color.Red Then
            MessageBox.Show("No GPIB connection made to TEGAM, check your connections.")
            Exit Sub
        End If


        Dim pd As New PrintDialog()
        pd.PrinterSettings = New PrinterSettings()
        Dim TEGAMresistValue As String
        Dim PRNreplacedValues As String

        PRNreplacedValues = PRNstring

        txtbWriteGPIB.Text = "GX" 'Get Value
        btnWRITE.PerformClick()
        wait(50)
        btnTRIGGER.PerformClick()
        wait(10)
        btnREAD.PerformClick()
        wait(500)
        TEGAMresistValue = txtbReadGPIB.Text
        TEGAMresistValue = TEGAMresistValue.Replace(" mOhm", "")
        TEGAMresistValue = TEGAMresistValue.Replace(" ", "")
        txtbRESISTANCE.Text = TEGAMresistValue

        ACTUALresistance = Convert.ToSingle(TEGAMresistValue)
        LOWERlimit = Convert.ToSingle(txtbLOWERresistanceLIMIT.Text)
        UPPERlimit = Convert.ToSingle(txtbUPPERresistanceLIMIT.Text)
        If (ACTUALresistance < LOWERlimit Or ACTUALresistance > UPPERlimit) Then
            MessageBox.Show("Resistance value out of spec.")
            txtbRESISTANCE.BackColor = Color.Red
            Exit Sub
        End If

        txtbRESISTANCE.BackColor = Color.LightGreen

        ' You need a string to send.
        ' The PRNstring variable contains the label Template, replace with the current job measurements and variables
        PRNreplacedValues = PRNreplacedValues.Replace("PSRxxxFLxxx", txtbPART_NUMBER.Text) 'PART NUMBER
        PRNreplacedValues = PRNreplacedValues.Replace("xxxxA", txtbAMPERAGE.Text) 'Amperage
        PRNreplacedValues = PRNreplacedValues.Replace("2xxVAC, xxxkA", txtbUL_AC_IR.Text) 'UL AC voltage, I.R.
        PRNreplacedValues = PRNreplacedValues.Replace("xxxVDC, xxxkA", txtbUL_DC_IR.Text) 'UL DC voltage, I.R.
        PRNreplacedValues = PRNreplacedValues.Replace("1xxVAC, xxxkA", txtbIEC_IR.Text) 'IEC voltage, I.R.
        PRNreplacedValues = PRNreplacedValues.Replace("LXXXF", txtbDATECODE.Text) 'Datecode
        PRNreplacedValues = PRNreplacedValues.Replace("X.XXX", txtbRESISTANCE.Text) 'Resistance

        If PrinterSelected = False Then     'Initial Settings require the printer to be selected, after that the Variable is set to false
            If (pd.ShowDialog() = DialogResult.OK) Then
                PrinterSelected = True
                Try
                    RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, PRNreplacedValues)
                Catch ex As Exception
                End Try
            End If
        Else
            Try
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, PRNreplacedValues)
            Catch ex As Exception
            End Try
        End If
        LogDateAndTime = DateAndTime.Now.ToString
        txtbLOG.Text = txtbLOG.Text + LogDateAndTime + "," + txtbSHOP_PACK.Text + "," + txtbPART_NUMBER.Text + "," + txtbRESISTANCE.Text + vbCrLf
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load localConfigSQ_Lbl_Mgr.ini variables
        'ChangeLanguage("es-MX")
        gpibWAIT = Convert.ToInt16(readIniFile("FILEPATHS", "gpibWAIT", "C:\SQBODY_files\localConfigSQ_Lbl_Mgr.ini"))
        ccorescannerWAIT = Convert.ToInt16(readIniFile("FILEPATHS", "ccorescannerWAIT", "C:\SQBODY_files\localConfigSQ_Lbl_Mgr.ini"))
        DBfilepath = readIniFile("FILEPATHS", "DBfilepath", "C:\SQBODY_files\localConfigSQ_Lbl_Mgr.ini")
        PRNfolder = readIniFile("FILEPATHS", "PRNfolder", "C:\SQBODY_files\localConfigSQ_Lbl_Mgr.ini")
        LogFolder = readIniFile("FILEPATHS", "LogFolder", "C:\SQBODY_files\localConfigSQ_Lbl_Mgr.ini")

        '*******************************************************************Initialize DB
        'LoadDBfile()
        If DBfilepath IsNot "" Then
            txtbDBfilepath.Text = DBfilepath
            txtbDBfilepath.BackColor = Color.LightGreen
        Else
            txtbDBfilepath.Text = "Error Loading DB"
            txtbDBfilepath.BackColor = Color.Red
        End If

        If PRNfolder IsNot "" Then
            txtbPRNfolder.Text = PRNfolder
            txtbPRNfolder.BackColor = Color.LightGreen
        Else
            txtbPRNfolder.Text = "Error Locating Folder"
            txtbPRNfolder.BackColor = Color.Red
        End If

        If LogFolder IsNot "" Then
            Using sr As StreamReader = File.OpenText(LogFolder + "SQBody_Master_Log.log")
                Do Until sr.EndOfStream
                    txtbLOG.Text = txtbLOG.Text + sr.ReadLine + vbCrLf
                Loop
            End Using
            txtbLOGfolder.Text = LogFolder
            txtbLOGfolder.BackColor = Color.LightGreen
        Else
            txtbLOGfolder.Text = "Error Locating Folder"
            txtbLOGfolder.BackColor = Color.Red
        End If

        ToolStripStatusLabel1.Text = "Press Start to Begin.."
    End Sub

    'Private Sub ChangeLanguage(ByVal lang As String)
    '    For Each c As Control In Me.Controls
    '        Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
    '        resources.ApplyResources(c, c.Name, New CultureInfo(lang))
    '    Next c
    'End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As Integer

        result = MessageBox.Show("Do you want to save the log file and exit?", Me.Text, MessageBoxButtons.OKCancel)

        If result = DialogResult.Cancel Then
            e.Cancel = True
        ElseIf result = DialogResult.OK Then

            Using sw As StreamWriter = File.CreateText(LogFolder + "SQBody_Master_Log.log")
                sw.WriteLine(txtbLOG.Text)
            End Using
            MessageBox.Show("Log File Saved in : " + LogFolder + "SQBody_Master_Log.log")
        End If
    End Sub
    Private Sub txtbEXITapp_Click(sender As Object, e As EventArgs) Handles txtbEXITapp.Click
        Me.Close()
    End Sub



    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'MessageBox.Show("press" + +"1")
        If e.KeyChar.ToString = " " Then
            e.Handled = True
            btnUSBprintZPL.PerformClick()
        End If
    End Sub

End Class
