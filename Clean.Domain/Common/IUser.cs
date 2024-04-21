namespace Clean.Domain.Common;

public interface IUser<TUserId> : IUser
    where TUserId : IEquatable<TUserId>
{
    TUserId Sub { get; }
}
public interface IUser
{
    string Name { get; }
}
