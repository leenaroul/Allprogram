namespace fellowshipleenaroul.Data_Structure
{
    /// <copyright file= calender.cs" company="Bridgelabz" >
    /// Company copyright tag
    /// </copyright>
using System;
using System.Collections.Generic;
using System.Text;


    class calender
    { /// <summary>
      /// this is the calender class
      /// for taking input from user
      /// </summary>
        public static void Calender()
        {
            try
            {
                Console.WriteLine(" enter month ");
                /// month input
                int month = Utility.IntegerInput();
                int date = 1;
                Console.WriteLine(" enter year ");
                /// year input
                int year = Utility.IntegerInput();
                int start = Utility.calenderinput(date, month, year);
                String[] months = {"January", "February", "March","April", "May","June","July", "August","September",
                "October", "November", "December" };
                String[] days = { "S ", "M ", "T ", "W ", "T ", "F ", "S " };
                Console.WriteLine("Calender" + month + " " + year);
                Console.WriteLine(months[month - 1] + "  " + year);
                int enddate = Utility.Enddate(month, year);
                for (int i = 0; i < days.Length; i++)
                {
                    Console.Write(days[i] + " ");
                }
                Console.WriteLine(); 
                int j = 1;
                for (int i = 1; i <= enddate + start; i++)
                {
                    if (i <= start)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        if (j < 9)
                        {
                            Console.Write(j + "  ");
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }
                        j++;
                    }
                    if (i % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
