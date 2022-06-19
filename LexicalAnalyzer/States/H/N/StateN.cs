using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States.H.N.O;

namespace LexicalAnalyzer.States.H.N;

public class StateN : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Star:
                    return new StateO();
                default:
                    return new StateN();
            }
        }

        return FinalState.Error;
    }
}
