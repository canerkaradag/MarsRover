using MarsRover.Core.Rovers.Interface;
using MarsRover.Core.Surface.Interface;
using System.Collections.Generic;
using System;

namespace MarsRover.Core.Rovers
{
    public class SquadManager : ISquadManager
    {
        private IPlateau plateau;
        private List<Rover> rovers;
        private Rover active;

        public SquadManager(IPlateau plateau)
        {
            this.plateau = plateau;
            this.rovers = new List<Rover>();
        }

        public Rover Active()
        {
            return active;
        }

        public void Deploy(IPosition position)
        {
            if (IsPointInside(position.X, position.Y))
            {
                var rover = new Rover(position, plateau, position.Direction);
                rovers.Add(rover);
                active = rover;
            }
            else
            {
                throw new Exception("Rover outside of bounds.");
            }
        }

        public List<Rover> Rovers()
        {
            return rovers;
        }

        private bool IsPointInside(int x, int y)
        {
            return x >= 0 && x < plateau.Size.Width && y >= 0 && y < plateau.Size.Height;
        }
    }
}
