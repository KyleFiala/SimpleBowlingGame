using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    class FinalFrame : Frame
    {
        private int _thirdRoll;

        public FinalFrame(int firstRoll, int secondRoll, int thirdRoll) : base(firstRoll, secondRoll)
        {
            _thirdRoll = thirdRoll;
        }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _score += _thirdRoll;
        }
    }
}
