using Undefined.Lambdas.Abstraction.Syntax;

namespace Undefined.Lambdas.Abstraction.Compilation;

public interface ILambdaCompiler
{
    public ILambdaCompiled Compile(ISyntaxTree syntaxTree);
}