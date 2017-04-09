using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class FastTower : Tower
    {
        protected override int FireRate { get; } = 3;

        public FastTower (MapLocation location) : base(location)
        {

        }
    }
}
