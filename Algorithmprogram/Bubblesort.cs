namespace fellowshipleenaroul.Algorithmprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class Bubblesort
    {
        public static void bubble()
        {
            try

            {
                Console.WriteLine(" enter number of input");
                int number = Utility.IntegerInput();
                int[] arr = new int[number];
                Console.WriteLine(" enter {0} number of array ", number);
                for (int i = 0; i < number; i++)
                {
                    arr[i] = Utility.IntegerInput();
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
