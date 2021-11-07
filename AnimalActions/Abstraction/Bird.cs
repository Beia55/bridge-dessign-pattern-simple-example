using AnimalActions.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions.Abstraction
{
    class Bird : Animal
    {
        public Bird(int eyeNo, int limbsNo, IMoveLogic iMoveLogic) 
            : base(eyeNo, limbsNo, iMoveLogic)
        {
        }

        public override void HowDoIMove()
        {
            Console.WriteLine("Bird move logic: " + base.MyLogicMove.Move());
        }
    }
}
