namespace fellowshipleenaroul.Algorithmprogram
{

using System;
using System.Collections.Generic;
using System.Text;


    class Anagram
    {
        public static void AnagramInput()

        {

            try

            {
                Console.WriteLine("Enetr First String");

                String string1 =  Console.ReadLine();

                Console.WriteLine("Enter second String");

                String string2 = Console.ReadLine();

                Boolean result = Utility.AnagramCheck(string1, string2);

                if (result == true)

                    Console.WriteLine(string1 + " and " + string2 + " Strings Anagram");

                else

                    Console.WriteLine(string1 + " and " + string2 + " strings are not Anagram");

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

        }
    }
}
