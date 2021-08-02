REG ADD HKEY_CLASSES_ROOT\*\SHELL\DECRYPT\COMMAND /VE /D "%~dp0QuickEncrypt.exe -g -d \"%%1\""  /f
REG ADD HKEY_CLASSES_ROOT\*\SHELL\ENCRYPT\COMMAND /VE /D "%~dp0QuickEncrypt.exe -g -e \"%%1\""  /f
pause