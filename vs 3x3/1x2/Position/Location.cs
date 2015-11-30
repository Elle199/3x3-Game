using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Location
    {
        List<Position> Player1 = new List<Position>();
        List<Position> Player2 = new List<Position>();
        Position newPlayer1;
        Position newPlayer2;
        public void newPosP1()
        {
            Console.Write("X-pos: ");
            int xpos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y-pos: ");
            int ypos = Convert.ToInt32(Console.ReadLine());
            newPlayer1 = new Position(xpos, ypos);
            Player1.Add(newPlayer1);
        }

        public void newPosP2()
        {
            Console.Write("X-pos: ");
            int xpos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y-pos: ");
            int ypos = Convert.ToInt32(Console.ReadLine());
            newPlayer2 = new Position(xpos, ypos);
            Player2.Add(newPlayer2);
        }
    }
}
