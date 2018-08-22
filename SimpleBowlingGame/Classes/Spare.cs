using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class Spare : Frame
    {
        // Constructor
        public Spare(int firstThrow, int secondThrow) : base(firstThrow, secondThrow)
        {
        }

        // Add Spare Bonus override
        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _score += framePlusOne.FirstThrow();
        }
    }
}
