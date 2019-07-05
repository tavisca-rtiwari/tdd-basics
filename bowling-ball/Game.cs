using System;

namespace BowlingBall
{
    public class Game
    {
        public static int[] roll = new int[21];
        public static int index = 0;
        public static int score = 0;
        public static int  i = 0;
        public void Roll(int pins)
        {
            if (index < 21)
            {
                roll[index++] = pins;
            } 
           // throw new NotImplementedException();
        }

        public int GetScore()
        {
            IScore iScore = new GetScore();
            score = 0;
            i = 0;
            index = 0;
            for (int frames = 0; frames < 10; frames++)
            {
                iScore.Score(i);
            }

            return score;
           // throw new NotImplementedException();
        }
    }
}

