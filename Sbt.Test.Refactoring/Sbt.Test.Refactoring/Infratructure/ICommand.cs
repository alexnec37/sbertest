using System;
using System.Collections.Generic;
using System.Text;

namespace Sbt.Test.Refactoring
{
    public interface ICommand
    {
        void Execute(IUnit unit);
    }
}
