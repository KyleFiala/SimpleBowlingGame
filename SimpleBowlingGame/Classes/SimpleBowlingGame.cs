using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBowlingGame.Classes
{
    public class SimpleBowlingGame : ISimpleBowlingGame
    {

        private List<Frame> _frames = new List<Frame>();

        public int Score() {
            _frames.Add(new Open(0, 0));
            _frames.Add(new Open(0, 0));

			for (int i = 0; i< 10; i++)
				_frames[i].AddBonus(_frames[i + 1], _frames[i + 2]);

            int counter = 0;
            _frames.ForEach(frame => counter += frame.Score());

		    return counter;
    }

    public void RecordFrame(params int[] throws)
        {
            if (!GameOver())
            {
                if (_frames.Count != 9)
                    _frames.Add(Frame.Generate(throws[0], throws[1]));
                else if (_frames.Count == 9 && throws.Length > 2)
                    _frames.Add(Frame.Generate(throws[0], throws[1], throws[2]));
                else
                    _frames.Add(Frame.Generate(throws[0], throws[1]));
            }
            else
            {
                throw new Exception("Game is Over...");
            }
        }

        private bool GameOver()
        {
            return _frames.Count.Equals(10);
        }
    }
}
