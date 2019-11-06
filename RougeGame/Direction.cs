using System;
using System.Collections.Generic;
using System.Text;

namespace RougeGame
{
    static class Direction
    {
        public static Position E => new Position(0, 1);
        public static Position W => new Position(0, -1);
        public static Position N => new Position(-1, 0);
        public static Position S => new Position(1, 0);
    }
}
