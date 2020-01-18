using System;
using System.Collections.Generic;
using System.Text;

namespace fellowshipleenaroul
{
    class Utility
    {
        /* ============================BASIC=============================== */
        /*-------------------------LEAP YEAR-------------------------------- */
        public static void leapyearcheck(int year)
        {
            try
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 00)
                {
                    Console.WriteLine(" {0} is leap year", year);
                }

                else
                {
                    Console.WriteLine(" {0} is not leap year", year);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /* ============================POWEROFTWO=============================== */
        public static void Poweroftwo(int number)
        {
            try
            {
                if (number > 0 && number < 31)
                {
                    for (int i = 1; i <= number; i++)
                    {

                        int power = (int)Math.Pow(2, i);


                        Console.WriteLine("2 * " + i + " = " + power);
                    }
                }

                else
                {

                    // To call same function again util user enter right power of 2
                    Console.WriteLine("Invalid Input (Enter Again)");
                    Console.WriteLine("Range: 0 < Power < 31");
                    int new_n = Convert.ToInt32(Console.ReadLine());
                    Utility.Poweroftwo(new_n);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* ============================FUNCTIONAL=============================== */
        /* ----------------------------SUMOFTHREE------------------------------- */
        public static void sumofthreenumber(int number, int[] arr)
        {
            bool found = true;
            for (int i = 0; i < number - 2; i++)
            {
                for (int j = i + 1; j < number - 1; j++)
                {
                    for (int k = j + 1; k < number; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.Write(arr[i]);
                            Console.Write(" ");
                            Console.Write(arr[j]);
                            Console.Write(" ");
                            Console.Write(arr[k]);
                            Console.Write("\n");
                            found = true;
                        }
                    }
                }
            }

            // If no triplet with 0 sum found in  
            if (found == false)
                Console.Write(" not exist ");

        }
        /* ============================DISTANCE=============================== */

        public static void distance(int x, int y)
        {
            double dist = Math.Sqrt(x * x + y * y);
            Console.WriteLine("distance from (" + x + ", " + y + ") to (0, 0) = " + dist);
            //dist((x, y), (a, b)) = √(x - a)² + (y - b)²


        }
        /* ============================QUADRATIC=============================== */

        public static void quadratic(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            double sqroot = Math.Sqrt(discriminant);

            double root1 = (-b + sqroot) / 2 * a;
            double root2 = (-b - sqroot) / 2 * a;

            Console.WriteLine(root1);
            Console.WriteLine(root2);

        }


        /*------------------------------2D Array---------------------------------*/

        public static void twoDarray(int row, int colm)
        {
            int[,] arr = new int[row, colm];
            Console.WriteLine("Enter " + row * colm + " Elements");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colm; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colm; j++)
                {

                    Console.Write(arr[i, j] + '\t');

                }
                Console.WriteLine("");

            }

        }


        /*-------------------------Wind Chill---------------------------*/

        public static void WindChill(int temp, int vel)
        {

            if (temp > 50 || vel < 3 && vel > 120)
            {
                // Run if entered values are not in Range
                Console.WriteLine("Invalid Input (Enter Again)");
                Console.WriteLine("Enter Value for Temperture (T < 50)");
                int new_temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Value for Velocity (3 < V < 120)");
                int new_vel = Convert.ToInt32(Console.ReadLine());

                Utility.WindChill(new_temp, new_vel);
            }
            else
            {
                // Computation
                double w = 35.74 + (0.6215 * temp) + (0.4275 * temp - 35.75) * Math.Pow(vel, 0.16);
                Console.WriteLine("Wind Chill = " + w);
            }

        }

        /* ============================ALGORITHM PROGRAM=============================== */

        /*-------------------------BUBBLE SORT---------------------------*/

        public static void Bubblesort( int num, int []arr)
        {
            int temp = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j < (num - i); j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        //swap elements  
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }

                }
            }


         Console.WriteLine("Sorted list of numbers:");

            for (int c = 0; c < num; c++)
                Console.WriteLine(arr[c]);
        }

        /*-------------------------INSERTION SORT---------------------------*/

        
        public static void Insertion(int num, String[] arr)
        {
            String[] str = new String[num];
             int j;
            for (int i = 1; i < num; i++)
            {
               /* Console.WriteLine("Sort Passsed");*/
                String key = arr[i];

                for (j = i - 1; j >= 0 && key.CompareTo(arr[j]) < 0; j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[j + 1] = key;
            }
            Console.WriteLine("Sorted list of String:");

            for (int c = 0; c < num; c++)
                Console.WriteLine(arr[c]+ " ");


            /*Console.WriteLine("Swapping Elements: New Array After Swap");
                Console.WriteLine(arr);*/
        }

        /*------------------------------MergeSort---------------------------------*/

        public static void mergeSort(String[] arr, int from, int to)
        {
            if (from == to)
            {
                return;
            }
            int mid = (from + to) / 2;
            // sort the first and the second half
            mergeSort(arr, from, mid);
            mergeSort(arr, mid + 1, to);
            merge(arr, from, mid, to);
        }

        public static void merge(String[] arr, int from, int mid, int to)
        {
            int n = to - from + 1;       
            String[] b = new String[n];   // merge both halves into a temporary array b
            int i1 = from;               // next element to consider in the first range
            int i2 = mid + 1;            // next element to consider in the second range
            int j = 0;                   // next open position in b

            // as long as neither i1 nor i2 past the end, move the smaller into b
            while (i1 <= mid && i2 <= to)
            {
                if (arr[i1].CompareTo(arr[i2]) < 0)
                {
                    b[j] = arr[i1];
                    i1++;
                }
                else
                {
                    b[j] = arr[i2];
                    i2++;
                }
                j++;
            }

            
            while (i1 <= mid)
            {
                b[j] = arr[i1];
                i1++;
                j++;
            }

            while (i2 <= to)
            {
                b[j] = arr[i2];
                i2++;
                j++;
            }

            for (j = 0; j < n; j++)
            {
                arr[from + j] = b[j];
            }

            Console.WriteLine("Sorted list of String:");

            for (int c = 0; c < n; c++)
                Console.WriteLine (arr[c] + " ");
        }//end merge

       





    }
}

    