using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class Bubblesort
    {
        public static void bubble()
        {
            try

            {
                Console.WriteLine(" enter number of input");
                int number = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[number];
                Console.WriteLine(" enter {0} number of array ", number);
                for (int i = 0; i < number; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Utility.Bubblesort(number, arr);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
