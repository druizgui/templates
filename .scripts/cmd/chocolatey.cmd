@echo off
::See https://chocolatey.org/

SET applications=notepadplusplus googlechrome keepass foxitreader resharper mousewithoutborders

echo install the folloging applications:
for %%p in (%applications%) do echo 	%%p

pause
for %%p in (%applications%) do (
	echo choco install %%p -ia "INSTALLDIR=""D:\Program Files""" -y
)


