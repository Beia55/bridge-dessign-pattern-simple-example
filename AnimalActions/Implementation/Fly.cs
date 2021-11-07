using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions.Implementation
{
    class Fly : IMoveLogic
    {
        public string Move()
        {
           return "constantly moving its wings";
        }
    }
}
