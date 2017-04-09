using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    // are used to contain code that should be shared by the concrete sub class 
    abstract class Invader : IInvader
    {

        private readonly Path _path;

        private int _pathStep = 0;

        protected virtual int stepSize { get; } = 1;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public abstract int Health { get; protected set; } 

        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }
        public virtual void Move() => _pathStep += stepSize;

        public virtual void DecreaseHelth(int factor)
        {
            Health -= factor;
            WriteLine("Shot at and hit an invader! ");
        }

    }
}
