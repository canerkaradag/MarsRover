using MarsRover.Core.Surface.Interface;

namespace MarsRover.Core.Controls.Interface
{
    public interface IMoveControl
    {
        IPosition Run(IPosition position,IPlateau plateau);
    }
}
