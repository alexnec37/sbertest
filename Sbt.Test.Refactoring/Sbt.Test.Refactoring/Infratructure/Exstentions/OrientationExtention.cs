using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public static class OrientationExtention
    {
        public static Orientation TurnClockwise(this Orientation orientation)
        {
            if (orientation == Orientation.North)
            {
                orientation = Orientation.East;
            }
            else if (orientation == Orientation.East)
            {
                orientation = Orientation.South;
            }
            else if (orientation == Orientation.South)
            {
                orientation = Orientation.West;
            }
            else if (orientation == Orientation.West)
            {
                orientation = Orientation.North;
            }

            return orientation;
        }
    }
}
