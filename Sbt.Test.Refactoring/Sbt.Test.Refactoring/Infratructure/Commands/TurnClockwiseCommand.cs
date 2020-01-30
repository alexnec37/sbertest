using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring
{
    public class TurnClockwiseCommand : ICommand
    {
        public void Execute(IUnit unitCmd)
        {
            if (unitCmd is ICommandKind<TurnClockwiseCommand> target)
            {
                target.Apply(this);
            }
        }
    }
}
