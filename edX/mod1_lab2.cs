using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car1 = new Car(2018, 544);
            var car2 = new Car("Red", 1969);
        
            Console.WriteLine($"Car 1 is a {car1.Year} and only has {car1.Mileage} miles on it.");
            Console.WriteLine($"Car 2 is {car2.Color} and is was made in {car2.Year}.");

            int count = Car.CountCars();
            Console.WriteLine($"There are {count} cars on the lot.");

        }
    }

    public class Car
    {
        // constructors
        public Car (string color, int year){
            this.Color = color;
            this.Year = year;
            instances++;
        }

        public Car (int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances++;
        }


        // props
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // static prop
        private static int instances = 0;

        public Car()
        {
            instances++;
        }

        public static int CountCars()
        {
            return instances;
        }

    }

}
