using Undefined.Lambdas.Abstraction.Methods.CallSites;

namespace Undefined.Lambdas.Abstraction.Syntax.Variables;

public interface IValueContainer : IValueCallSite, IRuntimeValue
{
    public void Assign(IRuntimeValue value);
}

public interface IValueContainer<T> : IValueContainer, IValueCallSite<T>, IRuntimeValue<T>
{
    public void Assign(IRuntimeValue<T> value);
}