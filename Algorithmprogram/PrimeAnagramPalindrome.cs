namespace fellowshipleenaroul.Algorithmprogram
{
    
using System;
using System.Collections.Generic;
using System.Text;


    class PrimeAnagramPalindrome
    {
        public static void PrimeAnagramPalindromeInput()

        {
            try

            {

                Console.WriteLine("Enter the lower boundery");
                int lower = Utility.IntegerInput();
                Console.WriteLine("Enter Upper boundary");
                int upper = Utility.IntegerInput();
                Utility.PrimeNumberArray(lower, upper);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
