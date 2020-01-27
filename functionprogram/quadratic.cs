using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class quadratic
    {

        public static void quadra()
        {
            try
            {
                Console.WriteLine(" enter first number");

                double a = Utility.DoubleInput();

                Console.WriteLine(" enter second number");

                double b = Utility.DoubleInput();
                Console.WriteLine(" enter third number");

                double c = Utility.DoubleInput();

                Utility.quadratic(a, b, c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
