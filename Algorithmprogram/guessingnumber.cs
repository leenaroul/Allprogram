namespace fellowshipleenaroul.Algorithmprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class guessingnumber
    {
        public static void GuessnumberInput()
        {
            try
            {
                Console.WriteLine("Enter Lower boundary of number");
                int lower = Utility.IntegerInput();
                Console.WriteLine("Enter Upperer boundary of number");
                int upper = Utility.IntegerInput();
                Utility.GuessNumberWorking(lower, upper);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
