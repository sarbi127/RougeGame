using System;
using System.Collections.Generic;
using System.Text;

namespace RougeGame
{
    internal class Cell : IDrawable
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Symbol => ". ";
        public ConsoleColor Color { get; set; }

        //public Creature Creature { get; set; }

        public Cell()

        {
            Color = ConsoleColor.Red;
        }
    }
}
