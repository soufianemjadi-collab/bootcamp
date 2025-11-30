// // EXERCISE 3
using System;

class Player
{
    public float Speed = 5f;
    public float JumpForce = 12f;

    public void Move()
    {
        Console.WriteLine($"Player moving at speed {Speed}");
    }

    public void Jump()
    {
        Console.WriteLine($"Player jumped with force {JumpForce}");
    }
}

class Program
{
    static void Main()
    {
        var player = new Player();
        player.Move();
        player.Jump();
    }
}

