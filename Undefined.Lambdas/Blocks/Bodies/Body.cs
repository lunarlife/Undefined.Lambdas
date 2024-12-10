namespace Undefined.Lambdas.Blocks.Bodies;

internal class Body : IBody
{
    public Body(ILambdaBlock block)
    {
        Block = block;
    }

    public void Declare(IRuntimeMethodBodyConstructor constructor)
    {
    }

    public ILambdaBlock Block { get; }
}