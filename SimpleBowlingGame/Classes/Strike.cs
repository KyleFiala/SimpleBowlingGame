using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class Strike : Frame
    {
        // Strike Constructor
        public Strike() : base(10, 0)
        {
        }

        // Add Strike Bonus override
        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            if (framePlusOne is Strike)
                _score += framePlusOne.FirstThrow() + framePlusTwo.FirstThrow();
            else
                _score += framePlusOne.FirstThrow() + framePlusOne.SecondThrow();
        }
    }
}
