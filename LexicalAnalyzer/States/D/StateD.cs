using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.D;

public class StateD : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Add:
                    return FinalState.Operator;
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
