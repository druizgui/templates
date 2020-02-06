:: ------------------------------------------------------------------------------------------------------------------
:: Copyright (C) 2020, David Ruiz. Licensed under the Apache License, Version 2.0. 
:: You may not use this file except in compliance with the License: http://www.apache.org/licenses/LICENSE-2.0
:: Software is distributed on an "AS IS", WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
:: ------------------------------------------------------------------------------------------------------------------

SET PROJECTNAME=AdventureWorks
SET REPOSITORY=https://github.com/<account>/%PROJECTNAME%.git

git clone %REPOSITORY% %PROJECTNAME%
cd                     %PROJECTNAME%

git init
dotnet new gitignore
git add .
git commit -m "startup project"
git push

git checkout -b dev
git push --set-upstream origin dev

dotnet new sln         %PROJECTNAME%

dotnet new classlib -n %PROJECTNAME%.App -f netcoreapp3.1

dotnet new classlib -n %PROJECTNAME%.Data -f netcoreapp3.1
dotnet sln add         %PROJECTNAME%.Data

dotnet new classlib -n %PROJECTNAME%.Dom 
dotnet sln add         %PROJECTNAME%.Dom
dotnet new mstest   -n %PROJECTNAME%.Tests
dotnet sln add         %PROJECTNAME%.Tests

dotnet new console  -n %PROJECTNAME%.Con
dotnet sln add         %PROJECTNAME%.Con


:: dotnet add package Microsoft.EntityFrameworkCore.Tools 
:: dotnet add package Microsoft.EntityFrameworkCore.Design
:: dotnet add package Microsoft.EntityFrameworkCore.InMemory
:: dotnet add package Microsoft.EntityFrameworkCore.SqlServer
:: dotnet add package System.ComponentModel.Annotations

:: Code Analysis
:: dotnet add package Microsoft.CodeAnalysis.FxCopAnalyzers
:: dotnet add package SecurityCodeScan
