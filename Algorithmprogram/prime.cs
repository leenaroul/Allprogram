using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class prime
    {
            public static void PrimeNumberInput()
            {
                try
                {
                    Boolean flag = true;
                    while (flag)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1. single prime number\n2. Range of Prime Number");
                        Console.WriteLine("3. want to exit");
                        int choice = Utility.IntegerInput();
                    switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter a number");
                                int number = Utility.IntegerInput();
                                Utility.PrimeNumberCalculator(number);
                                break;
                            case 2:
                                Console.WriteLine("Enter lower boundary of range");
                                int lower = Utility.IntegerInput();
                                Console.WriteLine("Enter upper boundary of range");
                                int upper = Utility.IntegerInput();
                                int[] primenumbersarray = Utility.PrimeNumberRange(lower, upper);
                                Utility.DisplayPrimeArray(primenumbersarray);
                                break;
                            case 3:
                                flag = false;
                                break;
                            default:
                                flag = false;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    
}
