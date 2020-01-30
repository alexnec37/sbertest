using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class TractorTest
    {
        [TestMethod]
        public void TestShouldMoveForward()
        {
            var mf = new MoveForwardCommand();
            Tractor tractor = new Tractor();
            mf.Execute(tractor);

            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(1, tractor.GetPositionY());
        }

        [TestMethod]
        public void TestShouldTurn()
        {
            var tc = new TurnClockwiseCommand();
            Tractor tractor = new Tractor();

            tc.Execute(tractor);
            Assert.AreEqual(Orientation.East, tractor.Orientation);

            tc.Execute(tractor);
            Assert.AreEqual(Orientation.South, tractor.Orientation);

            tc.Execute(tractor);
            Assert.AreEqual(Orientation.West, tractor.Orientation);

            tc.Execute(tractor);
            Assert.AreEqual(Orientation.North, tractor.Orientation);
        }

        [TestMethod]
        public void TestShouldTurnAndMoveInTheRightDirection()
        {
            var mf = new MoveForwardCommand();
            var tc = new TurnClockwiseCommand();
            Tractor tractor = new Tractor();

            tc.Execute(tractor);
            mf.Execute(tractor);
            Assert.AreEqual(1, tractor.GetPositionX());
            Assert.AreEqual(0, tractor.GetPositionY());

            tc.Execute(tractor);
            mf.Execute(tractor);
            Assert.AreEqual(1, tractor.GetPositionX());
            Assert.AreEqual(-1, tractor.GetPositionY());

            tc.Execute(tractor);
            mf.Execute(tractor);
            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(-1, tractor.GetPositionY());

            tc.Execute(tractor);
            mf.Execute(tractor);
            Assert.AreEqual(0, tractor.GetPositionX());
            Assert.AreEqual(0, tractor.GetPositionY());
        }

        [TestMethod]
        public void TestShouldThrowExceptionIfFallsOffPlateau()
        {
            var mf = new MoveForwardCommand();
            Tractor tractor = new Tractor();

            mf.Execute(tractor);
            mf.Execute(tractor);
            mf.Execute(tractor);
            mf.Execute(tractor);
            mf.Execute(tractor);

            try
            {
                mf.Execute(tractor);
                Assert.Fail("Tractor was expected to fall off the plateau");
            }
            catch (TractorInDitchException ex)
            {
            }
        }
    }
}
