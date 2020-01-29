/// <copyright file= utility.cs" company="Bridgelabz" >
/// Company copyright tag
/// </copyright>
namespace fellowshipleenaroul.Data_Structure
{
    
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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
        public static Boolean LeapYear(int year)///forchecking leapyear
        {
            if ((year % 4 == 0) && (year % 100 != 0)) return true;
            if (year % 400 == 0) return true;
            return false;
        }
        public static int Enddate(int month,int year)///for finding enddate of perticular month
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

        public bool palindromchecker(string input)
        {
            Deque deque = new Deque();
            string temp = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                deque.AddFront(input[i]);
            }
            while (!deque.IsEmpty())
            {
                temp += deque.RemoveFront();
            }

            if (temp == input)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Function to display elements in hash
        /// </summary>
        /// <param name="hash">hash array as parameter</param>
        /// <param name="path">path of the file as a parameter</param>
        public void DispalyHash(hash[] hash, string path)
        {
            StreamReader file = new StreamReader(path, Encoding.UTF8);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] numbers = line.Split(',', ' ');
                for (int i = 0; i < numbers.Length; i++)
                {
                    int number = Convert.ToInt32(numbers[i]);
                    int remainder = number % hash.Length;
                    hash[remainder].Add(number);
                }
            }

            string end = file.ReadToEnd();
            file.Close();
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i].Show();
            }
        }

        /// <summary>
        /// Function to delete element from the hash
        /// </summary>
        /// <param name="input">input , to be deleted, as a parameter</param>
        /// <param name="hash">hash as a parameter</param>
        public void DeleteFromFile(int input, hash hash)
        {
            hash.Remove(input);
            string changeFile = File.ReadAllText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\HashNumbers.txt", Encoding.UTF8);
            changeFile = changeFile.Replace(input + string.Empty, "0");
            File.WriteAllText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\HashNumbers.txt", changeFile);
        }

        /// <summary>
        /// Function to insert element in the hash
        /// </summary>
        /// <param name="input">input element as a parameter</param>
        /// <param name="hash">hash element as a parameter</param>
        /// <param name="path">path element as a parameter</param>
        public void InsertInFile(int input, hash[] hash, string path)
        {
            int remainder = input % hash.Length;
            hash[remainder].Add(input);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(input);
            }
        }
        public bool IsPrime(int input)
        {
            if (input == 2)
            {
                return true;
            }
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return input > 1;
        }

        /// <summary>
        /// Function to check if two input strings are anagram
        /// </summary>
        /// <param name="stringOne">stringOne as a parameter</param>
        /// <param name="stringTwo">stringTwo as a parameter</param>
        /// <returns>Returns true if the strings are anagram</returns>
        public bool IsAnagram(string stringOne, string stringTwo)
        {
            if (stringOne.Length != stringTwo.Length)
            {
                return false;
            }
            char[] stringOneArray = stringOne.ToLower().ToCharArray();
            char[] stringTwoArray = stringTwo.ToLower().ToCharArray();
            Array.Sort(stringOneArray);
            Array.Sort(stringTwoArray);
            for (int i = 0; i < stringOneArray.Length; i++)
            {
                if (stringOneArray[i] != stringTwoArray[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
