using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Base_Moleckula
    {
        double Mass;
        protected IEat eat;
        protected IBehavior behavior;
        protected IMove move;
        public Base_Moleckula(double mass)
        {
            Mass = mass;
        }
        public virtual void Eat(){}
        public virtual void Behavior() {}
        public virtual void Move() {}
        
    }
}
