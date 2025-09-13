using System;
using static System.Console;

namespace ConsoleKeys
{
    class Program
    {
        static void Main()
        {
            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
        }
    }
}