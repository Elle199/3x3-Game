using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2.Player
{
    class Playerlist
    {
        List<Player> players = new List<Player>();

        public void newPlayer()
        {
            Console.Write("Player name: ");
            string plr = Console.ReadLine();
            Player player = new Player(plr);
        }
    }
}
