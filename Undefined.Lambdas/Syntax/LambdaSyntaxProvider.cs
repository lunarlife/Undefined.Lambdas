using Undefined.Lambdas.Abstraction.Syntax;
using Undefined.Lambdas.Abstraction.Syntax.Stack;
using Undefined.Lambdas.Abstraction.Syntax.Variables;
using Undefined.Lambdas.Abstraction.Variables;
using Undefined.Lambdas.Syntax.Stack;

namespace Undefined.Lambdas.Syntax;

internal class LambdaSyntaxProvider : ILambdaSyntaxProvider
{
    private static readonly ThreadLocal<ILambdaSyntaxProvider?> ExecutingProviderThreaded = new();

    public static ILambdaSyntaxProvider ExecutingProvider
    {
        get
        {
            if (ExecutingProviderThreaded.Value is null)
                throw new InvalidOperationException($"There is no {nameof(ILambdaSyntaxProvider)} on current thread.");
            return ExecutingProviderThreaded.Value;
        }
    }

    public ILambdaStack Stack { get; } = new LambdaStack();

    private static ILambdaSyntaxProvider? ChangeExecutingProvider(ILambdaSyntaxProvider? provider)
    {
        ILambdaSyntaxProvider? oldProvider = null;
        if (ExecutingProviderThreaded.Value is not null)
        {
            oldProvider = ExecutingProviderThreaded.Value;
        }
        
        ExecutingProviderThreaded.Value = provider;
        return oldProvider;
    }

    public IVariable DeclareVariable(Type type, string name) => new 

    public void VariableSet(IVariable variable, IValue value) => throw new NotImplementedException();
    public IStackValue VariableGet(IVariable variable) => throw new NotImplementedException();

    public void Return(IValue? value) => throw new NotImplementedException();
}