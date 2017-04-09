using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class SheildedInvader : Invader
    {
        public override int Health { get; protected set; } = 4;

        public SheildedInvader(Path path) : base(path)
        {

        }
        public override void DecreaseHelth(int factor)
        {
            if(Random.NextDouble() < .5)
            {
                base.DecreaseHelth(factor);
            }
            else
            {
                WriteLine("Shot at a sheilded invader but took no damage");
            }
        }
    }
}
