
# reference for the dotnet command
# https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet?tabs=netcore21

## create the console project for quotable.console
## the name of the project is inferred from the output directory
dotnet new console --output quotable.console

## create the library project for quotable.core
dotnet new classlib --output quotable.core

## create the nunit test project for quotable.core
dotnet new nunit --output quotable.core.test

## create the aspnet.core project for the quotable.api
dotnet new webapi --output quotable.api

## create the nunit test project for the quotable.api
dotnet new nunit --output quotable.api.test


# setup the solution
## create the empty solution file
## the name of the solution fie is inferred from the directory
dotnet new sln

## add the projects to the solution
## the project to add is inferred by the directory that is passed in
## the dotnet command will look for a single file with a csproj extension in the directory
## for example, "dotnet sln add quotable.console" will look for a ".csproj" file in the "quotable.console"
dotnet sln add quotable.console
dotnet sln add quotable.core
dotnet sln add quotable.core.test
dotnet sln add quotable.api
dotnet sln add quotable.api.test

dotnet add quotable.console\quotable.console.csproj reference quotable.core\quotable.core.csproj
dotnet add quotable.core.test\quotable.core.test.csproj reference quotable.core\quotable.core.csproj
dotnet add quotable.api\quotable.api.csproj reference quotable.core\quotable.core.csproj
dotnet add quotable.api.test\quotable.api.test.csproj reference quotable.api\quotable.api.csproj

