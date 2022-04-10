using MarsRover.Core.Commands.Interface;
using MarsRover.Core.Surface.Interface;
using System.Text.RegularExpressions;

namespace MarsRover.Core.Commands
{
    public class PlateauCommand: ICommand
    {
        private string command { get; set; }
        private IPlateau plateau;

        public PlateauCommand(IPlateau plateau, string command)
        {
            this.command = command;
            this.plateau = plateau;
        }

        public bool IsMatchCommand(string command)
        {
            return new Regex("^\\d+ \\d+$").IsMatch(command);
        }

        private void Initialize(string command)
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                if (IsMatchCommand(command))
                {
                    var split = command.Split(' ');
                    if (split.Length == 2)
                    {
                        if (int.TryParse(split[0], out int width))
                        {
                            if (int.TryParse(split[1], out int height))
                            {
                                plateau.SizeDefine(width, height);
                            }
                        }
                    }
                }
            }
        }

        public void Run()
        {
            Initialize(command);
        }
    }
}
