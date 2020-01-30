using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class Tractor : IUnit, IPositioned, IOriented, ICommandKind<MoveForwardCommand>, ICommandKind<TurnClockwiseCommand>
    {
        private int[] _position = new int[] { 0, 0 };
        private int[] _field = new int[] { 5, 5 };
        private Orientation _orientation = Orientation.North;

        public Orientation Orientation
        {
            get 
            {
                return _orientation;
            }
        }
        
        // для обратной совместимости
        public void Move(string command)
        {
            if (command == "F")
            {
                MoveForwards();
            }
            else if (command == "T")
            {
                _orientation = Orientation.TurnClockwise();
            }
        }

        private void MoveForwards()
        {
            if (_orientation == Orientation.North)
            {
                _position = new int[] { _position[0], _position[1] + 1 };
            }
            else if (_orientation == Orientation.East)
            {
                _position = new int[] { _position[0] + 1, _position[1] };
            }
            else if (_orientation == Orientation.South)
            {
                _position = new int[] { _position[0], _position[1] - 1 };
            }
            else if (_orientation == Orientation.West)
            {
                _position = new int[] { _position[0] - 1, _position[1] };
            }

            if (_position[0] > _field[0] || _position[1] > _field[1])
            { 
                throw new TractorInDitchException();
            }
        }

        public int GetPositionX()
        {
            return _position[0];
        }

        public int GetPositionY()
        {
            return _position[1];
        }
        public void Apply(MoveForwardCommand command)
        {
            MoveForwards();
        }

        public void Apply(TurnClockwiseCommand command)
        {
            _orientation = Orientation.TurnClockwise();
        }
    }
}
