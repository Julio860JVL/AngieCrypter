namespace AngieCrypter
{
    class ChangeColor
    {
        internal static void Red(string a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(a);
            Console.ResetColor();
        }
        internal static void Green(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(a);
            Console.ResetColor();
        }
    }
}
