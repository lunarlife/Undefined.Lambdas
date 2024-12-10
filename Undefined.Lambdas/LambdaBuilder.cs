using Undefined.Lambdas.Blocks.Bodies;

namespace Undefined.Lambdas;

internal class LambdaBuilder : ILambdaBuilder
{
    private LambdaBuilder(IBody body)
    {
        Body = body;
    }

    public IBody Body { get; }

    public ILambdaRuntime Compile(IRuntimeMethodBodyConstructor constructor)
    {
        MakeReadOnly();

        return new LambdaRuntime()
    }

    public static ILambdaBuilder BuildLambda(Func<IBodyBuilder, IBody> bodyBuilder) =>
        new LambdaBuilder(bodyBuilder(new BodyBuilder()));
}