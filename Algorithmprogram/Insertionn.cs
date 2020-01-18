using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class Insertionn
    {
        public static void insort()
        {
            try

            {
                Console.WriteLine(" enter number of  string input");
                int number = Convert.ToInt32(Console.ReadLine());
                string[] arr = new String[number];
                Console.WriteLine(" enter any string ");
                for (int i = 0; i < number; i++)
                {
                    arr[i] = Console.ReadLine();
                }

                Utility.Insertion(number, arr);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
