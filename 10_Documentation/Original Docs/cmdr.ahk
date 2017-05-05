FileDelete, temp

;;;CREATE LABEL CODE FROM THE DATABASE
;; FIRST LABEL - [Name,Amps,Volt] -comma seperated, do not include commas in the keys for these entries.
IniRead, O, DB.ini, %1%, Name
if(O = "ERROR"){
	MsgBox This Key Doesnt Exist
	return
}
LabelCode = %O%

IniRead, O, DB.ini, %1%, Amps
if(O = "ERROR"){
	MsgBox Something went wrong, check the database files
	return
}
LabelCode = %LabelCode%,%O%

IniRead, O, DB.ini, %1%, Volt
if(O = "ERROR"){
	MsgBox Something went wrong, check the database files
	return
}
LabelCode = %LabelCode%,%O%


;; SECOND LABEL - [IEC;MaxA] -colon seperated, do not include semicolons in the keys for these entries. colon used instead of comma since the IEC must contain a comma.
IniRead, O, DB.ini, %1%, StdC
if(O = "ERROR"){
	MsgBox Something went wrong, check the database files
	return
}

;;;FIRST AND SECOND LABEL ARE SEPERATED BY A SINGLE PIPELINE '|'
LabelCode = %LabelCode%|%O%
IniRead, O, DB.ini, %1%, MaxA
if(O = "ERROR"){
	MsgBox Something went wrong, check the database files
	return
}
LabelCode = %LabelCode%;%O%


;;;CREATE FILE WITH LABEL CODE
file := FileOpen("temp", "rw")
file.Write(LabelCode)
file.Close()



;;;OPEN THE COMMANDER PROGRAM FOR THE LABEL TEMPLATE AND ACTIVATE
Process, Exist, cmdr.exe

if %ErrorLevel% 
{
	WinActivate, ahk_exe cmdr.exe
	SplashTextOn, , , Activating Commander
	WinWaitActive, ahk_exe cmdr.exe
	Send, {F4}
	WinKill, ahk_exe cmdr.exe
	SplashTextOn, , , Closing Commander
}

WinWaitClose, ahk_exe cmdr.exe

IniRead, J, DB.ini, %1%, CCC
if(J = "YES"){
	Run, C:\Production\Template-CCC.tl
	}
Else {
	Run, C:\Production\Template-NoCCC.tl
	}

WinWait, ahk_exe cmdr.exe
SplashTextOn, , , Starting Commander
WinActivate, ahk_exe cmdr.exe
WinWaitActive, ahk_exe cmdr.exe
SplashTextOn, , , Activating Commander
Send, {F3}

SplashTextOff
SplashTextOn, , , Commander is now Running.
WinMove, Commander is now Running., , 0, 0
Sleep, 2000
SplashTextOff

Return
