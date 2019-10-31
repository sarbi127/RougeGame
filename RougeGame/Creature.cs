using System;
using System.Collections.Generic;
using System.Text;

namespace RougeGame
{
    internal abstract class Creature : IDrawable
    {

        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public string Symbol { get; } = "C";
        public Cell Cell { get;  } 

        public Creature(Cell cell, string symbol)
        {
            Symbol = symbol;
            Cell = cell;
        }
    }
}
