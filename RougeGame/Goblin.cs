﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RougeGame
{
    class Goblin : Creature
    {
        public Goblin(Cell cell) : base(cell, "G ")
        {
            Damage = 15;
            Maxhealth = 25;

        }

    }
}

