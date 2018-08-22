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
                _score += framePlusOne.FirstRoll() + framePlusTwo.FirstRoll();
            else
                _score += framePlusOne.FirstRoll() + framePlusOne.SecondRoll();
        }
    }
}
