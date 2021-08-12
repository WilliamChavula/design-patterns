using System;

namespace Command_Pattern
{
    // <summary>
    // GameStartCommand
    // </summary>
    public class GameStartCommand : ICommand
    {
        private Game _game;

        public GameStartCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.Start();
            _game.DisplayScore();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing start command");
            _game.Finish();
        }
    }
}