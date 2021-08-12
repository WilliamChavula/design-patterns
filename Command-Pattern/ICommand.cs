namespace Command_Pattern
{
    // <summary>
    // The command interface
    // </summary>
    public interface ICommand
    {
        //  To execute a command
        void Execute();

        // To undo last command execution
        void Undo();
    }
}