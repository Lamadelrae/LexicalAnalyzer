using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States.H.N;

namespace LexicalAnalyzer.States.H;

public class StateH : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Star:
                    return new StateN();
                default:
                    token.GoBack();
                    return FinalState.Operator;
            }
        }
        return FinalState.Error;
    }
}
