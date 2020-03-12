using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var butterflyPredators = new List<string>()
            {
                "dogs",
                "cats",
                "lizards"
            };

            var butterflyPrey = new List<string>();
            butterflyPrey.Add("nectar");

            var butterfly = new bug("Judy", "monarch butterfly", butterflyPredators, butterflyPrey);

            var spiderPredators = new List<string>()
            {
                "bigger spiders",
                "cats",
                "lizards"
            };

            var spiderPrey = new List<string>()
            {
                "flies",
                "moths",
                "butterflies"
            };

            var spider = new bug("Jonathan", "wolf spider", spiderPredators, spiderPrey);

            Console.WriteLine(spider.Eat("cereal"));
            Console.WriteLine(spider.Eat("butterflies"));
            Console.WriteLine($"{spider.FormalName} hunts {spider.PreyList}");
            Console.WriteLine($"{butterfly.FormalName} hides from {butterfly.PredatorList}");
        }
    }
}
