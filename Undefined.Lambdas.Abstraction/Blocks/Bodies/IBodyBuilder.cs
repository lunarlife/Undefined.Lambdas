using Undefined.Lambdas.Abstraction.Presentations;

namespace Undefined.Lambdas.Abstraction.Blocks.Bodies;

public interface IBodyBuilder : IUCollection<Presentation>
{
    public IVariableCollection Vars { get; }

    public IBlockCollection Blocks { get; }
    public ILambdaBlock? BaseBlock { get; }
    public IBody Build();

}
