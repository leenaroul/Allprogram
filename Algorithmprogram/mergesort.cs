namespace fellowshipleenaroul.Algorithmprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class mergesort
    {

        public static void merge()
        {
            try
            {
                Console.WriteLine(" enter number of  string input");
                int number = Utility.IntegerInput();
                string[] arr = new String[number];
                Console.WriteLine(" enter any string ");
                for (int i = 0; i < number; i++)
                {
                    arr[i] = Utility.StringInput();
                }
                Utility.mergeSort(arr, 0, number - 1);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
