using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Basicprogram
{
    class leapyear
    {
        public static void Leapyear()
        {
            try
            {
              Console.WriteLine(" enter 4 digit number");
              int year = Utility.IntegerInput();
               Utility.leapyearcheck(year);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
