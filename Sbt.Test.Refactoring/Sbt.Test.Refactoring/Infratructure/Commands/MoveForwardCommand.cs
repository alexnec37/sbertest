using System;
using System.Collections.Generic;
using System.Text;

namespace Sbt.Test.Refactoring
{
    public class MoveForwardCommand : ICommand
    {
        public void Execute(IUnit unitCmd)
        {
            if (unitCmd is ICommandKind<MoveForwardCommand> target)
            {
                target.Apply(this);
            }
        }
    }
}
