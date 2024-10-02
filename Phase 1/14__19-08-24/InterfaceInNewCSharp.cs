//Interface in new C# (8.0 or above)
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var FootBallPlayer = new FootBallPlayer();
        FootBallPlayer.Play();
        FootBallPlayer.Out();

        var BasketBallPlayer = new BasketBallPlayer();
        BasketBallPlayer.Play();
        BasketBallPlayer.Out();
    }
}

public interface IPlayer
{
    public void Play();
    public void Out() // allows method definition //not possible in Older version
    {
        Console.WriteLine("Stop Playing!!!");
    }
}

public class FootBallPlayer : IPlayer
{
    public void Play()
    {
        Console.WriteLine("FootBall Player is playing");
    }
    public void Out()
    {
        Console.WriteLine("FB player is out");
    }
}

public class BasketBallPlayer : IPlayer
{
    public void Play()
    {
        Console.WriteLine("BasketBall Player is playing");
    }
    public void Out()
    {
        Console.WriteLine("FB player is out");
    }
}