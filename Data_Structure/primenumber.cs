
//----------------------------------------------------
// <copyright file="primenumbers.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;

    class primenumber
    {
        /// <summary>
        /// PrimeNumbers as a class
        /// </summary>
        public static void PrimeTwoDimensionArray()
        {
            try
            {
                Utility utility = new Utility();
                int[] primeNumbers = new int[1000];
                int count = 0;
                Console.WriteLine(" Prime number 0-1000 range :- ");
                for (int i = 1; i <= 1000; i++)
                {
                    if (utility.IsPrime(i))
                    {
                        primeNumbers[count] = i;
                        count++;
                    }
                }
                int[,] array = new int[10, 1000];
                int min = 0, max = 100, k = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (primeNumbers[k] < max && primeNumbers[k] > min)
                        {
                            array[i, j] = primeNumbers[k];
                            k++;
                        }
                        else
                        {
                            min = max;
                            max = max + 100;
                            break;
                        }
                    }
                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            Console.Write(array[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
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
