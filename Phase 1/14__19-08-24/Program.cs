//Interface in Older C# (Before 8.0)

using System;

namespace InterfaceInOldCSharp
{
    public interface IPlayer
    {
        void Play();//access modifier is not valid here for methods in interface (public void Play() not permitted)
        void Out(); // Default inteface implementation is not allowed in Older C# (cannot have method definition)
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
    internal class Program
    {
        static void Main(string[] args)
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
}
