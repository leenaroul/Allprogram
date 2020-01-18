using System;

namespace fellowshipleenaroul
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Boolean flag = true;
            try
            {

                while (flag)
                {
                    Console.WriteLine("  ");
                    Console.WriteLine("1: Basic Program  \n2: Logical Program");
                    Console.WriteLine("3: Functional Program \n4: Algorithmic Programs ");
                    Console.WriteLine("5: Exit ");

                    Console.WriteLine("enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Basicprogram.basicprogram.basic();
                            break;

                        case 2:
                            break;

                        case 3:
                            functionprogram.functionalprogram.functional();
                            break;
                        case 4:
                            Algorithmprogram.algorithm.Algorithm();
                            break;

                        case 5:
                            Console.WriteLine("Program List Exit");
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("wrong choice \n want to work in program list \n if yes press 1");
                            choice = Convert.ToInt32(Console.ReadLine());

                            if (choice != 0)
                            {
                                Console.WriteLine("Program exit");


                            }
                            break;
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                Console.ReadLine();



        }

    }
}
