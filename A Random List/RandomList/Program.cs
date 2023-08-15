//Main
using System.CodeDom.Compiler;

int n = 0;
int seed;
int low;
int high;
bool flag;

Console.Write("Please enter the number of random numbers you want to generate: ");
n = Convert.ToInt32(Console.ReadLine());
RandomList X = new RandomList(n);

Console.WriteLine("Please enter the range of numbers you want to generate: ");
low = Convert.ToInt32(Console.ReadLine());
high = Convert.ToInt32(Console.ReadLine());

flag = X.Generate(n, low, high);
if (!flag) { Console.WriteLine("Please check the range!"); }
else
{
    /*X.Seed = 5;
    X.Generate(n, low, high);
    X.Show();
    Console.WriteLine("The average value of the random number array is: " + X.Mean());
    Console.WriteLine("The seed of the random array is: " + X.Seed);
    X.Seed = -8;
    X.Generate(n, low, high);
    X.Show();
    Console.WriteLine("The average value of the random number array is: " + X.Mean());
    Console.WriteLine("The seed of the random array is: " + X.Seed);*/
    while (true)
    {
        Console.WriteLine("Please enter the seed for the random number array(-10 - 10): ");
        if (int.TryParse(Console.ReadLine(), out seed))
        {
            X.Seed = seed;
            X.Generate(n, low, high);
            X.Show();
            Console.WriteLine("The average value of the random number array is: " + X.Mean());
            Console.WriteLine("The seed of the random array is: " + X.Seed);
            Console.WriteLine();
        }
        else { break; }
    }
}