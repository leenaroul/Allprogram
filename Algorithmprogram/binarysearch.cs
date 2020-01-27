namespace fellowshipleenaroul.Algorithmprogram
{
using System;
using System.Collections.Generic;
using System.Text;
    class binarysearch
    {
        public static void binary()
        {
            try
            {
                Console.WriteLine(" enter number  how many string input");
                int number = Utility.IntegerInput();
                string[] arr = new String[number];
                Console.WriteLine(" enter string ");
                for (int i = 0; i < number; i++)
                {
                    arr[i] = Utility.StringInput();
                }
                Console.WriteLine("Which string you want to search ? ");
                String s = Utility.StringInput();

                int result = Utility.binarySearch(arr, s);

                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element found at index " + result);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
