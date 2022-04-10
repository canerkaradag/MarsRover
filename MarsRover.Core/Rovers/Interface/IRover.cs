using MarsRover.Core.Controls.Interface;

namespace MarsRover.Core.Rovers.Interface
{
    public interface IRover
    {
        void Move(IMoveControl moveControl);
    }
}
