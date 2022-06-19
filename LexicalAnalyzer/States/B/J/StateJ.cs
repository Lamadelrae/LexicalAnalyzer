using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.B.J;

public class StateJ : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Digit:
                    return new StateJ();
                default:
                    token.GoBack();
                    return FinalState.Integer;
            }
        }

        return FinalState.Error;
    }
}
