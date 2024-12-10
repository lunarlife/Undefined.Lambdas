using Undefined.Lambdas.Abstraction.Methods.CallSites;

namespace Undefined.Lambdas.Abstraction.Methods;

public interface IMethod
{
    public bool RequiresTarget { get; }
}

public interface IValueMethod : IMethod, IValueCallSite
{
}

public interface IValueMethod<TResult> : IValueMethod, IValueCallSite<TResult>
{
}

public interface IMethodParameterized<TParameters>
    : IMethod
{
}

public interface IValueMethodParameterized<TReturn, TParameters>
    : IMethodParameterized<TParameters>, IValueCallSiteParameterized<TReturn, TParameters>
{
}