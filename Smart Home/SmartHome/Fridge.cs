using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Fridge : Appliance
    {
        //Constructor
        public Fridge(string name) : base(name)
        { }

        //Methods
        public override bool TurnOn()
        {
            if (base.TurnOn())
            {
                Console.WriteLine(Name + "The frigde opened!");
                return true;
            }
            else
            {
                Console.WriteLine(Name + " has already opened!");
                return false;
            }
        }

        public override bool TurnOff()
        {
            if (base.TurnOff())
            {
                Console.WriteLine(Name + " closed!");
                return true;
            }
            else
            {
                Console.WriteLine(Name +  "The fridge has already closed!");
                return false;
            }
        }

        public override string GetTypes()
        {
            return "Fridge";
        }
    }
}
