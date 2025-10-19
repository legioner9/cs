using System;

namespace prj
{
    class Killer : Robot
    {
        public Killer(string name, int weight, byte[] coordinates, int helth) : base(name, weight, coordinates)
        {
            // System.Console.WriteLine("base.name = {0}", base.Name); // TODO base.width 0 !!!!
            this.Health = helth;
            // base.prnPrm();
            this.prnPrm();

        }

        public Killer() { }

        public int Health { get; set; }


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
            Console.WriteLine("Helth : {0}", this.Health);
        }
    }
}