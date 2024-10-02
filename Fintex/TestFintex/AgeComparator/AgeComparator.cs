using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int vasyaAge = 29;
        int katyaAge = 14;
        int mishaAge = 36;

        int min = -1;
        int middle = -1;
        int max = -1;

        if (vasyaAge <= katyaAge && vasyaAge <= mishaAge)
        {
            min = vasyaAge;
            if (katyaAge <= mishaAge)
            {
                middle = katyaAge;
                max = mishaAge;
            }
            else
            {
                middle = mishaAge;
                max = katyaAge;
            }
        }
        else if (katyaAge <= vasyaAge && katyaAge <= mishaAge)
        {
            min = katyaAge;
            if (vasyaAge <= mishaAge)
            {
                middle = vasyaAge;
                max = mishaAge;
            }
            else
            {
                middle = mishaAge;
                max = vasyaAge;
            }
        }
        else
        {
            min = mishaAge;
            if (vasyaAge <= katyaAge)
            {
                middle = vasyaAge;
                max = katyaAge;
            }
            else
            {
                middle = katyaAge;
                max = vasyaAge;
            }
        }

        Console.WriteLine("Minimal age: " + min);
        Console.WriteLine("Middle age: " + middle);
        Console.WriteLine("Maximal age: " + max);
    }
}