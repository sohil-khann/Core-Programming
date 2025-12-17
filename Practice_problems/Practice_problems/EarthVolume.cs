using System;
namespace Practice_problems
{
    public class EarthVolume
    {
        public EarthVolume()
        {
            double radiusKm = 6378;
            double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
            
            double volumeMiles3 = volumeKm3 / Math.Pow(1.6, 3);
            Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3} and cubic miles is {volumeMiles3}");
        }
    }
}