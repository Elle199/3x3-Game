using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1x2
{
    class Position
    {

        private int position1;
        private int position2;

        public Position(int pos1, int pos2)
        {
            position1 = pos1;
            position2 = pos2;
        }

        public int Position1
        {
            get { return position1; }
            set
            {
                if (value < 0 || value > 3)
                    Console.WriteLine("Sorry, value is not corect");
                else
                    position1 = value;
            }
        }

        public int Position2
        {
            get { return position2; }
            set
            {
                if (value < 0 || value > 3)
                    Console.WriteLine("Sorry, value is not corect");
                else
                    position2 = value;
            }
        }
    }
}
