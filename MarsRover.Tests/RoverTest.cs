using MarsRover.Core.Commands;
using MarsRover.Core.Rovers;
using MarsRover.Core.Surface.Plateau;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class RoverTest
    {
        [Test]
        public void FirstRoverTest()
        {          
            var command = new Command();

            var plateau = new Plateau();

            var squadManager = new SquadManager(plateau);

            var plateauCommand = new PlateauCommand(plateau, "5 5");
            command.Send(plateauCommand);

            var roverCommand = new RoverCommand(squadManager, "1 2 N");
            command.Send(roverCommand);

            var moveCommand = new MoveCommand(squadManager, "LMLMLMLMM");
            command.Send(moveCommand);

            var position = squadManager.Active().Position;

            Assert.NotNull(plateau);
            Assert.NotNull(command);
            Assert.NotNull(squadManager);
            Assert.AreEqual(string.Format("{0} {1} {2}", position.X, position.Y, position.Direction), "1 3 N");
        }

         [Test]
         public void SecondRoverTest()
         {            
            var command = new Command();

            var plateau = new Plateau();

            var squadManager = new SquadManager(plateau);

            var plateauCommand = new PlateauCommand(plateau, "5 5");
            command.Send(plateauCommand);

            var roverCommand = new RoverCommand(squadManager, "3 3 E");
            command.Send(roverCommand);

            var moveCommand = new MoveCommand(squadManager, "MMRMMRMRRM");
            command.Send(moveCommand);

            var position = squadManager.Active().Position;

            Assert.NotNull(plateau);
            Assert.NotNull(command);
            Assert.NotNull(squadManager);
            Assert.AreEqual(string.Format("{0} {1} {2}", position.X, position.Y, position.Direction), "5 1 E");
        }
    }
}