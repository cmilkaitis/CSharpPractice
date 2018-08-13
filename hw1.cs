using System;

namespace csharp_HW1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Color = "Red";
            car1.Manufacturer = "Toyota";
            Console.WriteLine("Car 1 is " + car1.Color + " and made by " + car1.Manufacturer);

            var saloonCar1 = new SaloonCar(2);
            Console.WriteLine("saloonCar1 has " + saloonCar1.Seats + " car seats");

            var saloonCar2 = new SaloonCar(3, "Nissan");
            Console.WriteLine("saloonCar2 has " + saloonCar2.Seats + " car seats and is made by " + saloonCar2.Manufacturer);

            var saloonCar3 = new SaloonCar(4, "Ford", "Purple");
            Console.WriteLine("saloonCar3 has " + saloonCar3.Seats + " car seats and is made by " + saloonCar3.Manufacturer + " and is the color " + saloonCar3.Color);

        }
    }

    public class Car
    {
        public Car(){
        }

        public string Color { get; set; }
        public string Manufacturer { get; set; }
    }

    public class SaloonCar : Car
    {
        
        public SaloonCar (int _Seats) {
            this.Seats = _Seats;
        }

        public SaloonCar (int _Seats, string _Manufacturer) {
            this.Seats = _Seats;
            this.Manufacturer = _Manufacturer;
        }

        public SaloonCar (int _Seats, string _Manufacturer, string _Color)
        {
            this.Seats = _Seats;
            this.Manufacturer = _Manufacturer;
            this.Color = _Color;
        }

        public int Seats { get; set; }
    }
}
