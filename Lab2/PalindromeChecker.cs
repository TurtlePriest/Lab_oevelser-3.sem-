using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class PalindromeChecker : Stack
    {
        public string GetUserInput()
        {
            Console.Write("Enter a string (or exit to quit): ");

            string value = Console.ReadLine();
            return value.ToLower();
        }

        public void Show_Strings(string input, string reverse)
        {
            Console.WriteLine("Your input string is: " + input);
            Console.WriteLine("The reverse is: " + reverse);
        }

        public string ReverseString(string users_input)
        {

            var newstr = new StringBuilder();
            Stack s = new Stack();


            foreach (char c in users_input.ToArray())
            {
                s.Push(c);

            }


            while (s.Size() > 0)
            {
                newstr.Append(s.Pop());
            }
            return newstr.ToString();
        }


        public void CheckResult(string input)
        {


            if (isPalindrome(input))
            {
                Console.WriteLine(input + " is a palindrome!");
            } else
            {
                Console.WriteLine(input + " is not a palindrome!");
            }




        }

        public bool isPalindrome(string str)
        {
            return str.Equals(ReverseString(str));

        }
    }
}
