# Start The .NET 8 TDD Project

This challenge should start with tests. The project is a small library, not an API, so create a solution with:

- one class library for the Roman numeral converter
- one xUnit test project for the tests

## 1. Create The Solution

Run these commands from the repository root:

```powershell
dotnet new sln -n swchallenge2
dotnet new classlib -n RomanNumerals -o src/RomanNumerals
dotnet new xunit -n RomanNumerals.Tests -o tests/RomanNumerals.Tests
dotnet sln swchallenge2.sln add src/RomanNumerals/RomanNumerals.csproj
dotnet sln swchallenge2.sln add tests/RomanNumerals.Tests/RomanNumerals.Tests.csproj
dotnet add tests/RomanNumerals.Tests/RomanNumerals.Tests.csproj reference src/RomanNumerals/RomanNumerals.csproj
```

## 2. Install Coverage Tool

Install the coverage collector in the test project:

```powershell
dotnet add tests/RomanNumerals.Tests/RomanNumerals.Tests.csproj package coverlet.collector
```

## 3. Run The First Test

Before writing converter code, create the first failing test in the test project. Example first behavior:

- `1` converts to `I`

Then run:

```powershell
dotnet test
```

The test should fail first. That is the red step.

## 4. Follow The TDD Cycle

For every small behavior:

1. Write one failing test.
2. Run the tests and confirm it fails.
3. Write the simplest library code that makes it pass.
4. Run the tests again.
5. Refactor only when tests are green.
6. Commit each step.

Useful commands:

```powershell
dotnet test
git status
git add .
git commit -m "test: add failing case for 1 as I"
git commit -m "feat: pass case for 1 as I"
git commit -m "refactor: simplify roman numeral conversion"
```

## 5. Run Coverage

Use this before submitting:

```powershell
dotnet test --collect:"XPlat Code Coverage"
```

The final target is at least 90% line coverage.

## Suggested First Test Cases

Start small and grow one case at a time:

- `1` -> `I`
- `2` -> `II`
- `3` -> `III`
- `4` -> `IV`
- `5` -> `V`
- `9` -> `IX`
- `40` -> `XL`
- `90` -> `XC`
- `400` -> `CD`
- `900` -> `CM`

Do not implement all cases at once. Each case should drive the next small code change.
