using Undefined.Lambdas.Abstraction.TypeBuilding;

namespace Undefined.Lambdas.Abstraction.Syntax.Variables;

public interface IRuntimeValue
{
    public IRuntimeType Type { get; }
}

public interface IRuntimeValue<T> : IRuntimeValue
{
    public new IRuntimeType<T> Type { get; }
}