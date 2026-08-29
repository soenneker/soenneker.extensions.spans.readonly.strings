[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.readonly.strings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.strings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.strings/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.strings/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.readonly.strings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.strings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.strings/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.strings/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.ReadOnly.Strings
A collection of helpful ReadOnlySpan (string) extension methods.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.ReadOnly.Strings
```

## Quick start

```csharp
using Soenneker.Extensions.Spans.ReadOnly.Strings;
```

Import the namespace, then call the extension methods directly on the matching value.

## Common operations

- `ContainsAPart()` - Determines whether any element in the specified span contains the given substring, using the specified string comparison option.
- `JoinStrings()` - Concatenates the elements of a read-only span of strings, using the specified separator character between each element. Optionally inserts a space after each separator.
