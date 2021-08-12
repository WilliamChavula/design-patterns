using System;

namespace Command_Pattern
{
    // <summary>
    // Client code
    // </summary>
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Command Pattern Demonstration***\n");
            
            // Client holds both the Invoker and Command Objects
            RemoteControl invoker = new RemoteControl();

            Game gameName = new Game("Golf");

            // Command to start the game
            GameStartCommand gameStartCommand = new GameStartCommand(gameName);

            // Command to stop the game
            GameStopCommand gameStopCommand = new GameStopCommand(gameName);

            Console.WriteLine("**Starting the game and performing undo immediately**");
            invoker.SetCommand(gameStartCommand);
            invoker.ExecuteCommand();

            // Performing undo operation
            Console.WriteLine("\nUndoing the previous command now");
            invoker.UndoCommand();

            Console.WriteLine("**Starting the game again. Then stopping it and undoing the stop operation.**");
            invoker.SetCommand(gameStartCommand);
            invoker.ExecuteCommand();

            // Stop command to finish the game
            invoker.SetCommand(gameStopCommand);
            invoker.ExecuteCommand();

            // Performing undo operation
            Console.WriteLine("\nUndoing the previous command now.");
            invoker.UndoCommand();

            Console.ReadKey();
        }
    }
}
