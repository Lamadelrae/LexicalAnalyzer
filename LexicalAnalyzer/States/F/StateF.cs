using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.F;

public class StateF : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Equal:
                    return FinalState.Operator;
                default:
                    token.GoBack();
                    return FinalState.Operator;
            }
        }

        return FinalState.Error;
    }
}
