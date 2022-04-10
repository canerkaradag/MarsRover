using MarsRover.Enums;

namespace MarsRover.Core.Surface.Interface
{
    public interface IPosition
    {
        int X { get; set; }
        int Y { get; set; }
        Direction Direction { get; set; }
    }
}
