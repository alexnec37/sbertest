using System;
using System.Collections.Generic;
using System.Text;

namespace Sbt.Test.Refactoring
{
    public interface ICommandKind<T> where T : ICommand
    {
        void Apply(T command);
    }
}
