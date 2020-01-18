using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class sumofthreezero
    {
        public static void sum()
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
                Utility.sumofthreenumber(number, arr);

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
