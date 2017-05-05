Process, Exist, cmdr.exe
SplashTextOn, , , %ErrorLevel%

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

Run, C:\Production\%1%
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
