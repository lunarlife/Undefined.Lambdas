namespace Undefined.Lambdas.Extensions.BlockBodyBuilder;

public delegate DelegateParameterized InvokeResolver(LambdaBlockBuilderContext context);

public static partial class LambdaBodyBuilderExtensions
{
    public static IStackVariable Invoke(this IBodyBuilder builder, IAction del,
        IDelegateInputValueCollection collection)
    {
    }

    public static void Invoke(this IBodyBuilder builder, Action action)
    {
        builder.Invoke(Handle.From(action))
        return;
    }

    public static void Invoke(this IBodyBuilder builder, Handle handleable)
    {
        builder.Add(constructor => constructor.Invoke(action));
        return;
    }   
    public static void Invoke<T>(this IBodyBuilder builder, IRuntimeValue handle)
    {
        builder.Add(constructor => constructor.Invoke(action));
        return;
    }
}