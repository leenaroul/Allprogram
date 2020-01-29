//----------------------------------------------------
// <copyright file="balancedparantheses.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


    class balancedparantheses
    {
        /// <summary>
        /// balancedparantheses class
        /// </summary>
        public static void parenthesis()
        {
            try
            {
                stack stack = new stack();
                Console.WriteLine("Enter arithmatic expression");
                string expression = Console.ReadLine();
                /// Regex expression to accept elements which is necessary for valid expression
                while (!Regex.IsMatch(expression, @"^[0-9-+/*)(]+$"))
                {
                    Console.WriteLine("Enter valid arithmatic expression");
                    expression = Console.ReadLine();
                }
                /// iterating to push elements
                for (int i = 0; i < expression.Length; i++)
                {
                    if (expression[i] + string.Empty == "(")
                    {
                        stack.Push("(");
                    }

                    if (expression[i] + string.Empty == ")")
                    {
                        stack.Pop();
                    }
                }
                if (stack.Isempty())
                {
                    Console.WriteLine("Arithmatic expression is balanced");
                }
                else
                {
                    Console.WriteLine("Arithmatic expression is not balanced");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            
        }
}
