using AnimalActions.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions
{
    class Client
    {
        public void ClientCode(Animal animal)
        {
            animal.HowDoIMove();
        }
    }
}
