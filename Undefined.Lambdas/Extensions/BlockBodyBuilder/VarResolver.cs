namespace Undefined.Lambdas.Extensions.BlockBodyBuilder;

public static partial class LambdaBodyBuilderExtensions
{
    public static IVariableCollection Vars(this IBodyBuilder body) => body.Block.DeclaredVariables;
}