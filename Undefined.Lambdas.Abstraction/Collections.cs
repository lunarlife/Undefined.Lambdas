using Undefined.Lambdas.Abstraction.Methods;
using Undefined.Lambdas.Abstraction.Presentations;
using Undefined.Lambdas.Abstraction.Syntax.Variables;
using Undefined.Lambdas.Abstraction.Variables;

namespace Undefined.Lambdas.Abstraction;

public interface IVariableCollection :  IUCollection<IVariable>;
public interface IBlockCollection : IUCollection<ILambdaBlock>;
public interface IMethodParameterCollection : IReadOnlyCollectionIndexed<ICompiledMethodParameter>;
