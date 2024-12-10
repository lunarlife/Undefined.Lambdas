namespace Undefined.Lambdas.Abstraction.Syntax.Variables;

public readonly struct VariableIdentifier : IEquatable<VariableIdentifier>
{
    public int DeclareId { get; }

    public VariableIdentifier(int declareId)
    {
        DeclareId = declareId;
    }

    public bool Equals(VariableIdentifier other) => DeclareId == other.DeclareId;

    public override bool Equals(object? obj) => obj is VariableIdentifier other && Equals(other);

    public override int GetHashCode() => DeclareId;
    public override string ToString() => DeclareId.ToString();
}