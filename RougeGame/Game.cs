using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RougeGame
{
    internal class Game
    {
             private Map map;
             private Hero hero;
             private bool gameInProgress = true;

        public Game()
        { }
        
        internal void Run()
        {
            Initialize();
            Play();
        }
        private void Play()
        {
            //do

            do

            {



                //draw map

                Draw();

                //get command

                GetInput();

                //execute action

                //draw map

                Draw();

                //enemy actions

                //draw map



            } while (gameInProgress);

            //while game in progress

        }

        private void GetInput()

        {

            ConsoleKey keyPressed = UI.GetKey();

            switch (keyPressed)

            {

                case ConsoleKey.LeftArrow:

                    Move(Direction.W);
                    break;

                case ConsoleKey.UpArrow:

                    Move(Direction.N);
                    break;

                case ConsoleKey.RightArrow:

                    Move(Direction.E);
                    break;

                case ConsoleKey.DownArrow:

                    Move(Direction.S);
                    break;
                //case ConsoleKey.P:

                //    PickUp();
                //    break;

                //case ConsoleKey.I:

                //    Inventory();
                //    break;

                case ConsoleKey.Q:

                    gameInProgress = false;
                    break;

            }

            var actionMeny = new Dictionary<ConsoleKey, Action>()
            {
                { ConsoleKey.P, PickUp },
                { ConsoleKey.I, Inventory }
            };

            if (actionMeny.ContainsKey( keyPressed))actionMeny[keyPressed].Invoke();
                 
        }

        private void Inventory()
        {
            var counter = 1;
            var builder = new StringBuilder();
            builder.AppendLine("Inventory:");
            foreach (var item in hero.Backpack)
            {
                builder.AppendLine($"{counter}: \t{item}");
                counter++;
            }

            UI.AddMessage(builder.ToString());
        }


        private void PickUp()
        {
            if(hero.Backpack.IsFull)
            {

                UI.AddMessage("Backpack is full");
                return;
            }

            var items = hero.Cell.Items;
            var item = items.FirstOrDefault();
            if (item == null) return;
            if (hero.Backpack.Add(item))
            {
                //items.Remove(item);
                UI.AddMessage($"Hero pick up {item.ToString()}");
                items.Remove(item);

            }
        }

        private void Move(Position movement)

        {

            Position newPosition = hero.Cell.Position + movement;
            Cell newCell = map.GetCell(newPosition);

           // var opponent = (Creature)map.CreatureAt(newCell);
            var opponent = map.CreatureAt(newCell) as Creature;
            if (opponent != null) hero.Attack(opponent);
            if (newCell != null) hero.Cell = newCell;

        }

        private void Draw()
        {
            UI.Clear();
            UI.DrawMap(map);
            UI.PrintStats($"Health: {hero.Health}\n Enemys: {map.Creatures.Count}\n_______________");
            UI.PrintLog();

        }

        private void Initialize()

        {
            //ToDo: Read from config later

            map = new Map(width: 10, height: 10);

            AddCreatureAndItems();

     
        }


        private void AddCreatureAndItems()
        {

            var heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);
            map.Creatures.Add(hero);

            var random = new Random();
            map.Creatures.Add(new Goblin(map.GetCell(random.Next(0,9), random.Next(0, 9))));
            map.Creatures.Add(new Goblin(map.GetCell(random.Next(0, 9), random.Next(0, 9))));
            map.Creatures.Add(new Ogre(map.GetCell(random.Next(0, 9), random.Next(0, 9))));
            map.Creatures.Add(new Ogre(map.GetCell(random.Next(0, 9), random.Next(0, 9))));

            map.Creatures.ForEach(c => c.AddMessage = UI.AddMessage);
            map.Creatures.ForEach(c => c.AddMessage += (s) => Debug.WriteLine(s));

            map.GetCell(random.Next(0, 9), random.Next(0, 9)).Items.Add(Item.Coin());
            map.GetCell(random.Next(0, 9), random.Next(0, 9)).Items.Add(Item.Coin());
            map.GetCell(random.Next(0, 9), random.Next(0, 9)).Items.Add(Item.Coin());
            map.GetCell(random.Next(0, 9), random.Next(0, 9)).Items.Add(Item.Hat());


        }
    }
}