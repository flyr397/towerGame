using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 1.0;

        protected override int Range { get; } = 2;

        public SniperTower (MapLocation location) : base(location)
        {

        }
    }
}
