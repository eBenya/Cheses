using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    struct Square
    {
        public static Square none = new Square(-1,1);

        public int x { get; private set; }
        public int y { get; private set; }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(string pos)
        {
            if (pos.Length == 2 &&
                pos[0] >= 'a' && pos[0] <= 'h' &&
                pos[1] >= '1' && pos[1] <= '8')
            {
                x = pos[0] - 'a';
                y = pos[1] - '1';
            }
            else this = none;
        }

        public bool OnBoard() => x >= 0 && x <= 8 && y >= 0 && y <= 8;
    }
}
