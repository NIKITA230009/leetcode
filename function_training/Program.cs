using System;
using static System.Console;

namespace function_training
{
    public class Program
    {
        static void time_table_get(byte number)
        {
            WriteLine($"this is table for number {number}");
            for (int i = 1; i <= 12; i++)
            {
                WriteLine($"{i}*{number} = {i * number}");
            }
        }
        static void RunTables()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between: 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    time_table_get(number);
                }
                else
                {
                    WriteLine("Number is not valid");
                }
            }
            while (isNumber);
        }
     static void Main(string[] args)
        {
            RunTables();
        }
    }
}