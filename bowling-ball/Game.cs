using System;

namespace BowlingBall
{
    public class Game
    {
        private int[] Rolls = new int[21];
        private int Index = 0;
        public void Roll(int pins)
        {
            if (Index < 21)
            {
                Rolls[Index++] = pins;
            } 
           // throw new NotImplementedException();
        }

        public int GetScore()
        {
            int score = 0;
            int i = 0;
            for(int frames = 0; frames < 10; frames++)
            {
                if(IsStrike(i))
                {
                    score = StrikeScore(score, i);
                    i += 1;
                }
                else if(IsSpare(i))
                {
                    score = SpareScore(score, i);
                    i += 2;
                }
                else
                {
                    score = Score(score, i);
                    i += 2;
                }
            }

            return score;
           // throw new NotImplementedException();
        }

        private int Score(int score, int i)
        {
            score += Rolls[i] + Rolls[i + 1];
            return score;
        }

        private int SpareScore(int score, int i)
        {
            score += Rolls[i] + Rolls[i + 1] + Rolls[i + 2];
            return score;
        }

        private int StrikeScore(int score, int i)
        {
            score += Rolls[i] + Rolls[i + 1] + Rolls[i + 2];
            return score;
        }

        private bool IsSpare(int i)
        {
            return Rolls[i] + Rolls[i + 1] == 10;
        }

        private bool IsStrike(int i)
        {
            return Rolls[i] == 10;
        }
    }
}

