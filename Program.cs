using System;

namespace oop_6115261004_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel c1= new Channel("c01", "HRC","game");
            Video v1 = new Video("V01", "Best game2020", "game", 10000000, c1);
            Channel c2= new Channel("c02", "PEKO", "vlogD");
            Video v2 = new Video("V02", "Valorant live", "game", 400000000, c2);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(v1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(v2.ToString());
        }
    }
}