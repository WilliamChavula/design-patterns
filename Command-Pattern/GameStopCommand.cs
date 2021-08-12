using System;

namespace Command_Pattern
{
    // <summary>
    // GameStopCommand
    // </summary>
    public class GameStopCommand : ICommand
    {
        private Game _game;

        public GameStopCommand(Game game)
        {
            _game = game;   
        }
        public void Execute()
        {
            Console.WriteLine("Finishing the game.");
            _game.Finish();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing the stop command");
            _game.Start();
            _game.DisplayScore();
        }
    }
}