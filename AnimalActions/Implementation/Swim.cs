using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions.Implementation
{
    class Swim: IMoveLogic
    {
        public string Move()
        {
            return "propel the body through water by using the limbs or the fins";
        }
    }
}
