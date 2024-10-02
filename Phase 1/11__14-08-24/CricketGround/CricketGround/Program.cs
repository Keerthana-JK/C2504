//1.Cricket Ground Boundry Sides Distances from batsman (from Pavilion End)
//        Leg Side 
//        Off Side  
//        Straight 
//        Third Man  
//    Compare two cricket grounds:
//        a) find the shortest distance from each ground and 
//        b) compare two ground based on shortest distance 
//            check which is preferred ground for batsman 

//    C#: CricketGround{ LegSideDistance: int, 
//        OffSideDistace: int,
//        StraightDistance: int,
//        ThirdManDistance: int }
//    -int FindShortestDistance()
//        among four distance find min 
//    - bool IsShortestDistanceGt(CricketGround other)     

//    C3: UserOfCricketGround will compare two grounds 
//        will say which ground is preferred ground 
using System;

namespace CricketGround
{
    internal class Program
    {
        class CricketGround
        {
            private int LegSideDistance;
            private int OffSideDistance;
            private int StraightDistance;
            private int ThirdManDistance;

            public CricketGround(int legSideDistance, int offSideDistance, int straightDistance, int thirdManDistance)
            {
                LegSideDistance = legSideDistance;
                OffSideDistance = offSideDistance;
                StraightDistance = straightDistance;
                ThirdManDistance = thirdManDistance;
            }

            public int FindShortestDistance()
            {
                return Math.Min(Math.Min(LegSideDistance, OffSideDistance), Math.Min(StraightDistance, ThirdManDistance));
            }
            public bool IsShortestDistanceGt(CricketGround other)
            {
                return this.FindShortestDistance() < other.FindShortestDistance();
            }

        }
        public static void Main(string[] args)
        {
            CricketGround cg1 = new CricketGround(100, 200, 150, 250);
            CricketGround cg2 = new CricketGround(210, 320, 120, 90);
            Console.WriteLine($"Shortest Distance from Cricket Ground 1: {cg1.FindShortestDistance()}");
            Console.WriteLine($"Shortest Distance from Cricket Ground 2: {cg2.FindShortestDistance()}");
            if (cg1.FindShortestDistance() > cg2.FindShortestDistance())
            {
                Console.WriteLine("Ground 2 is preferred for batsmen.");
            }
            else if (cg2.IsShortestDistanceGt(cg1))
            {
                Console.WriteLine("Ground 1 is preferred for batsmen.");
            }
            else
            {
                Console.WriteLine("Both grounds are equally preferred for batsmen.");


            }
        }

    }
}
