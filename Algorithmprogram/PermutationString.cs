﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class PermutationString
    {
        public static void PermutationStringInput()

        {
            try
            {

                int count = 0;

                Console.WriteLine("Enter the String to Generate the permutaion string");

                String string1 = Utility.StringInput();

                int length = string1.Length;

                Utility.Permutate(string1, 0, length - 1);

                Console.WriteLine(count);

            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
