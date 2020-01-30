using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sbt.Test.Refactoring.Tests
{
    [TestClass]
    public class StoneTest
    {
        [TestMethod]
        public void TestShouldStatic()
        {
            var mf = new MoveForwardCommand();
            Stone stone = new Stone(new int[] { 2, 4 });
            mf.Execute(stone);

            Assert.AreEqual(2, stone.GetPositionX());
            Assert.AreEqual(4, stone.GetPositionY());
        }
    }
}
