using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    class Lamp : Appliance
    {
        //Constructor
        public Lamp(string name) : base(name)
        { }

        //Methods
        public override bool TurnOn()
        {
            if (base.TurnOn())
            {
                Console.WriteLine(Name + " is turned on!");
                return true;
            }
            else 
            {
                Console.WriteLine(Name + " is already on!");
                return false; 
            }
        }

        public override bool TurnOff()
        {
            if (base.TurnOff())
            {
                Console.WriteLine(Name + " is turned off!");
                return true;
            }
            else
            {
                Console.WriteLine(Name + " is already off!");
                return false;
            }
        }

        public override string GetTypes()
        {
            return "Lamp";
        }
    }
}
