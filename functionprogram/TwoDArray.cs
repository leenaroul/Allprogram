using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class TwoDArray
    {
        public static void twodarray ()
        {
            try
            {
                Console.WriteLine(" enter value for row");
                int row = Utility.IntegerInput();
                Console.WriteLine(" enter value for colomn");
                int colm = Utility.IntegerInput();
                Utility.twoDarray(row, colm);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
