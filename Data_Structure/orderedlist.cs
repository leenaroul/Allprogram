namespace fellowshipleenaroul.Data_Structure
{
    //----------------------------------------------------
    // <copyright file="orderedlist.cs" company="Bridgelabz">
    // Company copyright tag.
    // </copyright>
    //----------------------------------------------------
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;

    class orderedlist
    {
        public static void OrderedList()
        {
            try
            {
                Linkedlist list = new Linkedlist();
                var file = File.ReadAllText(@"C:\Users\Admin\Desktop\Git_Leena\Allprogram\Data_Structure\Numbers.txt", Encoding.UTF8);
                string[] values = file.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    list.Append(Convert.ToInt32(values[i]));
                }

                for (int i = 0; i < list.Size(); i++)
                {
                    for (int j = 0; j < list.Size() - 1; j++)
                    {
                        if (Convert.ToInt32(list.Get(j)) > Convert.ToInt32(list.Get(j + 1)))
                        {
                            int temp = Convert.ToInt32(list.Get(j));
                            list.Put(j, list.Get(j + 1));
                            list.Put(j + 1, temp);
                        }
                    }
                }

                list.Show();
                Console.WriteLine("Enter any number");
                int input = Convert.ToInt32(Console.ReadLine());
                if (list.Search(input))
                {
                    list.Remove(input);
                }
                else
                {
                    list.AddOrder(input);
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
