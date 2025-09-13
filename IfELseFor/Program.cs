using System;
using static System.Console;

namespace IfELseFor
{
    class Program
    {
        static void Main()
        {
            object o = "3";
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i}X{j}={i * j}");
            }
            else
            {
                WriteLine("ERROR");
            }
        }
    }
}