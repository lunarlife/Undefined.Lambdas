using Undefined.Lambdas.Abstraction.Syntax;
using Undefined.Lambdas.Abstraction.TypeBuilding;

namespace Undefined.Lambdas.Abstraction.Values;

public interface IValue : ISyntax
{
    public IRuntimeType Type { get; }
}

public interface IValue<TValue> : IValue
{
    public new IRuntimeType<TValue> Type { get; }
}