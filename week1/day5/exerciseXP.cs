// // EXERCISE 1

// // EXERCISE 2
using System;

class Player
{
    public int HealthMain = 200;
    public int HealthFeature = 150;
}

class Program
{
    static void Main()
    {
        var p = new Player();
        Console.WriteLine("Main Health: " + p.HealthMain);
        Console.WriteLine("Feature Health: " + p.HealthFeature);
    }
}
