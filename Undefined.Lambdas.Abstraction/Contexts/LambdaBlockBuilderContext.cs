using Undefined.Lambdas.Abstraction.Blocks.Bodies;

namespace Undefined.Lambdas.Abstraction.Contexts;

public readonly struct LambdaBlockBuilderContext
{
    public IBodyBuilder Block { get; }
    
    public LambdaBlockBuilderContext(IBodyBuilder block)
    {
        Block = block;
    }

}