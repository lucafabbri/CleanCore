using ErrorOr;

namespace Clean.Core.Extensions;

public static class ErrorOrExtension
{
    public static TValue? ValueOrNull<TValue>(this ErrorOr<TValue> result)
    {
        return result.IsError ? default : result.Value;
    }
}
