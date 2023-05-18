using System;

namespace Angie
{
    internal class ChangeColor
    {
        public static void Red(string a)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(a);
            Console.ResetColor();
        }
        public static void Green(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(a);
            Console.ResetColor();
        }
    }
}
