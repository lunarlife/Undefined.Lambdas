namespace Undefined.Lambdas.Values;

internal class RuntimeValueImpl : IRuntimeValue<>
{
    public RuntimeValueImpl()
    {
        
    }
    public void Declare(IRuntimeMethodBodyConstructor constructor) => throw new NotImplementedException();
}
internal class RuntimeValueImpl<T> : RuntimeValueImpl
{
    public void Emit(IRuntimeMethodBodyConstructor constructor)
    {
    }
}