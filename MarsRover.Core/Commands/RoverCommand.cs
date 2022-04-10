using MarsRover.Core.Commands.Interface;
using MarsRover.Core.Rovers.Interface;
using MarsRover.Core.Surface;
using MarsRover.Core.Surface.Interface;
using MarsRover.Enums;
using System;
using System.Text.RegularExpressions;

namespace MarsRover.Core.Commands
{
    public class RoverCommand : ICommand
    {
        private string command { get; set; }
        private ISquadManager squadManager;
        private IPosition position;

        public RoverCommand(ISquadManager squadManager, string command)
        {
            this.command = command;
            this.squadManager = squadManager;
        }

        public bool IsMatchCommand(string command)
        {
            return new Regex("^\\d+ \\d+ [NSWE]$").IsMatch(command);
        }

        private void Initialize(string command)
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                if (IsMatchCommand(command))
                {
                    var split = command.Split(' ');
                    if (split.Length == 3)
                    {
                        if (int.TryParse(split[0], out int x) &&
                            int.TryParse(split[1], out int y) &&
                            Enum.TryParse(split[2], out Direction direction))
                        {
                            position = new Position(x, y, direction);
                            squadManager.Deploy(position);
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
