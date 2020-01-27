using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Basicprogram
{
    class poweroftwo
    {
        public static void power()
        {
            try
            {
                Console.WriteLine(" enter number power of two number");
                int number = Utility.IntegerInput();
                Utility.Poweroftwo(number);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
