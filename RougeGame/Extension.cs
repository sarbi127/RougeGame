using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RougeGame
{
    static class Extension
    {
        public static IDrawable CreatureAtExten(this IEnumerable<Creature> creatures, Cell cell)
        {
            //var res = creatures
            //    .Where(c => c.Cell.Items.Count > 3)
            //    .Select(i => new
            //    {
            //        nrOfItems = i.Cell.Items.Count,
            //        i.Cell.Symbol
            //    });
            return creatures.FirstOrDefault(c => c.Cell == cell);



        }

    }
}

