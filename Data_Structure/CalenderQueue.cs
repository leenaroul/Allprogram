/// <copyright file= CalenderQueue.cs" company="Bridgelabz" >
/// Company copyright tag
/// </copyright>
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;


    class CalenderQueue
    {
        public static void DisplayCalender()
        {
            
            Queue queue = new Queue();
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());//taking month as input
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());//taking year as input
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int start = Utility.calenderinput(1, month, year);
            int endDate = Utility.Enddate(month, year);
            while (start >= 1)
            {
                queue.Enqueue("   ");
                start--;
            }
            int count = 1;
            while (count <= endDate)
            {
                if (count < 9)
                {
                    queue.Enqueue(count + "  ");
                }
                else
                {
                    queue.Enqueue(count + " ");
                }
                count++;
            }
            Console.WriteLine(months[month - 1] + " " + year);
            Console.WriteLine("S |M |T |W |T |F |S");
            count = 0;
            while (!queue.IsEmpty())
            {
                Console.Write(queue.Get());
                queue.Dequeue();
                count++;
                if (count % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}

