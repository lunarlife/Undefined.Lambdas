using Undefined.Lambdas.Abstraction.TypeBuilding;

namespace Undefined.Lambdas.Abstraction.Methods;

public interface ICompiledMethodReturnType
{
    public IRuntimeType ReturnType { get; }
}

public interface ICompiledMethodReturnType<TReturn> : ICompiledMethodReturnType
{
    IRuntimeType ICompiledMethodReturnType.ReturnType => ReturnType;

    public new  IRuntimeType<TReturn> ReturnType { get; }

}