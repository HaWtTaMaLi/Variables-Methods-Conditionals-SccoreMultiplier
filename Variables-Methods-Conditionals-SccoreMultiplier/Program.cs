using System;

namespace Variables_Methods_Conditionals_SccoreMultiplier
{
    internal class Program
    {
        static int currentScore;
        static int currScoreMulti;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            currentScore = 0; 
            currScoreMulti = 1;

            Console.WriteLine("Score Multiplier: " + currScoreMulti);
            HUD();
            AddScoreWithMultiplier(5);
            HUD();
            IncreaseScoreMultiplier();
            HUD();
            AddScoreWithMultiplier(10);

            HUD();
            AddScoreWithMultiplier(20);
            HUD();
            IncreaseScoreMultiplier();
            HUD();
            AddScoreWithMultiplier(30);

            HUD();
            AddScoreWithMultiplier(15);
            HUD();
            IncreaseScoreMultiplier();
            HUD();
            AddScoreWithMultiplier(5);
            HUD();
        }

        static void AddScoreWithMultiplier(int incomingPoints)
        {
            //change to be two methods one has multiplier in it all the time
            Console.WriteLine("\nThe Math: " + currentScore + " +(" + incomingPoints + "x" + currScoreMulti + ")");
            currentScore = currentScore + incomingPoints * currScoreMulti;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You Scored " + incomingPoints + "pts.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void IncreaseScoreMultiplier()
        {
            //and one only changes the multpilier itself
            Console.ForegroundColor = ConsoleColor.Green;
            currScoreMulti++;
            Console.WriteLine("\nIncrease Multiplier: "+currScoreMulti);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void HUD()
        {
            Console.WriteLine("\n---The HUD!---");
            Console.WriteLine("Score: " + currentScore);
        }
    }
}
