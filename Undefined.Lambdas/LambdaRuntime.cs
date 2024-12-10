namespace Undefined.Lambdas;

internal class LambdaRuntime : LambdaCompiled, ILambdaRuntime
{
    public LambdaRuntime( ICompiledMethod compiledMethod) : base(compiledMethod)
    {
    }

    public IUCollection<IRuntimeDeclarable> LambdaTree { get; }
}