using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Class
{
    class SimpleBowlingGame : ISimpleBowlingGame
    {
        // Default constructor initializes game to first Frame
        public SimpleBowlingGame()
        {
        }

        public int Score { get; set; }

        public void RecordFrame(params int[] throws)
        {
           
        }
    }
}
