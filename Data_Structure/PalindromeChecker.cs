
//----------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;
    class PalindromeChecker
    {
        public static void Palindromechecker()
        {
            try
            {
                Utility utility = new Utility();
                Console.WriteLine("Enter string to check if it is palindrome");
                string input = Console.ReadLine();
                if (utility.palindromchecker(input))
                {
                    Console.WriteLine("String is palindrome");
                }
                else
                {
                    Console.WriteLine("String is not palindrome");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
