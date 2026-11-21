using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpVS
{
    internal class Game
    {
        public string title { get; set; }
        public string studio { get; set; }
        public string price { get; set; }
        public string time { get; set; }
        public static void Run()
        {
            Game game1 = new Game();
            game1.title = "the legend of c#";
            game1.studio = "code with luna ";
            game1.price = "50k";
            game1.time = "6 hours";
            Console.WriteLine(game1.title);
            Console.WriteLine(game1.studio);
            Game game2 = new Game();
            game2.title = "c# adventure";
            game2.studio = "code with luna ";
            game2.price = "40k";
            game2.time = "8 hours";
            Console.WriteLine(game2.price);

        }
    }
}
