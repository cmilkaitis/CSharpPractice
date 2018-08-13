using System;

namespace bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var humanJake = new Man();
            humanJake. // has access to all props via Inheritance 
           
        }
    }

    public class GeneralObject
    {
        public GeneralObject () {
            
        }

        public string Color { get; set; }
        public bool Moves { get; set; }

    }

    public class Human : GeneralObject
    {
        public Human () {
            
        }
        public string Name { get; set; }

    }

    public class Man : Human
    {
        public Man () {
            
        }

    }

    public class Woman : Human
    {
        public Woman () {

        }

    }

    public class Kart : GeneralObject
    {
        public Kart() {
        }

        public string Manufac { get; set; }
    }

    public class Alien : GeneralObject
    {
        public Alien() {
        }

        public string Planet { get; set; }
    }
}

