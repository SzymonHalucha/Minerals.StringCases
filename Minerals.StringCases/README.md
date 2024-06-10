# Minerals.StringCases

Optimized NuGet package with minimum memory allocation designed to help you convert strings to names cases such as Pascal, Camel, Kebab, Snake, Macro, Train and Title.

## Features

- **Wide choice of cases:** PascalCase, camelCase, _underscoreCamelCase, kebab-case, snake_case, MACRO_CASE, Train-Case, Title Case.
- **Performance:** The package is optimized for speed and memory allocation.
- **Universal:** Convert from any freely formatted string.
- **Compatible with .NET Standard 2.0:** Works on a wide range of platforms and development environments.

## Installation

Add the Minerals.StringCases nuget package to your C# project using the following methods:

### 1. Project file definition

```xml
<PackageReference Include="Minerals.StringCases" Version="0.2.0" />
```

### 2. dotnet command

```bat
dotnet add package Minerals.StringCases
```

## Usage

```csharp
using Minerals.StringCases;

string sampleText = "  _ example Variable - - Name   321";

string pascalCase = sampleText.ToPascalCase();
// ExampleVariableName321

string camelCase = sampleText.ToCamelCase();
// exampleVariableName321

string underscoreCamelCase = sampleText.ToUnderscoreCamelCase();
// _exampleVariableName321

string kebabCase = sampleText.ToKebabCase();
// example-variable-name-321

string snakeCase = sampleText.ToSnakeCase();
// example_variable_name_321

string macroCase = sampleText.ToMacroCase();
// EXAMPLE_VARIABLE_NAME_321

string trainCase = sampleText.ToTrainCase();
// Example-Variable-Name-321

string titleCase = sampleText.ToTitleCase();
// Example Variable Name 321
```

## Performance and comparison

Here is a comparison of the speed and amount of memory allocation with the most popular NuGet package similar to [Minerals.StringCases](https://www.nuget.org/packages/Minerals.StringCases/) version 0.1.0 - [CaseExtesions](https://www.nuget.org/packages/CaseExtensions/) version 1.1.0.

String used to perform the comparison:

```csharp
string sampleText = "  _ example Variable - - Name   321";
```

### Results

```log
BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4291/22H2/2022Update)
AMD Ryzen 5 2600, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.204
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  Job-LXTTHC : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```

| Method                          | Runtime  | Mean     | Error   | StdDev  | Gen0   | Allocated |
|-------------------------------- |--------- |---------:|--------:|--------:|-------:|----------:|
| CamelCase_Minerals_StringCases  | .NET 8.0 | 153.0 ns | 1.32 ns | 1.03 ns | 0.0343 |     144 B |
| PascalCase_Minerals_StringCases | .NET 8.0 | 159.2 ns | 2.11 ns | 1.98 ns | 0.0343 |     144 B |
| SnakeCase_Minerals_StringCases  | .NET 8.0 | 187.9 ns | 1.12 ns | 1.00 ns | 0.0362 |     152 B |
| KebabCase_Minerals_StringCases  | .NET 8.0 | 202.1 ns | 1.94 ns | 1.82 ns | 0.0362 |     152 B |
| TrainCase_Minerals_StringCases  | .NET 8.0 | 213.2 ns | 1.22 ns | 1.08 ns | 0.0362 |     152 B |
| -                               | -        | -        | -       | -       | -      |     -     |
| PascalCase_CaseExtensions       | .NET 8.0 | 517.7 ns | 4.23 ns | 3.96 ns | 0.0973 |     408 B |
| KebabCase_CaseExtensions        | .NET 8.0 | 529.3 ns | 3.52 ns | 3.29 ns | 0.0992 |     416 B |
| SnakeCase_CaseExtensions        | .NET 8.0 | 531.2 ns | 4.56 ns | 4.26 ns | 0.0992 |     416 B |
| TrainCase_CaseExtensions        | .NET 8.0 | 533.5 ns | 5.08 ns | 4.50 ns | 0.0992 |     416 B |
| CamelCase_CaseExtensions        | .NET 8.0 | 549.7 ns | 6.09 ns | 5.69 ns | 0.0973 |     408 B |

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [branches on this repository](https://github.com/SzymonHalucha/Minerals.StringCases/branches).

## Authors

- **Szymon Hałucha** - Maintainer

See also the list of [contributors](https://github.com/SzymonHalucha/Minerals.StringCases/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.
