﻿using MarsRover.Core.Controls.Interface;
using MarsRover.Core.Surface;
using MarsRover.Core.Surface.Interface;
using MarsRover.Enums;

namespace MarsRover.Core.Controls
{
    public class RightControl : IMoveControl
    {
        public IPosition Run(IPosition position, IPlateau plateau)
        {
            switch (position.Direction)
            {
                case Direction.N:
                    return new Position(position.X, position.Y, Direction.E);
                case Direction.S:
                    return new Position(position.X, position.Y, Direction.W);
                case Direction.E:
                    return new Position(position.X, position.Y, Direction.S);
                 default:
                    return new Position(position.X, position.Y, Direction.N);
            }
        }
    }
}
