using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class CommonCommandTest
    {
        [TestMethod]
        public void TestShouldCorrectCommandExec()
        {
            var mf = new MoveForwardCommand();
            var tc = new TurnClockwiseCommand();
            Tractor tractor = new Tractor();
            Stone stone = new Stone(new int[] { 2, 4 });
            Wind wind = new Wind();
            mf.Execute(tractor);
            mf.Execute(wind);
            mf.Execute(stone);
            tc.Execute(tractor);
            tc.Execute(wind);
            tc.Execute(stone);

            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(1, tractor.GetPositionY());
            Assert.AreEqual(Orientation.East, tractor.Orientation);

            Assert.AreEqual(Orientation.East, wind.Orientation);

            Assert.AreEqual(2, stone.GetPositionX());
            Assert.AreEqual(4, stone.GetPositionY());
        }

    }
}
