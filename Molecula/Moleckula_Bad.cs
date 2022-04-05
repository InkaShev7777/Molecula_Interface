using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Moleckula_Bad:Base_Moleckula
    {
        public Moleckula_Bad(double mass):base(mass)
        {
            eat = new Eat_Moleckule();
            behavior = new Behavior_Attack();
            move = new Fast();
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
