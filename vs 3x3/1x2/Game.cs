using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Game
    {
        public static void Run()
        {
            int[] player1 = new int[2];
            int[] player2 = new int[2];
            string[,] gameboard = new string[3, 3];
            int winner = 0;
            Console.Clear();
            while (winner != 1)
            {
                player1posregi:
                Console.Write("Player 1 x-pos: ");
                player1[0] = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Player 1 y-pos: ");
                player1[1] = Convert.ToInt32(Console.ReadLine()) - 1;
                if (gameboard[player1[0], player1[1]] != "x" && gameboard[player1[0], player1[1]] != "o")
                    gameboard[player1[0], player1[1]] = "x";
                else
                {
                    Console.WriteLine("Space taken");
                    goto player1posregi;
                }
                player2posregi:
                Console.Write("Player 2 x-pos: ");
                player2[0] = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Player 2 y-pos: ");
                player2[1] = Convert.ToInt32(Console.ReadLine()) - 1;
                if (gameboard[player2[0], player2[1]] != "x" && gameboard[player2[0], player2[1]] != "o")
                    gameboard[player2[0], player2[1]] = "o";
                else
                {
                    Console.WriteLine("Space taken");
                    goto player2posregi;
                }
                Console.Clear();
                for (int i = 0; i < gameboard.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int l = 0; l < gameboard.GetLength(1); l++)
                    {
                        Console.Write(gameboard[l , i] + "|");
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}