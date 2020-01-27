namespace fellowshipleenaroul.functionprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class distance
    {
        public static void Dist()
        {
            try
            {
                Console.WriteLine(" enter first number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter second number");
                int y = Convert.ToInt32(Console.ReadLine());
                Utility.distance(x, y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
