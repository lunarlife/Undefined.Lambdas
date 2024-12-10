namespace Undefined.Lambdas.Abstraction;

public interface IUCollection<T> : IReadOnlyCollectionIndexed<T>
{
    public new T this[int index] { set; }
}

public interface IReadOnlyCollectionIndexed<T> : IReadOnlyCollection<T>
{
    public T this[int index] { get; }
}