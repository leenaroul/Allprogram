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
                Console.WriteLine("3: Merge Sort ");
                Console.WriteLine("4: Binary Search  ");
                Console.WriteLine("5: Guessing Number ");
                Console.WriteLine("6: Prime Number in given range");
                Console.WriteLine("7: Prime Anagram Palindrome ");
                Console.WriteLine("8: Anagram checking String");
                Console.WriteLine("9: Permutation String");
                Console.WriteLine("10: Customize Message Demonstration using String Function and RegEx ");
                Console.WriteLine("11: Exit ");
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
                        
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        
                        break;

                    case 6:
                        
                        break;
                    case 7:
                        
                        break;
                    case 8:
                        
                        break;
                    case 9:
                        
                        break;
                    case 10:
                        
                        break;

                    case 11:
                        Console.WriteLine("Algorithm Program Exit");
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
