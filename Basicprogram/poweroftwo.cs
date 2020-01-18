using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Basicprogram
{
    class poweroftwo
    {
        public static void power()
        {
            Console.WriteLine(" enter number power of two number");
            int number = Convert.ToInt32(Console.ReadLine());
            Utility.Poweroftwo(number);
        }
    }
}
