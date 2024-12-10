namespace Undefined.Lambdas;

internal class LambdaCompiled : ILambdaCompiled
{
    public LambdaCompiled(ICompiledMethod compiledMethod)
    {
        CompiledMethod = compiledMethod;
    }

    public ICompiledMethod CompiledMethod { get; }
    public IAction DefaultDelegate { get; }
}