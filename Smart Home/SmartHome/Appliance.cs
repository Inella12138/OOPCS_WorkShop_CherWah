using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    delegate string StringOps();

    abstract class Appliance : IHealthChecker
    {
        private int useTimes;
        private string name;
        private bool isOn;

        //Constructor
        public Appliance(string name)
        {
            useTimes = 0;
            this.name = name;
            isOn = false;
        }

        //Property
        protected int UseTimes
        {
            get { return useTimes; }
        }

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected bool IsOn
        { 
            get { return isOn; }
        }

        //Methods
        public virtual bool TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                return true;
            }
            else { return false; }
        }

        public virtual bool TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                useTimes++;
                return true;
            }
            else { return false; }
        }

        public int GetUseTimes()
        {
            return useTimes;
        }

        public string GetName()
        {
            return name;
        }

        public abstract string GetTypes();

        public void HealthCheck()
        {
            bool flag = true;
            string name = GetName();
            int time = GetUseTimes();
            string type = GetTypes();

            if (time <= 15) { flag = true; }
            else if (time > 15 && time <= 20)
            {
                if  (type == "Fridge") {flag = true; }
                else { flag = false; }
            }
            else if  (time > 20) {flag = false; }

            if (!flag) { Console.WriteLine(name + " needs servicing after " + time + " uses."); }
            else { Console.WriteLine(name + " is healthy after " + time + " uses."); }
        }

    }
}
