using System;
namespace SimpleBowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstThrow = 0;
            int secondThrow = 0;
            int thirdThrow = 0;


            Class.SimpleBowlingGame bowlingGame = new Class.SimpleBowlingGame();
            Console.WriteLine("Welcome to Kyle's Simple Bowling Game. Begin Scoring:");
            for (int i = 0; i < 11; i++)
            {
                firstThrow = 0;
                secondThrow = 0;

                Console.WriteLine("Please enter score for Frame " + bowlingGame.Frame);

                Console.Write("First Throw: ");
                firstThrow = Int32.Parse(Console.ReadLine());

                if(firstThrow != 10)
                {
                    Console.Write("Second Throw: ");
                    secondThrow = Int32.Parse(Console.ReadLine());
                }

                if (bowlingGame.Frame == 10)
                {
                    if(firstThrow + secondThrow >= 10)
                    {
                        Console.Write("Fill Ball Throw: ");
                        thirdThrow = Int32.Parse(Console.ReadLine());
                    }
                    bowlingGame.RecordFrame(new int[] {firstThrow, secondThrow, thirdThrow});

                    Console.WriteLine("\nFinal Score: " + bowlingGame.Score);
                    break;
                }
                else
                {
                    bowlingGame.RecordFrame(new int[] { firstThrow, secondThrow });
                }

                Console.WriteLine("Current Score: " + bowlingGame.Score);
                
            }
            Console.WriteLine("Thanks for playing press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
