namespace Undefined.Lambdas.Abstraction.TypeBuilding;

public interface ITypeFactoryBuilder
{
    public ITypeFactoryBuilder ParameterlessConstructor();
    public ITypeFactory Build();
}