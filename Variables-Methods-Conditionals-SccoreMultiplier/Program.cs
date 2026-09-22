using System;

namespace Variables_Methods_Conditionals_SccoreMultiplier
{
    internal class Program
    {
        static int currentScore;
        static int currentScoreMultiplier;

        static void Main()
        {
            currentScore = 0; 
            currentScoreMultiplier = 1;

            HUD();
            AddScore(5);

            AddScoreWithMultiplier(5);
            HUD();

            //change to be two methods one has multiplier in it all the time
            //and one only changes the multpilier itself
        }

        static void AddScore(int incomingPoints)
        {
            currentScore = currentScore + incomingPoints;
            Console.WriteLine("\nYou scored " + incomingPoints + " points.");
        }

        static void HUD()
        {
            Console.WriteLine("\n---The HUD!---");
            Console.WriteLine("Score: " + currentScore);
        }

        static void AddScoreWithMultiplier(int incomingPoints)
        {
            currentScore = currentScore + incomingPoints * currentScoreMultiplier;
            Console.WriteLine("\nYou scored " + (incomingPoints * currentScoreMultiplier) + " (" + incomingPoints + "*" + currentScoreMultiplier + ") points.");
        }
    }
}
