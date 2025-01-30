using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.Common
{
    public class Elevation
    {
        private const string ElevationClass = "mdc-elevation--z{0}";
        private readonly int _elevation;

        public Elevation(int elevation)
        {
            _elevation = NormalizeElevation(elevation);
        }

        private int NormalizeElevation(int elevation)
        {
            if (elevation < 0)
            {
                return 1;
            }

            if (elevation > 24)
            {
                return 24;
            }

            return elevation;
        }

        public override string ToString()
        {
            return string.Format(ElevationClass, _elevation);
        }

        public static string Elevate(int elevation)
        {
            return new Elevation(elevation).ToString();
        }
    }
}
