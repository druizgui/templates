@echo off
set rootpath=%1

if "%rootpath%"=="" set rootpath=.

@setlocal enableextensions enabledelayedexpansion

for /f "delims=" %%p in ('dir /b /s %rootpath%\*.csproj') do (
	set x=%%p
	echo file: !x:~0,-7!
)
::for /f %%p in ('dir /b /s %rootpath%\*.csproj') do (	echo -^> file: %%p	)