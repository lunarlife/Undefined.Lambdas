using Undefined.Lambdas.Abstraction.Blocks.Bodies;
using Undefined.Lambdas.Abstraction.Compilation;

namespace Undefined.Lambdas.Abstraction;

public interface ILambdaBuilder
{
    public IBody Body { get; }
    public ILambdaRuntime Compile(IRuntimeMethodBodyConstructor constructor);

}
