using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class WindTest
    {
        [TestMethod]
        public void TestShouldTurn()
        {
            var tc = new TurnClockwiseCommand();
            Wind wind = new Wind();

            tc.Execute(wind);
            Assert.AreEqual(Orientation.East, wind.Orientation);

            tc.Execute(wind);
            Assert.AreEqual(Orientation.South, wind.Orientation);

            tc.Execute(wind);
            Assert.AreEqual(Orientation.West, wind.Orientation);

            tc.Execute(wind);
            Assert.AreEqual(Orientation.North, wind.Orientation);
        }
    }
}
