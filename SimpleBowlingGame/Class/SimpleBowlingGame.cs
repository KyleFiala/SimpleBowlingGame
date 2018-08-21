using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Class
{
    class SimpleBowlingGame : ISimpleBowlingGame
    {
        int frame;

        public int Score { get; set; }

        public void RecordFrame(params int[] throws)
        {
        }
    }
}
