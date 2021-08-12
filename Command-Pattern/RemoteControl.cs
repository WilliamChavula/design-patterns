namespace Command_Pattern
{
    // <summary>
    // Invoker class
    // </summary>
    public class RemoteControl
    {
        ICommand commandToBePerformed, lastCommandPerformed;
        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }

        public void ExecuteCommand()
        {
            commandToBePerformed.Execute();
            lastCommandPerformed = commandToBePerformed;
        }

        public void UndoCommand()
        {
            // Undo the last command
            lastCommandPerformed.Undo();
        }
    }
}