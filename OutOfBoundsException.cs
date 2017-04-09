using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TowerDefense
{
    class OutOfBoundsException : DefenseException
    {
      public OutOfBoundsException()
        {

        }

      public  OutOfBoundsException(string message) : base( message)
        {

        }
    }
}
