using Undefined.Lambdas.Abstraction.Presentations;

namespace Undefined.Lambdas.Abstraction.Blocks.Bodies;

public interface IBody : IRuntimeDeclarable
{
    public ILambdaBlock Block { get; }
}