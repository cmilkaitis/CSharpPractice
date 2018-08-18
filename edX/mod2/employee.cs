using System;
namespace Mod2_Lab1
{
    abstract class Employee
    {
        // private variables
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        // public properties
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public int ID { get; set; }

        // constructor
        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        // 'get' methods
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        public int getID()
        {
            return this.ID;
        }

        public virtual String toString()
        {
            return this.ID + " " + this.Name;
        }

        public abstract String employeeStatus()
        {
            return toString() + " is in the company's system";
        }
    }
}
