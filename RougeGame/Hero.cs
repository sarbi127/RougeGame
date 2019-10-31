using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RougeGame 
{
   
       internal class Hero : Creature
    {
        public Hero(Cell cell) : base(cell, "H ")
        {
            Color = System.ConsoleColor.Yellow;

        }

    }
}

