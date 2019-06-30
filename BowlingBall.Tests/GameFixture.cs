using System;
using Xunit;

namespace BowlingBall.Tests
{
    public class GameFixture : IDisposable
    {
        private Game game;
        public  GameFixture()
        {
            game = new Game();
        }
        public void Dispose()
        {
            game = null;
        }

        [Fact]
        public void TestRoll()
        {
            game.Roll(10);
            RollTimes(1, 20);
        }
        [Fact]
        public void TestGetScore()
        {
            game.Roll(2);
            game.Roll(3);
            RollTimes(1,19);
            Assert.Equal(23, game.GetScore());

        }
        [Fact]
        public void TestSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollTimes(0, 17);
            Assert.Equal(16, game.GetScore());

        }
        [Fact]
        public void TestStrike()
        {
            game.Roll(10);
            game.Roll(5);
            game.Roll(4);
            RollTimes(0, 16);
            Assert.Equal(28, game.GetScore());
        }
        [Fact]
        public void TestAll()
        {
            int[] framepins = {10,10,4,5,9,1,5,5,0,0,
                               1,1,2,2,3,3,10,1,1};
            for(int i = 0; i < framepins.Length; i++)
            {
                game.Roll(framepins[i]);
            }
            Assert.Equal(101, game.GetScore());
        }

        private void RollTimes(int pins,int rolls)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
