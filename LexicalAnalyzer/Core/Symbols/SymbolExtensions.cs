namespace LexicalAnalyzer.Core.Symbols;

public static class SymbolExtensions
{
    private static readonly Dictionary<char, Symbol> _possibleSymbols = new Dictionary<char, Symbol>()
    {
        { '+', Symbol.Add },
        { '-', Symbol.Minus },
        { '=', Symbol.Equal },
        { '.', Symbol.Dot },
        { '/', Symbol.Slash },
        { '!', Symbol.Exclamation },
        { '"', Symbol.Quote },
        { '*', Symbol.Star },
        { '>', Symbol.Operator },
        { '<', Symbol.Operator },
        { '&', Symbol.Operator },
        { ',', Symbol.Separator },
        { ';', Symbol.Separator },
        { '{', Symbol.Separator },
        { '}', Symbol.Separator },
        { '(', Symbol.Separator },
        { ')', Symbol.Separator },
        { '[', Symbol.Separator },
        { ']', Symbol.Separator },
        { ':', Symbol.Separator },
    };

    public static Symbol ToSymbol(this char input)
    {
        if (char.IsLetter(input))
        {
            return Symbol.Letter;
        }

        if (char.IsDigit(input))
        {
            return Symbol.Digit;
        }

        if (_possibleSymbols.ContainsKey(input))
        {
            return _possibleSymbols[input];
        }

        return Symbol.None;
    }
}
