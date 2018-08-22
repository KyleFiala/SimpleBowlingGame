using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class Frame
    {
        protected int _firstRoll;
        protected int _secondRoll;
        protected int _score;

        //Constructor
        public Frame(int firstRoll, int secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        // Get Methods
        public int FirstRoll() {
            return _firstRoll;
        }

        public int SecondRoll()
        {
            return _secondRoll;
        }


        // Add Bonus Methods
        public virtual void AddBonus(Frame framePlusOne, Frame FramePlusTwo) { }

        public void AddBonus(int points)
        {
            _score += points;
        }
    }
}
