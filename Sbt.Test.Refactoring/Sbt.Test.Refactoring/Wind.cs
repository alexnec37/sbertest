using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class Wind : IUnit, IOriented, ICommandKind<TurnClockwiseCommand>
    {
        private Orientation _orientation = Orientation.North;
        public Orientation Orientation => _orientation;

        public void Apply(TurnClockwiseCommand command)
        {
            _orientation = Orientation.TurnClockwise();
        }
    }
}
