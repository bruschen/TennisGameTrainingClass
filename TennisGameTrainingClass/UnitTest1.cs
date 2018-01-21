using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameTrainingClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            var expected = tennisGame.GetScore();
            var actual = "Love_All";

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Thirty_All()
        {
            TennisGame tennisGame = new TennisGame();
            tennisGame.SetHomeScore(1);
            var expected = tennisGame.GetScore();
            var actual = "Thirty_All";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Forty_All()
        {
            TennisGame tennisGame = new TennisGame();
            tennisGame.SetHomeScore(2);
            var expected = tennisGame.GetScore();
            var actual = "Forty_All";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            TennisGame tennisGame = new TennisGame();
            tennisGame.SetHomeScore(0);
            tennisGame.SetAwayScore(1);
            var expected = tennisGame.GetScore();
            var actual = "Forty_All";

            Assert.AreEqual(expected, actual);
        }
    }

    public class TennisGame
    {
        private int HomeCurrentScore;

        public object GetScore()
        {
            if (this.HomeCurrentScore==0)
            {
                return "Love_All";
            }
            else if (this.HomeCurrentScore==1)
            {
                return "Thirty_All";
            }
            else if (this.HomeCurrentScore==2)
            {
                return "Forty_All";
            }

            return "Love_All";
        }

        public void SetHomeScore(int score)
        {
            this.HomeCurrentScore = score;
        }

        public void SetAwayScore(int score)
        {
            this.SetAwayScore(score);
        }
    }
}
