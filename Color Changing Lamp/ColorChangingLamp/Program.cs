using ColorChangingLamp;

Lamp lamp = new Lamp();
Lamp lamp2 = new Lamp();    

for (int i = 0; i < 10; i++)
{
    lamp.TurnOn();
    lamp2.TurnOn();
    Console.WriteLine("The color of the lamp is "+ lamp.showCurrentColor()+".");
    Console.WriteLine("The color of the lamp2 is " + lamp2.showCurrentColor() + ".");
    lamp.TurnOff();
    lamp2.TurnOff();
}
