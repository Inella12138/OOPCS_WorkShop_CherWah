using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorChangingLamp
{
    public class Lamp
    {
        private bool isON;
        private string color;
        private int sel;
        private string[] colorsel = { "red", "green", "blue" };
    
        public Lamp() 
        {
            isON = false;
            sel = 0;
            color = colorsel[sel];
        }

        public bool isLampOn() { return isON; }

        public void TurnOn()
        {
            if (!isLampOn())
            {
                isON = true;
            }
            color = colorsel[sel];
            sel++;
            if (sel == 3) { sel = 0; }
        }

        public void TurnOff()
        {
            if (isLampOn()) 
            {
                isON = false;
            }
        }

        public string showCurrentColor()
        {
            return color;
        }
    }
}
