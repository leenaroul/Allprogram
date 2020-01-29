/// <copyright file= PrimeAnagramQueue.cs" company="Bridgelabz" >
/// Company copyright tag
/// </copyright>

namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;

    class PrimeAnagramQueue
    {/// <summary>
    /// prime anagram queue using linkedlist class
    /// </summary>
        public static void PrimeAnagram()
        {
            try
            {
                Utility utility = new Utility();
                queuelinkedlist queue = new queuelinkedlist();
                Console.WriteLine("Prime Numbers that are Anagram in the Range of 0 - 1000 in a Queue using the Linked List :- ");
                for (int i = 1; i <= 1000 - 1; i++)
                {
                    for (int j = i + 1; j <= 1000; j++)
                    {
                        if (utility.IsAnagram(i + string.Empty, j + string.Empty) && utility.IsPrime(i) && utility.IsPrime(j))
                        {
                            queue.Enqueue(j);
                        }
                    }
                }
                queue.Show();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
