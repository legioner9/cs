using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace prj
{
    class Bot : Robot
    {
        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        {
            // System.Console.WriteLine("base.name = {0}" , base.Name); // TODO base.width 0 !!!!
            // base.prnPrm();
            this.prnPrm();

        }

        public Bot() { }

        // write in chaild classes
        public override void prnPrm()
        {
            string name = "name : \"{0}\"";
            Console.WriteLine(name, this.Name);
            Console.WriteLine("weight : {0}", this.Weight);
            Console.WriteLine("coordinates : ");
            foreach (byte el in this.Coordinates)
            {
                Console.WriteLine(el);
            }
        }
    }
}