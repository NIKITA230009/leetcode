using System;
using System.Security.Cryptography.X509Certificates;

namespace PalindromeCheker
{
    public class Solution
    {
            public bool IsPalindrome(int x)
            {
                string str = x.ToString();
                if (str[0] == str[(str.Length)-1])
                {
                    return true;
                }
                else
                {
                    return false;
                } 
        }
      }
        class Programm
        {
        static void Main()
        {
            Solution solution = new Solution();
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input");
                return;
            }
            if (int.TryParse(input, out int number))
            {
                bool result = solution.IsPalindrome(number);
                Console.WriteLine(result);
            }
            else Console.WriteLine("Invalid input");
            }
        }
    }