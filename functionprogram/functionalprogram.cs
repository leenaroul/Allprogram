using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.functionprogram
{
    class functionalprogram
    {
        public static void functional()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: 2D Array ");
                Console.WriteLine("2: Sum of three Integer adds to ZERO ");
                Console.WriteLine("3: Distance ");
                Console.WriteLine("4: Quadratic  ");
                Console.WriteLine("5: WindChill ");
                Console.WriteLine("6: Exit ");


                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TwoDArray.twodarray();
                       
                        break;

                    case 2:
                        sumofthreezero.sum();
                        break;

                    case 3:
                        distance.Dist();
                        break;

                    case 4:
                        quadratic.quadra();
                        break;

                    case 5:
                        windchill.windChill();
                        break;

                    case 6:
                        Console.WriteLine("Basic Program Exit");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("wrong choice \n want to work in functional program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            functionalprogram.functional();
                        }

                        else
                        {
                            flag = false;
                        }

                        break;

                }

            }


        }

    }
}
