using System.Collections.Generic;
using UnitsNet.Units;

namespace DOFCalculator.Client.Models
{
    public class UnitMultiplicationFactors : Dictionary<LengthUnit, double>
    {
        public static UnitMultiplicationFactors Default => new UnitMultiplicationFactors
        {
            { LengthUnit.Meter, 1 },
            { LengthUnit.Foot, 0.3048 }
        };
    }
}
