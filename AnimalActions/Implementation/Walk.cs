using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions.Implementation
{
    class Walk : IMoveLogic
    {
        public string Move()
        {
            return "constantly / alternately moving the limbs";
        }
    }
}
