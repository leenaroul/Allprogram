namespace fellowshipleenaroul.Logicalprogram
{
using System;
using System.Collections.Generic;
using System.Text;


    class logical
    {
        public static void Logical()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: Gambler ");
                Console.WriteLine("2: Coupon Code ");
                Console.WriteLine("3: Tic tac toe ");
                Console.WriteLine("4: Exit ");
                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        gambler.gamble();
                        break;

                    case 2:
                        couponnumber.coupon();
                        break;

                    case 3:
                        Tictactoe.tictactoe();
                        break;
                    case 4:
                        Console.WriteLine("Logical Program Exit");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("wrong choice \n want to work in logical program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            logical.Logical();
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
