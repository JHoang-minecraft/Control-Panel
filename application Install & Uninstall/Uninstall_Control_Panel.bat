@echo off
set "STARTMENU=%APPDATA%\Microsoft\Windows\Start Menu\Programs"
set "SHORTCUT=%STARTMENU%\Control Panel.lnk"
if exist "%SHORTCUT%" (
    del "%SHORTCUT%"
    echo Shortcut removed: %SHORTCUT%
) else (
    echo Shortcut not found: %SHORTCUT%
)
pause
