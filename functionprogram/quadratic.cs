using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class quadratic
    {

        public static void quadra()
        { Console.WriteLine(" enter first number");

            double a = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine(" enter second number");

            double b = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine(" enter third number");

          double c = Convert.ToDouble(Console.ReadLine());

            Utility.quadratic(a, b, c);
    }
    }
}
