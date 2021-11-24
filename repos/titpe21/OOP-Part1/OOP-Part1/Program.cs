using System;

namespace OOP_Part1
{
    class Program
    {
        private static string userinput;

        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"the dog {name} has been created");
            }

            //getters
            public string Name //Name getter
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof");
                happiness += 0.2;
            }

            public void Wags()
            {
                Console.WriteLine($"{name}: Wiggle-wiggle");
            }

            public void Rename(string newname)
            {
                name = newname;
            }

            internal void showdogdata() 
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Spots: {Spots}");
                Console.WriteLine($"Happiness: {Happiness}");
            }
        }

        static void Main(string[] args)
        {
            Dog mydog = new Dog("koer", 15);
            mydog.Barks();
            mydog.Wags();
            Console.WriteLine($"{mydog.Name}'s level of happiness: {mydog.Happiness}");
            Dog2 mydog2 = new Dog2("peeter", 25);
            Console.WriteLine($"{mydog2.Name}'s level of happiness: {mydog2.Happiness}");

            mydog.Name = "Another dog";

            while(mydog.Happiness != 1)
            {
                mydog.Barks();
            }
            mydog.Wags();

            Console.WriteLine($"Enter a new name for my dog {mydog.Name}");
            string userinput = Console.ReadLine();
            mydog.Rename(userinput);
            mydog.showdogdata();






        }




        class Dog2
        {
            string name;
            int spots;
            double happiness;

            public Dog2(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"the dog {name} has been created");
            }

            public object Happiness { get; internal set; }
            public object Name { get; internal set; }
        }
    }
}
