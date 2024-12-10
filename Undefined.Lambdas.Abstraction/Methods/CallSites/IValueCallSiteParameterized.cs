using Undefined.Lambdas.Abstraction.Values;

namespace Undefined.Lambdas.Abstraction.Methods.CallSites;

public interface IValueCallSiteParameterized : IValue
{
    public IParameterBuilder GetParametersBuilder();
}

public interface IValueCallSiteParameterized<TValue> : IValueCallSiteParameterized, IValue<TValue>
{
}

public interface IValueCallSiteParameterized<TReturn, TParameters> : IValueCallSiteParameterized<TReturn>
{
    public new IParameterBuilder<TParameters> GetParametersBuilder();
}