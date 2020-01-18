using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Basicprogram
{
    class leapyear
    {
        public static void Leapyear()
        {
            Console.WriteLine(" enter 4 digit number");
            int year = Convert.ToInt32(Console.ReadLine());
            Utility.leapyearcheck(year);
        }
    }
}
