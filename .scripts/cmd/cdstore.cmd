@echo off
set currentpath=%cd%
echo currentpath: %currentpath%
cd \
dir /AD /B
cd %currentpath%
