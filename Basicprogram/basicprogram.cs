
namespace fellowshipleenaroul.Basicprogram
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// 
    /// </summary>
    class basicprogram
    {
        /// <summary>
        /// Basics this instance.
        /// </summary>
        public static void basic()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("1: Leap year ");
                Console.WriteLine("2: Power of two ");
                Console.WriteLine("3: Palindrom ");
                Console.WriteLine("4: Anagram  ");
                Console.WriteLine("5: Recursive ");
                Console.WriteLine("6: Gambler ");
                Console.WriteLine("7: Random numbers  ");
                Console.WriteLine("8: Stopwatch ");
                Console.WriteLine("9: Exit ");


                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        leapyear.Leapyear();
                        break;

                    case 2:
                        poweroftwo.power();
                        break;

                    case 3:
                        break;
                        
                    case 9:
                        Console.WriteLine("Basic Program Exit");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("wrong choice \n want to work in basic program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            basicprogram.basic();
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
