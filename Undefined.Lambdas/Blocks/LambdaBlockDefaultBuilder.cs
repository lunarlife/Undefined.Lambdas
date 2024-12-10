using Undefined.Lambdas.Blocks.Bodies;

namespace Undefined.Lambdas.Blocks;

internal class LambdaBlockDefaultBuilder : LambdaBlockBaseBuilder, ILambdaBlockDefaultBuilder
{
    public IBodyBuilder Body { get; } = new BodyBuilder();
}