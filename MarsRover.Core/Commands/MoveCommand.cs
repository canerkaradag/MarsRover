using MarsRover.Core.Commands.Interface;
using MarsRover.Core.Controls;
using MarsRover.Core.Controls.Interface;
using MarsRover.Core.Rovers;
using MarsRover.Core.Rovers.Interface;
using MarsRover.Enums;
using System.Text.RegularExpressions;
using System;

namespace MarsRover.Core.Commands
{
    public class MoveCommand : ICommand
    {
        private string command { get; set; }
        private ISquadManager squadManager;

        public MoveCommand(ISquadManager squadManager, string command)
        {
            this.command = command;
            this.squadManager = squadManager;
        }

        public bool IsMatchCommand(string command)
        {
            return new Regex("^[LMR]+$").IsMatch(command);
        }

        private void Move(string commands)
        {
            if (IsMatchCommand(commands))
            {
                var rover = squadManager.Active();
                foreach (var c in commands)
                {
                    if (Enum.TryParse(c.ToString(), out Movement movement))
                    {
                        Process(rover, movement);
                    }
                }
                Location(rover);
            }
        }

        private void Process(IRover rover, Movement movement)
        {
            if (IsCommandControl(movement, out IMoveControl moveControl))
            {
                rover.Move(moveControl);
            }
        }

        private bool IsCommandControl(Movement movement, out IMoveControl moveControl)
        {
            switch (movement)
            {
                case Movement.L:
                    moveControl = new LeftControl();
                    return true;
                case Movement.R:
                    moveControl = new RightControl();
                    return true;
                case Movement.M:
                    moveControl = new ForwardControl();
                    return true;
                default:
                    moveControl = null;
                    return false;
            }
        }

        private static void Location(Rover active)
        {
            Console.WriteLine(active.ToString());
        }

        public void Run()
        {
            Move(command);
        }
    }
}
