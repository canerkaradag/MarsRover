using MarsRover.Core.Controls.Interface;
using MarsRover.Core.Surface;
using MarsRover.Core.Surface.Interface;
using MarsRover.Enums;

namespace MarsRover.Core.Controls
{
    public class ForwardControl : IMoveControl
    {
        public IPosition Run(IPosition position, IPlateau plateau)
        {
            switch (position.Direction)
            {
                case Direction.N:
                    position.Y = (position.Y + 1 <= plateau.Size.Height) ? position.Y += 1 : 0;
                    return new Position(position.X, position.Y, position.Direction);
                case Direction.S:
                    position.Y = (position.Y - 1 >= 0) ? position.Y -= 1 : 0;
                    return new Position(position.X, position.Y, position.Direction);
                case Direction.E:
                    position.X = (position.X + 1 <= plateau.Size.Width) ? position.X += 1 : 0;
                    return new Position(position.X, position.Y, position.Direction);
                default:
                    position.X = (position.X - 1 >= 0) ? position.X -= 1 : 0;
                    return new Position(position.X, position.Y, position.Direction);
            }
        }
    }
}
