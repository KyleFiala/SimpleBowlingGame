using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Class
{
    class SimpleBowlingGame : ISimpleBowlingGame
    {
        private bool strike = false;
        public int Frame { get; set; }
        public int Score { get; set; }

        // Default constructor initializes game to first Frame
        public SimpleBowlingGame()
        {
            Frame = 1;
        }
        public void RecordFrame(params int[] throws)
        {
            int frameTotal;
            if (throws.Length > 1)
                frameTotal = throws[0] + throws[1];
            else
                frameTotal = throws[0];

            int strikeBonus = frameTotal*2;

            int thirdThrow = 0;

            if (throws.Length > 2 && (frameTotal==10))
                thirdThrow = throws[2];
            
            // If input is invalid we are just going to ingore it
            if (frameTotal < 11)
            {
                if (Frame < 10)
                {
                    // Initialize Score if it's the first Frame
                    if (Frame == 1)
                        Score = 0;

                    // Check for Strike
                    if (frameTotal >= 10)
                    {
                        if (strike)
                        {
                            Score +=  strikeBonus;
                        }
                        else
                        {
                            strike = true;
                            Score += frameTotal;
                        }
                    }
                    else // There wasn't a strike this Frame
                    {
                        if (strike) // Check for strike on previous Frame
                            Score += strikeBonus;
                        else
                            Score += frameTotal;
                        // Reset Strike Marker
                        strike = false;
                    }
                    Frame++;
                }
                else // 10th Frame
                {
                    // Check for fill ball.
                    if (frameTotal == 10)
                    {
                        if (strike)
                            Score += strikeBonus + thirdThrow;
                        else
                            Score += frameTotal + thirdThrow;
                    }
                    else
                    {
                        if (strike)
                            Score += strikeBonus;
                        else
                            Score += frameTotal;
                    }
                    
                    // Restart to Frame one for next call
                    Frame = 1;
                }
            }
        }
    }
}
