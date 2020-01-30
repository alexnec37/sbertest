using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class Stone : IUnit, IPositioned
    {
        private int[] _position = new int[] { 3, 2 };

        public Stone(int[] position)
        {
            _position = position;
        }
        public int GetPositionX()
        {
            return _position[0];
        }

        public int GetPositionY()
        {
            return _position[1];
        }
    }
}
