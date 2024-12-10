using Undefined.Lambdas.Abstraction.Blocks.Bodies;

namespace Undefined.Lambdas.Abstraction.Blocks;

public interface ILambdaBlockDefaultBuilder : ILambdaBlockBaseBuilder
{
    public IBodyBuilder Body { get; }
}