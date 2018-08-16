using System;

namespace Program
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "YELLOW";
            car1.Year = 2018;
            car1.Mileage = 253;
            Console.WriteLine($"My car is a {car1.Color} {car1.Year} and only has {car1.Mileage} miles on it");
        }
    }

    public class Car 
    {
        // props
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

    }

}
