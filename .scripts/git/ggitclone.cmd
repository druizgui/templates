:: ------------------------------------------------------------------------------------------------------------------
:: Copyright (C) 2020, David Ruiz. Licensed under the Apache License, Version 2.0. 
:: You may not use this file except in compliance with the License: http://www.apache.org/licenses/LICENSE-2.0
:: Software is distributed on an "AS IS", WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: ------------------------------------------------------------------------------------------------------------------
@echo off

SET PREFIX=https://github.com/{usergithub}/
SET SUFFIX=.git

:: Set your repositories here:
SET REPOSITORIES=repo1 repo2 repo3

IF NOT "%1"=="" SET REPOSITORIES=%*

for %%i in (%REPOSITORIES%) do (
	echo clone %PREFIX%%%i%SUFFIX% 
	git  clone %PREFIX%%%i%SUFFIX% 
)
