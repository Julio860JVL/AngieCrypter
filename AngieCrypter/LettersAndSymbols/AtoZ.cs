namespace AngieCrypter
{
    class AtoZ
    {
        // Letters (a thru z) swapped.
        // Do not change the values of 'char*' as those are the original characters.
        // The variables to be modified are 'mod*'.
        //
        // In order for this to work, the swapped letters cannot be duplicated.
        //
        // Example: If you swap letter 'modN' for 't' then,
        // you cannot use the letter 't' in any other character,
        // because 't' has been assigned to letter 'modN' already.
        //
        // And while you can actually do a duplicated swap,
        // what it will end up happening is the encryption wont work because
        // the duplicated letters will end up being the same letter and the message wont be
        // human-readable at the moment of decrypting the message.
        //
        // The way I made sure I wasn't duplicating the letters was by typing all the letters
        // in a text editor and deleting them from the text editor as I inserted them in the code.

        internal static char charA = 'a';
        internal static char modA = 'k';

        internal static char charB = 'b';
        internal static char modB = 'h';

        internal static char charC = 'c';
        internal static char modC = 'o';

        internal static char charD = 'd';
        internal static char modD = 't';

        internal static char charE = 'e';
        internal static char modE = 'i';

        internal static char charF = 'f';
        internal static char modF = 'v';

        internal static char charG = 'g';
        internal static char modG = 'n';

        internal static char charH = 'h';
        internal static char modH = 'e';

        internal static char charI = 'i';
        internal static char modI = 'u';

        internal static char charJ = 'j';
        internal static char modJ = 'z';

        internal static char charK = 'k';
        internal static char modK = 's';

        internal static char charL = 'l';
        internal static char modL = 'y';

        internal static char charM = 'm';
        internal static char modM = 'g';

        internal static char charN = 'n';
        internal static char modN = 'x';

        internal static char charO = 'o';
        internal static char modO = 'a';

        internal static char charP = 'p';
        internal static char modP = 'l';

        internal static char charQ = 'q';
        internal static char modQ = 'r';

        internal static char charR = 'r';
        internal static char modR = 'w';

        internal static char charS = 's';
        internal static char modS = 'c';

        internal static char charT = 't';
        internal static char modT = 'f';

        internal static char charU = 'u';
        internal static char modU = 'j';

        internal static char charV = 'v';
        internal static char modV = 'b';

        internal static char charW = 'w';
        internal static char modW = 'q';

        internal static char charX = 'x';
        internal static char modX = 'p';

        internal static char charY = 'y';
        internal static char modY = 'm';

        internal static char charZ = 'z';
        internal static char modZ = 'd';
    }
}
