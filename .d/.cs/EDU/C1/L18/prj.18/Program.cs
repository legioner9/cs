using System;
using System.Transactions;
using prj;

namespace prj
{
    class Program()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            var a = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("enter b");
            var b = Convert.ToInt32(Console.ReadLine());

            Mul(a, b);

        }

        public static void Mul(int a, int b)
        {
            Console.Write(a * b);
        }

        public static void Mul(double a, double b)
        {
            Console.Write(a * b);
        }
    }
}