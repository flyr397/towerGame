using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable, IMovable
    {
         int Health { get; }

        // True if the invader has reached the end of the path
          bool HasScored { get; }

          bool IsNeutralized { get; }

          bool IsActive { get; }

          void DecreaseHelth(int factor);

    }
}
