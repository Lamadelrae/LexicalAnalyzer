using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.B.K.L;

public class StateL : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Digit:
                    return new StateL();
                default:
                    token.GoBack();
                    return FinalState.Decimal;
            }
        }

        return FinalState.Error;
    }
}
