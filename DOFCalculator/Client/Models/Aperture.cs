using System.Collections.Generic;

namespace DOFCalculator.Client.Models
{
    public class Aperture : Dictionary<string, double>
    {
        public static Aperture Default => new Aperture
            {
                {"f/1",     1},
                {"f/1.2",   1.189207115},
                {"f/1.4",   1.414213562},
                {"f/1.8",   1.781797436},
                {"f/2",     2.0},
                {"f/2.8",   2.8},
                {"f/4",     4.0},
                {"f/5.6",   5.7},
                {"f/8",     8.0000000},
                {"f/11",    11.313708},
                {"f/16",    16.0},
                {"f/22",    22.6},
                {"f/32",    32.0}
            };
    }
}
