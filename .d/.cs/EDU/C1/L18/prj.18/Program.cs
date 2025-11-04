using System;
using System.Transactions;
using prj;

namespace prj
{
    class Program()
    {
        static void Main(string[] args)
        {
            var rob = new Robot(TypeRobot.Enemy);
        }


    }

    class Robot
    {
        public Robot(TypeRobot t)
        {
            Console.WriteLine($"t : {t}");
            Console.WriteLine($"(int)t : {(int)t}");
        }
    }

    enum TypeRobot { Enemy = 1, Hero = 2, Traitor = 3 };

}