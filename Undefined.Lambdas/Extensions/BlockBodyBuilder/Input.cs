using Undefined.Lambdas.Blocks.Variables;

namespace Undefined.Lambdas.Extensions.BlockBodyBuilder;

public delegate InputValue InputValueResolver(LambdaBlockBuilderContext context);

public static partial class LambdaBodyBuilderExtensions
{
    public static IValueReturned Descriptor(this IBodyBuilder builder, ITypeDescriptor descriptor)
    {
        builder.Add(p => p.Descriptor(descriptor));
        return new ValueReturned();
    }
    public static IValueReturned New(this IBodyBuilder builder, Type type)
    {
        return builder.Descriptor(TypeDescriptors.Type(type));
    }

}