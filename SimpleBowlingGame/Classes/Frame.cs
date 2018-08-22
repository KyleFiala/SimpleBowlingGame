using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class Frame
    {
        protected int _firstThrow;
        protected int _secondThrow;
        protected int _score;

        //Constructor
        public Frame(int firstThrow, int secondThrow)
        {
            _firstThrow = firstThrow;
            _secondThrow = secondThrow;
        }

        // Method to return wether Frame was Open a Spare or Strike
        public static Frame Generate(int firstThrow, int secondThrow)
        {
            if (firstThrow == 10)
                return new Strike();

            if ((firstThrow + secondThrow) == 10)
                return new Spare(firstThrow, secondThrow);

            return new Open(firstThrow, secondThrow);
        }

        // Method to return the Final Frame
        public static Frame Generate(int firstThrow, int secondThrow, int thirdThrow)
        {
            return new FinalFrame(firstThrow, secondThrow, thirdThrow);
        }


        //return the score of the frame.
        public int Score() {
            return _score + FirstThrow() + SecondThrow(); 
        }

        // Get Methods
        public int FirstThrow() {
            return _firstThrow;
        }

        public int SecondThrow()
        {
            return _secondThrow;
        }


        // Add Bonus Methods
        public virtual void AddBonus(Frame framePlusOne, Frame FramePlusTwo) { }

        public void AddBonus(int points)
        {
            _score += points;
        }
    }
}
