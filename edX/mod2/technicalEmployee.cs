using System;
namespace Mod2_Lab1
{
    public class TechnicalEmployee : Employee
    {

        public int successfulCheckIns = 5;

        public TechnicalEmployee(String name) : base (name, 75000)
        {
        }

        public override String employeeStatus()
        {
            return this.toString() + "has " + this.successfulCheckIns + " successful check ins.";
        }
    }
}
