namespace MarsRover.Core.Commands.Interface
{
    public interface ICommand
    {
        void Run();
        bool IsMatchCommand(string command);
    }
}
