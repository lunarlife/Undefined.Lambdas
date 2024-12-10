namespace Undefined.Lambdas.Extensions;

public static class VarsExtensions
{
    public static void AssignTo(this IAssignable assignable, IStorable storable) => assignable.AssignTo(() => storable);
}