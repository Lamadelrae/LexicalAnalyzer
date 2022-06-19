using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.I;

public class StateI : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Quote:
                    return FinalState.String;
                default:
                    return new StateI();
            }
        }

        return FinalState.Error;
    }
}
