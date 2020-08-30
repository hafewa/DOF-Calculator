using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOFCalculator.Client.Models.ViewModels
{
    public class CameraSettings
    {
        public Aperture Aperture { get; }
        public CameraSensorType CameraSensorType { get; }
        public UnitsNet.Length LensForcalLength { get; }
        public UnitsNet.Length SubjectDistance { get; }
        public UnitsNet.Units.LengthUnit SubjectDistanceUnit { get; }
    }
}
