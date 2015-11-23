using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 1;
            while (menuChoice != 0)
            {
                Console.Clear();
                Console.WriteLine("Tree i rad");
                Console.WriteLine("==========");
                Console.WriteLine("1. Start");
                Console.WriteLine("0. Exit");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                if (menuChoice == 1)
                {
                    Game.Run();
                }
            }
        }
    }
}