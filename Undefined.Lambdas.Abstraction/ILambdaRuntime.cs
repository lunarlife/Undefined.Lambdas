using Undefined.Lambdas.Abstraction.Methods;
using Undefined.Lambdas.Abstraction.Presentations;

namespace Undefined.Lambdas.Abstraction;

public static class Lambda
{
    public static Func<TReturn> Func<TReturn>(Func<TReturn> func) 
    {
        return new Func<TReturn>;
    }

    public static IAction<IpT> Action<T>(Action<T> valueFunc)
    {
    }
    public static IFunc<T> Query<T>(Func<T> queryFunc) 
}

public interface ILambdaRuntime : ILambdaCompiled
{
    public IUCollection<IRuntimeDeclarable> LambdaTree { get; }
}

public interface ILambdaCompiled
{
    public IMethod Method { get; }
    public IAction DefaultDelegate { get; }
}