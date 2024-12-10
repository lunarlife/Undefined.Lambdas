using Undefined.Lambdas.Abstraction.TypeBuilding;
using Undefined.Lambdas.Abstraction.Values;

namespace Undefined.Lambdas.Abstraction.Methods.CallSites;

public interface IValueCallSite : IValue
{
}

public interface IValueCallSite<TValue> : IValueCallSite, IValue<TValue>
{
}
