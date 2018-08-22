using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class FinalFrame : Frame
    {
        private int _thirdThrow;

        public FinalFrame(int firstThrow, int secondThrow, int thirdThrow) : base(firstThrow, secondThrow)
        {
            _thirdThrow = thirdThrow;
        }

        public int ThirdThrow()
        {
            return _thirdThrow;
        }

        public override void AddBonus(Frame framePlusOne, Frame framePlusTwo)
        {
            _score += _thirdThrow;
        }
    }
}
