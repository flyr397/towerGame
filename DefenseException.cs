using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class DefenseException : Exception
    {
        public DefenseException()
        {

        }

        public DefenseException(string message) : base( message)
        {

        }
    }
}
