# Name part (exa - Overload methods)
# Ifs:

<!-- IJump.cs
{
    public interface IJump
        float IJumpPrpY { get; set; }
        void IJumpMthDo();
}

IRun.cs
{
    public interface IRun
        float IRunPrpSpeed {get; set;}
        void IRunMthDo();

}

Robot.cs 
{
    abstract class Robot
        public Robot(string name, int weight, byte[] coordinates)

        private static "count" // str num Less

        private string "name"; // arg cl
        public string Name{get; private set;}

        private int "weight"
        public int Weight{get; set;}

        private byte[] coordinates
        public byte[] Coordinates{get; private set}

        public abstract void prnPrm();

        public float IJumpPrpY { get; set; }
        public void IJumpMthDo(){}

        public float IRunPrpSpeed {get; set;}
        public void IRunMthDo(){}
}

Bot.cs
{
    class Bot : Robot
        public Bot(string name, int weight, byte[] coordinates): 
            base(name, weight, coordinates)

        public override void prnPrm(){}
}

Killer.cs
{
    class Killer : Robot
        public KillerBot(string name, int weight, byte[] coordinates, int helth): 
                base(name, weight, coordinates)

        private int "helth"
        public int Helth{get; set;}

        public override void prnPrm(){}
} -->
