using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense 
{
    class PowerTower : Tower
    {
        protected override int Power { get; } = 3;

        protected override int Range { get; } = 1;

        public PowerTower (MapLocation location) : base(location)
        {

        }
    }
}
