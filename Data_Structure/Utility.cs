namespace fellowshipleenaroul.Data_Structure
{
    /// <copyright file= utility.cs" company="Bridgelabz" >
    /// Company copyright tag
    /// </copyright>
using System;
using System.Collections.Generic;
using System.Text;
    class Utility
    {
        public static int IntegerInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double DoubleInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static string StringInput()
        {
            return Console.ReadLine();
        }
        public static int calenderinput( int date,int month, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (date + x + (31 * m) / 12) % 7;
            return d;
        }
        public static Boolean LeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return false;
        }
        public static  int Enddate(int month,int year)
        {
            if(month==2 && LeapYear(year))
            {
                return 29;
            }
            if(month %2==0 && month<0)
            {
                return 30;
            }
            if (month %2==0 && month<8)
            {
                return 30;
            }
            return 31;

        }

    }
}
