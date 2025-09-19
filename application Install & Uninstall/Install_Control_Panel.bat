@echo off
set "STARTMENU=%APPDATA%\Microsoft\Windows\Start Menu\Programs"
set "SHORTCUT=%STARTMENU%\Control Panel.lnk"
set "EXE=D:\aaaaaa\Control panel\Control Panel\Control Panel\bin\Release\Control Panel.exe"
powershell -Command "$s=(New-Object -COM WScript.Shell).CreateShortcut($env:SHORTCUT);$s.TargetPath=$env:EXE;$s.WorkingDirectory='D:\aaaaaa\Control panel\Control Panel\Control Panel\bin\Release\';$s.Save()"
echo Shortcut created: %SHORTCUT%
pause
