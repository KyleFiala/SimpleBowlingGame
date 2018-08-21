using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Class
{
    class SimpleBowlingGame : ISimpleBowlingGame
    {
        private int frame;

        // Default constructor initalises game to first frame
        public SimpleBowlingGame()
        {
            frame = 1;
        }

        public int Score { get; set; }

        public void RecordFrame(params int[] throws)
        {
            // Player has two throws if it is not the 10th frame
            if (frame < 10)
            {
                frame++;
            }
            else // Player has possible 3 throws on the 10th frame
            {
                frame = 1;
            }
        }
    }
}
