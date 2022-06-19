using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States.B.K.L;

namespace LexicalAnalyzer.States.B.K;

public class StateK : IFunctionalState
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
                    return FinalState.Error;
            }
        }
        return FinalState.Error;
    }
}
