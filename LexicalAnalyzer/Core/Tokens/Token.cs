using LexicalAnalyzer.Core.Symbols;

namespace LexicalAnalyzer.Core.Tokens;

public class Token
{
    public string Content { get; set; }

    public int PreviousIndex { get; set; }

    public int CurrentIndex { get; set; }

    public string Word
    {
        get => Content[PreviousIndex..CurrentIndex];
    }

    public Token(string path)
    {
        Content = File.ReadAllLines(path).Aggregate((a, b) => a + b);
    }

    public Symbol GetCurrentSymbolAndSetNextIndex()
    {
        var symbol = Content[CurrentIndex].ToSymbol();
        CurrentIndex++;

        return symbol;
    }

    public void GoBack()
    {
        CurrentIndex--;
    }

    public bool HasNext()
    {
        return Content.Length > CurrentIndex;
    }
}
