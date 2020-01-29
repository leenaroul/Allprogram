﻿//----------------------------------------------------
// <copyright file="hash.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// hash class
    /// </summary>
    class hash
    {
        private int index;

        /// <summary>
        /// linkedList to create new Linked List
        /// </summary>
        private Linkedlist linkedList;

        /// <summary>
        /// integer len to measure length of hash
        /// </summary>
        private int len = 0;

        /// <summary>
        /// Initialize the new instance of Hash
        /// </summary>
        /// <param name="index">index as a parameter</param>
        public hash(int index)
        {
            this.index = index;
            this.linkedList = new Linkedlist();
            this.len++;
        }

        /// <summary>
        /// Function to add the data
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void Add(object data)
        {
            this.linkedList.Append(data);
            this.linkedList.OrederLinkedList();
        }

        /// <summary>
        /// Function to show or print the data
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < this.len; i++)
            {
                if (this.linkedList.Get(i) != null)
                {
                    Console.Write(this.index + " : ");
                    this.linkedList.Show();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Function to search given data
        /// </summary>
        /// <param name="input">data, to be searched, as a parameter</param>
        /// <returns>returns true if data if present</returns>
        public bool Search(object input)
        {
            for (int j = 0; j < this.linkedList.Size(); j++)
            {
                if (this.linkedList.Search(input) == true)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Function to remove data
        /// </summary>
        /// <param name="data">data as a parameter</param>
        public void Remove(object data)
        {
            this.linkedList.Remove(data);
        }
    }
}
