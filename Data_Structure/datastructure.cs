namespace fellowshipleenaroul.Data_Structure
{
    /// <copyright file= datastructure.cs" company="Bridgelabz" >
    /// Company copyright tag
    /// </copyright>
using System;
using System.Collections.Generic;
using System.Text;
 class datastructure
    {
        /// <summary>
        /// this is the data structure class
        /// </summary>
        public static void DataStructure()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1: Calender ");  /// calender program
                Console.WriteLine("2: ");
                Console.WriteLine("11: Exit "); 
                Console.WriteLine(" ");
                Console.WriteLine(" enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        calender.Calender();
                        break;
                    case 2:

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
                        Console.WriteLine("Data Structure Program Exit");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("wrong choice \n want to work in logical program \n if yes press 1");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                        {
                            datastructure.DataStructure();
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
