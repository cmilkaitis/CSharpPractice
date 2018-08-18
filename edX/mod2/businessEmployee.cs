using System;
namespace Mod2_Lab1
{
    public class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public BusinessEmployee(String name) : base (name, 50000)
        {
        }

        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
