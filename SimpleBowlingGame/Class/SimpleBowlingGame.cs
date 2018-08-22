﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Class
{
    class SimpleBowlingGame : ISimpleBowlingGame
    {
        private int frame;
        private bool strike = false;

        public int Score { get; set; }
        // Default constructor initializes game to first frame
        public SimpleBowlingGame()
        {
            frame = 1;
        }
        public void RecordFrame(params int[] throws)
        {
            // Store at number of pins knocked down on each throw
            int firstThrow = throws[0];
            int secondThrow = throws[1];
            int frameTotal = firstThrow + secondThrow;
            int strikeBonus = frameTotal*2;

            int thirdThrow = 0;

            if (throws.Length > 2 && (firstThrow+secondThrow==10))
                thirdThrow = throws[2];
            
            // If input is invalid we are just going to ingore it
            if (frameTotal > 10)
            {
                if (frame < 10)
                {
                    // Initialize Score if it's the first frame
                    if (frame == 1)
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
                    else // There wasn't a strike 
                    {
                        if (strike) // Check for strike on previous frame
                            Score += strikeBonus;
                        else
                            Score += frameTotal;
                        // Reset Strike Marker
                        strike = false;
                    }
                    frame++;
                }
                else // 10th frames
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
                    
                    // Prepare for the end of the game and ask if the player would like to start a new game.
                    frame = 1;
                }
            }
        }
    }
}
