using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriseldaExample
{
    class Griseldamember : Rapper
    {
        string _name;
        public Griseldamember(string name)
        {
            _name = name;
            haveBars = true;
            canSing = false;
        }
    }
}
