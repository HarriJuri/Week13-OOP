using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungriness

        }
        static Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
            hungriess = 0
            Console.WriteLine($"A cat named {name} has appeard!");
        }
        
        public string Name //Name getter
        {
            get { return Name; }
        }
        public string Color
        {
            get { return Color; }
        }
        public double Hungriness
        {
            get { return hungriness; }
        }
        public void Sleep()
        {
            Console.WriteLine("*Sleeps*");
            Hungriness += 0.2,
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
    
    
    static void Main(string[] args)
    {
        Cat mycat = new Cat("")
    }







}
