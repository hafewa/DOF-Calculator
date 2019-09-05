using System.Collections.Generic;
using UnitsNet;

namespace DOFCalculator.Client.Models
{
    public class CameraSensorTypeDictionary : Dictionary<string, UnitsNet.Length>
    {
        public static CameraSensorTypeDictionary Default => new CameraSensorTypeDictionary
        {
            { "Full-Frame Camera",                  Length.FromMillimeters(0.030) },
            { "APS-C 1.6x Crop (Canon)",            Length.FromMillimeters(0.019) },
            { "APS-C 1.5x Crop (Nikon, Sony NEX)",  Length.FromMillimeters(0.020) },
            { "Micro 4/3 (Olympus, Panasonic)",     Length.FromMillimeters(0.015) }
        };
    }
}
