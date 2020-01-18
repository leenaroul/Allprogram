using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class windchill
    {
        public static void windChill ()
        {
            Console.WriteLine(" Enter Value for Temperture (T < 50)");
            int Temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for Velocity (3 < V < 120)");
            int Vel = Convert.ToInt32(Console.ReadLine());
            Utility.WindChill(Temp, Vel);
        }
            
    }
}
