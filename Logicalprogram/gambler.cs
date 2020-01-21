namespace fellowshipleenaroul.Logicalprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class gambler
    {
        public static void gamble()
        {
            Console.WriteLine(" enter number of stakes");
            int stakes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter  Goal");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter number of times");
            int num = Convert.ToInt32(Console.ReadLine());
            Utility.Gambblr(stakes, goal, num);
        }
    }
}
