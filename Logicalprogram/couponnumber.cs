using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Logicalprogram
{
    class couponnumber
    {
        public static void coupon()
        {
            Console.WriteLine(" enter number of times for coupon code");
            int number = Convert.ToInt32(Console.ReadLine());
            int count=Utility.coupoN(number);
            Console.WriteLine(count); 

        }
    }
}
