namespace Undefined.Lambdas.Extensions.Delegators;

public static class DelegateExtensions
{
    public static TReturn Invoke<TReturn, TParametersDeclare>(this IFuncParameterized func,
        TParametersDeclare parameters)
        where TParametersDeclare : struct, IRequiredParameters<TParametersDeclare>, IParameterized =>
        ((IFunc<TReturn, TParametersDeclare>)func).Invoke(parameters);

    public static TReturn Invoke<TReturn, TParametersDeclare>(this IFuncParameterized func,
        TParametersDeclare parameters)
        where TParametersDeclare : struct, IRequiredParameters<TParametersDeclare>, IParameterized =>
        ((IFunc<TReturn, TParametersDeclare>)func).Invoke(parameters);
}