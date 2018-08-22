using System;

namespace SimpleBowlingGame
{
    // This program is just a quick shotty interface to test the accuracy of the Methods in SimpleBowlingGame.
    class Program
    {
        static void Main(string[] args)
        {
            Classes.SimpleBowlingGame simpleBowlingGame = new Classes.SimpleBowlingGame();
            int frameCount = 1;
            int throwOne = 0;
            int throwTwo = 0;
            int throwThree = 0;


            for (int i = 0; i <= 10; i++)
            {

                if (frameCount < 10)
                {
                    Console.WriteLine("Throws for Frame " + frameCount);
                    Console.WriteLine("Throw 1: ");
                    throwOne = Int32.Parse(Console.ReadLine());
                    if(throwOne < 10)
                    {
                        Console.WriteLine("Throw 2: ");
                        throwTwo = Int32.Parse(Console.ReadLine());
                    }

                    simpleBowlingGame.RecordFrame(new int[] { throwOne, throwTwo });
                }
                else if (frameCount == 10)
                {
                    Console.WriteLine("Throws for Frame " + frameCount);
                    Console.WriteLine("Throw 1: ");
                    throwOne = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Throw 2: ");
                    throwTwo = Int32.Parse(Console.ReadLine());

                    if(throwOne + throwTwo >= 10)
                    {
                        Console.WriteLine("Throw 3: ");
                        throwThree = Int32.Parse(Console.ReadLine());
                    }

                    simpleBowlingGame.RecordFrame(new int[] { throwOne, throwTwo, throwThree });
                }
                frameCount++;
            }
            Console.WriteLine("Final Score: " + simpleBowlingGame.Score());
            Console.WriteLine("Game Complete, Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
