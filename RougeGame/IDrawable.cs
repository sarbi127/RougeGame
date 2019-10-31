using System;

namespace RougeGame
{
    interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}