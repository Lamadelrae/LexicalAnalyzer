using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.C;

public class StateC : IFunctionalState
{
    public IState GetNext(Token token)
    {
        return FinalState.Seperator;
    }
}
