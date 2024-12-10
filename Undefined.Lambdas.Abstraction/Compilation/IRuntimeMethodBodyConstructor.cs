using System.Reflection;
using Undefined.Lambdas.Abstraction.Descriptors;
using Undefined.Lambdas.Abstraction.Syntax.Variables;

namespace Undefined.Lambdas.Abstraction.Compilation;

public interface IRuntimeMethodBodyConstructor
{
    public void InvokeMethod(MethodInfo method);
    public void LoadVar(VariableIdentifier identifier);
    
    public void Descriptor(ITypeDescriptor descriptor);
    public IRuntimeMethodBody Build();
}