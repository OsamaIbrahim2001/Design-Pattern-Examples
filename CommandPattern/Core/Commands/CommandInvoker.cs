namespace CommandPattern.Core.Commands
{
    internal class CommandInvoker
    {
        private List<ICommand> commands = new();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void ExecudCommands() {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
