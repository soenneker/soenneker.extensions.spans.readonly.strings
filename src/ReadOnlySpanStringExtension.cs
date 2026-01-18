using System;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.Spans.ReadOnly.Strings;

/// <summary>
/// A collection of helpful ReadOnlySpan (string) extension methods
/// </summary>
public static class ReadOnlySpanStringExtension
{
    /// <summary>
    /// Determines whether any element in the specified span contains the given substring, using the specified string
    /// comparison option.
    /// </summary>
    /// <remarks>Null elements within the span are ignored during the search. The search uses the specified
    /// StringComparison value for each element.</remarks>
    /// <param name="span">The read-only span of strings to search.</param>
    /// <param name="part">The substring to seek within each element of the span. Cannot be null.</param>
    /// <param name="comparison">One of the enumeration values that specifies the rules for the substring search, such as case sensitivity and
    /// culture.</param>
    /// <returns>true if any non-null element in the span contains the specified substring; otherwise, false.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool ContainsAPart(ReadOnlySpan<string> span, string part, StringComparison comparison)
    {
        for (int i = 0; i < span.Length; i++)
        {
            string? current = span[i];

            if (current is not null && current.IndexOf(part, comparison) >= 0)
                return true;
        }

        return false;
    }
}
