using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Symbols;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States.A;
using LexicalAnalyzer.States.B;
using LexicalAnalyzer.States.C;
using LexicalAnalyzer.States.D;
using LexicalAnalyzer.States.E;
using LexicalAnalyzer.States.F;
using LexicalAnalyzer.States.G;
using LexicalAnalyzer.States.H;
using LexicalAnalyzer.States.I;

namespace LexicalAnalyzer.States;

public class InitialState : IFunctionalState
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
                    return new StateB();
                case Symbol.Separator:
                    return new StateC();
                case Symbol.Add:
                    return new StateD();
                case Symbol.Minus:
                    return new StateE();
                case Symbol.Equal:
                    return new StateF();
                case Symbol.Exclamation:
                    return new StateG();
                case Symbol.Slash:
                    return new StateH();
                case Symbol.Quote:
                    return new StateI();
            }
        }

        return FinalState.Space;
    }
}
