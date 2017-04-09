using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class ResurectingInvader : IInvader
    {
        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;
        private FastInvader _incarnation3;
        private SheildedInvader _incarnation4;

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        public int Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

        // True if the invader has reached the end of the path
        public bool HasScored => _incarnation1.HasScored || _incarnation1.HasScored;

        public bool IsNeutralized => _incarnation1.IsNeutralized ? _incarnation2.IsNeutralized : _incarnation1.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        public ResurectingInvader (Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
            _incarnation3 = new FastInvader(path);
            _incarnation4 = new SheildedInvader(path);

        }

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }

        public void DecreaseHelth(int factor)
        {
            if (!_incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHelth(factor);
            }
            else
                _incarnation2.DecreaseHelth(factor);
        }


    }
}
