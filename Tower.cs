using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;
        protected virtual int FireRate { get; } = 2;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHelth(Power);


                        if (invader.IsNeutralized)
                        {
                            WriteLine("Neutralized Invader!!! at  " +invader.Location);
                        }
                    }
                    else
                    {
                        WriteLine("Shot at and missed an invader. ");
                    }
                    break;
                }

            }
        }
    }
}
