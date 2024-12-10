using Undefined.Lambdas.Abstraction.Stack;

namespace Undefined.Lambdas.Abstraction;

public interface ILambdaFrame : IUCollection<IStackVariable>
{
    public IFrameStackVariablesCollection FrameStackVariables { get; }
}