using System;

namespace Command_Pattern
{
    // <summary>
    // Game is the receiver class.
    // </summary>
    public class Game
    {
        string gameName;
        public Game(string name)
        {
            this.gameName = name;
        }

        public void Start()
        {
            Console.WriteLine($"{gameName} is on.");
        }

        public void DisplayScore()
        {
            Console.WriteLine("The score is changing time to time.");
        }

        public void Finish()
        {
            Console.WriteLine($"---The game of {gameName} is over.---");
        }
    }
}