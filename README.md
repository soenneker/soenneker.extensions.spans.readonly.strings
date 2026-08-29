[![](https://img.shields.io/nuget/v/soenneker.extensions.spans.readonly.strings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.strings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.strings/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.strings/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.spans.readonly.strings.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.spans.readonly.strings/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.spans.readonly.strings/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.spans.readonly.strings/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Spans.ReadOnly.Strings
Searches and joins spans of strings without first materializing another collection.

## Installation

```bash
dotnet add package Soenneker.Extensions.Spans.ReadOnly.Strings
```

## Usage

```csharp
using Soenneker.Extensions.Spans.ReadOnly.Strings;

ReadOnlySpan<string> values = ["alpha", "Beta", "gamma"];
bool found = ReadOnlySpanStringExtension.ContainsAPart(values, "bet", StringComparison.OrdinalIgnoreCase); // true

ReadOnlySpan<string?> pieces = ["one", null, "three"];
string joined = ReadOnlySpanStringExtension.JoinStrings(pieces, ',', includeSpace: true);
// "one, , three"
```

`ContainsAPart()` skips null elements, stops at the first match, and uses exactly the supplied `StringComparison`.

`JoinStrings()` uses a pooled builder. Separators are position-based: a null element contributes no text but still leaves its separator position, as the example shows. An empty span returns `""`; `includeSpace` adds one space after every separator.
