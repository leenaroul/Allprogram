using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class TwoDArray
    {
        public static void twodarray ()
        {
            Console.WriteLine(" enter value for row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter value for colomn");
            int colm = Convert.ToInt32(Console.ReadLine());
            Utility.twoDarray(row, colm);
        }
    }
}
