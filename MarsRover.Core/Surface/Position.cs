using MarsRover.Core.Surface.Interface;
using MarsRover.Enums;

namespace MarsRover.Core.Surface
{
    public class Position: IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Position(int x = 0, int y= 0, Direction direction = Direction.N)
        {
            X = x;
            Y = y;
            Direction = direction;
        }
    }
}
