﻿using System;

namespace RougeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Run();

            Console.WriteLine("Thanks for playing");

            Console.ReadKey();
        }
    }
}
