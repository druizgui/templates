:: ------------------------------------------------------------------------------------------------------------------
:: Copyright (C) 2020, David Ruiz. Licensed under the Apache License, Version 2.0. 
:: You may not use this file except in compliance with the License: http://www.apache.org/licenses/LICENSE-2.0
:: Software is distributed on an "AS IS", WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: ------------------------------------------------------------------------------------------------------------------
@echo off

SET CURRENTDIR=.
SET MESSAGE="Global commit"

if NOT "%2"=="" SET CURRENTDIR=%2
if NOT "%1"=="" SET MESSAGE=%1

for /f %%i in ('dir /ad /b /s %CURRENTDIR%') do (	
	IF EXIST %%i\.git (
		echo pull %%i
		git --git-dir=%%i\.git commit --all -m "%MESSAGE%"
	)
)
