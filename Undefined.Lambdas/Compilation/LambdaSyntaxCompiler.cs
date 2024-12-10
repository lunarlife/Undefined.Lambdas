using Undefined.Lambdas.Abstraction.Syntax;
using Undefined.Lambdas.Syntax;

namespace Undefined.Lambdas.Compilation;

public class LambdaSyntaxCompiler
{
    public void Compile(ILambdaSyntaxProvider provider, Action syntaxGenerator)
    {
        SyntaxFactory.CompileFor();
    }
}