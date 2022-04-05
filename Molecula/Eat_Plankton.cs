using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Eat_Plankton:IEat
    {
        public Eat_Plankton(){}
        public void Eat()
        {
            Console.WriteLine("I eat planckton");
        }
    }
}
