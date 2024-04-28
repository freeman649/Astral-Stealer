@echo off
echo Installing Python 3 and pip...
set PYTHON_VERSION=3.12.2
set PYTHON_URL=https://www.python.org/ftp/python/%PYTHON_VERSION%/python-%PYTHON_VERSION%-amd64.exe
set PIP_URL=https://bootstrap.pypa.io/get-pip.py
set PYTHON_INSTALLER=python-%PYTHON_VERSION%-amd64.exe
set PIP_INSTALLER=get-pip.py

echo Downloading Python 3 installer from %PYTHON_URL%...
curl -L -o %PYTHON_INSTALLER% %PYTHON_URL%
echo Installing Python 3...
start /wait %PYTHON_INSTALLER% /quiet InstallAllUsers=1 PrependPath=1 Include_test=0
echo Installing pip...
curl -L -o %PIP_INSTALLER% %PIP_URL%
python %PIP_INSTALLER%
echo Cleaning up...
del %PYTHON_INSTALLER%
del %PIP_INSTALLER%

echo Done.
pause
