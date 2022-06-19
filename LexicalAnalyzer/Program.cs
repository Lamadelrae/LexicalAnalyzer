using LexicalAnalyzer.Core.States;
using LexicalAnalyzer.Core.Tokens;
using LexicalAnalyzer.States;


try
{
    var token = new Token(@"C:\Users\Matthew\Desktop\input.txt");

    while (token.HasNext())
    {
        IState state = new InitialState();
        while (state is not IIdentityState)
        {
            state = ((IFunctionalState)state).GetNext(token);
        }

        if (state is IIdentityState identityState && identityState.Name != FinalState.Space.Name)
        {
            Console.WriteLine($"\n {identityState.Name}: {token.Word}");
        }

        token.PreviousIndex = token.CurrentIndex;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
