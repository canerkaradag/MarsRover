using MarsRover.Core.Commands.Interface;

namespace MarsRover.Core.Commands
{
    public class Command
    {
        public void Send(ICommand command)
        {
            command.Run();
        }
    }
}
