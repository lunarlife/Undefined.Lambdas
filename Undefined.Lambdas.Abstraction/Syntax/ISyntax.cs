using Undefined.Lambdas.Abstraction.Compilation;

namespace Undefined.Lambdas.Abstraction.Syntax;

public interface ISyntax
{
    public void Declare(ILambdaCompiler compiler);
}