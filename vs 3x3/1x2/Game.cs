using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Game
    {
        static string[,] gameboard = new string[3, 3];
        List<Position> positions = new List<Position>();
        public static void Run()
        {
            Location player = new Location();
            int winner = 0;
            Console.Clear();
            while(winner != 1)
            {
                Console.WriteLine("Player 1: ");
                player.newPosP1();
                gameboard[1, 2] = "x";
                Console.Clear();
                Console.WriteLine("Player 2: ");
                player.newPosP2();
                gameboard[0, 2] = "o";
                Console.Clear();
                for (int i = 0; i < gameboard.GetLength(0); i++)
                {
                    Console.WriteLine("");
                    for (int l = 0; l < gameboard.GetLength(1); l++)
                    {
                        Console.Write(gameboard[l , i]);
                    }
                }
            }
        }
    }
}