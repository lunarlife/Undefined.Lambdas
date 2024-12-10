using Undefined.Lambdas.Abstraction.Methods;
using Undefined.Lambdas.Abstraction.Syntax.Stack;
using Undefined.Lambdas.Abstraction.Syntax.Variables;
using Undefined.Lambdas.Abstraction.Values;
using Undefined.Lambdas.Abstraction.Variables;

namespace Undefined.Lambdas.Abstraction.Syntax;

public interface ILambdaSyntaxProvider
{
    public ILambdaStack Stack { get; }
    public IVariable DeclareVariable(Type type, string name);
    public void VariableSet(IVariable variable, IValue value);
    public IStackValue VariableGet(IVariable variable);
    public void Return(IValue? value);
}