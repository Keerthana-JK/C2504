//3.BikeRaceTrack
//        { Distance: int }
//-bool IsGt(BikeRaceTrack other)
//    TestBikeRaceTrack

using System;


namespace BikeRaceTrack
{
    class BikeRaceTrack
    {
        private int Distance;
        public BikeRaceTrack(int Distance) 
        {
            this.Distance = Distance;
        }
        public bool IsGt(BikeRaceTrack other)
        {  
            return Distance > other.Distance; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeRaceTrack b1 = new BikeRaceTrack(100);
            BikeRaceTrack b2 = new BikeRaceTrack(95);
            if (b1.IsGt(b2))
            {
                Console.WriteLine("Distance of Track 1 is greater than Track 2");
            }
            else if (b2.IsGt(b1))
            {
                Console.WriteLine("Distance of Track 1 is less than Track 2");
            }
            else
            {
                Console.WriteLine("Both tracks have equal distance");
            }
        }
    }
}
