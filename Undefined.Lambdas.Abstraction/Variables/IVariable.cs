using Undefined.Lambdas.Abstraction.Syntax.Variables;

namespace Undefined.Lambdas.Abstraction.Variables;

public interface IVariable : IValueContainer
{
    public string Name { get; }
}

public interface IVariable<T> : IVariable, IRuntimeValue<T>
{
}