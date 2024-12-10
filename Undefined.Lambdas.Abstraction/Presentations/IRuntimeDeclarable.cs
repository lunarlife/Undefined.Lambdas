using Undefined.Lambdas.Abstraction.Compilation;

namespace Undefined.Lambdas.Abstraction.Presentations;

public interface IRuntimeDeclarable

{
    public void Declare(IRuntimeMethodBodyConstructor constructor);
}