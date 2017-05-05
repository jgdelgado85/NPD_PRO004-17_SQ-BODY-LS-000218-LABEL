Gui, Add, GroupBox, w200 h250, Add/Change Database Entry
Gui, Add, Text,yp+50 xp+40, Name:
Gui, Add, Edit, vName
Gui, Add, Text,, Voltage:
Gui, Add, Edit, vVolt
Gui, Add, Text,, Amperage:
Gui, Add, Edit, vAmps
Gui, Add, Text,, X:
Gui, Add, Edit, vX

Gui, Add, Button, W30 Center, OK
Gui, Show
return

GuiClose(GuiHwnd) {  ; Declaring this parameter is optional.
    MsgBox 4,, Are you sure you want to close the GUI?
    ifMsgBox No
        return true  ; true = 1
}


ButtonOK:
{
	Gui, Submit
	IniWrite, %Name%, test.ini, %Name%, Name
	IniWrite, %Volt%, test.ini, %Name%, Volt
	IniWrite, %Amps%, test.ini, %Name%, Amps
	MsgBox You entered:`n%Name%`n%Volt%`n%Amps% `n `n These values have been added in the database.
}



FileExit:     ; User chose "Exit" from the File menu.
GuiClose:  ; User closed the window.
ExitApp


;IniWrite, Hello, test.ini, Section, Key