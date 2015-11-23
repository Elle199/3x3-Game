using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2.Player
{
    class Player
    {
        private string player;

        public Player(string plr)
        {
            player = plr;
        }

        public string Players
        {
            get { return player; }
            set { player = value; }
        }
    }
}
