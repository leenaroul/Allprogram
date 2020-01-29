//----------------------------------------------------
// <copyright file="Unorderlist.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


    class Unorderlist
    {
        public static void UnOrderedlist()
        {
            try
            {
                Linkedlist list = new Linkedlist();
                StreamReader file = new StreamReader(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\File.txt", Encoding.UTF8);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    for (int i = 0; i < word.Length; i++)
                    {
                        list.Append(word[i]);
                    }
                }

                list.Show();
                string end = file.ReadToEnd();
                file.Close();
                Console.WriteLine();
                Console.WriteLine("Enter word to find");
                string find = Console.ReadLine();
                string changeFile = File.ReadAllText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\File.txt", Encoding.UTF8);
                if (list.Search(find))
                {
                    list.Remove(find);
                    changeFile = changeFile.Replace(find, string.Empty);
                    File.WriteAllText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\File.txt", changeFile);
                }
                else
                {
                    list.Append(find);
                    using (StreamWriter sw = File.AppendText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\File.txt"))
                    {
                        sw.WriteLine(find);
                    }
                }

                list.Show();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

