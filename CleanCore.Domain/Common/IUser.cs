namespace CleanCore.Domain.Common;

/// <summary>
/// The user interface
/// </summary>
/// <seealso cref="IUser"/>
public interface IUser<TUserId> : IUser
    where TUserId : IEquatable<TUserId>
{
    /// <summary>
    /// Gets the value of the sub
    /// </summary>
    TUserId Sub { get; }
}
/// <summary>
/// The user interface
/// </summary>
public interface IUser
{
    /// <summary>
    /// Gets the value of the name
    /// </summary>
    string Name { get; }
}
