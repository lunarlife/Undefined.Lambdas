using Undefined.Lambdas.Utils;

namespace Undefined.Lambdas.Blocks.Bodies;

internal class BodyBuilder : UCollection<Presentation>, IBodyBuilder
{
    public ILambdaBlock Block { get; }
    public IBlockCollection Blocks { get; }
    public ILambdaBlock? BaseBlock { get; }
    public ILambdaFrame Frame { get; }
    public IBody Build() => new Body(Block, Blocks, BaseBlock, Frame);
}