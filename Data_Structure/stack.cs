//----------------------------------------------------
// <copyright file="stack.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace fellowshipleenaroul.Data_Structure
{
using System;
using System.Collections.Generic;
using System.Text;


    class stack
    {
        private static int limit = 1000;
        private int top = -1;
        private object[] Stack = new object[limit];

        public void Push(object data)
        {
            if (this.top >= limit - 1)
            {
                Console.WriteLine("stack overflow");
            }
            else
            {
                this.top = this.top + 1;
                this.Stack[this.top] = data;
            }
        }

        public void Pop()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stck underflow");
            }
            else
            {
                this.top--;
            }
        }

        public void peek()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
                return;
            }

            Console.WriteLine(this.Stack[this.top]);
            return;
        }

        public bool Isempty()
        {
            return this.top < 0;
        }

        public void print()
        {
            if (this.top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                for (int i = this.top; i >= 0; i--)
                {
                    Console.Write(this.Stack[i] + " ");
                }
            }
        }

        public int size()
        {
            return this.top + 1;
        }
    }
}
