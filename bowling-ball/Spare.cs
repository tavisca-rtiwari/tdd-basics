using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingBall
{
    class Spare : ISelectMethod
    {
        public void Score(int i)
        {
            Game.score += Game.roll[i] + Game.roll[i + 1] + Game.roll[i + 2];
            Game.i += 2;
            
        }

        public bool SelectMethod(int i)
        {
            return (Game.roll[i] + Game.roll[i+1] )== 10;
        }
    }
}
