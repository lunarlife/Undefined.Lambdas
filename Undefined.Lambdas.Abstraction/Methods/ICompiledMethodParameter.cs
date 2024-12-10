using Undefined.Lambdas.Abstraction.TypeBuilding;

namespace Undefined.Lambdas.Abstraction.Methods;

public interface ICompiledMethodParameter
{
    public IRuntimeType ParameterType { get; }
    public bool IsOptional { get; }
    public string DefaultValue { get; }
}