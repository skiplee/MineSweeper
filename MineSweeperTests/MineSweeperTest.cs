using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MineSweeperTests
{
    [TestFixture]
    public class MineSweeperTest
    {
        [Test]
        public void Ctor()
        {
            //assemble
            int x = 4;
            int y = 6;
            int mines = 2;

            //act
            var mineSweeper = new MineSweeper(x,y,mines);

            //assert
            Assert.That(mineSweeper.Gameboard.DimensionX, Is.EqualTo(x));
            Assert.That(mineSweeper.Gameboard.DimensionY, Is.EqualTo(y));
            Assert.That(mineSweeper.Mines, Is.EqualTo(mines));
        }
    }
}
