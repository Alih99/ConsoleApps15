using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in one unit and it will calculate and 
    /// output the equicalent distance in another unit.
    /// </summary>
    /// <author>
    /// Ali Hassan version 0.1
    /// modified by 14/02/2022
    /// </author>
    public class DistanceConverter
    {
        // constants for distance coversion
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

         //initialised instance variables
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        /// <summary>
        /// Constructor of the DistanceConverter Class
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

    }
}
