using LexicalAnalyzer.Core.Keywords;
using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.States.A;

public class StateA : IFunctionalState
{
    public IState GetNext(Token token)
    {
        if (token.HasNext())
        {
            switch (token.GetCurrentSymbolAndSetNextIndex())
            {
                case Symbol.Letter:
                    return new StateA();
                case Symbol.Digit:
                    return new StateA();
                default:
                    token.GoBack();
                    var word = token.Word;
                    if (word.IsKeyWord())
                    {
                        return FinalState.Reserved;
                    }

                    return FinalState.Identifier;
            }
        }

        return FinalState.Error;
    }
}
