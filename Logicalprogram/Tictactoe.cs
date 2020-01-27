namespace fellowshipleenaroul.Logicalprogram
{
    /// <copyright file= Tictactoe.cs" company="Bridgelabz" >
    /// Company copyright tag
    /// </copyright>
    using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
    class Tictactoe
    {
        static char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 1;///here it will check who won
                            /// <summary>
                            /// this is tictactoe game class
                            /// </summary>
        public static void tictactoe()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" player1: X and Player2: 0");
                Console.WriteLine("\n");
                if (player % 2 == 0)//chance of player
                {
                    Console.WriteLine(" second player chance");
                }
                else
                {
                    Console.WriteLine(" first player chance");
                }
                Console.WriteLine();
                Board();
                choice = int.Parse(Console.ReadLine()); ///user choice
                if (array[choice] != 'X' && array[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        array[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        array[choice] = 'X';
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already marked then show message and load board again  
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, array[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = Checkwin();// calling of check win  
            }
            while (flag != 1 && flag != -1);// This loof will be run until all cell of the grid is not marked with X and O or some player is not win  

            Console.Clear();// clearing the console  
            Board();// getting filled board again  

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }

            else// if flag value is -1 the match will be draw and no one is winner  
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
            Console.WriteLine("     |     |      ");
        }

        ///checking any player won or not
        private static int Checkwin()
        {
            ///winning condition first row
            if(array[1] == array[2] && array[2]==array[3])
            {
                return 1;
            }
            ///winning condition second row
            else if (array[4]== array[5] && array[5] == array[6])
            {
                return 1;
            }
            ///winning condition third row
            else if (array[7] == array[8] && array[8]==array[9])
            {
                return 1;
            }
            //Winning Condition First Column
            else if (array[1] == array[4] && array[4] == array[7])
            {
                return 1;
            }
            //Winning Condition Second Column  
            else if (array[2] == array[5] && array[5] == array[8])
            {
                return 1;
            }
            //Winning Condition Third Column  
            else if (array[3] == array[6] && array[6] == array[9])
            {
                return 1;
            }
            ///Winning Condition first diagonal
            else if (array[1] == array[5] && array[5] == array[9])
            {
                return 1;
            }
            ///Winning Condition second diagonal
            else if (array[3] == array[5] && array[5] == array[7])
            {
                return 1;
            }
            // If all the cells or values filled with X or O then player has won the match  
            else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


    }
}
