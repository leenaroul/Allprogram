namespace fellowshipleenaroul.Logicalprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class gambler
    {
        public static void gamble()
        {
            try
            { 
            Console.WriteLine(" enter number of stakes");
            int stakes = Utility.IntegerInput();
            Console.WriteLine(" enter  Goal");
            int goal = Utility.IntegerInput();
            Console.WriteLine(" enter number of times");
            int num = Utility.IntegerInput();
            Utility.Gambblr(stakes, goal, num);
            }
           catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
}
    }
}
