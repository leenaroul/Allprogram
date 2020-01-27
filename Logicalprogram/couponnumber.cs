using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Logicalprogram
{
    class couponnumber
    {
        public static void coupon()
        {
            try
            {
                Console.WriteLine(" enter number of times for coupon code");
                int number = Utility.IntegerInput();
                int count = Utility.couponnumber(number);
                Console.WriteLine(count);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
