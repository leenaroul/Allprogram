/// <copyright file= datastructure.cs" company="Bridgelabz" >
/// Company copyright tag
/// </copyright>
namespace fellowshipleenaroul.Data_Structure
{
    
using System;
using System.Collections.Generic;
using System.Text;
 class datastructure
    {
        /// <summary>
        /// this is the data structure class
        /// </summary>
        public static void DataStructure()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: Calender ");  /// calender program
                Console.WriteLine("2: Balanced parantheses");/// checking balanced parantheses program
                Console.WriteLine("3: Unordered list");///unsorted list 
                Console.WriteLine("4: Palindrome checker");///checking palindrome or not
                Console.WriteLine("5: Hashing function");///hasing program
                Console.WriteLine("6: Ordered list");//ordered list
                Console.WriteLine("7: Prime anagram queue ");//prime anagram number program
                Console.WriteLine("8: Calender Queue");// calender using queue
                Console.WriteLine("9: Prime number");//prime number program
                Console.WriteLine("10: Exit "); 
                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        calender.Calender();
                        break;
                    case 2:
                        balancedparantheses.parenthesis();
                        break;
                    case 3:
                        Unorderlist.UnOrderedlist();
                        break;
                    case 4:
                        PalindromeChecker.Palindromechecker();
                        break;
                    case 5:
                        hashingfuncion.HashChain();
                        break;
                    case 6:
                        orderedlist.OrderedList();
                        break;
                    case 7:
                        PrimeAnagramQueue.PrimeAnagram();
                        break;
                    case 8:
                        CalenderQueue.DisplayCalender();
                        break;
                    case 9:
                        primenumber.PrimeTwoDimensionArray();
                        break;
                    case 10:
                        Console.WriteLine("Data Structure Program Exit");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("wrong choice \n want to work in data structure program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            datastructure.DataStructure();
                        }
                        else
                        {
                            flag = false;
                        }

                        break;
                }
            }
        }
    }
}
