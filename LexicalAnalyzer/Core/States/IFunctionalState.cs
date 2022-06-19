using LexicalAnalyzer.Core.Tokens;

namespace LexicalAnalyzer.Core.States;

public interface IFunctionalState : IState
{
    IState GetNext(Token token);
}
