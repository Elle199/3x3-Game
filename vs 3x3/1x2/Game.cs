using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Game
    {
        static string[,] location = new string[3, 3];
        List<Position> positions = new List<Position>();
        public static void Run()
        {
            int winner = 0;
            Console.Clear();
            while(winner != 1)
            {
                for (int i = 0; i < location.GetLength(0); i += 1)
                {
                    for (int l = 0; l < location.GetLength(1); i += 1)
                    {
                        Console.WriteLine(location[i, l]);
                    }
                }
            }
        }

        public static void WinCheck()
        {
            if (location[0,0] == "x" && location[1,0] == "x" && location[2, 0] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }else if (location[0, 1] == "x" && location[1, 1] == "x" && location[2, 1] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }else if (location[0, 2] == "x" && location[1, 2] == "x" && location[2, 2] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }
            else if (location[0, 0] == "x" && location[0, 1] == "x" && location[0, 2] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }
            else if (location[0, 1] == "x" && location[1, 1] == "x" && location[2, 1] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }
            else if (location[0, 2] == "x" && location[1, 2] == "x" && location[2, 2] == "x")
            {
                Console.WriteLine("Player 1 wins");
            }
        }
    }
}