using ErrorOr;

namespace CleanCore.Core.Extensions;

/// <summary>
/// The error or extension class
/// </summary>
public static class ErrorOrExtension
{
    /// <summary>
    /// Values the or null using the specified result
    /// </summary>
    /// <typeparam name="TValue">The value</typeparam>
    /// <param name="result">The result</param>
    /// <returns>The value</returns>
    public static TValue? ValueOrNull<TValue>(this ErrorOr<TValue> result)
    {
        return result.IsError ? default : result.Value;
    }
}
