/// <copyright file= algorithm.cs" company="Bridgelabz" >
/// Company copyright tag
/// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class algorithm
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Algorithm()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: Insertion Sort ");
                Console.WriteLine("2: Bubble Sort ");
                Console.WriteLine("3: Merge Sort ");
                Console.WriteLine("4: Binary Search  ");
                Console.WriteLine("5: Guessing Number ");
                Console.WriteLine("6: Prime Number in given range");
                Console.WriteLine("7: Prime Anagram Palindrome ");
                Console.WriteLine("8: Anagram checking String");
                Console.WriteLine("9: Permutation String");
                Console.WriteLine("10: Customize Message Demonstration using String Function and RegEx ");
                Console.WriteLine("11: Exit ");
                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Insertionn.insort();
                        break;

                    case 2:
                        Bubblesort.bubble();
                        break;

                    case 3:
                        mergesort.merge();
                        break;

                    case 4:
                        binarysearch.binary();
                        break;

                    case 5:
                        guessingnumber.GuessnumberInput();
                        break;

                    case 6:
                        prime.PrimeNumberInput();
                        break;
                    case 7:
                        PrimeAnagramPalindrome.PrimeAnagramPalindromeInput();
                        break;
                    case 8:
                        Anagram.AnagramInput();
                        break;
                    case 9:
                        PermutationString.PermutationStringInput();
                        break;
                    case 10:
                        CustomizeMessage.StringMessageInput();
                        break;

                    case 11:
                        Console.WriteLine("Algorithm Program Exit");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("wrong choice \n want to work in Algorith program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            algorithm.Algorithm();
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
