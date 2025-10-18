using System;
using System.Transactions;
using prj;

namespace prj
{
    class Program()
    {
        static void Main(string[] args)
        {
            Killer klr = new("13", 23, [33, 43, 53], 34);

            klr.Health = 100;
            System.Console.WriteLine(klr.Health);

            List<Robot> rbts = [
            new("15", 25, [35, 45, 55]),
new("16", 26, [36, 46, 56]),
new("17", 27, [37, 47, 57])
            ];

            foreach (Robot el in rbts)
            {
                Console.WriteLine("index i = {0}", rbts.IndexOf(el));
                el.prnPrm();
            }

            List<Robot> rbts2 = new List<Robot> { };
            rbts2.Add(new("Al", 25, [1, 2, 3]));
            rbts2.Add(new("Bg", 30, [4, 5, 6]));

            foreach (Robot item in rbts2)
            {
                Console.WriteLine("index i = {0}", rbts.IndexOf(el));
                el.prnPrm();
            }


        }
    }
}