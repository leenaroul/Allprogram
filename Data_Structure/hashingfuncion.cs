//----------------------------------------------------
// <copyright file="Hashingfunction.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace fellowshipleenaroul.Data_Structure
{
    /// <summary>
    /// Hashingfunction as a class
    /// </summary>
    class hashingfuncion
    {
        public static void HashChain()
        {
            try
            {
                Utility utility = new Utility();

                ////Creates array having 11 slots////
                hash[] hash = new hash[11];
                for (int i = 0; i < 11; i++)
                {
                    hash[i] = new hash(i);
                }

                ////Read the numbers from file and display////
                string path = @"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\HashNumbers.txt";
                utility.DispalyHash(hash, path);

                ////Take user input to search it in hash////
                Console.WriteLine("Enter number to be searched");
                int searchInput = Convert.ToInt32(Console.ReadLine());
                bool find = false;
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i].Search(searchInput))
                    {
                        find = true;
                        Console.WriteLine(searchInput + " is present in hash. So it is going to be deleted");
                        utility.DeleteFromFile(searchInput, hash[i]);
                        return;
                    }
                }

                if (!find)
                {
                    Console.WriteLine(searchInput + " is not present. So it is going to be addded");
                    utility.InsertInFile(searchInput, hash, path);
                }

                utility.DispalyHash(hash, path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
