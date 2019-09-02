using System;

namespace OOPS_Practice
{
    static class Utilities
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
