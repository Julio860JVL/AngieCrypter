namespace AngieCrypter
{
    class Symbols
    {
        // special characters (starting with a space).
        //  ~!@#$%^&*()_+{}|:"<>?`1234567890-=[]\;',./
        //
        // Swap this characters with the same concept as the letters
        // (do not repeat/duplicate the characters).
        // And do not change the variables starting with 'char' because those are the
        // official real characters. You must only swap/change the variables starting with 'mod'. 

        internal static char charSpace = ' ';
        internal static char modSpace = '\u221E'; // <-- Infinity symbol.

        internal static char charTilde = '~';
        internal static char modTilde = '`';

        internal static char charExclamation = '!';
        internal static char modExclamation = '1';

        internal static char charAt = '@';
        internal static char modAt = '2';

        internal static char charPound = '#';
        internal static char modPound = '3';

        internal static char charDollar = '$';
        internal static char modDollar = '4';

        internal static char charPercent = '%';
        internal static char modPercent = '5';

        internal static char charCaret = '^';
        internal static char modCaret = '6';

        internal static char charAmpersand = '&';
        internal static char modAmpersand = '7';

        internal static char charAsterisk = '*';
        internal static char modAsterisk = '8';

        internal static char charOpenParenthesis = '(';
        internal static char modOpenParenthesis = '9';

        internal static char charCloseParenthesis = ')';
        internal static char modCloseParenthesis = '0';

        internal static char charUnderscore = '_';
        internal static char modUnderscore = '-';

        internal static char charPlus = '+';
        internal static char modPlus = '=';

        internal static char charOpenCurly = '{';
        internal static char modOpenCurly = ':';

        internal static char charCloseCurly = '}';
        internal static char modCloseCurly = '"';

        internal static char charVerticalBar = '|';
        internal static char modVerticalBar = '.';

        internal static char charColon = ':';
        internal static char modColon = '{';

        internal static char charQuotation = '"';
        internal static char modQuotation = '}';

        internal static char charLessThan = '<';
        internal static char modLessThan = '\\';

        internal static char charGreaterThan = '>';
        internal static char modGreaterThan = '/';

        internal static char charQuestion = '?';
        internal static char modQuestion = ',';

        internal static char charBacktick = '`';
        internal static char modBacktick = '~';

        internal static char charNum1 = '1';
        internal static char modNum1 = '!';

        internal static char charNum2 = '2';
        internal static char modNum2 = '@';

        internal static char charNum3 = '3';
        internal static char modNum3 = '#';

        internal static char charNum4 = '4';
        internal static char modNum4 = '$';

        internal static char charNum5 = '5';
        internal static char modNum5 = '%';
        
        internal static char charNum6 = '6';
        internal static char modNum6 = '^';

        internal static char charNum7 = '7';
        internal static char modNum7 = '&';

        internal static char charNum8 = '8';
        internal static char modNum8 = '*';

        internal static char charNum9 = '9';
        internal static char modNum9 = '(';

        internal static char charNum0 = '0';
        internal static char modNum0 = ')';

        internal static char charHyphen = '-';
        internal static char modHyphen = '_';

        internal static char charEquals = '=';
        internal static char modEquals = '+';

        internal static char charOpenSquare = '[';
        internal static char modOpenSquare = ';';

        internal static char charCloseSquare = ']';
        internal static char modCloseSquare = '\'';

        internal static char charBackslash = '\\';
        internal static char modBackslash = '<';

        internal static char charSemicolon = ';';
        internal static char modSemicolon = '[';

        internal static char charApostrophe = '"';
        internal static char modApostrophe = '}';

        internal static char charComma = ',';
        internal static char modComma = '?';

        internal static char charPeriod = '.';
        internal static char modPeriod = '|';

        internal static char charSlash = '/';
        internal static char modSlash = '>';
    }
}
