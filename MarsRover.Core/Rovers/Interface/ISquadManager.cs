using MarsRover.Core.Surface.Interface;
using System.Collections.Generic;

namespace MarsRover.Core.Rovers.Interface
{
    public interface ISquadManager
    {
        List<Rover> Rovers();

        Rover Active();

        void Deploy(IPosition position);
    }
}
