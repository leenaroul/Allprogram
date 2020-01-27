using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class windchill
    {
        public static void windChill ()
        {
            try
            {
                Console.WriteLine(" Enter Value for Temperture (T < 50)");
                int Temp = Utility.IntegerInput();
                Console.WriteLine("Enter Value for Velocity (3 < V < 120)");
                int Vel = Utility.IntegerInput();
                Utility.WindChill(Temp, Vel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
            
    }
}
