using System;
using System.Text;
using System.Linq;

namespace Lab2
{
    class MainProgram : PalindromeChecker
    {
        static void Main(string[] args)
        {
            PalindromeChecker palindrome = new PalindromeChecker();
            var input = "";
            while (!input.Contains("exit"))
            {
               
                input = palindrome.GetUserInput();


                if (!(input.Length > 1))
                {
                    Console.WriteLine(input + " is too short. Enter a word or number that is longer than one character.");
                }
                else
                {
                    if (!input.Contains("exit"))
                    {
                       
                        string reverse = palindrome.ReverseString(input);

                        palindrome.Show_Strings(input, reverse);

                        palindrome.CheckResult(input);

                    }

                }
            }
        }

    }



}