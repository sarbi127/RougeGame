using System;
using System.Collections.Generic;
using System.Text;

namespace RougeGame
{
    class Goblin : Creature
    {
        public Goblin(Cell cell) : base(cell, "G ", 25)
        {
            
            Color = ConsoleColor.Green;
            Damage = 15;

        }

    }
}

