using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomList
{
    private int[] randomArray;
    private int seed;
    //List<int> randomList = new List<int>();

    //Constructor
    public RandomList(int n)
    {
        randomArray = new int[n];        
    }

    //Seed attribute being implemented as a C# Property
    public int Seed
    {
        get { return seed; }
        set
        {
            if (value >= -10 && value <= 10)
            {
                seed = value;
            }
        }
    }

    public bool Generate(int n, int low, int high)
    {
        bool flag = false;//to see if [low < high]
        //randomList = new List<int>();
        Random rnd = new Random(seed);//generate random numbers with given seed
        if (low < high)
        {
            flag = true;
            for (int i = 0; i <n; i++)
            {
                int t = rnd.Next(low, high);
                randomArray[i] = t;//store numbers in array
                //randomList.Add(t);
            }
            return flag;
        }
        else { return flag; }
    }

    public void Show()
    {
        Console.Write("The random numbers are:");
        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i]+"\t");
        } 
        Console.WriteLine();
        /*for (int i = 0; i < randomList.Count; i++)
        {
            Console.Write(randomList[i] + "\t");
        }
        Console.WriteLine();*/
    }

    public float Mean()
    {
        float ave = 0;
        for(int i = 0;i < randomArray.Length;i++)
        {
            ave += randomArray[i] / randomArray.Length;
        }
        /*for (int i = 0; i < randomList.Count; i++)
        {
            ave += randomList[i] / randomList.Count;
        }*/
        return ave;
    }
}

