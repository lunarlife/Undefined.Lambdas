using Undefined.Lambdas.Abstraction.Presentations;

namespace Undefined.Lambdas.Abstraction.Values.Input;

public interface IInputRuntimeValueOld : IRuntimeValue<>
{
    public IRuntimeDeclarable RuntimeDeclarable { get; }
}