using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fuleTank;

            public Car(string _mark, string _model, string _regNumber, string _color)
            {
                mark = _mark;
                model = _model;
                regNumber = _regNumber;
                color = _color;
                odo = 0;
                fuleTank = 60;
                Console.WriteLine($"{color} {mark} {model} {regNumber} has been created.");
            }

            public string Model
            {
                get { return model; }
            }

            public string Mark
            {
                get { return mark; }
            }

            public string RegNumber
            {
                get { return regNumber; }
            }

            public string Color
            {
                get { return Color; }
            }

            public int Odo
            {
                get { return odo; }
            }

            public int FuleTank
            {
                get { return fuleTank; }
            }

            public void Drive()
            {
                fuleTank -= 5;
                odo += 100;
                Console.WriteLine("Vromm-vroom");
            }

            public void ShowCarInfo()
            {
                Console.WriteLine($"Mark: {mark}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"RegNumber: {regNumber}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odo: {odo}");
                Console.WriteLine($"Fule: {fuleTank}");
            }



        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Celica", "777BTJ", "Red");

            while(myCar.FuleTank > 0)
            {
                myCar.Drive();
            }


        }


    }
}
