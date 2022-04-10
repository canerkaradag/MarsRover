using MarsRover.Core.Controls.Interface;
using MarsRover.Core.Rovers.Interface;
using MarsRover.Core.Surface.Interface;
using MarsRover.Enums;

namespace MarsRover.Core.Rovers
{
    public class Rover : IRover
    {
        public IPosition Position { get; set; }
        public IPlateau Plateau { get; set; }
        public Direction Direction { get; set; }

        public Rover(IPosition position, IPlateau plateau, Direction direction)
        {
            Position = position;
            Plateau = plateau;
            Direction = direction;
        }

        public void Move(IMoveControl moveControl)
        {
            Position = moveControl.Run(Position, Plateau);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Position.X, Position.Y, Position.Direction);
        }
    }
}
