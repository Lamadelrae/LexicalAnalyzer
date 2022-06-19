using LexicalAnalyzer.Core.States;

namespace LexicalAnalyzer.States;

public class FinalState : IIdentityState
{
    public string Name { get; }

    private FinalState(string identity) => Name = identity;

    public static FinalState Error => new FinalState("error");

    public static FinalState Space => new FinalState("space");

    public static FinalState Integer => new FinalState("integer");

    public static FinalState Decimal => new FinalState("decimal");

    public static FinalState Reserved => new FinalState("reserved");

    public static FinalState Identifier => new FinalState("identifier");

    public static FinalState Seperator => new FinalState("seperator");

    public static FinalState Operator => new FinalState("operator");

    public static FinalState String => new FinalState("string");

    public static FinalState Comment => new FinalState("comment");
}
