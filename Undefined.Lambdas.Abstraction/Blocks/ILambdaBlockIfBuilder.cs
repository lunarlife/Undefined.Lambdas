using Undefined.Lambdas.Abstraction.Blocks.Bodies;
using Undefined.Lambdas.Abstraction.TypeBuilding;

namespace Undefined.Lambdas.Abstraction.Blocks;

public interface ILambdaBlockIfBuilder : ILambdaBlockBaseBuilder
{
    public IBodyBuilder Condition(ICondition condition);

}