using MarsRover.Core.Commands;
using MarsRover.Core.Rovers;
using MarsRover.Core.Surface.Plateau;
using System;

namespace MarsRover.Application
{
    class Program
    {
        static void Main(string[] args)
        {           
            var command = new Command();

            var plateau = new Plateau();

            var squadManager = new SquadManager(plateau);

            var plateauCommand = new PlateauCommand(plateau, "5 5");
            command.Send(plateauCommand);

           var roverCommand = new  RoverCommand(squadManager, "1 2 N");
            command.Send(roverCommand);

            var moveCommand = new MoveCommand(squadManager, "LMLMLMLMM");
            command.Send(moveCommand);

            roverCommand = new RoverCommand(squadManager, "3 3 E");
            command.Send(roverCommand);

            moveCommand = new MoveCommand(squadManager, "MMRMMRMRRM");
            command.Send(moveCommand);

            Console.ReadKey();
        }
    }
}
