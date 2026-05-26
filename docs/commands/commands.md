# Commands
```bash
dotnet new sln -n swchallenge2
dotnet new classlib -n RomanNumerals
dotnet new xunit -n RomanNumerals.Tests
dotnet sln .\swchallenge2.sln add .\RomanNumerals\RomanNumerals.csproj
dotnet sln .\swchallenge2.sln add .\RomanNumerals.Tests\RomanNumerals.Tests.csproj
```

## Add the library as reference for test project
```bash
dotnet add .\RomanNumerals.Tests\RomanNumerals.Tests.csproj reference .\RomanNumerals\RomanNumerals.csproj
```
