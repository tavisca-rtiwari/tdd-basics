using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    class Normal : ISelectMethod
    {
        public void Score(int i)
        {
            Game.score += Game.roll[i] + Game.roll[i + 1];
            Game.i += 2;
            

        }

        public bool SelectMethod(int i)
        {
            return Game.roll[i]>=0 && Game.roll[i] <= 10;
        }
    }
}
