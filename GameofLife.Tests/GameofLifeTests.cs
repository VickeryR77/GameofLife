using System;
using Xunit;

namespace GameofLife.Tests
{
    public class GameofLifeTests
    {
        [Theory]
        [InlineData(15 , false)]
        [InlineData(24, false)]
        public void Test1(int square, bool expected)
        {
            LifeGame test = new LifeGame(25);
            Assert.Equal(expected, test.World[square]);
        }

        [Fact]
        public void SurroundTest()
        {
            LifeGame test = new LifeGame(25);
            int[] cells = test.SurrondingCells(22, 25);
            Assert.Equal(23, cells[1]); // Right
            Assert.Equal(21, cells[0]); // left
            Assert.Equal(17, cells[2]);  // top
            Assert.Equal(2, cells[5]); // bottom
            Assert.Equal(16, cells[3]);  // top left
            Assert.Equal(18, cells[4]);  // top right
            Assert.Equal(1, cells[6]); // bottom left
            Assert.Equal(3, cells[7]); // bottom right
        }
    }
}
