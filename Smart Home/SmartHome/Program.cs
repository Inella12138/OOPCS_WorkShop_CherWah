using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Appliance living = new Lamp("Living_Room_Lamp");
            Appliance master = new Lamp("Master_Room_Lamp");
            Appliance study = new Lamp("Study_Room_Lamp");
            Appliance fridge = new Fridge("Fridge");

            for (int i = 0; i < 6; i++)
            {
                living.TurnOn();
                living.TurnOff();
            }
            for (int i = 0;i < 17;i++) 
            {
                master.TurnOn();
                master.TurnOff();
            }
            for (int i = 0; i < 9; i++)
            {
                study.TurnOn();
                study.TurnOff();
            }
            for (int i = 0; i < 28; i++)
            {
                fridge.TurnOn();
                fridge.TurnOff();
            }

            living.HealthCheck();
            study.HealthCheck();
            master.HealthCheck();
            fridge.HealthCheck();
        }
    }
}
