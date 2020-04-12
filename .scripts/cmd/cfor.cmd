::@echo off
set rootpath=%1
set currentpath=%cd%

if "%rootpath%"=="" set rootpath=.
::cd %rootpath%\
@setlocal enableextensions enabledelayedexpansion
for /f "delims=" %%p in ('dir /b %rootpath%\*.txt') do (
	set x=%%p
	echo file: !x:~0,-4!
)

for /f %%p in ('dir /b *.dll') do (
	echo -^> file: %%p	
)
pause

::cd /D %currentpath%