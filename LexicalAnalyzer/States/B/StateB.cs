using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States.B.J;
using LexicalAnalyzer.States.B.K;

namespace LexicalAnalyzer.States.B;

public class StateB : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Digit:
                    return new StateJ();
                case Symbol.Dot:
                    return new StateK();
                default:
                    token.GoBack();
                    return FinalState.Integer;
            }
        }

        return FinalState.Error;
    }
}
