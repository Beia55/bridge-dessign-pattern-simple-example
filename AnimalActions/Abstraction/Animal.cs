using AnimalActions.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalActions.Abstraction
{
    public abstract class Animal
    {
        public int EyeNo { get; set; }

        public int LimbsNo { get; set; }

        public IMoveLogic MyLogicMove;

        public Animal(int eyeNo, int limbsNo, IMoveLogic iMoveLogic)
        {
            this.EyeNo = eyeNo;
            this.LimbsNo = limbsNo;
            this.MyLogicMove = iMoveLogic;
        }

        public abstract void HowDoIMove();
    }
}
