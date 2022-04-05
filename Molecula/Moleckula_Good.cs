using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Moleckula_Good:Base_Moleckula
    {
        public Moleckula_Good(double mass):base(mass)
        {
            eat = new Eat_Plankton();
            behavior = new Behavior_Run();
            move = new Slow();
        }
        public override void Eat()
        {
            eat.Eat();
        }
        public override void Behavior()
        {
            this.behavior.behhevior();
        }
        public override void Move()
        {
            move.Go_Forward();
            move.Go_Back();
            move.Go_Left();
            move.Go_Right();
        }
    }
}
