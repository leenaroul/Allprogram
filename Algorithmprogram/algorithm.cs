using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul.Algorithmprogram
{
    class algorithm
    {
        public static void Algorithm()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: Insertion Sort ");
                Console.WriteLine("2: Bubble Sort ");
                Console.WriteLine("3: Merge Sort ");
                Console.WriteLine("4: Quadratic  ");
                Console.WriteLine("5: WindChill ");
                Console.WriteLine("6: Exit ");


                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Insertionn.insort();
                        break;

                    case 2:
                        Bubblesort.bubble();
                        break;

                    case 3:
                        mergesort.merge();
                        break;

                    case 4:
                       
                        break;

                    case 5:
                       
                        break;

                    case 6:
                        Console.WriteLine("Algorithm Program Exit");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("wrong choice \n want to work in Algorith program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            algorithm.Algorithm();
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
