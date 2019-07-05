using System.Collections.Generic;
using System.Linq;

namespace BowlingBall
{
    internal class GetScore : IScore
    {
        private readonly List<ISelectMethod> score;
        public GetScore()
        {
            score = new List<ISelectMethod>();
            score.Add(new Strike());
            score.Add(new Spare());
            score.Add(new Normal());
        }
        public void Score(int i)
        {
             score.First(r => r.SelectMethod(i)).Score(i);
        }
    }
}